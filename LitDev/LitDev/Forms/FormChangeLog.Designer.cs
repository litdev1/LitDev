namespace LitDev
{
    partial class FormChangeLog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Moving to .Net 4.8 to add new stuff");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("FindImageInImage method added");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("GetTextFromImage method added");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Fix for speech recognition");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Debug property added");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ScaleWidth method added");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("InputBox uses LDDialogs.SetStartupPosition");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ResetFocus method added");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("LastKeyReset method added");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("LastKeyReset method added");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Version 1.2.29.14", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode9,
            treeNode11,
            treeNode13,
            treeNode15,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("GetCollisions returns chain/rope name");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("GetAcceleration method added");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Fix for chains and ropes with non default scaling");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables modified to handle LF,CR");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Angle method added");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("TextAlignment method added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Version 1.2.29.0", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode24,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Increase default AABB for larger display");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
        "");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Exit event added");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("DataViewFont method added");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("CallIncludeWithVars method added");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("GetOriginPosition method added");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Allow longer duration animations");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("LoadModel ignore bad objects");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("GetOffset method added");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("WSAD keys for AutoControl only active if GW active");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Query updated to be similar to LDControls method");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Improved so that listview can use LDControls methods");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("CreateSpline and InterpolateSpline methods added");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("MathX", new System.Windows.Forms.TreeNode[] {
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Version 1.2.28.0", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode33,
            treeNode35,
            treeNode37,
            treeNode43,
            treeNode46,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("RichTextBoxWord method extended");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("TextBoxSelection method added");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("RichTextBoxSelectionChanged event added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("RichLastTextBoxSelection property added");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("RichTextBoxMousePosition method added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("RichTextBoxCaretPosition method added");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("RichTextBoxCaretCoordinates method added");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("RichTextBoxWholeWord property added");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("RichTextBoxInsert method added");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("GetAllShapesAt updated to handle RTB");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Compiler property added");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("GW and TW aliases added");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Aliases", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("LF, CR, SQ, DQ, BS special characters added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("InputBox method added");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("TurtleSpeed property added");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Version 1.2.27.0", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode62,
            treeNode64,
            treeNode66,
            treeNode68,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Update API");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("LoadImage replacement for Imagelist method that can download Flickr images");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Update HelixToolkit");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
        "ial methods added");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("AddBackImage bug fixed");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Performance improvement for \'sleeping\' shapes");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Updated intellisense");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Version 1.2.26.0", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode75,
            treeNode79,
            treeNode81,
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Network Security Protocol fixes (SSL)");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("SetSSL method added");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("FixFlickr updates for new api key");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Separate download required");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("SmallVisualBasic (sVB) support", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Version 1.2.25.0", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode87,
            treeNode89,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Reinstated website");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("API updated to MS Cognitive");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("CaptureScreen method added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Fix for ListFiles");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("WriteFromArray method added");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Object added (code by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Suppress javascript popup error messages");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Version 1.2.23.0", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode98,
            treeNode100,
            treeNode102,
            treeNode104,
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("SaveTableBySQL method added");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Object added by Abhishek Sathiabalan");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode109,
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDHashTable object added (code from Abhishek Sathiabalan)", new System.Windows.Forms.TreeNode[] {
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Some Nuget packages used (suggested by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Various performance improvements (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDGeography (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("AvailableCultures method added");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("FixFlickr updated for API change");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode117,
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Version 1.2.22.0", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("GetImage method improved to fix thread issue");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode121});
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("ReadByteArray and WriteByteArray methods added");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("RenameRoot method added");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("View method added");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("LDXML", new System.Windows.Forms.TreeNode[] {
            treeNode125,
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Update to Azure");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Version 1.2.21.0", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode124,
            treeNode127,
            treeNode129,
            treeNode131});
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("Correctly handles pie segments greater than 180 degrees");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Decimal2Base works for number 0 in all bases");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Updated currency API");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Version 1.2.20.0", new System.Windows.Forms.TreeNode[] {
            treeNode134,
            treeNode136,
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Fix for ReSize for some controls");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Fix for GetLeft and GetTop for shapes that have not been positioned yet");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode140,
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("AddPyramid shape fixed");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("New object to create icons and cursors added");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("LDIcon", new System.Windows.Forms.TreeNode[] {
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Fix for View (non-modal)");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Version 1.2.19.0", new System.Windows.Forms.TreeNode[] {
            treeNode142,
            treeNode144,
            treeNode146,
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("SetBackMaterial and AddBackImage methods added");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Version 1.2.18.0", new System.Windows.Forms.TreeNode[] {
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("Fast text appending method added");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("Volume method added");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode161});
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("Modified to use Google API since MS version is depreciated");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("FloodFillTolerance property added");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode165});
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("And and Or renamed And_ and Or_");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("SendClick method added");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode169});
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("Version 1.2.17.0", new System.Windows.Forms.TreeNode[] {
            treeNode154,
            treeNode156,
            treeNode158,
            treeNode160,
            treeNode162,
            treeNode164,
            treeNode166,
            treeNode168,
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("SHA512HashFile method added");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Broadcast method added");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDServer", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("AutoControl2 scene camera mode added (for model inspection)");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Various auto control improvements");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("SwapUpDirection method added");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode177,
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("Improved PauseUpdates and ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("LDGraphicsWIndow", new System.Windows.Forms.TreeNode[] {
            treeNode180});
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("3D vector algebra methods added");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDVector", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("LastListViewColumn event property added");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("ListView subscribes to LDControls selection events");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Version 1.2.16.0", new System.Windows.Forms.TreeNode[] {
            treeNode173,
            treeNode175,
            treeNode179,
            treeNode181,
            treeNode183,
            treeNode185,
            treeNode187});
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("Read and Write methods extended to read and write unindexed lines for 1D arrays");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("Animate method added");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("Fix for indent tab for non-paragraph rtf blocks");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("ResetMaterial method added");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("GetPosition method added");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode197,
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("RSA public private key methods added");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode190,
            treeNode192,
            treeNode194,
            treeNode196,
            treeNode199,
            treeNode201});
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode203});
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode205});
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode209,
            treeNode210,
            treeNode211,
            treeNode212,
            treeNode213,
            treeNode214,
            treeNode215,
            treeNode216,
            treeNode217,
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode220,
            treeNode221});
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode224,
            treeNode225,
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode204,
            treeNode206,
            treeNode208,
            treeNode219,
            treeNode222,
            treeNode227,
            treeNode229});
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode236,
            treeNode237,
            treeNode238,
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode241,
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode232,
            treeNode234,
            treeNode240,
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode249});
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode253});
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode248,
            treeNode250,
            treeNode252,
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode256,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode261,
            treeNode262,
            treeNode263});
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode267,
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode258,
            treeNode260,
            treeNode264,
            treeNode266,
            treeNode269});
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode273,
            treeNode274,
            treeNode275,
            treeNode276,
            treeNode277,
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode280});
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode282,
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode272,
            treeNode279,
            treeNode281,
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode288});
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode290});
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode292,
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode295,
            treeNode296});
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode287,
            treeNode289,
            treeNode291,
            treeNode294,
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode301});
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode303});
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode300,
            treeNode302,
            treeNode304,
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode308});
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode310,
            treeNode311});
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode313});
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode315,
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode318});
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode312,
            treeNode314,
            treeNode317,
            treeNode319,
            treeNode321});
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode325,
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode330,
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode324,
            treeNode327,
            treeNode329,
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode334,
            treeNode335});
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode341});
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode345});
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode336,
            treeNode338,
            treeNode340,
            treeNode342,
            treeNode344,
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode348,
            treeNode349,
            treeNode350});
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode353,
            treeNode355});
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode361,
            treeNode362,
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode365,
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode358,
            treeNode360,
            treeNode364,
            treeNode367});
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode370,
            treeNode372,
            treeNode374,
            treeNode376,
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode383});
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode387});
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode389});
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode384,
            treeNode386,
            treeNode388,
            treeNode390});
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode393,
            treeNode395,
            treeNode397});
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode399});
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode401});
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode403});
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode400,
            treeNode402,
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode406,
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode409,
            treeNode410,
            treeNode411,
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode408,
            treeNode413,
            treeNode415,
            treeNode417});
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode425});
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode420,
            treeNode422,
            treeNode424,
            treeNode426,
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode431,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode435});
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode437});
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode439});
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode436,
            treeNode438,
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode445,
            treeNode446,
            treeNode447,
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode450,
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode453,
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode449,
            treeNode452,
            treeNode455,
            treeNode457});
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode459,
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode464});
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode461,
            treeNode463,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode467,
            treeNode468});
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode470});
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode469,
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode473,
            treeNode474,
            treeNode475,
            treeNode476,
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode479,
            treeNode480,
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode478,
            treeNode482,
            treeNode484,
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode490});
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode496});
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode500});
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode489,
            treeNode491,
            treeNode493,
            treeNode495,
            treeNode497,
            treeNode499,
            treeNode501});
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode503,
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode505,
            treeNode507});
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode511,
            treeNode512,
            treeNode513,
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode510,
            treeNode515});
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode519,
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode522,
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode527});
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode518,
            treeNode521,
            treeNode524,
            treeNode526,
            treeNode528,
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode532,
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode539,
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode542});
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode534,
            treeNode536,
            treeNode538,
            treeNode541,
            treeNode543,
            treeNode545,
            treeNode547});
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode549});
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode552,
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode554,
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode558,
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode560,
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode564,
            treeNode565,
            treeNode566,
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode568,
            treeNode570,
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode580});
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode575,
            treeNode577,
            treeNode579,
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode584});
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode586,
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode589,
            treeNode590});
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode594,
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode588,
            treeNode591,
            treeNode593,
            treeNode596,
            treeNode598,
            treeNode600,
            treeNode602,
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode606,
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode608,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode617});
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode619,
            treeNode620,
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode616,
            treeNode618,
            treeNode622});
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode626,
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode625,
            treeNode628,
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode634,
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode633,
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode639,
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode645,
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode644,
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode652,
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode661,
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode654,
            treeNode656,
            treeNode658,
            treeNode660,
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode669,
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode674,
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode681,
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode683,
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode687,
            treeNode688});
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode691});
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode694,
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode696,
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode700,
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode708,
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode705,
            treeNode707,
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode712});
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode714,
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode713,
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode718,
            treeNode719,
            treeNode720,
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode728,
            treeNode730,
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode735,
            treeNode737,
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode745,
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode742,
            treeNode744,
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode757,
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode756,
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode761,
            treeNode762,
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode768});
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode767,
            treeNode769,
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode774,
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode778});
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode780,
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode779,
            treeNode782});
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode788,
            treeNode790,
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode795,
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode799,
            treeNode800});
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode812,
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode803,
            treeNode805,
            treeNode807,
            treeNode809,
            treeNode811,
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode816,
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode818,
            treeNode820,
            treeNode822});
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode826});
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode825,
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode829,
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode831,
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode840,
            treeNode841,
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode839,
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode850,
            treeNode851});
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode849,
            treeNode852,
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode857});
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode862,
            treeNode863});
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode866,
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode885});
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode891,
            treeNode892});
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode895});
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode899});
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode901});
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode902});
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode907});
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode909});
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode904,
            treeNode906,
            treeNode908,
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode914,
            treeNode915});
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode917});
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode916,
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode921});
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode923});
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode920,
            treeNode922,
            treeNode924});
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode926});
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode927,
            treeNode929});
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode931});
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode933});
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode932,
            treeNode934});
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode937 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode936});
            System.Windows.Forms.TreeNode treeNode938 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode937});
            System.Windows.Forms.TreeNode treeNode939 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode940 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode939});
            System.Windows.Forms.TreeNode treeNode941 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode940});
            System.Windows.Forms.TreeNode treeNode942 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode943 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode942});
            System.Windows.Forms.TreeNode treeNode944 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode943});
            System.Windows.Forms.TreeNode treeNode945 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode946 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode945});
            System.Windows.Forms.TreeNode treeNode947 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode946});
            System.Windows.Forms.TreeNode treeNode948 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode949 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode950 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode948,
            treeNode949});
            System.Windows.Forms.TreeNode treeNode951 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode952 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode951});
            System.Windows.Forms.TreeNode treeNode953 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode950,
            treeNode952});
            System.Windows.Forms.TreeNode treeNode954 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode955 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode954});
            System.Windows.Forms.TreeNode treeNode956 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode955});
            System.Windows.Forms.TreeNode treeNode957 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode958 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode957});
            System.Windows.Forms.TreeNode treeNode959 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode958});
            System.Windows.Forms.TreeNode treeNode960 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode961 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode960});
            System.Windows.Forms.TreeNode treeNode962 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode961});
            System.Windows.Forms.TreeNode treeNode963 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode964 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode965 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode963,
            treeNode964});
            System.Windows.Forms.TreeNode treeNode966 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode967 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode966});
            System.Windows.Forms.TreeNode treeNode968 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode969 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode970 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode968,
            treeNode969});
            System.Windows.Forms.TreeNode treeNode971 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode965,
            treeNode967,
            treeNode970});
            System.Windows.Forms.TreeNode treeNode972 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode973 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode972});
            System.Windows.Forms.TreeNode treeNode974 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode973});
            System.Windows.Forms.TreeNode treeNode975 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode976 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode975});
            System.Windows.Forms.TreeNode treeNode977 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode976});
            System.Windows.Forms.TreeNode treeNode978 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode979 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode980 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode978,
            treeNode979});
            System.Windows.Forms.TreeNode treeNode981 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode980});
            System.Windows.Forms.TreeNode treeNode982 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode983 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode984 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode985 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode982,
            treeNode983,
            treeNode984});
            System.Windows.Forms.TreeNode treeNode986 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode987 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode986});
            System.Windows.Forms.TreeNode treeNode988 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode989 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode988});
            System.Windows.Forms.TreeNode treeNode990 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode985,
            treeNode987,
            treeNode989});
            System.Windows.Forms.TreeNode treeNode991 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode992 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode993 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode991,
            treeNode992});
            System.Windows.Forms.TreeNode treeNode994 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode995 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode994});
            System.Windows.Forms.TreeNode treeNode996 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode993,
            treeNode995});
            System.Windows.Forms.TreeNode treeNode997 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode998 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode997});
            System.Windows.Forms.TreeNode treeNode999 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode1000 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode999});
            System.Windows.Forms.TreeNode treeNode1001 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode998,
            treeNode1000});
            System.Windows.Forms.TreeNode treeNode1002 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode1003 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode1002});
            System.Windows.Forms.TreeNode treeNode1004 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode1005 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode1004});
            System.Windows.Forms.TreeNode treeNode1006 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode1007 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1006});
            System.Windows.Forms.TreeNode treeNode1008 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode1009 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1008});
            System.Windows.Forms.TreeNode treeNode1010 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode1003,
            treeNode1005,
            treeNode1007,
            treeNode1009});
            System.Windows.Forms.TreeNode treeNode1011 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode1012 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1011});
            System.Windows.Forms.TreeNode treeNode1013 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode1012});
            System.Windows.Forms.TreeNode treeNode1014 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode1015 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1014});
            System.Windows.Forms.TreeNode treeNode1016 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode1015});
            System.Windows.Forms.TreeNode treeNode1017 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode1018 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1017});
            System.Windows.Forms.TreeNode treeNode1019 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode1020 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1019});
            System.Windows.Forms.TreeNode treeNode1021 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode1018,
            treeNode1020});
            System.Windows.Forms.TreeNode treeNode1022 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode1023 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1022});
            System.Windows.Forms.TreeNode treeNode1024 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode1025 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1024});
            System.Windows.Forms.TreeNode treeNode1026 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode1023,
            treeNode1025});
            System.Windows.Forms.TreeNode treeNode1027 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode1028 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode1027});
            System.Windows.Forms.TreeNode treeNode1029 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode1028});
            System.Windows.Forms.TreeNode treeNode1030 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode1031 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1030});
            System.Windows.Forms.TreeNode treeNode1032 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode1031});
            System.Windows.Forms.TreeNode treeNode1033 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode1034 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1033});
            System.Windows.Forms.TreeNode treeNode1035 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode1034});
            System.Windows.Forms.TreeNode treeNode1036 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode1037 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode1036});
            System.Windows.Forms.TreeNode treeNode1038 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode1039 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode1040 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode1041 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1038,
            treeNode1039,
            treeNode1040});
            System.Windows.Forms.TreeNode treeNode1042 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode1037,
            treeNode1041});
            System.Windows.Forms.TreeNode treeNode1043 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode1044 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1043});
            System.Windows.Forms.TreeNode treeNode1045 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode1046 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1045});
            System.Windows.Forms.TreeNode treeNode1047 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode1044,
            treeNode1046});
            System.Windows.Forms.TreeNode treeNode1048 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode1049 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1048});
            System.Windows.Forms.TreeNode treeNode1050 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode1051 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1050});
            System.Windows.Forms.TreeNode treeNode1052 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode1049,
            treeNode1051});
            System.Windows.Forms.TreeNode treeNode1053 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode1054 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1053});
            System.Windows.Forms.TreeNode treeNode1055 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode1056 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode1055});
            System.Windows.Forms.TreeNode treeNode1057 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode1058 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode1057});
            System.Windows.Forms.TreeNode treeNode1059 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode1054,
            treeNode1056,
            treeNode1058});
            System.Windows.Forms.TreeNode treeNode1060 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode1061 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1060});
            System.Windows.Forms.TreeNode treeNode1062 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode1061});
            System.Windows.Forms.TreeNode treeNode1063 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode1064 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1063});
            System.Windows.Forms.TreeNode treeNode1065 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode1066 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1065});
            System.Windows.Forms.TreeNode treeNode1067 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode1068 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode1069 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1067,
            treeNode1068});
            System.Windows.Forms.TreeNode treeNode1070 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode1064,
            treeNode1066,
            treeNode1069});
            System.Windows.Forms.TreeNode treeNode1071 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode1072 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1071});
            System.Windows.Forms.TreeNode treeNode1073 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode1074 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1073});
            System.Windows.Forms.TreeNode treeNode1075 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode1072,
            treeNode1074});
            System.Windows.Forms.TreeNode treeNode1076 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode1077 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1076});
            System.Windows.Forms.TreeNode treeNode1078 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode1077});
            System.Windows.Forms.TreeNode treeNode1079 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode1080 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1079});
            System.Windows.Forms.TreeNode treeNode1081 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode1080});
            System.Windows.Forms.TreeNode treeNode1082 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode1083 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1082});
            System.Windows.Forms.TreeNode treeNode1084 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode1083});
            System.Windows.Forms.TreeNode treeNode1085 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode1086 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1085});
            System.Windows.Forms.TreeNode treeNode1087 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode1086});
            System.Windows.Forms.TreeNode treeNode1088 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode1089 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1088});
            System.Windows.Forms.TreeNode treeNode1090 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode1091 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode1092 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1090,
            treeNode1091});
            System.Windows.Forms.TreeNode treeNode1093 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode1089,
            treeNode1092});
            System.Windows.Forms.TreeNode treeNode1094 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode1095 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1094});
            System.Windows.Forms.TreeNode treeNode1096 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode1097 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1096});
            System.Windows.Forms.TreeNode treeNode1098 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode1095,
            treeNode1097});
            System.Windows.Forms.TreeNode treeNode1099 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode1100 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1099});
            System.Windows.Forms.TreeNode treeNode1101 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode1102 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode1103 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1101,
            treeNode1102});
            System.Windows.Forms.TreeNode treeNode1104 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode1100,
            treeNode1103});
            System.Windows.Forms.TreeNode treeNode1105 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode1106 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1105});
            System.Windows.Forms.TreeNode treeNode1107 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode1106});
            System.Windows.Forms.TreeNode treeNode1108 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode1109 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1108});
            System.Windows.Forms.TreeNode treeNode1110 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode1109});
            System.Windows.Forms.TreeNode treeNode1111 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode1112 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1111});
            System.Windows.Forms.TreeNode treeNode1113 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode1112});
            System.Windows.Forms.TreeNode treeNode1114 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode1115 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode1116 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode1117 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode1114,
            treeNode1115,
            treeNode1116});
            System.Windows.Forms.TreeNode treeNode1118 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode1119 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode1118});
            System.Windows.Forms.TreeNode treeNode1120 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode1121 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode1122 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1120,
            treeNode1121});
            System.Windows.Forms.TreeNode treeNode1123 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode1124 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode1123});
            System.Windows.Forms.TreeNode treeNode1125 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode1117,
            treeNode1119,
            treeNode1122,
            treeNode1124});
            System.Windows.Forms.TreeNode treeNode1126 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode1127 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode1128 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode1126,
            treeNode1127});
            System.Windows.Forms.TreeNode treeNode1129 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode1130 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode1131 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode1132 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode1129,
            treeNode1130,
            treeNode1131});
            System.Windows.Forms.TreeNode treeNode1133 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode1134 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1133});
            System.Windows.Forms.TreeNode treeNode1135 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode1128,
            treeNode1132,
            treeNode1134});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(18, 18);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Moving to .Net 4.8 to add new stuff";
            treeNode2.Name = "Node2";
            treeNode2.Text = "FindImageInImage method added";
            treeNode3.Name = "Node0";
            treeNode3.Text = "GetTextFromImage method added";
            treeNode4.Name = "Node0";
            treeNode4.Text = "LDImage";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Fix for speech recognition";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Debug property added";
            treeNode7.Name = "Node0";
            treeNode7.Text = "LDSpeech";
            treeNode8.Name = "Node1";
            treeNode8.Text = "ScaleWidth method added";
            treeNode9.Name = "Node0";
            treeNode9.Text = "LDGraph";
            treeNode10.Name = "Node1";
            treeNode10.Text = "InputBox uses LDDialogs.SetStartupPosition";
            treeNode11.Name = "Node0";
            treeNode11.Text = "LDDialogs";
            treeNode12.Name = "Node1";
            treeNode12.Text = "ResetFocus method added";
            treeNode13.Name = "Node0";
            treeNode13.Text = "LDFocus";
            treeNode14.Name = "Node3";
            treeNode14.Text = "LastKeyReset method added";
            treeNode15.Name = "Node2";
            treeNode15.Text = "LDTextWindow";
            treeNode16.Name = "Node5";
            treeNode16.Text = "LastKeyReset method added";
            treeNode17.Name = "Node4";
            treeNode17.Text = "LDGraphicsWindow";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Version 1.2.29.14";
            treeNode19.Name = "Node1";
            treeNode19.Text = "GetCollisions returns chain/rope name";
            treeNode20.Name = "Node0";
            treeNode20.Text = "GetAcceleration method added";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Fix for chains and ropes with non default scaling";
            treeNode22.Name = "Node0";
            treeNode22.Text = "LDPhysics";
            treeNode23.Name = "Node1";
            treeNode23.Text = "SaveAllVariables and LoadAllVariables modified to handle LF,CR";
            treeNode24.Name = "Node0";
            treeNode24.Text = "LDFile";
            treeNode25.Name = "Node1";
            treeNode25.Text = "Angle method added";
            treeNode26.Name = "Node0";
            treeNode26.Text = "TextAlignment method added";
            treeNode27.Name = "Node0";
            treeNode27.Text = "LDShapes";
            treeNode28.Name = "Node0";
            treeNode28.Text = "Version 1.2.29.0";
            treeNode29.Name = "Node2";
            treeNode29.Text = "Increase default AABB for larger display";
            treeNode30.Name = "Node1";
            treeNode30.Text = "LDPhysics";
            treeNode31.Name = "Node1";
            treeNode31.Text = "UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
    "";
            treeNode32.Name = "Node0";
            treeNode32.Text = "Exit event added";
            treeNode33.Name = "Node0";
            treeNode33.Text = "LDTextWindow";
            treeNode34.Name = "Node1";
            treeNode34.Text = "DataViewFont method added";
            treeNode35.Name = "Node0";
            treeNode35.Text = "LDControls";
            treeNode36.Name = "Node1";
            treeNode36.Text = "CallIncludeWithVars method added";
            treeNode37.Name = "Node0";
            treeNode37.Text = "LDCall";
            treeNode38.Name = "Node0";
            treeNode38.Text = "GetOriginPosition method added";
            treeNode39.Name = "Node0";
            treeNode39.Text = "Allow longer duration animations";
            treeNode40.Name = "Node1";
            treeNode40.Text = "LoadModel ignore bad objects";
            treeNode41.Name = "Node0";
            treeNode41.Text = "GetOffset method added";
            treeNode42.Name = "Node0";
            treeNode42.Text = "WSAD keys for AutoControl only active if GW active";
            treeNode43.Name = "Node0";
            treeNode43.Text = "LD3DView";
            treeNode44.Name = "Node1";
            treeNode44.Text = "Query updated to be similar to LDControls method";
            treeNode45.Name = "Node2";
            treeNode45.Text = "Improved so that listview can use LDControls methods";
            treeNode46.Name = "Node0";
            treeNode46.Text = "LDDataBase";
            treeNode47.Name = "Node1";
            treeNode47.Text = "CreateSpline and InterpolateSpline methods added";
            treeNode48.Name = "Node0";
            treeNode48.Text = "MathX";
            treeNode49.Name = "Node0";
            treeNode49.Text = "Version 1.2.28.0";
            treeNode50.Name = "Node3";
            treeNode50.Text = "RichTextBoxWord method extended";
            treeNode51.Name = "Node4";
            treeNode51.Text = "TextBoxSelection method added";
            treeNode52.Name = "Node0";
            treeNode52.Text = "RichTextBoxSelectionChanged event added";
            treeNode53.Name = "Node1";
            treeNode53.Text = "RichLastTextBoxSelection property added";
            treeNode54.Name = "Node0";
            treeNode54.Text = "RichTextBoxMousePosition method added";
            treeNode55.Name = "Node0";
            treeNode55.Text = "RichTextBoxCaretPosition method added";
            treeNode56.Name = "Node0";
            treeNode56.Text = "RichTextBoxCaretCoordinates method added";
            treeNode57.Name = "Node0";
            treeNode57.Text = "RichTextBoxWholeWord property added";
            treeNode58.Name = "Node1";
            treeNode58.Text = "RichTextBoxInsert method added";
            treeNode59.Name = "Node0";
            treeNode59.Text = "GetAllShapesAt updated to handle RTB";
            treeNode60.Name = "Node0";
            treeNode60.Text = "LDControls";
            treeNode61.Name = "Node1";
            treeNode61.Text = "Compiler property added";
            treeNode62.Name = "Node0";
            treeNode62.Text = "LDCall";
            treeNode63.Name = "Node1";
            treeNode63.Text = "GW and TW aliases added";
            treeNode64.Name = "Node0";
            treeNode64.Text = "Aliases";
            treeNode65.Name = "Node1";
            treeNode65.Text = "LF, CR, SQ, DQ, BS special characters added";
            treeNode66.Name = "Node0";
            treeNode66.Text = "LDText";
            treeNode67.Name = "Node1";
            treeNode67.Text = "InputBox method added";
            treeNode68.Name = "Node0";
            treeNode68.Text = "LDDialogs";
            treeNode69.Name = "Node1";
            treeNode69.Text = "TurtleSpeed property added";
            treeNode70.Name = "Node0";
            treeNode70.Text = "LDShapes";
            treeNode71.Name = "Node2";
            treeNode71.Text = "Version 1.2.27.0";
            treeNode72.Name = "Node1";
            treeNode72.Text = "Update API";
            treeNode73.Name = "Node0";
            treeNode73.Text = "LDTranslate";
            treeNode74.Name = "Node1";
            treeNode74.Text = "LoadImage replacement for Imagelist method that can download Flickr images";
            treeNode75.Name = "Node0";
            treeNode75.Text = "LDImage";
            treeNode76.Name = "Node1";
            treeNode76.Text = "Update HelixToolkit";
            treeNode77.Name = "Node2";
            treeNode77.Text = "AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
    "ial methods added";
            treeNode78.Name = "Node0";
            treeNode78.Text = "AddBackImage bug fixed";
            treeNode79.Name = "Node0";
            treeNode79.Text = "LD3DView";
            treeNode80.Name = "Node1";
            treeNode80.Text = "Performance improvement for \'sleeping\' shapes";
            treeNode81.Name = "Node0";
            treeNode81.Text = "LDPhysics";
            treeNode82.Name = "Node1";
            treeNode82.Text = "Updated intellisense";
            treeNode83.Name = "Node0";
            treeNode83.Text = "LDFinances";
            treeNode84.Name = "Node0";
            treeNode84.Text = "Version 1.2.26.0";
            treeNode85.Name = "Node1";
            treeNode85.Text = "Network Security Protocol fixes (SSL)";
            treeNode86.Name = "Node3";
            treeNode86.Text = "SetSSL method added";
            treeNode87.Name = "Node2";
            treeNode87.Text = "LDNetwork";
            treeNode88.Name = "Node1";
            treeNode88.Text = "FixFlickr updates for new api key";
            treeNode89.Name = "Node0";
            treeNode89.Text = "LDUtilities";
            treeNode90.Name = "Node0";
            treeNode90.Text = "Separate download required";
            treeNode91.Name = "Node0";
            treeNode91.Text = "SmallVisualBasic (sVB) support";
            treeNode92.Name = "Node0";
            treeNode92.Text = "Version 1.2.25.0";
            treeNode93.Name = "Node1";
            treeNode93.Text = "Reinstated website";
            treeNode94.Name = "Node0";
            treeNode94.Text = "Version 1.2.24.0";
            treeNode95.Name = "Node2";
            treeNode95.Text = "API updated to MS Cognitive";
            treeNode96.Name = "Node1";
            treeNode96.Text = "LDTranslate";
            treeNode97.Name = "Node1";
            treeNode97.Text = "CaptureScreen method added";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LDUtilities";
            treeNode99.Name = "Node1";
            treeNode99.Text = "Fix for ListFiles";
            treeNode100.Name = "Node0";
            treeNode100.Text = "LDftp";
            treeNode101.Name = "Node1";
            treeNode101.Text = "WriteFromArray method added";
            treeNode102.Name = "Node0";
            treeNode102.Text = "LDFile";
            treeNode103.Name = "Node1";
            treeNode103.Text = "Object added (code by Abhishek Sathiabalan)";
            treeNode104.Name = "Node0";
            treeNode104.Text = "LDFinances";
            treeNode105.Name = "Node1";
            treeNode105.Text = "Suppress javascript popup error messages";
            treeNode106.Name = "Node0";
            treeNode106.Text = "LDControls";
            treeNode107.Name = "Node0";
            treeNode107.Text = "Version 1.2.23.0";
            treeNode108.Name = "Node3";
            treeNode108.Text = "SaveTableBySQL method added";
            treeNode109.Name = "Node2";
            treeNode109.Text = "LDDataBase";
            treeNode110.Name = "Node1";
            treeNode110.Text = "Object added by Abhishek Sathiabalan";
            treeNode111.Name = "Node0";
            treeNode111.Text = "LDFinances";
            treeNode112.Name = "Node1";
            treeNode112.Text = "Version 1.2.24.0";
            treeNode113.Name = "Node1";
            treeNode113.Text = "LDHashTable object added (code from Abhishek Sathiabalan)";
            treeNode114.Name = "Node2";
            treeNode114.Text = "Some Nuget packages used (suggested by Abhishek Sathiabalan)";
            treeNode115.Name = "Node0";
            treeNode115.Text = "Various performance improvements (code from Abhishek Sathiabalan)";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDGeography (code from Abhishek Sathiabalan)";
            treeNode117.Name = "Node1";
            treeNode117.Text = "AvailableCultures method added";
            treeNode118.Name = "Node0";
            treeNode118.Text = "FixFlickr updated for API change";
            treeNode119.Name = "Node0";
            treeNode119.Text = "LDUtilities";
            treeNode120.Name = "Node0";
            treeNode120.Text = "Version 1.2.22.0";
            treeNode121.Name = "Node2";
            treeNode121.Text = "GetImage method improved to fix thread issue";
            treeNode122.Name = "Node1";
            treeNode122.Text = "LDClipboard";
            treeNode123.Name = "Node1";
            treeNode123.Text = "ReadByteArray and WriteByteArray methods added";
            treeNode124.Name = "Node0";
            treeNode124.Text = "LDFile";
            treeNode125.Name = "Node1";
            treeNode125.Text = "RenameRoot method added";
            treeNode126.Name = "Node0";
            treeNode126.Text = "View method added";
            treeNode127.Name = "Node0";
            treeNode127.Text = "LDXML";
            treeNode128.Name = "Node1";
            treeNode128.Text = "Update to Azure";
            treeNode129.Name = "Node0";
            treeNode129.Text = "LDSearch";
            treeNode130.Name = "Node1";
            treeNode130.Text = "Volume and Pan properties added";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDMusic";
            treeNode132.Name = "Node0";
            treeNode132.Text = "Version 1.2.21.0";
            treeNode133.Name = "Node2";
            treeNode133.Text = "Correctly handles pie segments greater than 180 degrees";
            treeNode134.Name = "Node1";
            treeNode134.Text = "LDChart";
            treeNode135.Name = "Node1";
            treeNode135.Text = "Decimal2Base works for number 0 in all bases";
            treeNode136.Name = "Node0";
            treeNode136.Text = "LDMath";
            treeNode137.Name = "Node1";
            treeNode137.Text = "Updated currency API";
            treeNode138.Name = "Node0";
            treeNode138.Text = "LDUnits";
            treeNode139.Name = "Node0";
            treeNode139.Text = "Version 1.2.20.0";
            treeNode140.Name = "Node1";
            treeNode140.Text = "Fix for ReSize for some controls";
            treeNode141.Name = "Node2";
            treeNode141.Text = "Fix for GetLeft and GetTop for shapes that have not been positioned yet";
            treeNode142.Name = "Node0";
            treeNode142.Text = "LDShapes";
            treeNode143.Name = "Node4";
            treeNode143.Text = "AddPyramid shape fixed";
            treeNode144.Name = "Node3";
            treeNode144.Text = "LD3DView";
            treeNode145.Name = "Node3";
            treeNode145.Text = "New object to create icons and cursors added";
            treeNode146.Name = "Node2";
            treeNode146.Text = "LDIcon";
            treeNode147.Name = "Node1";
            treeNode147.Text = "Fix for View (non-modal)";
            treeNode148.Name = "Node0";
            treeNode148.Text = "LDMatrix";
            treeNode149.Name = "Node0";
            treeNode149.Text = "Version 1.2.19.0";
            treeNode150.Name = "Node1";
            treeNode150.Text = "SetBackMaterial and AddBackImage methods added";
            treeNode151.Name = "Node0";
            treeNode151.Text = "LD3DView";
            treeNode152.Name = "Node1";
            treeNode152.Text = "Version 1.2.18.0";
            treeNode153.Name = "Node2";
            treeNode153.Text = "Fast text appending method added";
            treeNode154.Name = "Node1";
            treeNode154.Text = "LDText";
            treeNode155.Name = "Node5";
            treeNode155.Text = "Potential performance improvements";
            treeNode156.Name = "Node4";
            treeNode156.Text = "LDFile";
            treeNode157.Name = "Node7";
            treeNode157.Text = "Potential performance improvements";
            treeNode158.Name = "Node6";
            treeNode158.Text = "LDDatabase";
            treeNode159.Name = "Node9";
            treeNode159.Text = "Potential performance improvements";
            treeNode160.Name = "Node8";
            treeNode160.Text = "LDArray";
            treeNode161.Name = "Node1";
            treeNode161.Text = "Volume method added";
            treeNode162.Name = "Node0";
            treeNode162.Text = "LDSound";
            treeNode163.Name = "Node1";
            treeNode163.Text = "Modified to use Google API since MS version is depreciated";
            treeNode164.Name = "Node0";
            treeNode164.Text = "LDTranslate";
            treeNode165.Name = "Node1";
            treeNode165.Text = "FloodFillTolerance property added";
            treeNode166.Name = "Node0";
            treeNode166.Text = "LDGraphicsWindow";
            treeNode167.Name = "Node1";
            treeNode167.Text = "And and Or renamed And_ and Or_";
            treeNode168.Name = "Node0";
            treeNode168.Text = "LDLogic";
            treeNode169.Name = "Node1";
            treeNode169.Text = "SendClick method added";
            treeNode170.Name = "Node0";
            treeNode170.Text = "LDUtilities";
            treeNode171.Name = "Node0";
            treeNode171.Text = "Version 1.2.17.0";
            treeNode172.Name = "Node2";
            treeNode172.Text = "SHA512HashFile method added";
            treeNode173.Name = "Node1";
            treeNode173.Text = "LDEncryption";
            treeNode174.Name = "Node1";
            treeNode174.Text = "Broadcast method added";
            treeNode175.Name = "Node0";
            treeNode175.Text = "LDServer";
            treeNode176.Name = "Node1";
            treeNode176.Text = "AutoControl2 scene camera mode added (for model inspection)";
            treeNode177.Name = "Node0";
            treeNode177.Text = "Various auto control improvements";
            treeNode178.Name = "Node7";
            treeNode178.Text = "SwapUpDirection method added";
            treeNode179.Name = "Node0";
            treeNode179.Text = "LD3DView";
            treeNode180.Name = "Node4";
            treeNode180.Text = "Improved PauseUpdates and ResumeUpdates";
            treeNode181.Name = "Node3";
            treeNode181.Text = "LDGraphicsWIndow";
            treeNode182.Name = "Node6";
            treeNode182.Text = "3D vector algebra methods added";
            treeNode183.Name = "Node5";
            treeNode183.Text = "LDVector";
            treeNode184.Name = "Node1";
            treeNode184.Text = "LastListViewColumn event property added";
            treeNode185.Name = "Node0";
            treeNode185.Text = "LDControls";
            treeNode186.Name = "Node3";
            treeNode186.Text = "ListView subscribes to LDControls selection events";
            treeNode187.Name = "Node2";
            treeNode187.Text = "LDDatabase";
            treeNode188.Name = "Node0";
            treeNode188.Text = "Version 1.2.16.0";
            treeNode189.Name = "Node1";
            treeNode189.Text = "Read and Write methods extended to read and write unindexed lines for 1D arrays";
            treeNode190.Name = "Node0";
            treeNode190.Text = "LDFastArray";
            treeNode191.Name = "Node3";
            treeNode191.Text = "Animate method added";
            treeNode192.Name = "Node2";
            treeNode192.Text = "LDGraphicsWindow";
            treeNode193.Name = "Node1";
            treeNode193.Text = "Fix for indent tab for non-paragraph rtf blocks";
            treeNode194.Name = "Node0";
            treeNode194.Text = "LDControls";
            treeNode195.Name = "Node3";
            treeNode195.Text = "Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated";
            treeNode196.Name = "Node2";
            treeNode196.Text = "LDTextWindow";
            treeNode197.Name = "Node1";
            treeNode197.Text = "ResetMaterial method added";
            treeNode198.Name = "Node2";
            treeNode198.Text = "GetPosition method added";
            treeNode199.Name = "Node0";
            treeNode199.Text = "LD3DView";
            treeNode200.Name = "Node1";
            treeNode200.Text = "RSA public private key methods added";
            treeNode201.Name = "Node0";
            treeNode201.Text = "LDEncryption";
            treeNode202.Name = "Node0";
            treeNode202.Text = "Version 1.2.15.0";
            treeNode203.Name = "Node2";
            treeNode203.Text = "Possible unclosed zip conflicts fixed";
            treeNode204.Name = "Node1";
            treeNode204.Text = "LDZip";
            treeNode205.Name = "Node5";
            treeNode205.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode206.Name = "Node3";
            treeNode206.Text = "LDStopwatch";
            treeNode207.Name = "Node7";
            treeNode207.Text = "LDTimer object added for additional timers";
            treeNode208.Name = "Node6";
            treeNode208.Text = "LDTimer";
            treeNode209.Name = "Node1";
            treeNode209.Text = "Speedup of selected critical performance code listed below";
            treeNode210.Name = "Node2";
            treeNode210.Text = "1) LDShapes.FastMove";
            treeNode211.Name = "Node3";
            treeNode211.Text = "2) LDPhysics graphical updates";
            treeNode212.Name = "Node4";
            treeNode212.Text = "3) LDImage and LDwebCam image processing";
            treeNode213.Name = "Node6";
            treeNode213.Text = "4) LDFastShapes";
            treeNode214.Name = "Node7";
            treeNode214.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode215.Name = "Node8";
            treeNode215.Text = "6) Selected LD3DView visual updates";
            treeNode216.Name = "Node9";
            treeNode216.Text = "7) LDEffect";
            treeNode217.Name = "Node10";
            treeNode217.Text = "8) LDGraph";
            treeNode218.Name = "Node11";
            treeNode218.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode219.Name = "Node0";
            treeNode219.Text = "General";
            treeNode220.Name = "Node1";
            treeNode220.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode221.Name = "Node2";
            treeNode221.Text = "CSV file read and write";
            treeNode222.Name = "Node0";
            treeNode222.Text = "LDFastArray";
            treeNode223.Name = "Node1";
            treeNode223.Text = "DataViewColAlignment method added";
            treeNode224.Name = "Node2";
            treeNode224.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode225.Name = "Node0";
            treeNode225.Text = "RichTextBoxTextTyped event added";
            treeNode226.Name = "Node1";
            treeNode226.Text = "RichTextBoxIndentToTab property added";
            treeNode227.Name = "Node0";
            treeNode227.Text = "LDControls";
            treeNode228.Name = "Node4";
            treeNode228.Text = "OverlapDetail property added";
            treeNode229.Name = "Node3";
            treeNode229.Text = "LDShapes";
            treeNode230.Name = "Node0";
            treeNode230.Text = "Version 1.2.14.0";
            treeNode231.Name = "Node2";
            treeNode231.Text = "TEMP tables allowed for SQLite databases";
            treeNode232.Name = "Node1";
            treeNode232.Text = "LDDataBase";
            treeNode233.Name = "Node1";
            treeNode233.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode234.Name = "Node0";
            treeNode234.Text = "LDMath";
            treeNode235.Name = "Node1";
            treeNode235.Text = "NormalMap method added for normal map 3D effects";
            treeNode236.Name = "Node2";
            treeNode236.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode237.Name = "Node5";
            treeNode237.Text = "MakeTransparent method added";
            treeNode238.Name = "Node6";
            treeNode238.Text = "ReplaceColour method added";
            treeNode239.Name = "Node0";
            treeNode239.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode240.Name = "Node0";
            treeNode240.Text = "LDImage";
            treeNode241.Name = "Node4";
            treeNode241.Text = "All image pixel manipulations speeded up";
            treeNode242.Name = "Node7";
            treeNode242.Text = "More Culture Invariace fixes";
            treeNode243.Name = "Node3";
            treeNode243.Text = "General";
            treeNode244.Name = "Node0";
            treeNode244.Text = "Version 1.2.13.0";
            treeNode245.Name = "Node1";
            treeNode245.Text = "Base conversions extended to include bases up to 36";
            treeNode246.Name = "Node0";
            treeNode246.Text = "LDMath";
            treeNode247.Name = "Node3";
            treeNode247.Text = "Updated to new Bing API";
            treeNode248.Name = "Node2";
            treeNode248.Text = "LDSearch";
            treeNode249.Name = "Node1";
            treeNode249.Text = "ShowInTaskbar property added";
            treeNode250.Name = "Node0";
            treeNode250.Text = "LDGraphicsWindow";
            treeNode251.Name = "Node1";
            treeNode251.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode252.Name = "Node0";
            treeNode252.Text = "LDFile";
            treeNode253.Name = "Node1";
            treeNode253.Text = "ToArray and FromArray methods added";
            treeNode254.Name = "Node0";
            treeNode254.Text = "LDxml";
            treeNode255.Name = "Node0";
            treeNode255.Text = "Version 1.2.12.0";
            treeNode256.Name = "Node2";
            treeNode256.Text = "DataViewColumnWidths method added";
            treeNode257.Name = "Node3";
            treeNode257.Text = "DataViewRowColours method added";
            treeNode258.Name = "Node1";
            treeNode258.Text = "LDControls";
            treeNode259.Name = "Node1";
            treeNode259.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode260.Name = "Node0";
            treeNode260.Text = "General";
            treeNode261.Name = "Node1";
            treeNode261.Text = "SetCentre method added";
            treeNode262.Name = "Node4";
            treeNode262.Text = "A 3rd rotation added";
            treeNode263.Name = "Node3";
            treeNode263.Text = "BoundingBox method added";
            treeNode264.Name = "Node0";
            treeNode264.Text = "LD3DView";
            treeNode265.Name = "Node3";
            treeNode265.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode266.Name = "Node2";
            treeNode266.Text = "LDDatabase";
            treeNode267.Name = "Node1";
            treeNode267.Text = "PlayMusic2 method added";
            treeNode268.Name = "Node2";
            treeNode268.Text = "Channel parameter added";
            treeNode269.Name = "Node0";
            treeNode269.Text = "LDMusic";
            treeNode270.Name = "Node0";
            treeNode270.Text = "Version 1.2.11.0";
            treeNode271.Name = "Node1";
            treeNode271.Text = "SetButtonStyle method added";
            treeNode272.Name = "Node0";
            treeNode272.Text = "LDControls";
            treeNode273.Name = "Node1";
            treeNode273.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode274.Name = "Node2";
            treeNode274.Text = "SetBillBoard method added";
            treeNode275.Name = "Node0";
            treeNode275.Text = "GetCameraUpDirection method added";
            treeNode276.Name = "Node1";
            treeNode276.Text = "Gradient brushes can be used";
            treeNode277.Name = "Node2";
            treeNode277.Text = "AutoControl method added";
            treeNode278.Name = "Node0";
            treeNode278.Text = "SpecularExponent property added";
            treeNode279.Name = "Node0";
            treeNode279.Text = "LD3DView";
            treeNode280.Name = "Node1";
            treeNode280.Text = "AddText method to annotate an image with text added";
            treeNode281.Name = "Node0";
            treeNode281.Text = "LDImage";
            treeNode282.Name = "Node4";
            treeNode282.Text = "BrushText for text on a brush added";
            treeNode283.Name = "Node0";
            treeNode283.Text = "Skew shapes method added";
            treeNode284.Name = "Node3";
            treeNode284.Text = "LDShapes";
            treeNode285.Name = "Node0";
            treeNode285.Text = "Version 1.2.10.0";
            treeNode286.Name = "Node1";
            treeNode286.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode287.Name = "Node0";
            treeNode287.Text = "LDUnits";
            treeNode288.Name = "Node1";
            treeNode288.Text = "Possible issue with FixSigFig fixed";
            treeNode289.Name = "Node0";
            treeNode289.Text = "LDMath";
            treeNode290.Name = "Node3";
            treeNode290.Text = "GetIndex method added (for SB arrays)";
            treeNode291.Name = "Node2";
            treeNode291.Text = "LDArray";
            treeNode292.Name = "Node5";
            treeNode292.Text = "Resize mode property added";
            treeNode293.Name = "Node6";
            treeNode293.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode294.Name = "Node4";
            treeNode294.Text = "LDGraphicsWindow";
            treeNode295.Name = "Node8";
            treeNode295.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode296.Name = "Node9";
            treeNode296.Text = "DataViewAllowUserEntry method added";
            treeNode297.Name = "Node7";
            treeNode297.Text = "LDControls";
            treeNode298.Name = "Node0";
            treeNode298.Text = "Version 1.2.9.0";
            treeNode299.Name = "Node1";
            treeNode299.Text = "New extended math object, starting with FFT";
            treeNode300.Name = "Node0";
            treeNode300.Text = "LDMathX";
            treeNode301.Name = "Node1";
            treeNode301.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode302.Name = "Node0";
            treeNode302.Text = "LDControls";
            treeNode303.Name = "Node3";
            treeNode303.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode304.Name = "Node2";
            treeNode304.Text = "LDArray";
            treeNode305.Name = "Node5";
            treeNode305.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode306.Name = "Node4";
            treeNode306.Text = "LDList";
            treeNode307.Name = "Node0";
            treeNode307.Text = "Version 1.2.8.0";
            treeNode308.Name = "Node2";
            treeNode308.Text = "Error handling, additional settings and multiple ports supported";
            treeNode309.Name = "Node1";
            treeNode309.Text = "LDCommPort";
            treeNode310.Name = "Node1";
            treeNode310.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode311.Name = "Node1";
            treeNode311.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode312.Name = "Node0";
            treeNode312.Text = "LDImage and LDWebCam";
            treeNode313.Name = "Node1";
            treeNode313.Text = "Bitwise operations object added";
            treeNode314.Name = "Node0";
            treeNode314.Text = "LDBits";
            treeNode315.Name = "Node1";
            treeNode315.Text = "Extended text encoding property added";
            treeNode316.Name = "Node0";
            treeNode316.Text = "TextWindow colours can be changed";
            treeNode317.Name = "Node0";
            treeNode317.Text = "LDTextWindow";
            treeNode318.Name = "Node1";
            treeNode318.Text = "GetWorkingImagePixelARGB method added";
            treeNode319.Name = "Node0";
            treeNode319.Text = "LDImage";
            treeNode320.Name = "Node1";
            treeNode320.Text = "RasteriseTurtleLines method added";
            treeNode321.Name = "Node0";
            treeNode321.Text = "LDShapes";
            treeNode322.Name = "Node0";
            treeNode322.Text = "Version 1.2.7.0";
            treeNode323.Name = "Node1";
            treeNode323.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode324.Name = "Node0";
            treeNode324.Text = "LDDialogs";
            treeNode325.Name = "Node1";
            treeNode325.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode326.Name = "Node2";
            treeNode326.Text = "ToggleSensor added";
            treeNode327.Name = "Node0";
            treeNode327.Text = "LDPhysics";
            treeNode328.Name = "Node1";
            treeNode328.Text = "Allow multiple copies of the webcam image";
            treeNode329.Name = "Node0";
            treeNode329.Text = "LDWebCam";
            treeNode330.Name = "Node1";
            treeNode330.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode331.Name = "Node0";
            treeNode331.Text = "MetaData method added";
            treeNode332.Name = "Node0";
            treeNode332.Text = "LDImage";
            treeNode333.Name = "Node0";
            treeNode333.Text = "Version 1.2.6.0";
            treeNode334.Name = "Node2";
            treeNode334.Text = "FixSigFig and FixDecimal methods added";
            treeNode335.Name = "Node3";
            treeNode335.Text = "MinNumber and MaxNumber properties added";
            treeNode336.Name = "Node1";
            treeNode336.Text = "LDMath";
            treeNode337.Name = "Node1";
            treeNode337.Text = "SliderMaximum property added";
            treeNode338.Name = "Node0";
            treeNode338.Text = "LDControls";
            treeNode339.Name = "Node1";
            treeNode339.Text = "ZoomAll method added";
            treeNode340.Name = "Node0";
            treeNode340.Text = "LDShapes";
            treeNode341.Name = "Node1";
            treeNode341.Text = "Reposition methods and properties added";
            treeNode342.Name = "Node0";
            treeNode342.Text = "LDGraphicsWindow";
            treeNode343.Name = "Node1";
            treeNode343.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode344.Name = "Node0";
            treeNode344.Text = "LDImage";
            treeNode345.Name = "Node1";
            treeNode345.Text = "MouseScroll parameter added";
            treeNode346.Name = "Node0";
            treeNode346.Text = "LDScrollBars";
            treeNode347.Name = "Node0";
            treeNode347.Text = "Version 1.2.5.0";
            treeNode348.Name = "Node0";
            treeNode348.Text = "New object added (previously a separate extension)";
            treeNode349.Name = "Node1";
            treeNode349.Text = "Async, Loop, Volume and Pan properties added";
            treeNode350.Name = "Node2";
            treeNode350.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode351.Name = "Node1";
            treeNode351.Text = "LDWaveForm";
            treeNode352.Name = "Node1";
            treeNode352.Text = "New object added to get input from gamepads or joysticks";
            treeNode353.Name = "Node0";
            treeNode353.Text = "LDController";
            treeNode354.Name = "Node1";
            treeNode354.Text = "RayCast method added";
            treeNode355.Name = "Node0";
            treeNode355.Text = "LDPhysics";
            treeNode356.Name = "Node0";
            treeNode356.Text = "Version 1.2.4.0";
            treeNode357.Name = "Node2";
            treeNode357.Text = "New object to apply effects to any shape or control";
            treeNode358.Name = "Node1";
            treeNode358.Text = "LDEffects";
            treeNode359.Name = "Node1";
            treeNode359.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode360.Name = "Node0";
            treeNode360.Text = "LDFigures";
            treeNode361.Name = "Node1";
            treeNode361.Text = "SetGroup method added";
            treeNode362.Name = "Node2";
            treeNode362.Text = "GetContacts method added";
            treeNode363.Name = "Node0";
            treeNode363.Text = "GetAllShapesAt method added";
            treeNode364.Name = "Node0";
            treeNode364.Text = "LDPhysics";
            treeNode365.Name = "Node2";
            treeNode365.Text = "SetImage handles images with transparency";
            treeNode366.Name = "Node0";
            treeNode366.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode367.Name = "Node1";
            treeNode367.Text = "LDClipboard";
            treeNode368.Name = "Node0";
            treeNode368.Text = "Version 1.2.3.0";
            treeNode369.Name = "Node2";
            treeNode369.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode370.Name = "Node1";
            treeNode370.Text = "LDShapes";
            treeNode371.Name = "Node4";
            treeNode371.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode372.Name = "Node3";
            treeNode372.Text = "LDFile";
            treeNode373.Name = "Node6";
            treeNode373.Text = "NewImage method added";
            treeNode374.Name = "Node5";
            treeNode374.Text = "LDImage";
            treeNode375.Name = "Node1";
            treeNode375.Text = "SetStartupPosition method added to position dialogs";
            treeNode376.Name = "Node0";
            treeNode376.Text = "LDDialogs";
            treeNode377.Name = "Node1";
            treeNode377.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode378.Name = "Node0";
            treeNode378.Text = "LDGraph";
            treeNode379.Name = "Node0";
            treeNode379.Text = "Version 1.2.2.0";
            treeNode380.Name = "Node2";
            treeNode380.Text = "Recompiled for Small Basic version 1.2";
            treeNode381.Name = "Node1";
            treeNode381.Text = "Version 1.2";
            treeNode382.Name = "Node0";
            treeNode382.Text = "Version 1.2.0.1";
            treeNode383.Name = "Node2";
            treeNode383.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode384.Name = "Node1";
            treeNode384.Text = "LDDialogs";
            treeNode385.Name = "Node1";
            treeNode385.Text = "Logical operations object added";
            treeNode386.Name = "Node0";
            treeNode386.Text = "LDLogic";
            treeNode387.Name = "Node4";
            treeNode387.Text = "CurrentCulture property added";
            treeNode388.Name = "Node3";
            treeNode388.Text = "LDUtilities";
            treeNode389.Name = "Node6";
            treeNode389.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode390.Name = "Node5";
            treeNode390.Text = "LDMath";
            treeNode391.Name = "Node0";
            treeNode391.Text = "Version 1.1.0.8";
            treeNode392.Name = "Node1";
            treeNode392.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode393.Name = "Node0";
            treeNode393.Text = "LDControls";
            treeNode394.Name = "Node1";
            treeNode394.Text = "Methods added to add and remove nodes and save xml file";
            treeNode395.Name = "Node0";
            treeNode395.Text = "LDxml";
            treeNode396.Name = "Node1";
            treeNode396.Text = "MusicPlayTime moved from LDFile";
            treeNode397.Name = "Node0";
            treeNode397.Text = "LDSound";
            treeNode398.Name = "Node0";
            treeNode398.Text = "Version 1.1.0.7";
            treeNode399.Name = "Node4";
            treeNode399.Text = "SplitImage method added";
            treeNode400.Name = "Node3";
            treeNode400.Text = "LDImage";
            treeNode401.Name = "Node6";
            treeNode401.Text = "EditTable and SaveTable methods added";
            treeNode402.Name = "Node5";
            treeNode402.Text = "LDDatabse";
            treeNode403.Name = "Node2";
            treeNode403.Text = "DataView control and methods added";
            treeNode404.Name = "Node1";
            treeNode404.Text = "LDControls";
            treeNode405.Name = "Node2";
            treeNode405.Text = "Version 1.1.0.6";
            treeNode406.Name = "Node2";
            treeNode406.Text = "Exists modified to check for directory as well as file";
            treeNode407.Name = "Node3";
            treeNode407.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode408.Name = "Node1";
            treeNode408.Text = "LDFile";
            treeNode409.Name = "Node5";
            treeNode409.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode410.Name = "Node6";
            treeNode410.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode411.Name = "Node9";
            treeNode411.Text = "Conditonal break point added";
            treeNode412.Name = "Node0";
            treeNode412.Text = "Step over button added";
            treeNode413.Name = "Node4";
            treeNode413.Text = "LDDebug";
            treeNode414.Name = "Node8";
            treeNode414.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode415.Name = "Node7";
            treeNode415.Text = "LDGraphicsWindow";
            treeNode416.Name = "Node1";
            treeNode416.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode417.Name = "Node0";
            treeNode417.Text = "LDResources";
            treeNode418.Name = "Node0";
            treeNode418.Text = "Version 1.1.0.5";
            treeNode419.Name = "Node2";
            treeNode419.Text = "ClipboardChanged event added";
            treeNode420.Name = "Node1";
            treeNode420.Text = "LDClipboard";
            treeNode421.Name = "Node1";
            treeNode421.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode422.Name = "Node0";
            treeNode422.Text = "LDFile";
            treeNode423.Name = "Node3";
            treeNode423.Text = "SetActive method added";
            treeNode424.Name = "Node2";
            treeNode424.Text = "LDGraphicsWindow";
            treeNode425.Name = "Node1";
            treeNode425.Text = "Parse xml file nodes";
            treeNode426.Name = "Node0";
            treeNode426.Text = "LDxml";
            treeNode427.Name = "Node3";
            treeNode427.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode428.Name = "Node2";
            treeNode428.Text = "General";
            treeNode429.Name = "Node0";
            treeNode429.Text = "Version 1.1.0.4";
            treeNode430.Name = "Node2";
            treeNode430.Text = "WakeAll method addded";
            treeNode431.Name = "Node1";
            treeNode431.Text = "LDPhysics";
            treeNode432.Name = "Node1";
            treeNode432.Text = "Clipboard methods added";
            treeNode433.Name = "Node0";
            treeNode433.Text = "LDClipboard";
            treeNode434.Name = "Node0";
            treeNode434.Text = "Version 1.1.0.3";
            treeNode435.Name = "Node6";
            treeNode435.Text = "SizeNWSE cursor added";
            treeNode436.Name = "Node5";
            treeNode436.Text = "LDCursors";
            treeNode437.Name = "Node8";
            treeNode437.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode438.Name = "Node7";
            treeNode438.Text = "LDGraph";
            treeNode439.Name = "Node1";
            treeNode439.Text = "SQLite updated for .Net 4.5";
            treeNode440.Name = "Node0";
            treeNode440.Text = "LDDataBase";
            treeNode441.Name = "Node4";
            treeNode441.Text = "Version 1.1.0.2";
            treeNode442.Name = "Node3";
            treeNode442.Text = "Recompiled for Small Basic version 1.1";
            treeNode443.Name = "Node2";
            treeNode443.Text = "Version 1.1";
            treeNode444.Name = "Node0";
            treeNode444.Text = "Version 1.1.0.1";
            treeNode445.Name = "Node12";
            treeNode445.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode446.Name = "Node13";
            treeNode446.Text = "RichTextBoxMargins method added";
            treeNode447.Name = "Node0";
            treeNode447.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode448.Name = "Node1";
            treeNode448.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode449.Name = "Node11";
            treeNode449.Text = "LDControls";
            treeNode450.Name = "Node3";
            treeNode450.Text = "Error reporting added";
            treeNode451.Name = "Node4";
            treeNode451.Text = "SetEncoding method added";
            treeNode452.Name = "Node2";
            treeNode452.Text = "LDCommPort";
            treeNode453.Name = "Node6";
            treeNode453.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode454.Name = "Node7";
            treeNode454.Text = "Export to excel fix for graph with no title";
            treeNode455.Name = "Node5";
            treeNode455.Text = "LDGraph";
            treeNode456.Name = "Node9";
            treeNode456.Text = "Negative restitution option when adding moving shape";
            treeNode457.Name = "Node8";
            treeNode457.Text = "LDPhysics";
            treeNode458.Name = "Node10";
            treeNode458.Text = "Version 1.0.0.133";
            treeNode459.Name = "Node2";
            treeNode459.Text = "Internal improvements to auto messaging";
            treeNode460.Name = "Node9";
            treeNode460.Text = "Name can be set and GetClients method added";
            treeNode461.Name = "Node1";
            treeNode461.Text = "LDClient";
            treeNode462.Name = "Node4";
            treeNode462.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode463.Name = "Node3";
            treeNode463.Text = "LDControls";
            treeNode464.Name = "Node8";
            treeNode464.Text = "Return message and possible file error fixed for Stop method";
            treeNode465.Name = "Node7";
            treeNode465.Text = "LDSound";
            treeNode466.Name = "Node0";
            treeNode466.Text = "Version 1.0.0.132";
            treeNode467.Name = "Node2";
            treeNode467.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode468.Name = "Node5";
            treeNode468.Text = "Compile method added to compile a Small Basic program";
            treeNode469.Name = "Node1";
            treeNode469.Text = "LDCall";
            treeNode470.Name = "Node4";
            treeNode470.Text = "Methods and code by Pappa Lapub added";
            treeNode471.Name = "Node3";
            treeNode471.Text = "LDShell";
            treeNode472.Name = "Node0";
            treeNode472.Text = "Version 1.0.0.131";
            treeNode473.Name = "Node6";
            treeNode473.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode474.Name = "Node7";
            treeNode474.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode475.Name = "Node8";
            treeNode475.Text = "Refactoring of all the pan, follow and box methods";
            treeNode476.Name = "Node6";
            treeNode476.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode477.Name = "Node8";
            treeNode477.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode478.Name = "Node5";
            treeNode478.Text = "LDPhysics";
            treeNode479.Name = "Node1";
            treeNode479.Text = "UseBinary property added";
            treeNode480.Name = "Node2";
            treeNode480.Text = "DoAsync property and associated completion events added";
            treeNode481.Name = "Node3";
            treeNode481.Text = "Delete method added";
            treeNode482.Name = "Node0";
            treeNode482.Text = "LDftp";
            treeNode483.Name = "Node5";
            treeNode483.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode484.Name = "Node4";
            treeNode484.Text = "LDCall";
            treeNode485.Name = "Node2";
            treeNode485.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode486.Name = "Node1";
            treeNode486.Text = "LDControls";
            treeNode487.Name = "Node4";
            treeNode487.Text = "Version 1.0.0.130";
            treeNode488.Name = "Node2";
            treeNode488.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode489.Name = "Node1";
            treeNode489.Text = "LDMath";
            treeNode490.Name = "Node1";
            treeNode490.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode491.Name = "Node0";
            treeNode491.Text = "LDPhysics";
            treeNode492.Name = "Node3";
            treeNode492.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode493.Name = "Node2";
            treeNode493.Text = "LDGraphicsWindow";
            treeNode494.Name = "Node1";
            treeNode494.Text = "FTP object methods added";
            treeNode495.Name = "Node0";
            treeNode495.Text = "LDftp";
            treeNode496.Name = "Node3";
            treeNode496.Text = "An existing file is replaced";
            treeNode497.Name = "Node2";
            treeNode497.Text = "LDZip";
            treeNode498.Name = "Node1";
            treeNode498.Text = "Size method added";
            treeNode499.Name = "Node0";
            treeNode499.Text = "LDFile";
            treeNode500.Name = "Node3";
            treeNode500.Text = "DownloadFile method added";
            treeNode501.Name = "Node2";
            treeNode501.Text = "LDNetwork";
            treeNode502.Name = "Node0";
            treeNode502.Text = "Version 1.0.0.129";
            treeNode503.Name = "Node2";
            treeNode503.Text = "Generalised joint connections added";
            treeNode504.Name = "Node0";
            treeNode504.Text = "AddExplosion method added";
            treeNode505.Name = "Node1";
            treeNode505.Text = "LDPhysics";
            treeNode506.Name = "Node1";
            treeNode506.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode507.Name = "Node0";
            treeNode507.Text = "LDShapes";
            treeNode508.Name = "Node0";
            treeNode508.Text = "Version 1.0.0.128";
            treeNode509.Name = "Node2";
            treeNode509.Text = "CheckServer method added";
            treeNode510.Name = "Node1";
            treeNode510.Text = "LDClient";
            treeNode511.Name = "Node1";
            treeNode511.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode512.Name = "Node2";
            treeNode512.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode513.Name = "Node3";
            treeNode513.Text = "GetAngle method added";
            treeNode514.Name = "Node4";
            treeNode514.Text = "Top-down tire (to model a car from above) methods added";
            treeNode515.Name = "Node0";
            treeNode515.Text = "LDPhysics";
            treeNode516.Name = "Node0";
            treeNode516.Text = "Version 1.0.0.127";
            treeNode517.Name = "Node7";
            treeNode517.Text = "Bug fixes for Overlap methods";
            treeNode518.Name = "Node6";
            treeNode518.Text = "LDShapes";
            treeNode519.Name = "Node0";
            treeNode519.Text = "Bug fix for multiple numeric sorts";
            treeNode520.Name = "Node9";
            treeNode520.Text = "ByValueWithIndex method added";
            treeNode521.Name = "Node8";
            treeNode521.Text = "LDSort";
            treeNode522.Name = "Node1";
            treeNode522.Text = "LAN method added to get local IP addresses";
            treeNode523.Name = "Node2";
            treeNode523.Text = "Ping method added";
            treeNode524.Name = "Node0";
            treeNode524.Text = "LDNetwork";
            treeNode525.Name = "Node1";
            treeNode525.Text = "LoadSVG method added";
            treeNode526.Name = "Node0";
            treeNode526.Text = "LDImage";
            treeNode527.Name = "Node3";
            treeNode527.Text = "Evaluate method added";
            treeNode528.Name = "Node2";
            treeNode528.Text = "LDMath";
            treeNode529.Name = "Node5";
            treeNode529.Text = "IncludeJScript method added";
            treeNode530.Name = "Node4";
            treeNode530.Text = "LDInline";
            treeNode531.Name = "Node5";
            treeNode531.Text = "Version 1.0.0.126";
            treeNode532.Name = "Node0";
            treeNode532.Text = "Special emphasis on async consistency";
            treeNode533.Name = "Node4";
            treeNode533.Text = "Simplified auto method for multi-player game data transfer";
            treeNode534.Name = "Node9";
            treeNode534.Text = "LDServer and LDClient objects added";
            treeNode535.Name = "Node2";
            treeNode535.Text = "GetWidth and GetHeight methods added";
            treeNode536.Name = "Node1";
            treeNode536.Text = "LDText";
            treeNode537.Name = "Node4";
            treeNode537.Text = "Bing web search";
            treeNode538.Name = "Node3";
            treeNode538.Text = "LDSearch";
            treeNode539.Name = "Node6";
            treeNode539.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode540.Name = "Node7";
            treeNode540.Text = "KeyScroll property added";
            treeNode541.Name = "Node5";
            treeNode541.Text = "LDScrollBars";
            treeNode542.Name = "Node9";
            treeNode542.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode543.Name = "Node8";
            treeNode543.Text = "LDShapes";
            treeNode544.Name = "Node1";
            treeNode544.Text = "SaveAs method bug fixed";
            treeNode545.Name = "Node0";
            treeNode545.Text = "LDImage";
            treeNode546.Name = "Node3";
            treeNode546.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode547.Name = "Node2";
            treeNode547.Text = "LDQueue";
            treeNode548.Name = "Node8";
            treeNode548.Text = "Version 1.0.0.125";
            treeNode549.Name = "Node7";
            treeNode549.Text = "Language translation object added";
            treeNode550.Name = "Node6";
            treeNode550.Text = "LDTranslate";
            treeNode551.Name = "Node5";
            treeNode551.Text = "Version 1.0.0.124";
            treeNode552.Name = "Node1";
            treeNode552.Text = "Mouse screen coordinate conversion parameters added";
            treeNode553.Name = "Node2";
            treeNode553.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode554.Name = "Node0";
            treeNode554.Text = "LDGraphicsWindow";
            treeNode555.Name = "Node4";
            treeNode555.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode556.Name = "Node3";
            treeNode556.Text = "LDUtilities";
            treeNode557.Name = "Node0";
            treeNode557.Text = "Version 1.0.0.123";
            treeNode558.Name = "Node5";
            treeNode558.Text = "ColorMatrix method added";
            treeNode559.Name = "Node0";
            treeNode559.Text = "Rotate method added";
            treeNode560.Name = "Node3";
            treeNode560.Text = "LDImage";
            treeNode561.Name = "Node1";
            treeNode561.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode562.Name = "Node0";
            treeNode562.Text = "LDChart";
            treeNode563.Name = "Node2";
            treeNode563.Text = "Version 1.0.0.122";
            treeNode564.Name = "Node2";
            treeNode564.Text = "EffectGamma added to darken and lighten";
            treeNode565.Name = "Node4";
            treeNode565.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode566.Name = "Node3";
            treeNode566.Text = "EffectContrast modified";
            treeNode567.Name = "Node0";
            treeNode567.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode568.Name = "Node1";
            treeNode568.Text = "LDImage";
            treeNode569.Name = "Node2";
            treeNode569.Text = "Error event added for all extension exceptions";
            treeNode570.Name = "Node1";
            treeNode570.Text = "LDEvents";
            treeNode571.Name = "Node1";
            treeNode571.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode572.Name = "Node0";
            treeNode572.Text = "LDMath";
            treeNode573.Name = "Node0";
            treeNode573.Text = "Version 1.0.0.121";
            treeNode574.Name = "Node2";
            treeNode574.Text = "FloodFill transparency effect fixed";
            treeNode575.Name = "Node1";
            treeNode575.Text = "LDGraphicsWindow";
            treeNode576.Name = "Node1";
            treeNode576.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode577.Name = "Node0";
            treeNode577.Text = "LDFile";
            treeNode578.Name = "Node1";
            treeNode578.Text = "EffectPixelate added";
            treeNode579.Name = "Node0";
            treeNode579.Text = "LDImage";
            treeNode580.Name = "Node1";
            treeNode580.Text = "Modified to work with Windows 8";
            treeNode581.Name = "Node0";
            treeNode581.Text = "LDWebCam";
            treeNode582.Name = "Node0";
            treeNode582.Text = "Version 1.0.0.120";
            treeNode583.Name = "Node2";
            treeNode583.Text = "FloodFill method added";
            treeNode584.Name = "Node1";
            treeNode584.Text = "LDGraphicsWindow";
            treeNode585.Name = "Node0";
            treeNode585.Text = "Version 1.0.0.119";
            treeNode586.Name = "Node0";
            treeNode586.Text = "SetShapeCursor method added";
            treeNode587.Name = "Node11";
            treeNode587.Text = "CreateCursor method added";
            treeNode588.Name = "Node9";
            treeNode588.Text = "LDCursors";
            treeNode589.Name = "Node2";
            treeNode589.Text = "SaveAs method to save in different file formats";
            treeNode590.Name = "Node0";
            treeNode590.Text = "Parameters added for some effects";
            treeNode591.Name = "Node1";
            treeNode591.Text = "LDImage";
            treeNode592.Name = "Node2";
            treeNode592.Text = "Parameters added for some effects";
            treeNode593.Name = "Node1";
            treeNode593.Text = "LDWebCam";
            treeNode594.Name = "Node1";
            treeNode594.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode595.Name = "Node0";
            treeNode595.Text = "SetFontFromFile method added for ttf fonts";
            treeNode596.Name = "Node0";
            treeNode596.Text = "LDGraphicsWindow";
            treeNode597.Name = "Node3";
            treeNode597.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode598.Name = "Node2";
            treeNode598.Text = "LDTextWindow";
            treeNode599.Name = "Node2";
            treeNode599.Text = "Zip methods moved here from LDUtilities";
            treeNode600.Name = "Node0";
            treeNode600.Text = "LDZip";
            treeNode601.Name = "Node3";
            treeNode601.Text = "Regex methods moved here from LDUtilities";
            treeNode602.Name = "Node1";
            treeNode602.Text = "LDRegex";
            treeNode603.Name = "Node1";
            treeNode603.Text = "ListViewRowCount method added";
            treeNode604.Name = "Node0";
            treeNode604.Text = "LDControls";
            treeNode605.Name = "Node3";
            treeNode605.Text = "Version 1.0.0.118";
            treeNode606.Name = "Node5";
            treeNode606.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode607.Name = "Node6";
            treeNode607.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode608.Name = "Node4";
            treeNode608.Text = "LDUtilities";
            treeNode609.Name = "Node10";
            treeNode609.Text = "SetUserCursor method added";
            treeNode610.Name = "Node4";
            treeNode610.Text = "LDCursors";
            treeNode611.Name = "Node3";
            treeNode611.Text = "Version 1.0.0.117";
            treeNode612.Name = "Node2";
            treeNode612.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode613.Name = "Node1";
            treeNode613.Text = "LDDictionary";
            treeNode614.Name = "Node0";
            treeNode614.Text = "Version 1.0.0.116";
            treeNode615.Name = "Node2";
            treeNode615.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode616.Name = "Node1";
            treeNode616.Text = "LDColours";
            treeNode617.Name = "Node4";
            treeNode617.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode618.Name = "Node3";
            treeNode618.Text = "LDShapes";
            treeNode619.Name = "Node1";
            treeNode619.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode620.Name = "Node0";
            treeNode620.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode621.Name = "Node1";
            treeNode621.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode622.Name = "Node0";
            treeNode622.Text = "LDGraph";
            treeNode623.Name = "Node0";
            treeNode623.Text = "Version 1.0.0.115";
            treeNode624.Name = "Node2";
            treeNode624.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode625.Name = "Node1";
            treeNode625.Text = "LDControls";
            treeNode626.Name = "Node4";
            treeNode626.Text = "RemoveTurtleLines method added";
            treeNode627.Name = "Node6";
            treeNode627.Text = "GetAllShapes method added";
            treeNode628.Name = "Node3";
            treeNode628.Text = "LDShapes";
            treeNode629.Name = "Node1";
            treeNode629.Text = "Odbc connection added";
            treeNode630.Name = "Node0";
            treeNode630.Text = "LDDatabase";
            treeNode631.Name = "Node0";
            treeNode631.Text = "Version 1.0.0.114";
            treeNode632.Name = "Node2";
            treeNode632.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode633.Name = "Node1";
            treeNode633.Text = "LDUtilities";
            treeNode634.Name = "Node4";
            treeNode634.Text = "ListView control added";
            treeNode635.Name = "Node5";
            treeNode635.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode636.Name = "Node3";
            treeNode636.Text = "LDControls";
            treeNode637.Name = "Node0";
            treeNode637.Text = "Version 1.0.0.113";
            treeNode638.Name = "Node2";
            treeNode638.Text = "Tone method added";
            treeNode639.Name = "Node1";
            treeNode639.Text = "LDSound";
            treeNode640.Name = "Node5";
            treeNode640.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode641.Name = "Node4";
            treeNode641.Text = "LDControls";
            treeNode642.Name = "Node0";
            treeNode642.Text = "Version 1.0.0.112";
            treeNode643.Name = "Node2";
            treeNode643.Text = "SqlServer and Access database support added";
            treeNode644.Name = "Node1";
            treeNode644.Text = "LDDataBase";
            treeNode645.Name = "Node4";
            treeNode645.Text = "FixFlickr method added";
            treeNode646.Name = "Node0";
            treeNode646.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode647.Name = "Node3";
            treeNode647.Text = "LDUtilities";
            treeNode648.Name = "Node0";
            treeNode648.Text = "Version 1.0.0.111";
            treeNode649.Name = "Node2";
            treeNode649.Text = "TextBoxTab method added";
            treeNode650.Name = "Node1";
            treeNode650.Text = "LDControls";
            treeNode651.Name = "Node0";
            treeNode651.Text = "Version 1.0.0.110";
            treeNode652.Name = "Node1";
            treeNode652.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode653.Name = "Node3";
            treeNode653.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode654.Name = "Node0";
            treeNode654.Text = "General";
            treeNode655.Name = "Node5";
            treeNode655.Text = "Exists method added to check if a file path exists or not";
            treeNode656.Name = "Node4";
            treeNode656.Text = "LDFile";
            treeNode657.Name = "Node7";
            treeNode657.Text = "Start method handles attaching to existing process without warning";
            treeNode658.Name = "Node6";
            treeNode658.Text = "LDProcess";
            treeNode659.Name = "Node1";
            treeNode659.Text = "MySQL database support added";
            treeNode660.Name = "Node0";
            treeNode660.Text = "LDDatabase";
            treeNode661.Name = "Node3";
            treeNode661.Text = "Add and Multiply methods honour transparency";
            treeNode662.Name = "Node4";
            treeNode662.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode663.Name = "Node2";
            treeNode663.Text = "LDImage";
            treeNode664.Name = "Node3";
            treeNode664.Text = "Version 1.0.0.109";
            treeNode665.Name = "Node2";
            treeNode665.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode666.Name = "Node1";
            treeNode666.Text = "LDTextWindow";
            treeNode667.Name = "Node0";
            treeNode667.Text = "Version 1.0.0.108";
            treeNode668.Name = "Node14";
            treeNode668.Text = "Transparent colour added";
            treeNode669.Name = "Node13";
            treeNode669.Text = "LDColours";
            treeNode670.Name = "Node16";
            treeNode670.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode671.Name = "Node15";
            treeNode671.Text = "LDDialogs";
            treeNode672.Name = "Node12";
            treeNode672.Text = "Version 1.0.0.107";
            treeNode673.Name = "Node8";
            treeNode673.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode674.Name = "Node7";
            treeNode674.Text = "LDControls";
            treeNode675.Name = "Node11";
            treeNode675.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode676.Name = "Node10";
            treeNode676.Text = "LDShapes";
            treeNode677.Name = "Node6";
            treeNode677.Text = "Version 1.0.0.106";
            treeNode678.Name = "Node5";
            treeNode678.Text = "Menu control added";
            treeNode679.Name = "Node4";
            treeNode679.Text = "LDControls";
            treeNode680.Name = "Node3";
            treeNode680.Text = "Version 1.0.0.105";
            treeNode681.Name = "Node5";
            treeNode681.Text = "ZipList method added";
            treeNode682.Name = "Node2";
            treeNode682.Text = "GetNextMapIndex method added";
            treeNode683.Name = "Node4";
            treeNode683.Text = "LDUtilities";
            treeNode684.Name = "Node1";
            treeNode684.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode685.Name = "Node0";
            treeNode685.Text = "LDShapes";
            treeNode686.Name = "Node3";
            treeNode686.Text = "Version 1.0.0.104";
            treeNode687.Name = "Node1";
            treeNode687.Text = "Transparency maintained for various methods";
            treeNode688.Name = "Node2";
            treeNode688.Text = "Effects bug fixed";
            treeNode689.Name = "Node0";
            treeNode689.Text = "LDImage";
            treeNode690.Name = "Node0";
            treeNode690.Text = "Version 1.0.0.103";
            treeNode691.Name = "Node1";
            treeNode691.Text = "Current application assemblies are all auto-referenced";
            treeNode692.Name = "Node0";
            treeNode692.Text = "LDInline";
            treeNode693.Name = "Node5";
            treeNode693.Text = "Version 1.0.0.102";
            treeNode694.Name = "Node1";
            treeNode694.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode695.Name = "Node2";
            treeNode695.Text = "LDInline.sb sample provided";
            treeNode696.Name = "Node0";
            treeNode696.Text = "LDInline";
            treeNode697.Name = "Node4";
            treeNode697.Text = "ExitButtonMode method added to control window close button state";
            treeNode698.Name = "Node3";
            treeNode698.Text = "LDUtilities";
            treeNode699.Name = "Node0";
            treeNode699.Text = "Version 1.0.0.101";
            treeNode700.Name = "Node1";
            treeNode700.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode701.Name = "Node0";
            treeNode701.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode702.Name = "Node0";
            treeNode702.Text = "LDTextWindow";
            treeNode703.Name = "Node0";
            treeNode703.Text = "Version 1.0.0.100";
            treeNode704.Name = "Node2";
            treeNode704.Text = "ReadANSIToArray method added";
            treeNode705.Name = "Node1";
            treeNode705.Text = "LDFile";
            treeNode706.Name = "Node1";
            treeNode706.Text = "DocumentViewer control added";
            treeNode707.Name = "Node0";
            treeNode707.Text = "LDControls";
            treeNode708.Name = "Node3";
            treeNode708.Text = "An object to batch update shapes (for speed reasons)";
            treeNode709.Name = "Node0";
            treeNode709.Text = "LDFastShapes.sb sample included";
            treeNode710.Name = "Node2";
            treeNode710.Text = "LDFastShapes";
            treeNode711.Name = "Node0";
            treeNode711.Text = "Version 1.0.0.99";
            treeNode712.Name = "Node1";
            treeNode712.Text = "Rendering performance improvements when many shapes present";
            treeNode713.Name = "Node0";
            treeNode713.Text = "LDPhysics";
            treeNode714.Name = "Node1";
            treeNode714.Text = "ANSItoUTF8 method added";
            treeNode715.Name = "Node2";
            treeNode715.Text = "ReadANSI method added";
            treeNode716.Name = "Node0";
            treeNode716.Text = "LDFile";
            treeNode717.Name = "Node1";
            treeNode717.Text = "Version 1.0.0.98";
            treeNode718.Name = "Node3";
            treeNode718.Text = "Move method added for tiangles, polygons and lines";
            treeNode719.Name = "Node4";
            treeNode719.Text = "RotateAbout method added";
            treeNode720.Name = "Node1";
            treeNode720.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode721.Name = "Node0";
            treeNode721.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode722.Name = "Node2";
            treeNode722.Text = "LDShapes";
            treeNode723.Name = "Node0";
            treeNode723.Text = "Version 1.0.0.97";
            treeNode724.Name = "Node4";
            treeNode724.Text = "A list storage object added";
            treeNode725.Name = "Node3";
            treeNode725.Text = "LDList";
            treeNode726.Name = "Node2";
            treeNode726.Text = "Version 1.0.0.96";
            treeNode727.Name = "Node4";
            treeNode727.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode728.Name = "Node3";
            treeNode728.Text = "LDQueue";
            treeNode729.Name = "Node6";
            treeNode729.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode730.Name = "Node5";
            treeNode730.Text = "LDNetwork";
            treeNode731.Name = "Node0";
            treeNode731.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode732.Name = "Node1";
            treeNode732.Text = "General";
            treeNode733.Name = "Node2";
            treeNode733.Text = "Version 1.0.0.95";
            treeNode734.Name = "Node2";
            treeNode734.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode735.Name = "Node1";
            treeNode735.Text = "LDEncryption";
            treeNode736.Name = "Node1";
            treeNode736.Text = "RandomNumberSeed property added";
            treeNode737.Name = "Node0";
            treeNode737.Text = "LDMath";
            treeNode738.Name = "Node1";
            treeNode738.Text = "SetGameData and GetGameData methods added";
            treeNode739.Name = "Node0";
            treeNode739.Text = "LDNetwork";
            treeNode740.Name = "Node0";
            treeNode740.Text = "Version 1.0.0.94";
            treeNode741.Name = "Node1";
            treeNode741.Text = "SliderGetValue method added";
            treeNode742.Name = "Node0";
            treeNode742.Text = "LDControls";
            treeNode743.Name = "Node5";
            treeNode743.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode744.Name = "Node2";
            treeNode744.Text = "LDUtilities";
            treeNode745.Name = "Node3";
            treeNode745.Text = "Encrypt and Decrypt methods added";
            treeNode746.Name = "Node4";
            treeNode746.Text = "MD5Hash method added";
            treeNode747.Name = "Node6";
            treeNode747.Text = "LDEncryption";
            treeNode748.Name = "Node0";
            treeNode748.Text = "Version 1.0.0.93";
            treeNode749.Name = "Node1";
            treeNode749.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode750.Name = "Node0";
            treeNode750.Text = "LDControls";
            treeNode751.Name = "Node0";
            treeNode751.Text = "Version 1.0.0.92";
            treeNode752.Name = "Node2";
            treeNode752.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode753.Name = "Node1";
            treeNode753.Text = "LDControls";
            treeNode754.Name = "Node1";
            treeNode754.Text = "Version 1.0.0.91";
            treeNode755.Name = "Node1";
            treeNode755.Text = "Font method added to modify shapes or controls that have text";
            treeNode756.Name = "Node0";
            treeNode756.Text = "LDShapes";
            treeNode757.Name = "Node1";
            treeNode757.Text = "MediaPlayer control added (play videos etc)";
            treeNode758.Name = "Node0";
            treeNode758.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode759.Name = "Node0";
            treeNode759.Text = "LDControls";
            treeNode760.Name = "Node1";
            treeNode760.Text = "Version 1.0.0.90";
            treeNode761.Name = "Node1";
            treeNode761.Text = "Autosize columns for ListView";
            treeNode762.Name = "Node2";
            treeNode762.Text = "LDDataBase.sb sample updated";
            treeNode763.Name = "Node0";
            treeNode763.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode764.Name = "Node0";
            treeNode764.Text = "LDDataBase";
            treeNode765.Name = "Node0";
            treeNode765.Text = "Version 1.0.0.89";
            treeNode766.Name = "Node4";
            treeNode766.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode767.Name = "Node3";
            treeNode767.Text = "LDScrollBars";
            treeNode768.Name = "Node1";
            treeNode768.Text = "CleanTemp method added";
            treeNode769.Name = "Node0";
            treeNode769.Text = "LDUtilities";
            treeNode770.Name = "Node1";
            treeNode770.Text = "SQLite database methods added";
            treeNode771.Name = "Node0";
            treeNode771.Text = "LDDataBase";
            treeNode772.Name = "Node2";
            treeNode772.Text = "Version 1.0.0.88";
            treeNode773.Name = "Node2";
            treeNode773.Text = "LastError now returns a text error";
            treeNode774.Name = "Node1";
            treeNode774.Text = "LDIOWarrior";
            treeNode775.Name = "Node1";
            treeNode775.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode776.Name = "Node0";
            treeNode776.Text = "LDScrollBars";
            treeNode777.Name = "Node0";
            treeNode777.Text = "Version 1.0.0.87";
            treeNode778.Name = "Node4";
            treeNode778.Text = "SetTurtleImage method added";
            treeNode779.Name = "Node3";
            treeNode779.Text = "LDShapes";
            treeNode780.Name = "Node1";
            treeNode780.Text = "Connect to IOWarrior USB devices";
            treeNode781.Name = "Node0";
            treeNode781.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode782.Name = "Node0";
            treeNode782.Text = "LDIOWarrior";
            treeNode783.Name = "Node2";
            treeNode783.Text = "Version 1.0.0.86";
            treeNode784.Name = "Node1";
            treeNode784.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode785.Name = "Node0";
            treeNode785.Text = "LDShapes";
            treeNode786.Name = "Node2";
            treeNode786.Text = "Version 1.0.0.85";
            treeNode787.Name = "Node4";
            treeNode787.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode788.Name = "Node3";
            treeNode788.Text = "LDFile";
            treeNode789.Name = "Node6";
            treeNode789.Text = "Crop method added";
            treeNode790.Name = "Node5";
            treeNode790.Text = "LDImage";
            treeNode791.Name = "Node1";
            treeNode791.Text = "LastDropFiles bug fixed";
            treeNode792.Name = "Node0";
            treeNode792.Text = "LDControls";
            treeNode793.Name = "Node2";
            treeNode793.Text = "Version 1.0.0.84";
            treeNode794.Name = "Node7";
            treeNode794.Text = "FileDropped event added";
            treeNode795.Name = "Node6";
            treeNode795.Text = "LDControls";
            treeNode796.Name = "Node1";
            treeNode796.Text = "Bug in Split corrected";
            treeNode797.Name = "Node0";
            treeNode797.Text = "LDText";
            treeNode798.Name = "Node5";
            treeNode798.Text = "Version 1.0.0.83";
            treeNode799.Name = "Node3";
            treeNode799.Text = "Title argument removed from AddComboBox";
            treeNode800.Name = "Node4";
            treeNode800.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode801.Name = "Node2";
            treeNode801.Text = "LDControls";
            treeNode802.Name = "Node1";
            treeNode802.Text = "Version 1.0.0.82";
            treeNode803.Name = "Node0";
            treeNode803.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode804.Name = "Node12";
            treeNode804.Text = "Program settings added";
            treeNode805.Name = "Node9";
            treeNode805.Text = "LDSettings";
            treeNode806.Name = "Node11";
            treeNode806.Text = "Get some system paths and user name";
            treeNode807.Name = "Node10";
            treeNode807.Text = "LDFile";
            treeNode808.Name = "Node14";
            treeNode808.Text = "System sounds added";
            treeNode809.Name = "Node13";
            treeNode809.Text = "LDSound";
            treeNode810.Name = "Node16";
            treeNode810.Text = "Binary, octal, hex and decimal conversions";
            treeNode811.Name = "Node15";
            treeNode811.Text = "LDMath";
            treeNode812.Name = "Node1";
            treeNode812.Text = "Replace method added";
            treeNode813.Name = "Node2";
            treeNode813.Text = "FindAll method added";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDText";
            treeNode815.Name = "Node8";
            treeNode815.Text = "Version 1.0.0.81";
            treeNode816.Name = "Node1";
            treeNode816.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode817.Name = "Node6";
            treeNode817.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode818.Name = "Node0";
            treeNode818.Text = "LDShapes";
            treeNode819.Name = "Node3";
            treeNode819.Text = "Truncate method added";
            treeNode820.Name = "Node2";
            treeNode820.Text = "LDMath";
            treeNode821.Name = "Node5";
            treeNode821.Text = "Additional text methods";
            treeNode822.Name = "Node4";
            treeNode822.Text = "LDText";
            treeNode823.Name = "Node0";
            treeNode823.Text = "Version 1.0.0.80";
            treeNode824.Name = "Node1";
            treeNode824.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode825.Name = "Node0";
            treeNode825.Text = "LDDialogs";
            treeNode826.Name = "Node1";
            treeNode826.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode827.Name = "Node0";
            treeNode827.Text = "LDUtilities";
            treeNode828.Name = "Node6";
            treeNode828.Text = "Version 1.0.0.79";
            treeNode829.Name = "Node2";
            treeNode829.Text = "Rasterize property added";
            treeNode830.Name = "Node5";
            treeNode830.Text = "Improvements associated with window resizing";
            treeNode831.Name = "Node1";
            treeNode831.Text = "LDScrollBars";
            treeNode832.Name = "Node4";
            treeNode832.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode833.Name = "Node3";
            treeNode833.Text = "LDUtilities";
            treeNode834.Name = "Node0";
            treeNode834.Text = "Version 1.0.0.78";
            treeNode835.Name = "Node1";
            treeNode835.Text = "Handle more than 100 drawables (rasterization)";
            treeNode836.Name = "Node0";
            treeNode836.Text = "LDScollBars";
            treeNode837.Name = "Node2";
            treeNode837.Text = "Version 1.0.0.77";
            treeNode838.Name = "Node1";
            treeNode838.Text = "Record sound from a microphone";
            treeNode839.Name = "Node0";
            treeNode839.Text = "LDSound";
            treeNode840.Name = "Node3";
            treeNode840.Text = "AnimateOpacity method added (flashing)";
            treeNode841.Name = "Node0";
            treeNode841.Text = "AnimateRotation method added (continuous rotation)";
            treeNode842.Name = "Node1";
            treeNode842.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode843.Name = "Node2";
            treeNode843.Text = "LDShapes";
            treeNode844.Name = "Node2";
            treeNode844.Text = "Version 1.0.0.76";
            treeNode845.Name = "Node1";
            treeNode845.Text = "AddAnimatedImage can use an ImageList image";
            treeNode846.Name = "Node0";
            treeNode846.Text = "LDShapes";
            treeNode847.Name = "Node0";
            treeNode847.Text = "Version 1.0.0.75";
            treeNode848.Name = "Node1";
            treeNode848.Text = "Initial graph axes scaling improvement";
            treeNode849.Name = "Node0";
            treeNode849.Text = "LDGraph";
            treeNode850.Name = "Node3";
            treeNode850.Text = "Methods to access a bluetooth device";
            treeNode851.Name = "Node0";
            treeNode851.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode852.Name = "Node2";
            treeNode852.Text = "LDBlueTooth";
            treeNode853.Name = "Node1";
            treeNode853.Text = "getFocus handles multiple LDWindows";
            treeNode854.Name = "Node0";
            treeNode854.Text = "LDFocus";
            treeNode855.Name = "Node0";
            treeNode855.Text = "Version 1.0.0.74";
            treeNode856.Name = "Node1";
            treeNode856.Text = "First pass at a generic USB (HID) device controller";
            treeNode857.Name = "Node0";
            treeNode857.Text = "LDHID";
            treeNode858.Name = "Node9";
            treeNode858.Text = "Version 1.0.0.73";
            treeNode859.Name = "Node8";
            treeNode859.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode860.Name = "Node7";
            treeNode860.Text = "LDGraph";
            treeNode861.Name = "Node6";
            treeNode861.Text = "Version 1.0.0.72";
            treeNode862.Name = "Node4";
            treeNode862.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode863.Name = "Node5";
            treeNode863.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode864.Name = "Node3";
            treeNode864.Text = "LDGraph";
            treeNode865.Name = "Node2";
            treeNode865.Text = "Version 1.0.0.71";
            treeNode866.Name = "Node1";
            treeNode866.Text = "Spurious error message fixed";
            treeNode867.Name = "Node2";
            treeNode867.Text = "CreateTrend data series creation method added";
            treeNode868.Name = "Node0";
            treeNode868.Text = "LDGraph";
            treeNode869.Name = "Node2";
            treeNode869.Text = "Version 1.0.0.70";
            treeNode870.Name = "Node1";
            treeNode870.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode871.Name = "Node0";
            treeNode871.Text = "LDControls";
            treeNode872.Name = "Node3";
            treeNode872.Text = "Version 1.0.0.69";
            treeNode873.Name = "Node2";
            treeNode873.Text = "Radio button control added";
            treeNode874.Name = "Node1";
            treeNode874.Text = "LDControls";
            treeNode875.Name = "Node0";
            treeNode875.Text = "Version 1.0.0.68";
            treeNode876.Name = "Node1";
            treeNode876.Text = "Bug fix for Copy";
            treeNode877.Name = "Node0";
            treeNode877.Text = "LDArray";
            treeNode878.Name = "Node2";
            treeNode878.Text = "Version 1.0.0.67";
            treeNode879.Name = "Node1";
            treeNode879.Text = "RegexMatch and RegexReplace methods added";
            treeNode880.Name = "Node0";
            treeNode880.Text = "LDUtilities";
            treeNode881.Name = "Node3";
            treeNode881.Text = "Version 1.0.0.66";
            treeNode882.Name = "Node2";
            treeNode882.Text = "Number culture conversions added";
            treeNode883.Name = "Node1";
            treeNode883.Text = "LDUtilities";
            treeNode884.Name = "Node0";
            treeNode884.Text = "Version 1.0.0.65";
            treeNode885.Name = "Node1";
            treeNode885.Text = "IsNumber method added";
            treeNode886.Name = "Node0";
            treeNode886.Text = "LDUtilities";
            treeNode887.Name = "Node2";
            treeNode887.Text = "Version 1.0.0.64";
            treeNode888.Name = "Node1";
            treeNode888.Text = "SetCursorPosition method added for textboxes";
            treeNode889.Name = "Node0";
            treeNode889.Text = "LDControls";
            treeNode890.Name = "Node4";
            treeNode890.Text = "Version 1.0.0.63";
            treeNode891.Name = "Node1";
            treeNode891.Text = "SetCursorToEnd method added for textboxes";
            treeNode892.Name = "Node3";
            treeNode892.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode893.Name = "Node0";
            treeNode893.Text = "LDControls";
            treeNode894.Name = "Node2";
            treeNode894.Text = "Version 1.0.0.62";
            treeNode895.Name = "Node1";
            treeNode895.Text = "Adding polygons not located at (0,0) corrected";
            treeNode896.Name = "Node0";
            treeNode896.Text = "LDPhysics";
            treeNode897.Name = "Node2";
            treeNode897.Text = "Version 1.0.0.61";
            treeNode898.Name = "Node1";
            treeNode898.Text = "GetFolder dialog added";
            treeNode899.Name = "Node0";
            treeNode899.Text = "LDDialogs";
            treeNode900.Name = "Node0";
            treeNode900.Text = "Version 1.0.0.60";
            treeNode901.Name = "Node10";
            treeNode901.Text = "Possible localization issue with Font size fixed";
            treeNode902.Name = "Node9";
            treeNode902.Text = "LDDialogs";
            treeNode903.Name = "Node8";
            treeNode903.Text = "Version 1.0.0.59";
            treeNode904.Name = "Node3";
            treeNode904.Text = "More internationalization fixes";
            treeNode905.Name = "Node2";
            treeNode905.Text = "ShowPrintPreview property added";
            treeNode906.Name = "Node1";
            treeNode906.Text = "LDUtilities";
            treeNode907.Name = "Node5";
            treeNode907.Text = "Possible error with gradient drawings fixed";
            treeNode908.Name = "Node4";
            treeNode908.Text = "LDShapes";
            treeNode909.Name = "Node7";
            treeNode909.Text = "Possible Listen event initialisation error fixed";
            treeNode910.Name = "Node6";
            treeNode910.Text = "LDSpeech";
            treeNode911.Name = "Node0";
            treeNode911.Text = "Version 1.0.0.58";
            treeNode912.Name = "Node7";
            treeNode912.Text = "Many possible internationisation issues fixed";
            treeNode913.Name = "Node4";
            treeNode913.Text = "Version 1.0.0.57";
            treeNode914.Name = "Node1";
            treeNode914.Text = "Emmisive colour correction for AddGeometry";
            treeNode915.Name = "Node2";
            treeNode915.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode916.Name = "Node0";
            treeNode916.Text = "LD3DView";
            treeNode917.Name = "Node1";
            treeNode917.Text = "CSVdeminiator property added";
            treeNode918.Name = "Node0";
            treeNode918.Text = "LDUtilities";
            treeNode919.Name = "Node5";
            treeNode919.Text = "Version 1.0.0.56";
            treeNode920.Name = "Node1";
            treeNode920.Text = "Improved error reporting";
            treeNode921.Name = "Node2";
            treeNode921.Text = "Culture invariant type conversions";
            treeNode922.Name = "Node1";
            treeNode922.Text = "LD3DView";
            treeNode923.Name = "Node4";
            treeNode923.Text = "ShowErrors method added";
            treeNode924.Name = "Node3";
            treeNode924.Text = "LDUtilities";
            treeNode925.Name = "Node0";
            treeNode925.Text = "Version 1.0.0.55";
            treeNode926.Name = "Node4";
            treeNode926.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode927.Name = "Node3";
            treeNode927.Text = "LDScrollBars";
            treeNode928.Name = "Node6";
            treeNode928.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode929.Name = "Node5";
            treeNode929.Text = "LDUtilities";
            treeNode930.Name = "Node2";
            treeNode930.Text = "Version 1.0.0.54";
            treeNode931.Name = "Node1";
            treeNode931.Text = "Debug window can be resized";
            treeNode932.Name = "Node0";
            treeNode932.Text = "LDDebug";
            treeNode933.Name = "Node1";
            treeNode933.Text = "PrintFile method added";
            treeNode934.Name = "Node0";
            treeNode934.Text = "LDFile";
            treeNode935.Name = "Node2";
            treeNode935.Text = "Version 1.0.0.53";
            treeNode936.Name = "Node1";
            treeNode936.Text = "SSL property option added";
            treeNode937.Name = "Node0";
            treeNode937.Text = "LDEmail";
            treeNode938.Name = "Node0";
            treeNode938.Text = "Version 1.0.0.52";
            treeNode939.Name = "Node1";
            treeNode939.Text = "Right Click Context menu added for any shape or control";
            treeNode940.Name = "Node0";
            treeNode940.Text = "LDControls";
            treeNode941.Name = "Node0";
            treeNode941.Text = "Version 1.0.0.51";
            treeNode942.Name = "Node1";
            treeNode942.Text = "Right click dropdown menu option added";
            treeNode943.Name = "Node0";
            treeNode943.Text = "LDDialogs";
            treeNode944.Name = "Node0";
            treeNode944.Text = "Version 1.0.0.50";
            treeNode945.Name = "Node1";
            treeNode945.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode946.Name = "Node0";
            treeNode946.Text = "LD3DView";
            treeNode947.Name = "Node0";
            treeNode947.Text = "Version 1.0.0.49";
            treeNode948.Name = "Node1";
            treeNode948.Text = "Performance improvements (some camera controls for this)";
            treeNode949.Name = "Node1";
            treeNode949.Text = "LoadModel (*.3ds) files added";
            treeNode950.Name = "Node0";
            treeNode950.Text = "LD3DView";
            treeNode951.Name = "Node3";
            treeNode951.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode952.Name = "Node2";
            treeNode952.Text = "LDShapes";
            treeNode953.Name = "Node0";
            treeNode953.Text = "Version 1.0.0.48";
            treeNode954.Name = "Node1";
            treeNode954.Text = "Some improvements including animations";
            treeNode955.Name = "Node0";
            treeNode955.Text = "LD3DView";
            treeNode956.Name = "Node0";
            treeNode956.Text = "Version 1.0.0.47";
            treeNode957.Name = "Node1";
            treeNode957.Text = "Some improvemts and new methods";
            treeNode958.Name = "Node0";
            treeNode958.Text = "LD3Dview";
            treeNode959.Name = "Node2";
            treeNode959.Text = "Version 1.0.0.46";
            treeNode960.Name = "Node1";
            treeNode960.Text = "A start at a 3D set of methods";
            treeNode961.Name = "Node0";
            treeNode961.Text = "LD3DView";
            treeNode962.Name = "Node10";
            treeNode962.Text = "Version 1.0.0.45";
            treeNode963.Name = "Node1";
            treeNode963.Text = "Create scrollbars for the GraphicsWindow";
            treeNode964.Name = "Node5";
            treeNode964.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode965.Name = "Node0";
            treeNode965.Text = "LDScrollBars";
            treeNode966.Name = "Node4";
            treeNode966.Text = "ColourList method added";
            treeNode967.Name = "Node3";
            treeNode967.Text = "LDUtilities";
            treeNode968.Name = "Node8";
            treeNode968.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode969.Name = "Node9";
            treeNode969.Text = "BackgroundImage method to set the background added";
            treeNode970.Name = "Node6";
            treeNode970.Text = "LDShapes";
            treeNode971.Name = "Node0";
            treeNode971.Text = "Version 1.0.0.44";
            treeNode972.Name = "Node1";
            treeNode972.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode973.Name = "Node0";
            treeNode973.Text = "LDUtilities";
            treeNode974.Name = "Node0";
            treeNode974.Text = "Version 1.0.0.43";
            treeNode975.Name = "Node1";
            treeNode975.Text = "Call Subs as functions with arguments";
            treeNode976.Name = "Node0";
            treeNode976.Text = "LDCall";
            treeNode977.Name = "Node0";
            treeNode977.Text = "Version 1.0.0.42";
            treeNode978.Name = "Node1";
            treeNode978.Text = "Font dialog added";
            treeNode979.Name = "Node2";
            treeNode979.Text = "Colours dialog moved here from LDColours";
            treeNode980.Name = "Node0";
            treeNode980.Text = "LDDialogs";
            treeNode981.Name = "Node9";
            treeNode981.Text = "Version 1.0.0.41";
            treeNode982.Name = "Node1";
            treeNode982.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode983.Name = "Node7";
            treeNode983.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode984.Name = "Node8";
            treeNode984.Text = "Some methods renamed";
            treeNode985.Name = "Node0";
            treeNode985.Text = "LDControls";
            treeNode986.Name = "Node3";
            treeNode986.Text = "HighScore method move here";
            treeNode987.Name = "Node2";
            treeNode987.Text = "LDNetwork";
            treeNode988.Name = "Node6";
            treeNode988.Text = "SetSize method added";
            treeNode989.Name = "Node5";
            treeNode989.Text = "LDShapes";
            treeNode990.Name = "Node3";
            treeNode990.Text = "Version 1.0.0.40";
            treeNode991.Name = "Node1";
            treeNode991.Text = "SelectTreeView method added";
            treeNode992.Name = "Node2";
            treeNode992.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode993.Name = "Node0";
            treeNode993.Text = "LDDialogs";
            treeNode994.Name = "Node1";
            treeNode994.Text = "Simple high score web method";
            treeNode995.Name = "Node0";
            treeNode995.Text = "LDHighScore";
            treeNode996.Name = "Node3";
            treeNode996.Text = "Version 1.0.0.39";
            treeNode997.Name = "Node2";
            treeNode997.Text = "RichTextBox methods improved";
            treeNode998.Name = "Node1";
            treeNode998.Text = "LDDialogs";
            treeNode999.Name = "Node1";
            treeNode999.Text = "Search, Load and Save methods added";
            treeNode1000.Name = "Node0";
            treeNode1000.Text = "LDArray";
            treeNode1001.Name = "Node0";
            treeNode1001.Text = "Version 1.0.0.38";
            treeNode1002.Name = "Node1";
            treeNode1002.Text = "Depreciated";
            treeNode1003.Name = "Node0";
            treeNode1003.Text = "LDWeather";
            treeNode1004.Name = "Node1";
            treeNode1004.Text = "Renamed from LDTrig and some more methods added";
            treeNode1005.Name = "Node0";
            treeNode1005.Text = "LDMath";
            treeNode1006.Name = "Node3";
            treeNode1006.Text = "RichTextBox method added";
            treeNode1007.Name = "Node2";
            treeNode1007.Text = "LDDialogs";
            treeNode1008.Name = "Node5";
            treeNode1008.Text = "FontList method added";
            treeNode1009.Name = "Node4";
            treeNode1009.Text = "LDUtilities";
            treeNode1010.Name = "Node2";
            treeNode1010.Text = "Version 1.0.0.37";
            treeNode1011.Name = "Node1";
            treeNode1011.Text = "Zip method extended";
            treeNode1012.Name = "Node0";
            treeNode1012.Text = "LDUtilities";
            treeNode1013.Name = "Node2";
            treeNode1013.Text = "Version 1.0.0.36";
            treeNode1014.Name = "Node1";
            treeNode1014.Text = "Collapse and expand treeview nodes method added";
            treeNode1015.Name = "Node0";
            treeNode1015.Text = "LDDialogs";
            treeNode1016.Name = "Node5";
            treeNode1016.Text = "Version 1.0.0.35";
            treeNode1017.Name = "Node1";
            treeNode1017.Text = "Arguments added to Start method";
            treeNode1018.Name = "Node0";
            treeNode1018.Text = "LDProcess";
            treeNode1019.Name = "Node4";
            treeNode1019.Text = "Zip compression methods added";
            treeNode1020.Name = "Node2";
            treeNode1020.Text = "LDUtilities";
            treeNode1021.Name = "Node2";
            treeNode1021.Text = "Version 1.0.0.34";
            treeNode1022.Name = "Node1";
            treeNode1022.Text = "GWStyle property added";
            treeNode1023.Name = "Node0";
            treeNode1023.Text = "LDUtilities";
            treeNode1024.Name = "Node1";
            treeNode1024.Text = "TreeView and associated events added";
            treeNode1025.Name = "Node0";
            treeNode1025.Text = "LDDialogs";
            treeNode1026.Name = "Node0";
            treeNode1026.Text = "Version 1.0.0.33";
            treeNode1027.Name = "Node1";
            treeNode1027.Text = "Possible end points not plotting bug fixed";
            treeNode1028.Name = "Node0";
            treeNode1028.Text = "LDGraph";
            treeNode1029.Name = "Node2";
            treeNode1029.Text = "Version 1.0.0.32";
            treeNode1030.Name = "Node1";
            treeNode1030.Text = "Activated event and Active property addded";
            treeNode1031.Name = "Node0";
            treeNode1031.Text = "LDWindows";
            treeNode1032.Name = "Node0";
            treeNode1032.Text = "Version 1.0.0.31";
            treeNode1033.Name = "Node1";
            treeNode1033.Text = "Create multiple GraphicsWindows";
            treeNode1034.Name = "Node0";
            treeNode1034.Text = "LDWindows";
            treeNode1035.Name = "Node0";
            treeNode1035.Text = "Version 1.0.0.30";
            treeNode1036.Name = "Node1";
            treeNode1036.Text = "Email sending method";
            treeNode1037.Name = "Node0";
            treeNode1037.Text = "LDMail";
            treeNode1038.Name = "Node1";
            treeNode1038.Text = "Add and Multiply methods bug fixed";
            treeNode1039.Name = "Node2";
            treeNode1039.Text = "Image statistics combined into one method";
            treeNode1040.Name = "Node3";
            treeNode1040.Text = "Histogram method added";
            treeNode1041.Name = "Node0";
            treeNode1041.Text = "LDImage";
            treeNode1042.Name = "Node0";
            treeNode1042.Text = "Version 1.0.0.29";
            treeNode1043.Name = "Node1";
            treeNode1043.Text = "SnapshotToImageList method added";
            treeNode1044.Name = "Node0";
            treeNode1044.Text = "LDWebCam";
            treeNode1045.Name = "Node3";
            treeNode1045.Text = "ImageList image manipulation methods";
            treeNode1046.Name = "Node2";
            treeNode1046.Text = "LDImage";
            treeNode1047.Name = "Node0";
            treeNode1047.Text = "Version 1.0.0.28";
            treeNode1048.Name = "Node1";
            treeNode1048.Text = "SortIndex bugfix for null values";
            treeNode1049.Name = "Node0";
            treeNode1049.Text = "LDArray";
            treeNode1050.Name = "Node1";
            treeNode1050.Text = "SnapshotToFile bug fixed";
            treeNode1051.Name = "Node0";
            treeNode1051.Text = "LDWebCam";
            treeNode1052.Name = "Node0";
            treeNode1052.Text = "Version 1.0.0.27";
            treeNode1053.Name = "Node1";
            treeNode1053.Text = "SortIndex method added";
            treeNode1054.Name = "Node0";
            treeNode1054.Text = "LDArray";
            treeNode1055.Name = "Node1";
            treeNode1055.Text = "Web based weather report data added";
            treeNode1056.Name = "Node0";
            treeNode1056.Text = "LDWeather";
            treeNode1057.Name = "Node3";
            treeNode1057.Text = "DataReceived event added";
            treeNode1058.Name = "Node2";
            treeNode1058.Text = "LDCommPort";
            treeNode1059.Name = "Node0";
            treeNode1059.Text = "Version 1.0.0.26";
            treeNode1060.Name = "Node1";
            treeNode1060.Text = "Speech recognition added";
            treeNode1061.Name = "Node0";
            treeNode1061.Text = "LDSpeech";
            treeNode1062.Name = "Node0";
            treeNode1062.Text = "Version 1.0.0.25";
            treeNode1063.Name = "Node4";
            treeNode1063.Text = "More methods added and some internal code optimised";
            treeNode1064.Name = "Node0";
            treeNode1064.Text = "LDArray & LDMatrix";
            treeNode1065.Name = "Node1";
            treeNode1065.Text = "KeyDown method added";
            treeNode1066.Name = "Node0";
            treeNode1066.Text = "LDUtilities";
            treeNode1067.Name = "Node1";
            treeNode1067.Text = "GetAllShapesAt method added";
            treeNode1068.Name = "Node0";
            treeNode1068.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode1069.Name = "Node0";
            treeNode1069.Text = "LDShapes";
            treeNode1070.Name = "Node0";
            treeNode1070.Text = "Version 1.0.0.24";
            treeNode1071.Name = "Node1";
            treeNode1071.Text = "OpenFile and SaveFile dialogs added";
            treeNode1072.Name = "Node0";
            treeNode1072.Text = "LDDialogs";
            treeNode1073.Name = "Node2";
            treeNode1073.Text = "Matrix methods, for example to solve linear equations";
            treeNode1074.Name = "Node1";
            treeNode1074.Text = "LDMatrix";
            treeNode1075.Name = "Node0";
            treeNode1075.Text = "Version 1.0.0.23";
            treeNode1076.Name = "Node1";
            treeNode1076.Text = "Sorting method added";
            treeNode1077.Name = "Node0";
            treeNode1077.Text = "LDArray";
            treeNode1078.Name = "Node0";
            treeNode1078.Text = "Version 1.0.0.22";
            treeNode1079.Name = "Node2";
            treeNode1079.Text = "Velocity Threshold setting added";
            treeNode1080.Name = "Node1";
            treeNode1080.Text = "LDPhysics";
            treeNode1081.Name = "Node0";
            treeNode1081.Text = "Version 1.0.0.21";
            treeNode1082.Name = "Node3";
            treeNode1082.Text = "SetDamping method added";
            treeNode1083.Name = "Node2";
            treeNode1083.Text = "LDPhysics";
            treeNode1084.Name = "Node1";
            treeNode1084.Text = "Version 1.0.0.20";
            treeNode1085.Name = "Node1";
            treeNode1085.Text = "Instrument name can be obtained from its number";
            treeNode1086.Name = "Node0";
            treeNode1086.Text = "LDMusic";
            treeNode1087.Name = "Node0";
            treeNode1087.Text = "Version 1.0.0.19";
            treeNode1088.Name = "Node1";
            treeNode1088.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode1089.Name = "Node0";
            treeNode1089.Text = "LDDialogs";
            treeNode1090.Name = "Node1";
            treeNode1090.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode1091.Name = "Node2";
            treeNode1091.Text = "Notes can also be played synchronously (chords)";
            treeNode1092.Name = "Node0";
            treeNode1092.Text = "LDMusic";
            treeNode1093.Name = "Node0";
            treeNode1093.Text = "Version 1.0.0.18";
            treeNode1094.Name = "Node1";
            treeNode1094.Text = "AnimationPause and AnimationResume methods added";
            treeNode1095.Name = "Node0";
            treeNode1095.Text = "LDShapes";
            treeNode1096.Name = "Node1";
            treeNode1096.Text = "Process list indexed by ID rather than name";
            treeNode1097.Name = "Node0";
            treeNode1097.Text = "LDProcess";
            treeNode1098.Name = "Node1";
            treeNode1098.Text = "Version 1.0.0.17";
            treeNode1099.Name = "Node1";
            treeNode1099.Text = "More effects added";
            treeNode1100.Name = "Node0";
            treeNode1100.Text = "LDWebCam";
            treeNode1101.Name = "Node1";
            treeNode1101.Text = "Add or change an image on a button or image shape";
            treeNode1102.Name = "Node1";
            treeNode1102.Text = "Add an animated gif or tiled image";
            treeNode1103.Name = "Node0";
            treeNode1103.Text = "LDShapes";
            treeNode1104.Name = "Node0";
            treeNode1104.Text = "Version 1.0.0.16";
            treeNode1105.Name = "Node1";
            treeNode1105.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode1106.Name = "Node0";
            treeNode1106.Text = "LDWebCam";
            treeNode1107.Name = "Node0";
            treeNode1107.Text = "Version 1.0.0.15";
            treeNode1108.Name = "Node2";
            treeNode1108.Text = "Variables may be changed during a debug session";
            treeNode1109.Name = "Node1";
            treeNode1109.Text = "LDDebug";
            treeNode1110.Name = "Node0";
            treeNode1110.Text = "Version 1.0.0.14";
            treeNode1111.Name = "Node1";
            treeNode1111.Text = "A basic debugging tool";
            treeNode1112.Name = "Node0";
            treeNode1112.Text = "LDDebug";
            treeNode1113.Name = "Node0";
            treeNode1113.Text = "Version 1.0.0.13";
            treeNode1114.Name = "Node2";
            treeNode1114.Text = "Methods to convert between HSL and RGB";
            treeNode1115.Name = "Node18";
            treeNode1115.Text = "Method to set colour opacity";
            treeNode1116.Name = "Node19";
            treeNode1116.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode1117.Name = "Node1";
            treeNode1117.Text = "LDColours";
            treeNode1118.Name = "Node4";
            treeNode1118.Text = "Methods to add and subtract dates and times";
            treeNode1119.Name = "Node3";
            treeNode1119.Text = "LDDateTime";
            treeNode1120.Name = "Node6";
            treeNode1120.Text = "Waiting overlay, Calendar and About popups";
            treeNode1121.Name = "Node17";
            treeNode1121.Text = "Tooltips";
            treeNode1122.Name = "Node5";
            treeNode1122.Text = "LDDialogs";
            treeNode1123.Name = "Node8";
            treeNode1123.Text = "File change event";
            treeNode1124.Name = "Node7";
            treeNode1124.Text = "LDEvents";
            treeNode1125.Name = "Node0";
            treeNode1125.Text = "Version 1.0.0.12";
            treeNode1126.Name = "Node12";
            treeNode1126.Text = "Methods to sort arrays by index or value";
            treeNode1127.Name = "Node22";
            treeNode1127.Text = "Sorting by number and character strings";
            treeNode1128.Name = "Node11";
            treeNode1128.Text = "LDSort";
            treeNode1129.Name = "Node14";
            treeNode1129.Text = "Statistics on any array and distribution generation";
            treeNode1130.Name = "Node20";
            treeNode1130.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode1131.Name = "Node21";
            treeNode1131.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode1132.Name = "Node13";
            treeNode1132.Text = "LDStatistics";
            treeNode1133.Name = "Node16";
            treeNode1133.Text = "Voice and volume added";
            treeNode1134.Name = "Node15";
            treeNode1134.Text = "LDSpeech";
            treeNode1135.Name = "Node9";
            treeNode1135.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode28,
            treeNode49,
            treeNode71,
            treeNode84,
            treeNode92,
            treeNode94,
            treeNode107,
            treeNode120,
            treeNode132,
            treeNode139,
            treeNode149,
            treeNode152,
            treeNode171,
            treeNode188,
            treeNode202,
            treeNode230,
            treeNode244,
            treeNode255,
            treeNode270,
            treeNode285,
            treeNode298,
            treeNode307,
            treeNode322,
            treeNode333,
            treeNode347,
            treeNode356,
            treeNode368,
            treeNode379,
            treeNode382,
            treeNode391,
            treeNode398,
            treeNode405,
            treeNode418,
            treeNode429,
            treeNode434,
            treeNode441,
            treeNode444,
            treeNode458,
            treeNode466,
            treeNode472,
            treeNode487,
            treeNode502,
            treeNode508,
            treeNode516,
            treeNode531,
            treeNode548,
            treeNode551,
            treeNode557,
            treeNode563,
            treeNode573,
            treeNode582,
            treeNode585,
            treeNode605,
            treeNode611,
            treeNode614,
            treeNode623,
            treeNode631,
            treeNode637,
            treeNode642,
            treeNode648,
            treeNode651,
            treeNode664,
            treeNode667,
            treeNode672,
            treeNode677,
            treeNode680,
            treeNode686,
            treeNode690,
            treeNode693,
            treeNode699,
            treeNode703,
            treeNode711,
            treeNode717,
            treeNode723,
            treeNode726,
            treeNode733,
            treeNode740,
            treeNode748,
            treeNode751,
            treeNode754,
            treeNode760,
            treeNode765,
            treeNode772,
            treeNode777,
            treeNode783,
            treeNode786,
            treeNode793,
            treeNode798,
            treeNode802,
            treeNode815,
            treeNode823,
            treeNode828,
            treeNode834,
            treeNode837,
            treeNode844,
            treeNode847,
            treeNode855,
            treeNode858,
            treeNode861,
            treeNode865,
            treeNode869,
            treeNode872,
            treeNode875,
            treeNode878,
            treeNode881,
            treeNode884,
            treeNode887,
            treeNode890,
            treeNode894,
            treeNode897,
            treeNode900,
            treeNode903,
            treeNode911,
            treeNode913,
            treeNode919,
            treeNode925,
            treeNode930,
            treeNode935,
            treeNode938,
            treeNode941,
            treeNode944,
            treeNode947,
            treeNode953,
            treeNode956,
            treeNode959,
            treeNode962,
            treeNode971,
            treeNode974,
            treeNode977,
            treeNode981,
            treeNode990,
            treeNode996,
            treeNode1001,
            treeNode1010,
            treeNode1013,
            treeNode1016,
            treeNode1021,
            treeNode1026,
            treeNode1029,
            treeNode1032,
            treeNode1035,
            treeNode1042,
            treeNode1047,
            treeNode1052,
            treeNode1059,
            treeNode1062,
            treeNode1070,
            treeNode1075,
            treeNode1078,
            treeNode1081,
            treeNode1084,
            treeNode1087,
            treeNode1093,
            treeNode1098,
            treeNode1104,
            treeNode1107,
            treeNode1110,
            treeNode1113,
            treeNode1125,
            treeNode1135});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(853, 502);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(723, 532);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Expand All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(564, 532);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Collapse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeLog";
            this.ShowIcon = false;
            this.Text = "Change Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TreeView treeView1;
    }
}