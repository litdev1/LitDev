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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CaptureScreen method added");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("FindImageInImage method added");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GetTextFromImage method added");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Version 1.2.29.6", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("GetCollisions returns chain/rope name");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("GetAcceleration method added");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Fix for chains and ropes with non default scaling");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables modified to handle LF,CR");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Angle method added");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("TextAlignment method added");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Version 1.2.29.0", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode12,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Increase default AABB for larger display");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
        "");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Exit event added");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("DataViewFont method added");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("CallIncludeWithVars method added");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("GetOriginPosition method added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Allow longer duration animations");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("LoadModel ignore bad objects");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("GetOffset method added");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("WSAD keys for AutoControl only active if GW active");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Query updated to be similar to LDControls method");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Improved so that listview can use LDControls methods");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("CreateSpline and InterpolateSpline methods added");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("MathX", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Version 1.2.28.0", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21,
            treeNode23,
            treeNode25,
            treeNode31,
            treeNode34,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("RichTextBoxWord method extended");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("TextBoxSelection method added");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("RichTextBoxSelectionChanged event added");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("RichLastTextBoxSelection property added");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("RichTextBoxMousePosition method added");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("RichTextBoxCaretPosition method added");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("RichTextBoxCaretCoordinates method added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("RichTextBoxWholeWord property added");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("RichTextBoxInsert method added");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("GetAllShapesAt updated to handle RTB");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Compiler property added");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("GW and TW aliases added");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Aliases", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("LF, CR, SQ, DQ, BS special characters added");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("InputBox method added");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("TurtleSpeed property added");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Version 1.2.27.0", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode50,
            treeNode52,
            treeNode54,
            treeNode56,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Update API");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("LoadImage replacement for Imagelist method that can download Flickr images");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Update HelixToolkit");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
        "ial methods added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("AddBackImage bug fixed");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Performance improvement for \'sleeping\' shapes");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Updated intellisense");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Version 1.2.26.0", new System.Windows.Forms.TreeNode[] {
            treeNode61,
            treeNode63,
            treeNode67,
            treeNode69,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Network Security Protocol fixes (SSL)");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("SetSSL method added");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("FixFlickr updates for new api key");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Separate download required");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("SmallVisualBasic (sVB) support", new System.Windows.Forms.TreeNode[] {
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Version 1.2.25.0", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode75,
            treeNode77,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Reinstated website");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("API updated to MS Cognitive");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("CaptureScreen method added");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Fix for ListFiles");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("WriteFromArray method added");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode89});
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Object added (code by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Suppress javascript popup error messages");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Version 1.2.23.0", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode86,
            treeNode88,
            treeNode90,
            treeNode92,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("SaveTableBySQL method added");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Object added by Abhishek Sathiabalan");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("LDFinances", new System.Windows.Forms.TreeNode[] {
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Version 1.2.24.0", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDHashTable object added (code from Abhishek Sathiabalan)", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Some Nuget packages used (suggested by Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Various performance improvements (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("LDGeography (code from Abhishek Sathiabalan)");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("AvailableCultures method added");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("FixFlickr updated for API change");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode105,
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Version 1.2.22.0", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode102,
            treeNode103,
            treeNode104,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("GetImage method improved to fix thread issue");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("ReadByteArray and WriteByteArray methods added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("RenameRoot method added");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("View method added");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("LDXML", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode114});
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Update to Azure");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Version 1.2.21.0", new System.Windows.Forms.TreeNode[] {
            treeNode110,
            treeNode112,
            treeNode115,
            treeNode117,
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Correctly handles pie segments greater than 180 degrees");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode121});
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Decimal2Base works for number 0 in all bases");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Updated currency API");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Version 1.2.20.0", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode124,
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Fix for ReSize for some controls");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Fix for GetLeft and GetTop for shapes that have not been positioned yet");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("AddPyramid shape fixed");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode131});
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("New object to create icons and cursors added");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("LDIcon", new System.Windows.Forms.TreeNode[] {
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Fix for View (non-modal)");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Version 1.2.19.0", new System.Windows.Forms.TreeNode[] {
            treeNode130,
            treeNode132,
            treeNode134,
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("SetBackMaterial and AddBackImage methods added");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("Version 1.2.18.0", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Fast text appending method added");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Potential performance improvements");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Volume method added");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("Modified to use Google API since MS version is depreciated");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("FloodFillTolerance property added");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("And and Or renamed And_ and Or_");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("SendClick method added");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Version 1.2.17.0", new System.Windows.Forms.TreeNode[] {
            treeNode142,
            treeNode144,
            treeNode146,
            treeNode148,
            treeNode150,
            treeNode152,
            treeNode154,
            treeNode156,
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("SHA512HashFile method added");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Broadcast method added");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LDServer", new System.Windows.Forms.TreeNode[] {
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("AutoControl2 scene camera mode added (for model inspection)");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Various auto control improvements");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("SwapUpDirection method added");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode164,
            treeNode165,
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Improved PauseUpdates and ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDGraphicsWIndow", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("3D vector algebra methods added");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDVector", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("LastListViewColumn event property added");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("ListView subscribes to LDControls selection events");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Version 1.2.16.0", new System.Windows.Forms.TreeNode[] {
            treeNode161,
            treeNode163,
            treeNode167,
            treeNode169,
            treeNode171,
            treeNode173,
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Read and Write methods extended to read and write unindexed lines for 1D arrays");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Animate method added");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Fix for indent tab for non-paragraph rtf blocks");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode183});
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("ResetMaterial method added");
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("GetPosition method added");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode185,
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("RSA public private key methods added");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode178,
            treeNode180,
            treeNode182,
            treeNode184,
            treeNode187,
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode197,
            treeNode198,
            treeNode199,
            treeNode200,
            treeNode201,
            treeNode202,
            treeNode203,
            treeNode204,
            treeNode205,
            treeNode206});
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode208,
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode211,
            treeNode212,
            treeNode213,
            treeNode214});
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode192,
            treeNode194,
            treeNode196,
            treeNode207,
            treeNode210,
            treeNode215,
            treeNode217});
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode219});
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode221});
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode224,
            treeNode225,
            treeNode226,
            treeNode227});
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode229,
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode220,
            treeNode222,
            treeNode228,
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode235});
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode237});
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode234,
            treeNode236,
            treeNode238,
            treeNode240,
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode244,
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode249,
            treeNode250,
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode253});
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode255,
            treeNode256});
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode248,
            treeNode252,
            treeNode254,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode261,
            treeNode262,
            treeNode263,
            treeNode264,
            treeNode265,
            treeNode266});
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode270,
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode260,
            treeNode267,
            treeNode269,
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode274});
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode276});
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode280,
            treeNode281});
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode283,
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode275,
            treeNode277,
            treeNode279,
            treeNode282,
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode290,
            treeNode292,
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode296});
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode298,
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode301});
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode303,
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode308});
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode297,
            treeNode300,
            treeNode302,
            treeNode305,
            treeNode307,
            treeNode309});
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode311});
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode313,
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode318,
            treeNode319});
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode312,
            treeNode315,
            treeNode317,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode322,
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode324,
            treeNode326,
            treeNode328,
            treeNode330,
            treeNode332,
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode336,
            treeNode337,
            treeNode338});
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode340});
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode339,
            treeNode341,
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode345});
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode347});
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode349,
            treeNode350,
            treeNode351});
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode353,
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode346,
            treeNode348,
            treeNode352,
            treeNode355});
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode361});
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode358,
            treeNode360,
            treeNode362,
            treeNode364,
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode372,
            treeNode374,
            treeNode376,
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode381,
            treeNode383,
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode387});
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode389});
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode388,
            treeNode390,
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode394,
            treeNode395});
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode397,
            treeNode398,
            treeNode399,
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode396,
            treeNode401,
            treeNode403,
            treeNode405});
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode415});
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode408,
            treeNode410,
            treeNode412,
            treeNode414,
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode420});
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode419,
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode425});
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode424,
            treeNode426,
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode431});
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode433,
            treeNode434,
            treeNode435,
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode438,
            treeNode439});
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode441,
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode437,
            treeNode440,
            treeNode443,
            treeNode445});
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode447,
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode452});
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode449,
            treeNode451,
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode455,
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode457,
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode461,
            treeNode462,
            treeNode463,
            treeNode464,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode467,
            treeNode468,
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode473});
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode466,
            treeNode470,
            treeNode472,
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode478});
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode480});
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode484});
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode477,
            treeNode479,
            treeNode481,
            treeNode483,
            treeNode485,
            treeNode487,
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode491,
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode493,
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode499,
            treeNode500,
            treeNode501,
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode498,
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode505});
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode507,
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode510,
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode515});
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode506,
            treeNode509,
            treeNode512,
            treeNode514,
            treeNode516,
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode520,
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode527,
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode522,
            treeNode524,
            treeNode526,
            treeNode529,
            treeNode531,
            treeNode533,
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode540,
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode542,
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode546,
            treeNode547});
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode549});
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode548,
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode552,
            treeNode553,
            treeNode554,
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode557});
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode556,
            treeNode558,
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode564});
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode568});
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode563,
            treeNode565,
            treeNode567,
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode574,
            treeNode575});
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode577,
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode580});
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode582,
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode585});
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode576,
            treeNode579,
            treeNode581,
            treeNode584,
            treeNode586,
            treeNode588,
            treeNode590,
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode594,
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode596,
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode600});
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode605});
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode607,
            treeNode608,
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode604,
            treeNode606,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode614,
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode617});
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode613,
            treeNode616,
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode622,
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode621,
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode626});
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode628});
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode627,
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode631});
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode633,
            treeNode634});
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode632,
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode637});
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode640,
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode649,
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode642,
            treeNode644,
            treeNode646,
            treeNode648,
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode656});
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode657,
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode662,
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode669,
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode671,
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode675,
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode682,
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode684,
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode688,
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode696,
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode693,
            treeNode695,
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode702,
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode701,
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode706,
            treeNode707,
            treeNode708,
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode712});
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode719});
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode716,
            treeNode718,
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode723,
            treeNode725,
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode733,
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode730,
            treeNode732,
            treeNode735});
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode745,
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode744,
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode749,
            treeNode750,
            treeNode751});
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode754});
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode755,
            treeNode757,
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode762,
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode768,
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode767,
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode772});
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode777});
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode776,
            treeNode778,
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode782});
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode783,
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode787,
            treeNode788});
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode800,
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode791,
            treeNode793,
            treeNode795,
            treeNode797,
            treeNode799,
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode804,
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode806,
            treeNode808,
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode812});
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode813,
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode817,
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode820});
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode819,
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode826});
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode828,
            treeNode829,
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode827,
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode834});
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode838,
            treeNode839});
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode837,
            treeNode840,
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode850,
            treeNode851});
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode854,
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode879,
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode890});
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode895});
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode897});
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode892,
            treeNode894,
            treeNode896,
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode900});
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode902,
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode904,
            treeNode906});
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode909});
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode911});
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode908,
            treeNode910,
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode914});
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode916});
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode915,
            treeNode917});
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode919});
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode921});
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode920,
            treeNode922});
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode924});
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode925});
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode927});
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode930});
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode931});
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode933});
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode934});
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode937 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode938 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode936,
            treeNode937});
            System.Windows.Forms.TreeNode treeNode939 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode940 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode939});
            System.Windows.Forms.TreeNode treeNode941 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode938,
            treeNode940});
            System.Windows.Forms.TreeNode treeNode942 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode943 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode942});
            System.Windows.Forms.TreeNode treeNode944 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode943});
            System.Windows.Forms.TreeNode treeNode945 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode946 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode945});
            System.Windows.Forms.TreeNode treeNode947 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode946});
            System.Windows.Forms.TreeNode treeNode948 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode949 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode948});
            System.Windows.Forms.TreeNode treeNode950 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode949});
            System.Windows.Forms.TreeNode treeNode951 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode952 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode953 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode951,
            treeNode952});
            System.Windows.Forms.TreeNode treeNode954 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode955 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode954});
            System.Windows.Forms.TreeNode treeNode956 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode957 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode958 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode956,
            treeNode957});
            System.Windows.Forms.TreeNode treeNode959 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode953,
            treeNode955,
            treeNode958});
            System.Windows.Forms.TreeNode treeNode960 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode961 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode960});
            System.Windows.Forms.TreeNode treeNode962 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode961});
            System.Windows.Forms.TreeNode treeNode963 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode964 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode963});
            System.Windows.Forms.TreeNode treeNode965 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode964});
            System.Windows.Forms.TreeNode treeNode966 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode967 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode968 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode966,
            treeNode967});
            System.Windows.Forms.TreeNode treeNode969 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode968});
            System.Windows.Forms.TreeNode treeNode970 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode971 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode972 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode973 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode970,
            treeNode971,
            treeNode972});
            System.Windows.Forms.TreeNode treeNode974 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode975 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode974});
            System.Windows.Forms.TreeNode treeNode976 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode977 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode976});
            System.Windows.Forms.TreeNode treeNode978 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode973,
            treeNode975,
            treeNode977});
            System.Windows.Forms.TreeNode treeNode979 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode980 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode981 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode979,
            treeNode980});
            System.Windows.Forms.TreeNode treeNode982 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode983 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode982});
            System.Windows.Forms.TreeNode treeNode984 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode981,
            treeNode983});
            System.Windows.Forms.TreeNode treeNode985 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode986 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode985});
            System.Windows.Forms.TreeNode treeNode987 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode988 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode987});
            System.Windows.Forms.TreeNode treeNode989 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode986,
            treeNode988});
            System.Windows.Forms.TreeNode treeNode990 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode991 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode990});
            System.Windows.Forms.TreeNode treeNode992 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode993 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode992});
            System.Windows.Forms.TreeNode treeNode994 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode995 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode994});
            System.Windows.Forms.TreeNode treeNode996 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode997 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode996});
            System.Windows.Forms.TreeNode treeNode998 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode991,
            treeNode993,
            treeNode995,
            treeNode997});
            System.Windows.Forms.TreeNode treeNode999 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode1000 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode999});
            System.Windows.Forms.TreeNode treeNode1001 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode1000});
            System.Windows.Forms.TreeNode treeNode1002 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode1003 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1002});
            System.Windows.Forms.TreeNode treeNode1004 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode1003});
            System.Windows.Forms.TreeNode treeNode1005 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode1006 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1005});
            System.Windows.Forms.TreeNode treeNode1007 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode1008 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1007});
            System.Windows.Forms.TreeNode treeNode1009 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode1006,
            treeNode1008});
            System.Windows.Forms.TreeNode treeNode1010 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode1011 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1010});
            System.Windows.Forms.TreeNode treeNode1012 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode1013 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1012});
            System.Windows.Forms.TreeNode treeNode1014 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode1011,
            treeNode1013});
            System.Windows.Forms.TreeNode treeNode1015 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode1016 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode1015});
            System.Windows.Forms.TreeNode treeNode1017 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode1016});
            System.Windows.Forms.TreeNode treeNode1018 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode1019 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1018});
            System.Windows.Forms.TreeNode treeNode1020 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode1019});
            System.Windows.Forms.TreeNode treeNode1021 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode1022 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode1021});
            System.Windows.Forms.TreeNode treeNode1023 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode1022});
            System.Windows.Forms.TreeNode treeNode1024 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode1025 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode1024});
            System.Windows.Forms.TreeNode treeNode1026 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode1027 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode1028 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode1029 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1026,
            treeNode1027,
            treeNode1028});
            System.Windows.Forms.TreeNode treeNode1030 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode1025,
            treeNode1029});
            System.Windows.Forms.TreeNode treeNode1031 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode1032 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1031});
            System.Windows.Forms.TreeNode treeNode1033 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode1034 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode1033});
            System.Windows.Forms.TreeNode treeNode1035 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode1032,
            treeNode1034});
            System.Windows.Forms.TreeNode treeNode1036 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode1037 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1036});
            System.Windows.Forms.TreeNode treeNode1038 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode1039 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1038});
            System.Windows.Forms.TreeNode treeNode1040 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode1037,
            treeNode1039});
            System.Windows.Forms.TreeNode treeNode1041 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode1042 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1041});
            System.Windows.Forms.TreeNode treeNode1043 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode1044 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode1043});
            System.Windows.Forms.TreeNode treeNode1045 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode1046 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode1045});
            System.Windows.Forms.TreeNode treeNode1047 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode1042,
            treeNode1044,
            treeNode1046});
            System.Windows.Forms.TreeNode treeNode1048 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode1049 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1048});
            System.Windows.Forms.TreeNode treeNode1050 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode1049});
            System.Windows.Forms.TreeNode treeNode1051 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode1052 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1051});
            System.Windows.Forms.TreeNode treeNode1053 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode1054 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode1053});
            System.Windows.Forms.TreeNode treeNode1055 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode1056 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode1057 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1055,
            treeNode1056});
            System.Windows.Forms.TreeNode treeNode1058 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode1052,
            treeNode1054,
            treeNode1057});
            System.Windows.Forms.TreeNode treeNode1059 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode1060 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1059});
            System.Windows.Forms.TreeNode treeNode1061 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode1062 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode1061});
            System.Windows.Forms.TreeNode treeNode1063 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode1060,
            treeNode1062});
            System.Windows.Forms.TreeNode treeNode1064 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode1065 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode1064});
            System.Windows.Forms.TreeNode treeNode1066 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode1065});
            System.Windows.Forms.TreeNode treeNode1067 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode1068 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1067});
            System.Windows.Forms.TreeNode treeNode1069 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode1068});
            System.Windows.Forms.TreeNode treeNode1070 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode1071 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode1070});
            System.Windows.Forms.TreeNode treeNode1072 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode1071});
            System.Windows.Forms.TreeNode treeNode1073 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode1074 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1073});
            System.Windows.Forms.TreeNode treeNode1075 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode1074});
            System.Windows.Forms.TreeNode treeNode1076 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode1077 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1076});
            System.Windows.Forms.TreeNode treeNode1078 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode1079 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode1080 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode1078,
            treeNode1079});
            System.Windows.Forms.TreeNode treeNode1081 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode1077,
            treeNode1080});
            System.Windows.Forms.TreeNode treeNode1082 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode1083 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1082});
            System.Windows.Forms.TreeNode treeNode1084 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode1085 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode1084});
            System.Windows.Forms.TreeNode treeNode1086 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode1083,
            treeNode1085});
            System.Windows.Forms.TreeNode treeNode1087 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode1088 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1087});
            System.Windows.Forms.TreeNode treeNode1089 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode1090 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode1091 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode1089,
            treeNode1090});
            System.Windows.Forms.TreeNode treeNode1092 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode1088,
            treeNode1091});
            System.Windows.Forms.TreeNode treeNode1093 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode1094 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode1093});
            System.Windows.Forms.TreeNode treeNode1095 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode1094});
            System.Windows.Forms.TreeNode treeNode1096 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode1097 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1096});
            System.Windows.Forms.TreeNode treeNode1098 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode1097});
            System.Windows.Forms.TreeNode treeNode1099 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode1100 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode1099});
            System.Windows.Forms.TreeNode treeNode1101 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode1100});
            System.Windows.Forms.TreeNode treeNode1102 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode1103 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode1104 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode1105 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode1102,
            treeNode1103,
            treeNode1104});
            System.Windows.Forms.TreeNode treeNode1106 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode1107 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode1106});
            System.Windows.Forms.TreeNode treeNode1108 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode1109 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode1110 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode1108,
            treeNode1109});
            System.Windows.Forms.TreeNode treeNode1111 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode1112 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode1111});
            System.Windows.Forms.TreeNode treeNode1113 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode1105,
            treeNode1107,
            treeNode1110,
            treeNode1112});
            System.Windows.Forms.TreeNode treeNode1114 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode1115 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode1116 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode1114,
            treeNode1115});
            System.Windows.Forms.TreeNode treeNode1117 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode1118 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode1119 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode1120 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode1117,
            treeNode1118,
            treeNode1119});
            System.Windows.Forms.TreeNode treeNode1121 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode1122 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode1121});
            System.Windows.Forms.TreeNode treeNode1123 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode1116,
            treeNode1120,
            treeNode1122});
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
            treeNode2.Name = "Node1";
            treeNode2.Text = "CaptureScreen method added";
            treeNode3.Name = "Node2";
            treeNode3.Text = "FindImageInImage method added";
            treeNode4.Name = "Node0";
            treeNode4.Text = "GetTextFromImage method added";
            treeNode5.Name = "Node0";
            treeNode5.Text = "LDImage";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Version 1.2.29.6";
            treeNode7.Name = "Node1";
            treeNode7.Text = "GetCollisions returns chain/rope name";
            treeNode8.Name = "Node0";
            treeNode8.Text = "GetAcceleration method added";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Fix for chains and ropes with non default scaling";
            treeNode10.Name = "Node0";
            treeNode10.Text = "LDPhysics";
            treeNode11.Name = "Node1";
            treeNode11.Text = "SaveAllVariables and LoadAllVariables modified to handle LF,CR";
            treeNode12.Name = "Node0";
            treeNode12.Text = "LDFile";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Angle method added";
            treeNode14.Name = "Node0";
            treeNode14.Text = "TextAlignment method added";
            treeNode15.Name = "Node0";
            treeNode15.Text = "LDShapes";
            treeNode16.Name = "Node0";
            treeNode16.Text = "Version 1.2.29.0";
            treeNode17.Name = "Node2";
            treeNode17.Text = "Increase default AABB for larger display";
            treeNode18.Name = "Node1";
            treeNode18.Text = "LDPhysics";
            treeNode19.Name = "Node1";
            treeNode19.Text = "UpdateShowHide property and Minimise method added.  Show and Hide methods updated" +
    "";
            treeNode20.Name = "Node0";
            treeNode20.Text = "Exit event added";
            treeNode21.Name = "Node0";
            treeNode21.Text = "LDTextWindow";
            treeNode22.Name = "Node1";
            treeNode22.Text = "DataViewFont method added";
            treeNode23.Name = "Node0";
            treeNode23.Text = "LDControls";
            treeNode24.Name = "Node1";
            treeNode24.Text = "CallIncludeWithVars method added";
            treeNode25.Name = "Node0";
            treeNode25.Text = "LDCall";
            treeNode26.Name = "Node0";
            treeNode26.Text = "GetOriginPosition method added";
            treeNode27.Name = "Node0";
            treeNode27.Text = "Allow longer duration animations";
            treeNode28.Name = "Node1";
            treeNode28.Text = "LoadModel ignore bad objects";
            treeNode29.Name = "Node0";
            treeNode29.Text = "GetOffset method added";
            treeNode30.Name = "Node0";
            treeNode30.Text = "WSAD keys for AutoControl only active if GW active";
            treeNode31.Name = "Node0";
            treeNode31.Text = "LD3DView";
            treeNode32.Name = "Node1";
            treeNode32.Text = "Query updated to be similar to LDControls method";
            treeNode33.Name = "Node2";
            treeNode33.Text = "Improved so that listview can use LDControls methods";
            treeNode34.Name = "Node0";
            treeNode34.Text = "LDDataBase";
            treeNode35.Name = "Node1";
            treeNode35.Text = "CreateSpline and InterpolateSpline methods added";
            treeNode36.Name = "Node0";
            treeNode36.Text = "MathX";
            treeNode37.Name = "Node0";
            treeNode37.Text = "Version 1.2.28.0";
            treeNode38.Name = "Node3";
            treeNode38.Text = "RichTextBoxWord method extended";
            treeNode39.Name = "Node4";
            treeNode39.Text = "TextBoxSelection method added";
            treeNode40.Name = "Node0";
            treeNode40.Text = "RichTextBoxSelectionChanged event added";
            treeNode41.Name = "Node1";
            treeNode41.Text = "RichLastTextBoxSelection property added";
            treeNode42.Name = "Node0";
            treeNode42.Text = "RichTextBoxMousePosition method added";
            treeNode43.Name = "Node0";
            treeNode43.Text = "RichTextBoxCaretPosition method added";
            treeNode44.Name = "Node0";
            treeNode44.Text = "RichTextBoxCaretCoordinates method added";
            treeNode45.Name = "Node0";
            treeNode45.Text = "RichTextBoxWholeWord property added";
            treeNode46.Name = "Node1";
            treeNode46.Text = "RichTextBoxInsert method added";
            treeNode47.Name = "Node0";
            treeNode47.Text = "GetAllShapesAt updated to handle RTB";
            treeNode48.Name = "Node0";
            treeNode48.Text = "LDControls";
            treeNode49.Name = "Node1";
            treeNode49.Text = "Compiler property added";
            treeNode50.Name = "Node0";
            treeNode50.Text = "LDCall";
            treeNode51.Name = "Node1";
            treeNode51.Text = "GW and TW aliases added";
            treeNode52.Name = "Node0";
            treeNode52.Text = "Aliases";
            treeNode53.Name = "Node1";
            treeNode53.Text = "LF, CR, SQ, DQ, BS special characters added";
            treeNode54.Name = "Node0";
            treeNode54.Text = "LDText";
            treeNode55.Name = "Node1";
            treeNode55.Text = "InputBox method added";
            treeNode56.Name = "Node0";
            treeNode56.Text = "LDDialogs";
            treeNode57.Name = "Node1";
            treeNode57.Text = "TurtleSpeed property added";
            treeNode58.Name = "Node0";
            treeNode58.Text = "LDShapes";
            treeNode59.Name = "Node2";
            treeNode59.Text = "Version 1.2.27.0";
            treeNode60.Name = "Node1";
            treeNode60.Text = "Update API";
            treeNode61.Name = "Node0";
            treeNode61.Text = "LDTranslate";
            treeNode62.Name = "Node1";
            treeNode62.Text = "LoadImage replacement for Imagelist method that can download Flickr images";
            treeNode63.Name = "Node0";
            treeNode63.Text = "LDImage";
            treeNode64.Name = "Node1";
            treeNode64.Text = "Update HelixToolkit";
            treeNode65.Name = "Node2";
            treeNode65.Text = "AddIcosahedron, AddDodecahedron, AddEllipsoid, AddOctahedron, AddTorus , AddMater" +
    "ial methods added";
            treeNode66.Name = "Node0";
            treeNode66.Text = "AddBackImage bug fixed";
            treeNode67.Name = "Node0";
            treeNode67.Text = "LD3DView";
            treeNode68.Name = "Node1";
            treeNode68.Text = "Performance improvement for \'sleeping\' shapes";
            treeNode69.Name = "Node0";
            treeNode69.Text = "LDPhysics";
            treeNode70.Name = "Node1";
            treeNode70.Text = "Updated intellisense";
            treeNode71.Name = "Node0";
            treeNode71.Text = "LDFinances";
            treeNode72.Name = "Node0";
            treeNode72.Text = "Version 1.2.26.0";
            treeNode73.Name = "Node1";
            treeNode73.Text = "Network Security Protocol fixes (SSL)";
            treeNode74.Name = "Node3";
            treeNode74.Text = "SetSSL method added";
            treeNode75.Name = "Node2";
            treeNode75.Text = "LDNetwork";
            treeNode76.Name = "Node1";
            treeNode76.Text = "FixFlickr updates for new api key";
            treeNode77.Name = "Node0";
            treeNode77.Text = "LDUtilities";
            treeNode78.Name = "Node0";
            treeNode78.Text = "Separate download required";
            treeNode79.Name = "Node0";
            treeNode79.Text = "SmallVisualBasic (sVB) support";
            treeNode80.Name = "Node0";
            treeNode80.Text = "Version 1.2.25.0";
            treeNode81.Name = "Node1";
            treeNode81.Text = "Reinstated website";
            treeNode82.Name = "Node0";
            treeNode82.Text = "Version 1.2.24.0";
            treeNode83.Name = "Node2";
            treeNode83.Text = "API updated to MS Cognitive";
            treeNode84.Name = "Node1";
            treeNode84.Text = "LDTranslate";
            treeNode85.Name = "Node1";
            treeNode85.Text = "CaptureScreen method added";
            treeNode86.Name = "Node0";
            treeNode86.Text = "LDUtilities";
            treeNode87.Name = "Node1";
            treeNode87.Text = "Fix for ListFiles";
            treeNode88.Name = "Node0";
            treeNode88.Text = "LDftp";
            treeNode89.Name = "Node1";
            treeNode89.Text = "WriteFromArray method added";
            treeNode90.Name = "Node0";
            treeNode90.Text = "LDFile";
            treeNode91.Name = "Node1";
            treeNode91.Text = "Object added (code by Abhishek Sathiabalan)";
            treeNode92.Name = "Node0";
            treeNode92.Text = "LDFinances";
            treeNode93.Name = "Node1";
            treeNode93.Text = "Suppress javascript popup error messages";
            treeNode94.Name = "Node0";
            treeNode94.Text = "LDControls";
            treeNode95.Name = "Node0";
            treeNode95.Text = "Version 1.2.23.0";
            treeNode96.Name = "Node3";
            treeNode96.Text = "SaveTableBySQL method added";
            treeNode97.Name = "Node2";
            treeNode97.Text = "LDDataBase";
            treeNode98.Name = "Node1";
            treeNode98.Text = "Object added by Abhishek Sathiabalan";
            treeNode99.Name = "Node0";
            treeNode99.Text = "LDFinances";
            treeNode100.Name = "Node1";
            treeNode100.Text = "Version 1.2.24.0";
            treeNode101.Name = "Node1";
            treeNode101.Text = "LDHashTable object added (code from Abhishek Sathiabalan)";
            treeNode102.Name = "Node2";
            treeNode102.Text = "Some Nuget packages used (suggested by Abhishek Sathiabalan)";
            treeNode103.Name = "Node0";
            treeNode103.Text = "Various performance improvements (code from Abhishek Sathiabalan)";
            treeNode104.Name = "Node0";
            treeNode104.Text = "LDGeography (code from Abhishek Sathiabalan)";
            treeNode105.Name = "Node1";
            treeNode105.Text = "AvailableCultures method added";
            treeNode106.Name = "Node0";
            treeNode106.Text = "FixFlickr updated for API change";
            treeNode107.Name = "Node0";
            treeNode107.Text = "LDUtilities";
            treeNode108.Name = "Node0";
            treeNode108.Text = "Version 1.2.22.0";
            treeNode109.Name = "Node2";
            treeNode109.Text = "GetImage method improved to fix thread issue";
            treeNode110.Name = "Node1";
            treeNode110.Text = "LDClipboard";
            treeNode111.Name = "Node1";
            treeNode111.Text = "ReadByteArray and WriteByteArray methods added";
            treeNode112.Name = "Node0";
            treeNode112.Text = "LDFile";
            treeNode113.Name = "Node1";
            treeNode113.Text = "RenameRoot method added";
            treeNode114.Name = "Node0";
            treeNode114.Text = "View method added";
            treeNode115.Name = "Node0";
            treeNode115.Text = "LDXML";
            treeNode116.Name = "Node1";
            treeNode116.Text = "Update to Azure";
            treeNode117.Name = "Node0";
            treeNode117.Text = "LDSearch";
            treeNode118.Name = "Node1";
            treeNode118.Text = "Volume and Pan properties added";
            treeNode119.Name = "Node0";
            treeNode119.Text = "LDMusic";
            treeNode120.Name = "Node0";
            treeNode120.Text = "Version 1.2.21.0";
            treeNode121.Name = "Node2";
            treeNode121.Text = "Correctly handles pie segments greater than 180 degrees";
            treeNode122.Name = "Node1";
            treeNode122.Text = "LDChart";
            treeNode123.Name = "Node1";
            treeNode123.Text = "Decimal2Base works for number 0 in all bases";
            treeNode124.Name = "Node0";
            treeNode124.Text = "LDMath";
            treeNode125.Name = "Node1";
            treeNode125.Text = "Updated currency API";
            treeNode126.Name = "Node0";
            treeNode126.Text = "LDUnits";
            treeNode127.Name = "Node0";
            treeNode127.Text = "Version 1.2.20.0";
            treeNode128.Name = "Node1";
            treeNode128.Text = "Fix for ReSize for some controls";
            treeNode129.Name = "Node2";
            treeNode129.Text = "Fix for GetLeft and GetTop for shapes that have not been positioned yet";
            treeNode130.Name = "Node0";
            treeNode130.Text = "LDShapes";
            treeNode131.Name = "Node4";
            treeNode131.Text = "AddPyramid shape fixed";
            treeNode132.Name = "Node3";
            treeNode132.Text = "LD3DView";
            treeNode133.Name = "Node3";
            treeNode133.Text = "New object to create icons and cursors added";
            treeNode134.Name = "Node2";
            treeNode134.Text = "LDIcon";
            treeNode135.Name = "Node1";
            treeNode135.Text = "Fix for View (non-modal)";
            treeNode136.Name = "Node0";
            treeNode136.Text = "LDMatrix";
            treeNode137.Name = "Node0";
            treeNode137.Text = "Version 1.2.19.0";
            treeNode138.Name = "Node1";
            treeNode138.Text = "SetBackMaterial and AddBackImage methods added";
            treeNode139.Name = "Node0";
            treeNode139.Text = "LD3DView";
            treeNode140.Name = "Node1";
            treeNode140.Text = "Version 1.2.18.0";
            treeNode141.Name = "Node2";
            treeNode141.Text = "Fast text appending method added";
            treeNode142.Name = "Node1";
            treeNode142.Text = "LDText";
            treeNode143.Name = "Node5";
            treeNode143.Text = "Potential performance improvements";
            treeNode144.Name = "Node4";
            treeNode144.Text = "LDFile";
            treeNode145.Name = "Node7";
            treeNode145.Text = "Potential performance improvements";
            treeNode146.Name = "Node6";
            treeNode146.Text = "LDDatabase";
            treeNode147.Name = "Node9";
            treeNode147.Text = "Potential performance improvements";
            treeNode148.Name = "Node8";
            treeNode148.Text = "LDArray";
            treeNode149.Name = "Node1";
            treeNode149.Text = "Volume method added";
            treeNode150.Name = "Node0";
            treeNode150.Text = "LDSound";
            treeNode151.Name = "Node1";
            treeNode151.Text = "Modified to use Google API since MS version is depreciated";
            treeNode152.Name = "Node0";
            treeNode152.Text = "LDTranslate";
            treeNode153.Name = "Node1";
            treeNode153.Text = "FloodFillTolerance property added";
            treeNode154.Name = "Node0";
            treeNode154.Text = "LDGraphicsWindow";
            treeNode155.Name = "Node1";
            treeNode155.Text = "And and Or renamed And_ and Or_";
            treeNode156.Name = "Node0";
            treeNode156.Text = "LDLogic";
            treeNode157.Name = "Node1";
            treeNode157.Text = "SendClick method added";
            treeNode158.Name = "Node0";
            treeNode158.Text = "LDUtilities";
            treeNode159.Name = "Node0";
            treeNode159.Text = "Version 1.2.17.0";
            treeNode160.Name = "Node2";
            treeNode160.Text = "SHA512HashFile method added";
            treeNode161.Name = "Node1";
            treeNode161.Text = "LDEncryption";
            treeNode162.Name = "Node1";
            treeNode162.Text = "Broadcast method added";
            treeNode163.Name = "Node0";
            treeNode163.Text = "LDServer";
            treeNode164.Name = "Node1";
            treeNode164.Text = "AutoControl2 scene camera mode added (for model inspection)";
            treeNode165.Name = "Node0";
            treeNode165.Text = "Various auto control improvements";
            treeNode166.Name = "Node7";
            treeNode166.Text = "SwapUpDirection method added";
            treeNode167.Name = "Node0";
            treeNode167.Text = "LD3DView";
            treeNode168.Name = "Node4";
            treeNode168.Text = "Improved PauseUpdates and ResumeUpdates";
            treeNode169.Name = "Node3";
            treeNode169.Text = "LDGraphicsWIndow";
            treeNode170.Name = "Node6";
            treeNode170.Text = "3D vector algebra methods added";
            treeNode171.Name = "Node5";
            treeNode171.Text = "LDVector";
            treeNode172.Name = "Node1";
            treeNode172.Text = "LastListViewColumn event property added";
            treeNode173.Name = "Node0";
            treeNode173.Text = "LDControls";
            treeNode174.Name = "Node3";
            treeNode174.Text = "ListView subscribes to LDControls selection events";
            treeNode175.Name = "Node2";
            treeNode175.Text = "LDDatabase";
            treeNode176.Name = "Node0";
            treeNode176.Text = "Version 1.2.16.0";
            treeNode177.Name = "Node1";
            treeNode177.Text = "Read and Write methods extended to read and write unindexed lines for 1D arrays";
            treeNode178.Name = "Node0";
            treeNode178.Text = "LDFastArray";
            treeNode179.Name = "Node3";
            treeNode179.Text = "Animate method added";
            treeNode180.Name = "Node2";
            treeNode180.Text = "LDGraphicsWindow";
            treeNode181.Name = "Node1";
            treeNode181.Text = "Fix for indent tab for non-paragraph rtf blocks";
            treeNode182.Name = "Node0";
            treeNode182.Text = "LDControls";
            treeNode183.Name = "Node3";
            treeNode183.Text = "Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated";
            treeNode184.Name = "Node2";
            treeNode184.Text = "LDTextWindow";
            treeNode185.Name = "Node1";
            treeNode185.Text = "ResetMaterial method added";
            treeNode186.Name = "Node2";
            treeNode186.Text = "GetPosition method added";
            treeNode187.Name = "Node0";
            treeNode187.Text = "LD3DView";
            treeNode188.Name = "Node1";
            treeNode188.Text = "RSA public private key methods added";
            treeNode189.Name = "Node0";
            treeNode189.Text = "LDEncryption";
            treeNode190.Name = "Node0";
            treeNode190.Text = "Version 1.2.15.0";
            treeNode191.Name = "Node2";
            treeNode191.Text = "Possible unclosed zip conflicts fixed";
            treeNode192.Name = "Node1";
            treeNode192.Text = "LDZip";
            treeNode193.Name = "Node5";
            treeNode193.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode194.Name = "Node3";
            treeNode194.Text = "LDStopwatch";
            treeNode195.Name = "Node7";
            treeNode195.Text = "LDTimer object added for additional timers";
            treeNode196.Name = "Node6";
            treeNode196.Text = "LDTimer";
            treeNode197.Name = "Node1";
            treeNode197.Text = "Speedup of selected critical performance code listed below";
            treeNode198.Name = "Node2";
            treeNode198.Text = "1) LDShapes.FastMove";
            treeNode199.Name = "Node3";
            treeNode199.Text = "2) LDPhysics graphical updates";
            treeNode200.Name = "Node4";
            treeNode200.Text = "3) LDImage and LDwebCam image processing";
            treeNode201.Name = "Node6";
            treeNode201.Text = "4) LDFastShapes";
            treeNode202.Name = "Node7";
            treeNode202.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode203.Name = "Node8";
            treeNode203.Text = "6) Selected LD3DView visual updates";
            treeNode204.Name = "Node9";
            treeNode204.Text = "7) LDEffect";
            treeNode205.Name = "Node10";
            treeNode205.Text = "8) LDGraph";
            treeNode206.Name = "Node11";
            treeNode206.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode207.Name = "Node0";
            treeNode207.Text = "General";
            treeNode208.Name = "Node1";
            treeNode208.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode209.Name = "Node2";
            treeNode209.Text = "CSV file read and write";
            treeNode210.Name = "Node0";
            treeNode210.Text = "LDFastArray";
            treeNode211.Name = "Node1";
            treeNode211.Text = "DataViewColAlignment method added";
            treeNode212.Name = "Node2";
            treeNode212.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode213.Name = "Node0";
            treeNode213.Text = "RichTextBoxTextTyped event added";
            treeNode214.Name = "Node1";
            treeNode214.Text = "RichTextBoxIndentToTab property added";
            treeNode215.Name = "Node0";
            treeNode215.Text = "LDControls";
            treeNode216.Name = "Node4";
            treeNode216.Text = "OverlapDetail property added";
            treeNode217.Name = "Node3";
            treeNode217.Text = "LDShapes";
            treeNode218.Name = "Node0";
            treeNode218.Text = "Version 1.2.14.0";
            treeNode219.Name = "Node2";
            treeNode219.Text = "TEMP tables allowed for SQLite databases";
            treeNode220.Name = "Node1";
            treeNode220.Text = "LDDataBase";
            treeNode221.Name = "Node1";
            treeNode221.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode222.Name = "Node0";
            treeNode222.Text = "LDMath";
            treeNode223.Name = "Node1";
            treeNode223.Text = "NormalMap method added for normal map 3D effects";
            treeNode224.Name = "Node2";
            treeNode224.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode225.Name = "Node5";
            treeNode225.Text = "MakeTransparent method added";
            treeNode226.Name = "Node6";
            treeNode226.Text = "ReplaceColour method added";
            treeNode227.Name = "Node0";
            treeNode227.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode228.Name = "Node0";
            treeNode228.Text = "LDImage";
            treeNode229.Name = "Node4";
            treeNode229.Text = "All image pixel manipulations speeded up";
            treeNode230.Name = "Node7";
            treeNode230.Text = "More Culture Invariace fixes";
            treeNode231.Name = "Node3";
            treeNode231.Text = "General";
            treeNode232.Name = "Node0";
            treeNode232.Text = "Version 1.2.13.0";
            treeNode233.Name = "Node1";
            treeNode233.Text = "Base conversions extended to include bases up to 36";
            treeNode234.Name = "Node0";
            treeNode234.Text = "LDMath";
            treeNode235.Name = "Node3";
            treeNode235.Text = "Updated to new Bing API";
            treeNode236.Name = "Node2";
            treeNode236.Text = "LDSearch";
            treeNode237.Name = "Node1";
            treeNode237.Text = "ShowInTaskbar property added";
            treeNode238.Name = "Node0";
            treeNode238.Text = "LDGraphicsWindow";
            treeNode239.Name = "Node1";
            treeNode239.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode240.Name = "Node0";
            treeNode240.Text = "LDFile";
            treeNode241.Name = "Node1";
            treeNode241.Text = "ToArray and FromArray methods added";
            treeNode242.Name = "Node0";
            treeNode242.Text = "LDxml";
            treeNode243.Name = "Node0";
            treeNode243.Text = "Version 1.2.12.0";
            treeNode244.Name = "Node2";
            treeNode244.Text = "DataViewColumnWidths method added";
            treeNode245.Name = "Node3";
            treeNode245.Text = "DataViewRowColours method added";
            treeNode246.Name = "Node1";
            treeNode246.Text = "LDControls";
            treeNode247.Name = "Node1";
            treeNode247.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode248.Name = "Node0";
            treeNode248.Text = "General";
            treeNode249.Name = "Node1";
            treeNode249.Text = "SetCentre method added";
            treeNode250.Name = "Node4";
            treeNode250.Text = "A 3rd rotation added";
            treeNode251.Name = "Node3";
            treeNode251.Text = "BoundingBox method added";
            treeNode252.Name = "Node0";
            treeNode252.Text = "LD3DView";
            treeNode253.Name = "Node3";
            treeNode253.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode254.Name = "Node2";
            treeNode254.Text = "LDDatabase";
            treeNode255.Name = "Node1";
            treeNode255.Text = "PlayMusic2 method added";
            treeNode256.Name = "Node2";
            treeNode256.Text = "Channel parameter added";
            treeNode257.Name = "Node0";
            treeNode257.Text = "LDMusic";
            treeNode258.Name = "Node0";
            treeNode258.Text = "Version 1.2.11.0";
            treeNode259.Name = "Node1";
            treeNode259.Text = "SetButtonStyle method added";
            treeNode260.Name = "Node0";
            treeNode260.Text = "LDControls";
            treeNode261.Name = "Node1";
            treeNode261.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode262.Name = "Node2";
            treeNode262.Text = "SetBillBoard method added";
            treeNode263.Name = "Node0";
            treeNode263.Text = "GetCameraUpDirection method added";
            treeNode264.Name = "Node1";
            treeNode264.Text = "Gradient brushes can be used";
            treeNode265.Name = "Node2";
            treeNode265.Text = "AutoControl method added";
            treeNode266.Name = "Node0";
            treeNode266.Text = "SpecularExponent property added";
            treeNode267.Name = "Node0";
            treeNode267.Text = "LD3DView";
            treeNode268.Name = "Node1";
            treeNode268.Text = "AddText method to annotate an image with text added";
            treeNode269.Name = "Node0";
            treeNode269.Text = "LDImage";
            treeNode270.Name = "Node4";
            treeNode270.Text = "BrushText for text on a brush added";
            treeNode271.Name = "Node0";
            treeNode271.Text = "Skew shapes method added";
            treeNode272.Name = "Node3";
            treeNode272.Text = "LDShapes";
            treeNode273.Name = "Node0";
            treeNode273.Text = "Version 1.2.10.0";
            treeNode274.Name = "Node1";
            treeNode274.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode275.Name = "Node0";
            treeNode275.Text = "LDUnits";
            treeNode276.Name = "Node1";
            treeNode276.Text = "Possible issue with FixSigFig fixed";
            treeNode277.Name = "Node0";
            treeNode277.Text = "LDMath";
            treeNode278.Name = "Node3";
            treeNode278.Text = "GetIndex method added (for SB arrays)";
            treeNode279.Name = "Node2";
            treeNode279.Text = "LDArray";
            treeNode280.Name = "Node5";
            treeNode280.Text = "Resize mode property added";
            treeNode281.Name = "Node6";
            treeNode281.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode282.Name = "Node4";
            treeNode282.Text = "LDGraphicsWindow";
            treeNode283.Name = "Node8";
            treeNode283.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode284.Name = "Node9";
            treeNode284.Text = "DataViewAllowUserEntry method added";
            treeNode285.Name = "Node7";
            treeNode285.Text = "LDControls";
            treeNode286.Name = "Node0";
            treeNode286.Text = "Version 1.2.9.0";
            treeNode287.Name = "Node1";
            treeNode287.Text = "New extended math object, starting with FFT";
            treeNode288.Name = "Node0";
            treeNode288.Text = "LDMathX";
            treeNode289.Name = "Node1";
            treeNode289.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode290.Name = "Node0";
            treeNode290.Text = "LDControls";
            treeNode291.Name = "Node3";
            treeNode291.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode292.Name = "Node2";
            treeNode292.Text = "LDArray";
            treeNode293.Name = "Node5";
            treeNode293.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode294.Name = "Node4";
            treeNode294.Text = "LDList";
            treeNode295.Name = "Node0";
            treeNode295.Text = "Version 1.2.8.0";
            treeNode296.Name = "Node2";
            treeNode296.Text = "Error handling, additional settings and multiple ports supported";
            treeNode297.Name = "Node1";
            treeNode297.Text = "LDCommPort";
            treeNode298.Name = "Node1";
            treeNode298.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode299.Name = "Node1";
            treeNode299.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode300.Name = "Node0";
            treeNode300.Text = "LDImage and LDWebCam";
            treeNode301.Name = "Node1";
            treeNode301.Text = "Bitwise operations object added";
            treeNode302.Name = "Node0";
            treeNode302.Text = "LDBits";
            treeNode303.Name = "Node1";
            treeNode303.Text = "Extended text encoding property added";
            treeNode304.Name = "Node0";
            treeNode304.Text = "TextWindow colours can be changed";
            treeNode305.Name = "Node0";
            treeNode305.Text = "LDTextWindow";
            treeNode306.Name = "Node1";
            treeNode306.Text = "GetWorkingImagePixelARGB method added";
            treeNode307.Name = "Node0";
            treeNode307.Text = "LDImage";
            treeNode308.Name = "Node1";
            treeNode308.Text = "RasteriseTurtleLines method added";
            treeNode309.Name = "Node0";
            treeNode309.Text = "LDShapes";
            treeNode310.Name = "Node0";
            treeNode310.Text = "Version 1.2.7.0";
            treeNode311.Name = "Node1";
            treeNode311.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode312.Name = "Node0";
            treeNode312.Text = "LDDialogs";
            treeNode313.Name = "Node1";
            treeNode313.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode314.Name = "Node2";
            treeNode314.Text = "ToggleSensor added";
            treeNode315.Name = "Node0";
            treeNode315.Text = "LDPhysics";
            treeNode316.Name = "Node1";
            treeNode316.Text = "Allow multiple copies of the webcam image";
            treeNode317.Name = "Node0";
            treeNode317.Text = "LDWebCam";
            treeNode318.Name = "Node1";
            treeNode318.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode319.Name = "Node0";
            treeNode319.Text = "MetaData method added";
            treeNode320.Name = "Node0";
            treeNode320.Text = "LDImage";
            treeNode321.Name = "Node0";
            treeNode321.Text = "Version 1.2.6.0";
            treeNode322.Name = "Node2";
            treeNode322.Text = "FixSigFig and FixDecimal methods added";
            treeNode323.Name = "Node3";
            treeNode323.Text = "MinNumber and MaxNumber properties added";
            treeNode324.Name = "Node1";
            treeNode324.Text = "LDMath";
            treeNode325.Name = "Node1";
            treeNode325.Text = "SliderMaximum property added";
            treeNode326.Name = "Node0";
            treeNode326.Text = "LDControls";
            treeNode327.Name = "Node1";
            treeNode327.Text = "ZoomAll method added";
            treeNode328.Name = "Node0";
            treeNode328.Text = "LDShapes";
            treeNode329.Name = "Node1";
            treeNode329.Text = "Reposition methods and properties added";
            treeNode330.Name = "Node0";
            treeNode330.Text = "LDGraphicsWindow";
            treeNode331.Name = "Node1";
            treeNode331.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode332.Name = "Node0";
            treeNode332.Text = "LDImage";
            treeNode333.Name = "Node1";
            treeNode333.Text = "MouseScroll parameter added";
            treeNode334.Name = "Node0";
            treeNode334.Text = "LDScrollBars";
            treeNode335.Name = "Node0";
            treeNode335.Text = "Version 1.2.5.0";
            treeNode336.Name = "Node0";
            treeNode336.Text = "New object added (previously a separate extension)";
            treeNode337.Name = "Node1";
            treeNode337.Text = "Async, Loop, Volume and Pan properties added";
            treeNode338.Name = "Node2";
            treeNode338.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode339.Name = "Node1";
            treeNode339.Text = "LDWaveForm";
            treeNode340.Name = "Node1";
            treeNode340.Text = "New object added to get input from gamepads or joysticks";
            treeNode341.Name = "Node0";
            treeNode341.Text = "LDController";
            treeNode342.Name = "Node1";
            treeNode342.Text = "RayCast method added";
            treeNode343.Name = "Node0";
            treeNode343.Text = "LDPhysics";
            treeNode344.Name = "Node0";
            treeNode344.Text = "Version 1.2.4.0";
            treeNode345.Name = "Node2";
            treeNode345.Text = "New object to apply effects to any shape or control";
            treeNode346.Name = "Node1";
            treeNode346.Text = "LDEffects";
            treeNode347.Name = "Node1";
            treeNode347.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode348.Name = "Node0";
            treeNode348.Text = "LDFigures";
            treeNode349.Name = "Node1";
            treeNode349.Text = "SetGroup method added";
            treeNode350.Name = "Node2";
            treeNode350.Text = "GetContacts method added";
            treeNode351.Name = "Node0";
            treeNode351.Text = "GetAllShapesAt method added";
            treeNode352.Name = "Node0";
            treeNode352.Text = "LDPhysics";
            treeNode353.Name = "Node2";
            treeNode353.Text = "SetImage handles images with transparency";
            treeNode354.Name = "Node0";
            treeNode354.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode355.Name = "Node1";
            treeNode355.Text = "LDClipboard";
            treeNode356.Name = "Node0";
            treeNode356.Text = "Version 1.2.3.0";
            treeNode357.Name = "Node2";
            treeNode357.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode358.Name = "Node1";
            treeNode358.Text = "LDShapes";
            treeNode359.Name = "Node4";
            treeNode359.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode360.Name = "Node3";
            treeNode360.Text = "LDFile";
            treeNode361.Name = "Node6";
            treeNode361.Text = "NewImage method added";
            treeNode362.Name = "Node5";
            treeNode362.Text = "LDImage";
            treeNode363.Name = "Node1";
            treeNode363.Text = "SetStartupPosition method added to position dialogs";
            treeNode364.Name = "Node0";
            treeNode364.Text = "LDDialogs";
            treeNode365.Name = "Node1";
            treeNode365.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode366.Name = "Node0";
            treeNode366.Text = "LDGraph";
            treeNode367.Name = "Node0";
            treeNode367.Text = "Version 1.2.2.0";
            treeNode368.Name = "Node2";
            treeNode368.Text = "Recompiled for Small Basic version 1.2";
            treeNode369.Name = "Node1";
            treeNode369.Text = "Version 1.2";
            treeNode370.Name = "Node0";
            treeNode370.Text = "Version 1.2.0.1";
            treeNode371.Name = "Node2";
            treeNode371.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode372.Name = "Node1";
            treeNode372.Text = "LDDialogs";
            treeNode373.Name = "Node1";
            treeNode373.Text = "Logical operations object added";
            treeNode374.Name = "Node0";
            treeNode374.Text = "LDLogic";
            treeNode375.Name = "Node4";
            treeNode375.Text = "CurrentCulture property added";
            treeNode376.Name = "Node3";
            treeNode376.Text = "LDUtilities";
            treeNode377.Name = "Node6";
            treeNode377.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode378.Name = "Node5";
            treeNode378.Text = "LDMath";
            treeNode379.Name = "Node0";
            treeNode379.Text = "Version 1.1.0.8";
            treeNode380.Name = "Node1";
            treeNode380.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode381.Name = "Node0";
            treeNode381.Text = "LDControls";
            treeNode382.Name = "Node1";
            treeNode382.Text = "Methods added to add and remove nodes and save xml file";
            treeNode383.Name = "Node0";
            treeNode383.Text = "LDxml";
            treeNode384.Name = "Node1";
            treeNode384.Text = "MusicPlayTime moved from LDFile";
            treeNode385.Name = "Node0";
            treeNode385.Text = "LDSound";
            treeNode386.Name = "Node0";
            treeNode386.Text = "Version 1.1.0.7";
            treeNode387.Name = "Node4";
            treeNode387.Text = "SplitImage method added";
            treeNode388.Name = "Node3";
            treeNode388.Text = "LDImage";
            treeNode389.Name = "Node6";
            treeNode389.Text = "EditTable and SaveTable methods added";
            treeNode390.Name = "Node5";
            treeNode390.Text = "LDDatabse";
            treeNode391.Name = "Node2";
            treeNode391.Text = "DataView control and methods added";
            treeNode392.Name = "Node1";
            treeNode392.Text = "LDControls";
            treeNode393.Name = "Node2";
            treeNode393.Text = "Version 1.1.0.6";
            treeNode394.Name = "Node2";
            treeNode394.Text = "Exists modified to check for directory as well as file";
            treeNode395.Name = "Node3";
            treeNode395.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode396.Name = "Node1";
            treeNode396.Text = "LDFile";
            treeNode397.Name = "Node5";
            treeNode397.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode398.Name = "Node6";
            treeNode398.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode399.Name = "Node9";
            treeNode399.Text = "Conditonal break point added";
            treeNode400.Name = "Node0";
            treeNode400.Text = "Step over button added";
            treeNode401.Name = "Node4";
            treeNode401.Text = "LDDebug";
            treeNode402.Name = "Node8";
            treeNode402.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode403.Name = "Node7";
            treeNode403.Text = "LDGraphicsWindow";
            treeNode404.Name = "Node1";
            treeNode404.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode405.Name = "Node0";
            treeNode405.Text = "LDResources";
            treeNode406.Name = "Node0";
            treeNode406.Text = "Version 1.1.0.5";
            treeNode407.Name = "Node2";
            treeNode407.Text = "ClipboardChanged event added";
            treeNode408.Name = "Node1";
            treeNode408.Text = "LDClipboard";
            treeNode409.Name = "Node1";
            treeNode409.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode410.Name = "Node0";
            treeNode410.Text = "LDFile";
            treeNode411.Name = "Node3";
            treeNode411.Text = "SetActive method added";
            treeNode412.Name = "Node2";
            treeNode412.Text = "LDGraphicsWindow";
            treeNode413.Name = "Node1";
            treeNode413.Text = "Parse xml file nodes";
            treeNode414.Name = "Node0";
            treeNode414.Text = "LDxml";
            treeNode415.Name = "Node3";
            treeNode415.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode416.Name = "Node2";
            treeNode416.Text = "General";
            treeNode417.Name = "Node0";
            treeNode417.Text = "Version 1.1.0.4";
            treeNode418.Name = "Node2";
            treeNode418.Text = "WakeAll method addded";
            treeNode419.Name = "Node1";
            treeNode419.Text = "LDPhysics";
            treeNode420.Name = "Node1";
            treeNode420.Text = "Clipboard methods added";
            treeNode421.Name = "Node0";
            treeNode421.Text = "LDClipboard";
            treeNode422.Name = "Node0";
            treeNode422.Text = "Version 1.1.0.3";
            treeNode423.Name = "Node6";
            treeNode423.Text = "SizeNWSE cursor added";
            treeNode424.Name = "Node5";
            treeNode424.Text = "LDCursors";
            treeNode425.Name = "Node8";
            treeNode425.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode426.Name = "Node7";
            treeNode426.Text = "LDGraph";
            treeNode427.Name = "Node1";
            treeNode427.Text = "SQLite updated for .Net 4.5";
            treeNode428.Name = "Node0";
            treeNode428.Text = "LDDataBase";
            treeNode429.Name = "Node4";
            treeNode429.Text = "Version 1.1.0.2";
            treeNode430.Name = "Node3";
            treeNode430.Text = "Recompiled for Small Basic version 1.1";
            treeNode431.Name = "Node2";
            treeNode431.Text = "Version 1.1";
            treeNode432.Name = "Node0";
            treeNode432.Text = "Version 1.1.0.1";
            treeNode433.Name = "Node12";
            treeNode433.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode434.Name = "Node13";
            treeNode434.Text = "RichTextBoxMargins method added";
            treeNode435.Name = "Node0";
            treeNode435.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode436.Name = "Node1";
            treeNode436.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode437.Name = "Node11";
            treeNode437.Text = "LDControls";
            treeNode438.Name = "Node3";
            treeNode438.Text = "Error reporting added";
            treeNode439.Name = "Node4";
            treeNode439.Text = "SetEncoding method added";
            treeNode440.Name = "Node2";
            treeNode440.Text = "LDCommPort";
            treeNode441.Name = "Node6";
            treeNode441.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode442.Name = "Node7";
            treeNode442.Text = "Export to excel fix for graph with no title";
            treeNode443.Name = "Node5";
            treeNode443.Text = "LDGraph";
            treeNode444.Name = "Node9";
            treeNode444.Text = "Negative restitution option when adding moving shape";
            treeNode445.Name = "Node8";
            treeNode445.Text = "LDPhysics";
            treeNode446.Name = "Node10";
            treeNode446.Text = "Version 1.0.0.133";
            treeNode447.Name = "Node2";
            treeNode447.Text = "Internal improvements to auto messaging";
            treeNode448.Name = "Node9";
            treeNode448.Text = "Name can be set and GetClients method added";
            treeNode449.Name = "Node1";
            treeNode449.Text = "LDClient";
            treeNode450.Name = "Node4";
            treeNode450.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode451.Name = "Node3";
            treeNode451.Text = "LDControls";
            treeNode452.Name = "Node8";
            treeNode452.Text = "Return message and possible file error fixed for Stop method";
            treeNode453.Name = "Node7";
            treeNode453.Text = "LDSound";
            treeNode454.Name = "Node0";
            treeNode454.Text = "Version 1.0.0.132";
            treeNode455.Name = "Node2";
            treeNode455.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode456.Name = "Node5";
            treeNode456.Text = "Compile method added to compile a Small Basic program";
            treeNode457.Name = "Node1";
            treeNode457.Text = "LDCall";
            treeNode458.Name = "Node4";
            treeNode458.Text = "Methods and code by Pappa Lapub added";
            treeNode459.Name = "Node3";
            treeNode459.Text = "LDShell";
            treeNode460.Name = "Node0";
            treeNode460.Text = "Version 1.0.0.131";
            treeNode461.Name = "Node6";
            treeNode461.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode462.Name = "Node7";
            treeNode462.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode463.Name = "Node8";
            treeNode463.Text = "Refactoring of all the pan, follow and box methods";
            treeNode464.Name = "Node6";
            treeNode464.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode465.Name = "Node8";
            treeNode465.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode466.Name = "Node5";
            treeNode466.Text = "LDPhysics";
            treeNode467.Name = "Node1";
            treeNode467.Text = "UseBinary property added";
            treeNode468.Name = "Node2";
            treeNode468.Text = "DoAsync property and associated completion events added";
            treeNode469.Name = "Node3";
            treeNode469.Text = "Delete method added";
            treeNode470.Name = "Node0";
            treeNode470.Text = "LDftp";
            treeNode471.Name = "Node5";
            treeNode471.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode472.Name = "Node4";
            treeNode472.Text = "LDCall";
            treeNode473.Name = "Node2";
            treeNode473.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode474.Name = "Node1";
            treeNode474.Text = "LDControls";
            treeNode475.Name = "Node4";
            treeNode475.Text = "Version 1.0.0.130";
            treeNode476.Name = "Node2";
            treeNode476.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode477.Name = "Node1";
            treeNode477.Text = "LDMath";
            treeNode478.Name = "Node1";
            treeNode478.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode479.Name = "Node0";
            treeNode479.Text = "LDPhysics";
            treeNode480.Name = "Node3";
            treeNode480.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode481.Name = "Node2";
            treeNode481.Text = "LDGraphicsWindow";
            treeNode482.Name = "Node1";
            treeNode482.Text = "FTP object methods added";
            treeNode483.Name = "Node0";
            treeNode483.Text = "LDftp";
            treeNode484.Name = "Node3";
            treeNode484.Text = "An existing file is replaced";
            treeNode485.Name = "Node2";
            treeNode485.Text = "LDZip";
            treeNode486.Name = "Node1";
            treeNode486.Text = "Size method added";
            treeNode487.Name = "Node0";
            treeNode487.Text = "LDFile";
            treeNode488.Name = "Node3";
            treeNode488.Text = "DownloadFile method added";
            treeNode489.Name = "Node2";
            treeNode489.Text = "LDNetwork";
            treeNode490.Name = "Node0";
            treeNode490.Text = "Version 1.0.0.129";
            treeNode491.Name = "Node2";
            treeNode491.Text = "Generalised joint connections added";
            treeNode492.Name = "Node0";
            treeNode492.Text = "AddExplosion method added";
            treeNode493.Name = "Node1";
            treeNode493.Text = "LDPhysics";
            treeNode494.Name = "Node1";
            treeNode494.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode495.Name = "Node0";
            treeNode495.Text = "LDShapes";
            treeNode496.Name = "Node0";
            treeNode496.Text = "Version 1.0.0.128";
            treeNode497.Name = "Node2";
            treeNode497.Text = "CheckServer method added";
            treeNode498.Name = "Node1";
            treeNode498.Text = "LDClient";
            treeNode499.Name = "Node1";
            treeNode499.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode500.Name = "Node2";
            treeNode500.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode501.Name = "Node3";
            treeNode501.Text = "GetAngle method added";
            treeNode502.Name = "Node4";
            treeNode502.Text = "Top-down tire (to model a car from above) methods added";
            treeNode503.Name = "Node0";
            treeNode503.Text = "LDPhysics";
            treeNode504.Name = "Node0";
            treeNode504.Text = "Version 1.0.0.127";
            treeNode505.Name = "Node7";
            treeNode505.Text = "Bug fixes for Overlap methods";
            treeNode506.Name = "Node6";
            treeNode506.Text = "LDShapes";
            treeNode507.Name = "Node0";
            treeNode507.Text = "Bug fix for multiple numeric sorts";
            treeNode508.Name = "Node9";
            treeNode508.Text = "ByValueWithIndex method added";
            treeNode509.Name = "Node8";
            treeNode509.Text = "LDSort";
            treeNode510.Name = "Node1";
            treeNode510.Text = "LAN method added to get local IP addresses";
            treeNode511.Name = "Node2";
            treeNode511.Text = "Ping method added";
            treeNode512.Name = "Node0";
            treeNode512.Text = "LDNetwork";
            treeNode513.Name = "Node1";
            treeNode513.Text = "LoadSVG method added";
            treeNode514.Name = "Node0";
            treeNode514.Text = "LDImage";
            treeNode515.Name = "Node3";
            treeNode515.Text = "Evaluate method added";
            treeNode516.Name = "Node2";
            treeNode516.Text = "LDMath";
            treeNode517.Name = "Node5";
            treeNode517.Text = "IncludeJScript method added";
            treeNode518.Name = "Node4";
            treeNode518.Text = "LDInline";
            treeNode519.Name = "Node5";
            treeNode519.Text = "Version 1.0.0.126";
            treeNode520.Name = "Node0";
            treeNode520.Text = "Special emphasis on async consistency";
            treeNode521.Name = "Node4";
            treeNode521.Text = "Simplified auto method for multi-player game data transfer";
            treeNode522.Name = "Node9";
            treeNode522.Text = "LDServer and LDClient objects added";
            treeNode523.Name = "Node2";
            treeNode523.Text = "GetWidth and GetHeight methods added";
            treeNode524.Name = "Node1";
            treeNode524.Text = "LDText";
            treeNode525.Name = "Node4";
            treeNode525.Text = "Bing web search";
            treeNode526.Name = "Node3";
            treeNode526.Text = "LDSearch";
            treeNode527.Name = "Node6";
            treeNode527.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode528.Name = "Node7";
            treeNode528.Text = "KeyScroll property added";
            treeNode529.Name = "Node5";
            treeNode529.Text = "LDScrollBars";
            treeNode530.Name = "Node9";
            treeNode530.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode531.Name = "Node8";
            treeNode531.Text = "LDShapes";
            treeNode532.Name = "Node1";
            treeNode532.Text = "SaveAs method bug fixed";
            treeNode533.Name = "Node0";
            treeNode533.Text = "LDImage";
            treeNode534.Name = "Node3";
            treeNode534.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode535.Name = "Node2";
            treeNode535.Text = "LDQueue";
            treeNode536.Name = "Node8";
            treeNode536.Text = "Version 1.0.0.125";
            treeNode537.Name = "Node7";
            treeNode537.Text = "Language translation object added";
            treeNode538.Name = "Node6";
            treeNode538.Text = "LDTranslate";
            treeNode539.Name = "Node5";
            treeNode539.Text = "Version 1.0.0.124";
            treeNode540.Name = "Node1";
            treeNode540.Text = "Mouse screen coordinate conversion parameters added";
            treeNode541.Name = "Node2";
            treeNode541.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode542.Name = "Node0";
            treeNode542.Text = "LDGraphicsWindow";
            treeNode543.Name = "Node4";
            treeNode543.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode544.Name = "Node3";
            treeNode544.Text = "LDUtilities";
            treeNode545.Name = "Node0";
            treeNode545.Text = "Version 1.0.0.123";
            treeNode546.Name = "Node5";
            treeNode546.Text = "ColorMatrix method added";
            treeNode547.Name = "Node0";
            treeNode547.Text = "Rotate method added";
            treeNode548.Name = "Node3";
            treeNode548.Text = "LDImage";
            treeNode549.Name = "Node1";
            treeNode549.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode550.Name = "Node0";
            treeNode550.Text = "LDChart";
            treeNode551.Name = "Node2";
            treeNode551.Text = "Version 1.0.0.122";
            treeNode552.Name = "Node2";
            treeNode552.Text = "EffectGamma added to darken and lighten";
            treeNode553.Name = "Node4";
            treeNode553.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode554.Name = "Node3";
            treeNode554.Text = "EffectContrast modified";
            treeNode555.Name = "Node0";
            treeNode555.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode556.Name = "Node1";
            treeNode556.Text = "LDImage";
            treeNode557.Name = "Node2";
            treeNode557.Text = "Error event added for all extension exceptions";
            treeNode558.Name = "Node1";
            treeNode558.Text = "LDEvents";
            treeNode559.Name = "Node1";
            treeNode559.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode560.Name = "Node0";
            treeNode560.Text = "LDMath";
            treeNode561.Name = "Node0";
            treeNode561.Text = "Version 1.0.0.121";
            treeNode562.Name = "Node2";
            treeNode562.Text = "FloodFill transparency effect fixed";
            treeNode563.Name = "Node1";
            treeNode563.Text = "LDGraphicsWindow";
            treeNode564.Name = "Node1";
            treeNode564.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode565.Name = "Node0";
            treeNode565.Text = "LDFile";
            treeNode566.Name = "Node1";
            treeNode566.Text = "EffectPixelate added";
            treeNode567.Name = "Node0";
            treeNode567.Text = "LDImage";
            treeNode568.Name = "Node1";
            treeNode568.Text = "Modified to work with Windows 8";
            treeNode569.Name = "Node0";
            treeNode569.Text = "LDWebCam";
            treeNode570.Name = "Node0";
            treeNode570.Text = "Version 1.0.0.120";
            treeNode571.Name = "Node2";
            treeNode571.Text = "FloodFill method added";
            treeNode572.Name = "Node1";
            treeNode572.Text = "LDGraphicsWindow";
            treeNode573.Name = "Node0";
            treeNode573.Text = "Version 1.0.0.119";
            treeNode574.Name = "Node0";
            treeNode574.Text = "SetShapeCursor method added";
            treeNode575.Name = "Node11";
            treeNode575.Text = "CreateCursor method added";
            treeNode576.Name = "Node9";
            treeNode576.Text = "LDCursors";
            treeNode577.Name = "Node2";
            treeNode577.Text = "SaveAs method to save in different file formats";
            treeNode578.Name = "Node0";
            treeNode578.Text = "Parameters added for some effects";
            treeNode579.Name = "Node1";
            treeNode579.Text = "LDImage";
            treeNode580.Name = "Node2";
            treeNode580.Text = "Parameters added for some effects";
            treeNode581.Name = "Node1";
            treeNode581.Text = "LDWebCam";
            treeNode582.Name = "Node1";
            treeNode582.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode583.Name = "Node0";
            treeNode583.Text = "SetFontFromFile method added for ttf fonts";
            treeNode584.Name = "Node0";
            treeNode584.Text = "LDGraphicsWindow";
            treeNode585.Name = "Node3";
            treeNode585.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode586.Name = "Node2";
            treeNode586.Text = "LDTextWindow";
            treeNode587.Name = "Node2";
            treeNode587.Text = "Zip methods moved here from LDUtilities";
            treeNode588.Name = "Node0";
            treeNode588.Text = "LDZip";
            treeNode589.Name = "Node3";
            treeNode589.Text = "Regex methods moved here from LDUtilities";
            treeNode590.Name = "Node1";
            treeNode590.Text = "LDRegex";
            treeNode591.Name = "Node1";
            treeNode591.Text = "ListViewRowCount method added";
            treeNode592.Name = "Node0";
            treeNode592.Text = "LDControls";
            treeNode593.Name = "Node3";
            treeNode593.Text = "Version 1.0.0.118";
            treeNode594.Name = "Node5";
            treeNode594.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode595.Name = "Node6";
            treeNode595.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode596.Name = "Node4";
            treeNode596.Text = "LDUtilities";
            treeNode597.Name = "Node10";
            treeNode597.Text = "SetUserCursor method added";
            treeNode598.Name = "Node4";
            treeNode598.Text = "LDCursors";
            treeNode599.Name = "Node3";
            treeNode599.Text = "Version 1.0.0.117";
            treeNode600.Name = "Node2";
            treeNode600.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode601.Name = "Node1";
            treeNode601.Text = "LDDictionary";
            treeNode602.Name = "Node0";
            treeNode602.Text = "Version 1.0.0.116";
            treeNode603.Name = "Node2";
            treeNode603.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode604.Name = "Node1";
            treeNode604.Text = "LDColours";
            treeNode605.Name = "Node4";
            treeNode605.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode606.Name = "Node3";
            treeNode606.Text = "LDShapes";
            treeNode607.Name = "Node1";
            treeNode607.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode608.Name = "Node0";
            treeNode608.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode609.Name = "Node1";
            treeNode609.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode610.Name = "Node0";
            treeNode610.Text = "LDGraph";
            treeNode611.Name = "Node0";
            treeNode611.Text = "Version 1.0.0.115";
            treeNode612.Name = "Node2";
            treeNode612.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode613.Name = "Node1";
            treeNode613.Text = "LDControls";
            treeNode614.Name = "Node4";
            treeNode614.Text = "RemoveTurtleLines method added";
            treeNode615.Name = "Node6";
            treeNode615.Text = "GetAllShapes method added";
            treeNode616.Name = "Node3";
            treeNode616.Text = "LDShapes";
            treeNode617.Name = "Node1";
            treeNode617.Text = "Odbc connection added";
            treeNode618.Name = "Node0";
            treeNode618.Text = "LDDatabase";
            treeNode619.Name = "Node0";
            treeNode619.Text = "Version 1.0.0.114";
            treeNode620.Name = "Node2";
            treeNode620.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode621.Name = "Node1";
            treeNode621.Text = "LDUtilities";
            treeNode622.Name = "Node4";
            treeNode622.Text = "ListView control added";
            treeNode623.Name = "Node5";
            treeNode623.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode624.Name = "Node3";
            treeNode624.Text = "LDControls";
            treeNode625.Name = "Node0";
            treeNode625.Text = "Version 1.0.0.113";
            treeNode626.Name = "Node2";
            treeNode626.Text = "Tone method added";
            treeNode627.Name = "Node1";
            treeNode627.Text = "LDSound";
            treeNode628.Name = "Node5";
            treeNode628.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode629.Name = "Node4";
            treeNode629.Text = "LDControls";
            treeNode630.Name = "Node0";
            treeNode630.Text = "Version 1.0.0.112";
            treeNode631.Name = "Node2";
            treeNode631.Text = "SqlServer and Access database support added";
            treeNode632.Name = "Node1";
            treeNode632.Text = "LDDataBase";
            treeNode633.Name = "Node4";
            treeNode633.Text = "FixFlickr method added";
            treeNode634.Name = "Node0";
            treeNode634.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode635.Name = "Node3";
            treeNode635.Text = "LDUtilities";
            treeNode636.Name = "Node0";
            treeNode636.Text = "Version 1.0.0.111";
            treeNode637.Name = "Node2";
            treeNode637.Text = "TextBoxTab method added";
            treeNode638.Name = "Node1";
            treeNode638.Text = "LDControls";
            treeNode639.Name = "Node0";
            treeNode639.Text = "Version 1.0.0.110";
            treeNode640.Name = "Node1";
            treeNode640.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode641.Name = "Node3";
            treeNode641.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode642.Name = "Node0";
            treeNode642.Text = "General";
            treeNode643.Name = "Node5";
            treeNode643.Text = "Exists method added to check if a file path exists or not";
            treeNode644.Name = "Node4";
            treeNode644.Text = "LDFile";
            treeNode645.Name = "Node7";
            treeNode645.Text = "Start method handles attaching to existing process without warning";
            treeNode646.Name = "Node6";
            treeNode646.Text = "LDProcess";
            treeNode647.Name = "Node1";
            treeNode647.Text = "MySQL database support added";
            treeNode648.Name = "Node0";
            treeNode648.Text = "LDDatabase";
            treeNode649.Name = "Node3";
            treeNode649.Text = "Add and Multiply methods honour transparency";
            treeNode650.Name = "Node4";
            treeNode650.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode651.Name = "Node2";
            treeNode651.Text = "LDImage";
            treeNode652.Name = "Node3";
            treeNode652.Text = "Version 1.0.0.109";
            treeNode653.Name = "Node2";
            treeNode653.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode654.Name = "Node1";
            treeNode654.Text = "LDTextWindow";
            treeNode655.Name = "Node0";
            treeNode655.Text = "Version 1.0.0.108";
            treeNode656.Name = "Node14";
            treeNode656.Text = "Transparent colour added";
            treeNode657.Name = "Node13";
            treeNode657.Text = "LDColours";
            treeNode658.Name = "Node16";
            treeNode658.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode659.Name = "Node15";
            treeNode659.Text = "LDDialogs";
            treeNode660.Name = "Node12";
            treeNode660.Text = "Version 1.0.0.107";
            treeNode661.Name = "Node8";
            treeNode661.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode662.Name = "Node7";
            treeNode662.Text = "LDControls";
            treeNode663.Name = "Node11";
            treeNode663.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode664.Name = "Node10";
            treeNode664.Text = "LDShapes";
            treeNode665.Name = "Node6";
            treeNode665.Text = "Version 1.0.0.106";
            treeNode666.Name = "Node5";
            treeNode666.Text = "Menu control added";
            treeNode667.Name = "Node4";
            treeNode667.Text = "LDControls";
            treeNode668.Name = "Node3";
            treeNode668.Text = "Version 1.0.0.105";
            treeNode669.Name = "Node5";
            treeNode669.Text = "ZipList method added";
            treeNode670.Name = "Node2";
            treeNode670.Text = "GetNextMapIndex method added";
            treeNode671.Name = "Node4";
            treeNode671.Text = "LDUtilities";
            treeNode672.Name = "Node1";
            treeNode672.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode673.Name = "Node0";
            treeNode673.Text = "LDShapes";
            treeNode674.Name = "Node3";
            treeNode674.Text = "Version 1.0.0.104";
            treeNode675.Name = "Node1";
            treeNode675.Text = "Transparency maintained for various methods";
            treeNode676.Name = "Node2";
            treeNode676.Text = "Effects bug fixed";
            treeNode677.Name = "Node0";
            treeNode677.Text = "LDImage";
            treeNode678.Name = "Node0";
            treeNode678.Text = "Version 1.0.0.103";
            treeNode679.Name = "Node1";
            treeNode679.Text = "Current application assemblies are all auto-referenced";
            treeNode680.Name = "Node0";
            treeNode680.Text = "LDInline";
            treeNode681.Name = "Node5";
            treeNode681.Text = "Version 1.0.0.102";
            treeNode682.Name = "Node1";
            treeNode682.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode683.Name = "Node2";
            treeNode683.Text = "LDInline.sb sample provided";
            treeNode684.Name = "Node0";
            treeNode684.Text = "LDInline";
            treeNode685.Name = "Node4";
            treeNode685.Text = "ExitButtonMode method added to control window close button state";
            treeNode686.Name = "Node3";
            treeNode686.Text = "LDUtilities";
            treeNode687.Name = "Node0";
            treeNode687.Text = "Version 1.0.0.101";
            treeNode688.Name = "Node1";
            treeNode688.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode689.Name = "Node0";
            treeNode689.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode690.Name = "Node0";
            treeNode690.Text = "LDTextWindow";
            treeNode691.Name = "Node0";
            treeNode691.Text = "Version 1.0.0.100";
            treeNode692.Name = "Node2";
            treeNode692.Text = "ReadANSIToArray method added";
            treeNode693.Name = "Node1";
            treeNode693.Text = "LDFile";
            treeNode694.Name = "Node1";
            treeNode694.Text = "DocumentViewer control added";
            treeNode695.Name = "Node0";
            treeNode695.Text = "LDControls";
            treeNode696.Name = "Node3";
            treeNode696.Text = "An object to batch update shapes (for speed reasons)";
            treeNode697.Name = "Node0";
            treeNode697.Text = "LDFastShapes.sb sample included";
            treeNode698.Name = "Node2";
            treeNode698.Text = "LDFastShapes";
            treeNode699.Name = "Node0";
            treeNode699.Text = "Version 1.0.0.99";
            treeNode700.Name = "Node1";
            treeNode700.Text = "Rendering performance improvements when many shapes present";
            treeNode701.Name = "Node0";
            treeNode701.Text = "LDPhysics";
            treeNode702.Name = "Node1";
            treeNode702.Text = "ANSItoUTF8 method added";
            treeNode703.Name = "Node2";
            treeNode703.Text = "ReadANSI method added";
            treeNode704.Name = "Node0";
            treeNode704.Text = "LDFile";
            treeNode705.Name = "Node1";
            treeNode705.Text = "Version 1.0.0.98";
            treeNode706.Name = "Node3";
            treeNode706.Text = "Move method added for tiangles, polygons and lines";
            treeNode707.Name = "Node4";
            treeNode707.Text = "RotateAbout method added";
            treeNode708.Name = "Node1";
            treeNode708.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode709.Name = "Node0";
            treeNode709.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode710.Name = "Node2";
            treeNode710.Text = "LDShapes";
            treeNode711.Name = "Node0";
            treeNode711.Text = "Version 1.0.0.97";
            treeNode712.Name = "Node4";
            treeNode712.Text = "A list storage object added";
            treeNode713.Name = "Node3";
            treeNode713.Text = "LDList";
            treeNode714.Name = "Node2";
            treeNode714.Text = "Version 1.0.0.96";
            treeNode715.Name = "Node4";
            treeNode715.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode716.Name = "Node3";
            treeNode716.Text = "LDQueue";
            treeNode717.Name = "Node6";
            treeNode717.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode718.Name = "Node5";
            treeNode718.Text = "LDNetwork";
            treeNode719.Name = "Node0";
            treeNode719.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode720.Name = "Node1";
            treeNode720.Text = "General";
            treeNode721.Name = "Node2";
            treeNode721.Text = "Version 1.0.0.95";
            treeNode722.Name = "Node2";
            treeNode722.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode723.Name = "Node1";
            treeNode723.Text = "LDEncryption";
            treeNode724.Name = "Node1";
            treeNode724.Text = "RandomNumberSeed property added";
            treeNode725.Name = "Node0";
            treeNode725.Text = "LDMath";
            treeNode726.Name = "Node1";
            treeNode726.Text = "SetGameData and GetGameData methods added";
            treeNode727.Name = "Node0";
            treeNode727.Text = "LDNetwork";
            treeNode728.Name = "Node0";
            treeNode728.Text = "Version 1.0.0.94";
            treeNode729.Name = "Node1";
            treeNode729.Text = "SliderGetValue method added";
            treeNode730.Name = "Node0";
            treeNode730.Text = "LDControls";
            treeNode731.Name = "Node5";
            treeNode731.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode732.Name = "Node2";
            treeNode732.Text = "LDUtilities";
            treeNode733.Name = "Node3";
            treeNode733.Text = "Encrypt and Decrypt methods added";
            treeNode734.Name = "Node4";
            treeNode734.Text = "MD5Hash method added";
            treeNode735.Name = "Node6";
            treeNode735.Text = "LDEncryption";
            treeNode736.Name = "Node0";
            treeNode736.Text = "Version 1.0.0.93";
            treeNode737.Name = "Node1";
            treeNode737.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode738.Name = "Node0";
            treeNode738.Text = "LDControls";
            treeNode739.Name = "Node0";
            treeNode739.Text = "Version 1.0.0.92";
            treeNode740.Name = "Node2";
            treeNode740.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode741.Name = "Node1";
            treeNode741.Text = "LDControls";
            treeNode742.Name = "Node1";
            treeNode742.Text = "Version 1.0.0.91";
            treeNode743.Name = "Node1";
            treeNode743.Text = "Font method added to modify shapes or controls that have text";
            treeNode744.Name = "Node0";
            treeNode744.Text = "LDShapes";
            treeNode745.Name = "Node1";
            treeNode745.Text = "MediaPlayer control added (play videos etc)";
            treeNode746.Name = "Node0";
            treeNode746.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode747.Name = "Node0";
            treeNode747.Text = "LDControls";
            treeNode748.Name = "Node1";
            treeNode748.Text = "Version 1.0.0.90";
            treeNode749.Name = "Node1";
            treeNode749.Text = "Autosize columns for ListView";
            treeNode750.Name = "Node2";
            treeNode750.Text = "LDDataBase.sb sample updated";
            treeNode751.Name = "Node0";
            treeNode751.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode752.Name = "Node0";
            treeNode752.Text = "LDDataBase";
            treeNode753.Name = "Node0";
            treeNode753.Text = "Version 1.0.0.89";
            treeNode754.Name = "Node4";
            treeNode754.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode755.Name = "Node3";
            treeNode755.Text = "LDScrollBars";
            treeNode756.Name = "Node1";
            treeNode756.Text = "CleanTemp method added";
            treeNode757.Name = "Node0";
            treeNode757.Text = "LDUtilities";
            treeNode758.Name = "Node1";
            treeNode758.Text = "SQLite database methods added";
            treeNode759.Name = "Node0";
            treeNode759.Text = "LDDataBase";
            treeNode760.Name = "Node2";
            treeNode760.Text = "Version 1.0.0.88";
            treeNode761.Name = "Node2";
            treeNode761.Text = "LastError now returns a text error";
            treeNode762.Name = "Node1";
            treeNode762.Text = "LDIOWarrior";
            treeNode763.Name = "Node1";
            treeNode763.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode764.Name = "Node0";
            treeNode764.Text = "LDScrollBars";
            treeNode765.Name = "Node0";
            treeNode765.Text = "Version 1.0.0.87";
            treeNode766.Name = "Node4";
            treeNode766.Text = "SetTurtleImage method added";
            treeNode767.Name = "Node3";
            treeNode767.Text = "LDShapes";
            treeNode768.Name = "Node1";
            treeNode768.Text = "Connect to IOWarrior USB devices";
            treeNode769.Name = "Node0";
            treeNode769.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode770.Name = "Node0";
            treeNode770.Text = "LDIOWarrior";
            treeNode771.Name = "Node2";
            treeNode771.Text = "Version 1.0.0.86";
            treeNode772.Name = "Node1";
            treeNode772.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode773.Name = "Node0";
            treeNode773.Text = "LDShapes";
            treeNode774.Name = "Node2";
            treeNode774.Text = "Version 1.0.0.85";
            treeNode775.Name = "Node4";
            treeNode775.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode776.Name = "Node3";
            treeNode776.Text = "LDFile";
            treeNode777.Name = "Node6";
            treeNode777.Text = "Crop method added";
            treeNode778.Name = "Node5";
            treeNode778.Text = "LDImage";
            treeNode779.Name = "Node1";
            treeNode779.Text = "LastDropFiles bug fixed";
            treeNode780.Name = "Node0";
            treeNode780.Text = "LDControls";
            treeNode781.Name = "Node2";
            treeNode781.Text = "Version 1.0.0.84";
            treeNode782.Name = "Node7";
            treeNode782.Text = "FileDropped event added";
            treeNode783.Name = "Node6";
            treeNode783.Text = "LDControls";
            treeNode784.Name = "Node1";
            treeNode784.Text = "Bug in Split corrected";
            treeNode785.Name = "Node0";
            treeNode785.Text = "LDText";
            treeNode786.Name = "Node5";
            treeNode786.Text = "Version 1.0.0.83";
            treeNode787.Name = "Node3";
            treeNode787.Text = "Title argument removed from AddComboBox";
            treeNode788.Name = "Node4";
            treeNode788.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode789.Name = "Node2";
            treeNode789.Text = "LDControls";
            treeNode790.Name = "Node1";
            treeNode790.Text = "Version 1.0.0.82";
            treeNode791.Name = "Node0";
            treeNode791.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode792.Name = "Node12";
            treeNode792.Text = "Program settings added";
            treeNode793.Name = "Node9";
            treeNode793.Text = "LDSettings";
            treeNode794.Name = "Node11";
            treeNode794.Text = "Get some system paths and user name";
            treeNode795.Name = "Node10";
            treeNode795.Text = "LDFile";
            treeNode796.Name = "Node14";
            treeNode796.Text = "System sounds added";
            treeNode797.Name = "Node13";
            treeNode797.Text = "LDSound";
            treeNode798.Name = "Node16";
            treeNode798.Text = "Binary, octal, hex and decimal conversions";
            treeNode799.Name = "Node15";
            treeNode799.Text = "LDMath";
            treeNode800.Name = "Node1";
            treeNode800.Text = "Replace method added";
            treeNode801.Name = "Node2";
            treeNode801.Text = "FindAll method added";
            treeNode802.Name = "Node0";
            treeNode802.Text = "LDText";
            treeNode803.Name = "Node8";
            treeNode803.Text = "Version 1.0.0.81";
            treeNode804.Name = "Node1";
            treeNode804.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode805.Name = "Node6";
            treeNode805.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode806.Name = "Node0";
            treeNode806.Text = "LDShapes";
            treeNode807.Name = "Node3";
            treeNode807.Text = "Truncate method added";
            treeNode808.Name = "Node2";
            treeNode808.Text = "LDMath";
            treeNode809.Name = "Node5";
            treeNode809.Text = "Additional text methods";
            treeNode810.Name = "Node4";
            treeNode810.Text = "LDText";
            treeNode811.Name = "Node0";
            treeNode811.Text = "Version 1.0.0.80";
            treeNode812.Name = "Node1";
            treeNode812.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode813.Name = "Node0";
            treeNode813.Text = "LDDialogs";
            treeNode814.Name = "Node1";
            treeNode814.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode815.Name = "Node0";
            treeNode815.Text = "LDUtilities";
            treeNode816.Name = "Node6";
            treeNode816.Text = "Version 1.0.0.79";
            treeNode817.Name = "Node2";
            treeNode817.Text = "Rasterize property added";
            treeNode818.Name = "Node5";
            treeNode818.Text = "Improvements associated with window resizing";
            treeNode819.Name = "Node1";
            treeNode819.Text = "LDScrollBars";
            treeNode820.Name = "Node4";
            treeNode820.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode821.Name = "Node3";
            treeNode821.Text = "LDUtilities";
            treeNode822.Name = "Node0";
            treeNode822.Text = "Version 1.0.0.78";
            treeNode823.Name = "Node1";
            treeNode823.Text = "Handle more than 100 drawables (rasterization)";
            treeNode824.Name = "Node0";
            treeNode824.Text = "LDScollBars";
            treeNode825.Name = "Node2";
            treeNode825.Text = "Version 1.0.0.77";
            treeNode826.Name = "Node1";
            treeNode826.Text = "Record sound from a microphone";
            treeNode827.Name = "Node0";
            treeNode827.Text = "LDSound";
            treeNode828.Name = "Node3";
            treeNode828.Text = "AnimateOpacity method added (flashing)";
            treeNode829.Name = "Node0";
            treeNode829.Text = "AnimateRotation method added (continuous rotation)";
            treeNode830.Name = "Node1";
            treeNode830.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode831.Name = "Node2";
            treeNode831.Text = "LDShapes";
            treeNode832.Name = "Node2";
            treeNode832.Text = "Version 1.0.0.76";
            treeNode833.Name = "Node1";
            treeNode833.Text = "AddAnimatedImage can use an ImageList image";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDShapes";
            treeNode835.Name = "Node0";
            treeNode835.Text = "Version 1.0.0.75";
            treeNode836.Name = "Node1";
            treeNode836.Text = "Initial graph axes scaling improvement";
            treeNode837.Name = "Node0";
            treeNode837.Text = "LDGraph";
            treeNode838.Name = "Node3";
            treeNode838.Text = "Methods to access a bluetooth device";
            treeNode839.Name = "Node0";
            treeNode839.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode840.Name = "Node2";
            treeNode840.Text = "LDBlueTooth";
            treeNode841.Name = "Node1";
            treeNode841.Text = "getFocus handles multiple LDWindows";
            treeNode842.Name = "Node0";
            treeNode842.Text = "LDFocus";
            treeNode843.Name = "Node0";
            treeNode843.Text = "Version 1.0.0.74";
            treeNode844.Name = "Node1";
            treeNode844.Text = "First pass at a generic USB (HID) device controller";
            treeNode845.Name = "Node0";
            treeNode845.Text = "LDHID";
            treeNode846.Name = "Node9";
            treeNode846.Text = "Version 1.0.0.73";
            treeNode847.Name = "Node8";
            treeNode847.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode848.Name = "Node7";
            treeNode848.Text = "LDGraph";
            treeNode849.Name = "Node6";
            treeNode849.Text = "Version 1.0.0.72";
            treeNode850.Name = "Node4";
            treeNode850.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode851.Name = "Node5";
            treeNode851.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode852.Name = "Node3";
            treeNode852.Text = "LDGraph";
            treeNode853.Name = "Node2";
            treeNode853.Text = "Version 1.0.0.71";
            treeNode854.Name = "Node1";
            treeNode854.Text = "Spurious error message fixed";
            treeNode855.Name = "Node2";
            treeNode855.Text = "CreateTrend data series creation method added";
            treeNode856.Name = "Node0";
            treeNode856.Text = "LDGraph";
            treeNode857.Name = "Node2";
            treeNode857.Text = "Version 1.0.0.70";
            treeNode858.Name = "Node1";
            treeNode858.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode859.Name = "Node0";
            treeNode859.Text = "LDControls";
            treeNode860.Name = "Node3";
            treeNode860.Text = "Version 1.0.0.69";
            treeNode861.Name = "Node2";
            treeNode861.Text = "Radio button control added";
            treeNode862.Name = "Node1";
            treeNode862.Text = "LDControls";
            treeNode863.Name = "Node0";
            treeNode863.Text = "Version 1.0.0.68";
            treeNode864.Name = "Node1";
            treeNode864.Text = "Bug fix for Copy";
            treeNode865.Name = "Node0";
            treeNode865.Text = "LDArray";
            treeNode866.Name = "Node2";
            treeNode866.Text = "Version 1.0.0.67";
            treeNode867.Name = "Node1";
            treeNode867.Text = "RegexMatch and RegexReplace methods added";
            treeNode868.Name = "Node0";
            treeNode868.Text = "LDUtilities";
            treeNode869.Name = "Node3";
            treeNode869.Text = "Version 1.0.0.66";
            treeNode870.Name = "Node2";
            treeNode870.Text = "Number culture conversions added";
            treeNode871.Name = "Node1";
            treeNode871.Text = "LDUtilities";
            treeNode872.Name = "Node0";
            treeNode872.Text = "Version 1.0.0.65";
            treeNode873.Name = "Node1";
            treeNode873.Text = "IsNumber method added";
            treeNode874.Name = "Node0";
            treeNode874.Text = "LDUtilities";
            treeNode875.Name = "Node2";
            treeNode875.Text = "Version 1.0.0.64";
            treeNode876.Name = "Node1";
            treeNode876.Text = "SetCursorPosition method added for textboxes";
            treeNode877.Name = "Node0";
            treeNode877.Text = "LDControls";
            treeNode878.Name = "Node4";
            treeNode878.Text = "Version 1.0.0.63";
            treeNode879.Name = "Node1";
            treeNode879.Text = "SetCursorToEnd method added for textboxes";
            treeNode880.Name = "Node3";
            treeNode880.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode881.Name = "Node0";
            treeNode881.Text = "LDControls";
            treeNode882.Name = "Node2";
            treeNode882.Text = "Version 1.0.0.62";
            treeNode883.Name = "Node1";
            treeNode883.Text = "Adding polygons not located at (0,0) corrected";
            treeNode884.Name = "Node0";
            treeNode884.Text = "LDPhysics";
            treeNode885.Name = "Node2";
            treeNode885.Text = "Version 1.0.0.61";
            treeNode886.Name = "Node1";
            treeNode886.Text = "GetFolder dialog added";
            treeNode887.Name = "Node0";
            treeNode887.Text = "LDDialogs";
            treeNode888.Name = "Node0";
            treeNode888.Text = "Version 1.0.0.60";
            treeNode889.Name = "Node10";
            treeNode889.Text = "Possible localization issue with Font size fixed";
            treeNode890.Name = "Node9";
            treeNode890.Text = "LDDialogs";
            treeNode891.Name = "Node8";
            treeNode891.Text = "Version 1.0.0.59";
            treeNode892.Name = "Node3";
            treeNode892.Text = "More internationalization fixes";
            treeNode893.Name = "Node2";
            treeNode893.Text = "ShowPrintPreview property added";
            treeNode894.Name = "Node1";
            treeNode894.Text = "LDUtilities";
            treeNode895.Name = "Node5";
            treeNode895.Text = "Possible error with gradient drawings fixed";
            treeNode896.Name = "Node4";
            treeNode896.Text = "LDShapes";
            treeNode897.Name = "Node7";
            treeNode897.Text = "Possible Listen event initialisation error fixed";
            treeNode898.Name = "Node6";
            treeNode898.Text = "LDSpeech";
            treeNode899.Name = "Node0";
            treeNode899.Text = "Version 1.0.0.58";
            treeNode900.Name = "Node7";
            treeNode900.Text = "Many possible internationisation issues fixed";
            treeNode901.Name = "Node4";
            treeNode901.Text = "Version 1.0.0.57";
            treeNode902.Name = "Node1";
            treeNode902.Text = "Emmisive colour correction for AddGeometry";
            treeNode903.Name = "Node2";
            treeNode903.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode904.Name = "Node0";
            treeNode904.Text = "LD3DView";
            treeNode905.Name = "Node1";
            treeNode905.Text = "CSVdeminiator property added";
            treeNode906.Name = "Node0";
            treeNode906.Text = "LDUtilities";
            treeNode907.Name = "Node5";
            treeNode907.Text = "Version 1.0.0.56";
            treeNode908.Name = "Node1";
            treeNode908.Text = "Improved error reporting";
            treeNode909.Name = "Node2";
            treeNode909.Text = "Culture invariant type conversions";
            treeNode910.Name = "Node1";
            treeNode910.Text = "LD3DView";
            treeNode911.Name = "Node4";
            treeNode911.Text = "ShowErrors method added";
            treeNode912.Name = "Node3";
            treeNode912.Text = "LDUtilities";
            treeNode913.Name = "Node0";
            treeNode913.Text = "Version 1.0.0.55";
            treeNode914.Name = "Node4";
            treeNode914.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode915.Name = "Node3";
            treeNode915.Text = "LDScrollBars";
            treeNode916.Name = "Node6";
            treeNode916.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode917.Name = "Node5";
            treeNode917.Text = "LDUtilities";
            treeNode918.Name = "Node2";
            treeNode918.Text = "Version 1.0.0.54";
            treeNode919.Name = "Node1";
            treeNode919.Text = "Debug window can be resized";
            treeNode920.Name = "Node0";
            treeNode920.Text = "LDDebug";
            treeNode921.Name = "Node1";
            treeNode921.Text = "PrintFile method added";
            treeNode922.Name = "Node0";
            treeNode922.Text = "LDFile";
            treeNode923.Name = "Node2";
            treeNode923.Text = "Version 1.0.0.53";
            treeNode924.Name = "Node1";
            treeNode924.Text = "SSL property option added";
            treeNode925.Name = "Node0";
            treeNode925.Text = "LDEmail";
            treeNode926.Name = "Node0";
            treeNode926.Text = "Version 1.0.0.52";
            treeNode927.Name = "Node1";
            treeNode927.Text = "Right Click Context menu added for any shape or control";
            treeNode928.Name = "Node0";
            treeNode928.Text = "LDControls";
            treeNode929.Name = "Node0";
            treeNode929.Text = "Version 1.0.0.51";
            treeNode930.Name = "Node1";
            treeNode930.Text = "Right click dropdown menu option added";
            treeNode931.Name = "Node0";
            treeNode931.Text = "LDDialogs";
            treeNode932.Name = "Node0";
            treeNode932.Text = "Version 1.0.0.50";
            treeNode933.Name = "Node1";
            treeNode933.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode934.Name = "Node0";
            treeNode934.Text = "LD3DView";
            treeNode935.Name = "Node0";
            treeNode935.Text = "Version 1.0.0.49";
            treeNode936.Name = "Node1";
            treeNode936.Text = "Performance improvements (some camera controls for this)";
            treeNode937.Name = "Node1";
            treeNode937.Text = "LoadModel (*.3ds) files added";
            treeNode938.Name = "Node0";
            treeNode938.Text = "LD3DView";
            treeNode939.Name = "Node3";
            treeNode939.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode940.Name = "Node2";
            treeNode940.Text = "LDShapes";
            treeNode941.Name = "Node0";
            treeNode941.Text = "Version 1.0.0.48";
            treeNode942.Name = "Node1";
            treeNode942.Text = "Some improvements including animations";
            treeNode943.Name = "Node0";
            treeNode943.Text = "LD3DView";
            treeNode944.Name = "Node0";
            treeNode944.Text = "Version 1.0.0.47";
            treeNode945.Name = "Node1";
            treeNode945.Text = "Some improvemts and new methods";
            treeNode946.Name = "Node0";
            treeNode946.Text = "LD3Dview";
            treeNode947.Name = "Node2";
            treeNode947.Text = "Version 1.0.0.46";
            treeNode948.Name = "Node1";
            treeNode948.Text = "A start at a 3D set of methods";
            treeNode949.Name = "Node0";
            treeNode949.Text = "LD3DView";
            treeNode950.Name = "Node10";
            treeNode950.Text = "Version 1.0.0.45";
            treeNode951.Name = "Node1";
            treeNode951.Text = "Create scrollbars for the GraphicsWindow";
            treeNode952.Name = "Node5";
            treeNode952.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode953.Name = "Node0";
            treeNode953.Text = "LDScrollBars";
            treeNode954.Name = "Node4";
            treeNode954.Text = "ColourList method added";
            treeNode955.Name = "Node3";
            treeNode955.Text = "LDUtilities";
            treeNode956.Name = "Node8";
            treeNode956.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode957.Name = "Node9";
            treeNode957.Text = "BackgroundImage method to set the background added";
            treeNode958.Name = "Node6";
            treeNode958.Text = "LDShapes";
            treeNode959.Name = "Node0";
            treeNode959.Text = "Version 1.0.0.44";
            treeNode960.Name = "Node1";
            treeNode960.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode961.Name = "Node0";
            treeNode961.Text = "LDUtilities";
            treeNode962.Name = "Node0";
            treeNode962.Text = "Version 1.0.0.43";
            treeNode963.Name = "Node1";
            treeNode963.Text = "Call Subs as functions with arguments";
            treeNode964.Name = "Node0";
            treeNode964.Text = "LDCall";
            treeNode965.Name = "Node0";
            treeNode965.Text = "Version 1.0.0.42";
            treeNode966.Name = "Node1";
            treeNode966.Text = "Font dialog added";
            treeNode967.Name = "Node2";
            treeNode967.Text = "Colours dialog moved here from LDColours";
            treeNode968.Name = "Node0";
            treeNode968.Text = "LDDialogs";
            treeNode969.Name = "Node9";
            treeNode969.Text = "Version 1.0.0.41";
            treeNode970.Name = "Node1";
            treeNode970.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode971.Name = "Node7";
            treeNode971.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode972.Name = "Node8";
            treeNode972.Text = "Some methods renamed";
            treeNode973.Name = "Node0";
            treeNode973.Text = "LDControls";
            treeNode974.Name = "Node3";
            treeNode974.Text = "HighScore method move here";
            treeNode975.Name = "Node2";
            treeNode975.Text = "LDNetwork";
            treeNode976.Name = "Node6";
            treeNode976.Text = "SetSize method added";
            treeNode977.Name = "Node5";
            treeNode977.Text = "LDShapes";
            treeNode978.Name = "Node3";
            treeNode978.Text = "Version 1.0.0.40";
            treeNode979.Name = "Node1";
            treeNode979.Text = "SelectTreeView method added";
            treeNode980.Name = "Node2";
            treeNode980.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode981.Name = "Node0";
            treeNode981.Text = "LDDialogs";
            treeNode982.Name = "Node1";
            treeNode982.Text = "Simple high score web method";
            treeNode983.Name = "Node0";
            treeNode983.Text = "LDHighScore";
            treeNode984.Name = "Node3";
            treeNode984.Text = "Version 1.0.0.39";
            treeNode985.Name = "Node2";
            treeNode985.Text = "RichTextBox methods improved";
            treeNode986.Name = "Node1";
            treeNode986.Text = "LDDialogs";
            treeNode987.Name = "Node1";
            treeNode987.Text = "Search, Load and Save methods added";
            treeNode988.Name = "Node0";
            treeNode988.Text = "LDArray";
            treeNode989.Name = "Node0";
            treeNode989.Text = "Version 1.0.0.38";
            treeNode990.Name = "Node1";
            treeNode990.Text = "Depreciated";
            treeNode991.Name = "Node0";
            treeNode991.Text = "LDWeather";
            treeNode992.Name = "Node1";
            treeNode992.Text = "Renamed from LDTrig and some more methods added";
            treeNode993.Name = "Node0";
            treeNode993.Text = "LDMath";
            treeNode994.Name = "Node3";
            treeNode994.Text = "RichTextBox method added";
            treeNode995.Name = "Node2";
            treeNode995.Text = "LDDialogs";
            treeNode996.Name = "Node5";
            treeNode996.Text = "FontList method added";
            treeNode997.Name = "Node4";
            treeNode997.Text = "LDUtilities";
            treeNode998.Name = "Node2";
            treeNode998.Text = "Version 1.0.0.37";
            treeNode999.Name = "Node1";
            treeNode999.Text = "Zip method extended";
            treeNode1000.Name = "Node0";
            treeNode1000.Text = "LDUtilities";
            treeNode1001.Name = "Node2";
            treeNode1001.Text = "Version 1.0.0.36";
            treeNode1002.Name = "Node1";
            treeNode1002.Text = "Collapse and expand treeview nodes method added";
            treeNode1003.Name = "Node0";
            treeNode1003.Text = "LDDialogs";
            treeNode1004.Name = "Node5";
            treeNode1004.Text = "Version 1.0.0.35";
            treeNode1005.Name = "Node1";
            treeNode1005.Text = "Arguments added to Start method";
            treeNode1006.Name = "Node0";
            treeNode1006.Text = "LDProcess";
            treeNode1007.Name = "Node4";
            treeNode1007.Text = "Zip compression methods added";
            treeNode1008.Name = "Node2";
            treeNode1008.Text = "LDUtilities";
            treeNode1009.Name = "Node2";
            treeNode1009.Text = "Version 1.0.0.34";
            treeNode1010.Name = "Node1";
            treeNode1010.Text = "GWStyle property added";
            treeNode1011.Name = "Node0";
            treeNode1011.Text = "LDUtilities";
            treeNode1012.Name = "Node1";
            treeNode1012.Text = "TreeView and associated events added";
            treeNode1013.Name = "Node0";
            treeNode1013.Text = "LDDialogs";
            treeNode1014.Name = "Node0";
            treeNode1014.Text = "Version 1.0.0.33";
            treeNode1015.Name = "Node1";
            treeNode1015.Text = "Possible end points not plotting bug fixed";
            treeNode1016.Name = "Node0";
            treeNode1016.Text = "LDGraph";
            treeNode1017.Name = "Node2";
            treeNode1017.Text = "Version 1.0.0.32";
            treeNode1018.Name = "Node1";
            treeNode1018.Text = "Activated event and Active property addded";
            treeNode1019.Name = "Node0";
            treeNode1019.Text = "LDWindows";
            treeNode1020.Name = "Node0";
            treeNode1020.Text = "Version 1.0.0.31";
            treeNode1021.Name = "Node1";
            treeNode1021.Text = "Create multiple GraphicsWindows";
            treeNode1022.Name = "Node0";
            treeNode1022.Text = "LDWindows";
            treeNode1023.Name = "Node0";
            treeNode1023.Text = "Version 1.0.0.30";
            treeNode1024.Name = "Node1";
            treeNode1024.Text = "Email sending method";
            treeNode1025.Name = "Node0";
            treeNode1025.Text = "LDMail";
            treeNode1026.Name = "Node1";
            treeNode1026.Text = "Add and Multiply methods bug fixed";
            treeNode1027.Name = "Node2";
            treeNode1027.Text = "Image statistics combined into one method";
            treeNode1028.Name = "Node3";
            treeNode1028.Text = "Histogram method added";
            treeNode1029.Name = "Node0";
            treeNode1029.Text = "LDImage";
            treeNode1030.Name = "Node0";
            treeNode1030.Text = "Version 1.0.0.29";
            treeNode1031.Name = "Node1";
            treeNode1031.Text = "SnapshotToImageList method added";
            treeNode1032.Name = "Node0";
            treeNode1032.Text = "LDWebCam";
            treeNode1033.Name = "Node3";
            treeNode1033.Text = "ImageList image manipulation methods";
            treeNode1034.Name = "Node2";
            treeNode1034.Text = "LDImage";
            treeNode1035.Name = "Node0";
            treeNode1035.Text = "Version 1.0.0.28";
            treeNode1036.Name = "Node1";
            treeNode1036.Text = "SortIndex bugfix for null values";
            treeNode1037.Name = "Node0";
            treeNode1037.Text = "LDArray";
            treeNode1038.Name = "Node1";
            treeNode1038.Text = "SnapshotToFile bug fixed";
            treeNode1039.Name = "Node0";
            treeNode1039.Text = "LDWebCam";
            treeNode1040.Name = "Node0";
            treeNode1040.Text = "Version 1.0.0.27";
            treeNode1041.Name = "Node1";
            treeNode1041.Text = "SortIndex method added";
            treeNode1042.Name = "Node0";
            treeNode1042.Text = "LDArray";
            treeNode1043.Name = "Node1";
            treeNode1043.Text = "Web based weather report data added";
            treeNode1044.Name = "Node0";
            treeNode1044.Text = "LDWeather";
            treeNode1045.Name = "Node3";
            treeNode1045.Text = "DataReceived event added";
            treeNode1046.Name = "Node2";
            treeNode1046.Text = "LDCommPort";
            treeNode1047.Name = "Node0";
            treeNode1047.Text = "Version 1.0.0.26";
            treeNode1048.Name = "Node1";
            treeNode1048.Text = "Speech recognition added";
            treeNode1049.Name = "Node0";
            treeNode1049.Text = "LDSpeech";
            treeNode1050.Name = "Node0";
            treeNode1050.Text = "Version 1.0.0.25";
            treeNode1051.Name = "Node4";
            treeNode1051.Text = "More methods added and some internal code optimised";
            treeNode1052.Name = "Node0";
            treeNode1052.Text = "LDArray & LDMatrix";
            treeNode1053.Name = "Node1";
            treeNode1053.Text = "KeyDown method added";
            treeNode1054.Name = "Node0";
            treeNode1054.Text = "LDUtilities";
            treeNode1055.Name = "Node1";
            treeNode1055.Text = "GetAllShapesAt method added";
            treeNode1056.Name = "Node0";
            treeNode1056.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode1057.Name = "Node0";
            treeNode1057.Text = "LDShapes";
            treeNode1058.Name = "Node0";
            treeNode1058.Text = "Version 1.0.0.24";
            treeNode1059.Name = "Node1";
            treeNode1059.Text = "OpenFile and SaveFile dialogs added";
            treeNode1060.Name = "Node0";
            treeNode1060.Text = "LDDialogs";
            treeNode1061.Name = "Node2";
            treeNode1061.Text = "Matrix methods, for example to solve linear equations";
            treeNode1062.Name = "Node1";
            treeNode1062.Text = "LDMatrix";
            treeNode1063.Name = "Node0";
            treeNode1063.Text = "Version 1.0.0.23";
            treeNode1064.Name = "Node1";
            treeNode1064.Text = "Sorting method added";
            treeNode1065.Name = "Node0";
            treeNode1065.Text = "LDArray";
            treeNode1066.Name = "Node0";
            treeNode1066.Text = "Version 1.0.0.22";
            treeNode1067.Name = "Node2";
            treeNode1067.Text = "Velocity Threshold setting added";
            treeNode1068.Name = "Node1";
            treeNode1068.Text = "LDPhysics";
            treeNode1069.Name = "Node0";
            treeNode1069.Text = "Version 1.0.0.21";
            treeNode1070.Name = "Node3";
            treeNode1070.Text = "SetDamping method added";
            treeNode1071.Name = "Node2";
            treeNode1071.Text = "LDPhysics";
            treeNode1072.Name = "Node1";
            treeNode1072.Text = "Version 1.0.0.20";
            treeNode1073.Name = "Node1";
            treeNode1073.Text = "Instrument name can be obtained from its number";
            treeNode1074.Name = "Node0";
            treeNode1074.Text = "LDMusic";
            treeNode1075.Name = "Node0";
            treeNode1075.Text = "Version 1.0.0.19";
            treeNode1076.Name = "Node1";
            treeNode1076.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode1077.Name = "Node0";
            treeNode1077.Text = "LDDialogs";
            treeNode1078.Name = "Node1";
            treeNode1078.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode1079.Name = "Node2";
            treeNode1079.Text = "Notes can also be played synchronously (chords)";
            treeNode1080.Name = "Node0";
            treeNode1080.Text = "LDMusic";
            treeNode1081.Name = "Node0";
            treeNode1081.Text = "Version 1.0.0.18";
            treeNode1082.Name = "Node1";
            treeNode1082.Text = "AnimationPause and AnimationResume methods added";
            treeNode1083.Name = "Node0";
            treeNode1083.Text = "LDShapes";
            treeNode1084.Name = "Node1";
            treeNode1084.Text = "Process list indexed by ID rather than name";
            treeNode1085.Name = "Node0";
            treeNode1085.Text = "LDProcess";
            treeNode1086.Name = "Node1";
            treeNode1086.Text = "Version 1.0.0.17";
            treeNode1087.Name = "Node1";
            treeNode1087.Text = "More effects added";
            treeNode1088.Name = "Node0";
            treeNode1088.Text = "LDWebCam";
            treeNode1089.Name = "Node1";
            treeNode1089.Text = "Add or change an image on a button or image shape";
            treeNode1090.Name = "Node1";
            treeNode1090.Text = "Add an animated gif or tiled image";
            treeNode1091.Name = "Node0";
            treeNode1091.Text = "LDShapes";
            treeNode1092.Name = "Node0";
            treeNode1092.Text = "Version 1.0.0.16";
            treeNode1093.Name = "Node1";
            treeNode1093.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode1094.Name = "Node0";
            treeNode1094.Text = "LDWebCam";
            treeNode1095.Name = "Node0";
            treeNode1095.Text = "Version 1.0.0.15";
            treeNode1096.Name = "Node2";
            treeNode1096.Text = "Variables may be changed during a debug session";
            treeNode1097.Name = "Node1";
            treeNode1097.Text = "LDDebug";
            treeNode1098.Name = "Node0";
            treeNode1098.Text = "Version 1.0.0.14";
            treeNode1099.Name = "Node1";
            treeNode1099.Text = "A basic debugging tool";
            treeNode1100.Name = "Node0";
            treeNode1100.Text = "LDDebug";
            treeNode1101.Name = "Node0";
            treeNode1101.Text = "Version 1.0.0.13";
            treeNode1102.Name = "Node2";
            treeNode1102.Text = "Methods to convert between HSL and RGB";
            treeNode1103.Name = "Node18";
            treeNode1103.Text = "Method to set colour opacity";
            treeNode1104.Name = "Node19";
            treeNode1104.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode1105.Name = "Node1";
            treeNode1105.Text = "LDColours";
            treeNode1106.Name = "Node4";
            treeNode1106.Text = "Methods to add and subtract dates and times";
            treeNode1107.Name = "Node3";
            treeNode1107.Text = "LDDateTime";
            treeNode1108.Name = "Node6";
            treeNode1108.Text = "Waiting overlay, Calendar and About popups";
            treeNode1109.Name = "Node17";
            treeNode1109.Text = "Tooltips";
            treeNode1110.Name = "Node5";
            treeNode1110.Text = "LDDialogs";
            treeNode1111.Name = "Node8";
            treeNode1111.Text = "File change event";
            treeNode1112.Name = "Node7";
            treeNode1112.Text = "LDEvents";
            treeNode1113.Name = "Node0";
            treeNode1113.Text = "Version 1.0.0.12";
            treeNode1114.Name = "Node12";
            treeNode1114.Text = "Methods to sort arrays by index or value";
            treeNode1115.Name = "Node22";
            treeNode1115.Text = "Sorting by number and character strings";
            treeNode1116.Name = "Node11";
            treeNode1116.Text = "LDSort";
            treeNode1117.Name = "Node14";
            treeNode1117.Text = "Statistics on any array and distribution generation";
            treeNode1118.Name = "Node20";
            treeNode1118.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode1119.Name = "Node21";
            treeNode1119.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode1120.Name = "Node13";
            treeNode1120.Text = "LDStatistics";
            treeNode1121.Name = "Node16";
            treeNode1121.Text = "Voice and volume added";
            treeNode1122.Name = "Node15";
            treeNode1122.Text = "LDSpeech";
            treeNode1123.Name = "Node9";
            treeNode1123.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode16,
            treeNode37,
            treeNode59,
            treeNode72,
            treeNode80,
            treeNode82,
            treeNode95,
            treeNode108,
            treeNode120,
            treeNode127,
            treeNode137,
            treeNode140,
            treeNode159,
            treeNode176,
            treeNode190,
            treeNode218,
            treeNode232,
            treeNode243,
            treeNode258,
            treeNode273,
            treeNode286,
            treeNode295,
            treeNode310,
            treeNode321,
            treeNode335,
            treeNode344,
            treeNode356,
            treeNode367,
            treeNode370,
            treeNode379,
            treeNode386,
            treeNode393,
            treeNode406,
            treeNode417,
            treeNode422,
            treeNode429,
            treeNode432,
            treeNode446,
            treeNode454,
            treeNode460,
            treeNode475,
            treeNode490,
            treeNode496,
            treeNode504,
            treeNode519,
            treeNode536,
            treeNode539,
            treeNode545,
            treeNode551,
            treeNode561,
            treeNode570,
            treeNode573,
            treeNode593,
            treeNode599,
            treeNode602,
            treeNode611,
            treeNode619,
            treeNode625,
            treeNode630,
            treeNode636,
            treeNode639,
            treeNode652,
            treeNode655,
            treeNode660,
            treeNode665,
            treeNode668,
            treeNode674,
            treeNode678,
            treeNode681,
            treeNode687,
            treeNode691,
            treeNode699,
            treeNode705,
            treeNode711,
            treeNode714,
            treeNode721,
            treeNode728,
            treeNode736,
            treeNode739,
            treeNode742,
            treeNode748,
            treeNode753,
            treeNode760,
            treeNode765,
            treeNode771,
            treeNode774,
            treeNode781,
            treeNode786,
            treeNode790,
            treeNode803,
            treeNode811,
            treeNode816,
            treeNode822,
            treeNode825,
            treeNode832,
            treeNode835,
            treeNode843,
            treeNode846,
            treeNode849,
            treeNode853,
            treeNode857,
            treeNode860,
            treeNode863,
            treeNode866,
            treeNode869,
            treeNode872,
            treeNode875,
            treeNode878,
            treeNode882,
            treeNode885,
            treeNode888,
            treeNode891,
            treeNode899,
            treeNode901,
            treeNode907,
            treeNode913,
            treeNode918,
            treeNode923,
            treeNode926,
            treeNode929,
            treeNode932,
            treeNode935,
            treeNode941,
            treeNode944,
            treeNode947,
            treeNode950,
            treeNode959,
            treeNode962,
            treeNode965,
            treeNode969,
            treeNode978,
            treeNode984,
            treeNode989,
            treeNode998,
            treeNode1001,
            treeNode1004,
            treeNode1009,
            treeNode1014,
            treeNode1017,
            treeNode1020,
            treeNode1023,
            treeNode1030,
            treeNode1035,
            treeNode1040,
            treeNode1047,
            treeNode1050,
            treeNode1058,
            treeNode1063,
            treeNode1066,
            treeNode1069,
            treeNode1072,
            treeNode1075,
            treeNode1081,
            treeNode1086,
            treeNode1092,
            treeNode1095,
            treeNode1098,
            treeNode1101,
            treeNode1113,
            treeNode1123});
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