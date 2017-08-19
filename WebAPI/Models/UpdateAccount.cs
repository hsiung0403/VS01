using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebAPI.Models
{
    public class UpdateAccount
    {
        public static void updateDept(DataTable dt)
        {
            if (checkvalue(dt))
            {
                //
                string[] arrSQL = new string[dt.Rows.Count];

                for (int r = 0; r <= dt.Rows.Count - 1; r++)
                {
                    string s0 = Convert.ToString(dt.Rows[r][0]);
                    string s1 = Convert.ToString(dt.Rows[r][1]);
                    string s2 = Convert.ToString(dt.Rows[r][2]);
                    string sql = "";
                    string g = Guid.NewGuid().ToString().Trim();
                    // A0FD084B-BAB5-4A0D-BD94-D451CD638A17
                    sql = " Insert Into comDepartment (DepartName,EngName,Memo,Male,Female,JobSch,MergeOutState,UsePerms,";
                    sql += " SalaryTypeID,HrmJobSchID,YanChangIndex,IsOverTimeApp,ReportCompID,ParentID,RealID,CalID,IsStoped,GUID,DepartID)";
                    sql += " Values ('" + s1 + "','" +s2+ "','',0,0,'',0,0,'','',0,0,'','','00B','',0,'" + g.ToUpper() + "','" +s0 + "')";
                    arrSQL[r] = sql;
                }
                DBAccess.DBCommon.sqlsend(arrSQL);
                
            }

            
        }

        public static void updateCustomer(DataTable dt)
        {
            if (checkvalue(dt))
            {
                //
                List<string> arrSQL = new List<string>();

                for (int r = 0; r <= (dt.Rows.Count) - 1; r++)
                {
                    string s0 = Convert.ToString(dt.Rows[r][0]);
                    string s1 = Convert.ToString(dt.Rows[r][1]);
                    string s2 = Convert.ToString(dt.Rows[r][2]);
                    string s3 = Convert.ToString(dt.Rows[r][3]);
                    string s4 = Convert.ToString(dt.Rows[r][4]);
                    string s5 = Convert.ToString(dt.Rows[r][5]);
                    //string s6 = Convert.ToString(dt.Rows[r][6]);
                    string sql = "";
                    string g = Guid.NewGuid().ToString().Trim();
                    // A0FD084B-BAB5-4A0D-BD94-D451CD638A17
                    sql = "Insert Into comCustomer (FundsAttribution,FullName,ShortName,ClassID,AreaID,CurrencyID,IsTemp,IsForeign,TaxNo,ChiefName,Capitalization,LinkMan,LinkManProf,Telephone1,Telephone2,Telephone3,MobileTel,FaxNo,Moderm,IndustrialClass,PersonID,Email,WebAddress,MergeOutState,ServerID,DealerID,PriceofTax,DirectCust,VIP,VIPLevel,DataVer,MemberCodeNo,MembercodeDate,IdentityNO,MaritalStatus,SexDistinction,Metier,NativePlace,NativeAddress,FamilyAddress,ZipCode,InvoiceHead,GatherOther,CheckOther,InvoTax,UsePerms,SrcID,SrcName,GUID,ElectronInvoice,Hqh,Hqw,Sjq,HqDate,BToBOrToC,IdentifyNo,EIStoreTypeGLN,EIStoreNo,EICourseType,EIStoreTypeGLN1,EIUsePapInvoice,EIPageType,Flag,ID) Values ";
                    sql += " ('"+s1.Trim()+"','"+s2.Trim()+"','"+s3.Trim()+"','','','NTD',0,0,'','',0,'','','','','','','','','','A0001','','',0,'','',0,0,0,'',2,'',0,'',0,0,'','','','','','TEST K008','','',0,0,1,'','"+g.Trim()+"',0,'','','',0,0,'','','','','',0,0,1,'"+s1.Trim()+"')";                    
                    if (Convert.ToInt32(s0) == 2)
                    {
                        sql =" Insert Into comCustomer (FundsAttribution,ClassID,AreaID,CurrencyID,FullName,IsTemp,IsForeign,TaxNo,ShortName,ChiefName,Capitalization,LinkMan,LinkManProf,Telephone1,Telephone2,Telephone3,MobileTel,PersonID,Moderm,FaxNo,IndustrialClass,Email,WebAddress,MergeOutState,IsFactory,PriceofTax,InvoiceHead,GatherOther,CheckOther,InvoTax,UsePerms,PlanPerson,GUID,Flag,ID) Values" ;
                        sql += " ('" + s1.Trim() + "','','','NTD','" + s2.Trim() + "',0,0,'','" + s3.Trim() + "','',0,'','','','','','','A0001','','','','','',0,0,0,'CS006','','',0,0,'A0001','38FFBDC7-92FC-4CCB-AC1F-CFA037077742'," + s0.Trim() + ",'" + s1.Trim() + "')";
                    }
                    arrSQL.Add(sql);
                    //
                    sql = "Insert Into comCustDesc (EngFullName,EngShortName,EngLinkMan,EngLinkManProf,EngWayOfRecv,EngWayOfDeliv,AccCommi,AccCommiPaied,AddrID,Memo,TypeOfBillExpire,DaysOfBillExpire,PriceRank,RateOfDiscount,AddField1,AddField2,DeliverAddrID,EngAddrID,DelivZoneNo,AddrOfInvo,Flag,ID) Values ('','','','','','','','','','',0,0,0,1,'','','','','','',"+s0.Trim()+",'"+s1.Trim()+"')";
                    arrSQL.Add(sql);
                    //
                    sql = " Insert Into comCustTrade (EarliestTradeDate,FirstTradeDate,LatelyTradeDate,LatelyReturnDate,FinalTradeDate,InvoiceType,TaxKind,AccReceivable,AccBillRecv,AccAdvRecv,BankAccount,BankID,CreditLevel,AmountQuota,BillQuota,RecvWay,DistDays,DayOfClose,DayOfRecv,UnEnCashQuota,InvoiceStyle,Term,NOChkUnEnCashQuota,Flag,ID) Values";
                    sql += "(0,0,0,0,0,31,0,'','','','" + s4.Trim() + "','" + s5.Trim() + "','a',0,0,0,0,31,5,0,1,0,0," + s0.Trim() + ",'" + s1.Trim() + "')";
                    arrSQL.Add(sql);
                }
                DBAccess.DBCommon.sqlsend(arrSQL.ToArray());
            }

        }
        private static bool checkvalue(DataTable dt)
        {

            bool check = false;
            if (dt.Rows.Count != 0)
            {
                check = true;
            }
            else
            {
                
            }


            return check  ;


        }






    }
}