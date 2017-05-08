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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SHA512HashFile method added");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Broadcast method added");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LDServer", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("AutoControl2 scene camera mode added (for model inspection)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Various auto control improvements");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("SwapUpDirection method added");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Improved PauseUpdates and ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LDGraphicsWIndow", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("3D vector algebra methods added");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("LDVector", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("LastListViewColumn event property added");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ListView subscribes to LDControls selection events");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Version 1.2.16.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode8,
            treeNode10,
            treeNode12,
            treeNode14,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Read and Write methods extended to read and write unindexed lines for 1D arrays");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Animate method added");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Fix for indent tab for non-paragraph rtf blocks");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("ResetMaterial method added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("GetPosition method added");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("RSA public private key methods added");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode21,
            treeNode23,
            treeNode25,
            treeNode28,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
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
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35,
            treeNode37,
            treeNode48,
            treeNode51,
            treeNode56,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode61,
            treeNode63,
            treeNode69,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode77,
            treeNode79,
            treeNode81,
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91,
            treeNode92});
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode89,
            treeNode93,
            treeNode95,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103,
            treeNode104,
            treeNode105,
            treeNode106,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode108,
            treeNode110,
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode124,
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode116,
            treeNode118,
            treeNode120,
            treeNode123,
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode129,
            treeNode131,
            treeNode133,
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode139,
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode144,
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode138,
            treeNode141,
            treeNode143,
            treeNode146,
            treeNode148,
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode154,
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode159,
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode153,
            treeNode156,
            treeNode158,
            treeNode161});
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode163,
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode165,
            treeNode167,
            treeNode169,
            treeNode171,
            treeNode173,
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode177,
            treeNode178,
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode183});
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode180,
            treeNode182,
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode190,
            treeNode191,
            treeNode192});
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode194,
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode187,
            treeNode189,
            treeNode193,
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode206});
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode199,
            treeNode201,
            treeNode203,
            treeNode205,
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode214});
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode213,
            treeNode215,
            treeNode217,
            treeNode219});
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode221});
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode223});
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode225});
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode222,
            treeNode224,
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode232});
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode229,
            treeNode231,
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode238,
            treeNode239,
            treeNode240,
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode237,
            treeNode242,
            treeNode244,
            treeNode246});
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode250});
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode256});
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode249,
            treeNode251,
            treeNode253,
            treeNode255,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode261});
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode260,
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode264});
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode266});
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode265,
            treeNode267,
            treeNode269});
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode274,
            treeNode275,
            treeNode276,
            treeNode277});
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode279,
            treeNode280});
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode282,
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode278,
            treeNode281,
            treeNode284,
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode290,
            treeNode292,
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode296,
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode298,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode302,
            treeNode303,
            treeNode304,
            treeNode305,
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode308,
            treeNode309,
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode307,
            treeNode311,
            treeNode313,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode319});
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode321});
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode318,
            treeNode320,
            treeNode322,
            treeNode324,
            treeNode326,
            treeNode328,
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode332,
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode335});
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode334,
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode338});
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode340,
            treeNode341,
            treeNode342,
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode339,
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode348,
            treeNode349});
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode358});
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode347,
            treeNode350,
            treeNode353,
            treeNode355,
            treeNode357,
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode361,
            treeNode362});
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode364});
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode368,
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode363,
            treeNode365,
            treeNode367,
            treeNode370,
            treeNode372,
            treeNode374,
            treeNode376});
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode379});
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode381,
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode383,
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode387,
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode390});
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode389,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode393,
            treeNode394,
            treeNode395,
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode397,
            treeNode399,
            treeNode401});
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode403});
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode405});
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode404,
            treeNode406,
            treeNode408,
            treeNode410});
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode415,
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode418,
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode423,
            treeNode424});
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode417,
            treeNode420,
            treeNode422,
            treeNode425,
            treeNode427,
            treeNode429,
            treeNode431,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode435,
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode438});
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode437,
            treeNode439});
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode441});
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode448,
            treeNode449,
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode445,
            treeNode447,
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode455,
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode454,
            treeNode457,
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode461});
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode463,
            treeNode464});
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode462,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode468,
            treeNode470});
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode474,
            treeNode475});
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode473,
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode478});
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode481,
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode484});
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode490,
            treeNode491});
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode483,
            treeNode485,
            treeNode487,
            treeNode489,
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode498,
            treeNode500});
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode503,
            treeNode505});
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode507});
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode510,
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode512,
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode516,
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode523,
            treeNode524});
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode525,
            treeNode527});
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode529,
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode531});
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode537,
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode534,
            treeNode536,
            treeNode539});
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode543,
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode542,
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode547,
            treeNode548,
            treeNode549,
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode554});
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode557,
            treeNode559,
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode563});
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode565});
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode564,
            treeNode566,
            treeNode568});
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode570});
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode574,
            treeNode575});
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode571,
            treeNode573,
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode579});
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode584});
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode586,
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode585,
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode590,
            treeNode591,
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode596,
            treeNode598,
            treeNode600});
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode603,
            treeNode605});
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode609,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode608,
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode614});
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode617,
            treeNode619,
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode624,
            treeNode626});
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode628,
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode637});
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode639});
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode641,
            treeNode642});
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode632,
            treeNode634,
            treeNode636,
            treeNode638,
            treeNode640,
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode645,
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode648});
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode647,
            treeNode649,
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode654,
            treeNode656});
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode658,
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode660,
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode669,
            treeNode670,
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode668,
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode679,
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode678,
            treeNode681,
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode688});
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode691,
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode695,
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode712});
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode720,
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode733,
            treeNode735,
            treeNode737,
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode743,
            treeNode744});
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode745,
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode749,
            treeNode751,
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode756,
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode761,
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode768});
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode772});
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode777,
            treeNode778});
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode779,
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode790});
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode792,
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode797,
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode794,
            treeNode796,
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode807,
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode811,
            treeNode812,
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode814,
            treeNode816,
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode820,
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode822,
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode826});
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode827,
            treeNode829});
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode832,
            treeNode834,
            treeNode836,
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode840});
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode847,
            treeNode849});
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode851});
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode852,
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode857});
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode863});
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode867,
            treeNode868,
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode866,
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode873,
            treeNode875});
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode878,
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode883,
            treeNode885,
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode890});
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode892});
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode894});
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode896,
            treeNode897});
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode893,
            treeNode895,
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode900});
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode902});
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode901,
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode906});
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode908});
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode909});
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode911});
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode914});
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode915});
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode917});
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode919,
            treeNode920});
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode918,
            treeNode921});
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode923});
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode925});
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode924,
            treeNode926});
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode930,
            treeNode931});
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode929,
            treeNode932});
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode934});
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode935});
            System.Windows.Forms.TreeNode treeNode937 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode938 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode937});
            System.Windows.Forms.TreeNode treeNode939 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode938});
            System.Windows.Forms.TreeNode treeNode940 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode941 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode940});
            System.Windows.Forms.TreeNode treeNode942 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode941});
            System.Windows.Forms.TreeNode treeNode943 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode944 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode945 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode946 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode943,
            treeNode944,
            treeNode945});
            System.Windows.Forms.TreeNode treeNode947 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode948 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode947});
            System.Windows.Forms.TreeNode treeNode949 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode950 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode951 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode949,
            treeNode950});
            System.Windows.Forms.TreeNode treeNode952 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode953 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode952});
            System.Windows.Forms.TreeNode treeNode954 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode946,
            treeNode948,
            treeNode951,
            treeNode953});
            System.Windows.Forms.TreeNode treeNode955 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode956 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode957 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode955,
            treeNode956});
            System.Windows.Forms.TreeNode treeNode958 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode959 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode960 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode961 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode958,
            treeNode959,
            treeNode960});
            System.Windows.Forms.TreeNode treeNode962 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode963 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode962});
            System.Windows.Forms.TreeNode treeNode964 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode957,
            treeNode961,
            treeNode963});
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
            this.treeView1.Location = new System.Drawing.Point(16, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "SHA512HashFile method added";
            treeNode2.Name = "Node1";
            treeNode2.Text = "LDEncryption";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Broadcast method added";
            treeNode4.Name = "Node0";
            treeNode4.Text = "LDServer";
            treeNode5.Name = "Node1";
            treeNode5.Text = "AutoControl2 scene camera mode added (for model inspection)";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Various auto control improvements";
            treeNode7.Name = "Node7";
            treeNode7.Text = "SwapUpDirection method added";
            treeNode8.Name = "Node0";
            treeNode8.Text = "LD3DView";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Improved PauseUpdates and ResumeUpdates";
            treeNode10.Name = "Node3";
            treeNode10.Text = "LDGraphicsWIndow";
            treeNode11.Name = "Node6";
            treeNode11.Text = "3D vector algebra methods added";
            treeNode12.Name = "Node5";
            treeNode12.Text = "LDVector";
            treeNode13.Name = "Node1";
            treeNode13.Text = "LastListViewColumn event property added";
            treeNode14.Name = "Node0";
            treeNode14.Text = "LDControls";
            treeNode15.Name = "Node3";
            treeNode15.Text = "ListView subscribes to LDControls selection events";
            treeNode16.Name = "Node2";
            treeNode16.Text = "LDDatabase";
            treeNode17.Name = "Node0";
            treeNode17.Text = "Version 1.2.16.0";
            treeNode18.Name = "Node1";
            treeNode18.Text = "Read and Write methods extended to read and write unindexed lines for 1D arrays";
            treeNode19.Name = "Node0";
            treeNode19.Text = "LDFastArray";
            treeNode20.Name = "Node3";
            treeNode20.Text = "Animate method added";
            treeNode21.Name = "Node2";
            treeNode21.Text = "LDGraphicsWindow";
            treeNode22.Name = "Node1";
            treeNode22.Text = "Fix for indent tab for non-paragraph rtf blocks";
            treeNode23.Name = "Node0";
            treeNode23.Text = "LDControls";
            treeNode24.Name = "Node3";
            treeNode24.Text = "Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated";
            treeNode25.Name = "Node2";
            treeNode25.Text = "LDTextWindow";
            treeNode26.Name = "Node1";
            treeNode26.Text = "ResetMaterial method added";
            treeNode27.Name = "Node2";
            treeNode27.Text = "GetPosition method added";
            treeNode28.Name = "Node0";
            treeNode28.Text = "LD3DView";
            treeNode29.Name = "Node1";
            treeNode29.Text = "RSA public private key methods added";
            treeNode30.Name = "Node0";
            treeNode30.Text = "LDEncryption";
            treeNode31.Name = "Node0";
            treeNode31.Text = "Version 1.2.15.0";
            treeNode32.Name = "Node2";
            treeNode32.Text = "Possible unclosed zip conflicts fixed";
            treeNode33.Name = "Node1";
            treeNode33.Text = "LDZip";
            treeNode34.Name = "Node5";
            treeNode34.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode35.Name = "Node3";
            treeNode35.Text = "LDStopwatch";
            treeNode36.Name = "Node7";
            treeNode36.Text = "LDTimer object added for additional timers";
            treeNode37.Name = "Node6";
            treeNode37.Text = "LDTimer";
            treeNode38.Name = "Node1";
            treeNode38.Text = "Speedup of selected critical performance code listed below";
            treeNode39.Name = "Node2";
            treeNode39.Text = "1) LDShapes.FastMove";
            treeNode40.Name = "Node3";
            treeNode40.Text = "2) LDPhysics graphical updates";
            treeNode41.Name = "Node4";
            treeNode41.Text = "3) LDImage and LDwebCam image processing";
            treeNode42.Name = "Node6";
            treeNode42.Text = "4) LDFastShapes";
            treeNode43.Name = "Node7";
            treeNode43.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode44.Name = "Node8";
            treeNode44.Text = "6) Selected LD3DView visual updates";
            treeNode45.Name = "Node9";
            treeNode45.Text = "7) LDEffect";
            treeNode46.Name = "Node10";
            treeNode46.Text = "8) LDGraph";
            treeNode47.Name = "Node11";
            treeNode47.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode48.Name = "Node0";
            treeNode48.Text = "General";
            treeNode49.Name = "Node1";
            treeNode49.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode50.Name = "Node2";
            treeNode50.Text = "CSV file read and write";
            treeNode51.Name = "Node0";
            treeNode51.Text = "LDFastArray";
            treeNode52.Name = "Node1";
            treeNode52.Text = "DataViewColAlignment method added";
            treeNode53.Name = "Node2";
            treeNode53.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode54.Name = "Node0";
            treeNode54.Text = "RichTextBoxTextTyped event added";
            treeNode55.Name = "Node1";
            treeNode55.Text = "RichTextBoxIndentToTab property added";
            treeNode56.Name = "Node0";
            treeNode56.Text = "LDControls";
            treeNode57.Name = "Node4";
            treeNode57.Text = "OverlapDetail property added";
            treeNode58.Name = "Node3";
            treeNode58.Text = "LDShapes";
            treeNode59.Name = "Node0";
            treeNode59.Text = "Version 1.2.14.0";
            treeNode60.Name = "Node2";
            treeNode60.Text = "TEMP tables allowed for SQLite databases";
            treeNode61.Name = "Node1";
            treeNode61.Text = "LDDataBase";
            treeNode62.Name = "Node1";
            treeNode62.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode63.Name = "Node0";
            treeNode63.Text = "LDMath";
            treeNode64.Name = "Node1";
            treeNode64.Text = "NormalMap method added for normal map 3D effects";
            treeNode65.Name = "Node2";
            treeNode65.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode66.Name = "Node5";
            treeNode66.Text = "MakeTransparent method added";
            treeNode67.Name = "Node6";
            treeNode67.Text = "ReplaceColour method added";
            treeNode68.Name = "Node0";
            treeNode68.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode69.Name = "Node0";
            treeNode69.Text = "LDImage";
            treeNode70.Name = "Node4";
            treeNode70.Text = "All image pixel manipulations speeded up";
            treeNode71.Name = "Node7";
            treeNode71.Text = "More Culture Invariace fixes";
            treeNode72.Name = "Node3";
            treeNode72.Text = "General";
            treeNode73.Name = "Node0";
            treeNode73.Text = "Version 1.2.13.0";
            treeNode74.Name = "Node1";
            treeNode74.Text = "Base conversions extended to include bases up to 36";
            treeNode75.Name = "Node0";
            treeNode75.Text = "LDMath";
            treeNode76.Name = "Node3";
            treeNode76.Text = "Updated to new Bing API";
            treeNode77.Name = "Node2";
            treeNode77.Text = "LDSearch";
            treeNode78.Name = "Node1";
            treeNode78.Text = "ShowInTaskbar property added";
            treeNode79.Name = "Node0";
            treeNode79.Text = "LDGraphicsWindow";
            treeNode80.Name = "Node1";
            treeNode80.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode81.Name = "Node0";
            treeNode81.Text = "LDFile";
            treeNode82.Name = "Node1";
            treeNode82.Text = "ToArray and FromArray methods added";
            treeNode83.Name = "Node0";
            treeNode83.Text = "LDxml";
            treeNode84.Name = "Node0";
            treeNode84.Text = "Version 1.2.12.0";
            treeNode85.Name = "Node2";
            treeNode85.Text = "DataViewColumnWidths method added";
            treeNode86.Name = "Node3";
            treeNode86.Text = "DataViewRowColours method added";
            treeNode87.Name = "Node1";
            treeNode87.Text = "LDControls";
            treeNode88.Name = "Node1";
            treeNode88.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode89.Name = "Node0";
            treeNode89.Text = "General";
            treeNode90.Name = "Node1";
            treeNode90.Text = "SetCentre method added";
            treeNode91.Name = "Node4";
            treeNode91.Text = "A 3rd rotation added";
            treeNode92.Name = "Node3";
            treeNode92.Text = "BoundingBox method added";
            treeNode93.Name = "Node0";
            treeNode93.Text = "LD3DView";
            treeNode94.Name = "Node3";
            treeNode94.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode95.Name = "Node2";
            treeNode95.Text = "LDDatabase";
            treeNode96.Name = "Node1";
            treeNode96.Text = "PlayMusic2 method added";
            treeNode97.Name = "Node2";
            treeNode97.Text = "Channel parameter added";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LDMusic";
            treeNode99.Name = "Node0";
            treeNode99.Text = "Version 1.2.11.0";
            treeNode100.Name = "Node1";
            treeNode100.Text = "SetButtonStyle method added";
            treeNode101.Name = "Node0";
            treeNode101.Text = "LDControls";
            treeNode102.Name = "Node1";
            treeNode102.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode103.Name = "Node2";
            treeNode103.Text = "SetBillBoard method added";
            treeNode104.Name = "Node0";
            treeNode104.Text = "GetCameraUpDirection method added";
            treeNode105.Name = "Node1";
            treeNode105.Text = "Gradient brushes can be used";
            treeNode106.Name = "Node2";
            treeNode106.Text = "AutoControl method added";
            treeNode107.Name = "Node0";
            treeNode107.Text = "SpecularExponent property added";
            treeNode108.Name = "Node0";
            treeNode108.Text = "LD3DView";
            treeNode109.Name = "Node1";
            treeNode109.Text = "AddText method to annotate an image with text added";
            treeNode110.Name = "Node0";
            treeNode110.Text = "LDImage";
            treeNode111.Name = "Node4";
            treeNode111.Text = "BrushText for text on a brush added";
            treeNode112.Name = "Node0";
            treeNode112.Text = "Skew shapes method added";
            treeNode113.Name = "Node3";
            treeNode113.Text = "LDShapes";
            treeNode114.Name = "Node0";
            treeNode114.Text = "Version 1.2.10.0";
            treeNode115.Name = "Node1";
            treeNode115.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDUnits";
            treeNode117.Name = "Node1";
            treeNode117.Text = "Possible issue with FixSigFig fixed";
            treeNode118.Name = "Node0";
            treeNode118.Text = "LDMath";
            treeNode119.Name = "Node3";
            treeNode119.Text = "GetIndex method added (for SB arrays)";
            treeNode120.Name = "Node2";
            treeNode120.Text = "LDArray";
            treeNode121.Name = "Node5";
            treeNode121.Text = "Resize mode property added";
            treeNode122.Name = "Node6";
            treeNode122.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode123.Name = "Node4";
            treeNode123.Text = "LDGraphicsWindow";
            treeNode124.Name = "Node8";
            treeNode124.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode125.Name = "Node9";
            treeNode125.Text = "DataViewAllowUserEntry method added";
            treeNode126.Name = "Node7";
            treeNode126.Text = "LDControls";
            treeNode127.Name = "Node0";
            treeNode127.Text = "Version 1.2.9.0";
            treeNode128.Name = "Node1";
            treeNode128.Text = "New extended math object, starting with FFT";
            treeNode129.Name = "Node0";
            treeNode129.Text = "LDMathX";
            treeNode130.Name = "Node1";
            treeNode130.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDControls";
            treeNode132.Name = "Node3";
            treeNode132.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode133.Name = "Node2";
            treeNode133.Text = "LDArray";
            treeNode134.Name = "Node5";
            treeNode134.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode135.Name = "Node4";
            treeNode135.Text = "LDList";
            treeNode136.Name = "Node0";
            treeNode136.Text = "Version 1.2.8.0";
            treeNode137.Name = "Node2";
            treeNode137.Text = "Error handling, additional settings and multiple ports supported";
            treeNode138.Name = "Node1";
            treeNode138.Text = "LDCommPort";
            treeNode139.Name = "Node1";
            treeNode139.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode140.Name = "Node1";
            treeNode140.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode141.Name = "Node0";
            treeNode141.Text = "LDImage and LDWebCam";
            treeNode142.Name = "Node1";
            treeNode142.Text = "Bitwise operations object added";
            treeNode143.Name = "Node0";
            treeNode143.Text = "LDBits";
            treeNode144.Name = "Node1";
            treeNode144.Text = "Extended text encoding property added";
            treeNode145.Name = "Node0";
            treeNode145.Text = "TextWindow colours can be changed";
            treeNode146.Name = "Node0";
            treeNode146.Text = "LDTextWindow";
            treeNode147.Name = "Node1";
            treeNode147.Text = "GetWorkingImagePixelARGB method added";
            treeNode148.Name = "Node0";
            treeNode148.Text = "LDImage";
            treeNode149.Name = "Node1";
            treeNode149.Text = "RasteriseTurtleLines method added";
            treeNode150.Name = "Node0";
            treeNode150.Text = "LDShapes";
            treeNode151.Name = "Node0";
            treeNode151.Text = "Version 1.2.7.0";
            treeNode152.Name = "Node1";
            treeNode152.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode153.Name = "Node0";
            treeNode153.Text = "LDDialogs";
            treeNode154.Name = "Node1";
            treeNode154.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode155.Name = "Node2";
            treeNode155.Text = "ToggleSensor added";
            treeNode156.Name = "Node0";
            treeNode156.Text = "LDPhysics";
            treeNode157.Name = "Node1";
            treeNode157.Text = "Allow multiple copies of the webcam image";
            treeNode158.Name = "Node0";
            treeNode158.Text = "LDWebCam";
            treeNode159.Name = "Node1";
            treeNode159.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode160.Name = "Node0";
            treeNode160.Text = "MetaData method added";
            treeNode161.Name = "Node0";
            treeNode161.Text = "LDImage";
            treeNode162.Name = "Node0";
            treeNode162.Text = "Version 1.2.6.0";
            treeNode163.Name = "Node2";
            treeNode163.Text = "FixSigFig and FixDecimal methods added";
            treeNode164.Name = "Node3";
            treeNode164.Text = "MinNumber and MaxNumber properties added";
            treeNode165.Name = "Node1";
            treeNode165.Text = "LDMath";
            treeNode166.Name = "Node1";
            treeNode166.Text = "SliderMaximum property added";
            treeNode167.Name = "Node0";
            treeNode167.Text = "LDControls";
            treeNode168.Name = "Node1";
            treeNode168.Text = "ZoomAll method added";
            treeNode169.Name = "Node0";
            treeNode169.Text = "LDShapes";
            treeNode170.Name = "Node1";
            treeNode170.Text = "Reposition methods and properties added";
            treeNode171.Name = "Node0";
            treeNode171.Text = "LDGraphicsWindow";
            treeNode172.Name = "Node1";
            treeNode172.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode173.Name = "Node0";
            treeNode173.Text = "LDImage";
            treeNode174.Name = "Node1";
            treeNode174.Text = "MouseScroll parameter added";
            treeNode175.Name = "Node0";
            treeNode175.Text = "LDScrollBars";
            treeNode176.Name = "Node0";
            treeNode176.Text = "Version 1.2.5.0";
            treeNode177.Name = "Node0";
            treeNode177.Text = "New object added (previously a separate extension)";
            treeNode178.Name = "Node1";
            treeNode178.Text = "Async, Loop, Volume and Pan properties added";
            treeNode179.Name = "Node2";
            treeNode179.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode180.Name = "Node1";
            treeNode180.Text = "LDWaveForm";
            treeNode181.Name = "Node1";
            treeNode181.Text = "New object added to get input from gamepads or joysticks";
            treeNode182.Name = "Node0";
            treeNode182.Text = "LDController";
            treeNode183.Name = "Node1";
            treeNode183.Text = "RayCast method added";
            treeNode184.Name = "Node0";
            treeNode184.Text = "LDPhysics";
            treeNode185.Name = "Node0";
            treeNode185.Text = "Version 1.2.4.0";
            treeNode186.Name = "Node2";
            treeNode186.Text = "New object to apply effects to any shape or control";
            treeNode187.Name = "Node1";
            treeNode187.Text = "LDEffects";
            treeNode188.Name = "Node1";
            treeNode188.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode189.Name = "Node0";
            treeNode189.Text = "LDFigures";
            treeNode190.Name = "Node1";
            treeNode190.Text = "SetGroup method added";
            treeNode191.Name = "Node2";
            treeNode191.Text = "GetContacts method added";
            treeNode192.Name = "Node0";
            treeNode192.Text = "GetAllShapesAt method added";
            treeNode193.Name = "Node0";
            treeNode193.Text = "LDPhysics";
            treeNode194.Name = "Node2";
            treeNode194.Text = "SetImage handles images with transparency";
            treeNode195.Name = "Node0";
            treeNode195.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode196.Name = "Node1";
            treeNode196.Text = "LDClipboard";
            treeNode197.Name = "Node0";
            treeNode197.Text = "Version 1.2.3.0";
            treeNode198.Name = "Node2";
            treeNode198.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode199.Name = "Node1";
            treeNode199.Text = "LDShapes";
            treeNode200.Name = "Node4";
            treeNode200.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode201.Name = "Node3";
            treeNode201.Text = "LDFile";
            treeNode202.Name = "Node6";
            treeNode202.Text = "NewImage method added";
            treeNode203.Name = "Node5";
            treeNode203.Text = "LDImage";
            treeNode204.Name = "Node1";
            treeNode204.Text = "SetStartupPosition method added to position dialogs";
            treeNode205.Name = "Node0";
            treeNode205.Text = "LDDialogs";
            treeNode206.Name = "Node1";
            treeNode206.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode207.Name = "Node0";
            treeNode207.Text = "LDGraph";
            treeNode208.Name = "Node0";
            treeNode208.Text = "Version 1.2.2.0";
            treeNode209.Name = "Node2";
            treeNode209.Text = "Recompiled for Small Basic version 1.2";
            treeNode210.Name = "Node1";
            treeNode210.Text = "Version 1.2";
            treeNode211.Name = "Node0";
            treeNode211.Text = "Version 1.2.0.1";
            treeNode212.Name = "Node2";
            treeNode212.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode213.Name = "Node1";
            treeNode213.Text = "LDDialogs";
            treeNode214.Name = "Node1";
            treeNode214.Text = "Logical operations object added";
            treeNode215.Name = "Node0";
            treeNode215.Text = "LDLogic";
            treeNode216.Name = "Node4";
            treeNode216.Text = "CurrentCulture property added";
            treeNode217.Name = "Node3";
            treeNode217.Text = "LDUtilities";
            treeNode218.Name = "Node6";
            treeNode218.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode219.Name = "Node5";
            treeNode219.Text = "LDMath";
            treeNode220.Name = "Node0";
            treeNode220.Text = "Version 1.1.0.8";
            treeNode221.Name = "Node1";
            treeNode221.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode222.Name = "Node0";
            treeNode222.Text = "LDControls";
            treeNode223.Name = "Node1";
            treeNode223.Text = "Methods added to add and remove nodes and save xml file";
            treeNode224.Name = "Node0";
            treeNode224.Text = "LDxml";
            treeNode225.Name = "Node1";
            treeNode225.Text = "MusicPlayTime moved from LDFile";
            treeNode226.Name = "Node0";
            treeNode226.Text = "LDSound";
            treeNode227.Name = "Node0";
            treeNode227.Text = "Version 1.1.0.7";
            treeNode228.Name = "Node4";
            treeNode228.Text = "SplitImage method added";
            treeNode229.Name = "Node3";
            treeNode229.Text = "LDImage";
            treeNode230.Name = "Node6";
            treeNode230.Text = "EditTable and SaveTable methods added";
            treeNode231.Name = "Node5";
            treeNode231.Text = "LDDatabse";
            treeNode232.Name = "Node2";
            treeNode232.Text = "DataView control and methods added";
            treeNode233.Name = "Node1";
            treeNode233.Text = "LDControls";
            treeNode234.Name = "Node2";
            treeNode234.Text = "Version 1.1.0.6";
            treeNode235.Name = "Node2";
            treeNode235.Text = "Exists modified to check for directory as well as file";
            treeNode236.Name = "Node3";
            treeNode236.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode237.Name = "Node1";
            treeNode237.Text = "LDFile";
            treeNode238.Name = "Node5";
            treeNode238.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode239.Name = "Node6";
            treeNode239.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode240.Name = "Node9";
            treeNode240.Text = "Conditonal break point added";
            treeNode241.Name = "Node0";
            treeNode241.Text = "Step over button added";
            treeNode242.Name = "Node4";
            treeNode242.Text = "LDDebug";
            treeNode243.Name = "Node8";
            treeNode243.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode244.Name = "Node7";
            treeNode244.Text = "LDGraphicsWindow";
            treeNode245.Name = "Node1";
            treeNode245.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode246.Name = "Node0";
            treeNode246.Text = "LDResources";
            treeNode247.Name = "Node0";
            treeNode247.Text = "Version 1.1.0.5";
            treeNode248.Name = "Node2";
            treeNode248.Text = "ClipboardChanged event added";
            treeNode249.Name = "Node1";
            treeNode249.Text = "LDClipboard";
            treeNode250.Name = "Node1";
            treeNode250.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode251.Name = "Node0";
            treeNode251.Text = "LDFile";
            treeNode252.Name = "Node3";
            treeNode252.Text = "SetActive method added";
            treeNode253.Name = "Node2";
            treeNode253.Text = "LDGraphicsWindow";
            treeNode254.Name = "Node1";
            treeNode254.Text = "Parse xml file nodes";
            treeNode255.Name = "Node0";
            treeNode255.Text = "LDxml";
            treeNode256.Name = "Node3";
            treeNode256.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode257.Name = "Node2";
            treeNode257.Text = "General";
            treeNode258.Name = "Node0";
            treeNode258.Text = "Version 1.1.0.4";
            treeNode259.Name = "Node2";
            treeNode259.Text = "WakeAll method addded";
            treeNode260.Name = "Node1";
            treeNode260.Text = "LDPhysics";
            treeNode261.Name = "Node1";
            treeNode261.Text = "Clipboard methods added";
            treeNode262.Name = "Node0";
            treeNode262.Text = "LDClipboard";
            treeNode263.Name = "Node0";
            treeNode263.Text = "Version 1.1.0.3";
            treeNode264.Name = "Node6";
            treeNode264.Text = "SizeNWSE cursor added";
            treeNode265.Name = "Node5";
            treeNode265.Text = "LDCursors";
            treeNode266.Name = "Node8";
            treeNode266.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode267.Name = "Node7";
            treeNode267.Text = "LDGraph";
            treeNode268.Name = "Node1";
            treeNode268.Text = "SQLite updated for .Net 4.5";
            treeNode269.Name = "Node0";
            treeNode269.Text = "LDDataBase";
            treeNode270.Name = "Node4";
            treeNode270.Text = "Version 1.1.0.2";
            treeNode271.Name = "Node3";
            treeNode271.Text = "Recompiled for Small Basic version 1.1";
            treeNode272.Name = "Node2";
            treeNode272.Text = "Version 1.1";
            treeNode273.Name = "Node0";
            treeNode273.Text = "Version 1.1.0.1";
            treeNode274.Name = "Node12";
            treeNode274.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode275.Name = "Node13";
            treeNode275.Text = "RichTextBoxMargins method added";
            treeNode276.Name = "Node0";
            treeNode276.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode277.Name = "Node1";
            treeNode277.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode278.Name = "Node11";
            treeNode278.Text = "LDControls";
            treeNode279.Name = "Node3";
            treeNode279.Text = "Error reporting added";
            treeNode280.Name = "Node4";
            treeNode280.Text = "SetEncoding method added";
            treeNode281.Name = "Node2";
            treeNode281.Text = "LDCommPort";
            treeNode282.Name = "Node6";
            treeNode282.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode283.Name = "Node7";
            treeNode283.Text = "Export to excel fix for graph with no title";
            treeNode284.Name = "Node5";
            treeNode284.Text = "LDGraph";
            treeNode285.Name = "Node9";
            treeNode285.Text = "Negative restitution option when adding moving shape";
            treeNode286.Name = "Node8";
            treeNode286.Text = "LDPhysics";
            treeNode287.Name = "Node10";
            treeNode287.Text = "Version 1.0.0.133";
            treeNode288.Name = "Node2";
            treeNode288.Text = "Internal improvements to auto messaging";
            treeNode289.Name = "Node9";
            treeNode289.Text = "Name can be set and GetClients method added";
            treeNode290.Name = "Node1";
            treeNode290.Text = "LDClient";
            treeNode291.Name = "Node4";
            treeNode291.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode292.Name = "Node3";
            treeNode292.Text = "LDControls";
            treeNode293.Name = "Node8";
            treeNode293.Text = "Return message and possible file error fixed for Stop method";
            treeNode294.Name = "Node7";
            treeNode294.Text = "LDSound";
            treeNode295.Name = "Node0";
            treeNode295.Text = "Version 1.0.0.132";
            treeNode296.Name = "Node2";
            treeNode296.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode297.Name = "Node5";
            treeNode297.Text = "Compile method added to compile a Small Basic program";
            treeNode298.Name = "Node1";
            treeNode298.Text = "LDCall";
            treeNode299.Name = "Node4";
            treeNode299.Text = "Methods and code by Pappa Lapub added";
            treeNode300.Name = "Node3";
            treeNode300.Text = "LDShell";
            treeNode301.Name = "Node0";
            treeNode301.Text = "Version 1.0.0.131";
            treeNode302.Name = "Node6";
            treeNode302.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode303.Name = "Node7";
            treeNode303.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode304.Name = "Node8";
            treeNode304.Text = "Refactoring of all the pan, follow and box methods";
            treeNode305.Name = "Node6";
            treeNode305.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode306.Name = "Node8";
            treeNode306.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode307.Name = "Node5";
            treeNode307.Text = "LDPhysics";
            treeNode308.Name = "Node1";
            treeNode308.Text = "UseBinary property added";
            treeNode309.Name = "Node2";
            treeNode309.Text = "DoAsync property and associated completion events added";
            treeNode310.Name = "Node3";
            treeNode310.Text = "Delete method added";
            treeNode311.Name = "Node0";
            treeNode311.Text = "LDftp";
            treeNode312.Name = "Node5";
            treeNode312.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode313.Name = "Node4";
            treeNode313.Text = "LDCall";
            treeNode314.Name = "Node2";
            treeNode314.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode315.Name = "Node1";
            treeNode315.Text = "LDControls";
            treeNode316.Name = "Node4";
            treeNode316.Text = "Version 1.0.0.130";
            treeNode317.Name = "Node2";
            treeNode317.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode318.Name = "Node1";
            treeNode318.Text = "LDMath";
            treeNode319.Name = "Node1";
            treeNode319.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode320.Name = "Node0";
            treeNode320.Text = "LDPhysics";
            treeNode321.Name = "Node3";
            treeNode321.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode322.Name = "Node2";
            treeNode322.Text = "LDGraphicsWindow";
            treeNode323.Name = "Node1";
            treeNode323.Text = "FTP object methods added";
            treeNode324.Name = "Node0";
            treeNode324.Text = "LDftp";
            treeNode325.Name = "Node3";
            treeNode325.Text = "An existing file is replaced";
            treeNode326.Name = "Node2";
            treeNode326.Text = "LDZip";
            treeNode327.Name = "Node1";
            treeNode327.Text = "Size method added";
            treeNode328.Name = "Node0";
            treeNode328.Text = "LDFile";
            treeNode329.Name = "Node3";
            treeNode329.Text = "DownloadFile method added";
            treeNode330.Name = "Node2";
            treeNode330.Text = "LDNetwork";
            treeNode331.Name = "Node0";
            treeNode331.Text = "Version 1.0.0.129";
            treeNode332.Name = "Node2";
            treeNode332.Text = "Generalised joint connections added";
            treeNode333.Name = "Node0";
            treeNode333.Text = "AddExplosion method added";
            treeNode334.Name = "Node1";
            treeNode334.Text = "LDPhysics";
            treeNode335.Name = "Node1";
            treeNode335.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode336.Name = "Node0";
            treeNode336.Text = "LDShapes";
            treeNode337.Name = "Node0";
            treeNode337.Text = "Version 1.0.0.128";
            treeNode338.Name = "Node2";
            treeNode338.Text = "CheckServer method added";
            treeNode339.Name = "Node1";
            treeNode339.Text = "LDClient";
            treeNode340.Name = "Node1";
            treeNode340.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode341.Name = "Node2";
            treeNode341.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode342.Name = "Node3";
            treeNode342.Text = "GetAngle method added";
            treeNode343.Name = "Node4";
            treeNode343.Text = "Top-down tire (to model a car from above) methods added";
            treeNode344.Name = "Node0";
            treeNode344.Text = "LDPhysics";
            treeNode345.Name = "Node0";
            treeNode345.Text = "Version 1.0.0.127";
            treeNode346.Name = "Node7";
            treeNode346.Text = "Bug fixes for Overlap methods";
            treeNode347.Name = "Node6";
            treeNode347.Text = "LDShapes";
            treeNode348.Name = "Node0";
            treeNode348.Text = "Bug fix for multiple numeric sorts";
            treeNode349.Name = "Node9";
            treeNode349.Text = "ByValueWithIndex method added";
            treeNode350.Name = "Node8";
            treeNode350.Text = "LDSort";
            treeNode351.Name = "Node1";
            treeNode351.Text = "LAN method added to get local IP addresses";
            treeNode352.Name = "Node2";
            treeNode352.Text = "Ping method added";
            treeNode353.Name = "Node0";
            treeNode353.Text = "LDNetwork";
            treeNode354.Name = "Node1";
            treeNode354.Text = "LoadSVG method added";
            treeNode355.Name = "Node0";
            treeNode355.Text = "LDImage";
            treeNode356.Name = "Node3";
            treeNode356.Text = "Evaluate method added";
            treeNode357.Name = "Node2";
            treeNode357.Text = "LDMath";
            treeNode358.Name = "Node5";
            treeNode358.Text = "IncludeJScript method added";
            treeNode359.Name = "Node4";
            treeNode359.Text = "LDInline";
            treeNode360.Name = "Node5";
            treeNode360.Text = "Version 1.0.0.126";
            treeNode361.Name = "Node0";
            treeNode361.Text = "Special emphasis on async consistency";
            treeNode362.Name = "Node4";
            treeNode362.Text = "Simplified auto method for multi-player game data transfer";
            treeNode363.Name = "Node9";
            treeNode363.Text = "LDServer and LDClient objects added";
            treeNode364.Name = "Node2";
            treeNode364.Text = "GetWidth and GetHeight methods added";
            treeNode365.Name = "Node1";
            treeNode365.Text = "LDText";
            treeNode366.Name = "Node4";
            treeNode366.Text = "Bing web search";
            treeNode367.Name = "Node3";
            treeNode367.Text = "LDSearch";
            treeNode368.Name = "Node6";
            treeNode368.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode369.Name = "Node7";
            treeNode369.Text = "KeyScroll property added";
            treeNode370.Name = "Node5";
            treeNode370.Text = "LDScrollBars";
            treeNode371.Name = "Node9";
            treeNode371.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode372.Name = "Node8";
            treeNode372.Text = "LDShapes";
            treeNode373.Name = "Node1";
            treeNode373.Text = "SaveAs method bug fixed";
            treeNode374.Name = "Node0";
            treeNode374.Text = "LDImage";
            treeNode375.Name = "Node3";
            treeNode375.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode376.Name = "Node2";
            treeNode376.Text = "LDQueue";
            treeNode377.Name = "Node8";
            treeNode377.Text = "Version 1.0.0.125";
            treeNode378.Name = "Node7";
            treeNode378.Text = "Language translation object added";
            treeNode379.Name = "Node6";
            treeNode379.Text = "LDTranslate";
            treeNode380.Name = "Node5";
            treeNode380.Text = "Version 1.0.0.124";
            treeNode381.Name = "Node1";
            treeNode381.Text = "Mouse screen coordinate conversion parameters added";
            treeNode382.Name = "Node2";
            treeNode382.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode383.Name = "Node0";
            treeNode383.Text = "LDGraphicsWindow";
            treeNode384.Name = "Node4";
            treeNode384.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode385.Name = "Node3";
            treeNode385.Text = "LDUtilities";
            treeNode386.Name = "Node0";
            treeNode386.Text = "Version 1.0.0.123";
            treeNode387.Name = "Node5";
            treeNode387.Text = "ColorMatrix method added";
            treeNode388.Name = "Node0";
            treeNode388.Text = "Rotate method added";
            treeNode389.Name = "Node3";
            treeNode389.Text = "LDImage";
            treeNode390.Name = "Node1";
            treeNode390.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode391.Name = "Node0";
            treeNode391.Text = "LDChart";
            treeNode392.Name = "Node2";
            treeNode392.Text = "Version 1.0.0.122";
            treeNode393.Name = "Node2";
            treeNode393.Text = "EffectGamma added to darken and lighten";
            treeNode394.Name = "Node4";
            treeNode394.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode395.Name = "Node3";
            treeNode395.Text = "EffectContrast modified";
            treeNode396.Name = "Node0";
            treeNode396.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode397.Name = "Node1";
            treeNode397.Text = "LDImage";
            treeNode398.Name = "Node2";
            treeNode398.Text = "Error event added for all extension exceptions";
            treeNode399.Name = "Node1";
            treeNode399.Text = "LDEvents";
            treeNode400.Name = "Node1";
            treeNode400.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode401.Name = "Node0";
            treeNode401.Text = "LDMath";
            treeNode402.Name = "Node0";
            treeNode402.Text = "Version 1.0.0.121";
            treeNode403.Name = "Node2";
            treeNode403.Text = "FloodFill transparency effect fixed";
            treeNode404.Name = "Node1";
            treeNode404.Text = "LDGraphicsWindow";
            treeNode405.Name = "Node1";
            treeNode405.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode406.Name = "Node0";
            treeNode406.Text = "LDFile";
            treeNode407.Name = "Node1";
            treeNode407.Text = "EffectPixelate added";
            treeNode408.Name = "Node0";
            treeNode408.Text = "LDImage";
            treeNode409.Name = "Node1";
            treeNode409.Text = "Modified to work with Windows 8";
            treeNode410.Name = "Node0";
            treeNode410.Text = "LDWebCam";
            treeNode411.Name = "Node0";
            treeNode411.Text = "Version 1.0.0.120";
            treeNode412.Name = "Node2";
            treeNode412.Text = "FloodFill method added";
            treeNode413.Name = "Node1";
            treeNode413.Text = "LDGraphicsWindow";
            treeNode414.Name = "Node0";
            treeNode414.Text = "Version 1.0.0.119";
            treeNode415.Name = "Node0";
            treeNode415.Text = "SetShapeCursor method added";
            treeNode416.Name = "Node11";
            treeNode416.Text = "CreateCursor method added";
            treeNode417.Name = "Node9";
            treeNode417.Text = "LDCursors";
            treeNode418.Name = "Node2";
            treeNode418.Text = "SaveAs method to save in different file formats";
            treeNode419.Name = "Node0";
            treeNode419.Text = "Parameters added for some effects";
            treeNode420.Name = "Node1";
            treeNode420.Text = "LDImage";
            treeNode421.Name = "Node2";
            treeNode421.Text = "Parameters added for some effects";
            treeNode422.Name = "Node1";
            treeNode422.Text = "LDWebCam";
            treeNode423.Name = "Node1";
            treeNode423.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode424.Name = "Node0";
            treeNode424.Text = "SetFontFromFile method added for ttf fonts";
            treeNode425.Name = "Node0";
            treeNode425.Text = "LDGraphicsWindow";
            treeNode426.Name = "Node3";
            treeNode426.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode427.Name = "Node2";
            treeNode427.Text = "LDTextWindow";
            treeNode428.Name = "Node2";
            treeNode428.Text = "Zip methods moved here from LDUtilities";
            treeNode429.Name = "Node0";
            treeNode429.Text = "LDZip";
            treeNode430.Name = "Node3";
            treeNode430.Text = "Regex methods moved here from LDUtilities";
            treeNode431.Name = "Node1";
            treeNode431.Text = "LDRegex";
            treeNode432.Name = "Node1";
            treeNode432.Text = "ListViewRowCount method added";
            treeNode433.Name = "Node0";
            treeNode433.Text = "LDControls";
            treeNode434.Name = "Node3";
            treeNode434.Text = "Version 1.0.0.118";
            treeNode435.Name = "Node5";
            treeNode435.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode436.Name = "Node6";
            treeNode436.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode437.Name = "Node4";
            treeNode437.Text = "LDUtilities";
            treeNode438.Name = "Node10";
            treeNode438.Text = "SetUserCursor method added";
            treeNode439.Name = "Node4";
            treeNode439.Text = "LDCursors";
            treeNode440.Name = "Node3";
            treeNode440.Text = "Version 1.0.0.117";
            treeNode441.Name = "Node2";
            treeNode441.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode442.Name = "Node1";
            treeNode442.Text = "LDDictionary";
            treeNode443.Name = "Node0";
            treeNode443.Text = "Version 1.0.0.116";
            treeNode444.Name = "Node2";
            treeNode444.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode445.Name = "Node1";
            treeNode445.Text = "LDColours";
            treeNode446.Name = "Node4";
            treeNode446.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode447.Name = "Node3";
            treeNode447.Text = "LDShapes";
            treeNode448.Name = "Node1";
            treeNode448.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode449.Name = "Node0";
            treeNode449.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode450.Name = "Node1";
            treeNode450.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode451.Name = "Node0";
            treeNode451.Text = "LDGraph";
            treeNode452.Name = "Node0";
            treeNode452.Text = "Version 1.0.0.115";
            treeNode453.Name = "Node2";
            treeNode453.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode454.Name = "Node1";
            treeNode454.Text = "LDControls";
            treeNode455.Name = "Node4";
            treeNode455.Text = "RemoveTurtleLines method added";
            treeNode456.Name = "Node6";
            treeNode456.Text = "GetAllShapes method added";
            treeNode457.Name = "Node3";
            treeNode457.Text = "LDShapes";
            treeNode458.Name = "Node1";
            treeNode458.Text = "Odbc connection added";
            treeNode459.Name = "Node0";
            treeNode459.Text = "LDDatabase";
            treeNode460.Name = "Node0";
            treeNode460.Text = "Version 1.0.0.114";
            treeNode461.Name = "Node2";
            treeNode461.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode462.Name = "Node1";
            treeNode462.Text = "LDUtilities";
            treeNode463.Name = "Node4";
            treeNode463.Text = "ListView control added";
            treeNode464.Name = "Node5";
            treeNode464.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode465.Name = "Node3";
            treeNode465.Text = "LDControls";
            treeNode466.Name = "Node0";
            treeNode466.Text = "Version 1.0.0.113";
            treeNode467.Name = "Node2";
            treeNode467.Text = "Tone method added";
            treeNode468.Name = "Node1";
            treeNode468.Text = "LDSound";
            treeNode469.Name = "Node5";
            treeNode469.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode470.Name = "Node4";
            treeNode470.Text = "LDControls";
            treeNode471.Name = "Node0";
            treeNode471.Text = "Version 1.0.0.112";
            treeNode472.Name = "Node2";
            treeNode472.Text = "SqlServer and Access database support added";
            treeNode473.Name = "Node1";
            treeNode473.Text = "LDDataBase";
            treeNode474.Name = "Node4";
            treeNode474.Text = "FixFlickr method added";
            treeNode475.Name = "Node0";
            treeNode475.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode476.Name = "Node3";
            treeNode476.Text = "LDUtilities";
            treeNode477.Name = "Node0";
            treeNode477.Text = "Version 1.0.0.111";
            treeNode478.Name = "Node2";
            treeNode478.Text = "TextBoxTab method added";
            treeNode479.Name = "Node1";
            treeNode479.Text = "LDControls";
            treeNode480.Name = "Node0";
            treeNode480.Text = "Version 1.0.0.110";
            treeNode481.Name = "Node1";
            treeNode481.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode482.Name = "Node3";
            treeNode482.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode483.Name = "Node0";
            treeNode483.Text = "General";
            treeNode484.Name = "Node5";
            treeNode484.Text = "Exists method added to check if a file path exists or not";
            treeNode485.Name = "Node4";
            treeNode485.Text = "LDFile";
            treeNode486.Name = "Node7";
            treeNode486.Text = "Start method handles attaching to existing process without warning";
            treeNode487.Name = "Node6";
            treeNode487.Text = "LDProcess";
            treeNode488.Name = "Node1";
            treeNode488.Text = "MySQL database support added";
            treeNode489.Name = "Node0";
            treeNode489.Text = "LDDatabase";
            treeNode490.Name = "Node3";
            treeNode490.Text = "Add and Multiply methods honour transparency";
            treeNode491.Name = "Node4";
            treeNode491.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode492.Name = "Node2";
            treeNode492.Text = "LDImage";
            treeNode493.Name = "Node3";
            treeNode493.Text = "Version 1.0.0.109";
            treeNode494.Name = "Node2";
            treeNode494.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode495.Name = "Node1";
            treeNode495.Text = "LDTextWindow";
            treeNode496.Name = "Node0";
            treeNode496.Text = "Version 1.0.0.108";
            treeNode497.Name = "Node14";
            treeNode497.Text = "Transparent colour added";
            treeNode498.Name = "Node13";
            treeNode498.Text = "LDColours";
            treeNode499.Name = "Node16";
            treeNode499.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode500.Name = "Node15";
            treeNode500.Text = "LDDialogs";
            treeNode501.Name = "Node12";
            treeNode501.Text = "Version 1.0.0.107";
            treeNode502.Name = "Node8";
            treeNode502.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode503.Name = "Node7";
            treeNode503.Text = "LDControls";
            treeNode504.Name = "Node11";
            treeNode504.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode505.Name = "Node10";
            treeNode505.Text = "LDShapes";
            treeNode506.Name = "Node6";
            treeNode506.Text = "Version 1.0.0.106";
            treeNode507.Name = "Node5";
            treeNode507.Text = "Menu control added";
            treeNode508.Name = "Node4";
            treeNode508.Text = "LDControls";
            treeNode509.Name = "Node3";
            treeNode509.Text = "Version 1.0.0.105";
            treeNode510.Name = "Node5";
            treeNode510.Text = "ZipList method added";
            treeNode511.Name = "Node2";
            treeNode511.Text = "GetNextMapIndex method added";
            treeNode512.Name = "Node4";
            treeNode512.Text = "LDUtilities";
            treeNode513.Name = "Node1";
            treeNode513.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode514.Name = "Node0";
            treeNode514.Text = "LDShapes";
            treeNode515.Name = "Node3";
            treeNode515.Text = "Version 1.0.0.104";
            treeNode516.Name = "Node1";
            treeNode516.Text = "Transparency maintained for various methods";
            treeNode517.Name = "Node2";
            treeNode517.Text = "Effects bug fixed";
            treeNode518.Name = "Node0";
            treeNode518.Text = "LDImage";
            treeNode519.Name = "Node0";
            treeNode519.Text = "Version 1.0.0.103";
            treeNode520.Name = "Node1";
            treeNode520.Text = "Current application assemblies are all auto-referenced";
            treeNode521.Name = "Node0";
            treeNode521.Text = "LDInline";
            treeNode522.Name = "Node5";
            treeNode522.Text = "Version 1.0.0.102";
            treeNode523.Name = "Node1";
            treeNode523.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode524.Name = "Node2";
            treeNode524.Text = "LDInline.sb sample provided";
            treeNode525.Name = "Node0";
            treeNode525.Text = "LDInline";
            treeNode526.Name = "Node4";
            treeNode526.Text = "ExitButtonMode method added to control window close button state";
            treeNode527.Name = "Node3";
            treeNode527.Text = "LDUtilities";
            treeNode528.Name = "Node0";
            treeNode528.Text = "Version 1.0.0.101";
            treeNode529.Name = "Node1";
            treeNode529.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode530.Name = "Node0";
            treeNode530.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode531.Name = "Node0";
            treeNode531.Text = "LDTextWindow";
            treeNode532.Name = "Node0";
            treeNode532.Text = "Version 1.0.0.100";
            treeNode533.Name = "Node2";
            treeNode533.Text = "ReadANSIToArray method added";
            treeNode534.Name = "Node1";
            treeNode534.Text = "LDFile";
            treeNode535.Name = "Node1";
            treeNode535.Text = "DocumentViewer control added";
            treeNode536.Name = "Node0";
            treeNode536.Text = "LDControls";
            treeNode537.Name = "Node3";
            treeNode537.Text = "An object to batch update shapes (for speed reasons)";
            treeNode538.Name = "Node0";
            treeNode538.Text = "LDFastShapes.sb sample included";
            treeNode539.Name = "Node2";
            treeNode539.Text = "LDFastShapes";
            treeNode540.Name = "Node0";
            treeNode540.Text = "Version 1.0.0.99";
            treeNode541.Name = "Node1";
            treeNode541.Text = "Rendering performance improvements when many shapes present";
            treeNode542.Name = "Node0";
            treeNode542.Text = "LDPhysics";
            treeNode543.Name = "Node1";
            treeNode543.Text = "ANSItoUTF8 method added";
            treeNode544.Name = "Node2";
            treeNode544.Text = "ReadANSI method added";
            treeNode545.Name = "Node0";
            treeNode545.Text = "LDFile";
            treeNode546.Name = "Node1";
            treeNode546.Text = "Version 1.0.0.98";
            treeNode547.Name = "Node3";
            treeNode547.Text = "Move method added for tiangles, polygons and lines";
            treeNode548.Name = "Node4";
            treeNode548.Text = "RotateAbout method added";
            treeNode549.Name = "Node1";
            treeNode549.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode550.Name = "Node0";
            treeNode550.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode551.Name = "Node2";
            treeNode551.Text = "LDShapes";
            treeNode552.Name = "Node0";
            treeNode552.Text = "Version 1.0.0.97";
            treeNode553.Name = "Node4";
            treeNode553.Text = "A list storage object added";
            treeNode554.Name = "Node3";
            treeNode554.Text = "LDList";
            treeNode555.Name = "Node2";
            treeNode555.Text = "Version 1.0.0.96";
            treeNode556.Name = "Node4";
            treeNode556.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode557.Name = "Node3";
            treeNode557.Text = "LDQueue";
            treeNode558.Name = "Node6";
            treeNode558.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode559.Name = "Node5";
            treeNode559.Text = "LDNetwork";
            treeNode560.Name = "Node0";
            treeNode560.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode561.Name = "Node1";
            treeNode561.Text = "General";
            treeNode562.Name = "Node2";
            treeNode562.Text = "Version 1.0.0.95";
            treeNode563.Name = "Node2";
            treeNode563.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode564.Name = "Node1";
            treeNode564.Text = "LDEncryption";
            treeNode565.Name = "Node1";
            treeNode565.Text = "RandomNumberSeed property added";
            treeNode566.Name = "Node0";
            treeNode566.Text = "LDMath";
            treeNode567.Name = "Node1";
            treeNode567.Text = "SetGameData and GetGameData methods added";
            treeNode568.Name = "Node0";
            treeNode568.Text = "LDNetwork";
            treeNode569.Name = "Node0";
            treeNode569.Text = "Version 1.0.0.94";
            treeNode570.Name = "Node1";
            treeNode570.Text = "SliderGetValue method added";
            treeNode571.Name = "Node0";
            treeNode571.Text = "LDControls";
            treeNode572.Name = "Node5";
            treeNode572.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode573.Name = "Node2";
            treeNode573.Text = "LDUtilities";
            treeNode574.Name = "Node3";
            treeNode574.Text = "Encrypt and Decrypt methods added";
            treeNode575.Name = "Node4";
            treeNode575.Text = "MD5Hash method added";
            treeNode576.Name = "Node6";
            treeNode576.Text = "LDEncryption";
            treeNode577.Name = "Node0";
            treeNode577.Text = "Version 1.0.0.93";
            treeNode578.Name = "Node1";
            treeNode578.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode579.Name = "Node0";
            treeNode579.Text = "LDControls";
            treeNode580.Name = "Node0";
            treeNode580.Text = "Version 1.0.0.92";
            treeNode581.Name = "Node2";
            treeNode581.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode582.Name = "Node1";
            treeNode582.Text = "LDControls";
            treeNode583.Name = "Node1";
            treeNode583.Text = "Version 1.0.0.91";
            treeNode584.Name = "Node1";
            treeNode584.Text = "Font method added to modify shapes or controls that have text";
            treeNode585.Name = "Node0";
            treeNode585.Text = "LDShapes";
            treeNode586.Name = "Node1";
            treeNode586.Text = "MediaPlayer control added (play videos etc)";
            treeNode587.Name = "Node0";
            treeNode587.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode588.Name = "Node0";
            treeNode588.Text = "LDControls";
            treeNode589.Name = "Node1";
            treeNode589.Text = "Version 1.0.0.90";
            treeNode590.Name = "Node1";
            treeNode590.Text = "Autosize columns for ListView";
            treeNode591.Name = "Node2";
            treeNode591.Text = "LDDataBase.sb sample updated";
            treeNode592.Name = "Node0";
            treeNode592.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode593.Name = "Node0";
            treeNode593.Text = "LDDataBase";
            treeNode594.Name = "Node0";
            treeNode594.Text = "Version 1.0.0.89";
            treeNode595.Name = "Node4";
            treeNode595.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode596.Name = "Node3";
            treeNode596.Text = "LDScrollBars";
            treeNode597.Name = "Node1";
            treeNode597.Text = "CleanTemp method added";
            treeNode598.Name = "Node0";
            treeNode598.Text = "LDUtilities";
            treeNode599.Name = "Node1";
            treeNode599.Text = "SQLite database methods added";
            treeNode600.Name = "Node0";
            treeNode600.Text = "LDDataBase";
            treeNode601.Name = "Node2";
            treeNode601.Text = "Version 1.0.0.88";
            treeNode602.Name = "Node2";
            treeNode602.Text = "LastError now returns a text error";
            treeNode603.Name = "Node1";
            treeNode603.Text = "LDIOWarrior";
            treeNode604.Name = "Node1";
            treeNode604.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode605.Name = "Node0";
            treeNode605.Text = "LDScrollBars";
            treeNode606.Name = "Node0";
            treeNode606.Text = "Version 1.0.0.87";
            treeNode607.Name = "Node4";
            treeNode607.Text = "SetTurtleImage method added";
            treeNode608.Name = "Node3";
            treeNode608.Text = "LDShapes";
            treeNode609.Name = "Node1";
            treeNode609.Text = "Connect to IOWarrior USB devices";
            treeNode610.Name = "Node0";
            treeNode610.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode611.Name = "Node0";
            treeNode611.Text = "LDIOWarrior";
            treeNode612.Name = "Node2";
            treeNode612.Text = "Version 1.0.0.86";
            treeNode613.Name = "Node1";
            treeNode613.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode614.Name = "Node0";
            treeNode614.Text = "LDShapes";
            treeNode615.Name = "Node2";
            treeNode615.Text = "Version 1.0.0.85";
            treeNode616.Name = "Node4";
            treeNode616.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode617.Name = "Node3";
            treeNode617.Text = "LDFile";
            treeNode618.Name = "Node6";
            treeNode618.Text = "Crop method added";
            treeNode619.Name = "Node5";
            treeNode619.Text = "LDImage";
            treeNode620.Name = "Node1";
            treeNode620.Text = "LastDropFiles bug fixed";
            treeNode621.Name = "Node0";
            treeNode621.Text = "LDControls";
            treeNode622.Name = "Node2";
            treeNode622.Text = "Version 1.0.0.84";
            treeNode623.Name = "Node7";
            treeNode623.Text = "FileDropped event added";
            treeNode624.Name = "Node6";
            treeNode624.Text = "LDControls";
            treeNode625.Name = "Node1";
            treeNode625.Text = "Bug in Split corrected";
            treeNode626.Name = "Node0";
            treeNode626.Text = "LDText";
            treeNode627.Name = "Node5";
            treeNode627.Text = "Version 1.0.0.83";
            treeNode628.Name = "Node3";
            treeNode628.Text = "Title argument removed from AddComboBox";
            treeNode629.Name = "Node4";
            treeNode629.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode630.Name = "Node2";
            treeNode630.Text = "LDControls";
            treeNode631.Name = "Node1";
            treeNode631.Text = "Version 1.0.0.82";
            treeNode632.Name = "Node0";
            treeNode632.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode633.Name = "Node12";
            treeNode633.Text = "Program settings added";
            treeNode634.Name = "Node9";
            treeNode634.Text = "LDSettings";
            treeNode635.Name = "Node11";
            treeNode635.Text = "Get some system paths and user name";
            treeNode636.Name = "Node10";
            treeNode636.Text = "LDFile";
            treeNode637.Name = "Node14";
            treeNode637.Text = "System sounds added";
            treeNode638.Name = "Node13";
            treeNode638.Text = "LDSound";
            treeNode639.Name = "Node16";
            treeNode639.Text = "Binary, octal, hex and decimal conversions";
            treeNode640.Name = "Node15";
            treeNode640.Text = "LDMath";
            treeNode641.Name = "Node1";
            treeNode641.Text = "Replace method added";
            treeNode642.Name = "Node2";
            treeNode642.Text = "FindAll method added";
            treeNode643.Name = "Node0";
            treeNode643.Text = "LDText";
            treeNode644.Name = "Node8";
            treeNode644.Text = "Version 1.0.0.81";
            treeNode645.Name = "Node1";
            treeNode645.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode646.Name = "Node6";
            treeNode646.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode647.Name = "Node0";
            treeNode647.Text = "LDShapes";
            treeNode648.Name = "Node3";
            treeNode648.Text = "Truncate method added";
            treeNode649.Name = "Node2";
            treeNode649.Text = "LDMath";
            treeNode650.Name = "Node5";
            treeNode650.Text = "Additional text methods";
            treeNode651.Name = "Node4";
            treeNode651.Text = "LDText";
            treeNode652.Name = "Node0";
            treeNode652.Text = "Version 1.0.0.80";
            treeNode653.Name = "Node1";
            treeNode653.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode654.Name = "Node0";
            treeNode654.Text = "LDDialogs";
            treeNode655.Name = "Node1";
            treeNode655.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode656.Name = "Node0";
            treeNode656.Text = "LDUtilities";
            treeNode657.Name = "Node6";
            treeNode657.Text = "Version 1.0.0.79";
            treeNode658.Name = "Node2";
            treeNode658.Text = "Rasterize property added";
            treeNode659.Name = "Node5";
            treeNode659.Text = "Improvements associated with window resizing";
            treeNode660.Name = "Node1";
            treeNode660.Text = "LDScrollBars";
            treeNode661.Name = "Node4";
            treeNode661.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode662.Name = "Node3";
            treeNode662.Text = "LDUtilities";
            treeNode663.Name = "Node0";
            treeNode663.Text = "Version 1.0.0.78";
            treeNode664.Name = "Node1";
            treeNode664.Text = "Handle more than 100 drawables (rasterization)";
            treeNode665.Name = "Node0";
            treeNode665.Text = "LDScollBars";
            treeNode666.Name = "Node2";
            treeNode666.Text = "Version 1.0.0.77";
            treeNode667.Name = "Node1";
            treeNode667.Text = "Record sound from a microphone";
            treeNode668.Name = "Node0";
            treeNode668.Text = "LDSound";
            treeNode669.Name = "Node3";
            treeNode669.Text = "AnimateOpacity method added (flashing)";
            treeNode670.Name = "Node0";
            treeNode670.Text = "AnimateRotation method added (continuous rotation)";
            treeNode671.Name = "Node1";
            treeNode671.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode672.Name = "Node2";
            treeNode672.Text = "LDShapes";
            treeNode673.Name = "Node2";
            treeNode673.Text = "Version 1.0.0.76";
            treeNode674.Name = "Node1";
            treeNode674.Text = "AddAnimatedImage can use an ImageList image";
            treeNode675.Name = "Node0";
            treeNode675.Text = "LDShapes";
            treeNode676.Name = "Node0";
            treeNode676.Text = "Version 1.0.0.75";
            treeNode677.Name = "Node1";
            treeNode677.Text = "Initial graph axes scaling improvement";
            treeNode678.Name = "Node0";
            treeNode678.Text = "LDGraph";
            treeNode679.Name = "Node3";
            treeNode679.Text = "Methods to access a bluetooth device";
            treeNode680.Name = "Node0";
            treeNode680.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode681.Name = "Node2";
            treeNode681.Text = "LDBlueTooth";
            treeNode682.Name = "Node1";
            treeNode682.Text = "getFocus handles multiple LDWindows";
            treeNode683.Name = "Node0";
            treeNode683.Text = "LDFocus";
            treeNode684.Name = "Node0";
            treeNode684.Text = "Version 1.0.0.74";
            treeNode685.Name = "Node1";
            treeNode685.Text = "First pass at a generic USB (HID) device controller";
            treeNode686.Name = "Node0";
            treeNode686.Text = "LDHID";
            treeNode687.Name = "Node9";
            treeNode687.Text = "Version 1.0.0.73";
            treeNode688.Name = "Node8";
            treeNode688.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode689.Name = "Node7";
            treeNode689.Text = "LDGraph";
            treeNode690.Name = "Node6";
            treeNode690.Text = "Version 1.0.0.72";
            treeNode691.Name = "Node4";
            treeNode691.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode692.Name = "Node5";
            treeNode692.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode693.Name = "Node3";
            treeNode693.Text = "LDGraph";
            treeNode694.Name = "Node2";
            treeNode694.Text = "Version 1.0.0.71";
            treeNode695.Name = "Node1";
            treeNode695.Text = "Spurious error message fixed";
            treeNode696.Name = "Node2";
            treeNode696.Text = "CreateTrend data series creation method added";
            treeNode697.Name = "Node0";
            treeNode697.Text = "LDGraph";
            treeNode698.Name = "Node2";
            treeNode698.Text = "Version 1.0.0.70";
            treeNode699.Name = "Node1";
            treeNode699.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode700.Name = "Node0";
            treeNode700.Text = "LDControls";
            treeNode701.Name = "Node3";
            treeNode701.Text = "Version 1.0.0.69";
            treeNode702.Name = "Node2";
            treeNode702.Text = "Radio button control added";
            treeNode703.Name = "Node1";
            treeNode703.Text = "LDControls";
            treeNode704.Name = "Node0";
            treeNode704.Text = "Version 1.0.0.68";
            treeNode705.Name = "Node1";
            treeNode705.Text = "Bug fix for Copy";
            treeNode706.Name = "Node0";
            treeNode706.Text = "LDArray";
            treeNode707.Name = "Node2";
            treeNode707.Text = "Version 1.0.0.67";
            treeNode708.Name = "Node1";
            treeNode708.Text = "RegexMatch and RegexReplace methods added";
            treeNode709.Name = "Node0";
            treeNode709.Text = "LDUtilities";
            treeNode710.Name = "Node3";
            treeNode710.Text = "Version 1.0.0.66";
            treeNode711.Name = "Node2";
            treeNode711.Text = "Number culture conversions added";
            treeNode712.Name = "Node1";
            treeNode712.Text = "LDUtilities";
            treeNode713.Name = "Node0";
            treeNode713.Text = "Version 1.0.0.65";
            treeNode714.Name = "Node1";
            treeNode714.Text = "IsNumber method added";
            treeNode715.Name = "Node0";
            treeNode715.Text = "LDUtilities";
            treeNode716.Name = "Node2";
            treeNode716.Text = "Version 1.0.0.64";
            treeNode717.Name = "Node1";
            treeNode717.Text = "SetCursorPosition method added for textboxes";
            treeNode718.Name = "Node0";
            treeNode718.Text = "LDControls";
            treeNode719.Name = "Node4";
            treeNode719.Text = "Version 1.0.0.63";
            treeNode720.Name = "Node1";
            treeNode720.Text = "SetCursorToEnd method added for textboxes";
            treeNode721.Name = "Node3";
            treeNode721.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode722.Name = "Node0";
            treeNode722.Text = "LDControls";
            treeNode723.Name = "Node2";
            treeNode723.Text = "Version 1.0.0.62";
            treeNode724.Name = "Node1";
            treeNode724.Text = "Adding polygons not located at (0,0) corrected";
            treeNode725.Name = "Node0";
            treeNode725.Text = "LDPhysics";
            treeNode726.Name = "Node2";
            treeNode726.Text = "Version 1.0.0.61";
            treeNode727.Name = "Node1";
            treeNode727.Text = "GetFolder dialog added";
            treeNode728.Name = "Node0";
            treeNode728.Text = "LDDialogs";
            treeNode729.Name = "Node0";
            treeNode729.Text = "Version 1.0.0.60";
            treeNode730.Name = "Node10";
            treeNode730.Text = "Possible localization issue with Font size fixed";
            treeNode731.Name = "Node9";
            treeNode731.Text = "LDDialogs";
            treeNode732.Name = "Node8";
            treeNode732.Text = "Version 1.0.0.59";
            treeNode733.Name = "Node3";
            treeNode733.Text = "More internationalization fixes";
            treeNode734.Name = "Node2";
            treeNode734.Text = "ShowPrintPreview property added";
            treeNode735.Name = "Node1";
            treeNode735.Text = "LDUtilities";
            treeNode736.Name = "Node5";
            treeNode736.Text = "Possible error with gradient drawings fixed";
            treeNode737.Name = "Node4";
            treeNode737.Text = "LDShapes";
            treeNode738.Name = "Node7";
            treeNode738.Text = "Possible Listen event initialisation error fixed";
            treeNode739.Name = "Node6";
            treeNode739.Text = "LDSpeech";
            treeNode740.Name = "Node0";
            treeNode740.Text = "Version 1.0.0.58";
            treeNode741.Name = "Node7";
            treeNode741.Text = "Many possible internationisation issues fixed";
            treeNode742.Name = "Node4";
            treeNode742.Text = "Version 1.0.0.57";
            treeNode743.Name = "Node1";
            treeNode743.Text = "Emmisive colour correction for AddGeometry";
            treeNode744.Name = "Node2";
            treeNode744.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode745.Name = "Node0";
            treeNode745.Text = "LD3DView";
            treeNode746.Name = "Node1";
            treeNode746.Text = "CSVdeminiator property added";
            treeNode747.Name = "Node0";
            treeNode747.Text = "LDUtilities";
            treeNode748.Name = "Node5";
            treeNode748.Text = "Version 1.0.0.56";
            treeNode749.Name = "Node1";
            treeNode749.Text = "Improved error reporting";
            treeNode750.Name = "Node2";
            treeNode750.Text = "Culture invariant type conversions";
            treeNode751.Name = "Node1";
            treeNode751.Text = "LD3DView";
            treeNode752.Name = "Node4";
            treeNode752.Text = "ShowErrors method added";
            treeNode753.Name = "Node3";
            treeNode753.Text = "LDUtilities";
            treeNode754.Name = "Node0";
            treeNode754.Text = "Version 1.0.0.55";
            treeNode755.Name = "Node4";
            treeNode755.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode756.Name = "Node3";
            treeNode756.Text = "LDScrollBars";
            treeNode757.Name = "Node6";
            treeNode757.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode758.Name = "Node5";
            treeNode758.Text = "LDUtilities";
            treeNode759.Name = "Node2";
            treeNode759.Text = "Version 1.0.0.54";
            treeNode760.Name = "Node1";
            treeNode760.Text = "Debug window can be resized";
            treeNode761.Name = "Node0";
            treeNode761.Text = "LDDebug";
            treeNode762.Name = "Node1";
            treeNode762.Text = "PrintFile method added";
            treeNode763.Name = "Node0";
            treeNode763.Text = "LDFile";
            treeNode764.Name = "Node2";
            treeNode764.Text = "Version 1.0.0.53";
            treeNode765.Name = "Node1";
            treeNode765.Text = "SSL property option added";
            treeNode766.Name = "Node0";
            treeNode766.Text = "LDEmail";
            treeNode767.Name = "Node0";
            treeNode767.Text = "Version 1.0.0.52";
            treeNode768.Name = "Node1";
            treeNode768.Text = "Right Click Context menu added for any shape or control";
            treeNode769.Name = "Node0";
            treeNode769.Text = "LDControls";
            treeNode770.Name = "Node0";
            treeNode770.Text = "Version 1.0.0.51";
            treeNode771.Name = "Node1";
            treeNode771.Text = "Right click dropdown menu option added";
            treeNode772.Name = "Node0";
            treeNode772.Text = "LDDialogs";
            treeNode773.Name = "Node0";
            treeNode773.Text = "Version 1.0.0.50";
            treeNode774.Name = "Node1";
            treeNode774.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode775.Name = "Node0";
            treeNode775.Text = "LD3DView";
            treeNode776.Name = "Node0";
            treeNode776.Text = "Version 1.0.0.49";
            treeNode777.Name = "Node1";
            treeNode777.Text = "Performance improvements (some camera controls for this)";
            treeNode778.Name = "Node1";
            treeNode778.Text = "LoadModel (*.3ds) files added";
            treeNode779.Name = "Node0";
            treeNode779.Text = "LD3DView";
            treeNode780.Name = "Node3";
            treeNode780.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode781.Name = "Node2";
            treeNode781.Text = "LDShapes";
            treeNode782.Name = "Node0";
            treeNode782.Text = "Version 1.0.0.48";
            treeNode783.Name = "Node1";
            treeNode783.Text = "Some improvements including animations";
            treeNode784.Name = "Node0";
            treeNode784.Text = "LD3DView";
            treeNode785.Name = "Node0";
            treeNode785.Text = "Version 1.0.0.47";
            treeNode786.Name = "Node1";
            treeNode786.Text = "Some improvemts and new methods";
            treeNode787.Name = "Node0";
            treeNode787.Text = "LD3Dview";
            treeNode788.Name = "Node2";
            treeNode788.Text = "Version 1.0.0.46";
            treeNode789.Name = "Node1";
            treeNode789.Text = "A start at a 3D set of methods";
            treeNode790.Name = "Node0";
            treeNode790.Text = "LD3DView";
            treeNode791.Name = "Node10";
            treeNode791.Text = "Version 1.0.0.45";
            treeNode792.Name = "Node1";
            treeNode792.Text = "Create scrollbars for the GraphicsWindow";
            treeNode793.Name = "Node5";
            treeNode793.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode794.Name = "Node0";
            treeNode794.Text = "LDScrollBars";
            treeNode795.Name = "Node4";
            treeNode795.Text = "ColourList method added";
            treeNode796.Name = "Node3";
            treeNode796.Text = "LDUtilities";
            treeNode797.Name = "Node8";
            treeNode797.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode798.Name = "Node9";
            treeNode798.Text = "BackgroundImage method to set the background added";
            treeNode799.Name = "Node6";
            treeNode799.Text = "LDShapes";
            treeNode800.Name = "Node0";
            treeNode800.Text = "Version 1.0.0.44";
            treeNode801.Name = "Node1";
            treeNode801.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode802.Name = "Node0";
            treeNode802.Text = "LDUtilities";
            treeNode803.Name = "Node0";
            treeNode803.Text = "Version 1.0.0.43";
            treeNode804.Name = "Node1";
            treeNode804.Text = "Call Subs as functions with arguments";
            treeNode805.Name = "Node0";
            treeNode805.Text = "LDCall";
            treeNode806.Name = "Node0";
            treeNode806.Text = "Version 1.0.0.42";
            treeNode807.Name = "Node1";
            treeNode807.Text = "Font dialog added";
            treeNode808.Name = "Node2";
            treeNode808.Text = "Colours dialog moved here from LDColours";
            treeNode809.Name = "Node0";
            treeNode809.Text = "LDDialogs";
            treeNode810.Name = "Node9";
            treeNode810.Text = "Version 1.0.0.41";
            treeNode811.Name = "Node1";
            treeNode811.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode812.Name = "Node7";
            treeNode812.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode813.Name = "Node8";
            treeNode813.Text = "Some methods renamed";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDControls";
            treeNode815.Name = "Node3";
            treeNode815.Text = "HighScore method move here";
            treeNode816.Name = "Node2";
            treeNode816.Text = "LDNetwork";
            treeNode817.Name = "Node6";
            treeNode817.Text = "SetSize method added";
            treeNode818.Name = "Node5";
            treeNode818.Text = "LDShapes";
            treeNode819.Name = "Node3";
            treeNode819.Text = "Version 1.0.0.40";
            treeNode820.Name = "Node1";
            treeNode820.Text = "SelectTreeView method added";
            treeNode821.Name = "Node2";
            treeNode821.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode822.Name = "Node0";
            treeNode822.Text = "LDDialogs";
            treeNode823.Name = "Node1";
            treeNode823.Text = "Simple high score web method";
            treeNode824.Name = "Node0";
            treeNode824.Text = "LDHighScore";
            treeNode825.Name = "Node3";
            treeNode825.Text = "Version 1.0.0.39";
            treeNode826.Name = "Node2";
            treeNode826.Text = "RichTextBox methods improved";
            treeNode827.Name = "Node1";
            treeNode827.Text = "LDDialogs";
            treeNode828.Name = "Node1";
            treeNode828.Text = "Search, Load and Save methods added";
            treeNode829.Name = "Node0";
            treeNode829.Text = "LDArray";
            treeNode830.Name = "Node0";
            treeNode830.Text = "Version 1.0.0.38";
            treeNode831.Name = "Node1";
            treeNode831.Text = "Depreciated";
            treeNode832.Name = "Node0";
            treeNode832.Text = "LDWeather";
            treeNode833.Name = "Node1";
            treeNode833.Text = "Renamed from LDTrig and some more methods added";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDMath";
            treeNode835.Name = "Node3";
            treeNode835.Text = "RichTextBox method added";
            treeNode836.Name = "Node2";
            treeNode836.Text = "LDDialogs";
            treeNode837.Name = "Node5";
            treeNode837.Text = "FontList method added";
            treeNode838.Name = "Node4";
            treeNode838.Text = "LDUtilities";
            treeNode839.Name = "Node2";
            treeNode839.Text = "Version 1.0.0.37";
            treeNode840.Name = "Node1";
            treeNode840.Text = "Zip method extended";
            treeNode841.Name = "Node0";
            treeNode841.Text = "LDUtilities";
            treeNode842.Name = "Node2";
            treeNode842.Text = "Version 1.0.0.36";
            treeNode843.Name = "Node1";
            treeNode843.Text = "Collapse and expand treeview nodes method added";
            treeNode844.Name = "Node0";
            treeNode844.Text = "LDDialogs";
            treeNode845.Name = "Node5";
            treeNode845.Text = "Version 1.0.0.35";
            treeNode846.Name = "Node1";
            treeNode846.Text = "Arguments added to Start method";
            treeNode847.Name = "Node0";
            treeNode847.Text = "LDProcess";
            treeNode848.Name = "Node4";
            treeNode848.Text = "Zip compression methods added";
            treeNode849.Name = "Node2";
            treeNode849.Text = "LDUtilities";
            treeNode850.Name = "Node2";
            treeNode850.Text = "Version 1.0.0.34";
            treeNode851.Name = "Node1";
            treeNode851.Text = "GWStyle property added";
            treeNode852.Name = "Node0";
            treeNode852.Text = "LDUtilities";
            treeNode853.Name = "Node1";
            treeNode853.Text = "TreeView and associated events added";
            treeNode854.Name = "Node0";
            treeNode854.Text = "LDDialogs";
            treeNode855.Name = "Node0";
            treeNode855.Text = "Version 1.0.0.33";
            treeNode856.Name = "Node1";
            treeNode856.Text = "Possible end points not plotting bug fixed";
            treeNode857.Name = "Node0";
            treeNode857.Text = "LDGraph";
            treeNode858.Name = "Node2";
            treeNode858.Text = "Version 1.0.0.32";
            treeNode859.Name = "Node1";
            treeNode859.Text = "Activated event and Active property addded";
            treeNode860.Name = "Node0";
            treeNode860.Text = "LDWindows";
            treeNode861.Name = "Node0";
            treeNode861.Text = "Version 1.0.0.31";
            treeNode862.Name = "Node1";
            treeNode862.Text = "Create multiple GraphicsWindows";
            treeNode863.Name = "Node0";
            treeNode863.Text = "LDWindows";
            treeNode864.Name = "Node0";
            treeNode864.Text = "Version 1.0.0.30";
            treeNode865.Name = "Node1";
            treeNode865.Text = "Email sending method";
            treeNode866.Name = "Node0";
            treeNode866.Text = "LDMail";
            treeNode867.Name = "Node1";
            treeNode867.Text = "Add and Multiply methods bug fixed";
            treeNode868.Name = "Node2";
            treeNode868.Text = "Image statistics combined into one method";
            treeNode869.Name = "Node3";
            treeNode869.Text = "Histogram method added";
            treeNode870.Name = "Node0";
            treeNode870.Text = "LDImage";
            treeNode871.Name = "Node0";
            treeNode871.Text = "Version 1.0.0.29";
            treeNode872.Name = "Node1";
            treeNode872.Text = "SnapshotToImageList method added";
            treeNode873.Name = "Node0";
            treeNode873.Text = "LDWebCam";
            treeNode874.Name = "Node3";
            treeNode874.Text = "ImageList image manipulation methods";
            treeNode875.Name = "Node2";
            treeNode875.Text = "LDImage";
            treeNode876.Name = "Node0";
            treeNode876.Text = "Version 1.0.0.28";
            treeNode877.Name = "Node1";
            treeNode877.Text = "SortIndex bugfix for null values";
            treeNode878.Name = "Node0";
            treeNode878.Text = "LDArray";
            treeNode879.Name = "Node1";
            treeNode879.Text = "SnapshotToFile bug fixed";
            treeNode880.Name = "Node0";
            treeNode880.Text = "LDWebCam";
            treeNode881.Name = "Node0";
            treeNode881.Text = "Version 1.0.0.27";
            treeNode882.Name = "Node1";
            treeNode882.Text = "SortIndex method added";
            treeNode883.Name = "Node0";
            treeNode883.Text = "LDArray";
            treeNode884.Name = "Node1";
            treeNode884.Text = "Web based weather report data added";
            treeNode885.Name = "Node0";
            treeNode885.Text = "LDWeather";
            treeNode886.Name = "Node3";
            treeNode886.Text = "DataReceived event added";
            treeNode887.Name = "Node2";
            treeNode887.Text = "LDCommPort";
            treeNode888.Name = "Node0";
            treeNode888.Text = "Version 1.0.0.26";
            treeNode889.Name = "Node1";
            treeNode889.Text = "Speech recognition added";
            treeNode890.Name = "Node0";
            treeNode890.Text = "LDSpeech";
            treeNode891.Name = "Node0";
            treeNode891.Text = "Version 1.0.0.25";
            treeNode892.Name = "Node4";
            treeNode892.Text = "More methods added and some internal code optimised";
            treeNode893.Name = "Node0";
            treeNode893.Text = "LDArray & LDMatrix";
            treeNode894.Name = "Node1";
            treeNode894.Text = "KeyDown method added";
            treeNode895.Name = "Node0";
            treeNode895.Text = "LDUtilities";
            treeNode896.Name = "Node1";
            treeNode896.Text = "GetAllShapesAt method added";
            treeNode897.Name = "Node0";
            treeNode897.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode898.Name = "Node0";
            treeNode898.Text = "LDShapes";
            treeNode899.Name = "Node0";
            treeNode899.Text = "Version 1.0.0.24";
            treeNode900.Name = "Node1";
            treeNode900.Text = "OpenFile and SaveFile dialogs added";
            treeNode901.Name = "Node0";
            treeNode901.Text = "LDDialogs";
            treeNode902.Name = "Node2";
            treeNode902.Text = "Matrix methods, for example to solve linear equations";
            treeNode903.Name = "Node1";
            treeNode903.Text = "LDMatrix";
            treeNode904.Name = "Node0";
            treeNode904.Text = "Version 1.0.0.23";
            treeNode905.Name = "Node1";
            treeNode905.Text = "Sorting method added";
            treeNode906.Name = "Node0";
            treeNode906.Text = "LDArray";
            treeNode907.Name = "Node0";
            treeNode907.Text = "Version 1.0.0.22";
            treeNode908.Name = "Node2";
            treeNode908.Text = "Velocity Threshold setting added";
            treeNode909.Name = "Node1";
            treeNode909.Text = "LDPhysics";
            treeNode910.Name = "Node0";
            treeNode910.Text = "Version 1.0.0.21";
            treeNode911.Name = "Node3";
            treeNode911.Text = "SetDamping method added";
            treeNode912.Name = "Node2";
            treeNode912.Text = "LDPhysics";
            treeNode913.Name = "Node1";
            treeNode913.Text = "Version 1.0.0.20";
            treeNode914.Name = "Node1";
            treeNode914.Text = "Instrument name can be obtained from its number";
            treeNode915.Name = "Node0";
            treeNode915.Text = "LDMusic";
            treeNode916.Name = "Node0";
            treeNode916.Text = "Version 1.0.0.19";
            treeNode917.Name = "Node1";
            treeNode917.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode918.Name = "Node0";
            treeNode918.Text = "LDDialogs";
            treeNode919.Name = "Node1";
            treeNode919.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode920.Name = "Node2";
            treeNode920.Text = "Notes can also be played synchronously (chords)";
            treeNode921.Name = "Node0";
            treeNode921.Text = "LDMusic";
            treeNode922.Name = "Node0";
            treeNode922.Text = "Version 1.0.0.18";
            treeNode923.Name = "Node1";
            treeNode923.Text = "AnimationPause and AnimationResume methods added";
            treeNode924.Name = "Node0";
            treeNode924.Text = "LDShapes";
            treeNode925.Name = "Node1";
            treeNode925.Text = "Process list indexed by ID rather than name";
            treeNode926.Name = "Node0";
            treeNode926.Text = "LDProcess";
            treeNode927.Name = "Node1";
            treeNode927.Text = "Version 1.0.0.17";
            treeNode928.Name = "Node1";
            treeNode928.Text = "More effects added";
            treeNode929.Name = "Node0";
            treeNode929.Text = "LDWebCam";
            treeNode930.Name = "Node1";
            treeNode930.Text = "Add or change an image on a button or image shape";
            treeNode931.Name = "Node1";
            treeNode931.Text = "Add an animated gif or tiled image";
            treeNode932.Name = "Node0";
            treeNode932.Text = "LDShapes";
            treeNode933.Name = "Node0";
            treeNode933.Text = "Version 1.0.0.16";
            treeNode934.Name = "Node1";
            treeNode934.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode935.Name = "Node0";
            treeNode935.Text = "LDWebCam";
            treeNode936.Name = "Node0";
            treeNode936.Text = "Version 1.0.0.15";
            treeNode937.Name = "Node2";
            treeNode937.Text = "Variables may be changed during a debug session";
            treeNode938.Name = "Node1";
            treeNode938.Text = "LDDebug";
            treeNode939.Name = "Node0";
            treeNode939.Text = "Version 1.0.0.14";
            treeNode940.Name = "Node1";
            treeNode940.Text = "A basic debugging tool";
            treeNode941.Name = "Node0";
            treeNode941.Text = "LDDebug";
            treeNode942.Name = "Node0";
            treeNode942.Text = "Version 1.0.0.13";
            treeNode943.Name = "Node2";
            treeNode943.Text = "Methods to convert between HSL and RGB";
            treeNode944.Name = "Node18";
            treeNode944.Text = "Method to set colour opacity";
            treeNode945.Name = "Node19";
            treeNode945.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode946.Name = "Node1";
            treeNode946.Text = "LDColours";
            treeNode947.Name = "Node4";
            treeNode947.Text = "Methods to add and subtract dates and times";
            treeNode948.Name = "Node3";
            treeNode948.Text = "LDDateTime";
            treeNode949.Name = "Node6";
            treeNode949.Text = "Waiting overlay, Calendar and About popups";
            treeNode950.Name = "Node17";
            treeNode950.Text = "Tooltips";
            treeNode951.Name = "Node5";
            treeNode951.Text = "LDDialogs";
            treeNode952.Name = "Node8";
            treeNode952.Text = "File change event";
            treeNode953.Name = "Node7";
            treeNode953.Text = "LDEvents";
            treeNode954.Name = "Node0";
            treeNode954.Text = "Version 1.0.0.12";
            treeNode955.Name = "Node12";
            treeNode955.Text = "Methods to sort arrays by index or value";
            treeNode956.Name = "Node22";
            treeNode956.Text = "Sorting by number and character strings";
            treeNode957.Name = "Node11";
            treeNode957.Text = "LDSort";
            treeNode958.Name = "Node14";
            treeNode958.Text = "Statistics on any array and distribution generation";
            treeNode959.Name = "Node20";
            treeNode959.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode960.Name = "Node21";
            treeNode960.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode961.Name = "Node13";
            treeNode961.Text = "LDStatistics";
            treeNode962.Name = "Node16";
            treeNode962.Text = "Voice and volume added";
            treeNode963.Name = "Node15";
            treeNode963.Text = "LDSpeech";
            treeNode964.Name = "Node9";
            treeNode964.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode31,
            treeNode59,
            treeNode73,
            treeNode84,
            treeNode99,
            treeNode114,
            treeNode127,
            treeNode136,
            treeNode151,
            treeNode162,
            treeNode176,
            treeNode185,
            treeNode197,
            treeNode208,
            treeNode211,
            treeNode220,
            treeNode227,
            treeNode234,
            treeNode247,
            treeNode258,
            treeNode263,
            treeNode270,
            treeNode273,
            treeNode287,
            treeNode295,
            treeNode301,
            treeNode316,
            treeNode331,
            treeNode337,
            treeNode345,
            treeNode360,
            treeNode377,
            treeNode380,
            treeNode386,
            treeNode392,
            treeNode402,
            treeNode411,
            treeNode414,
            treeNode434,
            treeNode440,
            treeNode443,
            treeNode452,
            treeNode460,
            treeNode466,
            treeNode471,
            treeNode477,
            treeNode480,
            treeNode493,
            treeNode496,
            treeNode501,
            treeNode506,
            treeNode509,
            treeNode515,
            treeNode519,
            treeNode522,
            treeNode528,
            treeNode532,
            treeNode540,
            treeNode546,
            treeNode552,
            treeNode555,
            treeNode562,
            treeNode569,
            treeNode577,
            treeNode580,
            treeNode583,
            treeNode589,
            treeNode594,
            treeNode601,
            treeNode606,
            treeNode612,
            treeNode615,
            treeNode622,
            treeNode627,
            treeNode631,
            treeNode644,
            treeNode652,
            treeNode657,
            treeNode663,
            treeNode666,
            treeNode673,
            treeNode676,
            treeNode684,
            treeNode687,
            treeNode690,
            treeNode694,
            treeNode698,
            treeNode701,
            treeNode704,
            treeNode707,
            treeNode710,
            treeNode713,
            treeNode716,
            treeNode719,
            treeNode723,
            treeNode726,
            treeNode729,
            treeNode732,
            treeNode740,
            treeNode742,
            treeNode748,
            treeNode754,
            treeNode759,
            treeNode764,
            treeNode767,
            treeNode770,
            treeNode773,
            treeNode776,
            treeNode782,
            treeNode785,
            treeNode788,
            treeNode791,
            treeNode800,
            treeNode803,
            treeNode806,
            treeNode810,
            treeNode819,
            treeNode825,
            treeNode830,
            treeNode839,
            treeNode842,
            treeNode845,
            treeNode850,
            treeNode855,
            treeNode858,
            treeNode861,
            treeNode864,
            treeNode871,
            treeNode876,
            treeNode881,
            treeNode888,
            treeNode891,
            treeNode899,
            treeNode904,
            treeNode907,
            treeNode910,
            treeNode913,
            treeNode916,
            treeNode922,
            treeNode927,
            treeNode933,
            treeNode936,
            treeNode939,
            treeNode942,
            treeNode954,
            treeNode964});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(759, 403);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(643, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Expand All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(501, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Collapse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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