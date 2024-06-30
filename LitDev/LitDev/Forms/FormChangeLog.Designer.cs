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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("GetCollisions returns chain/rope name");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("GetAcceleration method added");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fix for chains and ropes with non default scaling");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables modified to handle LF,CR");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Version 1.2.29.0", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Increase default AABB for larger display");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
        "");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Exit event added");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("DataViewFont method added");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("CallIncludeWithVars method added");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("GetOriginPosition method added");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Allow longer duration animations");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("LoadModel ignore bad objects");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("GetOffset method added");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("WSAD keys for AutoControl only active if GW active");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Query updated to be similar to LDControls method");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Improved so that listview can use LDControls methods");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("CreateSpline and InterpolateSpline methods added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("MathX", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Version 1.2.28.0", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode14,
            treeNode16,
            treeNode22,
            treeNode25,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("RichTextBoxWord method extended");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("TextBoxSelection method added");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("RichTextBoxSelectionChanged event added");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("RichLastTextBoxSelection property added");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("RichTextBoxMousePosition method added");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("RichTextBoxCaretPosition method added");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("RichTextBoxCaretCoordinates method added");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("RichTextBoxWholeWord property added");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("RichTextBoxInsert method added");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("GetAllShapesAt updated to handle RTB");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Compiler property added");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("GW and TW aliases added");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Aliases", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("LF, CR, SQ, DQ, BS special characters added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("InputBox method added");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("TurtleSpeed property added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Version 1.2.27.0", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode41,
            treeNode43,
            treeNode45,
            treeNode47,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Update API");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("LoadImage replacement for Imagelist method that can download Flickr images");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Update HelixToolkit");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
        "ial methods added");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("AddBackImage bug fixed");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Performance improvement for \'sleeping\' shapes");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Updated intellisense");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Version 1.2.26.0", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode54,
            treeNode58,
            treeNode60,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Network Security Protocol fixes (SSL)");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("SetSSL method added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("FixFlickr updates for new api key");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Separate download required");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("SmallVisualBasic (sVB) support", new System.Windows.Forms.TreeNode[] {
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Version 1.2.25.0", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode66,
            treeNode68,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Reinstated website");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("API updated to MS Cognitive");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("CaptureScreen method added");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Fix for ListFiles");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("WriteFromArray method added");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Object added (code by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Suppress javascript popup error messages");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Version 1.2.23.0", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode77,
            treeNode79,
            treeNode81,
            treeNode83,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("SaveTableBySQL method added");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Object added by Abhishek Sathiabalan");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode89});
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode88,
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("LDHashTable object added (code from Abhishek Sathiabalan)", new System.Windows.Forms.TreeNode[] {
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Some Nuget packages used (suggested by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Various performance improvements (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("LDGeography (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("AvailableCultures method added");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("FixFlickr updated for API change");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Version 1.2.22.0", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("GetImage method improved to fix thread issue");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("ReadByteArray and WriteByteArray methods added");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("RenameRoot method added");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("View method added");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDXML", new System.Windows.Forms.TreeNode[] {
            treeNode104,
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Update to Azure");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Version 1.2.21.0", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode103,
            treeNode106,
            treeNode108,
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Correctly handles pie segments greater than 180 degrees");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Decimal2Base works for number 0 in all bases");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode114});
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Updated currency API");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Version 1.2.20.0", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode115,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Fix for ReSize for some controls");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Fix for GetLeft and GetTop for shapes that have not been positioned yet");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("AddPyramid shape fixed");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("New object to create icons and cursors added");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDIcon", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Fix for View (non-modal)");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Version 1.2.19.0", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode123,
            treeNode125,
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("SetBackMaterial and AddBackImage methods added");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("Version 1.2.18.0", new System.Windows.Forms.TreeNode[] {
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Fast text appending method added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Volume method added");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Modified to use Google API since MS version is depreciated");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("FloodFillTolerance property added");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("And and Or renamed And_ and Or_");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("SendClick method added");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Version 1.2.17.0", new System.Windows.Forms.TreeNode[] {
            treeNode133,
            treeNode135,
            treeNode137,
            treeNode139,
            treeNode141,
            treeNode143,
            treeNode145,
            treeNode147,
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("SHA512HashFile method added");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("Broadcast method added");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("LDServer", new System.Windows.Forms.TreeNode[] {
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("AutoControl2 scene camera mode added (for model inspection)");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("Various auto control improvements");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("SwapUpDirection method added");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode155,
            treeNode156,
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Improved PauseUpdates and ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("LDGraphicsWIndow", new System.Windows.Forms.TreeNode[] {
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("3D vector algebra methods added");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("LDVector", new System.Windows.Forms.TreeNode[] {
            treeNode161});
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LastListViewColumn event property added");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("ListView subscribes to LDControls selection events");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode165});
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Version 1.2.16.0", new System.Windows.Forms.TreeNode[] {
            treeNode152,
            treeNode154,
            treeNode158,
            treeNode160,
            treeNode162,
            treeNode164,
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Read and Write methods extended to read and write unindexed lines for 1D arrays");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("Animate method added");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("Fix for indent tab for non-paragraph rtf blocks");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("ResetMaterial method added");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("GetPosition method added");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("RSA public private key methods added");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode169,
            treeNode171,
            treeNode173,
            treeNode175,
            treeNode178,
            treeNode180});
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode188,
            treeNode189,
            treeNode190,
            treeNode191,
            treeNode192,
            treeNode193,
            treeNode194,
            treeNode195,
            treeNode196,
            treeNode197});
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode199,
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode202,
            treeNode203,
            treeNode204,
            treeNode205});
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode183,
            treeNode185,
            treeNode187,
            treeNode198,
            treeNode201,
            treeNode206,
            treeNode208});
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode214,
            treeNode215,
            treeNode216,
            treeNode217,
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode220,
            treeNode221});
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode211,
            treeNode213,
            treeNode219,
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode232});
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode225,
            treeNode227,
            treeNode229,
            treeNode231,
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode240,
            treeNode241,
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode244});
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode237,
            treeNode239,
            treeNode243,
            treeNode245,
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode250});
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode252,
            treeNode253,
            treeNode254,
            treeNode255,
            treeNode256,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode261,
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode251,
            treeNode258,
            treeNode260,
            treeNode263});
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode267});
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode269});
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode271,
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode274,
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode266,
            treeNode268,
            treeNode270,
            treeNode273,
            treeNode276});
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode280});
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode282});
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode279,
            treeNode281,
            treeNode283,
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode289,
            treeNode290});
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode292});
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode294,
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode291,
            treeNode293,
            treeNode296,
            treeNode298,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode304,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode303,
            treeNode306,
            treeNode308,
            treeNode311});
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode313,
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode318});
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode322});
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode315,
            treeNode317,
            treeNode319,
            treeNode321,
            treeNode323,
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode327,
            treeNode328,
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode330,
            treeNode332,
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode338});
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode340,
            treeNode341,
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode344,
            treeNode345});
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode337,
            treeNode339,
            treeNode343,
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode350});
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode349,
            treeNode351,
            treeNode353,
            treeNode355,
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode362});
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode364});
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode363,
            treeNode365,
            treeNode367,
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode372,
            treeNode374,
            treeNode376});
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode379,
            treeNode381,
            treeNode383});
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode385,
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode388,
            treeNode389,
            treeNode390,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode393});
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode395});
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode387,
            treeNode392,
            treeNode394,
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode399,
            treeNode401,
            treeNode403,
            treeNode405,
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode410,
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode415,
            treeNode417,
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode422});
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode424,
            treeNode425,
            treeNode426,
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode429,
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode432,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode435});
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode428,
            treeNode431,
            treeNode434,
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode438,
            treeNode439});
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode441});
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode440,
            treeNode442,
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode446,
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode449});
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode448,
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode452,
            treeNode453,
            treeNode454,
            treeNode455,
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode458,
            treeNode459,
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode464});
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode457,
            treeNode461,
            treeNode463,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode473});
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode475});
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode468,
            treeNode470,
            treeNode472,
            treeNode474,
            treeNode476,
            treeNode478,
            treeNode480});
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode482,
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode484,
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode490,
            treeNode491,
            treeNode492,
            treeNode493});
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode489,
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode496});
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode498,
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode501,
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode497,
            treeNode500,
            treeNode503,
            treeNode505,
            treeNode507,
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode511,
            treeNode512});
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode518,
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode513,
            treeNode515,
            treeNode517,
            treeNode520,
            treeNode522,
            treeNode524,
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode531,
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode533,
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode537,
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode539,
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode543,
            treeNode544,
            treeNode545,
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode547,
            treeNode549,
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode557});
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode554,
            treeNode556,
            treeNode558,
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode563});
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode565,
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode568,
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode573,
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode580});
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode567,
            treeNode570,
            treeNode572,
            treeNode575,
            treeNode577,
            treeNode579,
            treeNode581,
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode585,
            treeNode586});
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode587,
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode594});
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode596});
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode598,
            treeNode599,
            treeNode600});
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode595,
            treeNode597,
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode605,
            treeNode606});
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode608});
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode604,
            treeNode607,
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode613,
            treeNode614});
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode612,
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode617});
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode618,
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode622});
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode624,
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode623,
            treeNode626});
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode628});
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode631,
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode634});
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode640,
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode633,
            treeNode635,
            treeNode637,
            treeNode639,
            treeNode642});
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode648,
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode653,
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode660,
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode662,
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode666,
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode673,
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode675,
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode679,
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode681});
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode687,
            treeNode688});
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode684,
            treeNode686,
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode691});
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode693,
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode692,
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode697,
            treeNode698,
            treeNode699,
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode707,
            treeNode709,
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode714,
            treeNode716,
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode724,
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode721,
            treeNode723,
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode736,
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode735,
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode740,
            treeNode741,
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode746,
            treeNode748,
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode754});
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode753,
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode759,
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode758,
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode768});
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode767,
            treeNode769,
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode774,
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode778,
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode791,
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode782,
            treeNode784,
            treeNode786,
            treeNode788,
            treeNode790,
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode795,
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode800});
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode797,
            treeNode799,
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode804,
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode808,
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode810,
            treeNode812});
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode819,
            treeNode820,
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode818,
            treeNode822});
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode829,
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode828,
            treeNode831,
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode839});
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode841,
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode845,
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode849});
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode870,
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode875});
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode878});
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode883,
            treeNode885,
            treeNode887,
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode891});
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode893,
            treeNode894});
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode895,
            treeNode897});
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode900});
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode902});
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode899,
            treeNode901,
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode907});
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode906,
            treeNode908});
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode911,
            treeNode913});
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode915});
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode916});
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode919});
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode921});
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode922});
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode924});
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode925});
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode927,
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode930});
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode929,
            treeNode931});
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode933});
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode934});
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode937 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode936});
            System.Windows.Forms.TreeNode treeNode938 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode937});
            System.Windows.Forms.TreeNode treeNode939 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode940 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode939});
            System.Windows.Forms.TreeNode treeNode941 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode940});
            System.Windows.Forms.TreeNode treeNode942 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode943 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode944 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode942,
            treeNode943});
            System.Windows.Forms.TreeNode treeNode945 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode946 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode945});
            System.Windows.Forms.TreeNode treeNode947 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode948 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode949 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode947,
            treeNode948});
            System.Windows.Forms.TreeNode treeNode950 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode944,
            treeNode946,
            treeNode949});
            System.Windows.Forms.TreeNode treeNode951 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode952 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode951});
            System.Windows.Forms.TreeNode treeNode953 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode952});
            System.Windows.Forms.TreeNode treeNode954 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode955 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode954});
            System.Windows.Forms.TreeNode treeNode956 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode955});
            System.Windows.Forms.TreeNode treeNode957 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode958 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode959 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode957,
            treeNode958});
            System.Windows.Forms.TreeNode treeNode960 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode959});
            System.Windows.Forms.TreeNode treeNode961 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode962 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode963 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode964 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode961,
            treeNode962,
            treeNode963});
            System.Windows.Forms.TreeNode treeNode965 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode966 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode965});
            System.Windows.Forms.TreeNode treeNode967 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode968 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode967});
            System.Windows.Forms.TreeNode treeNode969 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode964,
            treeNode966,
            treeNode968});
            System.Windows.Forms.TreeNode treeNode970 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode971 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode972 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode970,
            treeNode971});
            System.Windows.Forms.TreeNode treeNode973 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode974 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode973});
            System.Windows.Forms.TreeNode treeNode975 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode972,
            treeNode974});
            System.Windows.Forms.TreeNode treeNode976 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode977 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode976});
            System.Windows.Forms.TreeNode treeNode978 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode979 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode978});
            System.Windows.Forms.TreeNode treeNode980 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode977,
            treeNode979});
            System.Windows.Forms.TreeNode treeNode981 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode982 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode981});
            System.Windows.Forms.TreeNode treeNode983 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode984 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode983});
            System.Windows.Forms.TreeNode treeNode985 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode986 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode985});
            System.Windows.Forms.TreeNode treeNode987 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode988 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode987});
            System.Windows.Forms.TreeNode treeNode989 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode982,
            treeNode984,
            treeNode986,
            treeNode988});
            System.Windows.Forms.TreeNode treeNode990 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode991 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode990});
            System.Windows.Forms.TreeNode treeNode992 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode991});
            System.Windows.Forms.TreeNode treeNode993 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode994 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode993});
            System.Windows.Forms.TreeNode treeNode995 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode994});
            System.Windows.Forms.TreeNode treeNode996 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode997 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode996});
            System.Windows.Forms.TreeNode treeNode998 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode999 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode998});
            System.Windows.Forms.TreeNode treeNode1000 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode997,
            treeNode999});
            System.Windows.Forms.TreeNode treeNode1001 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode1002 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1001});
            System.Windows.Forms.TreeNode treeNode1003 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode1004 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1003});
            System.Windows.Forms.TreeNode treeNode1005 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode1002,
            treeNode1004});
            System.Windows.Forms.TreeNode treeNode1006 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode1007 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode1006});
            System.Windows.Forms.TreeNode treeNode1008 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode1007});
            System.Windows.Forms.TreeNode treeNode1009 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode1010 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1009});
            System.Windows.Forms.TreeNode treeNode1011 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode1010});
            System.Windows.Forms.TreeNode treeNode1012 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode1013 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1012});
            System.Windows.Forms.TreeNode treeNode1014 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode1013});
            System.Windows.Forms.TreeNode treeNode1015 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode1016 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode1015});
            System.Windows.Forms.TreeNode treeNode1017 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode1018 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode1019 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode1020 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1017,
            treeNode1018,
            treeNode1019});
            System.Windows.Forms.TreeNode treeNode1021 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode1016,
            treeNode1020});
            System.Windows.Forms.TreeNode treeNode1022 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode1023 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1022});
            System.Windows.Forms.TreeNode treeNode1024 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode1025 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1024});
            System.Windows.Forms.TreeNode treeNode1026 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode1023,
            treeNode1025});
            System.Windows.Forms.TreeNode treeNode1027 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode1028 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1027});
            System.Windows.Forms.TreeNode treeNode1029 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode1030 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1029});
            System.Windows.Forms.TreeNode treeNode1031 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode1028,
            treeNode1030});
            System.Windows.Forms.TreeNode treeNode1032 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode1033 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1032});
            System.Windows.Forms.TreeNode treeNode1034 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode1035 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode1034});
            System.Windows.Forms.TreeNode treeNode1036 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode1037 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode1036});
            System.Windows.Forms.TreeNode treeNode1038 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode1033,
            treeNode1035,
            treeNode1037});
            System.Windows.Forms.TreeNode treeNode1039 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode1040 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1039});
            System.Windows.Forms.TreeNode treeNode1041 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode1040});
            System.Windows.Forms.TreeNode treeNode1042 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode1043 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1042});
            System.Windows.Forms.TreeNode treeNode1044 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode1045 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1044});
            System.Windows.Forms.TreeNode treeNode1046 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode1047 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode1048 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1046,
            treeNode1047});
            System.Windows.Forms.TreeNode treeNode1049 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode1043,
            treeNode1045,
            treeNode1048});
            System.Windows.Forms.TreeNode treeNode1050 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode1051 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1050});
            System.Windows.Forms.TreeNode treeNode1052 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode1053 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1052});
            System.Windows.Forms.TreeNode treeNode1054 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode1051,
            treeNode1053});
            System.Windows.Forms.TreeNode treeNode1055 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode1056 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1055});
            System.Windows.Forms.TreeNode treeNode1057 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode1056});
            System.Windows.Forms.TreeNode treeNode1058 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode1059 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1058});
            System.Windows.Forms.TreeNode treeNode1060 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode1059});
            System.Windows.Forms.TreeNode treeNode1061 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode1062 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1061});
            System.Windows.Forms.TreeNode treeNode1063 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode1062});
            System.Windows.Forms.TreeNode treeNode1064 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode1065 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1064});
            System.Windows.Forms.TreeNode treeNode1066 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode1065});
            System.Windows.Forms.TreeNode treeNode1067 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode1068 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1067});
            System.Windows.Forms.TreeNode treeNode1069 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode1070 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode1071 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1069,
            treeNode1070});
            System.Windows.Forms.TreeNode treeNode1072 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode1068,
            treeNode1071});
            System.Windows.Forms.TreeNode treeNode1073 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode1074 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1073});
            System.Windows.Forms.TreeNode treeNode1075 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode1076 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1075});
            System.Windows.Forms.TreeNode treeNode1077 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode1074,
            treeNode1076});
            System.Windows.Forms.TreeNode treeNode1078 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode1079 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1078});
            System.Windows.Forms.TreeNode treeNode1080 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode1081 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode1082 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1080,
            treeNode1081});
            System.Windows.Forms.TreeNode treeNode1083 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode1079,
            treeNode1082});
            System.Windows.Forms.TreeNode treeNode1084 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode1085 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1084});
            System.Windows.Forms.TreeNode treeNode1086 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode1085});
            System.Windows.Forms.TreeNode treeNode1087 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode1088 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1087});
            System.Windows.Forms.TreeNode treeNode1089 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode1088});
            System.Windows.Forms.TreeNode treeNode1090 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode1091 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1090});
            System.Windows.Forms.TreeNode treeNode1092 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode1091});
            System.Windows.Forms.TreeNode treeNode1093 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode1094 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode1095 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode1096 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode1093,
            treeNode1094,
            treeNode1095});
            System.Windows.Forms.TreeNode treeNode1097 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode1098 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode1097});
            System.Windows.Forms.TreeNode treeNode1099 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode1100 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode1101 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1099,
            treeNode1100});
            System.Windows.Forms.TreeNode treeNode1102 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode1103 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode1102});
            System.Windows.Forms.TreeNode treeNode1104 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode1096,
            treeNode1098,
            treeNode1101,
            treeNode1103});
            System.Windows.Forms.TreeNode treeNode1105 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode1106 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode1107 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode1105,
            treeNode1106});
            System.Windows.Forms.TreeNode treeNode1108 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode1109 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode1110 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode1111 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode1108,
            treeNode1109,
            treeNode1110});
            System.Windows.Forms.TreeNode treeNode1112 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode1113 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1112});
            System.Windows.Forms.TreeNode treeNode1114 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode1107,
            treeNode1111,
            treeNode1113});
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
            treeNode1.Name = "Node1";
            treeNode1.Text = "GetCollisions returns chain/rope name";
            treeNode2.Name = "Node0";
            treeNode2.Text = "GetAcceleration method added";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Fix for chains and ropes with non default scaling";
            treeNode4.Name = "Node0";
            treeNode4.Text = "LDPhysics";
            treeNode5.Name = "Node1";
            treeNode5.Text = "SaveAllVariables and LoadAllVariables modified to handle LF,CR";
            treeNode6.Name = "Node0";
            treeNode6.Text = "LDFile";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Version 1.2.29.0";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Increase default AABB for larger display";
            treeNode9.Name = "Node1";
            treeNode9.Text = "LDPhysics";
            treeNode10.Name = "Node1";
            treeNode10.Text = "UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
    "";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Exit event added";
            treeNode12.Name = "Node0";
            treeNode12.Text = "LDTextWindow";
            treeNode13.Name = "Node1";
            treeNode13.Text = "DataViewFont method added";
            treeNode14.Name = "Node0";
            treeNode14.Text = "LDControls";
            treeNode15.Name = "Node1";
            treeNode15.Text = "CallIncludeWithVars method added";
            treeNode16.Name = "Node0";
            treeNode16.Text = "LDCall";
            treeNode17.Name = "Node0";
            treeNode17.Text = "GetOriginPosition method added";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Allow longer duration animations";
            treeNode19.Name = "Node1";
            treeNode19.Text = "LoadModel ignore bad objects";
            treeNode20.Name = "Node0";
            treeNode20.Text = "GetOffset method added";
            treeNode21.Name = "Node0";
            treeNode21.Text = "WSAD keys for AutoControl only active if GW active";
            treeNode22.Name = "Node0";
            treeNode22.Text = "LD3DView";
            treeNode23.Name = "Node1";
            treeNode23.Text = "Query updated to be similar to LDControls method";
            treeNode24.Name = "Node2";
            treeNode24.Text = "Improved so that listview can use LDControls methods";
            treeNode25.Name = "Node0";
            treeNode25.Text = "LDDataBase";
            treeNode26.Name = "Node1";
            treeNode26.Text = "CreateSpline and InterpolateSpline methods added";
            treeNode27.Name = "Node0";
            treeNode27.Text = "MathX";
            treeNode28.Name = "Node0";
            treeNode28.Text = "Version 1.2.28.0";
            treeNode29.Name = "Node3";
            treeNode29.Text = "RichTextBoxWord method extended";
            treeNode30.Name = "Node4";
            treeNode30.Text = "TextBoxSelection method added";
            treeNode31.Name = "Node0";
            treeNode31.Text = "RichTextBoxSelectionChanged event added";
            treeNode32.Name = "Node1";
            treeNode32.Text = "RichLastTextBoxSelection property added";
            treeNode33.Name = "Node0";
            treeNode33.Text = "RichTextBoxMousePosition method added";
            treeNode34.Name = "Node0";
            treeNode34.Text = "RichTextBoxCaretPosition method added";
            treeNode35.Name = "Node0";
            treeNode35.Text = "RichTextBoxCaretCoordinates method added";
            treeNode36.Name = "Node0";
            treeNode36.Text = "RichTextBoxWholeWord property added";
            treeNode37.Name = "Node1";
            treeNode37.Text = "RichTextBoxInsert method added";
            treeNode38.Name = "Node0";
            treeNode38.Text = "GetAllShapesAt updated to handle RTB";
            treeNode39.Name = "Node0";
            treeNode39.Text = "LDControls";
            treeNode40.Name = "Node1";
            treeNode40.Text = "Compiler property added";
            treeNode41.Name = "Node0";
            treeNode41.Text = "LDCall";
            treeNode42.Name = "Node1";
            treeNode42.Text = "GW and TW aliases added";
            treeNode43.Name = "Node0";
            treeNode43.Text = "Aliases";
            treeNode44.Name = "Node1";
            treeNode44.Text = "LF, CR, SQ, DQ, BS special characters added";
            treeNode45.Name = "Node0";
            treeNode45.Text = "LDText";
            treeNode46.Name = "Node1";
            treeNode46.Text = "InputBox method added";
            treeNode47.Name = "Node0";
            treeNode47.Text = "LDDialogs";
            treeNode48.Name = "Node1";
            treeNode48.Text = "TurtleSpeed property added";
            treeNode49.Name = "Node0";
            treeNode49.Text = "LDShapes";
            treeNode50.Name = "Node2";
            treeNode50.Text = "Version 1.2.27.0";
            treeNode51.Name = "Node1";
            treeNode51.Text = "Update API";
            treeNode52.Name = "Node0";
            treeNode52.Text = "LDTranslate";
            treeNode53.Name = "Node1";
            treeNode53.Text = "LoadImage replacement for Imagelist method that can download Flickr images";
            treeNode54.Name = "Node0";
            treeNode54.Text = "LDImage";
            treeNode55.Name = "Node1";
            treeNode55.Text = "Update HelixToolkit";
            treeNode56.Name = "Node2";
            treeNode56.Text = "AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
    "ial methods added";
            treeNode57.Name = "Node0";
            treeNode57.Text = "AddBackImage bug fixed";
            treeNode58.Name = "Node0";
            treeNode58.Text = "LD3DView";
            treeNode59.Name = "Node1";
            treeNode59.Text = "Performance improvement for \'sleeping\' shapes";
            treeNode60.Name = "Node0";
            treeNode60.Text = "LDPhysics";
            treeNode61.Name = "Node1";
            treeNode61.Text = "Updated intellisense";
            treeNode62.Name = "Node0";
            treeNode62.Text = "LDFinances";
            treeNode63.Name = "Node0";
            treeNode63.Text = "Version 1.2.26.0";
            treeNode64.Name = "Node1";
            treeNode64.Text = "Network Security Protocol fixes (SSL)";
            treeNode65.Name = "Node3";
            treeNode65.Text = "SetSSL method added";
            treeNode66.Name = "Node2";
            treeNode66.Text = "LDNetwork";
            treeNode67.Name = "Node1";
            treeNode67.Text = "FixFlickr updates for new api key";
            treeNode68.Name = "Node0";
            treeNode68.Text = "LDUtilities";
            treeNode69.Name = "Node0";
            treeNode69.Text = "Separate download required";
            treeNode70.Name = "Node0";
            treeNode70.Text = "SmallVisualBasic (sVB) support";
            treeNode71.Name = "Node0";
            treeNode71.Text = "Version 1.2.25.0";
            treeNode72.Name = "Node1";
            treeNode72.Text = "Reinstated website";
            treeNode73.Name = "Node0";
            treeNode73.Text = "Version 1.2.24.0";
            treeNode74.Name = "Node2";
            treeNode74.Text = "API updated to MS Cognitive";
            treeNode75.Name = "Node1";
            treeNode75.Text = "LDTranslate";
            treeNode76.Name = "Node1";
            treeNode76.Text = "CaptureScreen method added";
            treeNode77.Name = "Node0";
            treeNode77.Text = "LDUtilities";
            treeNode78.Name = "Node1";
            treeNode78.Text = "Fix for ListFiles";
            treeNode79.Name = "Node0";
            treeNode79.Text = "LDftp";
            treeNode80.Name = "Node1";
            treeNode80.Text = "WriteFromArray method added";
            treeNode81.Name = "Node0";
            treeNode81.Text = "LDFile";
            treeNode82.Name = "Node1";
            treeNode82.Text = "Object added (code by Abhishek Sathiabalan)";
            treeNode83.Name = "Node0";
            treeNode83.Text = "LDFinances";
            treeNode84.Name = "Node1";
            treeNode84.Text = "Suppress javascript popup error messages";
            treeNode85.Name = "Node0";
            treeNode85.Text = "LDControls";
            treeNode86.Name = "Node0";
            treeNode86.Text = "Version 1.2.23.0";
            treeNode87.Name = "Node3";
            treeNode87.Text = "SaveTableBySQL method added";
            treeNode88.Name = "Node2";
            treeNode88.Text = "LDDataBase";
            treeNode89.Name = "Node1";
            treeNode89.Text = "Object added by Abhishek Sathiabalan";
            treeNode90.Name = "Node0";
            treeNode90.Text = "LDFinances";
            treeNode91.Name = "Node1";
            treeNode91.Text = "Version 1.2.24.0";
            treeNode92.Name = "Node1";
            treeNode92.Text = "LDHashTable object added (code from Abhishek Sathiabalan)";
            treeNode93.Name = "Node2";
            treeNode93.Text = "Some Nuget packages used (suggested by Abhishek Sathiabalan)";
            treeNode94.Name = "Node0";
            treeNode94.Text = "Various performance improvements (code from Abhishek Sathiabalan)";
            treeNode95.Name = "Node0";
            treeNode95.Text = "LDGeography (code from Abhishek Sathiabalan)";
            treeNode96.Name = "Node1";
            treeNode96.Text = "AvailableCultures method added";
            treeNode97.Name = "Node0";
            treeNode97.Text = "FixFlickr updated for API change";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LDUtilities";
            treeNode99.Name = "Node0";
            treeNode99.Text = "Version 1.2.22.0";
            treeNode100.Name = "Node2";
            treeNode100.Text = "GetImage method improved to fix thread issue";
            treeNode101.Name = "Node1";
            treeNode101.Text = "LDClipboard";
            treeNode102.Name = "Node1";
            treeNode102.Text = "ReadByteArray and WriteByteArray methods added";
            treeNode103.Name = "Node0";
            treeNode103.Text = "LDFile";
            treeNode104.Name = "Node1";
            treeNode104.Text = "RenameRoot method added";
            treeNode105.Name = "Node0";
            treeNode105.Text = "View method added";
            treeNode106.Name = "Node0";
            treeNode106.Text = "LDXML";
            treeNode107.Name = "Node1";
            treeNode107.Text = "Update to Azure";
            treeNode108.Name = "Node0";
            treeNode108.Text = "LDSearch";
            treeNode109.Name = "Node1";
            treeNode109.Text = "Volume and Pan properties added";
            treeNode110.Name = "Node0";
            treeNode110.Text = "LDMusic";
            treeNode111.Name = "Node0";
            treeNode111.Text = "Version 1.2.21.0";
            treeNode112.Name = "Node2";
            treeNode112.Text = "Correctly handles pie segments greater than 180 degrees";
            treeNode113.Name = "Node1";
            treeNode113.Text = "LDChart";
            treeNode114.Name = "Node1";
            treeNode114.Text = "Decimal2Base works for number 0 in all bases";
            treeNode115.Name = "Node0";
            treeNode115.Text = "LDMath";
            treeNode116.Name = "Node1";
            treeNode116.Text = "Updated currency API";
            treeNode117.Name = "Node0";
            treeNode117.Text = "LDUnits";
            treeNode118.Name = "Node0";
            treeNode118.Text = "Version 1.2.20.0";
            treeNode119.Name = "Node1";
            treeNode119.Text = "Fix for ReSize for some controls";
            treeNode120.Name = "Node2";
            treeNode120.Text = "Fix for GetLeft and GetTop for shapes that have not been positioned yet";
            treeNode121.Name = "Node0";
            treeNode121.Text = "LDShapes";
            treeNode122.Name = "Node4";
            treeNode122.Text = "AddPyramid shape fixed";
            treeNode123.Name = "Node3";
            treeNode123.Text = "LD3DView";
            treeNode124.Name = "Node3";
            treeNode124.Text = "New object to create icons and cursors added";
            treeNode125.Name = "Node2";
            treeNode125.Text = "LDIcon";
            treeNode126.Name = "Node1";
            treeNode126.Text = "Fix for View (non-modal)";
            treeNode127.Name = "Node0";
            treeNode127.Text = "LDMatrix";
            treeNode128.Name = "Node0";
            treeNode128.Text = "Version 1.2.19.0";
            treeNode129.Name = "Node1";
            treeNode129.Text = "SetBackMaterial and AddBackImage methods added";
            treeNode130.Name = "Node0";
            treeNode130.Text = "LD3DView";
            treeNode131.Name = "Node1";
            treeNode131.Text = "Version 1.2.18.0";
            treeNode132.Name = "Node2";
            treeNode132.Text = "Fast text appending method added";
            treeNode133.Name = "Node1";
            treeNode133.Text = "LDText";
            treeNode134.Name = "Node5";
            treeNode134.Text = "Potential performance improvements";
            treeNode135.Name = "Node4";
            treeNode135.Text = "LDFile";
            treeNode136.Name = "Node7";
            treeNode136.Text = "Potential performance improvements";
            treeNode137.Name = "Node6";
            treeNode137.Text = "LDDatabase";
            treeNode138.Name = "Node9";
            treeNode138.Text = "Potential performance improvements";
            treeNode139.Name = "Node8";
            treeNode139.Text = "LDArray";
            treeNode140.Name = "Node1";
            treeNode140.Text = "Volume method added";
            treeNode141.Name = "Node0";
            treeNode141.Text = "LDSound";
            treeNode142.Name = "Node1";
            treeNode142.Text = "Modified to use Google API since MS version is depreciated";
            treeNode143.Name = "Node0";
            treeNode143.Text = "LDTranslate";
            treeNode144.Name = "Node1";
            treeNode144.Text = "FloodFillTolerance property added";
            treeNode145.Name = "Node0";
            treeNode145.Text = "LDGraphicsWindow";
            treeNode146.Name = "Node1";
            treeNode146.Text = "And and Or renamed And_ and Or_";
            treeNode147.Name = "Node0";
            treeNode147.Text = "LDLogic";
            treeNode148.Name = "Node1";
            treeNode148.Text = "SendClick method added";
            treeNode149.Name = "Node0";
            treeNode149.Text = "LDUtilities";
            treeNode150.Name = "Node0";
            treeNode150.Text = "Version 1.2.17.0";
            treeNode151.Name = "Node2";
            treeNode151.Text = "SHA512HashFile method added";
            treeNode152.Name = "Node1";
            treeNode152.Text = "LDEncryption";
            treeNode153.Name = "Node1";
            treeNode153.Text = "Broadcast method added";
            treeNode154.Name = "Node0";
            treeNode154.Text = "LDServer";
            treeNode155.Name = "Node1";
            treeNode155.Text = "AutoControl2 scene camera mode added (for model inspection)";
            treeNode156.Name = "Node0";
            treeNode156.Text = "Various auto control improvements";
            treeNode157.Name = "Node7";
            treeNode157.Text = "SwapUpDirection method added";
            treeNode158.Name = "Node0";
            treeNode158.Text = "LD3DView";
            treeNode159.Name = "Node4";
            treeNode159.Text = "Improved PauseUpdates and ResumeUpdates";
            treeNode160.Name = "Node3";
            treeNode160.Text = "LDGraphicsWIndow";
            treeNode161.Name = "Node6";
            treeNode161.Text = "3D vector algebra methods added";
            treeNode162.Name = "Node5";
            treeNode162.Text = "LDVector";
            treeNode163.Name = "Node1";
            treeNode163.Text = "LastListViewColumn event property added";
            treeNode164.Name = "Node0";
            treeNode164.Text = "LDControls";
            treeNode165.Name = "Node3";
            treeNode165.Text = "ListView subscribes to LDControls selection events";
            treeNode166.Name = "Node2";
            treeNode166.Text = "LDDatabase";
            treeNode167.Name = "Node0";
            treeNode167.Text = "Version 1.2.16.0";
            treeNode168.Name = "Node1";
            treeNode168.Text = "Read and Write methods extended to read and write unindexed lines for 1D arrays";
            treeNode169.Name = "Node0";
            treeNode169.Text = "LDFastArray";
            treeNode170.Name = "Node3";
            treeNode170.Text = "Animate method added";
            treeNode171.Name = "Node2";
            treeNode171.Text = "LDGraphicsWindow";
            treeNode172.Name = "Node1";
            treeNode172.Text = "Fix for indent tab for non-paragraph rtf blocks";
            treeNode173.Name = "Node0";
            treeNode173.Text = "LDControls";
            treeNode174.Name = "Node3";
            treeNode174.Text = "Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated";
            treeNode175.Name = "Node2";
            treeNode175.Text = "LDTextWindow";
            treeNode176.Name = "Node1";
            treeNode176.Text = "ResetMaterial method added";
            treeNode177.Name = "Node2";
            treeNode177.Text = "GetPosition method added";
            treeNode178.Name = "Node0";
            treeNode178.Text = "LD3DView";
            treeNode179.Name = "Node1";
            treeNode179.Text = "RSA public private key methods added";
            treeNode180.Name = "Node0";
            treeNode180.Text = "LDEncryption";
            treeNode181.Name = "Node0";
            treeNode181.Text = "Version 1.2.15.0";
            treeNode182.Name = "Node2";
            treeNode182.Text = "Possible unclosed zip conflicts fixed";
            treeNode183.Name = "Node1";
            treeNode183.Text = "LDZip";
            treeNode184.Name = "Node5";
            treeNode184.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode185.Name = "Node3";
            treeNode185.Text = "LDStopwatch";
            treeNode186.Name = "Node7";
            treeNode186.Text = "LDTimer object added for additional timers";
            treeNode187.Name = "Node6";
            treeNode187.Text = "LDTimer";
            treeNode188.Name = "Node1";
            treeNode188.Text = "Speedup of selected critical performance code listed below";
            treeNode189.Name = "Node2";
            treeNode189.Text = "1) LDShapes.FastMove";
            treeNode190.Name = "Node3";
            treeNode190.Text = "2) LDPhysics graphical updates";
            treeNode191.Name = "Node4";
            treeNode191.Text = "3) LDImage and LDwebCam image processing";
            treeNode192.Name = "Node6";
            treeNode192.Text = "4) LDFastShapes";
            treeNode193.Name = "Node7";
            treeNode193.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode194.Name = "Node8";
            treeNode194.Text = "6) Selected LD3DView visual updates";
            treeNode195.Name = "Node9";
            treeNode195.Text = "7) LDEffect";
            treeNode196.Name = "Node10";
            treeNode196.Text = "8) LDGraph";
            treeNode197.Name = "Node11";
            treeNode197.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode198.Name = "Node0";
            treeNode198.Text = "General";
            treeNode199.Name = "Node1";
            treeNode199.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode200.Name = "Node2";
            treeNode200.Text = "CSV file read and write";
            treeNode201.Name = "Node0";
            treeNode201.Text = "LDFastArray";
            treeNode202.Name = "Node1";
            treeNode202.Text = "DataViewColAlignment method added";
            treeNode203.Name = "Node2";
            treeNode203.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode204.Name = "Node0";
            treeNode204.Text = "RichTextBoxTextTyped event added";
            treeNode205.Name = "Node1";
            treeNode205.Text = "RichTextBoxIndentToTab property added";
            treeNode206.Name = "Node0";
            treeNode206.Text = "LDControls";
            treeNode207.Name = "Node4";
            treeNode207.Text = "OverlapDetail property added";
            treeNode208.Name = "Node3";
            treeNode208.Text = "LDShapes";
            treeNode209.Name = "Node0";
            treeNode209.Text = "Version 1.2.14.0";
            treeNode210.Name = "Node2";
            treeNode210.Text = "TEMP tables allowed for SQLite databases";
            treeNode211.Name = "Node1";
            treeNode211.Text = "LDDataBase";
            treeNode212.Name = "Node1";
            treeNode212.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode213.Name = "Node0";
            treeNode213.Text = "LDMath";
            treeNode214.Name = "Node1";
            treeNode214.Text = "NormalMap method added for normal map 3D effects";
            treeNode215.Name = "Node2";
            treeNode215.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode216.Name = "Node5";
            treeNode216.Text = "MakeTransparent method added";
            treeNode217.Name = "Node6";
            treeNode217.Text = "ReplaceColour method added";
            treeNode218.Name = "Node0";
            treeNode218.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode219.Name = "Node0";
            treeNode219.Text = "LDImage";
            treeNode220.Name = "Node4";
            treeNode220.Text = "All image pixel manipulations speeded up";
            treeNode221.Name = "Node7";
            treeNode221.Text = "More Culture Invariace fixes";
            treeNode222.Name = "Node3";
            treeNode222.Text = "General";
            treeNode223.Name = "Node0";
            treeNode223.Text = "Version 1.2.13.0";
            treeNode224.Name = "Node1";
            treeNode224.Text = "Base conversions extended to include bases up to 36";
            treeNode225.Name = "Node0";
            treeNode225.Text = "LDMath";
            treeNode226.Name = "Node3";
            treeNode226.Text = "Updated to new Bing API";
            treeNode227.Name = "Node2";
            treeNode227.Text = "LDSearch";
            treeNode228.Name = "Node1";
            treeNode228.Text = "ShowInTaskbar property added";
            treeNode229.Name = "Node0";
            treeNode229.Text = "LDGraphicsWindow";
            treeNode230.Name = "Node1";
            treeNode230.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode231.Name = "Node0";
            treeNode231.Text = "LDFile";
            treeNode232.Name = "Node1";
            treeNode232.Text = "ToArray and FromArray methods added";
            treeNode233.Name = "Node0";
            treeNode233.Text = "LDxml";
            treeNode234.Name = "Node0";
            treeNode234.Text = "Version 1.2.12.0";
            treeNode235.Name = "Node2";
            treeNode235.Text = "DataViewColumnWidths method added";
            treeNode236.Name = "Node3";
            treeNode236.Text = "DataViewRowColours method added";
            treeNode237.Name = "Node1";
            treeNode237.Text = "LDControls";
            treeNode238.Name = "Node1";
            treeNode238.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode239.Name = "Node0";
            treeNode239.Text = "General";
            treeNode240.Name = "Node1";
            treeNode240.Text = "SetCentre method added";
            treeNode241.Name = "Node4";
            treeNode241.Text = "A 3rd rotation added";
            treeNode242.Name = "Node3";
            treeNode242.Text = "BoundingBox method added";
            treeNode243.Name = "Node0";
            treeNode243.Text = "LD3DView";
            treeNode244.Name = "Node3";
            treeNode244.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode245.Name = "Node2";
            treeNode245.Text = "LDDatabase";
            treeNode246.Name = "Node1";
            treeNode246.Text = "PlayMusic2 method added";
            treeNode247.Name = "Node2";
            treeNode247.Text = "Channel parameter added";
            treeNode248.Name = "Node0";
            treeNode248.Text = "LDMusic";
            treeNode249.Name = "Node0";
            treeNode249.Text = "Version 1.2.11.0";
            treeNode250.Name = "Node1";
            treeNode250.Text = "SetButtonStyle method added";
            treeNode251.Name = "Node0";
            treeNode251.Text = "LDControls";
            treeNode252.Name = "Node1";
            treeNode252.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode253.Name = "Node2";
            treeNode253.Text = "SetBillBoard method added";
            treeNode254.Name = "Node0";
            treeNode254.Text = "GetCameraUpDirection method added";
            treeNode255.Name = "Node1";
            treeNode255.Text = "Gradient brushes can be used";
            treeNode256.Name = "Node2";
            treeNode256.Text = "AutoControl method added";
            treeNode257.Name = "Node0";
            treeNode257.Text = "SpecularExponent property added";
            treeNode258.Name = "Node0";
            treeNode258.Text = "LD3DView";
            treeNode259.Name = "Node1";
            treeNode259.Text = "AddText method to annotate an image with text added";
            treeNode260.Name = "Node0";
            treeNode260.Text = "LDImage";
            treeNode261.Name = "Node4";
            treeNode261.Text = "BrushText for text on a brush added";
            treeNode262.Name = "Node0";
            treeNode262.Text = "Skew shapes method added";
            treeNode263.Name = "Node3";
            treeNode263.Text = "LDShapes";
            treeNode264.Name = "Node0";
            treeNode264.Text = "Version 1.2.10.0";
            treeNode265.Name = "Node1";
            treeNode265.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode266.Name = "Node0";
            treeNode266.Text = "LDUnits";
            treeNode267.Name = "Node1";
            treeNode267.Text = "Possible issue with FixSigFig fixed";
            treeNode268.Name = "Node0";
            treeNode268.Text = "LDMath";
            treeNode269.Name = "Node3";
            treeNode269.Text = "GetIndex method added (for SB arrays)";
            treeNode270.Name = "Node2";
            treeNode270.Text = "LDArray";
            treeNode271.Name = "Node5";
            treeNode271.Text = "Resize mode property added";
            treeNode272.Name = "Node6";
            treeNode272.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode273.Name = "Node4";
            treeNode273.Text = "LDGraphicsWindow";
            treeNode274.Name = "Node8";
            treeNode274.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode275.Name = "Node9";
            treeNode275.Text = "DataViewAllowUserEntry method added";
            treeNode276.Name = "Node7";
            treeNode276.Text = "LDControls";
            treeNode277.Name = "Node0";
            treeNode277.Text = "Version 1.2.9.0";
            treeNode278.Name = "Node1";
            treeNode278.Text = "New extended math object, starting with FFT";
            treeNode279.Name = "Node0";
            treeNode279.Text = "LDMathX";
            treeNode280.Name = "Node1";
            treeNode280.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode281.Name = "Node0";
            treeNode281.Text = "LDControls";
            treeNode282.Name = "Node3";
            treeNode282.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode283.Name = "Node2";
            treeNode283.Text = "LDArray";
            treeNode284.Name = "Node5";
            treeNode284.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode285.Name = "Node4";
            treeNode285.Text = "LDList";
            treeNode286.Name = "Node0";
            treeNode286.Text = "Version 1.2.8.0";
            treeNode287.Name = "Node2";
            treeNode287.Text = "Error handling, additional settings and multiple ports supported";
            treeNode288.Name = "Node1";
            treeNode288.Text = "LDCommPort";
            treeNode289.Name = "Node1";
            treeNode289.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode290.Name = "Node1";
            treeNode290.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode291.Name = "Node0";
            treeNode291.Text = "LDImage and LDWebCam";
            treeNode292.Name = "Node1";
            treeNode292.Text = "Bitwise operations object added";
            treeNode293.Name = "Node0";
            treeNode293.Text = "LDBits";
            treeNode294.Name = "Node1";
            treeNode294.Text = "Extended text encoding property added";
            treeNode295.Name = "Node0";
            treeNode295.Text = "TextWindow colours can be changed";
            treeNode296.Name = "Node0";
            treeNode296.Text = "LDTextWindow";
            treeNode297.Name = "Node1";
            treeNode297.Text = "GetWorkingImagePixelARGB method added";
            treeNode298.Name = "Node0";
            treeNode298.Text = "LDImage";
            treeNode299.Name = "Node1";
            treeNode299.Text = "RasteriseTurtleLines method added";
            treeNode300.Name = "Node0";
            treeNode300.Text = "LDShapes";
            treeNode301.Name = "Node0";
            treeNode301.Text = "Version 1.2.7.0";
            treeNode302.Name = "Node1";
            treeNode302.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode303.Name = "Node0";
            treeNode303.Text = "LDDialogs";
            treeNode304.Name = "Node1";
            treeNode304.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode305.Name = "Node2";
            treeNode305.Text = "ToggleSensor added";
            treeNode306.Name = "Node0";
            treeNode306.Text = "LDPhysics";
            treeNode307.Name = "Node1";
            treeNode307.Text = "Allow multiple copies of the webcam image";
            treeNode308.Name = "Node0";
            treeNode308.Text = "LDWebCam";
            treeNode309.Name = "Node1";
            treeNode309.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode310.Name = "Node0";
            treeNode310.Text = "MetaData method added";
            treeNode311.Name = "Node0";
            treeNode311.Text = "LDImage";
            treeNode312.Name = "Node0";
            treeNode312.Text = "Version 1.2.6.0";
            treeNode313.Name = "Node2";
            treeNode313.Text = "FixSigFig and FixDecimal methods added";
            treeNode314.Name = "Node3";
            treeNode314.Text = "MinNumber and MaxNumber properties added";
            treeNode315.Name = "Node1";
            treeNode315.Text = "LDMath";
            treeNode316.Name = "Node1";
            treeNode316.Text = "SliderMaximum property added";
            treeNode317.Name = "Node0";
            treeNode317.Text = "LDControls";
            treeNode318.Name = "Node1";
            treeNode318.Text = "ZoomAll method added";
            treeNode319.Name = "Node0";
            treeNode319.Text = "LDShapes";
            treeNode320.Name = "Node1";
            treeNode320.Text = "Reposition methods and properties added";
            treeNode321.Name = "Node0";
            treeNode321.Text = "LDGraphicsWindow";
            treeNode322.Name = "Node1";
            treeNode322.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode323.Name = "Node0";
            treeNode323.Text = "LDImage";
            treeNode324.Name = "Node1";
            treeNode324.Text = "MouseScroll parameter added";
            treeNode325.Name = "Node0";
            treeNode325.Text = "LDScrollBars";
            treeNode326.Name = "Node0";
            treeNode326.Text = "Version 1.2.5.0";
            treeNode327.Name = "Node0";
            treeNode327.Text = "New object added (previously a separate extension)";
            treeNode328.Name = "Node1";
            treeNode328.Text = "Async, Loop, Volume and Pan properties added";
            treeNode329.Name = "Node2";
            treeNode329.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode330.Name = "Node1";
            treeNode330.Text = "LDWaveForm";
            treeNode331.Name = "Node1";
            treeNode331.Text = "New object added to get input from gamepads or joysticks";
            treeNode332.Name = "Node0";
            treeNode332.Text = "LDController";
            treeNode333.Name = "Node1";
            treeNode333.Text = "RayCast method added";
            treeNode334.Name = "Node0";
            treeNode334.Text = "LDPhysics";
            treeNode335.Name = "Node0";
            treeNode335.Text = "Version 1.2.4.0";
            treeNode336.Name = "Node2";
            treeNode336.Text = "New object to apply effects to any shape or control";
            treeNode337.Name = "Node1";
            treeNode337.Text = "LDEffects";
            treeNode338.Name = "Node1";
            treeNode338.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode339.Name = "Node0";
            treeNode339.Text = "LDFigures";
            treeNode340.Name = "Node1";
            treeNode340.Text = "SetGroup method added";
            treeNode341.Name = "Node2";
            treeNode341.Text = "GetContacts method added";
            treeNode342.Name = "Node0";
            treeNode342.Text = "GetAllShapesAt method added";
            treeNode343.Name = "Node0";
            treeNode343.Text = "LDPhysics";
            treeNode344.Name = "Node2";
            treeNode344.Text = "SetImage handles images with transparency";
            treeNode345.Name = "Node0";
            treeNode345.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode346.Name = "Node1";
            treeNode346.Text = "LDClipboard";
            treeNode347.Name = "Node0";
            treeNode347.Text = "Version 1.2.3.0";
            treeNode348.Name = "Node2";
            treeNode348.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode349.Name = "Node1";
            treeNode349.Text = "LDShapes";
            treeNode350.Name = "Node4";
            treeNode350.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode351.Name = "Node3";
            treeNode351.Text = "LDFile";
            treeNode352.Name = "Node6";
            treeNode352.Text = "NewImage method added";
            treeNode353.Name = "Node5";
            treeNode353.Text = "LDImage";
            treeNode354.Name = "Node1";
            treeNode354.Text = "SetStartupPosition method added to position dialogs";
            treeNode355.Name = "Node0";
            treeNode355.Text = "LDDialogs";
            treeNode356.Name = "Node1";
            treeNode356.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode357.Name = "Node0";
            treeNode357.Text = "LDGraph";
            treeNode358.Name = "Node0";
            treeNode358.Text = "Version 1.2.2.0";
            treeNode359.Name = "Node2";
            treeNode359.Text = "Recompiled for Small Basic version 1.2";
            treeNode360.Name = "Node1";
            treeNode360.Text = "Version 1.2";
            treeNode361.Name = "Node0";
            treeNode361.Text = "Version 1.2.0.1";
            treeNode362.Name = "Node2";
            treeNode362.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode363.Name = "Node1";
            treeNode363.Text = "LDDialogs";
            treeNode364.Name = "Node1";
            treeNode364.Text = "Logical operations object added";
            treeNode365.Name = "Node0";
            treeNode365.Text = "LDLogic";
            treeNode366.Name = "Node4";
            treeNode366.Text = "CurrentCulture property added";
            treeNode367.Name = "Node3";
            treeNode367.Text = "LDUtilities";
            treeNode368.Name = "Node6";
            treeNode368.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode369.Name = "Node5";
            treeNode369.Text = "LDMath";
            treeNode370.Name = "Node0";
            treeNode370.Text = "Version 1.1.0.8";
            treeNode371.Name = "Node1";
            treeNode371.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode372.Name = "Node0";
            treeNode372.Text = "LDControls";
            treeNode373.Name = "Node1";
            treeNode373.Text = "Methods added to add and remove nodes and save xml file";
            treeNode374.Name = "Node0";
            treeNode374.Text = "LDxml";
            treeNode375.Name = "Node1";
            treeNode375.Text = "MusicPlayTime moved from LDFile";
            treeNode376.Name = "Node0";
            treeNode376.Text = "LDSound";
            treeNode377.Name = "Node0";
            treeNode377.Text = "Version 1.1.0.7";
            treeNode378.Name = "Node4";
            treeNode378.Text = "SplitImage method added";
            treeNode379.Name = "Node3";
            treeNode379.Text = "LDImage";
            treeNode380.Name = "Node6";
            treeNode380.Text = "EditTable and SaveTable methods added";
            treeNode381.Name = "Node5";
            treeNode381.Text = "LDDatabse";
            treeNode382.Name = "Node2";
            treeNode382.Text = "DataView control and methods added";
            treeNode383.Name = "Node1";
            treeNode383.Text = "LDControls";
            treeNode384.Name = "Node2";
            treeNode384.Text = "Version 1.1.0.6";
            treeNode385.Name = "Node2";
            treeNode385.Text = "Exists modified to check for directory as well as file";
            treeNode386.Name = "Node3";
            treeNode386.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode387.Name = "Node1";
            treeNode387.Text = "LDFile";
            treeNode388.Name = "Node5";
            treeNode388.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode389.Name = "Node6";
            treeNode389.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode390.Name = "Node9";
            treeNode390.Text = "Conditonal break point added";
            treeNode391.Name = "Node0";
            treeNode391.Text = "Step over button added";
            treeNode392.Name = "Node4";
            treeNode392.Text = "LDDebug";
            treeNode393.Name = "Node8";
            treeNode393.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode394.Name = "Node7";
            treeNode394.Text = "LDGraphicsWindow";
            treeNode395.Name = "Node1";
            treeNode395.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode396.Name = "Node0";
            treeNode396.Text = "LDResources";
            treeNode397.Name = "Node0";
            treeNode397.Text = "Version 1.1.0.5";
            treeNode398.Name = "Node2";
            treeNode398.Text = "ClipboardChanged event added";
            treeNode399.Name = "Node1";
            treeNode399.Text = "LDClipboard";
            treeNode400.Name = "Node1";
            treeNode400.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode401.Name = "Node0";
            treeNode401.Text = "LDFile";
            treeNode402.Name = "Node3";
            treeNode402.Text = "SetActive method added";
            treeNode403.Name = "Node2";
            treeNode403.Text = "LDGraphicsWindow";
            treeNode404.Name = "Node1";
            treeNode404.Text = "Parse xml file nodes";
            treeNode405.Name = "Node0";
            treeNode405.Text = "LDxml";
            treeNode406.Name = "Node3";
            treeNode406.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode407.Name = "Node2";
            treeNode407.Text = "General";
            treeNode408.Name = "Node0";
            treeNode408.Text = "Version 1.1.0.4";
            treeNode409.Name = "Node2";
            treeNode409.Text = "WakeAll method addded";
            treeNode410.Name = "Node1";
            treeNode410.Text = "LDPhysics";
            treeNode411.Name = "Node1";
            treeNode411.Text = "Clipboard methods added";
            treeNode412.Name = "Node0";
            treeNode412.Text = "LDClipboard";
            treeNode413.Name = "Node0";
            treeNode413.Text = "Version 1.1.0.3";
            treeNode414.Name = "Node6";
            treeNode414.Text = "SizeNWSE cursor added";
            treeNode415.Name = "Node5";
            treeNode415.Text = "LDCursors";
            treeNode416.Name = "Node8";
            treeNode416.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode417.Name = "Node7";
            treeNode417.Text = "LDGraph";
            treeNode418.Name = "Node1";
            treeNode418.Text = "SQLite updated for .Net 4.5";
            treeNode419.Name = "Node0";
            treeNode419.Text = "LDDataBase";
            treeNode420.Name = "Node4";
            treeNode420.Text = "Version 1.1.0.2";
            treeNode421.Name = "Node3";
            treeNode421.Text = "Recompiled for Small Basic version 1.1";
            treeNode422.Name = "Node2";
            treeNode422.Text = "Version 1.1";
            treeNode423.Name = "Node0";
            treeNode423.Text = "Version 1.1.0.1";
            treeNode424.Name = "Node12";
            treeNode424.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode425.Name = "Node13";
            treeNode425.Text = "RichTextBoxMargins method added";
            treeNode426.Name = "Node0";
            treeNode426.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode427.Name = "Node1";
            treeNode427.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode428.Name = "Node11";
            treeNode428.Text = "LDControls";
            treeNode429.Name = "Node3";
            treeNode429.Text = "Error reporting added";
            treeNode430.Name = "Node4";
            treeNode430.Text = "SetEncoding method added";
            treeNode431.Name = "Node2";
            treeNode431.Text = "LDCommPort";
            treeNode432.Name = "Node6";
            treeNode432.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode433.Name = "Node7";
            treeNode433.Text = "Export to excel fix for graph with no title";
            treeNode434.Name = "Node5";
            treeNode434.Text = "LDGraph";
            treeNode435.Name = "Node9";
            treeNode435.Text = "Negative restitution option when adding moving shape";
            treeNode436.Name = "Node8";
            treeNode436.Text = "LDPhysics";
            treeNode437.Name = "Node10";
            treeNode437.Text = "Version 1.0.0.133";
            treeNode438.Name = "Node2";
            treeNode438.Text = "Internal improvements to auto messaging";
            treeNode439.Name = "Node9";
            treeNode439.Text = "Name can be set and GetClients method added";
            treeNode440.Name = "Node1";
            treeNode440.Text = "LDClient";
            treeNode441.Name = "Node4";
            treeNode441.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode442.Name = "Node3";
            treeNode442.Text = "LDControls";
            treeNode443.Name = "Node8";
            treeNode443.Text = "Return message and possible file error fixed for Stop method";
            treeNode444.Name = "Node7";
            treeNode444.Text = "LDSound";
            treeNode445.Name = "Node0";
            treeNode445.Text = "Version 1.0.0.132";
            treeNode446.Name = "Node2";
            treeNode446.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode447.Name = "Node5";
            treeNode447.Text = "Compile method added to compile a Small Basic program";
            treeNode448.Name = "Node1";
            treeNode448.Text = "LDCall";
            treeNode449.Name = "Node4";
            treeNode449.Text = "Methods and code by Pappa Lapub added";
            treeNode450.Name = "Node3";
            treeNode450.Text = "LDShell";
            treeNode451.Name = "Node0";
            treeNode451.Text = "Version 1.0.0.131";
            treeNode452.Name = "Node6";
            treeNode452.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode453.Name = "Node7";
            treeNode453.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode454.Name = "Node8";
            treeNode454.Text = "Refactoring of all the pan, follow and box methods";
            treeNode455.Name = "Node6";
            treeNode455.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode456.Name = "Node8";
            treeNode456.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode457.Name = "Node5";
            treeNode457.Text = "LDPhysics";
            treeNode458.Name = "Node1";
            treeNode458.Text = "UseBinary property added";
            treeNode459.Name = "Node2";
            treeNode459.Text = "DoAsync property and associated completion events added";
            treeNode460.Name = "Node3";
            treeNode460.Text = "Delete method added";
            treeNode461.Name = "Node0";
            treeNode461.Text = "LDftp";
            treeNode462.Name = "Node5";
            treeNode462.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode463.Name = "Node4";
            treeNode463.Text = "LDCall";
            treeNode464.Name = "Node2";
            treeNode464.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode465.Name = "Node1";
            treeNode465.Text = "LDControls";
            treeNode466.Name = "Node4";
            treeNode466.Text = "Version 1.0.0.130";
            treeNode467.Name = "Node2";
            treeNode467.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode468.Name = "Node1";
            treeNode468.Text = "LDMath";
            treeNode469.Name = "Node1";
            treeNode469.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode470.Name = "Node0";
            treeNode470.Text = "LDPhysics";
            treeNode471.Name = "Node3";
            treeNode471.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode472.Name = "Node2";
            treeNode472.Text = "LDGraphicsWindow";
            treeNode473.Name = "Node1";
            treeNode473.Text = "FTP object methods added";
            treeNode474.Name = "Node0";
            treeNode474.Text = "LDftp";
            treeNode475.Name = "Node3";
            treeNode475.Text = "An existing file is replaced";
            treeNode476.Name = "Node2";
            treeNode476.Text = "LDZip";
            treeNode477.Name = "Node1";
            treeNode477.Text = "Size method added";
            treeNode478.Name = "Node0";
            treeNode478.Text = "LDFile";
            treeNode479.Name = "Node3";
            treeNode479.Text = "DownloadFile method added";
            treeNode480.Name = "Node2";
            treeNode480.Text = "LDNetwork";
            treeNode481.Name = "Node0";
            treeNode481.Text = "Version 1.0.0.129";
            treeNode482.Name = "Node2";
            treeNode482.Text = "Generalised joint connections added";
            treeNode483.Name = "Node0";
            treeNode483.Text = "AddExplosion method added";
            treeNode484.Name = "Node1";
            treeNode484.Text = "LDPhysics";
            treeNode485.Name = "Node1";
            treeNode485.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode486.Name = "Node0";
            treeNode486.Text = "LDShapes";
            treeNode487.Name = "Node0";
            treeNode487.Text = "Version 1.0.0.128";
            treeNode488.Name = "Node2";
            treeNode488.Text = "CheckServer method added";
            treeNode489.Name = "Node1";
            treeNode489.Text = "LDClient";
            treeNode490.Name = "Node1";
            treeNode490.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode491.Name = "Node2";
            treeNode491.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode492.Name = "Node3";
            treeNode492.Text = "GetAngle method added";
            treeNode493.Name = "Node4";
            treeNode493.Text = "Top-down tire (to model a car from above) methods added";
            treeNode494.Name = "Node0";
            treeNode494.Text = "LDPhysics";
            treeNode495.Name = "Node0";
            treeNode495.Text = "Version 1.0.0.127";
            treeNode496.Name = "Node7";
            treeNode496.Text = "Bug fixes for Overlap methods";
            treeNode497.Name = "Node6";
            treeNode497.Text = "LDShapes";
            treeNode498.Name = "Node0";
            treeNode498.Text = "Bug fix for multiple numeric sorts";
            treeNode499.Name = "Node9";
            treeNode499.Text = "ByValueWithIndex method added";
            treeNode500.Name = "Node8";
            treeNode500.Text = "LDSort";
            treeNode501.Name = "Node1";
            treeNode501.Text = "LAN method added to get local IP addresses";
            treeNode502.Name = "Node2";
            treeNode502.Text = "Ping method added";
            treeNode503.Name = "Node0";
            treeNode503.Text = "LDNetwork";
            treeNode504.Name = "Node1";
            treeNode504.Text = "LoadSVG method added";
            treeNode505.Name = "Node0";
            treeNode505.Text = "LDImage";
            treeNode506.Name = "Node3";
            treeNode506.Text = "Evaluate method added";
            treeNode507.Name = "Node2";
            treeNode507.Text = "LDMath";
            treeNode508.Name = "Node5";
            treeNode508.Text = "IncludeJScript method added";
            treeNode509.Name = "Node4";
            treeNode509.Text = "LDInline";
            treeNode510.Name = "Node5";
            treeNode510.Text = "Version 1.0.0.126";
            treeNode511.Name = "Node0";
            treeNode511.Text = "Special emphasis on async consistency";
            treeNode512.Name = "Node4";
            treeNode512.Text = "Simplified auto method for multi-player game data transfer";
            treeNode513.Name = "Node9";
            treeNode513.Text = "LDServer and LDClient objects added";
            treeNode514.Name = "Node2";
            treeNode514.Text = "GetWidth and GetHeight methods added";
            treeNode515.Name = "Node1";
            treeNode515.Text = "LDText";
            treeNode516.Name = "Node4";
            treeNode516.Text = "Bing web search";
            treeNode517.Name = "Node3";
            treeNode517.Text = "LDSearch";
            treeNode518.Name = "Node6";
            treeNode518.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode519.Name = "Node7";
            treeNode519.Text = "KeyScroll property added";
            treeNode520.Name = "Node5";
            treeNode520.Text = "LDScrollBars";
            treeNode521.Name = "Node9";
            treeNode521.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode522.Name = "Node8";
            treeNode522.Text = "LDShapes";
            treeNode523.Name = "Node1";
            treeNode523.Text = "SaveAs method bug fixed";
            treeNode524.Name = "Node0";
            treeNode524.Text = "LDImage";
            treeNode525.Name = "Node3";
            treeNode525.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode526.Name = "Node2";
            treeNode526.Text = "LDQueue";
            treeNode527.Name = "Node8";
            treeNode527.Text = "Version 1.0.0.125";
            treeNode528.Name = "Node7";
            treeNode528.Text = "Language translation object added";
            treeNode529.Name = "Node6";
            treeNode529.Text = "LDTranslate";
            treeNode530.Name = "Node5";
            treeNode530.Text = "Version 1.0.0.124";
            treeNode531.Name = "Node1";
            treeNode531.Text = "Mouse screen coordinate conversion parameters added";
            treeNode532.Name = "Node2";
            treeNode532.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode533.Name = "Node0";
            treeNode533.Text = "LDGraphicsWindow";
            treeNode534.Name = "Node4";
            treeNode534.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode535.Name = "Node3";
            treeNode535.Text = "LDUtilities";
            treeNode536.Name = "Node0";
            treeNode536.Text = "Version 1.0.0.123";
            treeNode537.Name = "Node5";
            treeNode537.Text = "ColorMatrix method added";
            treeNode538.Name = "Node0";
            treeNode538.Text = "Rotate method added";
            treeNode539.Name = "Node3";
            treeNode539.Text = "LDImage";
            treeNode540.Name = "Node1";
            treeNode540.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode541.Name = "Node0";
            treeNode541.Text = "LDChart";
            treeNode542.Name = "Node2";
            treeNode542.Text = "Version 1.0.0.122";
            treeNode543.Name = "Node2";
            treeNode543.Text = "EffectGamma added to darken and lighten";
            treeNode544.Name = "Node4";
            treeNode544.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode545.Name = "Node3";
            treeNode545.Text = "EffectContrast modified";
            treeNode546.Name = "Node0";
            treeNode546.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode547.Name = "Node1";
            treeNode547.Text = "LDImage";
            treeNode548.Name = "Node2";
            treeNode548.Text = "Error event added for all extension exceptions";
            treeNode549.Name = "Node1";
            treeNode549.Text = "LDEvents";
            treeNode550.Name = "Node1";
            treeNode550.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode551.Name = "Node0";
            treeNode551.Text = "LDMath";
            treeNode552.Name = "Node0";
            treeNode552.Text = "Version 1.0.0.121";
            treeNode553.Name = "Node2";
            treeNode553.Text = "FloodFill transparency effect fixed";
            treeNode554.Name = "Node1";
            treeNode554.Text = "LDGraphicsWindow";
            treeNode555.Name = "Node1";
            treeNode555.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode556.Name = "Node0";
            treeNode556.Text = "LDFile";
            treeNode557.Name = "Node1";
            treeNode557.Text = "EffectPixelate added";
            treeNode558.Name = "Node0";
            treeNode558.Text = "LDImage";
            treeNode559.Name = "Node1";
            treeNode559.Text = "Modified to work with Windows 8";
            treeNode560.Name = "Node0";
            treeNode560.Text = "LDWebCam";
            treeNode561.Name = "Node0";
            treeNode561.Text = "Version 1.0.0.120";
            treeNode562.Name = "Node2";
            treeNode562.Text = "FloodFill method added";
            treeNode563.Name = "Node1";
            treeNode563.Text = "LDGraphicsWindow";
            treeNode564.Name = "Node0";
            treeNode564.Text = "Version 1.0.0.119";
            treeNode565.Name = "Node0";
            treeNode565.Text = "SetShapeCursor method added";
            treeNode566.Name = "Node11";
            treeNode566.Text = "CreateCursor method added";
            treeNode567.Name = "Node9";
            treeNode567.Text = "LDCursors";
            treeNode568.Name = "Node2";
            treeNode568.Text = "SaveAs method to save in different file formats";
            treeNode569.Name = "Node0";
            treeNode569.Text = "Parameters added for some effects";
            treeNode570.Name = "Node1";
            treeNode570.Text = "LDImage";
            treeNode571.Name = "Node2";
            treeNode571.Text = "Parameters added for some effects";
            treeNode572.Name = "Node1";
            treeNode572.Text = "LDWebCam";
            treeNode573.Name = "Node1";
            treeNode573.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode574.Name = "Node0";
            treeNode574.Text = "SetFontFromFile method added for ttf fonts";
            treeNode575.Name = "Node0";
            treeNode575.Text = "LDGraphicsWindow";
            treeNode576.Name = "Node3";
            treeNode576.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode577.Name = "Node2";
            treeNode577.Text = "LDTextWindow";
            treeNode578.Name = "Node2";
            treeNode578.Text = "Zip methods moved here from LDUtilities";
            treeNode579.Name = "Node0";
            treeNode579.Text = "LDZip";
            treeNode580.Name = "Node3";
            treeNode580.Text = "Regex methods moved here from LDUtilities";
            treeNode581.Name = "Node1";
            treeNode581.Text = "LDRegex";
            treeNode582.Name = "Node1";
            treeNode582.Text = "ListViewRowCount method added";
            treeNode583.Name = "Node0";
            treeNode583.Text = "LDControls";
            treeNode584.Name = "Node3";
            treeNode584.Text = "Version 1.0.0.118";
            treeNode585.Name = "Node5";
            treeNode585.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode586.Name = "Node6";
            treeNode586.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode587.Name = "Node4";
            treeNode587.Text = "LDUtilities";
            treeNode588.Name = "Node10";
            treeNode588.Text = "SetUserCursor method added";
            treeNode589.Name = "Node4";
            treeNode589.Text = "LDCursors";
            treeNode590.Name = "Node3";
            treeNode590.Text = "Version 1.0.0.117";
            treeNode591.Name = "Node2";
            treeNode591.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode592.Name = "Node1";
            treeNode592.Text = "LDDictionary";
            treeNode593.Name = "Node0";
            treeNode593.Text = "Version 1.0.0.116";
            treeNode594.Name = "Node2";
            treeNode594.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode595.Name = "Node1";
            treeNode595.Text = "LDColours";
            treeNode596.Name = "Node4";
            treeNode596.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode597.Name = "Node3";
            treeNode597.Text = "LDShapes";
            treeNode598.Name = "Node1";
            treeNode598.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode599.Name = "Node0";
            treeNode599.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode600.Name = "Node1";
            treeNode600.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode601.Name = "Node0";
            treeNode601.Text = "LDGraph";
            treeNode602.Name = "Node0";
            treeNode602.Text = "Version 1.0.0.115";
            treeNode603.Name = "Node2";
            treeNode603.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode604.Name = "Node1";
            treeNode604.Text = "LDControls";
            treeNode605.Name = "Node4";
            treeNode605.Text = "RemoveTurtleLines method added";
            treeNode606.Name = "Node6";
            treeNode606.Text = "GetAllShapes method added";
            treeNode607.Name = "Node3";
            treeNode607.Text = "LDShapes";
            treeNode608.Name = "Node1";
            treeNode608.Text = "Odbc connection added";
            treeNode609.Name = "Node0";
            treeNode609.Text = "LDDatabase";
            treeNode610.Name = "Node0";
            treeNode610.Text = "Version 1.0.0.114";
            treeNode611.Name = "Node2";
            treeNode611.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode612.Name = "Node1";
            treeNode612.Text = "LDUtilities";
            treeNode613.Name = "Node4";
            treeNode613.Text = "ListView control added";
            treeNode614.Name = "Node5";
            treeNode614.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode615.Name = "Node3";
            treeNode615.Text = "LDControls";
            treeNode616.Name = "Node0";
            treeNode616.Text = "Version 1.0.0.113";
            treeNode617.Name = "Node2";
            treeNode617.Text = "Tone method added";
            treeNode618.Name = "Node1";
            treeNode618.Text = "LDSound";
            treeNode619.Name = "Node5";
            treeNode619.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode620.Name = "Node4";
            treeNode620.Text = "LDControls";
            treeNode621.Name = "Node0";
            treeNode621.Text = "Version 1.0.0.112";
            treeNode622.Name = "Node2";
            treeNode622.Text = "SqlServer and Access database support added";
            treeNode623.Name = "Node1";
            treeNode623.Text = "LDDataBase";
            treeNode624.Name = "Node4";
            treeNode624.Text = "FixFlickr method added";
            treeNode625.Name = "Node0";
            treeNode625.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode626.Name = "Node3";
            treeNode626.Text = "LDUtilities";
            treeNode627.Name = "Node0";
            treeNode627.Text = "Version 1.0.0.111";
            treeNode628.Name = "Node2";
            treeNode628.Text = "TextBoxTab method added";
            treeNode629.Name = "Node1";
            treeNode629.Text = "LDControls";
            treeNode630.Name = "Node0";
            treeNode630.Text = "Version 1.0.0.110";
            treeNode631.Name = "Node1";
            treeNode631.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode632.Name = "Node3";
            treeNode632.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode633.Name = "Node0";
            treeNode633.Text = "General";
            treeNode634.Name = "Node5";
            treeNode634.Text = "Exists method added to check if a file path exists or not";
            treeNode635.Name = "Node4";
            treeNode635.Text = "LDFile";
            treeNode636.Name = "Node7";
            treeNode636.Text = "Start method handles attaching to existing process without warning";
            treeNode637.Name = "Node6";
            treeNode637.Text = "LDProcess";
            treeNode638.Name = "Node1";
            treeNode638.Text = "MySQL database support added";
            treeNode639.Name = "Node0";
            treeNode639.Text = "LDDatabase";
            treeNode640.Name = "Node3";
            treeNode640.Text = "Add and Multiply methods honour transparency";
            treeNode641.Name = "Node4";
            treeNode641.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode642.Name = "Node2";
            treeNode642.Text = "LDImage";
            treeNode643.Name = "Node3";
            treeNode643.Text = "Version 1.0.0.109";
            treeNode644.Name = "Node2";
            treeNode644.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode645.Name = "Node1";
            treeNode645.Text = "LDTextWindow";
            treeNode646.Name = "Node0";
            treeNode646.Text = "Version 1.0.0.108";
            treeNode647.Name = "Node14";
            treeNode647.Text = "Transparent colour added";
            treeNode648.Name = "Node13";
            treeNode648.Text = "LDColours";
            treeNode649.Name = "Node16";
            treeNode649.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode650.Name = "Node15";
            treeNode650.Text = "LDDialogs";
            treeNode651.Name = "Node12";
            treeNode651.Text = "Version 1.0.0.107";
            treeNode652.Name = "Node8";
            treeNode652.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode653.Name = "Node7";
            treeNode653.Text = "LDControls";
            treeNode654.Name = "Node11";
            treeNode654.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode655.Name = "Node10";
            treeNode655.Text = "LDShapes";
            treeNode656.Name = "Node6";
            treeNode656.Text = "Version 1.0.0.106";
            treeNode657.Name = "Node5";
            treeNode657.Text = "Menu control added";
            treeNode658.Name = "Node4";
            treeNode658.Text = "LDControls";
            treeNode659.Name = "Node3";
            treeNode659.Text = "Version 1.0.0.105";
            treeNode660.Name = "Node5";
            treeNode660.Text = "ZipList method added";
            treeNode661.Name = "Node2";
            treeNode661.Text = "GetNextMapIndex method added";
            treeNode662.Name = "Node4";
            treeNode662.Text = "LDUtilities";
            treeNode663.Name = "Node1";
            treeNode663.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode664.Name = "Node0";
            treeNode664.Text = "LDShapes";
            treeNode665.Name = "Node3";
            treeNode665.Text = "Version 1.0.0.104";
            treeNode666.Name = "Node1";
            treeNode666.Text = "Transparency maintained for various methods";
            treeNode667.Name = "Node2";
            treeNode667.Text = "Effects bug fixed";
            treeNode668.Name = "Node0";
            treeNode668.Text = "LDImage";
            treeNode669.Name = "Node0";
            treeNode669.Text = "Version 1.0.0.103";
            treeNode670.Name = "Node1";
            treeNode670.Text = "Current application assemblies are all auto-referenced";
            treeNode671.Name = "Node0";
            treeNode671.Text = "LDInline";
            treeNode672.Name = "Node5";
            treeNode672.Text = "Version 1.0.0.102";
            treeNode673.Name = "Node1";
            treeNode673.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode674.Name = "Node2";
            treeNode674.Text = "LDInline.sb sample provided";
            treeNode675.Name = "Node0";
            treeNode675.Text = "LDInline";
            treeNode676.Name = "Node4";
            treeNode676.Text = "ExitButtonMode method added to control window close button state";
            treeNode677.Name = "Node3";
            treeNode677.Text = "LDUtilities";
            treeNode678.Name = "Node0";
            treeNode678.Text = "Version 1.0.0.101";
            treeNode679.Name = "Node1";
            treeNode679.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode680.Name = "Node0";
            treeNode680.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode681.Name = "Node0";
            treeNode681.Text = "LDTextWindow";
            treeNode682.Name = "Node0";
            treeNode682.Text = "Version 1.0.0.100";
            treeNode683.Name = "Node2";
            treeNode683.Text = "ReadANSIToArray method added";
            treeNode684.Name = "Node1";
            treeNode684.Text = "LDFile";
            treeNode685.Name = "Node1";
            treeNode685.Text = "DocumentViewer control added";
            treeNode686.Name = "Node0";
            treeNode686.Text = "LDControls";
            treeNode687.Name = "Node3";
            treeNode687.Text = "An object to batch update shapes (for speed reasons)";
            treeNode688.Name = "Node0";
            treeNode688.Text = "LDFastShapes.sb sample included";
            treeNode689.Name = "Node2";
            treeNode689.Text = "LDFastShapes";
            treeNode690.Name = "Node0";
            treeNode690.Text = "Version 1.0.0.99";
            treeNode691.Name = "Node1";
            treeNode691.Text = "Rendering performance improvements when many shapes present";
            treeNode692.Name = "Node0";
            treeNode692.Text = "LDPhysics";
            treeNode693.Name = "Node1";
            treeNode693.Text = "ANSItoUTF8 method added";
            treeNode694.Name = "Node2";
            treeNode694.Text = "ReadANSI method added";
            treeNode695.Name = "Node0";
            treeNode695.Text = "LDFile";
            treeNode696.Name = "Node1";
            treeNode696.Text = "Version 1.0.0.98";
            treeNode697.Name = "Node3";
            treeNode697.Text = "Move method added for tiangles, polygons and lines";
            treeNode698.Name = "Node4";
            treeNode698.Text = "RotateAbout method added";
            treeNode699.Name = "Node1";
            treeNode699.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode700.Name = "Node0";
            treeNode700.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode701.Name = "Node2";
            treeNode701.Text = "LDShapes";
            treeNode702.Name = "Node0";
            treeNode702.Text = "Version 1.0.0.97";
            treeNode703.Name = "Node4";
            treeNode703.Text = "A list storage object added";
            treeNode704.Name = "Node3";
            treeNode704.Text = "LDList";
            treeNode705.Name = "Node2";
            treeNode705.Text = "Version 1.0.0.96";
            treeNode706.Name = "Node4";
            treeNode706.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode707.Name = "Node3";
            treeNode707.Text = "LDQueue";
            treeNode708.Name = "Node6";
            treeNode708.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode709.Name = "Node5";
            treeNode709.Text = "LDNetwork";
            treeNode710.Name = "Node0";
            treeNode710.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode711.Name = "Node1";
            treeNode711.Text = "General";
            treeNode712.Name = "Node2";
            treeNode712.Text = "Version 1.0.0.95";
            treeNode713.Name = "Node2";
            treeNode713.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode714.Name = "Node1";
            treeNode714.Text = "LDEncryption";
            treeNode715.Name = "Node1";
            treeNode715.Text = "RandomNumberSeed property added";
            treeNode716.Name = "Node0";
            treeNode716.Text = "LDMath";
            treeNode717.Name = "Node1";
            treeNode717.Text = "SetGameData and GetGameData methods added";
            treeNode718.Name = "Node0";
            treeNode718.Text = "LDNetwork";
            treeNode719.Name = "Node0";
            treeNode719.Text = "Version 1.0.0.94";
            treeNode720.Name = "Node1";
            treeNode720.Text = "SliderGetValue method added";
            treeNode721.Name = "Node0";
            treeNode721.Text = "LDControls";
            treeNode722.Name = "Node5";
            treeNode722.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode723.Name = "Node2";
            treeNode723.Text = "LDUtilities";
            treeNode724.Name = "Node3";
            treeNode724.Text = "Encrypt and Decrypt methods added";
            treeNode725.Name = "Node4";
            treeNode725.Text = "MD5Hash method added";
            treeNode726.Name = "Node6";
            treeNode726.Text = "LDEncryption";
            treeNode727.Name = "Node0";
            treeNode727.Text = "Version 1.0.0.93";
            treeNode728.Name = "Node1";
            treeNode728.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode729.Name = "Node0";
            treeNode729.Text = "LDControls";
            treeNode730.Name = "Node0";
            treeNode730.Text = "Version 1.0.0.92";
            treeNode731.Name = "Node2";
            treeNode731.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode732.Name = "Node1";
            treeNode732.Text = "LDControls";
            treeNode733.Name = "Node1";
            treeNode733.Text = "Version 1.0.0.91";
            treeNode734.Name = "Node1";
            treeNode734.Text = "Font method added to modify shapes or controls that have text";
            treeNode735.Name = "Node0";
            treeNode735.Text = "LDShapes";
            treeNode736.Name = "Node1";
            treeNode736.Text = "MediaPlayer control added (play videos etc)";
            treeNode737.Name = "Node0";
            treeNode737.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode738.Name = "Node0";
            treeNode738.Text = "LDControls";
            treeNode739.Name = "Node1";
            treeNode739.Text = "Version 1.0.0.90";
            treeNode740.Name = "Node1";
            treeNode740.Text = "Autosize columns for ListView";
            treeNode741.Name = "Node2";
            treeNode741.Text = "LDDataBase.sb sample updated";
            treeNode742.Name = "Node0";
            treeNode742.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode743.Name = "Node0";
            treeNode743.Text = "LDDataBase";
            treeNode744.Name = "Node0";
            treeNode744.Text = "Version 1.0.0.89";
            treeNode745.Name = "Node4";
            treeNode745.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode746.Name = "Node3";
            treeNode746.Text = "LDScrollBars";
            treeNode747.Name = "Node1";
            treeNode747.Text = "CleanTemp method added";
            treeNode748.Name = "Node0";
            treeNode748.Text = "LDUtilities";
            treeNode749.Name = "Node1";
            treeNode749.Text = "SQLite database methods added";
            treeNode750.Name = "Node0";
            treeNode750.Text = "LDDataBase";
            treeNode751.Name = "Node2";
            treeNode751.Text = "Version 1.0.0.88";
            treeNode752.Name = "Node2";
            treeNode752.Text = "LastError now returns a text error";
            treeNode753.Name = "Node1";
            treeNode753.Text = "LDIOWarrior";
            treeNode754.Name = "Node1";
            treeNode754.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode755.Name = "Node0";
            treeNode755.Text = "LDScrollBars";
            treeNode756.Name = "Node0";
            treeNode756.Text = "Version 1.0.0.87";
            treeNode757.Name = "Node4";
            treeNode757.Text = "SetTurtleImage method added";
            treeNode758.Name = "Node3";
            treeNode758.Text = "LDShapes";
            treeNode759.Name = "Node1";
            treeNode759.Text = "Connect to IOWarrior USB devices";
            treeNode760.Name = "Node0";
            treeNode760.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode761.Name = "Node0";
            treeNode761.Text = "LDIOWarrior";
            treeNode762.Name = "Node2";
            treeNode762.Text = "Version 1.0.0.86";
            treeNode763.Name = "Node1";
            treeNode763.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode764.Name = "Node0";
            treeNode764.Text = "LDShapes";
            treeNode765.Name = "Node2";
            treeNode765.Text = "Version 1.0.0.85";
            treeNode766.Name = "Node4";
            treeNode766.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode767.Name = "Node3";
            treeNode767.Text = "LDFile";
            treeNode768.Name = "Node6";
            treeNode768.Text = "Crop method added";
            treeNode769.Name = "Node5";
            treeNode769.Text = "LDImage";
            treeNode770.Name = "Node1";
            treeNode770.Text = "LastDropFiles bug fixed";
            treeNode771.Name = "Node0";
            treeNode771.Text = "LDControls";
            treeNode772.Name = "Node2";
            treeNode772.Text = "Version 1.0.0.84";
            treeNode773.Name = "Node7";
            treeNode773.Text = "FileDropped event added";
            treeNode774.Name = "Node6";
            treeNode774.Text = "LDControls";
            treeNode775.Name = "Node1";
            treeNode775.Text = "Bug in Split corrected";
            treeNode776.Name = "Node0";
            treeNode776.Text = "LDText";
            treeNode777.Name = "Node5";
            treeNode777.Text = "Version 1.0.0.83";
            treeNode778.Name = "Node3";
            treeNode778.Text = "Title argument removed from AddComboBox";
            treeNode779.Name = "Node4";
            treeNode779.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode780.Name = "Node2";
            treeNode780.Text = "LDControls";
            treeNode781.Name = "Node1";
            treeNode781.Text = "Version 1.0.0.82";
            treeNode782.Name = "Node0";
            treeNode782.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode783.Name = "Node12";
            treeNode783.Text = "Program settings added";
            treeNode784.Name = "Node9";
            treeNode784.Text = "LDSettings";
            treeNode785.Name = "Node11";
            treeNode785.Text = "Get some system paths and user name";
            treeNode786.Name = "Node10";
            treeNode786.Text = "LDFile";
            treeNode787.Name = "Node14";
            treeNode787.Text = "System sounds added";
            treeNode788.Name = "Node13";
            treeNode788.Text = "LDSound";
            treeNode789.Name = "Node16";
            treeNode789.Text = "Binary, octal, hex and decimal conversions";
            treeNode790.Name = "Node15";
            treeNode790.Text = "LDMath";
            treeNode791.Name = "Node1";
            treeNode791.Text = "Replace method added";
            treeNode792.Name = "Node2";
            treeNode792.Text = "FindAll method added";
            treeNode793.Name = "Node0";
            treeNode793.Text = "LDText";
            treeNode794.Name = "Node8";
            treeNode794.Text = "Version 1.0.0.81";
            treeNode795.Name = "Node1";
            treeNode795.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode796.Name = "Node6";
            treeNode796.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode797.Name = "Node0";
            treeNode797.Text = "LDShapes";
            treeNode798.Name = "Node3";
            treeNode798.Text = "Truncate method added";
            treeNode799.Name = "Node2";
            treeNode799.Text = "LDMath";
            treeNode800.Name = "Node5";
            treeNode800.Text = "Additional text methods";
            treeNode801.Name = "Node4";
            treeNode801.Text = "LDText";
            treeNode802.Name = "Node0";
            treeNode802.Text = "Version 1.0.0.80";
            treeNode803.Name = "Node1";
            treeNode803.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode804.Name = "Node0";
            treeNode804.Text = "LDDialogs";
            treeNode805.Name = "Node1";
            treeNode805.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode806.Name = "Node0";
            treeNode806.Text = "LDUtilities";
            treeNode807.Name = "Node6";
            treeNode807.Text = "Version 1.0.0.79";
            treeNode808.Name = "Node2";
            treeNode808.Text = "Rasterize property added";
            treeNode809.Name = "Node5";
            treeNode809.Text = "Improvements associated with window resizing";
            treeNode810.Name = "Node1";
            treeNode810.Text = "LDScrollBars";
            treeNode811.Name = "Node4";
            treeNode811.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode812.Name = "Node3";
            treeNode812.Text = "LDUtilities";
            treeNode813.Name = "Node0";
            treeNode813.Text = "Version 1.0.0.78";
            treeNode814.Name = "Node1";
            treeNode814.Text = "Handle more than 100 drawables (rasterization)";
            treeNode815.Name = "Node0";
            treeNode815.Text = "LDScollBars";
            treeNode816.Name = "Node2";
            treeNode816.Text = "Version 1.0.0.77";
            treeNode817.Name = "Node1";
            treeNode817.Text = "Record sound from a microphone";
            treeNode818.Name = "Node0";
            treeNode818.Text = "LDSound";
            treeNode819.Name = "Node3";
            treeNode819.Text = "AnimateOpacity method added (flashing)";
            treeNode820.Name = "Node0";
            treeNode820.Text = "AnimateRotation method added (continuous rotation)";
            treeNode821.Name = "Node1";
            treeNode821.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode822.Name = "Node2";
            treeNode822.Text = "LDShapes";
            treeNode823.Name = "Node2";
            treeNode823.Text = "Version 1.0.0.76";
            treeNode824.Name = "Node1";
            treeNode824.Text = "AddAnimatedImage can use an ImageList image";
            treeNode825.Name = "Node0";
            treeNode825.Text = "LDShapes";
            treeNode826.Name = "Node0";
            treeNode826.Text = "Version 1.0.0.75";
            treeNode827.Name = "Node1";
            treeNode827.Text = "Initial graph axes scaling improvement";
            treeNode828.Name = "Node0";
            treeNode828.Text = "LDGraph";
            treeNode829.Name = "Node3";
            treeNode829.Text = "Methods to access a bluetooth device";
            treeNode830.Name = "Node0";
            treeNode830.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode831.Name = "Node2";
            treeNode831.Text = "LDBlueTooth";
            treeNode832.Name = "Node1";
            treeNode832.Text = "getFocus handles multiple LDWindows";
            treeNode833.Name = "Node0";
            treeNode833.Text = "LDFocus";
            treeNode834.Name = "Node0";
            treeNode834.Text = "Version 1.0.0.74";
            treeNode835.Name = "Node1";
            treeNode835.Text = "First pass at a generic USB (HID) device controller";
            treeNode836.Name = "Node0";
            treeNode836.Text = "LDHID";
            treeNode837.Name = "Node9";
            treeNode837.Text = "Version 1.0.0.73";
            treeNode838.Name = "Node8";
            treeNode838.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode839.Name = "Node7";
            treeNode839.Text = "LDGraph";
            treeNode840.Name = "Node6";
            treeNode840.Text = "Version 1.0.0.72";
            treeNode841.Name = "Node4";
            treeNode841.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode842.Name = "Node5";
            treeNode842.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode843.Name = "Node3";
            treeNode843.Text = "LDGraph";
            treeNode844.Name = "Node2";
            treeNode844.Text = "Version 1.0.0.71";
            treeNode845.Name = "Node1";
            treeNode845.Text = "Spurious error message fixed";
            treeNode846.Name = "Node2";
            treeNode846.Text = "CreateTrend data series creation method added";
            treeNode847.Name = "Node0";
            treeNode847.Text = "LDGraph";
            treeNode848.Name = "Node2";
            treeNode848.Text = "Version 1.0.0.70";
            treeNode849.Name = "Node1";
            treeNode849.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode850.Name = "Node0";
            treeNode850.Text = "LDControls";
            treeNode851.Name = "Node3";
            treeNode851.Text = "Version 1.0.0.69";
            treeNode852.Name = "Node2";
            treeNode852.Text = "Radio button control added";
            treeNode853.Name = "Node1";
            treeNode853.Text = "LDControls";
            treeNode854.Name = "Node0";
            treeNode854.Text = "Version 1.0.0.68";
            treeNode855.Name = "Node1";
            treeNode855.Text = "Bug fix for Copy";
            treeNode856.Name = "Node0";
            treeNode856.Text = "LDArray";
            treeNode857.Name = "Node2";
            treeNode857.Text = "Version 1.0.0.67";
            treeNode858.Name = "Node1";
            treeNode858.Text = "RegexMatch and RegexReplace methods added";
            treeNode859.Name = "Node0";
            treeNode859.Text = "LDUtilities";
            treeNode860.Name = "Node3";
            treeNode860.Text = "Version 1.0.0.66";
            treeNode861.Name = "Node2";
            treeNode861.Text = "Number culture conversions added";
            treeNode862.Name = "Node1";
            treeNode862.Text = "LDUtilities";
            treeNode863.Name = "Node0";
            treeNode863.Text = "Version 1.0.0.65";
            treeNode864.Name = "Node1";
            treeNode864.Text = "IsNumber method added";
            treeNode865.Name = "Node0";
            treeNode865.Text = "LDUtilities";
            treeNode866.Name = "Node2";
            treeNode866.Text = "Version 1.0.0.64";
            treeNode867.Name = "Node1";
            treeNode867.Text = "SetCursorPosition method added for textboxes";
            treeNode868.Name = "Node0";
            treeNode868.Text = "LDControls";
            treeNode869.Name = "Node4";
            treeNode869.Text = "Version 1.0.0.63";
            treeNode870.Name = "Node1";
            treeNode870.Text = "SetCursorToEnd method added for textboxes";
            treeNode871.Name = "Node3";
            treeNode871.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode872.Name = "Node0";
            treeNode872.Text = "LDControls";
            treeNode873.Name = "Node2";
            treeNode873.Text = "Version 1.0.0.62";
            treeNode874.Name = "Node1";
            treeNode874.Text = "Adding polygons not located at (0,0) corrected";
            treeNode875.Name = "Node0";
            treeNode875.Text = "LDPhysics";
            treeNode876.Name = "Node2";
            treeNode876.Text = "Version 1.0.0.61";
            treeNode877.Name = "Node1";
            treeNode877.Text = "GetFolder dialog added";
            treeNode878.Name = "Node0";
            treeNode878.Text = "LDDialogs";
            treeNode879.Name = "Node0";
            treeNode879.Text = "Version 1.0.0.60";
            treeNode880.Name = "Node10";
            treeNode880.Text = "Possible localization issue with Font size fixed";
            treeNode881.Name = "Node9";
            treeNode881.Text = "LDDialogs";
            treeNode882.Name = "Node8";
            treeNode882.Text = "Version 1.0.0.59";
            treeNode883.Name = "Node3";
            treeNode883.Text = "More internationalization fixes";
            treeNode884.Name = "Node2";
            treeNode884.Text = "ShowPrintPreview property added";
            treeNode885.Name = "Node1";
            treeNode885.Text = "LDUtilities";
            treeNode886.Name = "Node5";
            treeNode886.Text = "Possible error with gradient drawings fixed";
            treeNode887.Name = "Node4";
            treeNode887.Text = "LDShapes";
            treeNode888.Name = "Node7";
            treeNode888.Text = "Possible Listen event initialisation error fixed";
            treeNode889.Name = "Node6";
            treeNode889.Text = "LDSpeech";
            treeNode890.Name = "Node0";
            treeNode890.Text = "Version 1.0.0.58";
            treeNode891.Name = "Node7";
            treeNode891.Text = "Many possible internationisation issues fixed";
            treeNode892.Name = "Node4";
            treeNode892.Text = "Version 1.0.0.57";
            treeNode893.Name = "Node1";
            treeNode893.Text = "Emmisive colour correction for AddGeometry";
            treeNode894.Name = "Node2";
            treeNode894.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode895.Name = "Node0";
            treeNode895.Text = "LD3DView";
            treeNode896.Name = "Node1";
            treeNode896.Text = "CSVdeminiator property added";
            treeNode897.Name = "Node0";
            treeNode897.Text = "LDUtilities";
            treeNode898.Name = "Node5";
            treeNode898.Text = "Version 1.0.0.56";
            treeNode899.Name = "Node1";
            treeNode899.Text = "Improved error reporting";
            treeNode900.Name = "Node2";
            treeNode900.Text = "Culture invariant type conversions";
            treeNode901.Name = "Node1";
            treeNode901.Text = "LD3DView";
            treeNode902.Name = "Node4";
            treeNode902.Text = "ShowErrors method added";
            treeNode903.Name = "Node3";
            treeNode903.Text = "LDUtilities";
            treeNode904.Name = "Node0";
            treeNode904.Text = "Version 1.0.0.55";
            treeNode905.Name = "Node4";
            treeNode905.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode906.Name = "Node3";
            treeNode906.Text = "LDScrollBars";
            treeNode907.Name = "Node6";
            treeNode907.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode908.Name = "Node5";
            treeNode908.Text = "LDUtilities";
            treeNode909.Name = "Node2";
            treeNode909.Text = "Version 1.0.0.54";
            treeNode910.Name = "Node1";
            treeNode910.Text = "Debug window can be resized";
            treeNode911.Name = "Node0";
            treeNode911.Text = "LDDebug";
            treeNode912.Name = "Node1";
            treeNode912.Text = "PrintFile method added";
            treeNode913.Name = "Node0";
            treeNode913.Text = "LDFile";
            treeNode914.Name = "Node2";
            treeNode914.Text = "Version 1.0.0.53";
            treeNode915.Name = "Node1";
            treeNode915.Text = "SSL property option added";
            treeNode916.Name = "Node0";
            treeNode916.Text = "LDEmail";
            treeNode917.Name = "Node0";
            treeNode917.Text = "Version 1.0.0.52";
            treeNode918.Name = "Node1";
            treeNode918.Text = "Right Click Context menu added for any shape or control";
            treeNode919.Name = "Node0";
            treeNode919.Text = "LDControls";
            treeNode920.Name = "Node0";
            treeNode920.Text = "Version 1.0.0.51";
            treeNode921.Name = "Node1";
            treeNode921.Text = "Right click dropdown menu option added";
            treeNode922.Name = "Node0";
            treeNode922.Text = "LDDialogs";
            treeNode923.Name = "Node0";
            treeNode923.Text = "Version 1.0.0.50";
            treeNode924.Name = "Node1";
            treeNode924.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode925.Name = "Node0";
            treeNode925.Text = "LD3DView";
            treeNode926.Name = "Node0";
            treeNode926.Text = "Version 1.0.0.49";
            treeNode927.Name = "Node1";
            treeNode927.Text = "Performance improvements (some camera controls for this)";
            treeNode928.Name = "Node1";
            treeNode928.Text = "LoadModel (*.3ds) files added";
            treeNode929.Name = "Node0";
            treeNode929.Text = "LD3DView";
            treeNode930.Name = "Node3";
            treeNode930.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode931.Name = "Node2";
            treeNode931.Text = "LDShapes";
            treeNode932.Name = "Node0";
            treeNode932.Text = "Version 1.0.0.48";
            treeNode933.Name = "Node1";
            treeNode933.Text = "Some improvements including animations";
            treeNode934.Name = "Node0";
            treeNode934.Text = "LD3DView";
            treeNode935.Name = "Node0";
            treeNode935.Text = "Version 1.0.0.47";
            treeNode936.Name = "Node1";
            treeNode936.Text = "Some improvemts and new methods";
            treeNode937.Name = "Node0";
            treeNode937.Text = "LD3Dview";
            treeNode938.Name = "Node2";
            treeNode938.Text = "Version 1.0.0.46";
            treeNode939.Name = "Node1";
            treeNode939.Text = "A start at a 3D set of methods";
            treeNode940.Name = "Node0";
            treeNode940.Text = "LD3DView";
            treeNode941.Name = "Node10";
            treeNode941.Text = "Version 1.0.0.45";
            treeNode942.Name = "Node1";
            treeNode942.Text = "Create scrollbars for the GraphicsWindow";
            treeNode943.Name = "Node5";
            treeNode943.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode944.Name = "Node0";
            treeNode944.Text = "LDScrollBars";
            treeNode945.Name = "Node4";
            treeNode945.Text = "ColourList method added";
            treeNode946.Name = "Node3";
            treeNode946.Text = "LDUtilities";
            treeNode947.Name = "Node8";
            treeNode947.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode948.Name = "Node9";
            treeNode948.Text = "BackgroundImage method to set the background added";
            treeNode949.Name = "Node6";
            treeNode949.Text = "LDShapes";
            treeNode950.Name = "Node0";
            treeNode950.Text = "Version 1.0.0.44";
            treeNode951.Name = "Node1";
            treeNode951.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode952.Name = "Node0";
            treeNode952.Text = "LDUtilities";
            treeNode953.Name = "Node0";
            treeNode953.Text = "Version 1.0.0.43";
            treeNode954.Name = "Node1";
            treeNode954.Text = "Call Subs as functions with arguments";
            treeNode955.Name = "Node0";
            treeNode955.Text = "LDCall";
            treeNode956.Name = "Node0";
            treeNode956.Text = "Version 1.0.0.42";
            treeNode957.Name = "Node1";
            treeNode957.Text = "Font dialog added";
            treeNode958.Name = "Node2";
            treeNode958.Text = "Colours dialog moved here from LDColours";
            treeNode959.Name = "Node0";
            treeNode959.Text = "LDDialogs";
            treeNode960.Name = "Node9";
            treeNode960.Text = "Version 1.0.0.41";
            treeNode961.Name = "Node1";
            treeNode961.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode962.Name = "Node7";
            treeNode962.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode963.Name = "Node8";
            treeNode963.Text = "Some methods renamed";
            treeNode964.Name = "Node0";
            treeNode964.Text = "LDControls";
            treeNode965.Name = "Node3";
            treeNode965.Text = "HighScore method move here";
            treeNode966.Name = "Node2";
            treeNode966.Text = "LDNetwork";
            treeNode967.Name = "Node6";
            treeNode967.Text = "SetSize method added";
            treeNode968.Name = "Node5";
            treeNode968.Text = "LDShapes";
            treeNode969.Name = "Node3";
            treeNode969.Text = "Version 1.0.0.40";
            treeNode970.Name = "Node1";
            treeNode970.Text = "SelectTreeView method added";
            treeNode971.Name = "Node2";
            treeNode971.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode972.Name = "Node0";
            treeNode972.Text = "LDDialogs";
            treeNode973.Name = "Node1";
            treeNode973.Text = "Simple high score web method";
            treeNode974.Name = "Node0";
            treeNode974.Text = "LDHighScore";
            treeNode975.Name = "Node3";
            treeNode975.Text = "Version 1.0.0.39";
            treeNode976.Name = "Node2";
            treeNode976.Text = "RichTextBox methods improved";
            treeNode977.Name = "Node1";
            treeNode977.Text = "LDDialogs";
            treeNode978.Name = "Node1";
            treeNode978.Text = "Search, Load and Save methods added";
            treeNode979.Name = "Node0";
            treeNode979.Text = "LDArray";
            treeNode980.Name = "Node0";
            treeNode980.Text = "Version 1.0.0.38";
            treeNode981.Name = "Node1";
            treeNode981.Text = "Depreciated";
            treeNode982.Name = "Node0";
            treeNode982.Text = "LDWeather";
            treeNode983.Name = "Node1";
            treeNode983.Text = "Renamed from LDTrig and some more methods added";
            treeNode984.Name = "Node0";
            treeNode984.Text = "LDMath";
            treeNode985.Name = "Node3";
            treeNode985.Text = "RichTextBox method added";
            treeNode986.Name = "Node2";
            treeNode986.Text = "LDDialogs";
            treeNode987.Name = "Node5";
            treeNode987.Text = "FontList method added";
            treeNode988.Name = "Node4";
            treeNode988.Text = "LDUtilities";
            treeNode989.Name = "Node2";
            treeNode989.Text = "Version 1.0.0.37";
            treeNode990.Name = "Node1";
            treeNode990.Text = "Zip method extended";
            treeNode991.Name = "Node0";
            treeNode991.Text = "LDUtilities";
            treeNode992.Name = "Node2";
            treeNode992.Text = "Version 1.0.0.36";
            treeNode993.Name = "Node1";
            treeNode993.Text = "Collapse and expand treeview nodes method added";
            treeNode994.Name = "Node0";
            treeNode994.Text = "LDDialogs";
            treeNode995.Name = "Node5";
            treeNode995.Text = "Version 1.0.0.35";
            treeNode996.Name = "Node1";
            treeNode996.Text = "Arguments added to Start method";
            treeNode997.Name = "Node0";
            treeNode997.Text = "LDProcess";
            treeNode998.Name = "Node4";
            treeNode998.Text = "Zip compression methods added";
            treeNode999.Name = "Node2";
            treeNode999.Text = "LDUtilities";
            treeNode1000.Name = "Node2";
            treeNode1000.Text = "Version 1.0.0.34";
            treeNode1001.Name = "Node1";
            treeNode1001.Text = "GWStyle property added";
            treeNode1002.Name = "Node0";
            treeNode1002.Text = "LDUtilities";
            treeNode1003.Name = "Node1";
            treeNode1003.Text = "TreeView and associated events added";
            treeNode1004.Name = "Node0";
            treeNode1004.Text = "LDDialogs";
            treeNode1005.Name = "Node0";
            treeNode1005.Text = "Version 1.0.0.33";
            treeNode1006.Name = "Node1";
            treeNode1006.Text = "Possible end points not plotting bug fixed";
            treeNode1007.Name = "Node0";
            treeNode1007.Text = "LDGraph";
            treeNode1008.Name = "Node2";
            treeNode1008.Text = "Version 1.0.0.32";
            treeNode1009.Name = "Node1";
            treeNode1009.Text = "Activated event and Active property addded";
            treeNode1010.Name = "Node0";
            treeNode1010.Text = "LDWindows";
            treeNode1011.Name = "Node0";
            treeNode1011.Text = "Version 1.0.0.31";
            treeNode1012.Name = "Node1";
            treeNode1012.Text = "Create multiple GraphicsWindows";
            treeNode1013.Name = "Node0";
            treeNode1013.Text = "LDWindows";
            treeNode1014.Name = "Node0";
            treeNode1014.Text = "Version 1.0.0.30";
            treeNode1015.Name = "Node1";
            treeNode1015.Text = "Email sending method";
            treeNode1016.Name = "Node0";
            treeNode1016.Text = "LDMail";
            treeNode1017.Name = "Node1";
            treeNode1017.Text = "Add and Multiply methods bug fixed";
            treeNode1018.Name = "Node2";
            treeNode1018.Text = "Image statistics combined into one method";
            treeNode1019.Name = "Node3";
            treeNode1019.Text = "Histogram method added";
            treeNode1020.Name = "Node0";
            treeNode1020.Text = "LDImage";
            treeNode1021.Name = "Node0";
            treeNode1021.Text = "Version 1.0.0.29";
            treeNode1022.Name = "Node1";
            treeNode1022.Text = "SnapshotToImageList method added";
            treeNode1023.Name = "Node0";
            treeNode1023.Text = "LDWebCam";
            treeNode1024.Name = "Node3";
            treeNode1024.Text = "ImageList image manipulation methods";
            treeNode1025.Name = "Node2";
            treeNode1025.Text = "LDImage";
            treeNode1026.Name = "Node0";
            treeNode1026.Text = "Version 1.0.0.28";
            treeNode1027.Name = "Node1";
            treeNode1027.Text = "SortIndex bugfix for null values";
            treeNode1028.Name = "Node0";
            treeNode1028.Text = "LDArray";
            treeNode1029.Name = "Node1";
            treeNode1029.Text = "SnapshotToFile bug fixed";
            treeNode1030.Name = "Node0";
            treeNode1030.Text = "LDWebCam";
            treeNode1031.Name = "Node0";
            treeNode1031.Text = "Version 1.0.0.27";
            treeNode1032.Name = "Node1";
            treeNode1032.Text = "SortIndex method added";
            treeNode1033.Name = "Node0";
            treeNode1033.Text = "LDArray";
            treeNode1034.Name = "Node1";
            treeNode1034.Text = "Web based weather report data added";
            treeNode1035.Name = "Node0";
            treeNode1035.Text = "LDWeather";
            treeNode1036.Name = "Node3";
            treeNode1036.Text = "DataReceived event added";
            treeNode1037.Name = "Node2";
            treeNode1037.Text = "LDCommPort";
            treeNode1038.Name = "Node0";
            treeNode1038.Text = "Version 1.0.0.26";
            treeNode1039.Name = "Node1";
            treeNode1039.Text = "Speech recognition added";
            treeNode1040.Name = "Node0";
            treeNode1040.Text = "LDSpeech";
            treeNode1041.Name = "Node0";
            treeNode1041.Text = "Version 1.0.0.25";
            treeNode1042.Name = "Node4";
            treeNode1042.Text = "More methods added and some internal code optimised";
            treeNode1043.Name = "Node0";
            treeNode1043.Text = "LDArray & LDMatrix";
            treeNode1044.Name = "Node1";
            treeNode1044.Text = "KeyDown method added";
            treeNode1045.Name = "Node0";
            treeNode1045.Text = "LDUtilities";
            treeNode1046.Name = "Node1";
            treeNode1046.Text = "GetAllShapesAt method added";
            treeNode1047.Name = "Node0";
            treeNode1047.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode1048.Name = "Node0";
            treeNode1048.Text = "LDShapes";
            treeNode1049.Name = "Node0";
            treeNode1049.Text = "Version 1.0.0.24";
            treeNode1050.Name = "Node1";
            treeNode1050.Text = "OpenFile and SaveFile dialogs added";
            treeNode1051.Name = "Node0";
            treeNode1051.Text = "LDDialogs";
            treeNode1052.Name = "Node2";
            treeNode1052.Text = "Matrix methods, for example to solve linear equations";
            treeNode1053.Name = "Node1";
            treeNode1053.Text = "LDMatrix";
            treeNode1054.Name = "Node0";
            treeNode1054.Text = "Version 1.0.0.23";
            treeNode1055.Name = "Node1";
            treeNode1055.Text = "Sorting method added";
            treeNode1056.Name = "Node0";
            treeNode1056.Text = "LDArray";
            treeNode1057.Name = "Node0";
            treeNode1057.Text = "Version 1.0.0.22";
            treeNode1058.Name = "Node2";
            treeNode1058.Text = "Velocity Threshold setting added";
            treeNode1059.Name = "Node1";
            treeNode1059.Text = "LDPhysics";
            treeNode1060.Name = "Node0";
            treeNode1060.Text = "Version 1.0.0.21";
            treeNode1061.Name = "Node3";
            treeNode1061.Text = "SetDamping method added";
            treeNode1062.Name = "Node2";
            treeNode1062.Text = "LDPhysics";
            treeNode1063.Name = "Node1";
            treeNode1063.Text = "Version 1.0.0.20";
            treeNode1064.Name = "Node1";
            treeNode1064.Text = "Instrument name can be obtained from its number";
            treeNode1065.Name = "Node0";
            treeNode1065.Text = "LDMusic";
            treeNode1066.Name = "Node0";
            treeNode1066.Text = "Version 1.0.0.19";
            treeNode1067.Name = "Node1";
            treeNode1067.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode1068.Name = "Node0";
            treeNode1068.Text = "LDDialogs";
            treeNode1069.Name = "Node1";
            treeNode1069.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode1070.Name = "Node2";
            treeNode1070.Text = "Notes can also be played synchronously (chords)";
            treeNode1071.Name = "Node0";
            treeNode1071.Text = "LDMusic";
            treeNode1072.Name = "Node0";
            treeNode1072.Text = "Version 1.0.0.18";
            treeNode1073.Name = "Node1";
            treeNode1073.Text = "AnimationPause and AnimationResume methods added";
            treeNode1074.Name = "Node0";
            treeNode1074.Text = "LDShapes";
            treeNode1075.Name = "Node1";
            treeNode1075.Text = "Process list indexed by ID rather than name";
            treeNode1076.Name = "Node0";
            treeNode1076.Text = "LDProcess";
            treeNode1077.Name = "Node1";
            treeNode1077.Text = "Version 1.0.0.17";
            treeNode1078.Name = "Node1";
            treeNode1078.Text = "More effects added";
            treeNode1079.Name = "Node0";
            treeNode1079.Text = "LDWebCam";
            treeNode1080.Name = "Node1";
            treeNode1080.Text = "Add or change an image on a button or image shape";
            treeNode1081.Name = "Node1";
            treeNode1081.Text = "Add an animated gif or tiled image";
            treeNode1082.Name = "Node0";
            treeNode1082.Text = "LDShapes";
            treeNode1083.Name = "Node0";
            treeNode1083.Text = "Version 1.0.0.16";
            treeNode1084.Name = "Node1";
            treeNode1084.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode1085.Name = "Node0";
            treeNode1085.Text = "LDWebCam";
            treeNode1086.Name = "Node0";
            treeNode1086.Text = "Version 1.0.0.15";
            treeNode1087.Name = "Node2";
            treeNode1087.Text = "Variables may be changed during a debug session";
            treeNode1088.Name = "Node1";
            treeNode1088.Text = "LDDebug";
            treeNode1089.Name = "Node0";
            treeNode1089.Text = "Version 1.0.0.14";
            treeNode1090.Name = "Node1";
            treeNode1090.Text = "A basic debugging tool";
            treeNode1091.Name = "Node0";
            treeNode1091.Text = "LDDebug";
            treeNode1092.Name = "Node0";
            treeNode1092.Text = "Version 1.0.0.13";
            treeNode1093.Name = "Node2";
            treeNode1093.Text = "Methods to convert between HSL and RGB";
            treeNode1094.Name = "Node18";
            treeNode1094.Text = "Method to set colour opacity";
            treeNode1095.Name = "Node19";
            treeNode1095.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode1096.Name = "Node1";
            treeNode1096.Text = "LDColours";
            treeNode1097.Name = "Node4";
            treeNode1097.Text = "Methods to add and subtract dates and times";
            treeNode1098.Name = "Node3";
            treeNode1098.Text = "LDDateTime";
            treeNode1099.Name = "Node6";
            treeNode1099.Text = "Waiting overlay, Calendar and About popups";
            treeNode1100.Name = "Node17";
            treeNode1100.Text = "Tooltips";
            treeNode1101.Name = "Node5";
            treeNode1101.Text = "LDDialogs";
            treeNode1102.Name = "Node8";
            treeNode1102.Text = "File change event";
            treeNode1103.Name = "Node7";
            treeNode1103.Text = "LDEvents";
            treeNode1104.Name = "Node0";
            treeNode1104.Text = "Version 1.0.0.12";
            treeNode1105.Name = "Node12";
            treeNode1105.Text = "Methods to sort arrays by index or value";
            treeNode1106.Name = "Node22";
            treeNode1106.Text = "Sorting by number and character strings";
            treeNode1107.Name = "Node11";
            treeNode1107.Text = "LDSort";
            treeNode1108.Name = "Node14";
            treeNode1108.Text = "Statistics on any array and distribution generation";
            treeNode1109.Name = "Node20";
            treeNode1109.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode1110.Name = "Node21";
            treeNode1110.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode1111.Name = "Node13";
            treeNode1111.Text = "LDStatistics";
            treeNode1112.Name = "Node16";
            treeNode1112.Text = "Voice and volume added";
            treeNode1113.Name = "Node15";
            treeNode1113.Text = "LDSpeech";
            treeNode1114.Name = "Node9";
            treeNode1114.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode28,
            treeNode50,
            treeNode63,
            treeNode71,
            treeNode73,
            treeNode86,
            treeNode99,
            treeNode111,
            treeNode118,
            treeNode128,
            treeNode131,
            treeNode150,
            treeNode167,
            treeNode181,
            treeNode209,
            treeNode223,
            treeNode234,
            treeNode249,
            treeNode264,
            treeNode277,
            treeNode286,
            treeNode301,
            treeNode312,
            treeNode326,
            treeNode335,
            treeNode347,
            treeNode358,
            treeNode361,
            treeNode370,
            treeNode377,
            treeNode384,
            treeNode397,
            treeNode408,
            treeNode413,
            treeNode420,
            treeNode423,
            treeNode437,
            treeNode445,
            treeNode451,
            treeNode466,
            treeNode481,
            treeNode487,
            treeNode495,
            treeNode510,
            treeNode527,
            treeNode530,
            treeNode536,
            treeNode542,
            treeNode552,
            treeNode561,
            treeNode564,
            treeNode584,
            treeNode590,
            treeNode593,
            treeNode602,
            treeNode610,
            treeNode616,
            treeNode621,
            treeNode627,
            treeNode630,
            treeNode643,
            treeNode646,
            treeNode651,
            treeNode656,
            treeNode659,
            treeNode665,
            treeNode669,
            treeNode672,
            treeNode678,
            treeNode682,
            treeNode690,
            treeNode696,
            treeNode702,
            treeNode705,
            treeNode712,
            treeNode719,
            treeNode727,
            treeNode730,
            treeNode733,
            treeNode739,
            treeNode744,
            treeNode751,
            treeNode756,
            treeNode762,
            treeNode765,
            treeNode772,
            treeNode777,
            treeNode781,
            treeNode794,
            treeNode802,
            treeNode807,
            treeNode813,
            treeNode816,
            treeNode823,
            treeNode826,
            treeNode834,
            treeNode837,
            treeNode840,
            treeNode844,
            treeNode848,
            treeNode851,
            treeNode854,
            treeNode857,
            treeNode860,
            treeNode863,
            treeNode866,
            treeNode869,
            treeNode873,
            treeNode876,
            treeNode879,
            treeNode882,
            treeNode890,
            treeNode892,
            treeNode898,
            treeNode904,
            treeNode909,
            treeNode914,
            treeNode917,
            treeNode920,
            treeNode923,
            treeNode926,
            treeNode932,
            treeNode935,
            treeNode938,
            treeNode941,
            treeNode950,
            treeNode953,
            treeNode956,
            treeNode960,
            treeNode969,
            treeNode975,
            treeNode980,
            treeNode989,
            treeNode992,
            treeNode995,
            treeNode1000,
            treeNode1005,
            treeNode1008,
            treeNode1011,
            treeNode1014,
            treeNode1021,
            treeNode1026,
            treeNode1031,
            treeNode1038,
            treeNode1041,
            treeNode1049,
            treeNode1054,
            treeNode1057,
            treeNode1060,
            treeNode1063,
            treeNode1066,
            treeNode1072,
            treeNode1077,
            treeNode1083,
            treeNode1086,
            treeNode1089,
            treeNode1092,
            treeNode1104,
            treeNode1114});
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