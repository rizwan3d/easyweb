using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Easy_Web
{
    struct projectfiles
    {
        public string path;
        public string name;
        public string hcode;
        public string ccode;
    }
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region attributes
        string[] attributes = { "html", "download", "target", "_blank" , "_parent" , "_self" , "_top" , "controls" , "audio/mpeg" , "audio/ogg" , "audio/wav"
                , "autoplay", "loop" ,"disabled" , "reset" , "submit" , "get" , "post","on","off" , "button"
                ,"checkbox","color","date","datetime","datetime-local","email","file","hidden","image","month","number","password","radio","range","reset","search","submit","tel","text","time","url","week"
                ,"sandbox" , "allow-forms" , "allow-pointer-lock" , "allow-popups" , "allow-same-origin" , "allow-scripts" , "allow-top-navigation"
                ,"allow-scripts","icon","stylesheet","selected","sortable"};
        #endregion
        #region snippets
        string[] snippets = { "<html>\n ^ \n</html>", "<h1> ^ </h1>", "<h2> ^ </h2>", "<h3> ^ </h3>", "<h4> ^ </h4>"
                , "<h5> ^ </h5>", "<h6> ^ </h6>", "<div>\n ^ \n<div>","<style>\n ^ \n</style>" , "<head>\n ^ \n</head>" , "<title>\n ^ \n</title>" ,"<body>\n ^ \n</body>"
                , "<!--\n ^ \n-->", "<!DOCTYPE ^>", "<a href=\"^\"> </a>", "href=\"^\"", "target=\"^\""
                ,"<abbr title=\"^\"> </abbr>", "title=\"^\"" , "<address>\n^\n</address>" , "<article>\n^\n</article>"
                ,"<aside>\n^\n</aside>", "<audio> \n ^ \n <audio>" , " <source src=\"^\" type=\" \" />"
                ,"<b>^</b>","<bdi>^</bdi>", "<blockquote cite=\"^\">\n\n</blockquote>", "<canvas id=\"^\"></canvas>" , "height=\"^\"" , "width=\"^\""
                ,"type=\"^\"", "value=\"^\"" , "<button type=\"^\"></button>", "formmethod=\"^\"" , "<caption>^</caption>" , "<cite>^</cite>"
                ,"<code>^</code>", "<datalist id=\"\">", "<dialog open> ^ </dialog>", "<div class=\"^\"> \n \n </div>" , "<em>^</em>"
                ,"<embed src=\"^\">" , "src=\"^\"", "<figcaption>^</figcaption>" , "<figure>^</figure>"
                , "<footer>\"^\"</footer>","<form action=\"^\" method=\"get\">\n\n</form>","autocomplete=\"on\""
                ,"<header>\n^\n</header>" , "<hr />" , "<i>" , "<input type=\"^\" value=\"\">", " <iframe src=\"^\"></iframe>"
                ,"srcdoc=\"^\"", "sandbox=\"^\"", "<img src=\"^\">", "alt=\"^\">","<ol>\n ^\n <ol>", "<li>^</li>"
                ,"<ol>\n<li>^</li>\n<li></li>\n</ol>","<ul>\n<li>^</li>\n<li></li>\n</ul>" , "<ul>\n^\n</ul>"
                ,"<link rel=\"^\" type=\"\" href=\"\">","<main>\n^\n</main>","<mark>^</mark>", "<nav>\n^\n</nav>"
                , "<select>\n^\n</select>","<option value=\"^\"></option>","<pre>^</pre>","<q>^</q>","<s>^</s>"
                ,"<script>\n^\n</script>", "src=\"^\"","<small>^</small>","<strong>^</strong>","<textarea rows=\"^\" cols=\"\"></textarea>"
                ,"<textarea>^</textarea>","<table>\n^\n</table>","<tr>\n^\n</tr>", "<th>^</th>","border=\"^\""};
        #endregion snippets
        #region csskeywords
        string[] csskey = { "font-weight:", "border-radius:", "color-stop:", "alignment-adjust:","alignment-baseline"
                ,"animation:","animation-delay:","animation-direction:","animation-duration:","animation-iteration-count"
                ,"animation-name:","animation-play-state:","animation-timing-function:","appearance:","azimuth"
                ,"backface-visibility:","background:","background-attachment:","background-break:","background-clip"
                ,"background-color:","background-image:","background-origin:","background-position:","background-repeat"
                ,"background-size:","baseline-shift:","binding:","bleed:","bookmark-label:","bookmark-level:","bookmark-state"
                ,"bookmark-target:","border:","border:","border-bottom:","border-bottom-color:","border-bottom-left-radius"
                ,"border-bottom-right-radius:","border-bottom-style:","border-bottom-width:","border-collapse"
                ,"border-color:","border-image:","border-image-outset:","border-image-repeat:","border-image-slice"
                ,"border-image-source:","border-image-width:","border-left:","border-left-color:","border-left-style"
                ,"border-left-width:","border-right:","border-right-color:","border-right-style:","border-right-width"
                ,"border-spacing:","border-style:","border-top:","border-top-color:","border-top-left-radius"
                ,"border-top-right-radius:","border-top-style:","border-top-width:","border-width:","bottom:","box-align"
                ,"box-decoration-break:","box-direction:","box-flex:","box-flex-group:","box-lines:","box-ordinal-group"
                ,"box-orient:","box-pack:","box-shadow:","box-sizing:","break-after:","break-before:","break-inside"
                ,"caption-side:","clear:","clip:","color:","color-profile:","column-count:","column-fill:","column-gap"
                ,"column-rule:","column-rule-color:","column-rule-style:","column-rule-width:","column-span"
                ,"column-width:","columns:","content:","counter-increment:","counter-reset:","crop:","cue:","cue-after"
                ,"cue-before:","cursor:","direction:","display:","dominant-baseline:","drop-initial-after-adjust"
                ,"drop-initial-after-align:","drop-initial-before-adjust:","drop-initial-before-align"
                ,"drop-initial-size:","drop-initial-value:","elevation:","empty-cells:","filter:","fit:","fit-position"
                ,"float:","float-offset:","font:","font-effect:","font-emphasize:","font-family:","font-size"
                ,"font-size-adjust:","font-stretch:","font-style:","font-variant:","grid-columns:","grid-rows"
                ,"hanging-punctuation:","height:","hyphenate-after:","hyphenate-before:","hyphenate-character"
                ,"hyphenate-lines:","hyphenate-resource:","hyphens:","icon:","image-orientation:","image-rendering"
                ,"image-resolution:","inline-box-align:","left:","letter-spacing:","line-height:","line-stacking"
                ,"line-stacking-ruby:","line-stacking-shift:","line-stacking-strategy:","list-style:","list-style-image"
                ,"list-style-position:","list-style-type:","margin:","margin-bottom:","margin-left:","margin-right"
                ,"margin-top:","mark:","mark-after:","mark-before:","marker-offset:","marks:","marquee-direction"
                ,"marquee-play-count:","marquee-speed:","marquee-style:","max-height:","max-width:","min-height"
                ,"min-width:","move-to:","nav-down:","nav-index:","nav-left:","nav-right:","nav-up:","opacity:","orphans"
                ,"outline:","outline-color:","outline-offset:","outline-style:","outline-width:","overflow:","overflow-style"
                ,"overflow-x:","overflow-y:","padding:","padding-bottom:","padding-left:","padding-right:","padding-top:","page"
                ,"page-break-after:","page-break-before:","page-break-inside:","page-policy:","pause:","pause-after"
                ,"pause-before:","perspective:","perspective-origin:","phonemes:","pitch:","pitch-range:","play-during"
                ,"position:","presentation-level:","punctuation-trim:","quotes:","rendering-intent:","resize:","rest"
                ,"rest-after:","rest-before:","richness:","right:","rotation:","rotation-point:","ruby-align:","ruby-overhang"
                ,"ruby-position:","ruby-span:","size:","speak:","speak-header:","speak-numeral:","speak-punctuation:","speech-rate"
                ,"stress:","string-set:","table-layout:","target:","target-name:","target-new:","target-position"
                ,"text-align:","text-align-last:","text-decoration:","text-emphasis:","text-height:","text-indent"
                ,"text-justify:","text-outline:","text-overflow:","text-shadow:","text-transform:","text-wrap:","top"
                ,"transform:","transform-origin:","transform-style:","transition:","transition-delay:","transition-duration"
                ,"transition-property:","transition-timing-function:","unicode-bidi:","vertical-align:","visibility"
                ,"voice-balance:","voice-duration:","voice-family:","voice-pitch:","voice-pitch-range:","voice-rate"
                ,"voice-stress:","voice-volume:","volume:","white-space:","white-space-collapse:","widows:","width:","word-break"
                ,"word-spacing:","word-wrap:","z-index)","no-repeat","fixed","linear-gradient","color-dodge","center","content-box"
                ,"solid","thick","dotted","2em","(border)","thick","double","absolute","left","both","rect","inline"
                ,"right","scroll","hidden","-webkit-flex","wrap","row-reverse","flex","row-reverse wrap","space-around"
                ,"first","justify","inter-word","uppercase","lowercase","capitalize","nowrap","break-all","break-word","overline"
                ,"line-through", "underline","wavy","myFirstFont","sensation","light.woff","arial","sans-serif","italic","bold"
                ,"Georgia","serif","expanded","normal","oblique","italic","small-caps","bold","rtl","bidi-override","collapse"
                ,"separate","hide","fixed","section","subsection","Section", "counter(section)","counter(subsection)","square","sqpurple"
                ,"circle","upper-roman","lower-alpha","infinite","mymove","alternate","forwards","paused","linear","rotate","preserve"
                ,"width","crosshair","help","wait","auto","outset","all","always","avoid","grayscale"};
        #endregion

        Style BlueBoldStyle = new TextStyle(Brushes.Red, null, FontStyle.Bold);
        Style MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        Style GreenStyle = new TextStyle(Brushes.Gray, null, FontStyle.Italic);
        Style BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        Style FireBrickBold = new TextStyle(Brushes.Firebrick, null, FontStyle.Bold);
        Style DodgerBlue = new TextStyle(Brushes.DodgerBlue, null, FontStyle.Regular);
        Style SteelBlue = new TextStyle(Brushes.SteelBlue, null, FontStyle.Regular);
        Style DarkGoldenRodBold = new TextStyle(Brushes.DarkGoldenrod, null, FontStyle.Bold);
        Style SlateGray = new TextStyle(Brushes.PeachPuff, null, FontStyle.Regular);
        Style DarkViolet = new TextStyle(Brushes.DarkViolet, null, FontStyle.Regular);

        int cmse = 0 , pfco =0;
        string CCSS, CHTML, path;

        string snippetstext = "<!DOCTYPE html>\n<html>\n<head>\n    <title>\n        my first web page\n    </title>\n    <link rel = \"stylesheet\" type=\"text/css\" href=\"./css/basic.css\">\n</head>\n<body>\n\n\n\n</body>\n</html>";

        AutocompleteMenu popupMenu;
        AutocompleteMenu popupMenu2;

        projectfiles[] pf = new projectfiles[10000];
        private bool firstrun = true;        

        private void open_project_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(f.SelectedPath + "\\css") && Directory.Exists(f.SelectedPath + "\\img") && Directory.Exists(f.SelectedPath + "\\fonts"))
                {
                    Fulllist(f.SelectedPath);
                    filecodepf();
                    tab.Enabled = true;
                    css_file_list.Enabled = true;
                    font_file_list.Enabled = true;
                    html_file_list.Enabled = true;
                    iame_file_list.Enabled = true;
                    navBarControl1.Enabled = true;
                    path = f.SelectedPath;
                    status.Caption = "Porject Opened";
                    updateautocompleat();
                }
                else
                    MessageBox.Show("Invalid Project");
            }
        }
        private void save_project_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (projectfiles p in pf)
            {
                if (p.name != null)
                {
                    if (p.name == CHTML)
                        File.WriteAllText(p.path, htmltext.Text);
                    if (p.name == CCSS)
                        File.WriteAllText(p.path, csstext.Text);
                    if (p.name.Contains("html") && p.hcode != null)
                        File.WriteAllText(p.path, p.hcode);
                    if (p.name.Contains("css") && p.ccode != null)
                        File.WriteAllText(p.path, p.ccode);
                    webBrowser1.Refresh();
                }
            }
            status.Caption = "Project Saved";
        }
        private void save_file_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (projectfiles p in pf)
            {
                if (p.name != null)
                {
                    if (p.name == CHTML)
                    {
                        File.WriteAllText(p.path, htmltext.Text);
                        webBrowser1.Navigate(p.path);
                    }
                    if (p.name == CCSS)
                        File.WriteAllText(p.path, csstext.Text);
                }
            }
            status.Caption = "File Saved";
        }
        private void exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void html_file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (html_file_list.SelectedItem != null)
            {
                for (int i = 0; i < pfco; i++)
                {
                    if (CHTML == pf[i].name)
                    {
                        pf[i].hcode = htmltext.Text;
                        webBrowser1.Navigate(pf[i].path);
                    }
                }
                for (int i = 0; i < pfco; i++)
                {
                    if (html_file_list.SelectedItem.ToString() == pf[i].name)
                    {
                        htmltext.Text = pf[i].hcode;
                        CHTML = pf[i].name;
                        webBrowser1.Navigate(pf[i].path);
                    }
                }
            }
        }
        private void css_file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (css_file_list.SelectedItem != null)
            {
                for (int i = 0; i < pfco; i++)
                {
                    if (CCSS == pf[i].name)
                        pf[i].ccode = csstext.Text;
                }
                for (int i = 0; i < pfco; i++)
                {
                    if (css_file_list.SelectedItem.ToString() == pf[i].name)
                    {
                        csstext.Text = pf[i].ccode;
                        CCSS = pf[i].name;
                    }
                }
            }
        }
        private void css_file_list_DoubleClick(object sender, EventArgs e)
        {
            if (css_file_list.SelectedItem != null)
            {
                htmltext.SelectedText = "<link rel=\"stylesheet\" href=\"./css/" + css_file_list.SelectedItem.ToString() + " type=\"text/css\">";
            }
        }
        private void iame_file_list_DoubleClick(object sender, EventArgs e)
        {
            if (iame_file_list.SelectedItem != null)
            {
                foreach (projectfiles p in pf)
                {
                    if (p.name != null)
                    {
                        if (iame_file_list.SelectedItem.ToString() == p.name)
                        {
                            if (tab.SelectedTabPage.Text == "Source")
                                htmltext.SelectedText = "./img/" + p.name;
                            else if (tab.SelectedTabPage.Text == "CSS")
                                csstext.SelectedText = "../img/" + p.name;
                        }
                    }
                }
            }
        }
        private void csstext_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(SlateGray, DarkViolet, DodgerBlue, FireBrickBold, BlueBoldStyle, DarkGoldenRodBold, MagentaStyle, GreenStyle, BrownStyle);
            e.ChangedRange.tb.CommentPrefix = null;
            e.ChangedRange.tb.LeftBracket = '(';
            e.ChangedRange.tb.RightBracket = ')';
            e.ChangedRange.tb.LeftBracket2 = '\x0';
            e.ChangedRange.tb.RightBracket2 = '\x0';

            e.ChangedRange.SetStyle(BrownStyle, @""".*?""|'.+?'", RegexOptions.Multiline);

            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);

            e.ChangedRange.SetStyle(MagentaStyle, @"\b(\d+\s*(px|em|pt|in|cm|mm|ex|pc)*)\b(%)*", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(MagentaStyle, @"#\b([a-fA-F0-9]{3,8})\b", RegexOptions.Multiline);

            e.ChangedRange.SetStyle(SteelBlue, @"(-(moz|o|ms|webkit|khtml)-(\w|-)+)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(FireBrickBold, @"(#:(\w|\.|-)+:#)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(DodgerBlue, @"\b(font-weight|border-radius|color-stop|alignment-adjust|alignment-baseline|animation|animation-delay|animation-direction|animation-duration|animation-iteration-count|animation-name|animation-play-state|animation-timing-function|appearance|azimuth|backface-visibility|background|background-attachment|background-break|background-clip|background-color|background-image|background-origin|background-position|background-repeat|background-size|baseline-shift|binding|bleed|bookmark-label|bookmark-level|bookmark-state|bookmark-target|border|border|border-bottom|border-bottom-color|border-bottom-left-radius|border-bottom-right-radius|border-bottom-style|border-bottom-width|border-collapse|border-color|border-image|border-image-outset|border-image-repeat|border-image-slice|border-image-source|border-image-width|border-left|border-left-color|border-left-style|border-left-width|border-right|border-right-color|border-right-style|border-right-width|border-spacing|border-style|border-top|border-top-color|border-top-left-radius|border-top-right-radius|border-top-style|border-top-width|border-width|bottom|box-align|box-decoration-break|box-direction|box-flex|box-flex-group|box-lines|box-ordinal-group|box-orient|box-pack|box-shadow|box-sizing|break-after|break-before|break-inside|caption-side|clear|clip|color|color-profile|column-count|column-fill|column-gap|column-rule|column-rule-color|column-rule-style|column-rule-width|column-span|column-width|columns|content|counter-increment|counter-reset|crop|cue|cue-after|cue-before|cursor|direction|display|dominant-baseline|drop-initial-after-adjust|drop-initial-after-align|drop-initial-before-adjust|drop-initial-before-align|drop-initial-size|drop-initial-value|elevation|empty-cells|filter|fit|fit-position|float|float-offset|font|font-effect|font-emphasize|font-family|font-size|font-size-adjust|font-stretch|font-style|font-variant|grid-columns|grid-rows|hanging-punctuation|height|hyphenate-after|hyphenate-before|hyphenate-character|hyphenate-lines|hyphenate-resource|hyphens|icon|image-orientation|image-rendering|image-resolution|inline-box-align|left|letter-spacing|line-height|line-stacking|line-stacking-ruby|line-stacking-shift|line-stacking-strategy|list-style|list-style-image|list-style-position|list-style-type|margin|margin-bottom|margin-left|margin-right|margin-top|mark|mark-after|mark-before|marker-offset|marks|marquee-direction|marquee-play-count|marquee-speed|marquee-style|max-height|max-width|min-height|min-width|move-to|nav-down|nav-index|nav-left|nav-right|nav-up|opacity|orphans|outline|outline-color|outline-offset|outline-style|outline-width|overflow|overflow-style|overflow-x|overflow-y|padding|padding-bottom|padding-left|padding-right|padding-top|page|page-break-after|page-break-before|page-break-inside|page-policy|pause|pause-after|pause-before|perspective|perspective-origin|phonemes|pitch|pitch-range|play-during|position|presentation-level|punctuation-trim|quotes|rendering-intent|resize|rest|rest-after|rest-before|richness|right|rotation|rotation-point|ruby-align|ruby-overhang|ruby-position|ruby-span|size|speak|speak-header|speak-numeral|speak-punctuation|speech-rate|stress|string-set|table-layout|target|target-name|target-new|target-position|text-align|text-align-last|text-decoration|text-emphasis|text-height|text-indent|text-justify|text-outline|text-overflow|text-shadow|text-transform|text-wrap|top|transform|transform-origin|transform-style|transition|transition-delay|transition-duration|transition-property|transition-timing-function|unicode-bidi|vertical-align|visibility|voice-balance|voice-duration|voice-family|voice-pitch|voice-pitch-range|voice-rate|voice-stress|voice-volume|volume|white-space|white-space-collapse|widows|width|word-break|word-spacing|word-wrap|z-index)\b", RegexOptions.Multiline);

            e.ChangedRange.SetStyle(BlueBoldStyle, @"[\}|\{]", RegexOptions.Multiline);

            e.ChangedRange.SetStyle(DarkGoldenRodBold, @"(\}.*?\{)|(\}.*)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(DarkGoldenRodBold, @"(\}.*?\{)|(.*\{)", RegexOptions.Singleline | RegexOptions.RightToLeft);

            e.ChangedRange.SetStyle(SlateGray, @"[\.|\,|\;|\:|\=|\(|\)|\!]", RegexOptions.Multiline);

            e.ChangedRange.SetStyle(DarkViolet, @"progid\:DXImageTransform\.Microsoft", RegexOptions.Multiline);

            e.ChangedRange.ClearFoldingMarkers();

            e.ChangedRange.SetFoldingMarkers("{", "}");
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");
        }        
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel2.Visible = true;
            cmse = 1;
            status.Caption = "HTML File Created";
        }
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel2.Visible = true;
            cmse = 2;
            status.Caption = "CSS File Created";
        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                pf[pfco].name = Path.GetFileName(of.FileName);
                File.Copy(of.FileName, path + "\\img\\" + pf[pfco].name);
                pf[pfco].path = path + "\\img\\" + pf[pfco].name;
                iame_file_list.Items.Add(pf[pfco].name,2);
                pfco++;
                status.Caption = "Image Added";
            }
        }
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                pf[pfco].name = Path.GetFileName(of.FileName);
                File.Copy(of.FileName, path + "\\fonts\\" + pf[pfco].name);
                pf[pfco].path = path + "\\fonts\\" + pf[pfco].name;
                font_file_list.Items.Add(pf[pfco].name,3);
                pfco++;
                status.Caption = "Font Added";
            }
        }
        public Form1()
        {
            InitializeComponent();
            popupMenu = new AutocompleteMenu(htmltext);
            popupMenu.SearchPattern = @"[\w\.:=!<>]";
            popupMenu.AllowTabKey = true;
            popupMenu2 = new AutocompleteMenu(csstext);
            popupMenu2.SearchPattern = @"[\w\.:=!<>]";
            popupMenu2.AllowTabKey = true;

            BuildAutocompleteMenu();
            BuildAutocompleteMenu2();
        }
        private void BuildAutocompleteMenu()
        {
            List<AutocompleteItem> items = new List<AutocompleteItem>();

            foreach (var item in snippets)
                items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });

            foreach (var item in attributes)
                items.Add(new AutocompleteItem(item));
            items.Add(new InsertSpaceSnippet());
            items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
            items.Add(new InsertEnterSnippet());

            popupMenu.Items.SetAutocompleteItems(items);
        }
        private void BuildAutocompleteMenu2()
        {
            List<AutocompleteItem> items = new List<AutocompleteItem>();

            foreach (var item in csskey)
                items.Add(new AutocompleteItem(item));

            popupMenu2.Items.SetAutocompleteItems(items);
        }
        #region autocomp
        class DeclarationSnippet : SnippetAutocompleteItem
        {
            public DeclarationSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;
            }
        }

        class InsertSpaceSnippet : AutocompleteItem
        {
            string pattern;

            public InsertSpaceSnippet(string pattern) : base("")
            {
                this.pattern = pattern;
            }

            public InsertSpaceSnippet()
                : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                if (Regex.IsMatch(fragmentText, pattern))
                {
                    Text = InsertSpaces(fragmentText);
                    if (Text != fragmentText)
                        return CompareResult.Visible;
                }
                return CompareResult.Hidden;
            }

            public string InsertSpaces(string fragment)
            {
                var m = Regex.Match(fragment, pattern);
                if (m == null)
                    return fragment;
                if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
                    return fragment;
                return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return Text;
                }
            }
        }

        class InsertEnterSnippet : AutocompleteItem
        {
            Place enterPlace = Place.Empty;

            public InsertEnterSnippet()
                : base("[Line break]")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var r = Parent.Fragment.Clone();
                while (r.Start.iChar > 0)
                {
                    if (r.CharBeforeStart == '}')
                    {
                        enterPlace = r.Start;
                        return CompareResult.Visible;
                    }
                    r.GoLeftThroughFolded();
                }
                return CompareResult.Hidden;
            }

            public override string GetTextForReplace()
            {
                Range r = Parent.Fragment;
                Place end = r.End;
                r.Start = enterPlace;
                r.End = r.End;
                return Environment.NewLine + r.Text;
            }

            public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
            {
                base.OnSelected(popupMenu, e);
                if (Parent.Fragment.tb.AutoIndent)
                    Parent.Fragment.tb.DoAutoIndent();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return "Insert line break after '}'";
                }
            }
        }
        #endregion
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (file_name_box.Text != "")
            {
                if (cmse == 1)
                {
                    makefile(".html");
                    html_file_list.Items.Add(pf[pfco - 1].name,0);
                }
                if (cmse == 2)
                {
                    makefile(".css");
                    css_file_list.Items.Add(pf[pfco - 1].name,1);
                }
                cmse = 0;
            }
        }
        private void firefox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CHTML != null)
            {
                string url = (path + "\\" + CHTML);
                System.Diagnostics.Process.Start("firefox.exe", "\"" + url + "\"");
            }
        }
        private void Internet_Explorer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CHTML != null)
            {
                string url = (path + "\\" + CHTML);
                System.Diagnostics.Process.Start("iexplore.exe", "\"" + url + "\"");
            }
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new_project.PerformClick();
        }        private void file_c_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            open_project.PerformClick();
        }
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save_file.PerformClick();
        }
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firefox.PerformClick();
        }
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Internet_Explorer.PerformClick();
        }
        private void h1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<h1> </h1>";
        }
        private void iame_file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstrun)
            {
                if (iame_file_list.SelectedItem != null)
                {
                    
                    foreach (projectfiles p2 in pf)
                    {
                        if (p2.name != null)
                        {
                            if (iame_file_list.SelectedItem.ToString() == p2.name)
                            {                                
                                ImageV.Image = new Bitmap(p2.path);
                                ImageV.Visible = true;
                                timer1.Enabled = true;
                                simpleButton1.Visible = true;
                                simpleButton1.BringToFront();
                            }
                        }
                    }
                }
            }
            else
                firstrun = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ImageV.Visible = false;
            timer1.Enabled = false;
            simpleButton1.Visible = false;
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ImageV.Visible = false;
            timer1.Enabled = false;
            simpleButton1.Visible = false;
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                pf[pfco].name = Path.GetFileName(of.FileName);
                File.Copy(of.FileName, path + pf[pfco].name);
                pf[pfco].path = path +  pf[pfco].name;
                html_file_list.Items.Add(pf[pfco].name, 0);
                pfco++;
                status.Caption = "HTML File Added";
                updateautocompleat();
            }            
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                pf[pfco].name = Path.GetFileName(of.FileName);
                File.Copy(of.FileName, path + "\\css\\" + pf[pfco].name);
                pf[pfco].path = path + "\\css\\" + pf[pfco].name;
                css_file_list.Items.Add(pf[pfco].name, 3);
                pfco++;
                status.Caption = "CSS File Added";
            }
        }
        private void font_file_list_DoubleClick(object sender, EventArgs e)
        {
            if (font_file_list.SelectedItem != null)
            {
                foreach (projectfiles p in pf)
                {
                    if (p.name != null)
                    {
                        if (font_file_list.SelectedItem.ToString() == p.name)
                        {
                            csstext.Text = "font-face {\n    font-family: " + p.name + ";\n    src: url(../fonts/"+ p.name +");\n}" + csstext.Text;
                        }
                    }
                }
            }
            
        }
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tab.SelectedTabPage.Text == "Source")
                htmltext.ShowFindDialog();
            else if (tab.SelectedTabPage.Text == "CSS")
                csstext.ShowFindDialog();
        }
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tab.SelectedTabPage.Text == "Source")
                htmltext.ShowReplaceDialog();
            else if (tab.SelectedTabPage.Text == "CSS")
                csstext.ShowReplaceDialog();
        }
        private void h2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<h2> </h2>";
        }
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<br />";
        }
        private void p_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<p> </p>";
        }
        private void pe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<pre> </pre>";
        }
        private void div_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<div> </div>";
        }
        private void em_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<em> </em>";
        }
        private void hr_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<hr />";
        }             
        private void a_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<a herf=\"\"> </a>";
        }
        private void table_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<table>\n\n</table>";
        }
        private void addrow_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<th>\n\n</th>";
        }
        private void addcell_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<tr>\n\n</tr>";
        }
        private void unorderedlist_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<ul>\n\n</ul>";
        }
        private void orderedlist_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<ol>\n\n</ol>";
        }
        private void listitem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<li>\n\n</li>";
        }
        private void iframe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<iframe src=\"\"></iframe>";
        }
        private void img_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<img src=\"\"></img>";
        }
        private void Video_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<video width=\"320\" height=\"240\" controls>\n   < source src=\"\" type=\"\">\n     Your browser does not support the Video tag.\n</video>";
        }
        private void audio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<audio controls>\n   < source src=\"\" type=\"\">\n     Your browser does not support the audio tag.\n</audio>";
        }
        private void nav_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<nav>\n\n</nav>";
        }
        private void form_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<form action=\"\" method=\"\">\n\n\n</form>";
        }
        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<input type =\"text\" name=\"\">";
        }
        private void inputsubmit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<input type=\"submit\" value=\"Submit\">";
        }
        private void textarea_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<textarea rows=\"\" cols=\"\"></textarea>";
        }
        private void button_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<button type=\"button\"></button>";
        }
        private void dropdownlist_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<select>\n</select>";
        }
        private void option_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<option value=\"\"></option>";
        }
        private void tab_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tab.SelectedTabPage.Text == "Source")
                documentMap1.Target = htmltext;
            if (tab.SelectedTabPage.Text == "CSS")
                documentMap1.Target = csstext;
        }
        private void new_project_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cProject();
            tab.Enabled = true;
            css_file_list.Enabled = true;
            font_file_list.Enabled = true;
            html_file_list.Enabled = true;
            iame_file_list.Enabled = true;
            navBarControl1.Enabled = true;
            filecodepf();
            status.Caption = "Project Created";
        }
        void cProject()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                path = FBD.SelectedPath;
                DirectoryInfo css = Directory.CreateDirectory(FBD.SelectedPath + "\\css");
                DirectoryInfo images = Directory.CreateDirectory(FBD.SelectedPath + "\\img");
                DirectoryInfo fon = Directory.CreateDirectory(FBD.SelectedPath + "\\fonts");
                if (!File.Exists(FBD.SelectedPath + "\\index.html"))
                {
                    FileStream fs = File.Create(FBD.SelectedPath + "\\index.html");
                    fs.Close();
                }
                if (!File.Exists(FBD.SelectedPath + "\\css\\basic.css"))
                {
                    FileStream fs = File.Create(FBD.SelectedPath + "\\css\\basic.css");
                    fs.Close();
                }
                Fulllist(FBD.SelectedPath);
                htmltext.Text = snippetstext;
                File.WriteAllText(FBD.SelectedPath + "\\index.html", snippetstext);
                CHTML = "index.html";
                CCSS = "basic.css";
            }
        }
        void Fulllist(String df)
        {
            html_file_list.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(df);
            DirectoryInfo d2 = new DirectoryInfo(df + "\\css");
            DirectoryInfo d3 = new DirectoryInfo(df + "\\img");
            DirectoryInfo d4 = new DirectoryInfo(df + "\\fonts");
            FileInfo[] HTMLFiles = d.GetFiles("*.html");
            FileInfo[] CSSFiles = d2.GetFiles("*.css");
            FileInfo[] IMGFiles = d3.GetFiles("*.*");
            FileInfo[] FONFiles = d4.GetFiles("*.*");
            foreach (FileInfo f in HTMLFiles)
            {
                pf[pfco].name = f.Name;
                pf[pfco].path = f.FullName;
                html_file_list.Items.Add(pf[pfco].name, 0);
                pfco++;
            }
            foreach (FileInfo f in CSSFiles)
            {
                pf[pfco].name = f.Name;
                pf[pfco].path = f.FullName;
                css_file_list.Items.Add(pf[pfco].name, 1);
                pfco++;
            }
            foreach (FileInfo f in IMGFiles)
            {
                pf[pfco].name = f.Name;
                pf[pfco].path = f.FullName;                
                iame_file_list.Items.Add(pf[pfco].name,2);                
                pfco++;
            }
            foreach (FileInfo f in FONFiles)
            {
                pf[pfco].name = f.Name;
                pf[pfco].path = f.FullName;
                font_file_list.Items.Add(pf[pfco].name,3);
                pfco++;
            }          
        }
        private void commetns_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            htmltext.SelectedText = "<!-- \n \n-->";
        }
        private void addclass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            classpanel.Visible = true;
        }
        void filecodepf()
        {
            for (int i = 0; i < pfco; i++)
            {
                if (pf[i].name != "")
                {
                    if (pf[i].name.Contains("html"))
                        pf[i].hcode = File.ReadAllText(pf[i].path);
                    if (pf[i].name.Contains("css"))
                        pf[i].ccode = File.ReadAllText(pf[i].path);
                }
            }
        }
        private void classok_Click(object sender, EventArgs e)
        {
            if (htmltext.SelectedText.Contains("<") && htmltext.SelectedText.Contains(">"))            
                htmltext.SelectedText = "<" + getBetween(htmltext.SelectedText, "<", ">") + " class=\"" + classname.Text + "\">";
            else
                MessageBox.Show("Invalid Tag");
            classname.Text = "";
            classpanel.Visible = false;
        }
        private void calsscancel_Click(object sender, EventArgs e)
        {
            classpanel.Visible = false;
            classname.Text = "";
        }
        private void bold_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            applaycss("font-weight: bold;");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                save_file.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.N))
            {
                new_project.PerformClick();
            }
            if (keyData == (Keys.Control | Keys.N))
            {
                open_project.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void color_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Color c = new Color();
            c.Show();
        }

        void makefile(string filetype)
        {
            string p2 = path;
            if (filetype == ".css")
                p2 = path + "\\css";
            if (!File.Exists(p2 + "\\" + file_name_box.Text + filetype))
            {
                FileStream fs = File.Create(p2 + "\\" + file_name_box.Text + filetype);
                fs.Close();
            }
            panel2.Visible = false;
            pf[pfco].name = file_name_box.Text + filetype;
            pf[pfco].path = p2 + "\\" + file_name_box.Text + filetype;
            if (filetype == ".html")
            {
                pf[pfco].hcode = snippetstext;
                File.WriteAllText(p2 + "\\" + file_name_box.Text + filetype, snippetstext);
            }
            else
                pf[pfco].ccode = "";
            pfco++;
            file_name_box.Text = "";
            updateautocompleat();
        }

        private void Font_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void FontWeightNormal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            applaycss("font-weight: normal;");

        }

        private void italic_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            applaycss("font-style: italic;");
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return null;
            }
        }
        public void applaycss(string cssvalue)
        {
            string str = htmltext.SelectedText;
            string[] css = csstext.Text.Split('.');
            if (!(str == ""))
            {
                if (csstext.Text.Contains(str))
                {
                    for (int i = 0; i < css.Length; i++)
                        if (css[i].Contains(str))
                        {
                            string css2 = getBetween(css[i], "{", "}");
                            if (!(css2.Contains(cssvalue)))
                                css2 += cssvalue + Environment.NewLine;
                            //if()
                            css[i] = str + "{" + css2 + "}";
                            break;
                        }
                    csstext.Text = "";
                    foreach (string s in css)
                        if (!(s == ""))
                            csstext.Text += "." + s + Environment.NewLine;
                }
                else
                {
                    csstext.Text += Environment.NewLine + "." + str + "{\n" + cssvalue + "\n}";
                }
            }
            else
            {
                MessageBox.Show("Invalid Class");
            }
        }
        //void applaycss(string csstoapplay)
        //{
        //    string str = htmltext.SelectedText;
        //    string[] css = csstext.Text.Split('.');
        //    if (!(str == ""))
        //    {
        //        if (csstext.Text.Contains(str))
        //        {
        //            for (int i = 0; i < css.Length; i++)
        //                if (css[i].Contains(str))
        //                {
        //                    string css2 = getBetween(css[i], "{", "}");
        //                    if (!(css2.Contains(csstoapplay)))
        //                        css2 += csstoapplay + Environment.NewLine;
        //                    css[i] = str + "{" + css2 + "}";
        //                    break;
        //                }
        //            csstext.Text = "";
        //            foreach (string s in css)
        //                if (!(s == ""))
        //                    csstext.Text += "." + s + Environment.NewLine;
        //        }
        //        else
        //        {
        //            csstext.Text += Environment.NewLine + "." + str + "{\n" + csstoapplay + "\n}";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Class");
        //    }
        //}

        void updateautocompleat()
        {
            List<AutocompleteItem> items = new List<AutocompleteItem>();

            foreach (var item in snippets)
                items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });

            foreach (var item in attributes)
                items.Add(new AutocompleteItem(item));
            items.Add(new InsertSpaceSnippet());
            items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
            items.Add(new InsertEnterSnippet());

            foreach(projectfiles p in pf)
            {
                if(p.name != null)
                {
                    if (p.name.Contains("html"))
                        items.Add(new AutocompleteItem(p.name));
                }
            }

            popupMenu.Items.SetAutocompleteItems(items);
        }
    }
}