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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Version 1.2.29.8", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("GetCollisions returns chain/rope name");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("GetAcceleration method added");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Fix for chains and ropes with non default scaling");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables modified to handle LF,CR");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Angle method added");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("TextAlignment method added");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Version 1.2.29.0", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode13,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Increase default AABB for larger display");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
        "");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Exit event added");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("DataViewFont method added");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("CallIncludeWithVars method added");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("GetOriginPosition method added");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Allow longer duration animations");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("LoadModel ignore bad objects");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("GetOffset method added");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("WSAD keys for AutoControl only active if GW active");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Query updated to be similar to LDControls method");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Improved so that listview can use LDControls methods");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("CreateSpline and InterpolateSpline methods added");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("MathX", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Version 1.2.28.0", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode22,
            treeNode24,
            treeNode26,
            treeNode32,
            treeNode35,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("RichTextBoxWord method extended");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("TextBoxSelection method added");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("RichTextBoxSelectionChanged event added");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("RichLastTextBoxSelection property added");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("RichTextBoxMousePosition method added");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("RichTextBoxCaretPosition method added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("RichTextBoxCaretCoordinates method added");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("RichTextBoxWholeWord property added");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("RichTextBoxInsert method added");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("GetAllShapesAt updated to handle RTB");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Compiler property added");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("GW and TW aliases added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Aliases", new System.Windows.Forms.TreeNode[] {
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("LF, CR, SQ, DQ, BS special characters added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("InputBox method added");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("TurtleSpeed property added");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Version 1.2.27.0", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode51,
            treeNode53,
            treeNode55,
            treeNode57,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Update API");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("LoadImage replacement for Imagelist method that can download Flickr images");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Update HelixToolkit");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
        "ial methods added");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("AddBackImage bug fixed");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode66,
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Performance improvement for \'sleeping\' shapes");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Updated intellisense");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Version 1.2.26.0", new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode64,
            treeNode68,
            treeNode70,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Network Security Protocol fixes (SSL)");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("SetSSL method added");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("FixFlickr updates for new api key");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Separate download required");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("SmallVisualBasic (sVB) support", new System.Windows.Forms.TreeNode[] {
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Version 1.2.25.0", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode76,
            treeNode78,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Reinstated website");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("API updated to MS Cognitive");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("CaptureScreen method added");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Fix for ListFiles");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("WriteFromArray method added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Object added (code by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode92});
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Suppress javascript popup error messages");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Version 1.2.23.0", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode87,
            treeNode89,
            treeNode91,
            treeNode93,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("SaveTableBySQL method added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Object added by Abhishek Sathiabalan");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode98,
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("LDHashTable object added (code from Abhishek Sathiabalan)", new System.Windows.Forms.TreeNode[] {
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Some Nuget packages used (suggested by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Various performance improvements (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("LDGeography (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("AvailableCultures method added");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("FixFlickr updated for API change");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Version 1.2.22.0", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103,
            treeNode104,
            treeNode105,
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("GetImage method improved to fix thread issue");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("ReadByteArray and WriteByteArray methods added");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("RenameRoot method added");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("View method added");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDXML", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Update to Azure");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Version 1.2.21.0", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode113,
            treeNode116,
            treeNode118,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Correctly handles pie segments greater than 180 degrees");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Decimal2Base works for number 0 in all bases");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Updated currency API");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Version 1.2.20.0", new System.Windows.Forms.TreeNode[] {
            treeNode123,
            treeNode125,
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Fix for ReSize for some controls");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Fix for GetLeft and GetTop for shapes that have not been positioned yet");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode129,
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("AddPyramid shape fixed");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("New object to create icons and cursors added");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("LDIcon", new System.Windows.Forms.TreeNode[] {
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Fix for View (non-modal)");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Version 1.2.19.0", new System.Windows.Forms.TreeNode[] {
            treeNode131,
            treeNode133,
            treeNode135,
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("SetBackMaterial and AddBackImage methods added");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Version 1.2.18.0", new System.Windows.Forms.TreeNode[] {
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Fast text appending method added");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Volume method added");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Modified to use Google API since MS version is depreciated");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("FloodFillTolerance property added");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("And and Or renamed And_ and Or_");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("SendClick method added");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("Version 1.2.17.0", new System.Windows.Forms.TreeNode[] {
            treeNode143,
            treeNode145,
            treeNode147,
            treeNode149,
            treeNode151,
            treeNode153,
            treeNode155,
            treeNode157,
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("SHA512HashFile method added");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode161});
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("Broadcast method added");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("LDServer", new System.Windows.Forms.TreeNode[] {
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("AutoControl2 scene camera mode added (for model inspection)");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Various auto control improvements");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("SwapUpDirection method added");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode165,
            treeNode166,
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("Improved PauseUpdates and ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("LDGraphicsWIndow", new System.Windows.Forms.TreeNode[] {
            treeNode169});
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("3D vector algebra methods added");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("LDVector", new System.Windows.Forms.TreeNode[] {
            treeNode171});
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LastListViewColumn event property added");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode173});
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("ListView subscribes to LDControls selection events");
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Version 1.2.16.0", new System.Windows.Forms.TreeNode[] {
            treeNode162,
            treeNode164,
            treeNode168,
            treeNode170,
            treeNode172,
            treeNode174,
            treeNode176});
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("Read and Write methods extended to read and write unindexed lines for 1D arrays");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("Animate method added");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode180});
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Fix for indent tab for non-paragraph rtf blocks");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("ResetMaterial method added");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("GetPosition method added");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode186,
            treeNode187});
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("RSA public private key methods added");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode179,
            treeNode181,
            treeNode183,
            treeNode185,
            treeNode188,
            treeNode190});
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode192});
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode194});
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode198,
            treeNode199,
            treeNode200,
            treeNode201,
            treeNode202,
            treeNode203,
            treeNode204,
            treeNode205,
            treeNode206,
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode209,
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode212,
            treeNode213,
            treeNode214,
            treeNode215});
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode217});
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode193,
            treeNode195,
            treeNode197,
            treeNode208,
            treeNode211,
            treeNode216,
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode224,
            treeNode225,
            treeNode226,
            treeNode227,
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode230,
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode221,
            treeNode223,
            treeNode229,
            treeNode232});
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode234});
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode240});
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode237,
            treeNode239,
            treeNode241,
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode245,
            treeNode246});
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode251,
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode256,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode247,
            treeNode249,
            treeNode253,
            treeNode255,
            treeNode258});
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode262,
            treeNode263,
            treeNode264,
            treeNode265,
            treeNode266,
            treeNode267});
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode269});
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode271,
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode261,
            treeNode268,
            treeNode270,
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode277});
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode279});
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode281,
            treeNode282});
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode284,
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode276,
            treeNode278,
            treeNode280,
            treeNode283,
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode288});
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode290});
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode292});
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode289,
            treeNode291,
            treeNode293,
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode299,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode304,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode309});
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode298,
            treeNode301,
            treeNode303,
            treeNode306,
            treeNode308,
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode314,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode313,
            treeNode316,
            treeNode318,
            treeNode321});
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode323,
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode325,
            treeNode327,
            treeNode329,
            treeNode331,
            treeNode333,
            treeNode335});
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode337,
            treeNode338,
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode341});
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode340,
            treeNode342,
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode350,
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode354,
            treeNode355});
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode347,
            treeNode349,
            treeNode353,
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode358});
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode362});
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode364});
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode359,
            treeNode361,
            treeNode363,
            treeNode365,
            treeNode367});
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode370});
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode372});
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode374});
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode376});
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode373,
            treeNode375,
            treeNode377,
            treeNode379});
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode383});
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode382,
            treeNode384,
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode390});
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode389,
            treeNode391,
            treeNode393});
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode395,
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode398,
            treeNode399,
            treeNode400,
            treeNode401});
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode403});
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode405});
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode397,
            treeNode402,
            treeNode404,
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode408});
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode410});
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode409,
            treeNode411,
            treeNode413,
            treeNode415,
            treeNode417});
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode420,
            treeNode422});
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode424});
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode425,
            treeNode427,
            treeNode429});
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode431});
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode434,
            treeNode435,
            treeNode436,
            treeNode437});
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode439,
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode442,
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode445});
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode438,
            treeNode441,
            treeNode444,
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode448,
            treeNode449});
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode450,
            treeNode452,
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode456,
            treeNode457});
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode458,
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode462,
            treeNode463,
            treeNode464,
            treeNode465,
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode468,
            treeNode469,
            treeNode470});
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode467,
            treeNode471,
            treeNode473,
            treeNode475});
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode487});
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode478,
            treeNode480,
            treeNode482,
            treeNode484,
            treeNode486,
            treeNode488,
            treeNode490});
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode492,
            treeNode493});
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode494,
            treeNode496});
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode500,
            treeNode501,
            treeNode502,
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode499,
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode508,
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode511,
            treeNode512});
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode507,
            treeNode510,
            treeNode513,
            treeNode515,
            treeNode517,
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode521,
            treeNode522});
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode524});
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode528,
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode531});
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode523,
            treeNode525,
            treeNode527,
            treeNode530,
            treeNode532,
            treeNode534,
            treeNode536});
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode539});
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode541,
            treeNode542});
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode543,
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode547,
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode549,
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode553,
            treeNode554,
            treeNode555,
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode557,
            treeNode559,
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode563});
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode565});
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode564,
            treeNode566,
            treeNode568,
            treeNode570});
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode573});
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode575,
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode578,
            treeNode579});
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode583,
            treeNode584});
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode586});
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode590});
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode577,
            treeNode580,
            treeNode582,
            treeNode585,
            treeNode587,
            treeNode589,
            treeNode591,
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode595,
            treeNode596});
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode597,
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode606});
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode608,
            treeNode609,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode605,
            treeNode607,
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode615,
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode614,
            treeNode617,
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode623,
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode622,
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode628,
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode634,
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode633,
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode639});
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode641,
            treeNode642});
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode648});
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode650,
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode643,
            treeNode645,
            treeNode647,
            treeNode649,
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode658,
            treeNode660});
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode663,
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode670,
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode672,
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode676,
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode681});
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode683,
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode685,
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode689,
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode691});
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode697,
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode694,
            treeNode696,
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode703,
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode702,
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode707,
            treeNode708,
            treeNode709,
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode717,
            treeNode719,
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode723});
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode724,
            treeNode726,
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode734,
            treeNode735});
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode731,
            treeNode733,
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode744});
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode746,
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode745,
            treeNode748});
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode750,
            treeNode751,
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode756,
            treeNode758,
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode763,
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode769,
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode768,
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode778});
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode777,
            treeNode779,
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode784,
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode788,
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode790});
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode801,
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode792,
            treeNode794,
            treeNode796,
            treeNode798,
            treeNode800,
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode805,
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode807,
            treeNode809,
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode814,
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode818,
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode820,
            treeNode822});
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode829,
            treeNode830,
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode828,
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode834});
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode839,
            treeNode840});
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode838,
            treeNode841,
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode849});
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode851,
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode855,
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode857});
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode863});
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode866});
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode875});
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode878});
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode880,
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode885});
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode890});
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode891});
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode894});
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode893,
            treeNode895,
            treeNode897,
            treeNode899});
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode901});
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode903,
            treeNode904});
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode906});
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode905,
            treeNode907});
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode909,
            treeNode911,
            treeNode913});
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode915});
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode917});
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode916,
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode920});
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode922});
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode921,
            treeNode923});
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode925});
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode926});
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode929});
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode931});
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode932});
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode934});
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode935});
            System.Windows.Forms.TreeNode treeNode937 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode938 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode939 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode937,
            treeNode938});
            System.Windows.Forms.TreeNode treeNode940 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode941 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode940});
            System.Windows.Forms.TreeNode treeNode942 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode939,
            treeNode941});
            System.Windows.Forms.TreeNode treeNode943 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode944 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode943});
            System.Windows.Forms.TreeNode treeNode945 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode944});
            System.Windows.Forms.TreeNode treeNode946 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode947 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode946});
            System.Windows.Forms.TreeNode treeNode948 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode947});
            System.Windows.Forms.TreeNode treeNode949 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode950 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode949});
            System.Windows.Forms.TreeNode treeNode951 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode950});
            System.Windows.Forms.TreeNode treeNode952 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode953 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode954 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode952,
            treeNode953});
            System.Windows.Forms.TreeNode treeNode955 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode956 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode955});
            System.Windows.Forms.TreeNode treeNode957 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode958 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode959 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode957,
            treeNode958});
            System.Windows.Forms.TreeNode treeNode960 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode954,
            treeNode956,
            treeNode959});
            System.Windows.Forms.TreeNode treeNode961 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode962 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode961});
            System.Windows.Forms.TreeNode treeNode963 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode962});
            System.Windows.Forms.TreeNode treeNode964 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode965 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode964});
            System.Windows.Forms.TreeNode treeNode966 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode965});
            System.Windows.Forms.TreeNode treeNode967 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode968 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode969 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode967,
            treeNode968});
            System.Windows.Forms.TreeNode treeNode970 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode969});
            System.Windows.Forms.TreeNode treeNode971 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode972 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode973 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode974 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode971,
            treeNode972,
            treeNode973});
            System.Windows.Forms.TreeNode treeNode975 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode976 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode975});
            System.Windows.Forms.TreeNode treeNode977 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode978 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode977});
            System.Windows.Forms.TreeNode treeNode979 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode974,
            treeNode976,
            treeNode978});
            System.Windows.Forms.TreeNode treeNode980 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode981 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode982 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode980,
            treeNode981});
            System.Windows.Forms.TreeNode treeNode983 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode984 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode983});
            System.Windows.Forms.TreeNode treeNode985 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode982,
            treeNode984});
            System.Windows.Forms.TreeNode treeNode986 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode987 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode986});
            System.Windows.Forms.TreeNode treeNode988 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode989 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode988});
            System.Windows.Forms.TreeNode treeNode990 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode987,
            treeNode989});
            System.Windows.Forms.TreeNode treeNode991 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode992 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode991});
            System.Windows.Forms.TreeNode treeNode993 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode994 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode993});
            System.Windows.Forms.TreeNode treeNode995 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode996 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode995});
            System.Windows.Forms.TreeNode treeNode997 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode998 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode997});
            System.Windows.Forms.TreeNode treeNode999 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode992,
            treeNode994,
            treeNode996,
            treeNode998});
            System.Windows.Forms.TreeNode treeNode1000 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode1001 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1000});
            System.Windows.Forms.TreeNode treeNode1002 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode1001});
            System.Windows.Forms.TreeNode treeNode1003 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode1004 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1003});
            System.Windows.Forms.TreeNode treeNode1005 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode1004});
            System.Windows.Forms.TreeNode treeNode1006 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode1007 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1006});
            System.Windows.Forms.TreeNode treeNode1008 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode1009 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1008});
            System.Windows.Forms.TreeNode treeNode1010 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode1007,
            treeNode1009});
            System.Windows.Forms.TreeNode treeNode1011 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode1012 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1011});
            System.Windows.Forms.TreeNode treeNode1013 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode1014 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1013});
            System.Windows.Forms.TreeNode treeNode1015 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode1012,
            treeNode1014});
            System.Windows.Forms.TreeNode treeNode1016 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode1017 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode1016});
            System.Windows.Forms.TreeNode treeNode1018 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode1017});
            System.Windows.Forms.TreeNode treeNode1019 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode1020 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1019});
            System.Windows.Forms.TreeNode treeNode1021 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode1020});
            System.Windows.Forms.TreeNode treeNode1022 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode1023 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1022});
            System.Windows.Forms.TreeNode treeNode1024 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode1023});
            System.Windows.Forms.TreeNode treeNode1025 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode1026 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode1025});
            System.Windows.Forms.TreeNode treeNode1027 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode1028 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode1029 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode1030 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1027,
            treeNode1028,
            treeNode1029});
            System.Windows.Forms.TreeNode treeNode1031 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode1026,
            treeNode1030});
            System.Windows.Forms.TreeNode treeNode1032 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode1033 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1032});
            System.Windows.Forms.TreeNode treeNode1034 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode1035 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1034});
            System.Windows.Forms.TreeNode treeNode1036 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode1033,
            treeNode1035});
            System.Windows.Forms.TreeNode treeNode1037 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode1038 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1037});
            System.Windows.Forms.TreeNode treeNode1039 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode1040 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1039});
            System.Windows.Forms.TreeNode treeNode1041 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode1038,
            treeNode1040});
            System.Windows.Forms.TreeNode treeNode1042 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode1043 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1042});
            System.Windows.Forms.TreeNode treeNode1044 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode1045 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode1044});
            System.Windows.Forms.TreeNode treeNode1046 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode1047 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode1046});
            System.Windows.Forms.TreeNode treeNode1048 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode1043,
            treeNode1045,
            treeNode1047});
            System.Windows.Forms.TreeNode treeNode1049 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode1050 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1049});
            System.Windows.Forms.TreeNode treeNode1051 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode1050});
            System.Windows.Forms.TreeNode treeNode1052 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode1053 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1052});
            System.Windows.Forms.TreeNode treeNode1054 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode1055 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1054});
            System.Windows.Forms.TreeNode treeNode1056 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode1057 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode1058 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1056,
            treeNode1057});
            System.Windows.Forms.TreeNode treeNode1059 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode1053,
            treeNode1055,
            treeNode1058});
            System.Windows.Forms.TreeNode treeNode1060 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode1061 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1060});
            System.Windows.Forms.TreeNode treeNode1062 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode1063 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1062});
            System.Windows.Forms.TreeNode treeNode1064 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode1061,
            treeNode1063});
            System.Windows.Forms.TreeNode treeNode1065 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode1066 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1065});
            System.Windows.Forms.TreeNode treeNode1067 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode1066});
            System.Windows.Forms.TreeNode treeNode1068 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode1069 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1068});
            System.Windows.Forms.TreeNode treeNode1070 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode1069});
            System.Windows.Forms.TreeNode treeNode1071 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode1072 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1071});
            System.Windows.Forms.TreeNode treeNode1073 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode1072});
            System.Windows.Forms.TreeNode treeNode1074 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode1075 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1074});
            System.Windows.Forms.TreeNode treeNode1076 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode1075});
            System.Windows.Forms.TreeNode treeNode1077 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode1078 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1077});
            System.Windows.Forms.TreeNode treeNode1079 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode1080 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode1081 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1079,
            treeNode1080});
            System.Windows.Forms.TreeNode treeNode1082 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode1078,
            treeNode1081});
            System.Windows.Forms.TreeNode treeNode1083 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode1084 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1083});
            System.Windows.Forms.TreeNode treeNode1085 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode1086 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1085});
            System.Windows.Forms.TreeNode treeNode1087 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode1084,
            treeNode1086});
            System.Windows.Forms.TreeNode treeNode1088 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode1089 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1088});
            System.Windows.Forms.TreeNode treeNode1090 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode1091 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode1092 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1090,
            treeNode1091});
            System.Windows.Forms.TreeNode treeNode1093 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode1089,
            treeNode1092});
            System.Windows.Forms.TreeNode treeNode1094 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode1095 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1094});
            System.Windows.Forms.TreeNode treeNode1096 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode1095});
            System.Windows.Forms.TreeNode treeNode1097 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode1098 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1097});
            System.Windows.Forms.TreeNode treeNode1099 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode1098});
            System.Windows.Forms.TreeNode treeNode1100 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode1101 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1100});
            System.Windows.Forms.TreeNode treeNode1102 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode1101});
            System.Windows.Forms.TreeNode treeNode1103 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode1104 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode1105 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode1106 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode1103,
            treeNode1104,
            treeNode1105});
            System.Windows.Forms.TreeNode treeNode1107 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode1108 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode1107});
            System.Windows.Forms.TreeNode treeNode1109 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode1110 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode1111 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1109,
            treeNode1110});
            System.Windows.Forms.TreeNode treeNode1112 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode1113 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode1112});
            System.Windows.Forms.TreeNode treeNode1114 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode1106,
            treeNode1108,
            treeNode1111,
            treeNode1113});
            System.Windows.Forms.TreeNode treeNode1115 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode1116 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode1117 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode1115,
            treeNode1116});
            System.Windows.Forms.TreeNode treeNode1118 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode1119 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode1120 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode1121 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode1118,
            treeNode1119,
            treeNode1120});
            System.Windows.Forms.TreeNode treeNode1122 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode1123 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1122});
            System.Windows.Forms.TreeNode treeNode1124 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode1117,
            treeNode1121,
            treeNode1123});
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
            treeNode6.Text = "LDSpeech";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Version 1.2.29.8";
            treeNode8.Name = "Node1";
            treeNode8.Text = "GetCollisions returns chain/rope name";
            treeNode9.Name = "Node0";
            treeNode9.Text = "GetAcceleration method added";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Fix for chains and ropes with non default scaling";
            treeNode11.Name = "Node0";
            treeNode11.Text = "LDPhysics";
            treeNode12.Name = "Node1";
            treeNode12.Text = "SaveAllVariables and LoadAllVariables modified to handle LF,CR";
            treeNode13.Name = "Node0";
            treeNode13.Text = "LDFile";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Angle method added";
            treeNode15.Name = "Node0";
            treeNode15.Text = "TextAlignment method added";
            treeNode16.Name = "Node0";
            treeNode16.Text = "LDShapes";
            treeNode17.Name = "Node0";
            treeNode17.Text = "Version 1.2.29.0";
            treeNode18.Name = "Node2";
            treeNode18.Text = "Increase default AABB for larger display";
            treeNode19.Name = "Node1";
            treeNode19.Text = "LDPhysics";
            treeNode20.Name = "Node1";
            treeNode20.Text = "UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
    "";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Exit event added";
            treeNode22.Name = "Node0";
            treeNode22.Text = "LDTextWindow";
            treeNode23.Name = "Node1";
            treeNode23.Text = "DataViewFont method added";
            treeNode24.Name = "Node0";
            treeNode24.Text = "LDControls";
            treeNode25.Name = "Node1";
            treeNode25.Text = "CallIncludeWithVars method added";
            treeNode26.Name = "Node0";
            treeNode26.Text = "LDCall";
            treeNode27.Name = "Node0";
            treeNode27.Text = "GetOriginPosition method added";
            treeNode28.Name = "Node0";
            treeNode28.Text = "Allow longer duration animations";
            treeNode29.Name = "Node1";
            treeNode29.Text = "LoadModel ignore bad objects";
            treeNode30.Name = "Node0";
            treeNode30.Text = "GetOffset method added";
            treeNode31.Name = "Node0";
            treeNode31.Text = "WSAD keys for AutoControl only active if GW active";
            treeNode32.Name = "Node0";
            treeNode32.Text = "LD3DView";
            treeNode33.Name = "Node1";
            treeNode33.Text = "Query updated to be similar to LDControls method";
            treeNode34.Name = "Node2";
            treeNode34.Text = "Improved so that listview can use LDControls methods";
            treeNode35.Name = "Node0";
            treeNode35.Text = "LDDataBase";
            treeNode36.Name = "Node1";
            treeNode36.Text = "CreateSpline and InterpolateSpline methods added";
            treeNode37.Name = "Node0";
            treeNode37.Text = "MathX";
            treeNode38.Name = "Node0";
            treeNode38.Text = "Version 1.2.28.0";
            treeNode39.Name = "Node3";
            treeNode39.Text = "RichTextBoxWord method extended";
            treeNode40.Name = "Node4";
            treeNode40.Text = "TextBoxSelection method added";
            treeNode41.Name = "Node0";
            treeNode41.Text = "RichTextBoxSelectionChanged event added";
            treeNode42.Name = "Node1";
            treeNode42.Text = "RichLastTextBoxSelection property added";
            treeNode43.Name = "Node0";
            treeNode43.Text = "RichTextBoxMousePosition method added";
            treeNode44.Name = "Node0";
            treeNode44.Text = "RichTextBoxCaretPosition method added";
            treeNode45.Name = "Node0";
            treeNode45.Text = "RichTextBoxCaretCoordinates method added";
            treeNode46.Name = "Node0";
            treeNode46.Text = "RichTextBoxWholeWord property added";
            treeNode47.Name = "Node1";
            treeNode47.Text = "RichTextBoxInsert method added";
            treeNode48.Name = "Node0";
            treeNode48.Text = "GetAllShapesAt updated to handle RTB";
            treeNode49.Name = "Node0";
            treeNode49.Text = "LDControls";
            treeNode50.Name = "Node1";
            treeNode50.Text = "Compiler property added";
            treeNode51.Name = "Node0";
            treeNode51.Text = "LDCall";
            treeNode52.Name = "Node1";
            treeNode52.Text = "GW and TW aliases added";
            treeNode53.Name = "Node0";
            treeNode53.Text = "Aliases";
            treeNode54.Name = "Node1";
            treeNode54.Text = "LF, CR, SQ, DQ, BS special characters added";
            treeNode55.Name = "Node0";
            treeNode55.Text = "LDText";
            treeNode56.Name = "Node1";
            treeNode56.Text = "InputBox method added";
            treeNode57.Name = "Node0";
            treeNode57.Text = "LDDialogs";
            treeNode58.Name = "Node1";
            treeNode58.Text = "TurtleSpeed property added";
            treeNode59.Name = "Node0";
            treeNode59.Text = "LDShapes";
            treeNode60.Name = "Node2";
            treeNode60.Text = "Version 1.2.27.0";
            treeNode61.Name = "Node1";
            treeNode61.Text = "Update API";
            treeNode62.Name = "Node0";
            treeNode62.Text = "LDTranslate";
            treeNode63.Name = "Node1";
            treeNode63.Text = "LoadImage replacement for Imagelist method that can download Flickr images";
            treeNode64.Name = "Node0";
            treeNode64.Text = "LDImage";
            treeNode65.Name = "Node1";
            treeNode65.Text = "Update HelixToolkit";
            treeNode66.Name = "Node2";
            treeNode66.Text = "AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
    "ial methods added";
            treeNode67.Name = "Node0";
            treeNode67.Text = "AddBackImage bug fixed";
            treeNode68.Name = "Node0";
            treeNode68.Text = "LD3DView";
            treeNode69.Name = "Node1";
            treeNode69.Text = "Performance improvement for \'sleeping\' shapes";
            treeNode70.Name = "Node0";
            treeNode70.Text = "LDPhysics";
            treeNode71.Name = "Node1";
            treeNode71.Text = "Updated intellisense";
            treeNode72.Name = "Node0";
            treeNode72.Text = "LDFinances";
            treeNode73.Name = "Node0";
            treeNode73.Text = "Version 1.2.26.0";
            treeNode74.Name = "Node1";
            treeNode74.Text = "Network Security Protocol fixes (SSL)";
            treeNode75.Name = "Node3";
            treeNode75.Text = "SetSSL method added";
            treeNode76.Name = "Node2";
            treeNode76.Text = "LDNetwork";
            treeNode77.Name = "Node1";
            treeNode77.Text = "FixFlickr updates for new api key";
            treeNode78.Name = "Node0";
            treeNode78.Text = "LDUtilities";
            treeNode79.Name = "Node0";
            treeNode79.Text = "Separate download required";
            treeNode80.Name = "Node0";
            treeNode80.Text = "SmallVisualBasic (sVB) support";
            treeNode81.Name = "Node0";
            treeNode81.Text = "Version 1.2.25.0";
            treeNode82.Name = "Node1";
            treeNode82.Text = "Reinstated website";
            treeNode83.Name = "Node0";
            treeNode83.Text = "Version 1.2.24.0";
            treeNode84.Name = "Node2";
            treeNode84.Text = "API updated to MS Cognitive";
            treeNode85.Name = "Node1";
            treeNode85.Text = "LDTranslate";
            treeNode86.Name = "Node1";
            treeNode86.Text = "CaptureScreen method added";
            treeNode87.Name = "Node0";
            treeNode87.Text = "LDUtilities";
            treeNode88.Name = "Node1";
            treeNode88.Text = "Fix for ListFiles";
            treeNode89.Name = "Node0";
            treeNode89.Text = "LDftp";
            treeNode90.Name = "Node1";
            treeNode90.Text = "WriteFromArray method added";
            treeNode91.Name = "Node0";
            treeNode91.Text = "LDFile";
            treeNode92.Name = "Node1";
            treeNode92.Text = "Object added (code by Abhishek Sathiabalan)";
            treeNode93.Name = "Node0";
            treeNode93.Text = "LDFinances";
            treeNode94.Name = "Node1";
            treeNode94.Text = "Suppress javascript popup error messages";
            treeNode95.Name = "Node0";
            treeNode95.Text = "LDControls";
            treeNode96.Name = "Node0";
            treeNode96.Text = "Version 1.2.23.0";
            treeNode97.Name = "Node3";
            treeNode97.Text = "SaveTableBySQL method added";
            treeNode98.Name = "Node2";
            treeNode98.Text = "LDDataBase";
            treeNode99.Name = "Node1";
            treeNode99.Text = "Object added by Abhishek Sathiabalan";
            treeNode100.Name = "Node0";
            treeNode100.Text = "LDFinances";
            treeNode101.Name = "Node1";
            treeNode101.Text = "Version 1.2.24.0";
            treeNode102.Name = "Node1";
            treeNode102.Text = "LDHashTable object added (code from Abhishek Sathiabalan)";
            treeNode103.Name = "Node2";
            treeNode103.Text = "Some Nuget packages used (suggested by Abhishek Sathiabalan)";
            treeNode104.Name = "Node0";
            treeNode104.Text = "Various performance improvements (code from Abhishek Sathiabalan)";
            treeNode105.Name = "Node0";
            treeNode105.Text = "LDGeography (code from Abhishek Sathiabalan)";
            treeNode106.Name = "Node1";
            treeNode106.Text = "AvailableCultures method added";
            treeNode107.Name = "Node0";
            treeNode107.Text = "FixFlickr updated for API change";
            treeNode108.Name = "Node0";
            treeNode108.Text = "LDUtilities";
            treeNode109.Name = "Node0";
            treeNode109.Text = "Version 1.2.22.0";
            treeNode110.Name = "Node2";
            treeNode110.Text = "GetImage method improved to fix thread issue";
            treeNode111.Name = "Node1";
            treeNode111.Text = "LDClipboard";
            treeNode112.Name = "Node1";
            treeNode112.Text = "ReadByteArray and WriteByteArray methods added";
            treeNode113.Name = "Node0";
            treeNode113.Text = "LDFile";
            treeNode114.Name = "Node1";
            treeNode114.Text = "RenameRoot method added";
            treeNode115.Name = "Node0";
            treeNode115.Text = "View method added";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDXML";
            treeNode117.Name = "Node1";
            treeNode117.Text = "Update to Azure";
            treeNode118.Name = "Node0";
            treeNode118.Text = "LDSearch";
            treeNode119.Name = "Node1";
            treeNode119.Text = "Volume and Pan properties added";
            treeNode120.Name = "Node0";
            treeNode120.Text = "LDMusic";
            treeNode121.Name = "Node0";
            treeNode121.Text = "Version 1.2.21.0";
            treeNode122.Name = "Node2";
            treeNode122.Text = "Correctly handles pie segments greater than 180 degrees";
            treeNode123.Name = "Node1";
            treeNode123.Text = "LDChart";
            treeNode124.Name = "Node1";
            treeNode124.Text = "Decimal2Base works for number 0 in all bases";
            treeNode125.Name = "Node0";
            treeNode125.Text = "LDMath";
            treeNode126.Name = "Node1";
            treeNode126.Text = "Updated currency API";
            treeNode127.Name = "Node0";
            treeNode127.Text = "LDUnits";
            treeNode128.Name = "Node0";
            treeNode128.Text = "Version 1.2.20.0";
            treeNode129.Name = "Node1";
            treeNode129.Text = "Fix for ReSize for some controls";
            treeNode130.Name = "Node2";
            treeNode130.Text = "Fix for GetLeft and GetTop for shapes that have not been positioned yet";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDShapes";
            treeNode132.Name = "Node4";
            treeNode132.Text = "AddPyramid shape fixed";
            treeNode133.Name = "Node3";
            treeNode133.Text = "LD3DView";
            treeNode134.Name = "Node3";
            treeNode134.Text = "New object to create icons and cursors added";
            treeNode135.Name = "Node2";
            treeNode135.Text = "LDIcon";
            treeNode136.Name = "Node1";
            treeNode136.Text = "Fix for View (non-modal)";
            treeNode137.Name = "Node0";
            treeNode137.Text = "LDMatrix";
            treeNode138.Name = "Node0";
            treeNode138.Text = "Version 1.2.19.0";
            treeNode139.Name = "Node1";
            treeNode139.Text = "SetBackMaterial and AddBackImage methods added";
            treeNode140.Name = "Node0";
            treeNode140.Text = "LD3DView";
            treeNode141.Name = "Node1";
            treeNode141.Text = "Version 1.2.18.0";
            treeNode142.Name = "Node2";
            treeNode142.Text = "Fast text appending method added";
            treeNode143.Name = "Node1";
            treeNode143.Text = "LDText";
            treeNode144.Name = "Node5";
            treeNode144.Text = "Potential performance improvements";
            treeNode145.Name = "Node4";
            treeNode145.Text = "LDFile";
            treeNode146.Name = "Node7";
            treeNode146.Text = "Potential performance improvements";
            treeNode147.Name = "Node6";
            treeNode147.Text = "LDDatabase";
            treeNode148.Name = "Node9";
            treeNode148.Text = "Potential performance improvements";
            treeNode149.Name = "Node8";
            treeNode149.Text = "LDArray";
            treeNode150.Name = "Node1";
            treeNode150.Text = "Volume method added";
            treeNode151.Name = "Node0";
            treeNode151.Text = "LDSound";
            treeNode152.Name = "Node1";
            treeNode152.Text = "Modified to use Google API since MS version is depreciated";
            treeNode153.Name = "Node0";
            treeNode153.Text = "LDTranslate";
            treeNode154.Name = "Node1";
            treeNode154.Text = "FloodFillTolerance property added";
            treeNode155.Name = "Node0";
            treeNode155.Text = "LDGraphicsWindow";
            treeNode156.Name = "Node1";
            treeNode156.Text = "And and Or renamed And_ and Or_";
            treeNode157.Name = "Node0";
            treeNode157.Text = "LDLogic";
            treeNode158.Name = "Node1";
            treeNode158.Text = "SendClick method added";
            treeNode159.Name = "Node0";
            treeNode159.Text = "LDUtilities";
            treeNode160.Name = "Node0";
            treeNode160.Text = "Version 1.2.17.0";
            treeNode161.Name = "Node2";
            treeNode161.Text = "SHA512HashFile method added";
            treeNode162.Name = "Node1";
            treeNode162.Text = "LDEncryption";
            treeNode163.Name = "Node1";
            treeNode163.Text = "Broadcast method added";
            treeNode164.Name = "Node0";
            treeNode164.Text = "LDServer";
            treeNode165.Name = "Node1";
            treeNode165.Text = "AutoControl2 scene camera mode added (for model inspection)";
            treeNode166.Name = "Node0";
            treeNode166.Text = "Various auto control improvements";
            treeNode167.Name = "Node7";
            treeNode167.Text = "SwapUpDirection method added";
            treeNode168.Name = "Node0";
            treeNode168.Text = "LD3DView";
            treeNode169.Name = "Node4";
            treeNode169.Text = "Improved PauseUpdates and ResumeUpdates";
            treeNode170.Name = "Node3";
            treeNode170.Text = "LDGraphicsWIndow";
            treeNode171.Name = "Node6";
            treeNode171.Text = "3D vector algebra methods added";
            treeNode172.Name = "Node5";
            treeNode172.Text = "LDVector";
            treeNode173.Name = "Node1";
            treeNode173.Text = "LastListViewColumn event property added";
            treeNode174.Name = "Node0";
            treeNode174.Text = "LDControls";
            treeNode175.Name = "Node3";
            treeNode175.Text = "ListView subscribes to LDControls selection events";
            treeNode176.Name = "Node2";
            treeNode176.Text = "LDDatabase";
            treeNode177.Name = "Node0";
            treeNode177.Text = "Version 1.2.16.0";
            treeNode178.Name = "Node1";
            treeNode178.Text = "Read and Write methods extended to read and write unindexed lines for 1D arrays";
            treeNode179.Name = "Node0";
            treeNode179.Text = "LDFastArray";
            treeNode180.Name = "Node3";
            treeNode180.Text = "Animate method added";
            treeNode181.Name = "Node2";
            treeNode181.Text = "LDGraphicsWindow";
            treeNode182.Name = "Node1";
            treeNode182.Text = "Fix for indent tab for non-paragraph rtf blocks";
            treeNode183.Name = "Node0";
            treeNode183.Text = "LDControls";
            treeNode184.Name = "Node3";
            treeNode184.Text = "Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated";
            treeNode185.Name = "Node2";
            treeNode185.Text = "LDTextWindow";
            treeNode186.Name = "Node1";
            treeNode186.Text = "ResetMaterial method added";
            treeNode187.Name = "Node2";
            treeNode187.Text = "GetPosition method added";
            treeNode188.Name = "Node0";
            treeNode188.Text = "LD3DView";
            treeNode189.Name = "Node1";
            treeNode189.Text = "RSA public private key methods added";
            treeNode190.Name = "Node0";
            treeNode190.Text = "LDEncryption";
            treeNode191.Name = "Node0";
            treeNode191.Text = "Version 1.2.15.0";
            treeNode192.Name = "Node2";
            treeNode192.Text = "Possible unclosed zip conflicts fixed";
            treeNode193.Name = "Node1";
            treeNode193.Text = "LDZip";
            treeNode194.Name = "Node5";
            treeNode194.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode195.Name = "Node3";
            treeNode195.Text = "LDStopwatch";
            treeNode196.Name = "Node7";
            treeNode196.Text = "LDTimer object added for additional timers";
            treeNode197.Name = "Node6";
            treeNode197.Text = "LDTimer";
            treeNode198.Name = "Node1";
            treeNode198.Text = "Speedup of selected critical performance code listed below";
            treeNode199.Name = "Node2";
            treeNode199.Text = "1) LDShapes.FastMove";
            treeNode200.Name = "Node3";
            treeNode200.Text = "2) LDPhysics graphical updates";
            treeNode201.Name = "Node4";
            treeNode201.Text = "3) LDImage and LDwebCam image processing";
            treeNode202.Name = "Node6";
            treeNode202.Text = "4) LDFastShapes";
            treeNode203.Name = "Node7";
            treeNode203.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode204.Name = "Node8";
            treeNode204.Text = "6) Selected LD3DView visual updates";
            treeNode205.Name = "Node9";
            treeNode205.Text = "7) LDEffect";
            treeNode206.Name = "Node10";
            treeNode206.Text = "8) LDGraph";
            treeNode207.Name = "Node11";
            treeNode207.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode208.Name = "Node0";
            treeNode208.Text = "General";
            treeNode209.Name = "Node1";
            treeNode209.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode210.Name = "Node2";
            treeNode210.Text = "CSV file read and write";
            treeNode211.Name = "Node0";
            treeNode211.Text = "LDFastArray";
            treeNode212.Name = "Node1";
            treeNode212.Text = "DataViewColAlignment method added";
            treeNode213.Name = "Node2";
            treeNode213.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode214.Name = "Node0";
            treeNode214.Text = "RichTextBoxTextTyped event added";
            treeNode215.Name = "Node1";
            treeNode215.Text = "RichTextBoxIndentToTab property added";
            treeNode216.Name = "Node0";
            treeNode216.Text = "LDControls";
            treeNode217.Name = "Node4";
            treeNode217.Text = "OverlapDetail property added";
            treeNode218.Name = "Node3";
            treeNode218.Text = "LDShapes";
            treeNode219.Name = "Node0";
            treeNode219.Text = "Version 1.2.14.0";
            treeNode220.Name = "Node2";
            treeNode220.Text = "TEMP tables allowed for SQLite databases";
            treeNode221.Name = "Node1";
            treeNode221.Text = "LDDataBase";
            treeNode222.Name = "Node1";
            treeNode222.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode223.Name = "Node0";
            treeNode223.Text = "LDMath";
            treeNode224.Name = "Node1";
            treeNode224.Text = "NormalMap method added for normal map 3D effects";
            treeNode225.Name = "Node2";
            treeNode225.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode226.Name = "Node5";
            treeNode226.Text = "MakeTransparent method added";
            treeNode227.Name = "Node6";
            treeNode227.Text = "ReplaceColour method added";
            treeNode228.Name = "Node0";
            treeNode228.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode229.Name = "Node0";
            treeNode229.Text = "LDImage";
            treeNode230.Name = "Node4";
            treeNode230.Text = "All image pixel manipulations speeded up";
            treeNode231.Name = "Node7";
            treeNode231.Text = "More Culture Invariace fixes";
            treeNode232.Name = "Node3";
            treeNode232.Text = "General";
            treeNode233.Name = "Node0";
            treeNode233.Text = "Version 1.2.13.0";
            treeNode234.Name = "Node1";
            treeNode234.Text = "Base conversions extended to include bases up to 36";
            treeNode235.Name = "Node0";
            treeNode235.Text = "LDMath";
            treeNode236.Name = "Node3";
            treeNode236.Text = "Updated to new Bing API";
            treeNode237.Name = "Node2";
            treeNode237.Text = "LDSearch";
            treeNode238.Name = "Node1";
            treeNode238.Text = "ShowInTaskbar property added";
            treeNode239.Name = "Node0";
            treeNode239.Text = "LDGraphicsWindow";
            treeNode240.Name = "Node1";
            treeNode240.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode241.Name = "Node0";
            treeNode241.Text = "LDFile";
            treeNode242.Name = "Node1";
            treeNode242.Text = "ToArray and FromArray methods added";
            treeNode243.Name = "Node0";
            treeNode243.Text = "LDxml";
            treeNode244.Name = "Node0";
            treeNode244.Text = "Version 1.2.12.0";
            treeNode245.Name = "Node2";
            treeNode245.Text = "DataViewColumnWidths method added";
            treeNode246.Name = "Node3";
            treeNode246.Text = "DataViewRowColours method added";
            treeNode247.Name = "Node1";
            treeNode247.Text = "LDControls";
            treeNode248.Name = "Node1";
            treeNode248.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode249.Name = "Node0";
            treeNode249.Text = "General";
            treeNode250.Name = "Node1";
            treeNode250.Text = "SetCentre method added";
            treeNode251.Name = "Node4";
            treeNode251.Text = "A 3rd rotation added";
            treeNode252.Name = "Node3";
            treeNode252.Text = "BoundingBox method added";
            treeNode253.Name = "Node0";
            treeNode253.Text = "LD3DView";
            treeNode254.Name = "Node3";
            treeNode254.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode255.Name = "Node2";
            treeNode255.Text = "LDDatabase";
            treeNode256.Name = "Node1";
            treeNode256.Text = "PlayMusic2 method added";
            treeNode257.Name = "Node2";
            treeNode257.Text = "Channel parameter added";
            treeNode258.Name = "Node0";
            treeNode258.Text = "LDMusic";
            treeNode259.Name = "Node0";
            treeNode259.Text = "Version 1.2.11.0";
            treeNode260.Name = "Node1";
            treeNode260.Text = "SetButtonStyle method added";
            treeNode261.Name = "Node0";
            treeNode261.Text = "LDControls";
            treeNode262.Name = "Node1";
            treeNode262.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode263.Name = "Node2";
            treeNode263.Text = "SetBillBoard method added";
            treeNode264.Name = "Node0";
            treeNode264.Text = "GetCameraUpDirection method added";
            treeNode265.Name = "Node1";
            treeNode265.Text = "Gradient brushes can be used";
            treeNode266.Name = "Node2";
            treeNode266.Text = "AutoControl method added";
            treeNode267.Name = "Node0";
            treeNode267.Text = "SpecularExponent property added";
            treeNode268.Name = "Node0";
            treeNode268.Text = "LD3DView";
            treeNode269.Name = "Node1";
            treeNode269.Text = "AddText method to annotate an image with text added";
            treeNode270.Name = "Node0";
            treeNode270.Text = "LDImage";
            treeNode271.Name = "Node4";
            treeNode271.Text = "BrushText for text on a brush added";
            treeNode272.Name = "Node0";
            treeNode272.Text = "Skew shapes method added";
            treeNode273.Name = "Node3";
            treeNode273.Text = "LDShapes";
            treeNode274.Name = "Node0";
            treeNode274.Text = "Version 1.2.10.0";
            treeNode275.Name = "Node1";
            treeNode275.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode276.Name = "Node0";
            treeNode276.Text = "LDUnits";
            treeNode277.Name = "Node1";
            treeNode277.Text = "Possible issue with FixSigFig fixed";
            treeNode278.Name = "Node0";
            treeNode278.Text = "LDMath";
            treeNode279.Name = "Node3";
            treeNode279.Text = "GetIndex method added (for SB arrays)";
            treeNode280.Name = "Node2";
            treeNode280.Text = "LDArray";
            treeNode281.Name = "Node5";
            treeNode281.Text = "Resize mode property added";
            treeNode282.Name = "Node6";
            treeNode282.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode283.Name = "Node4";
            treeNode283.Text = "LDGraphicsWindow";
            treeNode284.Name = "Node8";
            treeNode284.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode285.Name = "Node9";
            treeNode285.Text = "DataViewAllowUserEntry method added";
            treeNode286.Name = "Node7";
            treeNode286.Text = "LDControls";
            treeNode287.Name = "Node0";
            treeNode287.Text = "Version 1.2.9.0";
            treeNode288.Name = "Node1";
            treeNode288.Text = "New extended math object, starting with FFT";
            treeNode289.Name = "Node0";
            treeNode289.Text = "LDMathX";
            treeNode290.Name = "Node1";
            treeNode290.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode291.Name = "Node0";
            treeNode291.Text = "LDControls";
            treeNode292.Name = "Node3";
            treeNode292.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode293.Name = "Node2";
            treeNode293.Text = "LDArray";
            treeNode294.Name = "Node5";
            treeNode294.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode295.Name = "Node4";
            treeNode295.Text = "LDList";
            treeNode296.Name = "Node0";
            treeNode296.Text = "Version 1.2.8.0";
            treeNode297.Name = "Node2";
            treeNode297.Text = "Error handling, additional settings and multiple ports supported";
            treeNode298.Name = "Node1";
            treeNode298.Text = "LDCommPort";
            treeNode299.Name = "Node1";
            treeNode299.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode300.Name = "Node1";
            treeNode300.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode301.Name = "Node0";
            treeNode301.Text = "LDImage and LDWebCam";
            treeNode302.Name = "Node1";
            treeNode302.Text = "Bitwise operations object added";
            treeNode303.Name = "Node0";
            treeNode303.Text = "LDBits";
            treeNode304.Name = "Node1";
            treeNode304.Text = "Extended text encoding property added";
            treeNode305.Name = "Node0";
            treeNode305.Text = "TextWindow colours can be changed";
            treeNode306.Name = "Node0";
            treeNode306.Text = "LDTextWindow";
            treeNode307.Name = "Node1";
            treeNode307.Text = "GetWorkingImagePixelARGB method added";
            treeNode308.Name = "Node0";
            treeNode308.Text = "LDImage";
            treeNode309.Name = "Node1";
            treeNode309.Text = "RasteriseTurtleLines method added";
            treeNode310.Name = "Node0";
            treeNode310.Text = "LDShapes";
            treeNode311.Name = "Node0";
            treeNode311.Text = "Version 1.2.7.0";
            treeNode312.Name = "Node1";
            treeNode312.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode313.Name = "Node0";
            treeNode313.Text = "LDDialogs";
            treeNode314.Name = "Node1";
            treeNode314.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode315.Name = "Node2";
            treeNode315.Text = "ToggleSensor added";
            treeNode316.Name = "Node0";
            treeNode316.Text = "LDPhysics";
            treeNode317.Name = "Node1";
            treeNode317.Text = "Allow multiple copies of the webcam image";
            treeNode318.Name = "Node0";
            treeNode318.Text = "LDWebCam";
            treeNode319.Name = "Node1";
            treeNode319.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode320.Name = "Node0";
            treeNode320.Text = "MetaData method added";
            treeNode321.Name = "Node0";
            treeNode321.Text = "LDImage";
            treeNode322.Name = "Node0";
            treeNode322.Text = "Version 1.2.6.0";
            treeNode323.Name = "Node2";
            treeNode323.Text = "FixSigFig and FixDecimal methods added";
            treeNode324.Name = "Node3";
            treeNode324.Text = "MinNumber and MaxNumber properties added";
            treeNode325.Name = "Node1";
            treeNode325.Text = "LDMath";
            treeNode326.Name = "Node1";
            treeNode326.Text = "SliderMaximum property added";
            treeNode327.Name = "Node0";
            treeNode327.Text = "LDControls";
            treeNode328.Name = "Node1";
            treeNode328.Text = "ZoomAll method added";
            treeNode329.Name = "Node0";
            treeNode329.Text = "LDShapes";
            treeNode330.Name = "Node1";
            treeNode330.Text = "Reposition methods and properties added";
            treeNode331.Name = "Node0";
            treeNode331.Text = "LDGraphicsWindow";
            treeNode332.Name = "Node1";
            treeNode332.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode333.Name = "Node0";
            treeNode333.Text = "LDImage";
            treeNode334.Name = "Node1";
            treeNode334.Text = "MouseScroll parameter added";
            treeNode335.Name = "Node0";
            treeNode335.Text = "LDScrollBars";
            treeNode336.Name = "Node0";
            treeNode336.Text = "Version 1.2.5.0";
            treeNode337.Name = "Node0";
            treeNode337.Text = "New object added (previously a separate extension)";
            treeNode338.Name = "Node1";
            treeNode338.Text = "Async, Loop, Volume and Pan properties added";
            treeNode339.Name = "Node2";
            treeNode339.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode340.Name = "Node1";
            treeNode340.Text = "LDWaveForm";
            treeNode341.Name = "Node1";
            treeNode341.Text = "New object added to get input from gamepads or joysticks";
            treeNode342.Name = "Node0";
            treeNode342.Text = "LDController";
            treeNode343.Name = "Node1";
            treeNode343.Text = "RayCast method added";
            treeNode344.Name = "Node0";
            treeNode344.Text = "LDPhysics";
            treeNode345.Name = "Node0";
            treeNode345.Text = "Version 1.2.4.0";
            treeNode346.Name = "Node2";
            treeNode346.Text = "New object to apply effects to any shape or control";
            treeNode347.Name = "Node1";
            treeNode347.Text = "LDEffects";
            treeNode348.Name = "Node1";
            treeNode348.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode349.Name = "Node0";
            treeNode349.Text = "LDFigures";
            treeNode350.Name = "Node1";
            treeNode350.Text = "SetGroup method added";
            treeNode351.Name = "Node2";
            treeNode351.Text = "GetContacts method added";
            treeNode352.Name = "Node0";
            treeNode352.Text = "GetAllShapesAt method added";
            treeNode353.Name = "Node0";
            treeNode353.Text = "LDPhysics";
            treeNode354.Name = "Node2";
            treeNode354.Text = "SetImage handles images with transparency";
            treeNode355.Name = "Node0";
            treeNode355.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode356.Name = "Node1";
            treeNode356.Text = "LDClipboard";
            treeNode357.Name = "Node0";
            treeNode357.Text = "Version 1.2.3.0";
            treeNode358.Name = "Node2";
            treeNode358.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode359.Name = "Node1";
            treeNode359.Text = "LDShapes";
            treeNode360.Name = "Node4";
            treeNode360.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode361.Name = "Node3";
            treeNode361.Text = "LDFile";
            treeNode362.Name = "Node6";
            treeNode362.Text = "NewImage method added";
            treeNode363.Name = "Node5";
            treeNode363.Text = "LDImage";
            treeNode364.Name = "Node1";
            treeNode364.Text = "SetStartupPosition method added to position dialogs";
            treeNode365.Name = "Node0";
            treeNode365.Text = "LDDialogs";
            treeNode366.Name = "Node1";
            treeNode366.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode367.Name = "Node0";
            treeNode367.Text = "LDGraph";
            treeNode368.Name = "Node0";
            treeNode368.Text = "Version 1.2.2.0";
            treeNode369.Name = "Node2";
            treeNode369.Text = "Recompiled for Small Basic version 1.2";
            treeNode370.Name = "Node1";
            treeNode370.Text = "Version 1.2";
            treeNode371.Name = "Node0";
            treeNode371.Text = "Version 1.2.0.1";
            treeNode372.Name = "Node2";
            treeNode372.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode373.Name = "Node1";
            treeNode373.Text = "LDDialogs";
            treeNode374.Name = "Node1";
            treeNode374.Text = "Logical operations object added";
            treeNode375.Name = "Node0";
            treeNode375.Text = "LDLogic";
            treeNode376.Name = "Node4";
            treeNode376.Text = "CurrentCulture property added";
            treeNode377.Name = "Node3";
            treeNode377.Text = "LDUtilities";
            treeNode378.Name = "Node6";
            treeNode378.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode379.Name = "Node5";
            treeNode379.Text = "LDMath";
            treeNode380.Name = "Node0";
            treeNode380.Text = "Version 1.1.0.8";
            treeNode381.Name = "Node1";
            treeNode381.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode382.Name = "Node0";
            treeNode382.Text = "LDControls";
            treeNode383.Name = "Node1";
            treeNode383.Text = "Methods added to add and remove nodes and save xml file";
            treeNode384.Name = "Node0";
            treeNode384.Text = "LDxml";
            treeNode385.Name = "Node1";
            treeNode385.Text = "MusicPlayTime moved from LDFile";
            treeNode386.Name = "Node0";
            treeNode386.Text = "LDSound";
            treeNode387.Name = "Node0";
            treeNode387.Text = "Version 1.1.0.7";
            treeNode388.Name = "Node4";
            treeNode388.Text = "SplitImage method added";
            treeNode389.Name = "Node3";
            treeNode389.Text = "LDImage";
            treeNode390.Name = "Node6";
            treeNode390.Text = "EditTable and SaveTable methods added";
            treeNode391.Name = "Node5";
            treeNode391.Text = "LDDatabse";
            treeNode392.Name = "Node2";
            treeNode392.Text = "DataView control and methods added";
            treeNode393.Name = "Node1";
            treeNode393.Text = "LDControls";
            treeNode394.Name = "Node2";
            treeNode394.Text = "Version 1.1.0.6";
            treeNode395.Name = "Node2";
            treeNode395.Text = "Exists modified to check for directory as well as file";
            treeNode396.Name = "Node3";
            treeNode396.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode397.Name = "Node1";
            treeNode397.Text = "LDFile";
            treeNode398.Name = "Node5";
            treeNode398.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode399.Name = "Node6";
            treeNode399.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode400.Name = "Node9";
            treeNode400.Text = "Conditonal break point added";
            treeNode401.Name = "Node0";
            treeNode401.Text = "Step over button added";
            treeNode402.Name = "Node4";
            treeNode402.Text = "LDDebug";
            treeNode403.Name = "Node8";
            treeNode403.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode404.Name = "Node7";
            treeNode404.Text = "LDGraphicsWindow";
            treeNode405.Name = "Node1";
            treeNode405.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode406.Name = "Node0";
            treeNode406.Text = "LDResources";
            treeNode407.Name = "Node0";
            treeNode407.Text = "Version 1.1.0.5";
            treeNode408.Name = "Node2";
            treeNode408.Text = "ClipboardChanged event added";
            treeNode409.Name = "Node1";
            treeNode409.Text = "LDClipboard";
            treeNode410.Name = "Node1";
            treeNode410.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode411.Name = "Node0";
            treeNode411.Text = "LDFile";
            treeNode412.Name = "Node3";
            treeNode412.Text = "SetActive method added";
            treeNode413.Name = "Node2";
            treeNode413.Text = "LDGraphicsWindow";
            treeNode414.Name = "Node1";
            treeNode414.Text = "Parse xml file nodes";
            treeNode415.Name = "Node0";
            treeNode415.Text = "LDxml";
            treeNode416.Name = "Node3";
            treeNode416.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode417.Name = "Node2";
            treeNode417.Text = "General";
            treeNode418.Name = "Node0";
            treeNode418.Text = "Version 1.1.0.4";
            treeNode419.Name = "Node2";
            treeNode419.Text = "WakeAll method addded";
            treeNode420.Name = "Node1";
            treeNode420.Text = "LDPhysics";
            treeNode421.Name = "Node1";
            treeNode421.Text = "Clipboard methods added";
            treeNode422.Name = "Node0";
            treeNode422.Text = "LDClipboard";
            treeNode423.Name = "Node0";
            treeNode423.Text = "Version 1.1.0.3";
            treeNode424.Name = "Node6";
            treeNode424.Text = "SizeNWSE cursor added";
            treeNode425.Name = "Node5";
            treeNode425.Text = "LDCursors";
            treeNode426.Name = "Node8";
            treeNode426.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode427.Name = "Node7";
            treeNode427.Text = "LDGraph";
            treeNode428.Name = "Node1";
            treeNode428.Text = "SQLite updated for .Net 4.5";
            treeNode429.Name = "Node0";
            treeNode429.Text = "LDDataBase";
            treeNode430.Name = "Node4";
            treeNode430.Text = "Version 1.1.0.2";
            treeNode431.Name = "Node3";
            treeNode431.Text = "Recompiled for Small Basic version 1.1";
            treeNode432.Name = "Node2";
            treeNode432.Text = "Version 1.1";
            treeNode433.Name = "Node0";
            treeNode433.Text = "Version 1.1.0.1";
            treeNode434.Name = "Node12";
            treeNode434.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode435.Name = "Node13";
            treeNode435.Text = "RichTextBoxMargins method added";
            treeNode436.Name = "Node0";
            treeNode436.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode437.Name = "Node1";
            treeNode437.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode438.Name = "Node11";
            treeNode438.Text = "LDControls";
            treeNode439.Name = "Node3";
            treeNode439.Text = "Error reporting added";
            treeNode440.Name = "Node4";
            treeNode440.Text = "SetEncoding method added";
            treeNode441.Name = "Node2";
            treeNode441.Text = "LDCommPort";
            treeNode442.Name = "Node6";
            treeNode442.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode443.Name = "Node7";
            treeNode443.Text = "Export to excel fix for graph with no title";
            treeNode444.Name = "Node5";
            treeNode444.Text = "LDGraph";
            treeNode445.Name = "Node9";
            treeNode445.Text = "Negative restitution option when adding moving shape";
            treeNode446.Name = "Node8";
            treeNode446.Text = "LDPhysics";
            treeNode447.Name = "Node10";
            treeNode447.Text = "Version 1.0.0.133";
            treeNode448.Name = "Node2";
            treeNode448.Text = "Internal improvements to auto messaging";
            treeNode449.Name = "Node9";
            treeNode449.Text = "Name can be set and GetClients method added";
            treeNode450.Name = "Node1";
            treeNode450.Text = "LDClient";
            treeNode451.Name = "Node4";
            treeNode451.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode452.Name = "Node3";
            treeNode452.Text = "LDControls";
            treeNode453.Name = "Node8";
            treeNode453.Text = "Return message and possible file error fixed for Stop method";
            treeNode454.Name = "Node7";
            treeNode454.Text = "LDSound";
            treeNode455.Name = "Node0";
            treeNode455.Text = "Version 1.0.0.132";
            treeNode456.Name = "Node2";
            treeNode456.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode457.Name = "Node5";
            treeNode457.Text = "Compile method added to compile a Small Basic program";
            treeNode458.Name = "Node1";
            treeNode458.Text = "LDCall";
            treeNode459.Name = "Node4";
            treeNode459.Text = "Methods and code by Pappa Lapub added";
            treeNode460.Name = "Node3";
            treeNode460.Text = "LDShell";
            treeNode461.Name = "Node0";
            treeNode461.Text = "Version 1.0.0.131";
            treeNode462.Name = "Node6";
            treeNode462.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode463.Name = "Node7";
            treeNode463.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode464.Name = "Node8";
            treeNode464.Text = "Refactoring of all the pan, follow and box methods";
            treeNode465.Name = "Node6";
            treeNode465.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode466.Name = "Node8";
            treeNode466.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode467.Name = "Node5";
            treeNode467.Text = "LDPhysics";
            treeNode468.Name = "Node1";
            treeNode468.Text = "UseBinary property added";
            treeNode469.Name = "Node2";
            treeNode469.Text = "DoAsync property and associated completion events added";
            treeNode470.Name = "Node3";
            treeNode470.Text = "Delete method added";
            treeNode471.Name = "Node0";
            treeNode471.Text = "LDftp";
            treeNode472.Name = "Node5";
            treeNode472.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode473.Name = "Node4";
            treeNode473.Text = "LDCall";
            treeNode474.Name = "Node2";
            treeNode474.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode475.Name = "Node1";
            treeNode475.Text = "LDControls";
            treeNode476.Name = "Node4";
            treeNode476.Text = "Version 1.0.0.130";
            treeNode477.Name = "Node2";
            treeNode477.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode478.Name = "Node1";
            treeNode478.Text = "LDMath";
            treeNode479.Name = "Node1";
            treeNode479.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode480.Name = "Node0";
            treeNode480.Text = "LDPhysics";
            treeNode481.Name = "Node3";
            treeNode481.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode482.Name = "Node2";
            treeNode482.Text = "LDGraphicsWindow";
            treeNode483.Name = "Node1";
            treeNode483.Text = "FTP object methods added";
            treeNode484.Name = "Node0";
            treeNode484.Text = "LDftp";
            treeNode485.Name = "Node3";
            treeNode485.Text = "An existing file is replaced";
            treeNode486.Name = "Node2";
            treeNode486.Text = "LDZip";
            treeNode487.Name = "Node1";
            treeNode487.Text = "Size method added";
            treeNode488.Name = "Node0";
            treeNode488.Text = "LDFile";
            treeNode489.Name = "Node3";
            treeNode489.Text = "DownloadFile method added";
            treeNode490.Name = "Node2";
            treeNode490.Text = "LDNetwork";
            treeNode491.Name = "Node0";
            treeNode491.Text = "Version 1.0.0.129";
            treeNode492.Name = "Node2";
            treeNode492.Text = "Generalised joint connections added";
            treeNode493.Name = "Node0";
            treeNode493.Text = "AddExplosion method added";
            treeNode494.Name = "Node1";
            treeNode494.Text = "LDPhysics";
            treeNode495.Name = "Node1";
            treeNode495.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode496.Name = "Node0";
            treeNode496.Text = "LDShapes";
            treeNode497.Name = "Node0";
            treeNode497.Text = "Version 1.0.0.128";
            treeNode498.Name = "Node2";
            treeNode498.Text = "CheckServer method added";
            treeNode499.Name = "Node1";
            treeNode499.Text = "LDClient";
            treeNode500.Name = "Node1";
            treeNode500.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode501.Name = "Node2";
            treeNode501.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode502.Name = "Node3";
            treeNode502.Text = "GetAngle method added";
            treeNode503.Name = "Node4";
            treeNode503.Text = "Top-down tire (to model a car from above) methods added";
            treeNode504.Name = "Node0";
            treeNode504.Text = "LDPhysics";
            treeNode505.Name = "Node0";
            treeNode505.Text = "Version 1.0.0.127";
            treeNode506.Name = "Node7";
            treeNode506.Text = "Bug fixes for Overlap methods";
            treeNode507.Name = "Node6";
            treeNode507.Text = "LDShapes";
            treeNode508.Name = "Node0";
            treeNode508.Text = "Bug fix for multiple numeric sorts";
            treeNode509.Name = "Node9";
            treeNode509.Text = "ByValueWithIndex method added";
            treeNode510.Name = "Node8";
            treeNode510.Text = "LDSort";
            treeNode511.Name = "Node1";
            treeNode511.Text = "LAN method added to get local IP addresses";
            treeNode512.Name = "Node2";
            treeNode512.Text = "Ping method added";
            treeNode513.Name = "Node0";
            treeNode513.Text = "LDNetwork";
            treeNode514.Name = "Node1";
            treeNode514.Text = "LoadSVG method added";
            treeNode515.Name = "Node0";
            treeNode515.Text = "LDImage";
            treeNode516.Name = "Node3";
            treeNode516.Text = "Evaluate method added";
            treeNode517.Name = "Node2";
            treeNode517.Text = "LDMath";
            treeNode518.Name = "Node5";
            treeNode518.Text = "IncludeJScript method added";
            treeNode519.Name = "Node4";
            treeNode519.Text = "LDInline";
            treeNode520.Name = "Node5";
            treeNode520.Text = "Version 1.0.0.126";
            treeNode521.Name = "Node0";
            treeNode521.Text = "Special emphasis on async consistency";
            treeNode522.Name = "Node4";
            treeNode522.Text = "Simplified auto method for multi-player game data transfer";
            treeNode523.Name = "Node9";
            treeNode523.Text = "LDServer and LDClient objects added";
            treeNode524.Name = "Node2";
            treeNode524.Text = "GetWidth and GetHeight methods added";
            treeNode525.Name = "Node1";
            treeNode525.Text = "LDText";
            treeNode526.Name = "Node4";
            treeNode526.Text = "Bing web search";
            treeNode527.Name = "Node3";
            treeNode527.Text = "LDSearch";
            treeNode528.Name = "Node6";
            treeNode528.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode529.Name = "Node7";
            treeNode529.Text = "KeyScroll property added";
            treeNode530.Name = "Node5";
            treeNode530.Text = "LDScrollBars";
            treeNode531.Name = "Node9";
            treeNode531.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode532.Name = "Node8";
            treeNode532.Text = "LDShapes";
            treeNode533.Name = "Node1";
            treeNode533.Text = "SaveAs method bug fixed";
            treeNode534.Name = "Node0";
            treeNode534.Text = "LDImage";
            treeNode535.Name = "Node3";
            treeNode535.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode536.Name = "Node2";
            treeNode536.Text = "LDQueue";
            treeNode537.Name = "Node8";
            treeNode537.Text = "Version 1.0.0.125";
            treeNode538.Name = "Node7";
            treeNode538.Text = "Language translation object added";
            treeNode539.Name = "Node6";
            treeNode539.Text = "LDTranslate";
            treeNode540.Name = "Node5";
            treeNode540.Text = "Version 1.0.0.124";
            treeNode541.Name = "Node1";
            treeNode541.Text = "Mouse screen coordinate conversion parameters added";
            treeNode542.Name = "Node2";
            treeNode542.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode543.Name = "Node0";
            treeNode543.Text = "LDGraphicsWindow";
            treeNode544.Name = "Node4";
            treeNode544.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode545.Name = "Node3";
            treeNode545.Text = "LDUtilities";
            treeNode546.Name = "Node0";
            treeNode546.Text = "Version 1.0.0.123";
            treeNode547.Name = "Node5";
            treeNode547.Text = "ColorMatrix method added";
            treeNode548.Name = "Node0";
            treeNode548.Text = "Rotate method added";
            treeNode549.Name = "Node3";
            treeNode549.Text = "LDImage";
            treeNode550.Name = "Node1";
            treeNode550.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode551.Name = "Node0";
            treeNode551.Text = "LDChart";
            treeNode552.Name = "Node2";
            treeNode552.Text = "Version 1.0.0.122";
            treeNode553.Name = "Node2";
            treeNode553.Text = "EffectGamma added to darken and lighten";
            treeNode554.Name = "Node4";
            treeNode554.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode555.Name = "Node3";
            treeNode555.Text = "EffectContrast modified";
            treeNode556.Name = "Node0";
            treeNode556.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode557.Name = "Node1";
            treeNode557.Text = "LDImage";
            treeNode558.Name = "Node2";
            treeNode558.Text = "Error event added for all extension exceptions";
            treeNode559.Name = "Node1";
            treeNode559.Text = "LDEvents";
            treeNode560.Name = "Node1";
            treeNode560.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode561.Name = "Node0";
            treeNode561.Text = "LDMath";
            treeNode562.Name = "Node0";
            treeNode562.Text = "Version 1.0.0.121";
            treeNode563.Name = "Node2";
            treeNode563.Text = "FloodFill transparency effect fixed";
            treeNode564.Name = "Node1";
            treeNode564.Text = "LDGraphicsWindow";
            treeNode565.Name = "Node1";
            treeNode565.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode566.Name = "Node0";
            treeNode566.Text = "LDFile";
            treeNode567.Name = "Node1";
            treeNode567.Text = "EffectPixelate added";
            treeNode568.Name = "Node0";
            treeNode568.Text = "LDImage";
            treeNode569.Name = "Node1";
            treeNode569.Text = "Modified to work with Windows 8";
            treeNode570.Name = "Node0";
            treeNode570.Text = "LDWebCam";
            treeNode571.Name = "Node0";
            treeNode571.Text = "Version 1.0.0.120";
            treeNode572.Name = "Node2";
            treeNode572.Text = "FloodFill method added";
            treeNode573.Name = "Node1";
            treeNode573.Text = "LDGraphicsWindow";
            treeNode574.Name = "Node0";
            treeNode574.Text = "Version 1.0.0.119";
            treeNode575.Name = "Node0";
            treeNode575.Text = "SetShapeCursor method added";
            treeNode576.Name = "Node11";
            treeNode576.Text = "CreateCursor method added";
            treeNode577.Name = "Node9";
            treeNode577.Text = "LDCursors";
            treeNode578.Name = "Node2";
            treeNode578.Text = "SaveAs method to save in different file formats";
            treeNode579.Name = "Node0";
            treeNode579.Text = "Parameters added for some effects";
            treeNode580.Name = "Node1";
            treeNode580.Text = "LDImage";
            treeNode581.Name = "Node2";
            treeNode581.Text = "Parameters added for some effects";
            treeNode582.Name = "Node1";
            treeNode582.Text = "LDWebCam";
            treeNode583.Name = "Node1";
            treeNode583.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode584.Name = "Node0";
            treeNode584.Text = "SetFontFromFile method added for ttf fonts";
            treeNode585.Name = "Node0";
            treeNode585.Text = "LDGraphicsWindow";
            treeNode586.Name = "Node3";
            treeNode586.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode587.Name = "Node2";
            treeNode587.Text = "LDTextWindow";
            treeNode588.Name = "Node2";
            treeNode588.Text = "Zip methods moved here from LDUtilities";
            treeNode589.Name = "Node0";
            treeNode589.Text = "LDZip";
            treeNode590.Name = "Node3";
            treeNode590.Text = "Regex methods moved here from LDUtilities";
            treeNode591.Name = "Node1";
            treeNode591.Text = "LDRegex";
            treeNode592.Name = "Node1";
            treeNode592.Text = "ListViewRowCount method added";
            treeNode593.Name = "Node0";
            treeNode593.Text = "LDControls";
            treeNode594.Name = "Node3";
            treeNode594.Text = "Version 1.0.0.118";
            treeNode595.Name = "Node5";
            treeNode595.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode596.Name = "Node6";
            treeNode596.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode597.Name = "Node4";
            treeNode597.Text = "LDUtilities";
            treeNode598.Name = "Node10";
            treeNode598.Text = "SetUserCursor method added";
            treeNode599.Name = "Node4";
            treeNode599.Text = "LDCursors";
            treeNode600.Name = "Node3";
            treeNode600.Text = "Version 1.0.0.117";
            treeNode601.Name = "Node2";
            treeNode601.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode602.Name = "Node1";
            treeNode602.Text = "LDDictionary";
            treeNode603.Name = "Node0";
            treeNode603.Text = "Version 1.0.0.116";
            treeNode604.Name = "Node2";
            treeNode604.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode605.Name = "Node1";
            treeNode605.Text = "LDColours";
            treeNode606.Name = "Node4";
            treeNode606.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode607.Name = "Node3";
            treeNode607.Text = "LDShapes";
            treeNode608.Name = "Node1";
            treeNode608.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode609.Name = "Node0";
            treeNode609.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode610.Name = "Node1";
            treeNode610.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode611.Name = "Node0";
            treeNode611.Text = "LDGraph";
            treeNode612.Name = "Node0";
            treeNode612.Text = "Version 1.0.0.115";
            treeNode613.Name = "Node2";
            treeNode613.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode614.Name = "Node1";
            treeNode614.Text = "LDControls";
            treeNode615.Name = "Node4";
            treeNode615.Text = "RemoveTurtleLines method added";
            treeNode616.Name = "Node6";
            treeNode616.Text = "GetAllShapes method added";
            treeNode617.Name = "Node3";
            treeNode617.Text = "LDShapes";
            treeNode618.Name = "Node1";
            treeNode618.Text = "Odbc connection added";
            treeNode619.Name = "Node0";
            treeNode619.Text = "LDDatabase";
            treeNode620.Name = "Node0";
            treeNode620.Text = "Version 1.0.0.114";
            treeNode621.Name = "Node2";
            treeNode621.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode622.Name = "Node1";
            treeNode622.Text = "LDUtilities";
            treeNode623.Name = "Node4";
            treeNode623.Text = "ListView control added";
            treeNode624.Name = "Node5";
            treeNode624.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode625.Name = "Node3";
            treeNode625.Text = "LDControls";
            treeNode626.Name = "Node0";
            treeNode626.Text = "Version 1.0.0.113";
            treeNode627.Name = "Node2";
            treeNode627.Text = "Tone method added";
            treeNode628.Name = "Node1";
            treeNode628.Text = "LDSound";
            treeNode629.Name = "Node5";
            treeNode629.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode630.Name = "Node4";
            treeNode630.Text = "LDControls";
            treeNode631.Name = "Node0";
            treeNode631.Text = "Version 1.0.0.112";
            treeNode632.Name = "Node2";
            treeNode632.Text = "SqlServer and Access database support added";
            treeNode633.Name = "Node1";
            treeNode633.Text = "LDDataBase";
            treeNode634.Name = "Node4";
            treeNode634.Text = "FixFlickr method added";
            treeNode635.Name = "Node0";
            treeNode635.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode636.Name = "Node3";
            treeNode636.Text = "LDUtilities";
            treeNode637.Name = "Node0";
            treeNode637.Text = "Version 1.0.0.111";
            treeNode638.Name = "Node2";
            treeNode638.Text = "TextBoxTab method added";
            treeNode639.Name = "Node1";
            treeNode639.Text = "LDControls";
            treeNode640.Name = "Node0";
            treeNode640.Text = "Version 1.0.0.110";
            treeNode641.Name = "Node1";
            treeNode641.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode642.Name = "Node3";
            treeNode642.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode643.Name = "Node0";
            treeNode643.Text = "General";
            treeNode644.Name = "Node5";
            treeNode644.Text = "Exists method added to check if a file path exists or not";
            treeNode645.Name = "Node4";
            treeNode645.Text = "LDFile";
            treeNode646.Name = "Node7";
            treeNode646.Text = "Start method handles attaching to existing process without warning";
            treeNode647.Name = "Node6";
            treeNode647.Text = "LDProcess";
            treeNode648.Name = "Node1";
            treeNode648.Text = "MySQL database support added";
            treeNode649.Name = "Node0";
            treeNode649.Text = "LDDatabase";
            treeNode650.Name = "Node3";
            treeNode650.Text = "Add and Multiply methods honour transparency";
            treeNode651.Name = "Node4";
            treeNode651.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode652.Name = "Node2";
            treeNode652.Text = "LDImage";
            treeNode653.Name = "Node3";
            treeNode653.Text = "Version 1.0.0.109";
            treeNode654.Name = "Node2";
            treeNode654.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode655.Name = "Node1";
            treeNode655.Text = "LDTextWindow";
            treeNode656.Name = "Node0";
            treeNode656.Text = "Version 1.0.0.108";
            treeNode657.Name = "Node14";
            treeNode657.Text = "Transparent colour added";
            treeNode658.Name = "Node13";
            treeNode658.Text = "LDColours";
            treeNode659.Name = "Node16";
            treeNode659.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode660.Name = "Node15";
            treeNode660.Text = "LDDialogs";
            treeNode661.Name = "Node12";
            treeNode661.Text = "Version 1.0.0.107";
            treeNode662.Name = "Node8";
            treeNode662.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode663.Name = "Node7";
            treeNode663.Text = "LDControls";
            treeNode664.Name = "Node11";
            treeNode664.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode665.Name = "Node10";
            treeNode665.Text = "LDShapes";
            treeNode666.Name = "Node6";
            treeNode666.Text = "Version 1.0.0.106";
            treeNode667.Name = "Node5";
            treeNode667.Text = "Menu control added";
            treeNode668.Name = "Node4";
            treeNode668.Text = "LDControls";
            treeNode669.Name = "Node3";
            treeNode669.Text = "Version 1.0.0.105";
            treeNode670.Name = "Node5";
            treeNode670.Text = "ZipList method added";
            treeNode671.Name = "Node2";
            treeNode671.Text = "GetNextMapIndex method added";
            treeNode672.Name = "Node4";
            treeNode672.Text = "LDUtilities";
            treeNode673.Name = "Node1";
            treeNode673.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode674.Name = "Node0";
            treeNode674.Text = "LDShapes";
            treeNode675.Name = "Node3";
            treeNode675.Text = "Version 1.0.0.104";
            treeNode676.Name = "Node1";
            treeNode676.Text = "Transparency maintained for various methods";
            treeNode677.Name = "Node2";
            treeNode677.Text = "Effects bug fixed";
            treeNode678.Name = "Node0";
            treeNode678.Text = "LDImage";
            treeNode679.Name = "Node0";
            treeNode679.Text = "Version 1.0.0.103";
            treeNode680.Name = "Node1";
            treeNode680.Text = "Current application assemblies are all auto-referenced";
            treeNode681.Name = "Node0";
            treeNode681.Text = "LDInline";
            treeNode682.Name = "Node5";
            treeNode682.Text = "Version 1.0.0.102";
            treeNode683.Name = "Node1";
            treeNode683.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode684.Name = "Node2";
            treeNode684.Text = "LDInline.sb sample provided";
            treeNode685.Name = "Node0";
            treeNode685.Text = "LDInline";
            treeNode686.Name = "Node4";
            treeNode686.Text = "ExitButtonMode method added to control window close button state";
            treeNode687.Name = "Node3";
            treeNode687.Text = "LDUtilities";
            treeNode688.Name = "Node0";
            treeNode688.Text = "Version 1.0.0.101";
            treeNode689.Name = "Node1";
            treeNode689.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode690.Name = "Node0";
            treeNode690.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode691.Name = "Node0";
            treeNode691.Text = "LDTextWindow";
            treeNode692.Name = "Node0";
            treeNode692.Text = "Version 1.0.0.100";
            treeNode693.Name = "Node2";
            treeNode693.Text = "ReadANSIToArray method added";
            treeNode694.Name = "Node1";
            treeNode694.Text = "LDFile";
            treeNode695.Name = "Node1";
            treeNode695.Text = "DocumentViewer control added";
            treeNode696.Name = "Node0";
            treeNode696.Text = "LDControls";
            treeNode697.Name = "Node3";
            treeNode697.Text = "An object to batch update shapes (for speed reasons)";
            treeNode698.Name = "Node0";
            treeNode698.Text = "LDFastShapes.sb sample included";
            treeNode699.Name = "Node2";
            treeNode699.Text = "LDFastShapes";
            treeNode700.Name = "Node0";
            treeNode700.Text = "Version 1.0.0.99";
            treeNode701.Name = "Node1";
            treeNode701.Text = "Rendering performance improvements when many shapes present";
            treeNode702.Name = "Node0";
            treeNode702.Text = "LDPhysics";
            treeNode703.Name = "Node1";
            treeNode703.Text = "ANSItoUTF8 method added";
            treeNode704.Name = "Node2";
            treeNode704.Text = "ReadANSI method added";
            treeNode705.Name = "Node0";
            treeNode705.Text = "LDFile";
            treeNode706.Name = "Node1";
            treeNode706.Text = "Version 1.0.0.98";
            treeNode707.Name = "Node3";
            treeNode707.Text = "Move method added for tiangles, polygons and lines";
            treeNode708.Name = "Node4";
            treeNode708.Text = "RotateAbout method added";
            treeNode709.Name = "Node1";
            treeNode709.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode710.Name = "Node0";
            treeNode710.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode711.Name = "Node2";
            treeNode711.Text = "LDShapes";
            treeNode712.Name = "Node0";
            treeNode712.Text = "Version 1.0.0.97";
            treeNode713.Name = "Node4";
            treeNode713.Text = "A list storage object added";
            treeNode714.Name = "Node3";
            treeNode714.Text = "LDList";
            treeNode715.Name = "Node2";
            treeNode715.Text = "Version 1.0.0.96";
            treeNode716.Name = "Node4";
            treeNode716.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode717.Name = "Node3";
            treeNode717.Text = "LDQueue";
            treeNode718.Name = "Node6";
            treeNode718.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode719.Name = "Node5";
            treeNode719.Text = "LDNetwork";
            treeNode720.Name = "Node0";
            treeNode720.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode721.Name = "Node1";
            treeNode721.Text = "General";
            treeNode722.Name = "Node2";
            treeNode722.Text = "Version 1.0.0.95";
            treeNode723.Name = "Node2";
            treeNode723.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode724.Name = "Node1";
            treeNode724.Text = "LDEncryption";
            treeNode725.Name = "Node1";
            treeNode725.Text = "RandomNumberSeed property added";
            treeNode726.Name = "Node0";
            treeNode726.Text = "LDMath";
            treeNode727.Name = "Node1";
            treeNode727.Text = "SetGameData and GetGameData methods added";
            treeNode728.Name = "Node0";
            treeNode728.Text = "LDNetwork";
            treeNode729.Name = "Node0";
            treeNode729.Text = "Version 1.0.0.94";
            treeNode730.Name = "Node1";
            treeNode730.Text = "SliderGetValue method added";
            treeNode731.Name = "Node0";
            treeNode731.Text = "LDControls";
            treeNode732.Name = "Node5";
            treeNode732.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode733.Name = "Node2";
            treeNode733.Text = "LDUtilities";
            treeNode734.Name = "Node3";
            treeNode734.Text = "Encrypt and Decrypt methods added";
            treeNode735.Name = "Node4";
            treeNode735.Text = "MD5Hash method added";
            treeNode736.Name = "Node6";
            treeNode736.Text = "LDEncryption";
            treeNode737.Name = "Node0";
            treeNode737.Text = "Version 1.0.0.93";
            treeNode738.Name = "Node1";
            treeNode738.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode739.Name = "Node0";
            treeNode739.Text = "LDControls";
            treeNode740.Name = "Node0";
            treeNode740.Text = "Version 1.0.0.92";
            treeNode741.Name = "Node2";
            treeNode741.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode742.Name = "Node1";
            treeNode742.Text = "LDControls";
            treeNode743.Name = "Node1";
            treeNode743.Text = "Version 1.0.0.91";
            treeNode744.Name = "Node1";
            treeNode744.Text = "Font method added to modify shapes or controls that have text";
            treeNode745.Name = "Node0";
            treeNode745.Text = "LDShapes";
            treeNode746.Name = "Node1";
            treeNode746.Text = "MediaPlayer control added (play videos etc)";
            treeNode747.Name = "Node0";
            treeNode747.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode748.Name = "Node0";
            treeNode748.Text = "LDControls";
            treeNode749.Name = "Node1";
            treeNode749.Text = "Version 1.0.0.90";
            treeNode750.Name = "Node1";
            treeNode750.Text = "Autosize columns for ListView";
            treeNode751.Name = "Node2";
            treeNode751.Text = "LDDataBase.sb sample updated";
            treeNode752.Name = "Node0";
            treeNode752.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode753.Name = "Node0";
            treeNode753.Text = "LDDataBase";
            treeNode754.Name = "Node0";
            treeNode754.Text = "Version 1.0.0.89";
            treeNode755.Name = "Node4";
            treeNode755.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode756.Name = "Node3";
            treeNode756.Text = "LDScrollBars";
            treeNode757.Name = "Node1";
            treeNode757.Text = "CleanTemp method added";
            treeNode758.Name = "Node0";
            treeNode758.Text = "LDUtilities";
            treeNode759.Name = "Node1";
            treeNode759.Text = "SQLite database methods added";
            treeNode760.Name = "Node0";
            treeNode760.Text = "LDDataBase";
            treeNode761.Name = "Node2";
            treeNode761.Text = "Version 1.0.0.88";
            treeNode762.Name = "Node2";
            treeNode762.Text = "LastError now returns a text error";
            treeNode763.Name = "Node1";
            treeNode763.Text = "LDIOWarrior";
            treeNode764.Name = "Node1";
            treeNode764.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode765.Name = "Node0";
            treeNode765.Text = "LDScrollBars";
            treeNode766.Name = "Node0";
            treeNode766.Text = "Version 1.0.0.87";
            treeNode767.Name = "Node4";
            treeNode767.Text = "SetTurtleImage method added";
            treeNode768.Name = "Node3";
            treeNode768.Text = "LDShapes";
            treeNode769.Name = "Node1";
            treeNode769.Text = "Connect to IOWarrior USB devices";
            treeNode770.Name = "Node0";
            treeNode770.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode771.Name = "Node0";
            treeNode771.Text = "LDIOWarrior";
            treeNode772.Name = "Node2";
            treeNode772.Text = "Version 1.0.0.86";
            treeNode773.Name = "Node1";
            treeNode773.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode774.Name = "Node0";
            treeNode774.Text = "LDShapes";
            treeNode775.Name = "Node2";
            treeNode775.Text = "Version 1.0.0.85";
            treeNode776.Name = "Node4";
            treeNode776.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode777.Name = "Node3";
            treeNode777.Text = "LDFile";
            treeNode778.Name = "Node6";
            treeNode778.Text = "Crop method added";
            treeNode779.Name = "Node5";
            treeNode779.Text = "LDImage";
            treeNode780.Name = "Node1";
            treeNode780.Text = "LastDropFiles bug fixed";
            treeNode781.Name = "Node0";
            treeNode781.Text = "LDControls";
            treeNode782.Name = "Node2";
            treeNode782.Text = "Version 1.0.0.84";
            treeNode783.Name = "Node7";
            treeNode783.Text = "FileDropped event added";
            treeNode784.Name = "Node6";
            treeNode784.Text = "LDControls";
            treeNode785.Name = "Node1";
            treeNode785.Text = "Bug in Split corrected";
            treeNode786.Name = "Node0";
            treeNode786.Text = "LDText";
            treeNode787.Name = "Node5";
            treeNode787.Text = "Version 1.0.0.83";
            treeNode788.Name = "Node3";
            treeNode788.Text = "Title argument removed from AddComboBox";
            treeNode789.Name = "Node4";
            treeNode789.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode790.Name = "Node2";
            treeNode790.Text = "LDControls";
            treeNode791.Name = "Node1";
            treeNode791.Text = "Version 1.0.0.82";
            treeNode792.Name = "Node0";
            treeNode792.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode793.Name = "Node12";
            treeNode793.Text = "Program settings added";
            treeNode794.Name = "Node9";
            treeNode794.Text = "LDSettings";
            treeNode795.Name = "Node11";
            treeNode795.Text = "Get some system paths and user name";
            treeNode796.Name = "Node10";
            treeNode796.Text = "LDFile";
            treeNode797.Name = "Node14";
            treeNode797.Text = "System sounds added";
            treeNode798.Name = "Node13";
            treeNode798.Text = "LDSound";
            treeNode799.Name = "Node16";
            treeNode799.Text = "Binary, octal, hex and decimal conversions";
            treeNode800.Name = "Node15";
            treeNode800.Text = "LDMath";
            treeNode801.Name = "Node1";
            treeNode801.Text = "Replace method added";
            treeNode802.Name = "Node2";
            treeNode802.Text = "FindAll method added";
            treeNode803.Name = "Node0";
            treeNode803.Text = "LDText";
            treeNode804.Name = "Node8";
            treeNode804.Text = "Version 1.0.0.81";
            treeNode805.Name = "Node1";
            treeNode805.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode806.Name = "Node6";
            treeNode806.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode807.Name = "Node0";
            treeNode807.Text = "LDShapes";
            treeNode808.Name = "Node3";
            treeNode808.Text = "Truncate method added";
            treeNode809.Name = "Node2";
            treeNode809.Text = "LDMath";
            treeNode810.Name = "Node5";
            treeNode810.Text = "Additional text methods";
            treeNode811.Name = "Node4";
            treeNode811.Text = "LDText";
            treeNode812.Name = "Node0";
            treeNode812.Text = "Version 1.0.0.80";
            treeNode813.Name = "Node1";
            treeNode813.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDDialogs";
            treeNode815.Name = "Node1";
            treeNode815.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode816.Name = "Node0";
            treeNode816.Text = "LDUtilities";
            treeNode817.Name = "Node6";
            treeNode817.Text = "Version 1.0.0.79";
            treeNode818.Name = "Node2";
            treeNode818.Text = "Rasterize property added";
            treeNode819.Name = "Node5";
            treeNode819.Text = "Improvements associated with window resizing";
            treeNode820.Name = "Node1";
            treeNode820.Text = "LDScrollBars";
            treeNode821.Name = "Node4";
            treeNode821.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode822.Name = "Node3";
            treeNode822.Text = "LDUtilities";
            treeNode823.Name = "Node0";
            treeNode823.Text = "Version 1.0.0.78";
            treeNode824.Name = "Node1";
            treeNode824.Text = "Handle more than 100 drawables (rasterization)";
            treeNode825.Name = "Node0";
            treeNode825.Text = "LDScollBars";
            treeNode826.Name = "Node2";
            treeNode826.Text = "Version 1.0.0.77";
            treeNode827.Name = "Node1";
            treeNode827.Text = "Record sound from a microphone";
            treeNode828.Name = "Node0";
            treeNode828.Text = "LDSound";
            treeNode829.Name = "Node3";
            treeNode829.Text = "AnimateOpacity method added (flashing)";
            treeNode830.Name = "Node0";
            treeNode830.Text = "AnimateRotation method added (continuous rotation)";
            treeNode831.Name = "Node1";
            treeNode831.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode832.Name = "Node2";
            treeNode832.Text = "LDShapes";
            treeNode833.Name = "Node2";
            treeNode833.Text = "Version 1.0.0.76";
            treeNode834.Name = "Node1";
            treeNode834.Text = "AddAnimatedImage can use an ImageList image";
            treeNode835.Name = "Node0";
            treeNode835.Text = "LDShapes";
            treeNode836.Name = "Node0";
            treeNode836.Text = "Version 1.0.0.75";
            treeNode837.Name = "Node1";
            treeNode837.Text = "Initial graph axes scaling improvement";
            treeNode838.Name = "Node0";
            treeNode838.Text = "LDGraph";
            treeNode839.Name = "Node3";
            treeNode839.Text = "Methods to access a bluetooth device";
            treeNode840.Name = "Node0";
            treeNode840.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode841.Name = "Node2";
            treeNode841.Text = "LDBlueTooth";
            treeNode842.Name = "Node1";
            treeNode842.Text = "getFocus handles multiple LDWindows";
            treeNode843.Name = "Node0";
            treeNode843.Text = "LDFocus";
            treeNode844.Name = "Node0";
            treeNode844.Text = "Version 1.0.0.74";
            treeNode845.Name = "Node1";
            treeNode845.Text = "First pass at a generic USB (HID) device controller";
            treeNode846.Name = "Node0";
            treeNode846.Text = "LDHID";
            treeNode847.Name = "Node9";
            treeNode847.Text = "Version 1.0.0.73";
            treeNode848.Name = "Node8";
            treeNode848.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode849.Name = "Node7";
            treeNode849.Text = "LDGraph";
            treeNode850.Name = "Node6";
            treeNode850.Text = "Version 1.0.0.72";
            treeNode851.Name = "Node4";
            treeNode851.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode852.Name = "Node5";
            treeNode852.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode853.Name = "Node3";
            treeNode853.Text = "LDGraph";
            treeNode854.Name = "Node2";
            treeNode854.Text = "Version 1.0.0.71";
            treeNode855.Name = "Node1";
            treeNode855.Text = "Spurious error message fixed";
            treeNode856.Name = "Node2";
            treeNode856.Text = "CreateTrend data series creation method added";
            treeNode857.Name = "Node0";
            treeNode857.Text = "LDGraph";
            treeNode858.Name = "Node2";
            treeNode858.Text = "Version 1.0.0.70";
            treeNode859.Name = "Node1";
            treeNode859.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode860.Name = "Node0";
            treeNode860.Text = "LDControls";
            treeNode861.Name = "Node3";
            treeNode861.Text = "Version 1.0.0.69";
            treeNode862.Name = "Node2";
            treeNode862.Text = "Radio button control added";
            treeNode863.Name = "Node1";
            treeNode863.Text = "LDControls";
            treeNode864.Name = "Node0";
            treeNode864.Text = "Version 1.0.0.68";
            treeNode865.Name = "Node1";
            treeNode865.Text = "Bug fix for Copy";
            treeNode866.Name = "Node0";
            treeNode866.Text = "LDArray";
            treeNode867.Name = "Node2";
            treeNode867.Text = "Version 1.0.0.67";
            treeNode868.Name = "Node1";
            treeNode868.Text = "RegexMatch and RegexReplace methods added";
            treeNode869.Name = "Node0";
            treeNode869.Text = "LDUtilities";
            treeNode870.Name = "Node3";
            treeNode870.Text = "Version 1.0.0.66";
            treeNode871.Name = "Node2";
            treeNode871.Text = "Number culture conversions added";
            treeNode872.Name = "Node1";
            treeNode872.Text = "LDUtilities";
            treeNode873.Name = "Node0";
            treeNode873.Text = "Version 1.0.0.65";
            treeNode874.Name = "Node1";
            treeNode874.Text = "IsNumber method added";
            treeNode875.Name = "Node0";
            treeNode875.Text = "LDUtilities";
            treeNode876.Name = "Node2";
            treeNode876.Text = "Version 1.0.0.64";
            treeNode877.Name = "Node1";
            treeNode877.Text = "SetCursorPosition method added for textboxes";
            treeNode878.Name = "Node0";
            treeNode878.Text = "LDControls";
            treeNode879.Name = "Node4";
            treeNode879.Text = "Version 1.0.0.63";
            treeNode880.Name = "Node1";
            treeNode880.Text = "SetCursorToEnd method added for textboxes";
            treeNode881.Name = "Node3";
            treeNode881.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode882.Name = "Node0";
            treeNode882.Text = "LDControls";
            treeNode883.Name = "Node2";
            treeNode883.Text = "Version 1.0.0.62";
            treeNode884.Name = "Node1";
            treeNode884.Text = "Adding polygons not located at (0,0) corrected";
            treeNode885.Name = "Node0";
            treeNode885.Text = "LDPhysics";
            treeNode886.Name = "Node2";
            treeNode886.Text = "Version 1.0.0.61";
            treeNode887.Name = "Node1";
            treeNode887.Text = "GetFolder dialog added";
            treeNode888.Name = "Node0";
            treeNode888.Text = "LDDialogs";
            treeNode889.Name = "Node0";
            treeNode889.Text = "Version 1.0.0.60";
            treeNode890.Name = "Node10";
            treeNode890.Text = "Possible localization issue with Font size fixed";
            treeNode891.Name = "Node9";
            treeNode891.Text = "LDDialogs";
            treeNode892.Name = "Node8";
            treeNode892.Text = "Version 1.0.0.59";
            treeNode893.Name = "Node3";
            treeNode893.Text = "More internationalization fixes";
            treeNode894.Name = "Node2";
            treeNode894.Text = "ShowPrintPreview property added";
            treeNode895.Name = "Node1";
            treeNode895.Text = "LDUtilities";
            treeNode896.Name = "Node5";
            treeNode896.Text = "Possible error with gradient drawings fixed";
            treeNode897.Name = "Node4";
            treeNode897.Text = "LDShapes";
            treeNode898.Name = "Node7";
            treeNode898.Text = "Possible Listen event initialisation error fixed";
            treeNode899.Name = "Node6";
            treeNode899.Text = "LDSpeech";
            treeNode900.Name = "Node0";
            treeNode900.Text = "Version 1.0.0.58";
            treeNode901.Name = "Node7";
            treeNode901.Text = "Many possible internationisation issues fixed";
            treeNode902.Name = "Node4";
            treeNode902.Text = "Version 1.0.0.57";
            treeNode903.Name = "Node1";
            treeNode903.Text = "Emmisive colour correction for AddGeometry";
            treeNode904.Name = "Node2";
            treeNode904.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode905.Name = "Node0";
            treeNode905.Text = "LD3DView";
            treeNode906.Name = "Node1";
            treeNode906.Text = "CSVdeminiator property added";
            treeNode907.Name = "Node0";
            treeNode907.Text = "LDUtilities";
            treeNode908.Name = "Node5";
            treeNode908.Text = "Version 1.0.0.56";
            treeNode909.Name = "Node1";
            treeNode909.Text = "Improved error reporting";
            treeNode910.Name = "Node2";
            treeNode910.Text = "Culture invariant type conversions";
            treeNode911.Name = "Node1";
            treeNode911.Text = "LD3DView";
            treeNode912.Name = "Node4";
            treeNode912.Text = "ShowErrors method added";
            treeNode913.Name = "Node3";
            treeNode913.Text = "LDUtilities";
            treeNode914.Name = "Node0";
            treeNode914.Text = "Version 1.0.0.55";
            treeNode915.Name = "Node4";
            treeNode915.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode916.Name = "Node3";
            treeNode916.Text = "LDScrollBars";
            treeNode917.Name = "Node6";
            treeNode917.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode918.Name = "Node5";
            treeNode918.Text = "LDUtilities";
            treeNode919.Name = "Node2";
            treeNode919.Text = "Version 1.0.0.54";
            treeNode920.Name = "Node1";
            treeNode920.Text = "Debug window can be resized";
            treeNode921.Name = "Node0";
            treeNode921.Text = "LDDebug";
            treeNode922.Name = "Node1";
            treeNode922.Text = "PrintFile method added";
            treeNode923.Name = "Node0";
            treeNode923.Text = "LDFile";
            treeNode924.Name = "Node2";
            treeNode924.Text = "Version 1.0.0.53";
            treeNode925.Name = "Node1";
            treeNode925.Text = "SSL property option added";
            treeNode926.Name = "Node0";
            treeNode926.Text = "LDEmail";
            treeNode927.Name = "Node0";
            treeNode927.Text = "Version 1.0.0.52";
            treeNode928.Name = "Node1";
            treeNode928.Text = "Right Click Context menu added for any shape or control";
            treeNode929.Name = "Node0";
            treeNode929.Text = "LDControls";
            treeNode930.Name = "Node0";
            treeNode930.Text = "Version 1.0.0.51";
            treeNode931.Name = "Node1";
            treeNode931.Text = "Right click dropdown menu option added";
            treeNode932.Name = "Node0";
            treeNode932.Text = "LDDialogs";
            treeNode933.Name = "Node0";
            treeNode933.Text = "Version 1.0.0.50";
            treeNode934.Name = "Node1";
            treeNode934.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode935.Name = "Node0";
            treeNode935.Text = "LD3DView";
            treeNode936.Name = "Node0";
            treeNode936.Text = "Version 1.0.0.49";
            treeNode937.Name = "Node1";
            treeNode937.Text = "Performance improvements (some camera controls for this)";
            treeNode938.Name = "Node1";
            treeNode938.Text = "LoadModel (*.3ds) files added";
            treeNode939.Name = "Node0";
            treeNode939.Text = "LD3DView";
            treeNode940.Name = "Node3";
            treeNode940.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode941.Name = "Node2";
            treeNode941.Text = "LDShapes";
            treeNode942.Name = "Node0";
            treeNode942.Text = "Version 1.0.0.48";
            treeNode943.Name = "Node1";
            treeNode943.Text = "Some improvements including animations";
            treeNode944.Name = "Node0";
            treeNode944.Text = "LD3DView";
            treeNode945.Name = "Node0";
            treeNode945.Text = "Version 1.0.0.47";
            treeNode946.Name = "Node1";
            treeNode946.Text = "Some improvemts and new methods";
            treeNode947.Name = "Node0";
            treeNode947.Text = "LD3Dview";
            treeNode948.Name = "Node2";
            treeNode948.Text = "Version 1.0.0.46";
            treeNode949.Name = "Node1";
            treeNode949.Text = "A start at a 3D set of methods";
            treeNode950.Name = "Node0";
            treeNode950.Text = "LD3DView";
            treeNode951.Name = "Node10";
            treeNode951.Text = "Version 1.0.0.45";
            treeNode952.Name = "Node1";
            treeNode952.Text = "Create scrollbars for the GraphicsWindow";
            treeNode953.Name = "Node5";
            treeNode953.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode954.Name = "Node0";
            treeNode954.Text = "LDScrollBars";
            treeNode955.Name = "Node4";
            treeNode955.Text = "ColourList method added";
            treeNode956.Name = "Node3";
            treeNode956.Text = "LDUtilities";
            treeNode957.Name = "Node8";
            treeNode957.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode958.Name = "Node9";
            treeNode958.Text = "BackgroundImage method to set the background added";
            treeNode959.Name = "Node6";
            treeNode959.Text = "LDShapes";
            treeNode960.Name = "Node0";
            treeNode960.Text = "Version 1.0.0.44";
            treeNode961.Name = "Node1";
            treeNode961.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode962.Name = "Node0";
            treeNode962.Text = "LDUtilities";
            treeNode963.Name = "Node0";
            treeNode963.Text = "Version 1.0.0.43";
            treeNode964.Name = "Node1";
            treeNode964.Text = "Call Subs as functions with arguments";
            treeNode965.Name = "Node0";
            treeNode965.Text = "LDCall";
            treeNode966.Name = "Node0";
            treeNode966.Text = "Version 1.0.0.42";
            treeNode967.Name = "Node1";
            treeNode967.Text = "Font dialog added";
            treeNode968.Name = "Node2";
            treeNode968.Text = "Colours dialog moved here from LDColours";
            treeNode969.Name = "Node0";
            treeNode969.Text = "LDDialogs";
            treeNode970.Name = "Node9";
            treeNode970.Text = "Version 1.0.0.41";
            treeNode971.Name = "Node1";
            treeNode971.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode972.Name = "Node7";
            treeNode972.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode973.Name = "Node8";
            treeNode973.Text = "Some methods renamed";
            treeNode974.Name = "Node0";
            treeNode974.Text = "LDControls";
            treeNode975.Name = "Node3";
            treeNode975.Text = "HighScore method move here";
            treeNode976.Name = "Node2";
            treeNode976.Text = "LDNetwork";
            treeNode977.Name = "Node6";
            treeNode977.Text = "SetSize method added";
            treeNode978.Name = "Node5";
            treeNode978.Text = "LDShapes";
            treeNode979.Name = "Node3";
            treeNode979.Text = "Version 1.0.0.40";
            treeNode980.Name = "Node1";
            treeNode980.Text = "SelectTreeView method added";
            treeNode981.Name = "Node2";
            treeNode981.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode982.Name = "Node0";
            treeNode982.Text = "LDDialogs";
            treeNode983.Name = "Node1";
            treeNode983.Text = "Simple high score web method";
            treeNode984.Name = "Node0";
            treeNode984.Text = "LDHighScore";
            treeNode985.Name = "Node3";
            treeNode985.Text = "Version 1.0.0.39";
            treeNode986.Name = "Node2";
            treeNode986.Text = "RichTextBox methods improved";
            treeNode987.Name = "Node1";
            treeNode987.Text = "LDDialogs";
            treeNode988.Name = "Node1";
            treeNode988.Text = "Search, Load and Save methods added";
            treeNode989.Name = "Node0";
            treeNode989.Text = "LDArray";
            treeNode990.Name = "Node0";
            treeNode990.Text = "Version 1.0.0.38";
            treeNode991.Name = "Node1";
            treeNode991.Text = "Depreciated";
            treeNode992.Name = "Node0";
            treeNode992.Text = "LDWeather";
            treeNode993.Name = "Node1";
            treeNode993.Text = "Renamed from LDTrig and some more methods added";
            treeNode994.Name = "Node0";
            treeNode994.Text = "LDMath";
            treeNode995.Name = "Node3";
            treeNode995.Text = "RichTextBox method added";
            treeNode996.Name = "Node2";
            treeNode996.Text = "LDDialogs";
            treeNode997.Name = "Node5";
            treeNode997.Text = "FontList method added";
            treeNode998.Name = "Node4";
            treeNode998.Text = "LDUtilities";
            treeNode999.Name = "Node2";
            treeNode999.Text = "Version 1.0.0.37";
            treeNode1000.Name = "Node1";
            treeNode1000.Text = "Zip method extended";
            treeNode1001.Name = "Node0";
            treeNode1001.Text = "LDUtilities";
            treeNode1002.Name = "Node2";
            treeNode1002.Text = "Version 1.0.0.36";
            treeNode1003.Name = "Node1";
            treeNode1003.Text = "Collapse and expand treeview nodes method added";
            treeNode1004.Name = "Node0";
            treeNode1004.Text = "LDDialogs";
            treeNode1005.Name = "Node5";
            treeNode1005.Text = "Version 1.0.0.35";
            treeNode1006.Name = "Node1";
            treeNode1006.Text = "Arguments added to Start method";
            treeNode1007.Name = "Node0";
            treeNode1007.Text = "LDProcess";
            treeNode1008.Name = "Node4";
            treeNode1008.Text = "Zip compression methods added";
            treeNode1009.Name = "Node2";
            treeNode1009.Text = "LDUtilities";
            treeNode1010.Name = "Node2";
            treeNode1010.Text = "Version 1.0.0.34";
            treeNode1011.Name = "Node1";
            treeNode1011.Text = "GWStyle property added";
            treeNode1012.Name = "Node0";
            treeNode1012.Text = "LDUtilities";
            treeNode1013.Name = "Node1";
            treeNode1013.Text = "TreeView and associated events added";
            treeNode1014.Name = "Node0";
            treeNode1014.Text = "LDDialogs";
            treeNode1015.Name = "Node0";
            treeNode1015.Text = "Version 1.0.0.33";
            treeNode1016.Name = "Node1";
            treeNode1016.Text = "Possible end points not plotting bug fixed";
            treeNode1017.Name = "Node0";
            treeNode1017.Text = "LDGraph";
            treeNode1018.Name = "Node2";
            treeNode1018.Text = "Version 1.0.0.32";
            treeNode1019.Name = "Node1";
            treeNode1019.Text = "Activated event and Active property addded";
            treeNode1020.Name = "Node0";
            treeNode1020.Text = "LDWindows";
            treeNode1021.Name = "Node0";
            treeNode1021.Text = "Version 1.0.0.31";
            treeNode1022.Name = "Node1";
            treeNode1022.Text = "Create multiple GraphicsWindows";
            treeNode1023.Name = "Node0";
            treeNode1023.Text = "LDWindows";
            treeNode1024.Name = "Node0";
            treeNode1024.Text = "Version 1.0.0.30";
            treeNode1025.Name = "Node1";
            treeNode1025.Text = "Email sending method";
            treeNode1026.Name = "Node0";
            treeNode1026.Text = "LDMail";
            treeNode1027.Name = "Node1";
            treeNode1027.Text = "Add and Multiply methods bug fixed";
            treeNode1028.Name = "Node2";
            treeNode1028.Text = "Image statistics combined into one method";
            treeNode1029.Name = "Node3";
            treeNode1029.Text = "Histogram method added";
            treeNode1030.Name = "Node0";
            treeNode1030.Text = "LDImage";
            treeNode1031.Name = "Node0";
            treeNode1031.Text = "Version 1.0.0.29";
            treeNode1032.Name = "Node1";
            treeNode1032.Text = "SnapshotToImageList method added";
            treeNode1033.Name = "Node0";
            treeNode1033.Text = "LDWebCam";
            treeNode1034.Name = "Node3";
            treeNode1034.Text = "ImageList image manipulation methods";
            treeNode1035.Name = "Node2";
            treeNode1035.Text = "LDImage";
            treeNode1036.Name = "Node0";
            treeNode1036.Text = "Version 1.0.0.28";
            treeNode1037.Name = "Node1";
            treeNode1037.Text = "SortIndex bugfix for null values";
            treeNode1038.Name = "Node0";
            treeNode1038.Text = "LDArray";
            treeNode1039.Name = "Node1";
            treeNode1039.Text = "SnapshotToFile bug fixed";
            treeNode1040.Name = "Node0";
            treeNode1040.Text = "LDWebCam";
            treeNode1041.Name = "Node0";
            treeNode1041.Text = "Version 1.0.0.27";
            treeNode1042.Name = "Node1";
            treeNode1042.Text = "SortIndex method added";
            treeNode1043.Name = "Node0";
            treeNode1043.Text = "LDArray";
            treeNode1044.Name = "Node1";
            treeNode1044.Text = "Web based weather report data added";
            treeNode1045.Name = "Node0";
            treeNode1045.Text = "LDWeather";
            treeNode1046.Name = "Node3";
            treeNode1046.Text = "DataReceived event added";
            treeNode1047.Name = "Node2";
            treeNode1047.Text = "LDCommPort";
            treeNode1048.Name = "Node0";
            treeNode1048.Text = "Version 1.0.0.26";
            treeNode1049.Name = "Node1";
            treeNode1049.Text = "Speech recognition added";
            treeNode1050.Name = "Node0";
            treeNode1050.Text = "LDSpeech";
            treeNode1051.Name = "Node0";
            treeNode1051.Text = "Version 1.0.0.25";
            treeNode1052.Name = "Node4";
            treeNode1052.Text = "More methods added and some internal code optimised";
            treeNode1053.Name = "Node0";
            treeNode1053.Text = "LDArray & LDMatrix";
            treeNode1054.Name = "Node1";
            treeNode1054.Text = "KeyDown method added";
            treeNode1055.Name = "Node0";
            treeNode1055.Text = "LDUtilities";
            treeNode1056.Name = "Node1";
            treeNode1056.Text = "GetAllShapesAt method added";
            treeNode1057.Name = "Node0";
            treeNode1057.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode1058.Name = "Node0";
            treeNode1058.Text = "LDShapes";
            treeNode1059.Name = "Node0";
            treeNode1059.Text = "Version 1.0.0.24";
            treeNode1060.Name = "Node1";
            treeNode1060.Text = "OpenFile and SaveFile dialogs added";
            treeNode1061.Name = "Node0";
            treeNode1061.Text = "LDDialogs";
            treeNode1062.Name = "Node2";
            treeNode1062.Text = "Matrix methods, for example to solve linear equations";
            treeNode1063.Name = "Node1";
            treeNode1063.Text = "LDMatrix";
            treeNode1064.Name = "Node0";
            treeNode1064.Text = "Version 1.0.0.23";
            treeNode1065.Name = "Node1";
            treeNode1065.Text = "Sorting method added";
            treeNode1066.Name = "Node0";
            treeNode1066.Text = "LDArray";
            treeNode1067.Name = "Node0";
            treeNode1067.Text = "Version 1.0.0.22";
            treeNode1068.Name = "Node2";
            treeNode1068.Text = "Velocity Threshold setting added";
            treeNode1069.Name = "Node1";
            treeNode1069.Text = "LDPhysics";
            treeNode1070.Name = "Node0";
            treeNode1070.Text = "Version 1.0.0.21";
            treeNode1071.Name = "Node3";
            treeNode1071.Text = "SetDamping method added";
            treeNode1072.Name = "Node2";
            treeNode1072.Text = "LDPhysics";
            treeNode1073.Name = "Node1";
            treeNode1073.Text = "Version 1.0.0.20";
            treeNode1074.Name = "Node1";
            treeNode1074.Text = "Instrument name can be obtained from its number";
            treeNode1075.Name = "Node0";
            treeNode1075.Text = "LDMusic";
            treeNode1076.Name = "Node0";
            treeNode1076.Text = "Version 1.0.0.19";
            treeNode1077.Name = "Node1";
            treeNode1077.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode1078.Name = "Node0";
            treeNode1078.Text = "LDDialogs";
            treeNode1079.Name = "Node1";
            treeNode1079.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode1080.Name = "Node2";
            treeNode1080.Text = "Notes can also be played synchronously (chords)";
            treeNode1081.Name = "Node0";
            treeNode1081.Text = "LDMusic";
            treeNode1082.Name = "Node0";
            treeNode1082.Text = "Version 1.0.0.18";
            treeNode1083.Name = "Node1";
            treeNode1083.Text = "AnimationPause and AnimationResume methods added";
            treeNode1084.Name = "Node0";
            treeNode1084.Text = "LDShapes";
            treeNode1085.Name = "Node1";
            treeNode1085.Text = "Process list indexed by ID rather than name";
            treeNode1086.Name = "Node0";
            treeNode1086.Text = "LDProcess";
            treeNode1087.Name = "Node1";
            treeNode1087.Text = "Version 1.0.0.17";
            treeNode1088.Name = "Node1";
            treeNode1088.Text = "More effects added";
            treeNode1089.Name = "Node0";
            treeNode1089.Text = "LDWebCam";
            treeNode1090.Name = "Node1";
            treeNode1090.Text = "Add or change an image on a button or image shape";
            treeNode1091.Name = "Node1";
            treeNode1091.Text = "Add an animated gif or tiled image";
            treeNode1092.Name = "Node0";
            treeNode1092.Text = "LDShapes";
            treeNode1093.Name = "Node0";
            treeNode1093.Text = "Version 1.0.0.16";
            treeNode1094.Name = "Node1";
            treeNode1094.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode1095.Name = "Node0";
            treeNode1095.Text = "LDWebCam";
            treeNode1096.Name = "Node0";
            treeNode1096.Text = "Version 1.0.0.15";
            treeNode1097.Name = "Node2";
            treeNode1097.Text = "Variables may be changed during a debug session";
            treeNode1098.Name = "Node1";
            treeNode1098.Text = "LDDebug";
            treeNode1099.Name = "Node0";
            treeNode1099.Text = "Version 1.0.0.14";
            treeNode1100.Name = "Node1";
            treeNode1100.Text = "A basic debugging tool";
            treeNode1101.Name = "Node0";
            treeNode1101.Text = "LDDebug";
            treeNode1102.Name = "Node0";
            treeNode1102.Text = "Version 1.0.0.13";
            treeNode1103.Name = "Node2";
            treeNode1103.Text = "Methods to convert between HSL and RGB";
            treeNode1104.Name = "Node18";
            treeNode1104.Text = "Method to set colour opacity";
            treeNode1105.Name = "Node19";
            treeNode1105.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode1106.Name = "Node1";
            treeNode1106.Text = "LDColours";
            treeNode1107.Name = "Node4";
            treeNode1107.Text = "Methods to add and subtract dates and times";
            treeNode1108.Name = "Node3";
            treeNode1108.Text = "LDDateTime";
            treeNode1109.Name = "Node6";
            treeNode1109.Text = "Waiting overlay, Calendar and About popups";
            treeNode1110.Name = "Node17";
            treeNode1110.Text = "Tooltips";
            treeNode1111.Name = "Node5";
            treeNode1111.Text = "LDDialogs";
            treeNode1112.Name = "Node8";
            treeNode1112.Text = "File change event";
            treeNode1113.Name = "Node7";
            treeNode1113.Text = "LDEvents";
            treeNode1114.Name = "Node0";
            treeNode1114.Text = "Version 1.0.0.12";
            treeNode1115.Name = "Node12";
            treeNode1115.Text = "Methods to sort arrays by index or value";
            treeNode1116.Name = "Node22";
            treeNode1116.Text = "Sorting by number and character strings";
            treeNode1117.Name = "Node11";
            treeNode1117.Text = "LDSort";
            treeNode1118.Name = "Node14";
            treeNode1118.Text = "Statistics on any array and distribution generation";
            treeNode1119.Name = "Node20";
            treeNode1119.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode1120.Name = "Node21";
            treeNode1120.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode1121.Name = "Node13";
            treeNode1121.Text = "LDStatistics";
            treeNode1122.Name = "Node16";
            treeNode1122.Text = "Voice and volume added";
            treeNode1123.Name = "Node15";
            treeNode1123.Text = "LDSpeech";
            treeNode1124.Name = "Node9";
            treeNode1124.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode17,
            treeNode38,
            treeNode60,
            treeNode73,
            treeNode81,
            treeNode83,
            treeNode96,
            treeNode109,
            treeNode121,
            treeNode128,
            treeNode138,
            treeNode141,
            treeNode160,
            treeNode177,
            treeNode191,
            treeNode219,
            treeNode233,
            treeNode244,
            treeNode259,
            treeNode274,
            treeNode287,
            treeNode296,
            treeNode311,
            treeNode322,
            treeNode336,
            treeNode345,
            treeNode357,
            treeNode368,
            treeNode371,
            treeNode380,
            treeNode387,
            treeNode394,
            treeNode407,
            treeNode418,
            treeNode423,
            treeNode430,
            treeNode433,
            treeNode447,
            treeNode455,
            treeNode461,
            treeNode476,
            treeNode491,
            treeNode497,
            treeNode505,
            treeNode520,
            treeNode537,
            treeNode540,
            treeNode546,
            treeNode552,
            treeNode562,
            treeNode571,
            treeNode574,
            treeNode594,
            treeNode600,
            treeNode603,
            treeNode612,
            treeNode620,
            treeNode626,
            treeNode631,
            treeNode637,
            treeNode640,
            treeNode653,
            treeNode656,
            treeNode661,
            treeNode666,
            treeNode669,
            treeNode675,
            treeNode679,
            treeNode682,
            treeNode688,
            treeNode692,
            treeNode700,
            treeNode706,
            treeNode712,
            treeNode715,
            treeNode722,
            treeNode729,
            treeNode737,
            treeNode740,
            treeNode743,
            treeNode749,
            treeNode754,
            treeNode761,
            treeNode766,
            treeNode772,
            treeNode775,
            treeNode782,
            treeNode787,
            treeNode791,
            treeNode804,
            treeNode812,
            treeNode817,
            treeNode823,
            treeNode826,
            treeNode833,
            treeNode836,
            treeNode844,
            treeNode847,
            treeNode850,
            treeNode854,
            treeNode858,
            treeNode861,
            treeNode864,
            treeNode867,
            treeNode870,
            treeNode873,
            treeNode876,
            treeNode879,
            treeNode883,
            treeNode886,
            treeNode889,
            treeNode892,
            treeNode900,
            treeNode902,
            treeNode908,
            treeNode914,
            treeNode919,
            treeNode924,
            treeNode927,
            treeNode930,
            treeNode933,
            treeNode936,
            treeNode942,
            treeNode945,
            treeNode948,
            treeNode951,
            treeNode960,
            treeNode963,
            treeNode966,
            treeNode970,
            treeNode979,
            treeNode985,
            treeNode990,
            treeNode999,
            treeNode1002,
            treeNode1005,
            treeNode1010,
            treeNode1015,
            treeNode1018,
            treeNode1021,
            treeNode1024,
            treeNode1031,
            treeNode1036,
            treeNode1041,
            treeNode1048,
            treeNode1051,
            treeNode1059,
            treeNode1064,
            treeNode1067,
            treeNode1070,
            treeNode1073,
            treeNode1076,
            treeNode1082,
            treeNode1087,
            treeNode1093,
            treeNode1096,
            treeNode1099,
            treeNode1102,
            treeNode1114,
            treeNode1124});
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