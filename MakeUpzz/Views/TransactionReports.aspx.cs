﻿using MakeUpzz.Dataset;
using MakeUpzz.Handler;
using MakeUpzz.Models;
using MakeUpzz.Report;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeUpzz.Views
{
    public partial class TransactionReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1 data = getData(TransactionHeaderHandler.getAllTransaction());
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            report.SetDataSource(data);
        }
        //C:\inetpub\wwwroot -> Copy ini, paste di directory this pc abis tu copy folder nya masukin ke vs 2022
        public DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            foreach (TransactionHeader t in transactions)
            {
                int subTotal = 0;
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;

                

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["MakeupID"] = d.MakeupID;
                    drow["Quantity"] = d.Quantity;

                    int makeupPrice = MakeupHandler.getMakeupPrice(d.MakeupID);
                    int totalPrice = d.Quantity * makeupPrice;
                    drow["TotalPrice"] = totalPrice;
                    subTotal += totalPrice;

                    detailTable.Rows.Add(drow);
                }

                hrow["SubTotal"] = subTotal;
                headerTable.Rows.Add(hrow);
            }
            return data;
        }
    }
}