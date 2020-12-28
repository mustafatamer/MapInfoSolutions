using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EDABIS2.BusinessMapInfo.Core.ObjectReferences;
using EDABIS2.MapInfoHelper;
using EDABIS2.Utils.Classes.StringSystem;

using MapInfo.Types;

namespace WindowsFormsApp
{
    public class TestEdabis
    {

        public TestEdabis()
        {
            var PASS = decrypt("t2IxC4N7k94jxMzQ9iRysw==");
            var USERID = decrypt("lJjCjKK7VHD / rotKFzYW8Q ==");
            var UAVTDATASOURCE = decrypt("+gtYdPAVwIx8a0+JjGOepA==");
            var UAVTUSERID = decrypt("YIi3H+/w1sI=");
            var EDABIS_UAVT_PASSWORD = decrypt("NYi7Poti3TF7dkDue54MFQ ==");
            var EDABIS_UAVT_DATABASE_TYPE = decrypt("KoMFXtWZYy4 =");

            int windowId = MapInfoClass.Instance.GetActiveWindowId("Form1");

            ObjectShowMap(@"select * from SBK_SDK where SDK_NO = ""B0042""", "TEMPSBK_SDK", "\\", windowId, 50m, true, "SBK_SDK");
        }



        public static string decrypt(string message)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes("Edabis@123"));
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
            desalg.Key = deskey;
            desalg.Mode = CipherMode.ECB;
            desalg.Padding = PaddingMode.PKCS7;
            byte[] decrypt_data = Convert.FromBase64String(message);
            byte[] results;
            try
            {
                results = desalg.CreateDecryptor().TransformFinalBlock(decrypt_data, 0, decrypt_data.Length);
            }
            finally
            {
                desalg.Clear();
                md5.Clear();
            }
            return utf8.GetString(results);
        }



        public void ObjectShowMap(string sqlquery, string tempTableName, string filePath, int windowId, decimal zoomRate, bool zoomEntireBase, string tableName, string attribute = "", string subAttribute = "")
        {
            try
            {
                bool zoomEntire = false;
                bool flag = true;
                zoomEntire = zoomEntireBase;
            //    MapInfoClass.Instance.miTable.IsTableOpenCloseTable(tempTableName);
                string tempDirectory = "\\";

                if (tableName.StartsWith("DEM_") && !tempTableName.StartsWith("SEL_"))
                {
                    if (MapInfoClass.Instance.miTable.TableRowCount(tableName) == 0m)
                    {
                        //SessionEdabisBusiness.Instance.SessionMainForm.ShowMessage(Lang.Instance.GetString("BusinessMapInfo.Core.ObjectReferences.ObjectReference.MessageNoRecord.Text"), MessageType.Warning);
                        return;
                    }
                    MapInfoClass.Instance.Do("Add Map Window " + windowId + " Layer " + tableName);
                    if (zoomEntire)
                    {
                        MapInfoClass.Instance.Do("Set Map Window " + windowId + " Zoom Entire Layer " + tableName);
                        MapInfoClass.Instance.Do("Set Map Window " + windowId + " Zoom " + zoomRate.ConvertSQLString());
                        MapInfoClass.Instance.Do("Set Map Window " + windowId + " Layer " + tableName + " Display Graphic ");
                    }
                }
                else
                {
                    //if (string.IsNullOrEmpty(tempTableName) || !(MapInfoClass.Instance.miTable.TableRowCount(tempTableName) != 0m))
                    //{
                    //    return;
                    //}
                    MapInfoClass.Instance.Do(sqlquery + " into " + tempTableName);
                    string oFoundQ = "Select * From " + tempTableName + " Where Not Obj Into sel_ONotFound";
                    MapInfoClass.Instance.Do(oFoundQ);
                    if (MapInfoClass.Instance.miTable.TableRowCount("sel_ONotFound") == 0m)
                    {
                        string styleId = MapInfoClass.Instance.Eval("ObjectInfo(" + tempTableName + ".Obj,1)");
                        if (styleId == 7.ToString())
                        {
                            MapInfoClass.Instance.miTable.IsTableOpenCloseTable("selQuery");
                            MapInfoClass.Instance.Do("Commit Table " + tempTableName + " As \"" + filePath + "\\selQuery.TAB\"");
                            MapInfoClass.Instance.Do("Open Table \"" + filePath + "\\selQuery.TAB\"");
                            MapInfoClass.Instance.Do("update selQuery set obj=createpoint(centroidx(obj),centroidy(obj))");
                            MapInfoClass.Instance.Do($"commit table selQuery");
                            tempTableName = "selQuery";
                        }
                        string styleAttribute = "";
                        if (!string.IsNullOrEmpty(attribute))
                        {
                        }
                        styleAttribute = ((!(styleAttribute == "")) ? (" Global " + styleAttribute) : GetQueryObjectStyle(tempTableName));
                        ObjectTypeEnum objectType = GetQueryObjectType(tempTableName);
                        if (objectType == ObjectTypeEnum.OBJ_TYPE_LINE || objectType == ObjectTypeEnum.OBJ_TYPE_PLINE || objectType == ObjectTypeEnum.OBJ_TYPE_MPOINT || objectType == ObjectTypeEnum.NONE)
                        {
                            if (zoomEntireBase)
                            {
                                zoomEntire = true;
                            }
                        }
                        else if (MapInfoClass.Instance.miTable.TableRowCount("sel_ONotFound") != 1m)
                        {
                            zoomEntire = false;
                        }
                        MapInfoClass.Instance.Do("Add Map Window " + windowId + " Layer " + tempTableName);
                        MapInfoClass.Instance.Do("Set Map Window " + windowId + " Zoom Entire Layer " + tempTableName);
                        if (!zoomEntire)
                        {
                            MapInfoClass.Instance.Do("Set Map Window " + windowId + " Zoom " + zoomRate.ConvertSQLString());
                        }
                        MapInfoClass.Instance.Do("Set Map Window " + windowId + " Layer " + tempTableName + " Display Global " + styleAttribute);
                    }
                    else
                    {
                        MessageBox.Show("Obje Bulunamadı..!");
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("EDBS-ERR-002-000-173", ex);
            }
            finally
            {
                MapInfoClass.Instance.miTable.IsTableOpenCloseTable("sel_ONotFound");
            }
        }


        public string GetQueryObjectStyle(string tableName)
        {
            string stylestr = string.Empty;
            try
            {
                string styleId = MapInfoClass.Instance.Eval("objectinfo(" + tableName + ".obj,1)");
                if (styleId == 3.ToString() || styleId == 4.ToString())
                {
                    stylestr = "  Global  line  (7, 2, 4227327)";
                }
                else if (styleId == 5.ToString())
                {
                    stylestr = " Global Symbol (\"PINB-64.BMP\",0,15,0)";
                }
                else if (styleId == 7.ToString())
                {
                    stylestr = "  Global  Pen  (3,64,10526975)   Global Brush (01,10526975,12632319) ";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("EDBS-ERR-002-000-932", ex);
            }
            return stylestr;
        }

        public ObjectTypeEnum GetQueryObjectType(string tableName)
        {
            ObjectTypeEnum valType = ObjectTypeEnum.NONE;
            try
            {
                string styleId = MapInfoClass.Instance.Eval("ObjectInfo(" + tableName + ".Obj,1)");
                if (styleId == 3.ToString() || styleId == 4.ToString())
                {
                    valType = ObjectTypeEnum.OBJ_TYPE_LINE;
                }
                else if (styleId == 5.ToString())
                {
                    valType = ObjectTypeEnum.OBJ_TYPE_POINT;
                }
                else if (styleId == 7.ToString())
                {
                    valType = ObjectTypeEnum.OBJ_TYPE_REGION;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("EDBS-ERR-002-000-932", ex);
            }
            return valType;
        }

        [Flags]
        public enum ObjectTypeEnum
        {
            NONE = 0x0,
            OBJ_TYPE_ARC = 0x1,
            OBJ_TYPE_ELLIPSE = 0x2,
            OBJ_TYPE_LINE = 0x3,
            OBJ_TYPE_PLINE = 0x4,
            OBJ_TYPE_POINT = 0x5,
            OBJ_TYPE_FRAME = 0x6,
            OBJ_TYPE_REGION = 0x7,
            OBJ_TYPE_RECT = 0x8,
            OBJ_TYPE_ROUNDRECT = 0x9,
            OBJ_TYPE_TEXT = 0xA,
            OBJ_TYPE_MPOINT = 0xB,
            OBJ_TYPE_COLLECTION = 0xC,
            NoObject = 0xD
        }

    }
}
