using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebAPI.Controllers
{
    public class updateChi
    {
        /// <summary>
        /// 寫入公司
        /// </summary>
        /// <param name="cs"></param>
        /// 
        public static void updateCustomer(DataTable dt)
        {
            using (DBAccess.CHICompEntities db = new DBAccess.CHICompEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        for (int r = 0; r <= dt.Rows.Count; r++)
                        {
                            string ID = Convert.ToString(dt.Rows[1][r]);
                            string cname = Convert.ToString(dt.Rows[2][r]);
                            string shortname = Convert.ToString(dt.Rows[3][r]);
                            int flag = Convert.ToInt32(Convert.ToString(dt.Rows[0][r]));
                            string BankAccount = Convert.ToString(dt.Rows[4][r]);
                            string BankID = Convert.ToString(dt.Rows[5][r]);
                            bool nApp = true;

                            //DBAccess.comCustomer cust = db.comCustomer.First(x => x.ID == ID);
                            //if (cust != null)
                            //{
                            //    cust.FullName  = Convert.ToString(dt.Rows[1][r]);
                            //    cust.ShortName  = Convert.ToString(dt.Rows[2][r]);
                            //    nApp = false;

                            //}
                            //else
                            {
                                if (flag == 1)
                                {
                                    // Customer
                                    db.comCustomer.Add(
                                       new DBAccess.comCustomer
                                       {
                                           FundsAttribution = shortname,
                                           FullName = cname,
                                           ShortName = shortname,
                                           ClassID = "",
                                           AreaID = "",
                                           CurrencyID = "NTD",
                                           IsTemp = false,
                                           IsForeign = false,
                                           TaxNo = "",
                                           ChiefName = "",
                                           Capitalization = 0,
                                           LinkMan = "",
                                           LinkManProf = "",
                                           Telephone1 = "",
                                           Telephone2 = "",
                                           Telephone3 = "",
                                           MobileTel = "",
                                           FaxNo = "",
                                           Moderm = "",
                                           IndustrialClass = "",
                                           PersonID = "A0001",
                                           Email = "",
                                           WebAddress = "",
                                           MergeOutState = 0,
                                           ServerID = "",
                                           DealerID = "",
                                           PriceofTax = false,
                                           DirectCust = false,
                                           VIP = false,
                                           VIPLevel = "",
                                           DataVer = 2,
                                           MemberCodeNo = "",
                                           MembercodeDate = 0,
                                           IdentityNO = "",
                                           MaritalStatus = 0,
                                           SexDistinction = false,
                                           Metier = "",
                                           NativePlace = "",
                                           NativeAddress = "",
                                           FamilyAddress = "",
                                           ZipCode = "",
                                           InvoiceHead = cname,
                                           GatherOther = "",
                                           CheckOther = "",
                                           InvoTax = false,
                                           UsePerms = false,
                                           SrcID = 1,
                                           SrcName = "",
                                           GUID = "",
                                           ElectronInvoice = 0,
                                           Hqh = "",
                                           Hqw = "",
                                           Sjq = "",
                                           HqDate = 0,
                                           BToBOrToC = 0,
                                           IdentifyNo = "",
                                           EIStoreTypeGLN = "",
                                           EIStoreNo = "",
                                           EICourseType = "",
                                           EIStoreTypeGLN1 = "",
                                           EIUsePapInvoice = false,
                                           EIPageType = 0,
                                           Flag = (short)flag,
                                           ID = Convert.ToString(dt.Rows[1][r]),
                                       });
                                }
                                else
                                {
                                    // supplier
                                    db.comCustomer.Add(
                                       new DBAccess.comCustomer
                                       {
                                           FundsAttribution = shortname,
                                            ClassID="",
                                            AreaID="",
                                            CurrencyID="NTD",
                                            FullName=cname ,
                                            IsTemp=false,
                                            IsForeign=false,
                                            TaxNo="",
                                            ShortName=shortname,
                                            ChiefName="",
                                            Capitalization=0,
                                            LinkMan="",
                                            LinkManProf="",
                                            Telephone1="",
                                            Telephone2="",
                                            Telephone3="",
                                            MobileTel="",
                                            PersonID="A0001",
                                            Moderm="",
                                            FaxNo="",
                                            IndustrialClass="",
                                            Email="",
                                            WebAddress="",
                                            MergeOutState=0,
                                            IsFactory=false ,
                                            PriceofTax=false,
                                            InvoiceHead=cname,
                                            GatherOther="",
                                            CheckOther="",
                                            InvoTax=false ,
                                            UsePerms=false,
                                            PlanPerson="A0001",
                                            GUID="",
                                            Flag=2,
                                            ID= ID
                                       });
                                }
                            }
                            if (nApp)
                            {
                                db.comCustDesc.Add(
                                  new DBAccess.comCustDesc
                                  {
                                      EngFullName = "",
                                      EngShortName = "",
                                      EngLinkMan = "",
                                      EngLinkManProf = "",
                                      EngWayOfRecv = "",
                                      EngWayOfDeliv = "",
                                      AccCommi = "",
                                      AccCommiPaied = "",
                                      AddrID = "",
                                      Memo = "",
                                      TypeOfBillExpire = 0,
                                      DaysOfBillExpire = 0,
                                      PriceRank = 0,
                                      RateOfDiscount = 1,
                                      AddField1 = "",
                                      AddField2 = "",
                                      DeliverAddrID = "",
                                      EngAddrID = "",
                                      DelivZoneNo = "",
                                      AddrOfInvo = "",
                                      Flag = (short)flag,
                                      ID = Convert.ToString(dt.Rows[1][r])
                                  });
                            }
                            DBAccess.comCustTrade Trade = db.comCustTrade.First(x => x.ID == ID);
                            if (Trade != null)
                            {
                                Trade.BankAccount = BankAccount;
                                Trade.BankID = BankID;
                            }
                            else
                            {

                                db.comCustTrade.Add(
                                        new DBAccess.comCustTrade
                                        {
                                            EarliestTradeDate=0,
                                            FirstTradeDate=0,
                                            LatelyTradeDate=0,
                                            LatelyReturnDate=0,
                                            FinalTradeDate=0,
                                            InvoiceType=31,
                                            TaxKind=0,
                                            AccReceivable="",
                                            AccBillRecv="",
                                            AccAdvRecv="",
                                            BankAccount=BankAccount,
                                            BankID=BankID,
                                            CreditLevel="a",
                                            AmountQuota=0,
                                            BillQuota=0,
                                            RecvWay=0,
                                            DistDays=0,
                                            DayOfClose=31,
                                            DayOfRecv=5,
                                            UnEnCashQuota=0,
                                            InvoiceStyle=1,
                                            Term=0,
                                            NOChkUnEnCashQuota=0,
                                            Flag = (short)flag,
                                            ID= ID
                                        });

                            }
                        }
                        db.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }
        /// <summary>
        /// 寫入部門
        /// </summary>
        /// <param name="cs"></param>
        ///
        public static void updateDeppt(DataTable dt)
        {
            using (DBAccess.CHICompEntities db = new DBAccess.CHICompEntities())
            {
                //using (var tran = db.Database.BeginTransaction())
                {
                    //try
                    {
                        for (int r = 0; r <= dt.Rows.Count; r++ )
                        {
                            string ID = Convert.ToString(dt.Rows[0][r]);

                            //var order = (from o in db.comDepartment 
                            //             where o.DepartID  == ID
                            //             select o).First();

                            ////
                            //// DBAccess.comD'epartment dept= db.comDepartment.First(x=> x.DepartID ==ID);
                            ////
                            //if (order != null)
                            //{
                            //    order.DepartName = Convert.ToString(dt.Rows[1][r]);
                            //    order.EngName = Convert.ToString(dt.Rows[2][r]);
                            //}
                            //else
                            {
                                db.comDepartment.Add(
                                   new DBAccess.comDepartment
                                   {
                                       DepartID = Convert.ToString(dt.Rows[0][r]),
                                       DepartName = Convert.ToString(dt.Rows[0][r]),
                                       EngName = Convert.ToString(dt.Rows[0][r]),
                                       Memo ="",
                                       Female=0,
                                       Male=0,
                                       JobSch="",
                                       MergeOutState=0,
                                       UsePerms=false,
                                       SalaryTypeID="",
                                       HrmJobSchID="",
                                       YanChangIndex=0,
                                       IsOverTimeApp=false,
                                       ReportCompID="",
                                       ParentID="",
                                       RealID="",
                                       CalID="",
                                       IsStoped=false,
                                       GUID=""
                                   });
                            }
                        }
                        db.SaveChanges();
                        int oo = 0;
                        //tran.Commit();
                    }
                    //catch (Exception ex)
                    //{
                    //    tran.Rollback();
                    //    throw ex;
                    //}
                }
            }

        }


    }
}
