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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Version 1.2.16.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Read and Write methods extended to read and write unindexed lines for 1D arrays");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Animate method added");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Fix for indent tab for non-paragraph rtf blocks");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ResetMaterial method added");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("GetPosition method added");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("RSA public private key methods added");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11,
            treeNode13,
            treeNode15,
            treeNode18,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode25,
            treeNode27,
            treeNode38,
            treeNode41,
            treeNode46,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode53,
            treeNode59,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode67,
            treeNode69,
            treeNode71,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode79,
            treeNode83,
            treeNode85,
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95,
            treeNode96,
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode91,
            treeNode98,
            treeNode100,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode108,
            treeNode110,
            treeNode113,
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode119,
            treeNode121,
            treeNode123,
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode129,
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode134,
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode131,
            treeNode133,
            treeNode136,
            treeNode138,
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode144,
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode149,
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode143,
            treeNode146,
            treeNode148,
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode153,
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode155,
            treeNode157,
            treeNode159,
            treeNode161,
            treeNode163,
            treeNode165});
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode167,
            treeNode168,
            treeNode169});
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode171});
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode173});
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode170,
            treeNode172,
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode176});
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode180,
            treeNode181,
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode184,
            treeNode185});
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode177,
            treeNode179,
            treeNode183,
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode190});
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode192});
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode194});
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode189,
            treeNode191,
            treeNode193,
            treeNode195,
            treeNode197});
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode199});
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode206});
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode208});
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode203,
            treeNode205,
            treeNode207,
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode211});
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode215});
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode212,
            treeNode214,
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode219,
            treeNode221,
            treeNode223});
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode225,
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode228,
            treeNode229,
            treeNode230,
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode235});
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode227,
            treeNode232,
            treeNode234,
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode240});
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode244});
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode246});
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode239,
            treeNode241,
            treeNode243,
            treeNode245,
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode249});
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode256});
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode258});
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode255,
            treeNode257,
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode261});
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode264,
            treeNode265,
            treeNode266,
            treeNode267});
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode269,
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode272,
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode268,
            treeNode271,
            treeNode274,
            treeNode276});
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode278,
            treeNode279});
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode281});
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode280,
            treeNode282,
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode286,
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode290});
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode292,
            treeNode293,
            treeNode294,
            treeNode295,
            treeNode296});
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode298,
            treeNode299,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode297,
            treeNode301,
            treeNode303,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode309});
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode311});
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode313});
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode319});
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode308,
            treeNode310,
            treeNode312,
            treeNode314,
            treeNode316,
            treeNode318,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode322,
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode324,
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode330,
            treeNode331,
            treeNode332,
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode329,
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode338,
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode341,
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode337,
            treeNode340,
            treeNode343,
            treeNode345,
            treeNode347,
            treeNode349});
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode358,
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode361});
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode353,
            treeNode355,
            treeNode357,
            treeNode360,
            treeNode362,
            treeNode364,
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode371,
            treeNode372});
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode374});
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode373,
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode377,
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode379,
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode383,
            treeNode384,
            treeNode385,
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode390});
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode387,
            treeNode389,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode393});
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode395});
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode397});
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode399});
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode394,
            treeNode396,
            treeNode398,
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode403});
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode405,
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode408,
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode413,
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode420});
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode422});
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode407,
            treeNode410,
            treeNode412,
            treeNode415,
            treeNode417,
            treeNode419,
            treeNode421,
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode425,
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode427,
            treeNode429});
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode431});
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode434});
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode438,
            treeNode439,
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode435,
            treeNode437,
            treeNode441});
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode445,
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode444,
            treeNode447,
            treeNode449});
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode453,
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode452,
            treeNode455});
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode457});
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode458,
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode464,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode463,
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode468});
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode471,
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode478});
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode480,
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode473,
            treeNode475,
            treeNode477,
            treeNode479,
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode484});
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode487});
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode488,
            treeNode490});
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode493,
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode500,
            treeNode501});
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode502,
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode506,
            treeNode507});
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode510});
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode513,
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode515,
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode519,
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode527,
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode524,
            treeNode526,
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode531});
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode533,
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode532,
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode537,
            treeNode538,
            treeNode539,
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode547,
            treeNode549,
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode557});
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode554,
            treeNode556,
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode564,
            treeNode565});
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode561,
            treeNode563,
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode568});
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode576,
            treeNode577});
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode575,
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode580,
            treeNode581,
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode585});
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode586,
            treeNode588,
            treeNode590});
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode594});
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode593,
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode599,
            treeNode600});
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode598,
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode606});
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode608});
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode607,
            treeNode609,
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode614,
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode618,
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode631,
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode622,
            treeNode624,
            treeNode626,
            treeNode628,
            treeNode630,
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode635,
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode637,
            treeNode639,
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode644,
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode648,
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode650,
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode659,
            treeNode660,
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode658,
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode669,
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode668,
            treeNode671,
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode681,
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode685,
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode707});
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode710,
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode712});
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode723,
            treeNode725,
            treeNode727,
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode733,
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode735,
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode739,
            treeNode741,
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode746,
            treeNode748});
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode751,
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode767,
            treeNode768});
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode769,
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode777});
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode782,
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode787,
            treeNode788});
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode784,
            treeNode786,
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode797,
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode801,
            treeNode802,
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode804,
            treeNode806,
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode810,
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode812,
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode817,
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode822,
            treeNode824,
            treeNode826,
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode834});
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode837,
            treeNode839});
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode842,
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode849});
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode857,
            treeNode858,
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode856,
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode863,
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode868,
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode873,
            treeNode875,
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode886,
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode883,
            treeNode885,
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode890});
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode892});
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode891,
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode895});
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode899});
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode901});
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode902});
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode904});
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode907});
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode909,
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode908,
            treeNode911});
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode913});
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode915});
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode914,
            treeNode916});
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode920,
            treeNode921});
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode919,
            treeNode922});
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode924});
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode925});
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode927});
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode930});
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode931});
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode933,
            treeNode934,
            treeNode935});
            System.Windows.Forms.TreeNode treeNode937 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode938 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode937});
            System.Windows.Forms.TreeNode treeNode939 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode940 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode941 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode939,
            treeNode940});
            System.Windows.Forms.TreeNode treeNode942 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode943 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode942});
            System.Windows.Forms.TreeNode treeNode944 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode936,
            treeNode938,
            treeNode941,
            treeNode943});
            System.Windows.Forms.TreeNode treeNode945 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode946 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode947 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode945,
            treeNode946});
            System.Windows.Forms.TreeNode treeNode948 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode949 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode950 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode951 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode948,
            treeNode949,
            treeNode950});
            System.Windows.Forms.TreeNode treeNode952 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode953 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode952});
            System.Windows.Forms.TreeNode treeNode954 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode947,
            treeNode951,
            treeNode953});
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
            treeNode6.Text = "LD3DView";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Version 1.2.16.0";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Read and Write methods extended to read and write unindexed lines for 1D arrays";
            treeNode9.Name = "Node0";
            treeNode9.Text = "LDFastArray";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Animate method added";
            treeNode11.Name = "Node2";
            treeNode11.Text = "LDGraphicsWindow";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Fix for indent tab for non-paragraph rtf blocks";
            treeNode13.Name = "Node0";
            treeNode13.Text = "LDControls";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Encoding: \"BigEndianUnicode\" and \"UTF32\" depreciated";
            treeNode15.Name = "Node2";
            treeNode15.Text = "LDTextWindow";
            treeNode16.Name = "Node1";
            treeNode16.Text = "ResetMaterial method added";
            treeNode17.Name = "Node2";
            treeNode17.Text = "GetPosition method added";
            treeNode18.Name = "Node0";
            treeNode18.Text = "LD3DView";
            treeNode19.Name = "Node1";
            treeNode19.Text = "RSA public private key methods added";
            treeNode20.Name = "Node0";
            treeNode20.Text = "LDEncryption";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Version 1.2.15.0";
            treeNode22.Name = "Node2";
            treeNode22.Text = "Possible unclosed zip conflicts fixed";
            treeNode23.Name = "Node1";
            treeNode23.Text = "LDZip";
            treeNode24.Name = "Node5";
            treeNode24.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode25.Name = "Node3";
            treeNode25.Text = "LDStopwatch";
            treeNode26.Name = "Node7";
            treeNode26.Text = "LDTimer object added for additional timers";
            treeNode27.Name = "Node6";
            treeNode27.Text = "LDTimer";
            treeNode28.Name = "Node1";
            treeNode28.Text = "Speedup of selected critical performance code listed below";
            treeNode29.Name = "Node2";
            treeNode29.Text = "1) LDShapes.FastMove";
            treeNode30.Name = "Node3";
            treeNode30.Text = "2) LDPhysics graphical updates";
            treeNode31.Name = "Node4";
            treeNode31.Text = "3) LDImage and LDwebCam image processing";
            treeNode32.Name = "Node6";
            treeNode32.Text = "4) LDFastShapes";
            treeNode33.Name = "Node7";
            treeNode33.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode34.Name = "Node8";
            treeNode34.Text = "6) Selected LD3DView visual updates";
            treeNode35.Name = "Node9";
            treeNode35.Text = "7) LDEffect";
            treeNode36.Name = "Node10";
            treeNode36.Text = "8) LDGraph";
            treeNode37.Name = "Node11";
            treeNode37.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode38.Name = "Node0";
            treeNode38.Text = "General";
            treeNode39.Name = "Node1";
            treeNode39.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode40.Name = "Node2";
            treeNode40.Text = "CSV file read and write";
            treeNode41.Name = "Node0";
            treeNode41.Text = "LDFastArray";
            treeNode42.Name = "Node1";
            treeNode42.Text = "DataViewColAlignment method added";
            treeNode43.Name = "Node2";
            treeNode43.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode44.Name = "Node0";
            treeNode44.Text = "RichTextBoxTextTyped event added";
            treeNode45.Name = "Node1";
            treeNode45.Text = "RichTextBoxIndentToTab property added";
            treeNode46.Name = "Node0";
            treeNode46.Text = "LDControls";
            treeNode47.Name = "Node4";
            treeNode47.Text = "OverlapDetail property added";
            treeNode48.Name = "Node3";
            treeNode48.Text = "LDShapes";
            treeNode49.Name = "Node0";
            treeNode49.Text = "Version 1.2.14.0";
            treeNode50.Name = "Node2";
            treeNode50.Text = "TEMP tables allowed for SQLite databases";
            treeNode51.Name = "Node1";
            treeNode51.Text = "LDDataBase";
            treeNode52.Name = "Node1";
            treeNode52.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode53.Name = "Node0";
            treeNode53.Text = "LDMath";
            treeNode54.Name = "Node1";
            treeNode54.Text = "NormalMap method added for normal map 3D effects";
            treeNode55.Name = "Node2";
            treeNode55.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode56.Name = "Node5";
            treeNode56.Text = "MakeTransparent method added";
            treeNode57.Name = "Node6";
            treeNode57.Text = "ReplaceColour method added";
            treeNode58.Name = "Node0";
            treeNode58.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode59.Name = "Node0";
            treeNode59.Text = "LDImage";
            treeNode60.Name = "Node4";
            treeNode60.Text = "All image pixel manipulations speeded up";
            treeNode61.Name = "Node7";
            treeNode61.Text = "More Culture Invariace fixes";
            treeNode62.Name = "Node3";
            treeNode62.Text = "General";
            treeNode63.Name = "Node0";
            treeNode63.Text = "Version 1.2.13.0";
            treeNode64.Name = "Node1";
            treeNode64.Text = "Base conversions extended to include bases up to 36";
            treeNode65.Name = "Node0";
            treeNode65.Text = "LDMath";
            treeNode66.Name = "Node3";
            treeNode66.Text = "Updated to new Bing API";
            treeNode67.Name = "Node2";
            treeNode67.Text = "LDSearch";
            treeNode68.Name = "Node1";
            treeNode68.Text = "ShowInTaskbar property added";
            treeNode69.Name = "Node0";
            treeNode69.Text = "LDGraphicsWindow";
            treeNode70.Name = "Node1";
            treeNode70.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode71.Name = "Node0";
            treeNode71.Text = "LDFile";
            treeNode72.Name = "Node1";
            treeNode72.Text = "ToArray and FromArray methods added";
            treeNode73.Name = "Node0";
            treeNode73.Text = "LDxml";
            treeNode74.Name = "Node0";
            treeNode74.Text = "Version 1.2.12.0";
            treeNode75.Name = "Node2";
            treeNode75.Text = "DataViewColumnWidths method added";
            treeNode76.Name = "Node3";
            treeNode76.Text = "DataViewRowColours method added";
            treeNode77.Name = "Node1";
            treeNode77.Text = "LDControls";
            treeNode78.Name = "Node1";
            treeNode78.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode79.Name = "Node0";
            treeNode79.Text = "General";
            treeNode80.Name = "Node1";
            treeNode80.Text = "SetCentre method added";
            treeNode81.Name = "Node4";
            treeNode81.Text = "A 3rd rotation added";
            treeNode82.Name = "Node3";
            treeNode82.Text = "BoundingBox method added";
            treeNode83.Name = "Node0";
            treeNode83.Text = "LD3DView";
            treeNode84.Name = "Node3";
            treeNode84.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode85.Name = "Node2";
            treeNode85.Text = "LDDatabase";
            treeNode86.Name = "Node1";
            treeNode86.Text = "PlayMusic2 method added";
            treeNode87.Name = "Node2";
            treeNode87.Text = "Channel parameter added";
            treeNode88.Name = "Node0";
            treeNode88.Text = "LDMusic";
            treeNode89.Name = "Node0";
            treeNode89.Text = "Version 1.2.11.0";
            treeNode90.Name = "Node1";
            treeNode90.Text = "SetButtonStyle method added";
            treeNode91.Name = "Node0";
            treeNode91.Text = "LDControls";
            treeNode92.Name = "Node1";
            treeNode92.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode93.Name = "Node2";
            treeNode93.Text = "SetBillBoard method added";
            treeNode94.Name = "Node0";
            treeNode94.Text = "GetCameraUpDirection method added";
            treeNode95.Name = "Node1";
            treeNode95.Text = "Gradient brushes can be used";
            treeNode96.Name = "Node2";
            treeNode96.Text = "AutoControl method added";
            treeNode97.Name = "Node0";
            treeNode97.Text = "SpecularExponent property added";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LD3DView";
            treeNode99.Name = "Node1";
            treeNode99.Text = "AddText method to annotate an image with text added";
            treeNode100.Name = "Node0";
            treeNode100.Text = "LDImage";
            treeNode101.Name = "Node4";
            treeNode101.Text = "BrushText for text on a brush added";
            treeNode102.Name = "Node0";
            treeNode102.Text = "Skew shapes method added";
            treeNode103.Name = "Node3";
            treeNode103.Text = "LDShapes";
            treeNode104.Name = "Node0";
            treeNode104.Text = "Version 1.2.10.0";
            treeNode105.Name = "Node1";
            treeNode105.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode106.Name = "Node0";
            treeNode106.Text = "LDUnits";
            treeNode107.Name = "Node1";
            treeNode107.Text = "Possible issue with FixSigFig fixed";
            treeNode108.Name = "Node0";
            treeNode108.Text = "LDMath";
            treeNode109.Name = "Node3";
            treeNode109.Text = "GetIndex method added (for SB arrays)";
            treeNode110.Name = "Node2";
            treeNode110.Text = "LDArray";
            treeNode111.Name = "Node5";
            treeNode111.Text = "Resize mode property added";
            treeNode112.Name = "Node6";
            treeNode112.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode113.Name = "Node4";
            treeNode113.Text = "LDGraphicsWindow";
            treeNode114.Name = "Node8";
            treeNode114.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode115.Name = "Node9";
            treeNode115.Text = "DataViewAllowUserEntry method added";
            treeNode116.Name = "Node7";
            treeNode116.Text = "LDControls";
            treeNode117.Name = "Node0";
            treeNode117.Text = "Version 1.2.9.0";
            treeNode118.Name = "Node1";
            treeNode118.Text = "New extended math object, starting with FFT";
            treeNode119.Name = "Node0";
            treeNode119.Text = "LDMathX";
            treeNode120.Name = "Node1";
            treeNode120.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode121.Name = "Node0";
            treeNode121.Text = "LDControls";
            treeNode122.Name = "Node3";
            treeNode122.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode123.Name = "Node2";
            treeNode123.Text = "LDArray";
            treeNode124.Name = "Node5";
            treeNode124.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode125.Name = "Node4";
            treeNode125.Text = "LDList";
            treeNode126.Name = "Node0";
            treeNode126.Text = "Version 1.2.8.0";
            treeNode127.Name = "Node2";
            treeNode127.Text = "Error handling, additional settings and multiple ports supported";
            treeNode128.Name = "Node1";
            treeNode128.Text = "LDCommPort";
            treeNode129.Name = "Node1";
            treeNode129.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode130.Name = "Node1";
            treeNode130.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDImage and LDWebCam";
            treeNode132.Name = "Node1";
            treeNode132.Text = "Bitwise operations object added";
            treeNode133.Name = "Node0";
            treeNode133.Text = "LDBits";
            treeNode134.Name = "Node1";
            treeNode134.Text = "Extended text encoding property added";
            treeNode135.Name = "Node0";
            treeNode135.Text = "TextWindow colours can be changed";
            treeNode136.Name = "Node0";
            treeNode136.Text = "LDTextWindow";
            treeNode137.Name = "Node1";
            treeNode137.Text = "GetWorkingImagePixelARGB method added";
            treeNode138.Name = "Node0";
            treeNode138.Text = "LDImage";
            treeNode139.Name = "Node1";
            treeNode139.Text = "RasteriseTurtleLines method added";
            treeNode140.Name = "Node0";
            treeNode140.Text = "LDShapes";
            treeNode141.Name = "Node0";
            treeNode141.Text = "Version 1.2.7.0";
            treeNode142.Name = "Node1";
            treeNode142.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode143.Name = "Node0";
            treeNode143.Text = "LDDialogs";
            treeNode144.Name = "Node1";
            treeNode144.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode145.Name = "Node2";
            treeNode145.Text = "ToggleSensor added";
            treeNode146.Name = "Node0";
            treeNode146.Text = "LDPhysics";
            treeNode147.Name = "Node1";
            treeNode147.Text = "Allow multiple copies of the webcam image";
            treeNode148.Name = "Node0";
            treeNode148.Text = "LDWebCam";
            treeNode149.Name = "Node1";
            treeNode149.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode150.Name = "Node0";
            treeNode150.Text = "MetaData method added";
            treeNode151.Name = "Node0";
            treeNode151.Text = "LDImage";
            treeNode152.Name = "Node0";
            treeNode152.Text = "Version 1.2.6.0";
            treeNode153.Name = "Node2";
            treeNode153.Text = "FixSigFig and FixDecimal methods added";
            treeNode154.Name = "Node3";
            treeNode154.Text = "MinNumber and MaxNumber properties added";
            treeNode155.Name = "Node1";
            treeNode155.Text = "LDMath";
            treeNode156.Name = "Node1";
            treeNode156.Text = "SliderMaximum property added";
            treeNode157.Name = "Node0";
            treeNode157.Text = "LDControls";
            treeNode158.Name = "Node1";
            treeNode158.Text = "ZoomAll method added";
            treeNode159.Name = "Node0";
            treeNode159.Text = "LDShapes";
            treeNode160.Name = "Node1";
            treeNode160.Text = "Reposition methods and properties added";
            treeNode161.Name = "Node0";
            treeNode161.Text = "LDGraphicsWindow";
            treeNode162.Name = "Node1";
            treeNode162.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode163.Name = "Node0";
            treeNode163.Text = "LDImage";
            treeNode164.Name = "Node1";
            treeNode164.Text = "MouseScroll parameter added";
            treeNode165.Name = "Node0";
            treeNode165.Text = "LDScrollBars";
            treeNode166.Name = "Node0";
            treeNode166.Text = "Version 1.2.5.0";
            treeNode167.Name = "Node0";
            treeNode167.Text = "New object added (previously a separate extension)";
            treeNode168.Name = "Node1";
            treeNode168.Text = "Async, Loop, Volume and Pan properties added";
            treeNode169.Name = "Node2";
            treeNode169.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode170.Name = "Node1";
            treeNode170.Text = "LDWaveForm";
            treeNode171.Name = "Node1";
            treeNode171.Text = "New object added to get input from gamepads or joysticks";
            treeNode172.Name = "Node0";
            treeNode172.Text = "LDController";
            treeNode173.Name = "Node1";
            treeNode173.Text = "RayCast method added";
            treeNode174.Name = "Node0";
            treeNode174.Text = "LDPhysics";
            treeNode175.Name = "Node0";
            treeNode175.Text = "Version 1.2.4.0";
            treeNode176.Name = "Node2";
            treeNode176.Text = "New object to apply effects to any shape or control";
            treeNode177.Name = "Node1";
            treeNode177.Text = "LDEffects";
            treeNode178.Name = "Node1";
            treeNode178.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode179.Name = "Node0";
            treeNode179.Text = "LDFigures";
            treeNode180.Name = "Node1";
            treeNode180.Text = "SetGroup method added";
            treeNode181.Name = "Node2";
            treeNode181.Text = "GetContacts method added";
            treeNode182.Name = "Node0";
            treeNode182.Text = "GetAllShapesAt method added";
            treeNode183.Name = "Node0";
            treeNode183.Text = "LDPhysics";
            treeNode184.Name = "Node2";
            treeNode184.Text = "SetImage handles images with transparency";
            treeNode185.Name = "Node0";
            treeNode185.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode186.Name = "Node1";
            treeNode186.Text = "LDClipboard";
            treeNode187.Name = "Node0";
            treeNode187.Text = "Version 1.2.3.0";
            treeNode188.Name = "Node2";
            treeNode188.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode189.Name = "Node1";
            treeNode189.Text = "LDShapes";
            treeNode190.Name = "Node4";
            treeNode190.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode191.Name = "Node3";
            treeNode191.Text = "LDFile";
            treeNode192.Name = "Node6";
            treeNode192.Text = "NewImage method added";
            treeNode193.Name = "Node5";
            treeNode193.Text = "LDImage";
            treeNode194.Name = "Node1";
            treeNode194.Text = "SetStartupPosition method added to position dialogs";
            treeNode195.Name = "Node0";
            treeNode195.Text = "LDDialogs";
            treeNode196.Name = "Node1";
            treeNode196.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode197.Name = "Node0";
            treeNode197.Text = "LDGraph";
            treeNode198.Name = "Node0";
            treeNode198.Text = "Version 1.2.2.0";
            treeNode199.Name = "Node2";
            treeNode199.Text = "Recompiled for Small Basic version 1.2";
            treeNode200.Name = "Node1";
            treeNode200.Text = "Version 1.2";
            treeNode201.Name = "Node0";
            treeNode201.Text = "Version 1.2.0.1";
            treeNode202.Name = "Node2";
            treeNode202.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode203.Name = "Node1";
            treeNode203.Text = "LDDialogs";
            treeNode204.Name = "Node1";
            treeNode204.Text = "Logical operations object added";
            treeNode205.Name = "Node0";
            treeNode205.Text = "LDLogic";
            treeNode206.Name = "Node4";
            treeNode206.Text = "CurrentCulture property added";
            treeNode207.Name = "Node3";
            treeNode207.Text = "LDUtilities";
            treeNode208.Name = "Node6";
            treeNode208.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode209.Name = "Node5";
            treeNode209.Text = "LDMath";
            treeNode210.Name = "Node0";
            treeNode210.Text = "Version 1.1.0.8";
            treeNode211.Name = "Node1";
            treeNode211.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode212.Name = "Node0";
            treeNode212.Text = "LDControls";
            treeNode213.Name = "Node1";
            treeNode213.Text = "Methods added to add and remove nodes and save xml file";
            treeNode214.Name = "Node0";
            treeNode214.Text = "LDxml";
            treeNode215.Name = "Node1";
            treeNode215.Text = "MusicPlayTime moved from LDFile";
            treeNode216.Name = "Node0";
            treeNode216.Text = "LDSound";
            treeNode217.Name = "Node0";
            treeNode217.Text = "Version 1.1.0.7";
            treeNode218.Name = "Node4";
            treeNode218.Text = "SplitImage method added";
            treeNode219.Name = "Node3";
            treeNode219.Text = "LDImage";
            treeNode220.Name = "Node6";
            treeNode220.Text = "EditTable and SaveTable methods added";
            treeNode221.Name = "Node5";
            treeNode221.Text = "LDDatabse";
            treeNode222.Name = "Node2";
            treeNode222.Text = "DataView control and methods added";
            treeNode223.Name = "Node1";
            treeNode223.Text = "LDControls";
            treeNode224.Name = "Node2";
            treeNode224.Text = "Version 1.1.0.6";
            treeNode225.Name = "Node2";
            treeNode225.Text = "Exists modified to check for directory as well as file";
            treeNode226.Name = "Node3";
            treeNode226.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode227.Name = "Node1";
            treeNode227.Text = "LDFile";
            treeNode228.Name = "Node5";
            treeNode228.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode229.Name = "Node6";
            treeNode229.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode230.Name = "Node9";
            treeNode230.Text = "Conditonal break point added";
            treeNode231.Name = "Node0";
            treeNode231.Text = "Step over button added";
            treeNode232.Name = "Node4";
            treeNode232.Text = "LDDebug";
            treeNode233.Name = "Node8";
            treeNode233.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode234.Name = "Node7";
            treeNode234.Text = "LDGraphicsWindow";
            treeNode235.Name = "Node1";
            treeNode235.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode236.Name = "Node0";
            treeNode236.Text = "LDResources";
            treeNode237.Name = "Node0";
            treeNode237.Text = "Version 1.1.0.5";
            treeNode238.Name = "Node2";
            treeNode238.Text = "ClipboardChanged event added";
            treeNode239.Name = "Node1";
            treeNode239.Text = "LDClipboard";
            treeNode240.Name = "Node1";
            treeNode240.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode241.Name = "Node0";
            treeNode241.Text = "LDFile";
            treeNode242.Name = "Node3";
            treeNode242.Text = "SetActive method added";
            treeNode243.Name = "Node2";
            treeNode243.Text = "LDGraphicsWindow";
            treeNode244.Name = "Node1";
            treeNode244.Text = "Parse xml file nodes";
            treeNode245.Name = "Node0";
            treeNode245.Text = "LDxml";
            treeNode246.Name = "Node3";
            treeNode246.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode247.Name = "Node2";
            treeNode247.Text = "General";
            treeNode248.Name = "Node0";
            treeNode248.Text = "Version 1.1.0.4";
            treeNode249.Name = "Node2";
            treeNode249.Text = "WakeAll method addded";
            treeNode250.Name = "Node1";
            treeNode250.Text = "LDPhysics";
            treeNode251.Name = "Node1";
            treeNode251.Text = "Clipboard methods added";
            treeNode252.Name = "Node0";
            treeNode252.Text = "LDClipboard";
            treeNode253.Name = "Node0";
            treeNode253.Text = "Version 1.1.0.3";
            treeNode254.Name = "Node6";
            treeNode254.Text = "SizeNWSE cursor added";
            treeNode255.Name = "Node5";
            treeNode255.Text = "LDCursors";
            treeNode256.Name = "Node8";
            treeNode256.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode257.Name = "Node7";
            treeNode257.Text = "LDGraph";
            treeNode258.Name = "Node1";
            treeNode258.Text = "SQLite updated for .Net 4.5";
            treeNode259.Name = "Node0";
            treeNode259.Text = "LDDataBase";
            treeNode260.Name = "Node4";
            treeNode260.Text = "Version 1.1.0.2";
            treeNode261.Name = "Node3";
            treeNode261.Text = "Recompiled for Small Basic version 1.1";
            treeNode262.Name = "Node2";
            treeNode262.Text = "Version 1.1";
            treeNode263.Name = "Node0";
            treeNode263.Text = "Version 1.1.0.1";
            treeNode264.Name = "Node12";
            treeNode264.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode265.Name = "Node13";
            treeNode265.Text = "RichTextBoxMargins method added";
            treeNode266.Name = "Node0";
            treeNode266.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode267.Name = "Node1";
            treeNode267.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode268.Name = "Node11";
            treeNode268.Text = "LDControls";
            treeNode269.Name = "Node3";
            treeNode269.Text = "Error reporting added";
            treeNode270.Name = "Node4";
            treeNode270.Text = "SetEncoding method added";
            treeNode271.Name = "Node2";
            treeNode271.Text = "LDCommPort";
            treeNode272.Name = "Node6";
            treeNode272.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode273.Name = "Node7";
            treeNode273.Text = "Export to excel fix for graph with no title";
            treeNode274.Name = "Node5";
            treeNode274.Text = "LDGraph";
            treeNode275.Name = "Node9";
            treeNode275.Text = "Negative restitution option when adding moving shape";
            treeNode276.Name = "Node8";
            treeNode276.Text = "LDPhysics";
            treeNode277.Name = "Node10";
            treeNode277.Text = "Version 1.0.0.133";
            treeNode278.Name = "Node2";
            treeNode278.Text = "Internal improvements to auto messaging";
            treeNode279.Name = "Node9";
            treeNode279.Text = "Name can be set and GetClients method added";
            treeNode280.Name = "Node1";
            treeNode280.Text = "LDClient";
            treeNode281.Name = "Node4";
            treeNode281.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode282.Name = "Node3";
            treeNode282.Text = "LDControls";
            treeNode283.Name = "Node8";
            treeNode283.Text = "Return message and possible file error fixed for Stop method";
            treeNode284.Name = "Node7";
            treeNode284.Text = "LDSound";
            treeNode285.Name = "Node0";
            treeNode285.Text = "Version 1.0.0.132";
            treeNode286.Name = "Node2";
            treeNode286.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode287.Name = "Node5";
            treeNode287.Text = "Compile method added to compile a Small Basic program";
            treeNode288.Name = "Node1";
            treeNode288.Text = "LDCall";
            treeNode289.Name = "Node4";
            treeNode289.Text = "Methods and code by Pappa Lapub added";
            treeNode290.Name = "Node3";
            treeNode290.Text = "LDShell";
            treeNode291.Name = "Node0";
            treeNode291.Text = "Version 1.0.0.131";
            treeNode292.Name = "Node6";
            treeNode292.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode293.Name = "Node7";
            treeNode293.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode294.Name = "Node8";
            treeNode294.Text = "Refactoring of all the pan, follow and box methods";
            treeNode295.Name = "Node6";
            treeNode295.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode296.Name = "Node8";
            treeNode296.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode297.Name = "Node5";
            treeNode297.Text = "LDPhysics";
            treeNode298.Name = "Node1";
            treeNode298.Text = "UseBinary property added";
            treeNode299.Name = "Node2";
            treeNode299.Text = "DoAsync property and associated completion events added";
            treeNode300.Name = "Node3";
            treeNode300.Text = "Delete method added";
            treeNode301.Name = "Node0";
            treeNode301.Text = "LDftp";
            treeNode302.Name = "Node5";
            treeNode302.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode303.Name = "Node4";
            treeNode303.Text = "LDCall";
            treeNode304.Name = "Node2";
            treeNode304.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode305.Name = "Node1";
            treeNode305.Text = "LDControls";
            treeNode306.Name = "Node4";
            treeNode306.Text = "Version 1.0.0.130";
            treeNode307.Name = "Node2";
            treeNode307.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode308.Name = "Node1";
            treeNode308.Text = "LDMath";
            treeNode309.Name = "Node1";
            treeNode309.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode310.Name = "Node0";
            treeNode310.Text = "LDPhysics";
            treeNode311.Name = "Node3";
            treeNode311.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode312.Name = "Node2";
            treeNode312.Text = "LDGraphicsWindow";
            treeNode313.Name = "Node1";
            treeNode313.Text = "FTP object methods added";
            treeNode314.Name = "Node0";
            treeNode314.Text = "LDftp";
            treeNode315.Name = "Node3";
            treeNode315.Text = "An existing file is replaced";
            treeNode316.Name = "Node2";
            treeNode316.Text = "LDZip";
            treeNode317.Name = "Node1";
            treeNode317.Text = "Size method added";
            treeNode318.Name = "Node0";
            treeNode318.Text = "LDFile";
            treeNode319.Name = "Node3";
            treeNode319.Text = "DownloadFile method added";
            treeNode320.Name = "Node2";
            treeNode320.Text = "LDNetwork";
            treeNode321.Name = "Node0";
            treeNode321.Text = "Version 1.0.0.129";
            treeNode322.Name = "Node2";
            treeNode322.Text = "Generalised joint connections added";
            treeNode323.Name = "Node0";
            treeNode323.Text = "AddExplosion method added";
            treeNode324.Name = "Node1";
            treeNode324.Text = "LDPhysics";
            treeNode325.Name = "Node1";
            treeNode325.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode326.Name = "Node0";
            treeNode326.Text = "LDShapes";
            treeNode327.Name = "Node0";
            treeNode327.Text = "Version 1.0.0.128";
            treeNode328.Name = "Node2";
            treeNode328.Text = "CheckServer method added";
            treeNode329.Name = "Node1";
            treeNode329.Text = "LDClient";
            treeNode330.Name = "Node1";
            treeNode330.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode331.Name = "Node2";
            treeNode331.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode332.Name = "Node3";
            treeNode332.Text = "GetAngle method added";
            treeNode333.Name = "Node4";
            treeNode333.Text = "Top-down tire (to model a car from above) methods added";
            treeNode334.Name = "Node0";
            treeNode334.Text = "LDPhysics";
            treeNode335.Name = "Node0";
            treeNode335.Text = "Version 1.0.0.127";
            treeNode336.Name = "Node7";
            treeNode336.Text = "Bug fixes for Overlap methods";
            treeNode337.Name = "Node6";
            treeNode337.Text = "LDShapes";
            treeNode338.Name = "Node0";
            treeNode338.Text = "Bug fix for multiple numeric sorts";
            treeNode339.Name = "Node9";
            treeNode339.Text = "ByValueWithIndex method added";
            treeNode340.Name = "Node8";
            treeNode340.Text = "LDSort";
            treeNode341.Name = "Node1";
            treeNode341.Text = "LAN method added to get local IP addresses";
            treeNode342.Name = "Node2";
            treeNode342.Text = "Ping method added";
            treeNode343.Name = "Node0";
            treeNode343.Text = "LDNetwork";
            treeNode344.Name = "Node1";
            treeNode344.Text = "LoadSVG method added";
            treeNode345.Name = "Node0";
            treeNode345.Text = "LDImage";
            treeNode346.Name = "Node3";
            treeNode346.Text = "Evaluate method added";
            treeNode347.Name = "Node2";
            treeNode347.Text = "LDMath";
            treeNode348.Name = "Node5";
            treeNode348.Text = "IncludeJScript method added";
            treeNode349.Name = "Node4";
            treeNode349.Text = "LDInline";
            treeNode350.Name = "Node5";
            treeNode350.Text = "Version 1.0.0.126";
            treeNode351.Name = "Node0";
            treeNode351.Text = "Special emphasis on async consistency";
            treeNode352.Name = "Node4";
            treeNode352.Text = "Simplified auto method for multi-player game data transfer";
            treeNode353.Name = "Node9";
            treeNode353.Text = "LDServer and LDClient objects added";
            treeNode354.Name = "Node2";
            treeNode354.Text = "GetWidth and GetHeight methods added";
            treeNode355.Name = "Node1";
            treeNode355.Text = "LDText";
            treeNode356.Name = "Node4";
            treeNode356.Text = "Bing web search";
            treeNode357.Name = "Node3";
            treeNode357.Text = "LDSearch";
            treeNode358.Name = "Node6";
            treeNode358.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode359.Name = "Node7";
            treeNode359.Text = "KeyScroll property added";
            treeNode360.Name = "Node5";
            treeNode360.Text = "LDScrollBars";
            treeNode361.Name = "Node9";
            treeNode361.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode362.Name = "Node8";
            treeNode362.Text = "LDShapes";
            treeNode363.Name = "Node1";
            treeNode363.Text = "SaveAs method bug fixed";
            treeNode364.Name = "Node0";
            treeNode364.Text = "LDImage";
            treeNode365.Name = "Node3";
            treeNode365.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode366.Name = "Node2";
            treeNode366.Text = "LDQueue";
            treeNode367.Name = "Node8";
            treeNode367.Text = "Version 1.0.0.125";
            treeNode368.Name = "Node7";
            treeNode368.Text = "Language translation object added";
            treeNode369.Name = "Node6";
            treeNode369.Text = "LDTranslate";
            treeNode370.Name = "Node5";
            treeNode370.Text = "Version 1.0.0.124";
            treeNode371.Name = "Node1";
            treeNode371.Text = "Mouse screen coordinate conversion parameters added";
            treeNode372.Name = "Node2";
            treeNode372.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode373.Name = "Node0";
            treeNode373.Text = "LDGraphicsWindow";
            treeNode374.Name = "Node4";
            treeNode374.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode375.Name = "Node3";
            treeNode375.Text = "LDUtilities";
            treeNode376.Name = "Node0";
            treeNode376.Text = "Version 1.0.0.123";
            treeNode377.Name = "Node5";
            treeNode377.Text = "ColorMatrix method added";
            treeNode378.Name = "Node0";
            treeNode378.Text = "Rotate method added";
            treeNode379.Name = "Node3";
            treeNode379.Text = "LDImage";
            treeNode380.Name = "Node1";
            treeNode380.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode381.Name = "Node0";
            treeNode381.Text = "LDChart";
            treeNode382.Name = "Node2";
            treeNode382.Text = "Version 1.0.0.122";
            treeNode383.Name = "Node2";
            treeNode383.Text = "EffectGamma added to darken and lighten";
            treeNode384.Name = "Node4";
            treeNode384.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode385.Name = "Node3";
            treeNode385.Text = "EffectContrast modified";
            treeNode386.Name = "Node0";
            treeNode386.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode387.Name = "Node1";
            treeNode387.Text = "LDImage";
            treeNode388.Name = "Node2";
            treeNode388.Text = "Error event added for all extension exceptions";
            treeNode389.Name = "Node1";
            treeNode389.Text = "LDEvents";
            treeNode390.Name = "Node1";
            treeNode390.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode391.Name = "Node0";
            treeNode391.Text = "LDMath";
            treeNode392.Name = "Node0";
            treeNode392.Text = "Version 1.0.0.121";
            treeNode393.Name = "Node2";
            treeNode393.Text = "FloodFill transparency effect fixed";
            treeNode394.Name = "Node1";
            treeNode394.Text = "LDGraphicsWindow";
            treeNode395.Name = "Node1";
            treeNode395.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode396.Name = "Node0";
            treeNode396.Text = "LDFile";
            treeNode397.Name = "Node1";
            treeNode397.Text = "EffectPixelate added";
            treeNode398.Name = "Node0";
            treeNode398.Text = "LDImage";
            treeNode399.Name = "Node1";
            treeNode399.Text = "Modified to work with Windows 8";
            treeNode400.Name = "Node0";
            treeNode400.Text = "LDWebCam";
            treeNode401.Name = "Node0";
            treeNode401.Text = "Version 1.0.0.120";
            treeNode402.Name = "Node2";
            treeNode402.Text = "FloodFill method added";
            treeNode403.Name = "Node1";
            treeNode403.Text = "LDGraphicsWindow";
            treeNode404.Name = "Node0";
            treeNode404.Text = "Version 1.0.0.119";
            treeNode405.Name = "Node0";
            treeNode405.Text = "SetShapeCursor method added";
            treeNode406.Name = "Node11";
            treeNode406.Text = "CreateCursor method added";
            treeNode407.Name = "Node9";
            treeNode407.Text = "LDCursors";
            treeNode408.Name = "Node2";
            treeNode408.Text = "SaveAs method to save in different file formats";
            treeNode409.Name = "Node0";
            treeNode409.Text = "Parameters added for some effects";
            treeNode410.Name = "Node1";
            treeNode410.Text = "LDImage";
            treeNode411.Name = "Node2";
            treeNode411.Text = "Parameters added for some effects";
            treeNode412.Name = "Node1";
            treeNode412.Text = "LDWebCam";
            treeNode413.Name = "Node1";
            treeNode413.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode414.Name = "Node0";
            treeNode414.Text = "SetFontFromFile method added for ttf fonts";
            treeNode415.Name = "Node0";
            treeNode415.Text = "LDGraphicsWindow";
            treeNode416.Name = "Node3";
            treeNode416.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode417.Name = "Node2";
            treeNode417.Text = "LDTextWindow";
            treeNode418.Name = "Node2";
            treeNode418.Text = "Zip methods moved here from LDUtilities";
            treeNode419.Name = "Node0";
            treeNode419.Text = "LDZip";
            treeNode420.Name = "Node3";
            treeNode420.Text = "Regex methods moved here from LDUtilities";
            treeNode421.Name = "Node1";
            treeNode421.Text = "LDRegex";
            treeNode422.Name = "Node1";
            treeNode422.Text = "ListViewRowCount method added";
            treeNode423.Name = "Node0";
            treeNode423.Text = "LDControls";
            treeNode424.Name = "Node3";
            treeNode424.Text = "Version 1.0.0.118";
            treeNode425.Name = "Node5";
            treeNode425.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode426.Name = "Node6";
            treeNode426.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode427.Name = "Node4";
            treeNode427.Text = "LDUtilities";
            treeNode428.Name = "Node10";
            treeNode428.Text = "SetUserCursor method added";
            treeNode429.Name = "Node4";
            treeNode429.Text = "LDCursors";
            treeNode430.Name = "Node3";
            treeNode430.Text = "Version 1.0.0.117";
            treeNode431.Name = "Node2";
            treeNode431.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode432.Name = "Node1";
            treeNode432.Text = "LDDictionary";
            treeNode433.Name = "Node0";
            treeNode433.Text = "Version 1.0.0.116";
            treeNode434.Name = "Node2";
            treeNode434.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode435.Name = "Node1";
            treeNode435.Text = "LDColours";
            treeNode436.Name = "Node4";
            treeNode436.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode437.Name = "Node3";
            treeNode437.Text = "LDShapes";
            treeNode438.Name = "Node1";
            treeNode438.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode439.Name = "Node0";
            treeNode439.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode440.Name = "Node1";
            treeNode440.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode441.Name = "Node0";
            treeNode441.Text = "LDGraph";
            treeNode442.Name = "Node0";
            treeNode442.Text = "Version 1.0.0.115";
            treeNode443.Name = "Node2";
            treeNode443.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode444.Name = "Node1";
            treeNode444.Text = "LDControls";
            treeNode445.Name = "Node4";
            treeNode445.Text = "RemoveTurtleLines method added";
            treeNode446.Name = "Node6";
            treeNode446.Text = "GetAllShapes method added";
            treeNode447.Name = "Node3";
            treeNode447.Text = "LDShapes";
            treeNode448.Name = "Node1";
            treeNode448.Text = "Odbc connection added";
            treeNode449.Name = "Node0";
            treeNode449.Text = "LDDatabase";
            treeNode450.Name = "Node0";
            treeNode450.Text = "Version 1.0.0.114";
            treeNode451.Name = "Node2";
            treeNode451.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode452.Name = "Node1";
            treeNode452.Text = "LDUtilities";
            treeNode453.Name = "Node4";
            treeNode453.Text = "ListView control added";
            treeNode454.Name = "Node5";
            treeNode454.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode455.Name = "Node3";
            treeNode455.Text = "LDControls";
            treeNode456.Name = "Node0";
            treeNode456.Text = "Version 1.0.0.113";
            treeNode457.Name = "Node2";
            treeNode457.Text = "Tone method added";
            treeNode458.Name = "Node1";
            treeNode458.Text = "LDSound";
            treeNode459.Name = "Node5";
            treeNode459.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode460.Name = "Node4";
            treeNode460.Text = "LDControls";
            treeNode461.Name = "Node0";
            treeNode461.Text = "Version 1.0.0.112";
            treeNode462.Name = "Node2";
            treeNode462.Text = "SqlServer and Access database support added";
            treeNode463.Name = "Node1";
            treeNode463.Text = "LDDataBase";
            treeNode464.Name = "Node4";
            treeNode464.Text = "FixFlickr method added";
            treeNode465.Name = "Node0";
            treeNode465.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode466.Name = "Node3";
            treeNode466.Text = "LDUtilities";
            treeNode467.Name = "Node0";
            treeNode467.Text = "Version 1.0.0.111";
            treeNode468.Name = "Node2";
            treeNode468.Text = "TextBoxTab method added";
            treeNode469.Name = "Node1";
            treeNode469.Text = "LDControls";
            treeNode470.Name = "Node0";
            treeNode470.Text = "Version 1.0.0.110";
            treeNode471.Name = "Node1";
            treeNode471.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode472.Name = "Node3";
            treeNode472.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode473.Name = "Node0";
            treeNode473.Text = "General";
            treeNode474.Name = "Node5";
            treeNode474.Text = "Exists method added to check if a file path exists or not";
            treeNode475.Name = "Node4";
            treeNode475.Text = "LDFile";
            treeNode476.Name = "Node7";
            treeNode476.Text = "Start method handles attaching to existing process without warning";
            treeNode477.Name = "Node6";
            treeNode477.Text = "LDProcess";
            treeNode478.Name = "Node1";
            treeNode478.Text = "MySQL database support added";
            treeNode479.Name = "Node0";
            treeNode479.Text = "LDDatabase";
            treeNode480.Name = "Node3";
            treeNode480.Text = "Add and Multiply methods honour transparency";
            treeNode481.Name = "Node4";
            treeNode481.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode482.Name = "Node2";
            treeNode482.Text = "LDImage";
            treeNode483.Name = "Node3";
            treeNode483.Text = "Version 1.0.0.109";
            treeNode484.Name = "Node2";
            treeNode484.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode485.Name = "Node1";
            treeNode485.Text = "LDTextWindow";
            treeNode486.Name = "Node0";
            treeNode486.Text = "Version 1.0.0.108";
            treeNode487.Name = "Node14";
            treeNode487.Text = "Transparent colour added";
            treeNode488.Name = "Node13";
            treeNode488.Text = "LDColours";
            treeNode489.Name = "Node16";
            treeNode489.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode490.Name = "Node15";
            treeNode490.Text = "LDDialogs";
            treeNode491.Name = "Node12";
            treeNode491.Text = "Version 1.0.0.107";
            treeNode492.Name = "Node8";
            treeNode492.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode493.Name = "Node7";
            treeNode493.Text = "LDControls";
            treeNode494.Name = "Node11";
            treeNode494.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode495.Name = "Node10";
            treeNode495.Text = "LDShapes";
            treeNode496.Name = "Node6";
            treeNode496.Text = "Version 1.0.0.106";
            treeNode497.Name = "Node5";
            treeNode497.Text = "Menu control added";
            treeNode498.Name = "Node4";
            treeNode498.Text = "LDControls";
            treeNode499.Name = "Node3";
            treeNode499.Text = "Version 1.0.0.105";
            treeNode500.Name = "Node5";
            treeNode500.Text = "ZipList method added";
            treeNode501.Name = "Node2";
            treeNode501.Text = "GetNextMapIndex method added";
            treeNode502.Name = "Node4";
            treeNode502.Text = "LDUtilities";
            treeNode503.Name = "Node1";
            treeNode503.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode504.Name = "Node0";
            treeNode504.Text = "LDShapes";
            treeNode505.Name = "Node3";
            treeNode505.Text = "Version 1.0.0.104";
            treeNode506.Name = "Node1";
            treeNode506.Text = "Transparency maintained for various methods";
            treeNode507.Name = "Node2";
            treeNode507.Text = "Effects bug fixed";
            treeNode508.Name = "Node0";
            treeNode508.Text = "LDImage";
            treeNode509.Name = "Node0";
            treeNode509.Text = "Version 1.0.0.103";
            treeNode510.Name = "Node1";
            treeNode510.Text = "Current application assemblies are all auto-referenced";
            treeNode511.Name = "Node0";
            treeNode511.Text = "LDInline";
            treeNode512.Name = "Node5";
            treeNode512.Text = "Version 1.0.0.102";
            treeNode513.Name = "Node1";
            treeNode513.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode514.Name = "Node2";
            treeNode514.Text = "LDInline.sb sample provided";
            treeNode515.Name = "Node0";
            treeNode515.Text = "LDInline";
            treeNode516.Name = "Node4";
            treeNode516.Text = "ExitButtonMode method added to control window close button state";
            treeNode517.Name = "Node3";
            treeNode517.Text = "LDUtilities";
            treeNode518.Name = "Node0";
            treeNode518.Text = "Version 1.0.0.101";
            treeNode519.Name = "Node1";
            treeNode519.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode520.Name = "Node0";
            treeNode520.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode521.Name = "Node0";
            treeNode521.Text = "LDTextWindow";
            treeNode522.Name = "Node0";
            treeNode522.Text = "Version 1.0.0.100";
            treeNode523.Name = "Node2";
            treeNode523.Text = "ReadANSIToArray method added";
            treeNode524.Name = "Node1";
            treeNode524.Text = "LDFile";
            treeNode525.Name = "Node1";
            treeNode525.Text = "DocumentViewer control added";
            treeNode526.Name = "Node0";
            treeNode526.Text = "LDControls";
            treeNode527.Name = "Node3";
            treeNode527.Text = "An object to batch update shapes (for speed reasons)";
            treeNode528.Name = "Node0";
            treeNode528.Text = "LDFastShapes.sb sample included";
            treeNode529.Name = "Node2";
            treeNode529.Text = "LDFastShapes";
            treeNode530.Name = "Node0";
            treeNode530.Text = "Version 1.0.0.99";
            treeNode531.Name = "Node1";
            treeNode531.Text = "Rendering performance improvements when many shapes present";
            treeNode532.Name = "Node0";
            treeNode532.Text = "LDPhysics";
            treeNode533.Name = "Node1";
            treeNode533.Text = "ANSItoUTF8 method added";
            treeNode534.Name = "Node2";
            treeNode534.Text = "ReadANSI method added";
            treeNode535.Name = "Node0";
            treeNode535.Text = "LDFile";
            treeNode536.Name = "Node1";
            treeNode536.Text = "Version 1.0.0.98";
            treeNode537.Name = "Node3";
            treeNode537.Text = "Move method added for tiangles, polygons and lines";
            treeNode538.Name = "Node4";
            treeNode538.Text = "RotateAbout method added";
            treeNode539.Name = "Node1";
            treeNode539.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode540.Name = "Node0";
            treeNode540.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode541.Name = "Node2";
            treeNode541.Text = "LDShapes";
            treeNode542.Name = "Node0";
            treeNode542.Text = "Version 1.0.0.97";
            treeNode543.Name = "Node4";
            treeNode543.Text = "A list storage object added";
            treeNode544.Name = "Node3";
            treeNode544.Text = "LDList";
            treeNode545.Name = "Node2";
            treeNode545.Text = "Version 1.0.0.96";
            treeNode546.Name = "Node4";
            treeNode546.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode547.Name = "Node3";
            treeNode547.Text = "LDQueue";
            treeNode548.Name = "Node6";
            treeNode548.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode549.Name = "Node5";
            treeNode549.Text = "LDNetwork";
            treeNode550.Name = "Node0";
            treeNode550.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode551.Name = "Node1";
            treeNode551.Text = "General";
            treeNode552.Name = "Node2";
            treeNode552.Text = "Version 1.0.0.95";
            treeNode553.Name = "Node2";
            treeNode553.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode554.Name = "Node1";
            treeNode554.Text = "LDEncryption";
            treeNode555.Name = "Node1";
            treeNode555.Text = "RandomNumberSeed property added";
            treeNode556.Name = "Node0";
            treeNode556.Text = "LDMath";
            treeNode557.Name = "Node1";
            treeNode557.Text = "SetGameData and GetGameData methods added";
            treeNode558.Name = "Node0";
            treeNode558.Text = "LDNetwork";
            treeNode559.Name = "Node0";
            treeNode559.Text = "Version 1.0.0.94";
            treeNode560.Name = "Node1";
            treeNode560.Text = "SliderGetValue method added";
            treeNode561.Name = "Node0";
            treeNode561.Text = "LDControls";
            treeNode562.Name = "Node5";
            treeNode562.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode563.Name = "Node2";
            treeNode563.Text = "LDUtilities";
            treeNode564.Name = "Node3";
            treeNode564.Text = "Encrypt and Decrypt methods added";
            treeNode565.Name = "Node4";
            treeNode565.Text = "MD5Hash method added";
            treeNode566.Name = "Node6";
            treeNode566.Text = "LDEncryption";
            treeNode567.Name = "Node0";
            treeNode567.Text = "Version 1.0.0.93";
            treeNode568.Name = "Node1";
            treeNode568.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode569.Name = "Node0";
            treeNode569.Text = "LDControls";
            treeNode570.Name = "Node0";
            treeNode570.Text = "Version 1.0.0.92";
            treeNode571.Name = "Node2";
            treeNode571.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode572.Name = "Node1";
            treeNode572.Text = "LDControls";
            treeNode573.Name = "Node1";
            treeNode573.Text = "Version 1.0.0.91";
            treeNode574.Name = "Node1";
            treeNode574.Text = "Font method added to modify shapes or controls that have text";
            treeNode575.Name = "Node0";
            treeNode575.Text = "LDShapes";
            treeNode576.Name = "Node1";
            treeNode576.Text = "MediaPlayer control added (play videos etc)";
            treeNode577.Name = "Node0";
            treeNode577.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode578.Name = "Node0";
            treeNode578.Text = "LDControls";
            treeNode579.Name = "Node1";
            treeNode579.Text = "Version 1.0.0.90";
            treeNode580.Name = "Node1";
            treeNode580.Text = "Autosize columns for ListView";
            treeNode581.Name = "Node2";
            treeNode581.Text = "LDDataBase.sb sample updated";
            treeNode582.Name = "Node0";
            treeNode582.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode583.Name = "Node0";
            treeNode583.Text = "LDDataBase";
            treeNode584.Name = "Node0";
            treeNode584.Text = "Version 1.0.0.89";
            treeNode585.Name = "Node4";
            treeNode585.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode586.Name = "Node3";
            treeNode586.Text = "LDScrollBars";
            treeNode587.Name = "Node1";
            treeNode587.Text = "CleanTemp method added";
            treeNode588.Name = "Node0";
            treeNode588.Text = "LDUtilities";
            treeNode589.Name = "Node1";
            treeNode589.Text = "SQLite database methods added";
            treeNode590.Name = "Node0";
            treeNode590.Text = "LDDataBase";
            treeNode591.Name = "Node2";
            treeNode591.Text = "Version 1.0.0.88";
            treeNode592.Name = "Node2";
            treeNode592.Text = "LastError now returns a text error";
            treeNode593.Name = "Node1";
            treeNode593.Text = "LDIOWarrior";
            treeNode594.Name = "Node1";
            treeNode594.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode595.Name = "Node0";
            treeNode595.Text = "LDScrollBars";
            treeNode596.Name = "Node0";
            treeNode596.Text = "Version 1.0.0.87";
            treeNode597.Name = "Node4";
            treeNode597.Text = "SetTurtleImage method added";
            treeNode598.Name = "Node3";
            treeNode598.Text = "LDShapes";
            treeNode599.Name = "Node1";
            treeNode599.Text = "Connect to IOWarrior USB devices";
            treeNode600.Name = "Node0";
            treeNode600.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode601.Name = "Node0";
            treeNode601.Text = "LDIOWarrior";
            treeNode602.Name = "Node2";
            treeNode602.Text = "Version 1.0.0.86";
            treeNode603.Name = "Node1";
            treeNode603.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode604.Name = "Node0";
            treeNode604.Text = "LDShapes";
            treeNode605.Name = "Node2";
            treeNode605.Text = "Version 1.0.0.85";
            treeNode606.Name = "Node4";
            treeNode606.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode607.Name = "Node3";
            treeNode607.Text = "LDFile";
            treeNode608.Name = "Node6";
            treeNode608.Text = "Crop method added";
            treeNode609.Name = "Node5";
            treeNode609.Text = "LDImage";
            treeNode610.Name = "Node1";
            treeNode610.Text = "LastDropFiles bug fixed";
            treeNode611.Name = "Node0";
            treeNode611.Text = "LDControls";
            treeNode612.Name = "Node2";
            treeNode612.Text = "Version 1.0.0.84";
            treeNode613.Name = "Node7";
            treeNode613.Text = "FileDropped event added";
            treeNode614.Name = "Node6";
            treeNode614.Text = "LDControls";
            treeNode615.Name = "Node1";
            treeNode615.Text = "Bug in Split corrected";
            treeNode616.Name = "Node0";
            treeNode616.Text = "LDText";
            treeNode617.Name = "Node5";
            treeNode617.Text = "Version 1.0.0.83";
            treeNode618.Name = "Node3";
            treeNode618.Text = "Title argument removed from AddComboBox";
            treeNode619.Name = "Node4";
            treeNode619.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode620.Name = "Node2";
            treeNode620.Text = "LDControls";
            treeNode621.Name = "Node1";
            treeNode621.Text = "Version 1.0.0.82";
            treeNode622.Name = "Node0";
            treeNode622.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode623.Name = "Node12";
            treeNode623.Text = "Program settings added";
            treeNode624.Name = "Node9";
            treeNode624.Text = "LDSettings";
            treeNode625.Name = "Node11";
            treeNode625.Text = "Get some system paths and user name";
            treeNode626.Name = "Node10";
            treeNode626.Text = "LDFile";
            treeNode627.Name = "Node14";
            treeNode627.Text = "System sounds added";
            treeNode628.Name = "Node13";
            treeNode628.Text = "LDSound";
            treeNode629.Name = "Node16";
            treeNode629.Text = "Binary, octal, hex and decimal conversions";
            treeNode630.Name = "Node15";
            treeNode630.Text = "LDMath";
            treeNode631.Name = "Node1";
            treeNode631.Text = "Replace method added";
            treeNode632.Name = "Node2";
            treeNode632.Text = "FindAll method added";
            treeNode633.Name = "Node0";
            treeNode633.Text = "LDText";
            treeNode634.Name = "Node8";
            treeNode634.Text = "Version 1.0.0.81";
            treeNode635.Name = "Node1";
            treeNode635.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode636.Name = "Node6";
            treeNode636.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode637.Name = "Node0";
            treeNode637.Text = "LDShapes";
            treeNode638.Name = "Node3";
            treeNode638.Text = "Truncate method added";
            treeNode639.Name = "Node2";
            treeNode639.Text = "LDMath";
            treeNode640.Name = "Node5";
            treeNode640.Text = "Additional text methods";
            treeNode641.Name = "Node4";
            treeNode641.Text = "LDText";
            treeNode642.Name = "Node0";
            treeNode642.Text = "Version 1.0.0.80";
            treeNode643.Name = "Node1";
            treeNode643.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode644.Name = "Node0";
            treeNode644.Text = "LDDialogs";
            treeNode645.Name = "Node1";
            treeNode645.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode646.Name = "Node0";
            treeNode646.Text = "LDUtilities";
            treeNode647.Name = "Node6";
            treeNode647.Text = "Version 1.0.0.79";
            treeNode648.Name = "Node2";
            treeNode648.Text = "Rasterize property added";
            treeNode649.Name = "Node5";
            treeNode649.Text = "Improvements associated with window resizing";
            treeNode650.Name = "Node1";
            treeNode650.Text = "LDScrollBars";
            treeNode651.Name = "Node4";
            treeNode651.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode652.Name = "Node3";
            treeNode652.Text = "LDUtilities";
            treeNode653.Name = "Node0";
            treeNode653.Text = "Version 1.0.0.78";
            treeNode654.Name = "Node1";
            treeNode654.Text = "Handle more than 100 drawables (rasterization)";
            treeNode655.Name = "Node0";
            treeNode655.Text = "LDScollBars";
            treeNode656.Name = "Node2";
            treeNode656.Text = "Version 1.0.0.77";
            treeNode657.Name = "Node1";
            treeNode657.Text = "Record sound from a microphone";
            treeNode658.Name = "Node0";
            treeNode658.Text = "LDSound";
            treeNode659.Name = "Node3";
            treeNode659.Text = "AnimateOpacity method added (flashing)";
            treeNode660.Name = "Node0";
            treeNode660.Text = "AnimateRotation method added (continuous rotation)";
            treeNode661.Name = "Node1";
            treeNode661.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode662.Name = "Node2";
            treeNode662.Text = "LDShapes";
            treeNode663.Name = "Node2";
            treeNode663.Text = "Version 1.0.0.76";
            treeNode664.Name = "Node1";
            treeNode664.Text = "AddAnimatedImage can use an ImageList image";
            treeNode665.Name = "Node0";
            treeNode665.Text = "LDShapes";
            treeNode666.Name = "Node0";
            treeNode666.Text = "Version 1.0.0.75";
            treeNode667.Name = "Node1";
            treeNode667.Text = "Initial graph axes scaling improvement";
            treeNode668.Name = "Node0";
            treeNode668.Text = "LDGraph";
            treeNode669.Name = "Node3";
            treeNode669.Text = "Methods to access a bluetooth device";
            treeNode670.Name = "Node0";
            treeNode670.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode671.Name = "Node2";
            treeNode671.Text = "LDBlueTooth";
            treeNode672.Name = "Node1";
            treeNode672.Text = "getFocus handles multiple LDWindows";
            treeNode673.Name = "Node0";
            treeNode673.Text = "LDFocus";
            treeNode674.Name = "Node0";
            treeNode674.Text = "Version 1.0.0.74";
            treeNode675.Name = "Node1";
            treeNode675.Text = "First pass at a generic USB (HID) device controller";
            treeNode676.Name = "Node0";
            treeNode676.Text = "LDHID";
            treeNode677.Name = "Node9";
            treeNode677.Text = "Version 1.0.0.73";
            treeNode678.Name = "Node8";
            treeNode678.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode679.Name = "Node7";
            treeNode679.Text = "LDGraph";
            treeNode680.Name = "Node6";
            treeNode680.Text = "Version 1.0.0.72";
            treeNode681.Name = "Node4";
            treeNode681.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode682.Name = "Node5";
            treeNode682.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode683.Name = "Node3";
            treeNode683.Text = "LDGraph";
            treeNode684.Name = "Node2";
            treeNode684.Text = "Version 1.0.0.71";
            treeNode685.Name = "Node1";
            treeNode685.Text = "Spurious error message fixed";
            treeNode686.Name = "Node2";
            treeNode686.Text = "CreateTrend data series creation method added";
            treeNode687.Name = "Node0";
            treeNode687.Text = "LDGraph";
            treeNode688.Name = "Node2";
            treeNode688.Text = "Version 1.0.0.70";
            treeNode689.Name = "Node1";
            treeNode689.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode690.Name = "Node0";
            treeNode690.Text = "LDControls";
            treeNode691.Name = "Node3";
            treeNode691.Text = "Version 1.0.0.69";
            treeNode692.Name = "Node2";
            treeNode692.Text = "Radio button control added";
            treeNode693.Name = "Node1";
            treeNode693.Text = "LDControls";
            treeNode694.Name = "Node0";
            treeNode694.Text = "Version 1.0.0.68";
            treeNode695.Name = "Node1";
            treeNode695.Text = "Bug fix for Copy";
            treeNode696.Name = "Node0";
            treeNode696.Text = "LDArray";
            treeNode697.Name = "Node2";
            treeNode697.Text = "Version 1.0.0.67";
            treeNode698.Name = "Node1";
            treeNode698.Text = "RegexMatch and RegexReplace methods added";
            treeNode699.Name = "Node0";
            treeNode699.Text = "LDUtilities";
            treeNode700.Name = "Node3";
            treeNode700.Text = "Version 1.0.0.66";
            treeNode701.Name = "Node2";
            treeNode701.Text = "Number culture conversions added";
            treeNode702.Name = "Node1";
            treeNode702.Text = "LDUtilities";
            treeNode703.Name = "Node0";
            treeNode703.Text = "Version 1.0.0.65";
            treeNode704.Name = "Node1";
            treeNode704.Text = "IsNumber method added";
            treeNode705.Name = "Node0";
            treeNode705.Text = "LDUtilities";
            treeNode706.Name = "Node2";
            treeNode706.Text = "Version 1.0.0.64";
            treeNode707.Name = "Node1";
            treeNode707.Text = "SetCursorPosition method added for textboxes";
            treeNode708.Name = "Node0";
            treeNode708.Text = "LDControls";
            treeNode709.Name = "Node4";
            treeNode709.Text = "Version 1.0.0.63";
            treeNode710.Name = "Node1";
            treeNode710.Text = "SetCursorToEnd method added for textboxes";
            treeNode711.Name = "Node3";
            treeNode711.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode712.Name = "Node0";
            treeNode712.Text = "LDControls";
            treeNode713.Name = "Node2";
            treeNode713.Text = "Version 1.0.0.62";
            treeNode714.Name = "Node1";
            treeNode714.Text = "Adding polygons not located at (0,0) corrected";
            treeNode715.Name = "Node0";
            treeNode715.Text = "LDPhysics";
            treeNode716.Name = "Node2";
            treeNode716.Text = "Version 1.0.0.61";
            treeNode717.Name = "Node1";
            treeNode717.Text = "GetFolder dialog added";
            treeNode718.Name = "Node0";
            treeNode718.Text = "LDDialogs";
            treeNode719.Name = "Node0";
            treeNode719.Text = "Version 1.0.0.60";
            treeNode720.Name = "Node10";
            treeNode720.Text = "Possible localization issue with Font size fixed";
            treeNode721.Name = "Node9";
            treeNode721.Text = "LDDialogs";
            treeNode722.Name = "Node8";
            treeNode722.Text = "Version 1.0.0.59";
            treeNode723.Name = "Node3";
            treeNode723.Text = "More internationalization fixes";
            treeNode724.Name = "Node2";
            treeNode724.Text = "ShowPrintPreview property added";
            treeNode725.Name = "Node1";
            treeNode725.Text = "LDUtilities";
            treeNode726.Name = "Node5";
            treeNode726.Text = "Possible error with gradient drawings fixed";
            treeNode727.Name = "Node4";
            treeNode727.Text = "LDShapes";
            treeNode728.Name = "Node7";
            treeNode728.Text = "Possible Listen event initialisation error fixed";
            treeNode729.Name = "Node6";
            treeNode729.Text = "LDSpeech";
            treeNode730.Name = "Node0";
            treeNode730.Text = "Version 1.0.0.58";
            treeNode731.Name = "Node7";
            treeNode731.Text = "Many possible internationisation issues fixed";
            treeNode732.Name = "Node4";
            treeNode732.Text = "Version 1.0.0.57";
            treeNode733.Name = "Node1";
            treeNode733.Text = "Emmisive colour correction for AddGeometry";
            treeNode734.Name = "Node2";
            treeNode734.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode735.Name = "Node0";
            treeNode735.Text = "LD3DView";
            treeNode736.Name = "Node1";
            treeNode736.Text = "CSVdeminiator property added";
            treeNode737.Name = "Node0";
            treeNode737.Text = "LDUtilities";
            treeNode738.Name = "Node5";
            treeNode738.Text = "Version 1.0.0.56";
            treeNode739.Name = "Node1";
            treeNode739.Text = "Improved error reporting";
            treeNode740.Name = "Node2";
            treeNode740.Text = "Culture invariant type conversions";
            treeNode741.Name = "Node1";
            treeNode741.Text = "LD3DView";
            treeNode742.Name = "Node4";
            treeNode742.Text = "ShowErrors method added";
            treeNode743.Name = "Node3";
            treeNode743.Text = "LDUtilities";
            treeNode744.Name = "Node0";
            treeNode744.Text = "Version 1.0.0.55";
            treeNode745.Name = "Node4";
            treeNode745.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode746.Name = "Node3";
            treeNode746.Text = "LDScrollBars";
            treeNode747.Name = "Node6";
            treeNode747.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode748.Name = "Node5";
            treeNode748.Text = "LDUtilities";
            treeNode749.Name = "Node2";
            treeNode749.Text = "Version 1.0.0.54";
            treeNode750.Name = "Node1";
            treeNode750.Text = "Debug window can be resized";
            treeNode751.Name = "Node0";
            treeNode751.Text = "LDDebug";
            treeNode752.Name = "Node1";
            treeNode752.Text = "PrintFile method added";
            treeNode753.Name = "Node0";
            treeNode753.Text = "LDFile";
            treeNode754.Name = "Node2";
            treeNode754.Text = "Version 1.0.0.53";
            treeNode755.Name = "Node1";
            treeNode755.Text = "SSL property option added";
            treeNode756.Name = "Node0";
            treeNode756.Text = "LDEmail";
            treeNode757.Name = "Node0";
            treeNode757.Text = "Version 1.0.0.52";
            treeNode758.Name = "Node1";
            treeNode758.Text = "Right Click Context menu added for any shape or control";
            treeNode759.Name = "Node0";
            treeNode759.Text = "LDControls";
            treeNode760.Name = "Node0";
            treeNode760.Text = "Version 1.0.0.51";
            treeNode761.Name = "Node1";
            treeNode761.Text = "Right click dropdown menu option added";
            treeNode762.Name = "Node0";
            treeNode762.Text = "LDDialogs";
            treeNode763.Name = "Node0";
            treeNode763.Text = "Version 1.0.0.50";
            treeNode764.Name = "Node1";
            treeNode764.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode765.Name = "Node0";
            treeNode765.Text = "LD3DView";
            treeNode766.Name = "Node0";
            treeNode766.Text = "Version 1.0.0.49";
            treeNode767.Name = "Node1";
            treeNode767.Text = "Performance improvements (some camera controls for this)";
            treeNode768.Name = "Node1";
            treeNode768.Text = "LoadModel (*.3ds) files added";
            treeNode769.Name = "Node0";
            treeNode769.Text = "LD3DView";
            treeNode770.Name = "Node3";
            treeNode770.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode771.Name = "Node2";
            treeNode771.Text = "LDShapes";
            treeNode772.Name = "Node0";
            treeNode772.Text = "Version 1.0.0.48";
            treeNode773.Name = "Node1";
            treeNode773.Text = "Some improvements including animations";
            treeNode774.Name = "Node0";
            treeNode774.Text = "LD3DView";
            treeNode775.Name = "Node0";
            treeNode775.Text = "Version 1.0.0.47";
            treeNode776.Name = "Node1";
            treeNode776.Text = "Some improvemts and new methods";
            treeNode777.Name = "Node0";
            treeNode777.Text = "LD3Dview";
            treeNode778.Name = "Node2";
            treeNode778.Text = "Version 1.0.0.46";
            treeNode779.Name = "Node1";
            treeNode779.Text = "A start at a 3D set of methods";
            treeNode780.Name = "Node0";
            treeNode780.Text = "LD3DView";
            treeNode781.Name = "Node10";
            treeNode781.Text = "Version 1.0.0.45";
            treeNode782.Name = "Node1";
            treeNode782.Text = "Create scrollbars for the GraphicsWindow";
            treeNode783.Name = "Node5";
            treeNode783.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode784.Name = "Node0";
            treeNode784.Text = "LDScrollBars";
            treeNode785.Name = "Node4";
            treeNode785.Text = "ColourList method added";
            treeNode786.Name = "Node3";
            treeNode786.Text = "LDUtilities";
            treeNode787.Name = "Node8";
            treeNode787.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode788.Name = "Node9";
            treeNode788.Text = "BackgroundImage method to set the background added";
            treeNode789.Name = "Node6";
            treeNode789.Text = "LDShapes";
            treeNode790.Name = "Node0";
            treeNode790.Text = "Version 1.0.0.44";
            treeNode791.Name = "Node1";
            treeNode791.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode792.Name = "Node0";
            treeNode792.Text = "LDUtilities";
            treeNode793.Name = "Node0";
            treeNode793.Text = "Version 1.0.0.43";
            treeNode794.Name = "Node1";
            treeNode794.Text = "Call Subs as functions with arguments";
            treeNode795.Name = "Node0";
            treeNode795.Text = "LDCall";
            treeNode796.Name = "Node0";
            treeNode796.Text = "Version 1.0.0.42";
            treeNode797.Name = "Node1";
            treeNode797.Text = "Font dialog added";
            treeNode798.Name = "Node2";
            treeNode798.Text = "Colours dialog moved here from LDColours";
            treeNode799.Name = "Node0";
            treeNode799.Text = "LDDialogs";
            treeNode800.Name = "Node9";
            treeNode800.Text = "Version 1.0.0.41";
            treeNode801.Name = "Node1";
            treeNode801.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode802.Name = "Node7";
            treeNode802.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode803.Name = "Node8";
            treeNode803.Text = "Some methods renamed";
            treeNode804.Name = "Node0";
            treeNode804.Text = "LDControls";
            treeNode805.Name = "Node3";
            treeNode805.Text = "HighScore method move here";
            treeNode806.Name = "Node2";
            treeNode806.Text = "LDNetwork";
            treeNode807.Name = "Node6";
            treeNode807.Text = "SetSize method added";
            treeNode808.Name = "Node5";
            treeNode808.Text = "LDShapes";
            treeNode809.Name = "Node3";
            treeNode809.Text = "Version 1.0.0.40";
            treeNode810.Name = "Node1";
            treeNode810.Text = "SelectTreeView method added";
            treeNode811.Name = "Node2";
            treeNode811.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode812.Name = "Node0";
            treeNode812.Text = "LDDialogs";
            treeNode813.Name = "Node1";
            treeNode813.Text = "Simple high score web method";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDHighScore";
            treeNode815.Name = "Node3";
            treeNode815.Text = "Version 1.0.0.39";
            treeNode816.Name = "Node2";
            treeNode816.Text = "RichTextBox methods improved";
            treeNode817.Name = "Node1";
            treeNode817.Text = "LDDialogs";
            treeNode818.Name = "Node1";
            treeNode818.Text = "Search, Load and Save methods added";
            treeNode819.Name = "Node0";
            treeNode819.Text = "LDArray";
            treeNode820.Name = "Node0";
            treeNode820.Text = "Version 1.0.0.38";
            treeNode821.Name = "Node1";
            treeNode821.Text = "Depreciated";
            treeNode822.Name = "Node0";
            treeNode822.Text = "LDWeather";
            treeNode823.Name = "Node1";
            treeNode823.Text = "Renamed from LDTrig and some more methods added";
            treeNode824.Name = "Node0";
            treeNode824.Text = "LDMath";
            treeNode825.Name = "Node3";
            treeNode825.Text = "RichTextBox method added";
            treeNode826.Name = "Node2";
            treeNode826.Text = "LDDialogs";
            treeNode827.Name = "Node5";
            treeNode827.Text = "FontList method added";
            treeNode828.Name = "Node4";
            treeNode828.Text = "LDUtilities";
            treeNode829.Name = "Node2";
            treeNode829.Text = "Version 1.0.0.37";
            treeNode830.Name = "Node1";
            treeNode830.Text = "Zip method extended";
            treeNode831.Name = "Node0";
            treeNode831.Text = "LDUtilities";
            treeNode832.Name = "Node2";
            treeNode832.Text = "Version 1.0.0.36";
            treeNode833.Name = "Node1";
            treeNode833.Text = "Collapse and expand treeview nodes method added";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDDialogs";
            treeNode835.Name = "Node5";
            treeNode835.Text = "Version 1.0.0.35";
            treeNode836.Name = "Node1";
            treeNode836.Text = "Arguments added to Start method";
            treeNode837.Name = "Node0";
            treeNode837.Text = "LDProcess";
            treeNode838.Name = "Node4";
            treeNode838.Text = "Zip compression methods added";
            treeNode839.Name = "Node2";
            treeNode839.Text = "LDUtilities";
            treeNode840.Name = "Node2";
            treeNode840.Text = "Version 1.0.0.34";
            treeNode841.Name = "Node1";
            treeNode841.Text = "GWStyle property added";
            treeNode842.Name = "Node0";
            treeNode842.Text = "LDUtilities";
            treeNode843.Name = "Node1";
            treeNode843.Text = "TreeView and associated events added";
            treeNode844.Name = "Node0";
            treeNode844.Text = "LDDialogs";
            treeNode845.Name = "Node0";
            treeNode845.Text = "Version 1.0.0.33";
            treeNode846.Name = "Node1";
            treeNode846.Text = "Possible end points not plotting bug fixed";
            treeNode847.Name = "Node0";
            treeNode847.Text = "LDGraph";
            treeNode848.Name = "Node2";
            treeNode848.Text = "Version 1.0.0.32";
            treeNode849.Name = "Node1";
            treeNode849.Text = "Activated event and Active property addded";
            treeNode850.Name = "Node0";
            treeNode850.Text = "LDWindows";
            treeNode851.Name = "Node0";
            treeNode851.Text = "Version 1.0.0.31";
            treeNode852.Name = "Node1";
            treeNode852.Text = "Create multiple GraphicsWindows";
            treeNode853.Name = "Node0";
            treeNode853.Text = "LDWindows";
            treeNode854.Name = "Node0";
            treeNode854.Text = "Version 1.0.0.30";
            treeNode855.Name = "Node1";
            treeNode855.Text = "Email sending method";
            treeNode856.Name = "Node0";
            treeNode856.Text = "LDMail";
            treeNode857.Name = "Node1";
            treeNode857.Text = "Add and Multiply methods bug fixed";
            treeNode858.Name = "Node2";
            treeNode858.Text = "Image statistics combined into one method";
            treeNode859.Name = "Node3";
            treeNode859.Text = "Histogram method added";
            treeNode860.Name = "Node0";
            treeNode860.Text = "LDImage";
            treeNode861.Name = "Node0";
            treeNode861.Text = "Version 1.0.0.29";
            treeNode862.Name = "Node1";
            treeNode862.Text = "SnapshotToImageList method added";
            treeNode863.Name = "Node0";
            treeNode863.Text = "LDWebCam";
            treeNode864.Name = "Node3";
            treeNode864.Text = "ImageList image manipulation methods";
            treeNode865.Name = "Node2";
            treeNode865.Text = "LDImage";
            treeNode866.Name = "Node0";
            treeNode866.Text = "Version 1.0.0.28";
            treeNode867.Name = "Node1";
            treeNode867.Text = "SortIndex bugfix for null values";
            treeNode868.Name = "Node0";
            treeNode868.Text = "LDArray";
            treeNode869.Name = "Node1";
            treeNode869.Text = "SnapshotToFile bug fixed";
            treeNode870.Name = "Node0";
            treeNode870.Text = "LDWebCam";
            treeNode871.Name = "Node0";
            treeNode871.Text = "Version 1.0.0.27";
            treeNode872.Name = "Node1";
            treeNode872.Text = "SortIndex method added";
            treeNode873.Name = "Node0";
            treeNode873.Text = "LDArray";
            treeNode874.Name = "Node1";
            treeNode874.Text = "Web based weather report data added";
            treeNode875.Name = "Node0";
            treeNode875.Text = "LDWeather";
            treeNode876.Name = "Node3";
            treeNode876.Text = "DataReceived event added";
            treeNode877.Name = "Node2";
            treeNode877.Text = "LDCommPort";
            treeNode878.Name = "Node0";
            treeNode878.Text = "Version 1.0.0.26";
            treeNode879.Name = "Node1";
            treeNode879.Text = "Speech recognition added";
            treeNode880.Name = "Node0";
            treeNode880.Text = "LDSpeech";
            treeNode881.Name = "Node0";
            treeNode881.Text = "Version 1.0.0.25";
            treeNode882.Name = "Node4";
            treeNode882.Text = "More methods added and some internal code optimised";
            treeNode883.Name = "Node0";
            treeNode883.Text = "LDArray & LDMatrix";
            treeNode884.Name = "Node1";
            treeNode884.Text = "KeyDown method added";
            treeNode885.Name = "Node0";
            treeNode885.Text = "LDUtilities";
            treeNode886.Name = "Node1";
            treeNode886.Text = "GetAllShapesAt method added";
            treeNode887.Name = "Node0";
            treeNode887.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode888.Name = "Node0";
            treeNode888.Text = "LDShapes";
            treeNode889.Name = "Node0";
            treeNode889.Text = "Version 1.0.0.24";
            treeNode890.Name = "Node1";
            treeNode890.Text = "OpenFile and SaveFile dialogs added";
            treeNode891.Name = "Node0";
            treeNode891.Text = "LDDialogs";
            treeNode892.Name = "Node2";
            treeNode892.Text = "Matrix methods, for example to solve linear equations";
            treeNode893.Name = "Node1";
            treeNode893.Text = "LDMatrix";
            treeNode894.Name = "Node0";
            treeNode894.Text = "Version 1.0.0.23";
            treeNode895.Name = "Node1";
            treeNode895.Text = "Sorting method added";
            treeNode896.Name = "Node0";
            treeNode896.Text = "LDArray";
            treeNode897.Name = "Node0";
            treeNode897.Text = "Version 1.0.0.22";
            treeNode898.Name = "Node2";
            treeNode898.Text = "Velocity Threshold setting added";
            treeNode899.Name = "Node1";
            treeNode899.Text = "LDPhysics";
            treeNode900.Name = "Node0";
            treeNode900.Text = "Version 1.0.0.21";
            treeNode901.Name = "Node3";
            treeNode901.Text = "SetDamping method added";
            treeNode902.Name = "Node2";
            treeNode902.Text = "LDPhysics";
            treeNode903.Name = "Node1";
            treeNode903.Text = "Version 1.0.0.20";
            treeNode904.Name = "Node1";
            treeNode904.Text = "Instrument name can be obtained from its number";
            treeNode905.Name = "Node0";
            treeNode905.Text = "LDMusic";
            treeNode906.Name = "Node0";
            treeNode906.Text = "Version 1.0.0.19";
            treeNode907.Name = "Node1";
            treeNode907.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode908.Name = "Node0";
            treeNode908.Text = "LDDialogs";
            treeNode909.Name = "Node1";
            treeNode909.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode910.Name = "Node2";
            treeNode910.Text = "Notes can also be played synchronously (chords)";
            treeNode911.Name = "Node0";
            treeNode911.Text = "LDMusic";
            treeNode912.Name = "Node0";
            treeNode912.Text = "Version 1.0.0.18";
            treeNode913.Name = "Node1";
            treeNode913.Text = "AnimationPause and AnimationResume methods added";
            treeNode914.Name = "Node0";
            treeNode914.Text = "LDShapes";
            treeNode915.Name = "Node1";
            treeNode915.Text = "Process list indexed by ID rather than name";
            treeNode916.Name = "Node0";
            treeNode916.Text = "LDProcess";
            treeNode917.Name = "Node1";
            treeNode917.Text = "Version 1.0.0.17";
            treeNode918.Name = "Node1";
            treeNode918.Text = "More effects added";
            treeNode919.Name = "Node0";
            treeNode919.Text = "LDWebCam";
            treeNode920.Name = "Node1";
            treeNode920.Text = "Add or change an image on a button or image shape";
            treeNode921.Name = "Node1";
            treeNode921.Text = "Add an animated gif or tiled image";
            treeNode922.Name = "Node0";
            treeNode922.Text = "LDShapes";
            treeNode923.Name = "Node0";
            treeNode923.Text = "Version 1.0.0.16";
            treeNode924.Name = "Node1";
            treeNode924.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode925.Name = "Node0";
            treeNode925.Text = "LDWebCam";
            treeNode926.Name = "Node0";
            treeNode926.Text = "Version 1.0.0.15";
            treeNode927.Name = "Node2";
            treeNode927.Text = "Variables may be changed during a debug session";
            treeNode928.Name = "Node1";
            treeNode928.Text = "LDDebug";
            treeNode929.Name = "Node0";
            treeNode929.Text = "Version 1.0.0.14";
            treeNode930.Name = "Node1";
            treeNode930.Text = "A basic debugging tool";
            treeNode931.Name = "Node0";
            treeNode931.Text = "LDDebug";
            treeNode932.Name = "Node0";
            treeNode932.Text = "Version 1.0.0.13";
            treeNode933.Name = "Node2";
            treeNode933.Text = "Methods to convert between HSL and RGB";
            treeNode934.Name = "Node18";
            treeNode934.Text = "Method to set colour opacity";
            treeNode935.Name = "Node19";
            treeNode935.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode936.Name = "Node1";
            treeNode936.Text = "LDColours";
            treeNode937.Name = "Node4";
            treeNode937.Text = "Methods to add and subtract dates and times";
            treeNode938.Name = "Node3";
            treeNode938.Text = "LDDateTime";
            treeNode939.Name = "Node6";
            treeNode939.Text = "Waiting overlay, Calendar and About popups";
            treeNode940.Name = "Node17";
            treeNode940.Text = "Tooltips";
            treeNode941.Name = "Node5";
            treeNode941.Text = "LDDialogs";
            treeNode942.Name = "Node8";
            treeNode942.Text = "File change event";
            treeNode943.Name = "Node7";
            treeNode943.Text = "LDEvents";
            treeNode944.Name = "Node0";
            treeNode944.Text = "Version 1.0.0.12";
            treeNode945.Name = "Node12";
            treeNode945.Text = "Methods to sort arrays by index or value";
            treeNode946.Name = "Node22";
            treeNode946.Text = "Sorting by number and character strings";
            treeNode947.Name = "Node11";
            treeNode947.Text = "LDSort";
            treeNode948.Name = "Node14";
            treeNode948.Text = "Statistics on any array and distribution generation";
            treeNode949.Name = "Node20";
            treeNode949.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode950.Name = "Node21";
            treeNode950.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode951.Name = "Node13";
            treeNode951.Text = "LDStatistics";
            treeNode952.Name = "Node16";
            treeNode952.Text = "Voice and volume added";
            treeNode953.Name = "Node15";
            treeNode953.Text = "LDSpeech";
            treeNode954.Name = "Node9";
            treeNode954.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode21,
            treeNode49,
            treeNode63,
            treeNode74,
            treeNode89,
            treeNode104,
            treeNode117,
            treeNode126,
            treeNode141,
            treeNode152,
            treeNode166,
            treeNode175,
            treeNode187,
            treeNode198,
            treeNode201,
            treeNode210,
            treeNode217,
            treeNode224,
            treeNode237,
            treeNode248,
            treeNode253,
            treeNode260,
            treeNode263,
            treeNode277,
            treeNode285,
            treeNode291,
            treeNode306,
            treeNode321,
            treeNode327,
            treeNode335,
            treeNode350,
            treeNode367,
            treeNode370,
            treeNode376,
            treeNode382,
            treeNode392,
            treeNode401,
            treeNode404,
            treeNode424,
            treeNode430,
            treeNode433,
            treeNode442,
            treeNode450,
            treeNode456,
            treeNode461,
            treeNode467,
            treeNode470,
            treeNode483,
            treeNode486,
            treeNode491,
            treeNode496,
            treeNode499,
            treeNode505,
            treeNode509,
            treeNode512,
            treeNode518,
            treeNode522,
            treeNode530,
            treeNode536,
            treeNode542,
            treeNode545,
            treeNode552,
            treeNode559,
            treeNode567,
            treeNode570,
            treeNode573,
            treeNode579,
            treeNode584,
            treeNode591,
            treeNode596,
            treeNode602,
            treeNode605,
            treeNode612,
            treeNode617,
            treeNode621,
            treeNode634,
            treeNode642,
            treeNode647,
            treeNode653,
            treeNode656,
            treeNode663,
            treeNode666,
            treeNode674,
            treeNode677,
            treeNode680,
            treeNode684,
            treeNode688,
            treeNode691,
            treeNode694,
            treeNode697,
            treeNode700,
            treeNode703,
            treeNode706,
            treeNode709,
            treeNode713,
            treeNode716,
            treeNode719,
            treeNode722,
            treeNode730,
            treeNode732,
            treeNode738,
            treeNode744,
            treeNode749,
            treeNode754,
            treeNode757,
            treeNode760,
            treeNode763,
            treeNode766,
            treeNode772,
            treeNode775,
            treeNode778,
            treeNode781,
            treeNode790,
            treeNode793,
            treeNode796,
            treeNode800,
            treeNode809,
            treeNode815,
            treeNode820,
            treeNode829,
            treeNode832,
            treeNode835,
            treeNode840,
            treeNode845,
            treeNode848,
            treeNode851,
            treeNode854,
            treeNode861,
            treeNode866,
            treeNode871,
            treeNode878,
            treeNode881,
            treeNode889,
            treeNode894,
            treeNode897,
            treeNode900,
            treeNode903,
            treeNode906,
            treeNode912,
            treeNode917,
            treeNode923,
            treeNode926,
            treeNode929,
            treeNode932,
            treeNode944,
            treeNode954});
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