using DevExpress.XtraNavBar;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MIcrosoftEdgeLauncherCsharp;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Easy_Web
{
    public struct projectfiles
    {
        public string path;
        public string name;
        public string hcode;
        public string ccode;
    }
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        // This function does all the work
       // [DllImport("Trial.dll", EntryPoint = "ReadSettingsStr", CharSet = CharSet.Ansi)]
       // static extern uint InitTrial(String aKeyCode, IntPtr aHWnd);

        // Use this function to register the application when the application is running
       // [DllImport("Trial.dll", EntryPoint = "DisplayRegistrationStr", CharSet = CharSet.Ansi)]
       // static extern uint DisplayRegistration(String aKeyCode, IntPtr aHWnd);

        // Use this function to silently register the license without displaying our registration dialog; when called the function saves the license (without validating it) on local machine and returns 0 for success or a different exit code otherwise
       // [DllImport("Trial.dll", EntryPoint = "RegisterStr", CharSet = CharSet.Unicode)]
       // static extern uint RegisterLicense(String aKeyCode, String aLicense);

       // private const string kLibraryKey = "A6141A5B7BC0F9839795C56DA9FD870FD0C506";

        private static void OnInit()
        {
            //try
            //{
                //Process process = Process.GetCurrentProcess();                
                //InitTrial(kLibraryKey, process.MainWindowHandle);
            //}
            //catch (DllNotFoundException ex)
            //{
            //    // Trial dll is missing close the application immediately.
            //    MessageBox.Show(ex.ToString());
            //    Process.GetCurrentProcess().Kill();
            //}
            //catch (Exception ex1)
            //{
            //    MessageBox.Show(ex1.ToString());
            //}
        }

        // Function called from the application menu, when registering it
        private void RegisterApp(object sender, EventArgs e)
        {
        ///    Process process = Process.GetCurrentProcess();
        //    DisplayRegistration(kLibraryKey, process.MainWindowHandle);
        }


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
                ,"width","crosshair","help","wait","auto","outset","all","always","avoid","grayscale","font-family"};
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

        public int cmse = 0 , pfco =0;
        public string CCSS, CHTML, path;

        string snippetstext = "<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <title>\n        my first web page\n    </title>\n    <link rel = \"stylesheet\" type=\"text/css\" href=\"./css/basic.css\">\n</head>\n<body>\n\n\n\n</body>\n</html>";

        AutocompleteMenu popupMenu;
        AutocompleteMenu popupMenu2;

        public projectfiles[] pf = new projectfiles[10000];
        private bool projopend;
        private cssfunctions cssfun = new cssfunctions();

        string projectname = string.Empty;
        public CSSPARSER parser; 

        private void open_project_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projopend)
            {
                Application.Restart();
            }

            FolderBrowserDialog f = new FolderBrowserDialog();
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] s = f.SelectedPath.Split('\\');
                projectname = s[s.Length - 1];
                this.Text = "Easy Web [" + projectname  + "]";
                if (Directory.Exists(f.SelectedPath + "\\css") && Directory.Exists(f.SelectedPath + "\\img") && Directory.Exists(f.SelectedPath + "\\fonts") && File.Exists(f.SelectedPath + "\\index.html") && File.Exists(f.SelectedPath + "\\css\\basic.css"))
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
                    projopend = !projopend;
                    foreach(projectfiles p in pf)
                    {
                        if(p.name != null)
                        {
                            if (p.name.Contains("index.html"))
                            {
                                htmltext.Text = p.hcode;
                                CHTML = p.name;
                                webBrowser1.Navigate(path + "\\" +p.name);
                            }
                            if (p.name.Contains("basic.css"))
                            {
                                csstext.Text = p.ccode;
                                CCSS = p.name;
                            }
                        }
                    }

                    settabname();

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
                settabname();
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
                settabname();
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
                            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                                htmltext.SelectedText = "./img/" + p.name;
                            else if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
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
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe\");

            string productName = (string)reg.GetValue("Path") + "\\firefox.exe";
            if (File.Exists(productName))
            {
                if (CHTML != null)
                {
                    string url = (path + "\\" + CHTML);
                    System.Diagnostics.Process.Start("firefox.exe", "\"" + url + "\"");
                }
            }
            else
                MessageBox.Show("Install Firefox");
        }
        private void Internet_Explorer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\iexplorer.exe\");

                string productName = (string)reg.GetValue("Path") + "\\iexplorer.exe";
                if (File.Exists(productName))
                {
                    if (CHTML != null)
                    {
                        string url = (path + "\\" + CHTML);
                        System.Diagnostics.Process.Start("iexplore.exe", "\"" + url + "\"");
                    }
                }
                else
                    MessageBox.Show("Install Internet Explorer");
            }
            catch(Exception g)
            {
                MessageBox.Show("Install Internet Explorer");
            }
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new_project.PerformClick();
        }
        private void file_c_Click(object sender, EventArgs e)
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
                            string extension =Path.GetExtension(p.name);
                            string result = p.name.Substring(0, p.name.Length - extension.Length);
                            csstext.Text = "@font-face {\n    font-family: " + result + ";\n    src: url(../fonts/"+ p.name +");\n}" + csstext.Text;
                        }
                    }
                }
            }
        }
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.ShowFindDialog();
            else if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.ShowFindDialog();
        }
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.ShowReplaceDialog();
            else if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
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
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                documentMap1.Target = htmltext;
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                documentMap1.Target = csstext;
        }
        private void new_project_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projopend)
            {
                Application.Restart();
            }
            cProject();
            tab.Enabled = true;
            css_file_list.Enabled = true;
            font_file_list.Enabled = true;
            html_file_list.Enabled = true;
            iame_file_list.Enabled = true;
            navBarControl1.Enabled = true;
            filecodepf();
            CHTML = "index.html";
            CCSS = "basic.css";
            status.Caption = "Project Created";
            settabname();
            projopend = !projopend;
        }
        void cProject()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                path = FBD.SelectedPath;
                string[] s = FBD.SelectedPath.Split('\\');
                projectname = s[s.Length - 1];
                this.Name = "Easy Web [" + projectname + "]";
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
                htmltext.SelectedText = this.cssfun.applyclass(htmltext.SelectedText, classname.Text);

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
            string str = htmltext.SelectedText;
            parser.SetCSS(csstext.Text);
            parser.AddPropery(str, "font-weight", "bold");
            csstext.Text = parser.ToString();
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
            ChangeFont cf = new ChangeFont();
            cf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parser = new CSSPARSER();
            OnInit();
            string[] textArray1 = new string[] {
       "bounce", "flash", "pulse", "rubberBand", "shake", "headShake", "swing", "tada", "wobble", "jello", "bounceIn", "bounceInDown", "bounceInLeft", "bounceInRight", "bounceInUp", "bounceOut",
       "bounceOutDown", "bounceOutLeft", "bounceOutRight", "bounceOutUp", "fadeIn", "fadeInDown", "fadeInDownBig", "fadeInLeft", "fadeInLeftBig", "fadeInRight", "fadeInRightBig", "fadeInUp", "fadeInUpBig", "fadeOut", "fadeOutDown", "fadeOutDownBig",
       "fadeOutLeft", "fadeOutLeftBig", "fadeOutRight", "fadeOutRightBig", "fadeOutUp", "fadeOutUpBig", "flipInX", "flipInY", "flipOutX", "flipOutY", "lightSpeedIn", "lightSpeedOut", "rotateIn", "rotateInDownLeft", "rotateInDownRight", "rotateInUpLeft",
       "rotateInUpRight", "rotateOut", "rotateOutDownLeft", "rotateOutDownRight", "rotateOutUpLeft", "rotateOutUpRight", "hinge", "rollIn", "rollOut", "zoomIn", "zoomInDown", "zoomInLeft", "zoomInRight", "zoomInUp", "zoomOut", "zoomOutDown",
       "zoomOutLeft", "zoomOutRight", "zoomOutUp", "slideInDown", "slideInLeft", "slideInRight", "slideInUp", "slideOutDown", "slideOutLeft", "slideOutRight", "slideOutUp"
        };
            foreach (string str in textArray1)
            {
                NavBarItem ContentsItem = navBarControl1.Items.Add();
                ContentsItem.Caption = "Contents";
                ContentsItem.Caption = str;
                ContentsItem.LinkClicked += new NavBarLinkEventHandler(this.ContentsItem_LinkClicked);
                navBarGroup3.ItemLinks.Add(ContentsItem);
            }
            textArray1 = new string[]{ "w3-red","w3-pink","w3-purple","w3-deep-purple","w3-indigo","w3-blue","w3-light-blue","w3-cyan","w3-aqua","w3-teal","w3-green","w3-light-green","w3-lime","w3-sand","w3-khaki","w3-yellow","w3-amber","w3-orange","w3-deep-orange","w3-blue-grey","w3-brown","w3-light-grey","w3-grey","w3-dark-grey","w3-black","w3-pale-red","w3-pale-yellow","w3-pale-green","w3-pale-blue"
,"w3-container","w3-section","w3-border","w3-border-top","w3-border-right","w3-border-bottom","w3-border-left","w3-border-0"
,"w3-bottombar","w3-leftbar","w3-rightbar","w3-topbar"
,"w3-border-red","w3-border-pink","w3-border-purple","w3-border-deep-purple","w3-border-indigo","w3-border-blue","w3-border-light-blue","w3-border-cyan","w3-border-aqua","w3-border-teal","w3-border-green","w3-border-light-green","w3-border-lime","w3-border-sand","w3-border-khaki","w3-border-yellow","w3-border-amber","w3-border-orange","w3-border-deep-orange","w3-border-blue-grey","w3-border-brown","w3-border-light-grey","w3-border-grey","w3-border-dark-grey","w3-border-black","w3-border-pale-red","w3-border-pale-yellow","w3-border-pale-green","w3-border-pale-blue"
,"w3-hover-border-red","w3-hover-border-pink","w3-hover-border-purple","w3-hover-border-deep-purple","w3-hover-border-indigo","w3-hover-border-blue","w3-hover-border-light-blue","w3-hover-border-cyan","w3-hover-border-aqua","w3-hover-border-teal","w3-hover-border-green","w3-hover-border-light-green","w3-hover-border-lime","w3-hover-border-sand","w3-hover-border-khaki","w3-hover-border-yellow","w3-hover-border-amber","w3-hover-border-orange","w3-hover-border-deep-orange","w3-hover-border-blue-grey","w3-hover-border-brown","w3-hover-border-light-grey","w3-hover-border-grey","w3-hover-border-dark-grey","w3-hover-border-black","w3-hover-border-pale-red","w3-hover-border-pale-yellow","w3-hover-border-pale-green","w3-hover-border-pale-blue"
,"w3-panel","w3-card","w3-card-2","w3-card-4","w3-card-8","w3-card-12","w3-card-16","w3-card-24"
,"w3-tiny","w3-small","w3-medium","w3-large","w3-xlarge","w3-xxlarge","w3-xxxlarge","w3-jumbo"
,"w3-left-align","w3-right-align","w3-center","w3-wide","w3-slim","w3-text-shadow","w3-opacity"
,"w3-round","w3-round-small","w3-round-medium","w3-round-large","w3-round-xlarge","w3-round-xxlarge","w3-round-jumbo","w3-circle"
,"w3-padding-4","w3-padding-8","w3-padding-12","w3-padding-16","w3-padding-24","w3-padding-32","w3-padding-48","w3-padding-64","w3-padding-128","w3-padding-0"
,"w3-padding","w3-padding-tiny","w3-padding-small","w3-padding-medium","w3-padding-large","w3-padding-xlarge","w3-padding-xxlarge","w3-padding-jumbo"
,"w3-margin","w3-margin-top","w3-margin-right","w3-margin-bottom","w3-margin-left","w3-margin-0","w3-section"
,"w3-display-container","w3-display-topleft","w3-display-topright","w3-display-bottomleft","w3-display-bottomright","w3-display-middle","w3-display-topmiddle","w3-display-bottommiddle"
,"w3-btn","w3-serif","fa","fa-quote-right","w3-closebtn"
,"w3-table","w3-striped","w3-border","w3-bordered","w3-centered","w3-hoverable","w3-table-all"
,"w3-hover-opacity","w3-hover-opacity-off","w3-label","w3-input","w3-validate"
,"w3-text-red","w3-text-pink","w3-text-purple","w3-text-deep-purple","w3-text-indigo","w3-text-blue","w3-text-light-blue","w3-text-cyan","w3-text-aqua","w3-text-teal","w3-text-green","w3-text-light-green","w3-text-lime","w3-text-sand","w3-text-khaki","w3-text-yellow","w3-text-amber","w3-text-orange","w3-text-deep-orange","w3-text-blue-grey","w3-text-brown","w3-text-light-grey","w3-text-grey","w3-text-dark-grey","w3-text-black","w3-text-pale-red","w3-text-pale-yellow","w3-text-pale-green","w3-text-pale-blue"
,"w3-round","w3-animate-input","w3-half","w3-badge","w3-tag"
,"fa fa-home","fa fa-bars","fa fa-arrow-left","fa fa-arrow-right","fa fa-search","fa fa-close","fa fa-refresh","fa fa-trash","fa fa-male","fa fa-car","fa fa-truck","fa fa-plane"
};
            foreach (string str in textArray1)
            {
                NavBarItem ContentsItem = navBarControl1.Items.Add();
                ContentsItem.Caption = "Contents";
                ContentsItem.Caption = str;
                ContentsItem.LinkClicked += new NavBarLinkEventHandler(this.ContentsItem3_LinkClicked);
                navBarGroup5.ItemLinks.Add(ContentsItem);
            }

            textArray1 = new string[]{
                "navbar","caret","label","table","img-responsive","img-rounded","img-thumbnail","img-circle"
,"sr-only","lead","text-muted","text-primary","text-warning","text-danger","text-success"
,"text-info","text-left","text-right","text-center","h6","h1","h2","h3","h4","h5","page-header"
,"list-unstyled","list-inline","initialism","pull-right","prettyprint","pre-scrollable","container"
,"row","col-lg-12","col-xs-11","col-xs-1","col-xs-2","col-xs-3","col-xs-4","col-xs-5","col-xs-6"
,"col-xs-7","col-xs-8","col-xs-9","col-xs-10","col-xs-12","col-sm-11","col-sm-1","col-sm-2"
,"col-sm-3","col-sm-4","col-sm-5","col-sm-6","col-sm-7","col-sm-8","col-sm-9","col-sm-10"
,"col-sm-12","col-sm-push-1","col-sm-push-2","col-sm-push-3","col-sm-push-4","col-sm-push-5"
,"col-sm-push-6","col-sm-push-7","col-sm-push-8","col-sm-push-9","col-sm-push-10","col-sm-push-11"
,"col-sm-pull-1","col-sm-pull-2","col-sm-pull-3","col-sm-pull-4","col-sm-pull-5","col-sm-pull-6"
,"col-sm-pull-7","col-sm-pull-8","col-sm-pull-9","col-sm-pull-10","col-sm-pull-11","col-sm-offset-1"
,"col-sm-offset-2","col-sm-offset-3","col-sm-offset-4","col-sm-offset-5","col-sm-offset-6"
,"col-sm-offset-7","col-sm-offset-8","col-sm-offset-9","col-sm-offset-10","col-sm-offset-11"
,"col-md-11","col-md-1","col-md-2","col-md-3","col-md-4","col-md-5","col-md-6","col-md-7","col-md-8"
,"col-md-9","col-md-10","col-md-12","col-md-push-0","col-md-push-1","col-md-push-2","col-md-push-3","col-md-push-4"
,"col-md-push-5","col-md-push-6","col-md-push-7","col-md-push-8","col-md-push-9","col-md-push-10"
,"col-md-push-11","col-md-pull-0","col-md-pull-1","col-md-pull-2","col-md-pull-3","col-md-pull-4"
,"col-md-pull-5","col-md-pull-6","col-md-pull-7","col-md-pull-8","col-md-pull-9","col-md-pull-10"
,"col-md-pull-11","col-md-offset-0","col-md-offset-1","col-md-offset-2","col-md-offset-3","col-md-offset-4"
,"col-md-offset-5","col-md-offset-6","col-md-offset-7","col-md-offset-8","col-md-offset-9","col-md-offset-10"
,"col-md-offset-11","col-lg-11","col-lg-1","col-lg-2","col-lg-3","col-lg-4","col-lg-5","col-lg-6","col-lg-7"
,"col-lg-8","col-lg-9","col-lg-10","col-lg-push-0","col-lg-push-1","col-lg-push-2","col-lg-push-3","col-lg-push-4"
,"col-lg-push-5","col-lg-push-6","col-lg-push-7","col-lg-push-8","col-lg-push-9","col-lg-push-10","col-lg-push-11"
,"col-lg-pull-0","col-lg-pull-1","col-lg-pull-2","col-lg-pull-3","col-lg-pull-4","col-lg-pull-5","col-lg-pull-6"
,"col-lg-pull-7","col-lg-pull-8","col-lg-pull-9","col-lg-pull-10","col-lg-pull-11","col-lg-offset-0","col-lg-offset-1"
,"col-lg-offset-2","col-lg-offset-3","col-lg-offset-4","col-lg-offset-5","col-lg-offset-6","col-lg-offset-7","col-lg-offset-8"
,"col-lg-offset-9","col-lg-offset-10","col-lg-offset-11","table-bordered","table-responsive","form-control","form-group","checkbox"
,"checkbox-inline","input-sm","input-lg","control-label","input-group-addon","form-control-static","help-block"
,"btn","active","btn-default","btn-primary","btn-warning","btn-danger","btn-success","btn-info"
,"btn-link","btn-lg","btn-xs","btn-block","fade","in","collapse","collapsing","glyphicon","dropdown"
,"dropdown-menu","divider","dropdown-header","dropdown-backdrop","btn-group-vertical","btn-group"
,"dropdown-toggle","btn-group-justified","input-group","col","input-group-btn","nav","nav-divider"
,"nav-tabs","nav-justified","nav-tabs-justified","pill-pane","navbar-header","navbar-collapse","navbar-static-top"
,"navbar-fixed-bottom","navbar-fixed-top","navbar-brand","navbar-toggle","icon-bar","navbar-nav","navbar-left"
,"navbar-right","navbar-form","navbar-btn","navbar-text","navbar-default","navbar-link","navbar-inverse"
,"breadcrumb","pagination","pager","label-default","label-primary","label-success","label-info","label-warning"
,"label-danger","badge","jumbotron","thumbnail","caption","alert","alert-link","alert-dismissable","close"
,"alert-success","alert-info","alert-warning","alert-danger","progress","progress-bar","progress-bar-success","progress-bar-info"
,"progress-bar-warning","progress-bar-danger","media-body","media","media-object","media-heading","pull-left"
,"media-list","list-group","list-group-item","list-group-item-heading","list-group-item-text"
,"panel","panel-body","panel-heading","panel-title","panel-footer","panel-default","panel-primary"
,"panel-success","panel-warning","panel-danger","panel-info","well","well-lg","well-sm","modal-open"
,"modal","modal-dialog","modal-content","modal-backdrop","modal-header","modal-title","modal-body"
,"modal-footer","tooltip","top","right","bottom","left","tooltip-inner","tooltip-arrow","popover"
,"popover-title","popover-content","arrow","carousel","carousel-inner","item","prev","next","carousel-control","glyphicon-chevron-right","icon-next","carousel-indicators","carousel-caption","hide","show","invisible","text-hide","affix","hidden","visible-xs","visible-sm","visible-md","visible-lg","hidden-xs","hidden-sm","hidden-md","hidden-lg","visible-print","hidden-print"
};
            foreach (string str in textArray1)
            {
                NavBarItem ContentsItem = navBarControl1.Items.Add();
                ContentsItem.Caption = "Contents";
                ContentsItem.Caption = str;
                ContentsItem.LinkClicked += new NavBarLinkEventHandler(this.ContentsItem2_LinkClicked);
                navBarGroup4.ItemLinks.Add(ContentsItem);
            }

            this.WindowState = FormWindowState.Maximized;
            MouseStrip.BackColor = this.BackColor;
            MouseStrip.ForeColor = this.ForeColor;
        }

        private void ContentsItem3_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string str;
            if (!File.Exists(this.path + "\\css\\w3.css"))
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Files\\w3.css"))
                {
                    File.Copy(Environment.CurrentDirectory + "\\Files\\w3.css", path + "\\css\\w3.css", true);
                }
            }
            if (this.htmltext.SelectedText.Contains("<") && this.htmltext.SelectedText.Contains(">"))
            {
                this.htmltext.SelectedText = this.cssfun.applyclass(htmltext.SelectedText, e.Link.Caption);
            }
            else
                MessageBox.Show("Invalid");
            str = "<link rel = \"stylesheet\" type=\"text/css\" href=\"./css/w3.css\">";
            if (!(htmltext.Text.Contains(str)))
            {
                this.htmltext.Text = this.htmltext.Text.Replace("</head>", "<link rel = \"stylesheet\" type=\"text/css\" href=\"./css/w3.css\">\n</head>");
            }
        }

        private void ContentsItem2_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string str;
            string str2;
            if (!File.Exists(this.path + "\\css\\bootstrap.css"))
            {
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap.css", path + "\\css\\bootstrap.css", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap.css.map", path + "\\css\\bootstrap.css.map", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap.min.css", path + "\\css\\bootstrap.min.css", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap.min.css.map", path + "\\css\\bootstrap.min.css.map", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap-theme.css", path + "\\css\\bootstrap-theme.css", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap-theme.css.map", path + "\\css\\bootstrap-theme.css.map", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap-theme.min.css", path + "\\css\\bootstrap-theme.min.css", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\bootstrap-theme.min.css.map", path + "\\css\\bootstrap-theme.min.css", true);

                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\glyphicons-halflings-regular.eot", path + "\\fonts\\glyphicons-halflings-regular.eot", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\glyphicons-halflings-regular.svg", path + "\\fonts\\glyphicons-halflings-regular.svg", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\glyphicons-halflings-regular.ttf", path + "\\fonts\\glyphicons-halflings-regular.ttf", true);
                File.Copy(Environment.CurrentDirectory + "\\Files\\boot\\glyphicons-halflings-regular.woff", path + "\\fonts\\glyphicons-halflings-regular.woff", true);

            }
            if (this.htmltext.SelectedText.Contains("<") && this.htmltext.SelectedText.Contains(">"))
            {
                this.htmltext.SelectedText = this.cssfun.applyclass(htmltext.SelectedText, e.Link.Caption);
            }
            else
                MessageBox.Show("Invalid");
            str = "<link rel = \"stylesheet\" type=\"text/css\" href=\"./css/bootstrap.min.css\">";
            if (!(htmltext.Text.Contains(str)))
            {
                this.htmltext.Text = this.htmltext.Text.Replace("</head>", "<link rel = \"stylesheet\" type=\"text/css\" href=\"./css/bootstrap.min.css\">\n</head>");
            }
        }

        private void ContentsItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string str;
            string str2;
            if (!File.Exists(this.path + "\\css\\animate.css"))
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Files\\ani\\animate.css"))
                {
                    File.Copy(Environment.CurrentDirectory + "\\Files\\ani\\animate.css", path + "\\css\\animate.css", true);
                }
            }
            str2 = htmltext.SelectedText.Replace("animated", "");
                if (this.htmltext.SelectedText.Contains("<") && this.htmltext.SelectedText.Contains(">"))
                {
                    this.htmltext.SelectedText = this.cssfun.applyclass(str2, "animated " + e.Link.Caption);
                }
                else
                    MessageBox.Show("Invalid");
            str = "<link rel = \"stylesheet\" type=\"text/css\" href=\"./css/animate.css\">";
            if (!(htmltext.Text.Contains(str)))
            {
                this.htmltext.Text = this.htmltext.Text.Replace("</head>", "<link rel = \"stylesheet\" type=\"text/css\" href=\"./css/animate.css\">\n</head>");
            }
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void FontWeightNormal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string str = htmltext.SelectedText;
            parser.SetCSS(csstext.Text);
            parser.AddPropery(str, "font-weight", "normal");
            csstext.Text = parser.ToString();

        }

        private void italic_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string str = htmltext.SelectedText;
            parser.SetCSS(csstext.Text);
            parser.AddPropery(str, "font-style", "italic");
            csstext.Text = parser.ToString();
        }

        private void Fontsize_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FontSize f = new FontSize();
            f.Show();
        }

        private void backgroundrepeaty_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string str = htmltext.SelectedText;
            parser.SetCSS(csstext.Text);
            parser.AddPropery(str, "background-repeat", "repeat-y");
            csstext.Text = parser.ToString();
        }

        private void repeatx_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string str = htmltext.SelectedText;
            parser.SetCSS(csstext.Text);
            parser.AddPropery(str, "background-repeat", "repeat-x");
            csstext.Text = parser.ToString();
        }

        private void BackgroundRepeatno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string str = htmltext.SelectedText;
            parser.SetCSS(csstext.Text);
            parser.AddPropery(str, "background-repeat", "no-repeat");
            csstext.Text = parser.ToString(); 
        }

        private void Borderwidth_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            borderwidth b = new borderwidth();
            b.ShowDialog();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            opacity o = new opacity();
            o.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            List<string> list = new List<string> ();
            for (int i = 0; i < pfco; i++)
            {

                if (pf[i].path.Contains("jpg") || pf[i].path.Contains("png") | pf[i].path.Contains("bmp") | pf[i].name.Contains("gif"))
                {
                    list.Add(pf[i].path);
                }
            }
            BImage j = new BImage(list.ToArray());
            j.Show();
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
        
        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsWindows10())
            {
                if (CHTML != null)
                {
                    string url = (path + "\\" + CHTML);
                    Process process = new Process();

                    // Stop the process from opening a new window
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    // Setup executable and parameters
                    process.StartInfo.FileName = Environment.CurrentDirectory + "\\MIcrosoftEdgeLauncherCsharp.exe";
                    process.StartInfo.Arguments = "\"" + url + "\"";

                    // Go
                    process.Start();

                }
            }
            else
                MessageBox.Show("Windows 10 is Required");
        }

        static bool IsWindows10()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            string productName = (string)reg.GetValue("ProductName");

            return productName.StartsWith("Windows 10");
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonItem20.PerformClick();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.ShowGoToDialog();
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.ShowGoToDialog();
        }
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            shotcutkeys s = new shotcutkeys();
            s.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.SelectedText = "";
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.SelectedText = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.Cut();
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.Copy();
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.Paste();
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tab.SelectedTabPage.Text.Substring(0, "Source".Length) == "Source")
                htmltext.SelectAll();
            if (tab.SelectedTabPage.Text.Substring(0, "CSS".Length) == "CSS")
                csstext.SelectAll();
        }

        private void iame_file_list_MouseClick(object sender, MouseEventArgs e)
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
                            ImageV.BringToFront();
                        }
                    }
                }
            }
        }

        private void classname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                classok.PerformClick();
        }

        private void file_name_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                file_ok.PerformClick();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = this.Width - 330;

        }
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
                    //if (p.name.Contains("html"))
                        items.Add(new AutocompleteItem(p.name));
                    items.Add(new AutocompleteItem(p.path));
                }
            }
            popupMenu.Items.SetAutocompleteItems(items);
        }
        private void settabname()
        {
            tab.TabPages[0].Text = "Source[" + CHTML + "]";
            tab.TabPages[1].Text = "CSS[" + CCSS + "]";
            tab.TabPages[2].Text = "Live[" + CHTML + "]";
        }
    }
}