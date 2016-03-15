﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News : System.Web.UI.Page
{
    DataClassesDataContext lnq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
        fill_data();

    }
    private void fill_data()
    {
        var id = (from a in lnq_obj.news_msts

                  where a.intglcode == 1
                  select a).Single();
        Literal1.Text = id.news;

    }
}