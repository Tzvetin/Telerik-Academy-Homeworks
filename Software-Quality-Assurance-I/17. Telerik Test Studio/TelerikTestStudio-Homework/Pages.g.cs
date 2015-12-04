//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikTestStudio_Homework
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
        /// Page : http://www.book.store.bg/ 
        /// </summary>
        public StoreBgКнижарницаPage StoreBgКнижарница
        {
            get
            {
                return new StoreBgКнижарницаPage("http://www.book.store.bg/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.book.store.bg/search?srchstr=JavaScript&sin=0&p=s 
        /// </summary>
        public StoreBgКнигиJavaScriptPage StoreBgКнигиJavaScript
        {
            get
            {
                return new StoreBgКнигиJavaScriptPage("http://www.book.store.bg/search?srchstr=JavaScript&sin=0&p=s", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.book.store.bg/search?srchstr=JavaScript&p=s&sin=1 
        /// </summary>
        public StoreBgКнигиJavaScript0Page StoreBgКнигиJavaScript0
        {
            get
            {
                return new StoreBgКнигиJavaScript0Page("http://www.book.store.bg/search?srchstr=JavaScript&p=s&sin=1", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.book.store.bg/p61454/javascript-for-dummies-richard-uognyr.html 
        /// </summary>
        public StoreBgJavaScriptForPage StoreBgJavaScriptFor
        {
            get
            {
                return new StoreBgJavaScriptForPage("http://www.book.store.bg/p61454/javascript-for-dummies-richard-uognyr.html", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.book.store.bg/cgi-bin/pp-page.cgi?p=delivery_price&productid=61454 
        /// </summary>
        public StoreBgPage StoreBg
        {
            get
            {
                return new StoreBgPage("http://www.book.store.bg/cgi-bin/pp-page.cgi?p=delivery_price&productid=61454", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.book.store.bg/search?srchstr=Melanie+delon&sin=0&p=s 
        /// </summary>
        public StoreBgКнигиMelaniePage StoreBgКнигиMelanie
        {
            get
            {
                return new StoreBgКнигиMelaniePage("http://www.book.store.bg/search?srchstr=Melanie+delon&sin=0&p=s", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://stage.telerikacademy.com/ 
        /// </summary>
        public СофтуернаАкадемияНаPage СофтуернаАкадемияНа
        {
            get
            {
                return new СофтуернаАкадемияНаPage("http://stage.telerikacademy.com/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://stage.telerikacademy.com/Users/Auth/Login 
        /// </summary>
        public ВходТелерикАкадемияPage ВходТелерикАкадемия
        {
            get
            {
                return new ВходТелерикАкадемияPage("http://stage.telerikacademy.com/Users/Auth/Login", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://stage.telerikacademy.com/Users/Profile/Settings 
        /// </summary>
        public НастройкиТелерикАкадемияPage НастройкиТелерикАкадемия
        {
            get
            {
                return new НастройкиТелерикАкадемияPage("http://stage.telerikacademy.com/Users/Profile/Settings", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://stage.telerikacademy.com/Users/mladen.m.savov 
        /// </summary>
        public ПрофилътНаMladenMSavovPage ПрофилътНаMladenMSavov
        {
            get
            {
                return new ПрофилътНаMladenMSavovPage("http://stage.telerikacademy.com/Users/mladen.m.savov", _manager.ActiveBrowser.Find);
            }
        }
        public class StoreBgКнижарницаPage : HtmlPage
        {
            public StoreBgКнижарницаPage(string url, Find find) : 
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
            /// (Html): [TagIndex 'Exact' input:8]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText SrchstrText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("TagIndex=input:8");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:11]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit Submit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("TagIndex=input:11");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' label] AND [TextContent 'Exact' всички раздели]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl ВсичкиРазделиLabelTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=всички раздели", "tagname=label");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' label] AND [TextContent 'Exact' само в книгите]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl СамоВКнигитеLABELTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=label", "TextContent=само в книгите");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression SrchstrText = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:8");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Submit = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:11");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ВсичкиРазделиLabelTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=всички раздели", "tagname=label");
                public ArtOfTest.WebAii.Core.HtmlFindExpression СамоВКнигитеLABELTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=label", "TextContent=само в книгите");
            }
        }
        public class StoreBgКнигиJavaScriptPage : HtmlPage
        {
            public StoreBgКнигиJavaScriptPage(string url, Find find) : 
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
            /// (Html): [TagIndex 'Exact' b:4]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl JavaScriptBTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TagIndex=b:4");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' b] AND [TextContent 'StartsWith' Търси във всичк]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl ТърсиВъвBTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^Търси във всичк", "tagname=b");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:17]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputRadioButton SinRadio
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputRadioButton>("TagIndex=input:17");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:14]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit Submit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("TagIndex=input:14");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression JavaScriptBTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=b:4");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ТърсиВъвBTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Търси във всичк", "tagname=b");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SinRadio = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:17");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Submit = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:14");
            }
        }
        public class StoreBgКнигиJavaScript0Page : HtmlPage
        {
            public StoreBgКнигиJavaScript0Page(string url, Find find) : 
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
            /// (Html): [tagname 'Exact' b] AND [TextContent 'StartsWith' Търси само в "К]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl ТърсиСамоВBTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^Търси само в \"К", "tagname=b");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' h3:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl JavaScriptH3Tag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TagIndex=h3:0");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ТърсиСамоВBTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Търси само в \"К", "tagname=b");
                public ArtOfTest.WebAii.Core.HtmlFindExpression JavaScriptH3Tag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=h3:0");
            }
        }
        public class StoreBgJavaScriptForPage : HtmlPage
        {
            public StoreBgJavaScriptForPage(string url, Find find) : 
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
            /// (Html): [href 'Exact' /cgi-bin/pp-page.cgi?p=delivery_price&amp;productid=61454] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor ЩракнетеТукLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("href=/cgi-bin/pp-page.cgi?p=delivery_price&amp;productid=61454", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' щракнете тук]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor ЩракнететукLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=щракнете тук");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ЩракнетеТукLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("href=/cgi-bin/pp-page.cgi?p=delivery_price&amp;productid=61454", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ЩракнететукLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=щракнете тук");
            }
        }
        public class StoreBgPage : HtmlPage
        {
            public StoreBgPage(string url, Find find) : 
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
            /// (Html): [tagname 'Exact' b] AND [TextContent 'StartsWith' Цена за доставк]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl ЦенаЗаBTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^Цена за доставк", "tagname=b");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ЦенаЗаBTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Цена за доставк", "tagname=b");
            }
        }
        public class StoreBgКнигиMelaniePage : HtmlPage
        {
            public StoreBgКнигиMelaniePage(string url, Find find) : 
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
            /// (Html): [tagname 'Exact' b] AND [TextContent 'Exact' Melanie delon]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl MelanieDelonBTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=Melanie delon", "tagname=b");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' label] AND [TextContent 'Exact' всички раздели]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl ВсичкиРазделиLABELTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=label", "TextContent=всички раздели");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:8]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText SrchstrText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("TagIndex=input:8");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:11]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit Submit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("TagIndex=input:11");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression MelanieDelonBTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Melanie delon", "tagname=b");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ВсичкиРазделиLABELTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=label", "TextContent=всички раздели");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SrchstrText = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:8");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Submit = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:11");
            }
        }
        public class СофтуернаАкадемияНаPage : HtmlPage
        {
            public СофтуернаАкадемияНаPage(string url, Find find) : 
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
            /// (Html): [id 'Exact' EntranceButton] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor EntranceButtonLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "id=EntranceButton");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' HeaderUserPanel][tagIndex 'Exact' a:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor MladenMSavovLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=HeaderUserPanel", "|", "tagIndex=a:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' SettingMI][TagIndex 'Exact' span:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=SettingMI", "|", "TagIndex=span:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ExitMI][TagIndex 'Exact' span:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=ExitMI", "|", "TagIndex=span:0");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression EntranceButtonLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "id=EntranceButton");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MladenMSavovLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=HeaderUserPanel", "|", "tagIndex=a:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=SettingMI", "|", "TagIndex=span:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=ExitMI", "|", "TagIndex=span:0");
            }
        }
        public class ВходТелерикАкадемияPage : HtmlPage
        {
            public ВходТелерикАкадемияPage(string url, Find find) : 
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
            /// (Html): [id 'Exact' UsernameOrEmail] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText UsernameOrEmailText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=UsernameOrEmail");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' Password] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword PasswordPassword
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("tagname=input", "id=Password");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' input] AND [value 'Exact' Вход]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit Submit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("tagname=input", "value=Вход");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression UsernameOrEmailText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=UsernameOrEmail");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswordPassword = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=Password");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Submit = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "value=Вход");
            }
        }
        public class НастройкиТелерикАкадемияPage : HtmlPage
        {
            public НастройкиТелерикАкадемияPage(string url, Find find) : 
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
            /// (Html): [id 'Exact' FirstName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText FirstNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=FirstName");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' LastName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText LastNameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=LastName");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' FirstNameEn] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText FirstNameEnText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=FirstNameEn");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' LastNameEn] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText LastNameEnText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=LastNameEn");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' 1970 - 1979]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor _19701979Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=1970 - 1979");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' 1978]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor _1978Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=1978");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' Jan]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor JanLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=Jan");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' MaleRadioBtn] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputRadioButton MaleRadioBtnRadio
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputRadioButton>("tagname=input", "id=MaleRadioBtn");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' SettingsForm][TagIndex 'Exact' span:15]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan SelectSpan
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=SettingsForm", "|", "TagIndex=span:15");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' SettingsForm][TagIndex 'Exact' span:21]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan SelectSpan0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=SettingsForm", "|", "TagIndex=span:21");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' input] AND [value 'Exact' Запази промените]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit Submit
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("tagname=input", "value=Запази промените");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' HeaderUserPanel][TagIndex 'Exact' a:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor MladenMSavovLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=HeaderUserPanel", "|", "TagIndex=a:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' SettingsForm][TagIndex 'Exact' span:9]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan SelectSpan1
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=SettingsForm", "|", "TagIndex=span:9");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' 30]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor _30JanuaryLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=30");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression FirstNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=FirstName");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LastNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=LastName");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FirstNameEnText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=FirstNameEn");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LastNameEnText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=LastNameEn");
                public ArtOfTest.WebAii.Core.HtmlFindExpression _19701979Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=1970 - 1979");
                public ArtOfTest.WebAii.Core.HtmlFindExpression _1978Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=1978");
                public ArtOfTest.WebAii.Core.HtmlFindExpression JanLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=Jan");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MaleRadioBtnRadio = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=MaleRadioBtn");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SelectSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=SettingsForm", "|", "TagIndex=span:15");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SelectSpan0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=SettingsForm", "|", "TagIndex=span:21");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Submit = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "value=Запази промените");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MladenMSavovLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=HeaderUserPanel", "|", "TagIndex=a:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SelectSpan1 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=SettingsForm", "|", "TagIndex=span:9");
                public ArtOfTest.WebAii.Core.HtmlFindExpression _30JanuaryLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=30");
            }
        }
        public class ПрофилътНаMladenMSavovPage : HtmlPage
        {
            public ПрофилътНаMladenMSavovPage(string url, Find find) : 
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
            /// (Html): [tagname 'Exact' strong] AND [TextContent 'StartsWith' mladen.m.savov ]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl MladenMStrongTag0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^mladen.m.savov ", "tagname=strong");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression MladenMStrongTag0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^mladen.m.savov ", "tagname=strong");
            }
        }
    }
    public class Applications
    {
        private Manager _manager;
        public Applications(Manager manager)
        {
            _manager = manager;
        }
    }
}
