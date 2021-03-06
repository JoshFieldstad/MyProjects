//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject7
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : http://localhost:58549/TestPage/ 
        /// </summary>
        public HttpLocalhost58549TestPagPage HttpLocalhost58549TestPag
        {
            get
            {
                return new HttpLocalhost58549TestPagPage("http://localhost:58549/TestPage/", _manager.ActiveBrowser.Find);
            }
        }
        public class HttpLocalhost58549TestPagPage : HtmlPage
        {
            public HttpLocalhost58549TestPagPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00] AND [tagname 'Exact' table]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridTableView RadGrid1Table
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridTableView>("tagname=table", "id=RadGrid1_ctl00");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl02_ctl04_TB_ProductName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText RadGrid1TBProductNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=RadGrid1_ctl00_ctl02_ctl04_TB_ProductName", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl02_ctl04_RNTB_UnitPrice_wrapper] AND [tagname 'Exact' span]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.RadInput RadGrid1RNTBUnitPriceWrapperSpan
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.RadInput>("tagname=span", "id=RadGrid1_ctl00_ctl02_ctl04_RNTB_UnitPrice_wrapper");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00][tagIndex 'Exact' div:0]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridEditForm Div
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridEditForm>("id=RadGrid1_ctl00", "|", "tagIndex=div:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' Button1] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputButton Button1Button
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputButton>("tagname=input", "id=Button1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' Count : 31]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell Count31TableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("TextContent=Count : 31", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' First : Chai]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell FirstChaiTableCell
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("TextContent=First : Chai", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [HtmlPath 'Exact' /body[0]/form[id=form1]/div[id=RadAjaxPAnel1Panel]/div[id=RadAjaxPAnel1]/div[id=RadGrid1]/table[id=RadGrid1_ctl00]/tfoot[0]/tr[0]/td[2]] AND [tagname 'Exact' td] AND [XPath 'Exact' /html[1]/body[1]/form[1]/div[3]/div[1]/div[1]/table[1]/tfoot[1]/tr[1]/td[3]]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridFooterCell Sum
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridFooterCell>("tagname=td", "XPath=/html[1]/body[1]/form[1]/div[3]/div[1]/div[1]/table[1]/tfoot[1]/tr[1]/td[3]" +
                            "", "HtmlPath=/body[0]/form[id=form1]/div[id=RadAjaxPAnel1Panel]/div[id=RadAjaxPAnel1]" +
                            "/div[id=RadGrid1]/table[id=RadGrid1_ctl00]/tfoot[0]/tr[0]/td[2]");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl04_gbccolumn] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputImage RadGrid1GbccolumnImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputImage>("tagname=input", "id=RadGrid1_ctl00_ctl04_gbccolumn");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00__0] AND [tagname 'Exact' tr]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridDataItem FirstElementInTable
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridDataItem>("id=RadGrid1_ctl00__0", "tagname=tr");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl02_ctl03_FilterTextBox_ProductName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText RadGrid1FilterTextBoxProductNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=RadGrid1_ctl00_ctl02_ctl03_FilterTextBox_ProductName", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00_ctl02_ctl03_Filter_ProductName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputButton RadGrid1FilterProductNameButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputButton>("tagname=input", "id=RadGrid1_ctl00_ctl02_ctl03_Filter_ProductName");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_rfltMenu_detached] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv RadGrid1RfltMenuDetachedDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("tagname=div", "id=RadGrid1_rfltMenu_detached");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_rfltMenu_detached][tagIndex 'Exact' li:1]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.RadMenuItem ListItem
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.RadMenuItem>("id=RadGrid1_rfltMenu_detached", "|", "tagIndex=li:1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' td] AND [TextContent 'Exact' Count : 3]
            ///
            /// </summary>
            public Telerik.WebAii.Controls.Html.GridFooterCell Count
            {
                get
                {
                    return Get<Telerik.WebAii.Controls.Html.GridFooterCell>("TextContent=Count : 3", "tagname=td");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' RadGrid1_ctl00] AND [tagname 'Exact' table]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTable RadGrid1Table0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTable>("tagname=table", "id=RadGrid1_ctl00");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1Table = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=table", "id=RadGrid1_ctl00");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1TBProductNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00_ctl02_ctl04_TB_ProductName", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1RNTBUnitPriceWrapperSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=span", "id=RadGrid1_ctl00_ctl02_ctl04_RNTB_UnitPrice_wrapper");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00", "|", "tagIndex=div:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Button1Button = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=Button1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Count31TableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Count : 31", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FirstChaiTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=First : Chai", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Sum = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=td", "XPath=/html[1]/body[1]/form[1]/div[3]/div[1]/div[1]/table[1]/tfoot[1]/tr[1]/td[3]" +
                        "", "HtmlPath=/body[0]/form[id=form1]/div[id=RadAjaxPAnel1Panel]/div[id=RadAjaxPAnel1]" +
                        "/div[id=RadGrid1]/table[id=RadGrid1_ctl00]/tfoot[0]/tr[0]/td[2]");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1GbccolumnImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=RadGrid1_ctl00_ctl04_gbccolumn");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FirstElementInTable = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00__0", "tagname=tr");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1FilterTextBoxProductNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_ctl00_ctl02_ctl03_FilterTextBox_ProductName", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1FilterProductNameButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=RadGrid1_ctl00_ctl02_ctl03_Filter_ProductName");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1RfltMenuDetachedDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=div", "id=RadGrid1_rfltMenu_detached");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ListItem = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=RadGrid1_rfltMenu_detached", "|", "tagIndex=li:1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Count = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Count : 3", "tagname=td");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RadGrid1Table0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=table", "id=RadGrid1_ctl00");
            }
        }
    }
}
