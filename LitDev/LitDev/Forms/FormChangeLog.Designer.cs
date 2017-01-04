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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode17,
            treeNode20,
            treeNode24,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode31,
            treeNode37,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode45,
            treeNode47,
            treeNode49,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode57,
            treeNode61,
            treeNode63,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode76,
            treeNode78,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode89,
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode86,
            treeNode88,
            treeNode91,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode99,
            treeNode101,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode107,
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode112,
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode109,
            treeNode111,
            treeNode114,
            treeNode116,
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode127,
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode124,
            treeNode126,
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode131,
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode133,
            treeNode135,
            treeNode137,
            treeNode139,
            treeNode141,
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode145,
            treeNode146,
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode148,
            treeNode150,
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode158,
            treeNode159,
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode162,
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode155,
            treeNode157,
            treeNode161,
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode167,
            treeNode169,
            treeNode171,
            treeNode173,
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode180});
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode181,
            treeNode183,
            treeNode185,
            treeNode187});
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode190,
            treeNode192,
            treeNode194});
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode197,
            treeNode199,
            treeNode201});
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode203,
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode206,
            treeNode207,
            treeNode208,
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode211});
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode205,
            treeNode210,
            treeNode212,
            treeNode214});
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode217,
            treeNode219,
            treeNode221,
            treeNode223,
            treeNode225});
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode227});
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode229});
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode228,
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode232});
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode234});
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode233,
            treeNode235,
            treeNode237});
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode240});
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode242,
            treeNode243,
            treeNode244,
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode247,
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode253});
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode249,
            treeNode252,
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode256,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode261});
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode258,
            treeNode260,
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode264,
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode267});
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode266,
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode270,
            treeNode271,
            treeNode272,
            treeNode273,
            treeNode274});
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode276,
            treeNode277,
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode280});
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode282});
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode275,
            treeNode279,
            treeNode281,
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode286,
            treeNode288,
            treeNode290,
            treeNode292,
            treeNode294,
            treeNode296,
            treeNode298});
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode300,
            treeNode301});
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode303});
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode302,
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode308,
            treeNode309,
            treeNode310,
            treeNode311});
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode307,
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode316,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode322});
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode315,
            treeNode318,
            treeNode321,
            treeNode323,
            treeNode325,
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode329,
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode336,
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode341});
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode331,
            treeNode333,
            treeNode335,
            treeNode338,
            treeNode340,
            treeNode342,
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode347});
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode349,
            treeNode350});
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode353});
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode355,
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode358});
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode357,
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode361,
            treeNode362,
            treeNode363,
            treeNode364});
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode365,
            treeNode367,
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode372,
            treeNode374,
            treeNode376,
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode383,
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode386,
            treeNode387});
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode389});
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode391,
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode385,
            treeNode388,
            treeNode390,
            treeNode393,
            treeNode395,
            treeNode397,
            treeNode399,
            treeNode401});
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode403,
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode405,
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode410});
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode416,
            treeNode417,
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode413,
            treeNode415,
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode423,
            treeNode424});
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode422,
            treeNode425,
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode429});
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode431,
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode430,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode435});
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode437});
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode436,
            treeNode438});
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode442,
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode441,
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode449,
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode452});
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode458,
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode451,
            treeNode453,
            treeNode455,
            treeNode457,
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode463});
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode466,
            treeNode468});
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode470});
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode471,
            treeNode473});
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode475});
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode478,
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode480,
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode484,
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode491,
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode493,
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode497,
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode501});
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode505,
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode502,
            treeNode504,
            treeNode507});
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode511,
            treeNode512});
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode510,
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode515,
            treeNode516,
            treeNode517,
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode522});
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode524});
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode525,
            treeNode527,
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode531});
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode532,
            treeNode534,
            treeNode536});
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode542,
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode539,
            treeNode541,
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode547});
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode549});
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode552});
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode554,
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode553,
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode558,
            treeNode559,
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode563});
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode565});
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode564,
            treeNode566,
            treeNode568});
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode570});
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode571,
            treeNode573});
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode575});
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode577,
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode576,
            treeNode579});
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode584});
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode586});
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode585,
            treeNode587,
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode592,
            treeNode594});
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode596,
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode605});
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode609,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode600,
            treeNode602,
            treeNode604,
            treeNode606,
            treeNode608,
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode613,
            treeNode614});
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode615,
            treeNode617,
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode622,
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode626,
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode628,
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode637,
            treeNode638,
            treeNode639});
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode636,
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode642});
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode647,
            treeNode648});
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode646,
            treeNode649,
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode656});
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode659,
            treeNode660});
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode663,
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode688,
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode701,
            treeNode703,
            treeNode705,
            treeNode707});
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode711,
            treeNode712});
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode713,
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode717,
            treeNode719,
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode723});
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode724,
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode729,
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode733});
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode745,
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode748});
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode747,
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode751});
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode754});
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode760,
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode765,
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode762,
            treeNode764,
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode772});
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode775,
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode777});
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode779,
            treeNode780,
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode782,
            treeNode784,
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode788,
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode790,
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode795,
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode800,
            treeNode802,
            treeNode804,
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode812});
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode815,
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode820,
            treeNode822});
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode835,
            treeNode836,
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode834,
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode840});
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode841,
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode846,
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode851,
            treeNode853,
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode857});
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode864,
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode861,
            treeNode863,
            treeNode866});
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode869,
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode885});
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode887,
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode886,
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode891});
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode892,
            treeNode894});
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode898,
            treeNode899});
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode897,
            treeNode900});
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode902});
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode906});
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode908});
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode909});
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode911,
            treeNode912,
            treeNode913});
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode915});
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode917,
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode920});
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode914,
            treeNode916,
            treeNode919,
            treeNode921});
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode923,
            treeNode924});
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode926,
            treeNode927,
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode930});
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode925,
            treeNode929,
            treeNode931});
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
            treeNode1.Text = "Possible unclosed zip conflicts fixed";
            treeNode2.Name = "Node1";
            treeNode2.Text = "LDZip";
            treeNode3.Name = "Node5";
            treeNode3.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode4.Name = "Node3";
            treeNode4.Text = "LDStopwatch";
            treeNode5.Name = "Node7";
            treeNode5.Text = "LDTimer object added for additional timers";
            treeNode6.Name = "Node6";
            treeNode6.Text = "LDTimer";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Speedup of selected critical performance code listed below";
            treeNode8.Name = "Node2";
            treeNode8.Text = "1) LDShapes.FastMove";
            treeNode9.Name = "Node3";
            treeNode9.Text = "2) LDPhysics graphical updates";
            treeNode10.Name = "Node4";
            treeNode10.Text = "3) LDImage and LDwebCam image processing";
            treeNode11.Name = "Node6";
            treeNode11.Text = "4) LDFastShapes";
            treeNode12.Name = "Node7";
            treeNode12.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode13.Name = "Node8";
            treeNode13.Text = "6) Selected LD3DView visual updates";
            treeNode14.Name = "Node9";
            treeNode14.Text = "7) LDEffect";
            treeNode15.Name = "Node10";
            treeNode15.Text = "8) LDGraph";
            treeNode16.Name = "Node11";
            treeNode16.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode17.Name = "Node0";
            treeNode17.Text = "General";
            treeNode18.Name = "Node1";
            treeNode18.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode19.Name = "Node2";
            treeNode19.Text = "CSV file read and write";
            treeNode20.Name = "Node0";
            treeNode20.Text = "LDFastArray";
            treeNode21.Name = "Node1";
            treeNode21.Text = "DataViewColAlignment method added";
            treeNode22.Name = "Node2";
            treeNode22.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode23.Name = "Node0";
            treeNode23.Text = "RichTextBoxTextTyped event added";
            treeNode24.Name = "Node0";
            treeNode24.Text = "LDControls";
            treeNode25.Name = "Node4";
            treeNode25.Text = "OverlapDetail property added";
            treeNode26.Name = "Node3";
            treeNode26.Text = "LDShapes";
            treeNode27.Name = "Node0";
            treeNode27.Text = "Version 1.2.14.0";
            treeNode28.Name = "Node2";
            treeNode28.Text = "TEMP tables allowed for SQLite databases";
            treeNode29.Name = "Node1";
            treeNode29.Text = "LDDataBase";
            treeNode30.Name = "Node1";
            treeNode30.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode31.Name = "Node0";
            treeNode31.Text = "LDMath";
            treeNode32.Name = "Node1";
            treeNode32.Text = "NormalMap method added for normal map 3D effects";
            treeNode33.Name = "Node2";
            treeNode33.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode34.Name = "Node5";
            treeNode34.Text = "MakeTransparent method added";
            treeNode35.Name = "Node6";
            treeNode35.Text = "ReplaceColour method added";
            treeNode36.Name = "Node0";
            treeNode36.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode37.Name = "Node0";
            treeNode37.Text = "LDImage";
            treeNode38.Name = "Node4";
            treeNode38.Text = "All image pixel manipulations speeded up";
            treeNode39.Name = "Node7";
            treeNode39.Text = "More Culture Invariace fixes";
            treeNode40.Name = "Node3";
            treeNode40.Text = "General";
            treeNode41.Name = "Node0";
            treeNode41.Text = "Version 1.2.13.0";
            treeNode42.Name = "Node1";
            treeNode42.Text = "Base conversions extended to include bases up to 36";
            treeNode43.Name = "Node0";
            treeNode43.Text = "LDMath";
            treeNode44.Name = "Node3";
            treeNode44.Text = "Updated to new Bing API";
            treeNode45.Name = "Node2";
            treeNode45.Text = "LDSearch";
            treeNode46.Name = "Node1";
            treeNode46.Text = "ShowInTaskbar property added";
            treeNode47.Name = "Node0";
            treeNode47.Text = "LDGraphicsWindow";
            treeNode48.Name = "Node1";
            treeNode48.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode49.Name = "Node0";
            treeNode49.Text = "LDFile";
            treeNode50.Name = "Node1";
            treeNode50.Text = "ToArray and FromArray methods added";
            treeNode51.Name = "Node0";
            treeNode51.Text = "LDxml";
            treeNode52.Name = "Node0";
            treeNode52.Text = "Version 1.2.12.0";
            treeNode53.Name = "Node2";
            treeNode53.Text = "DataViewColumnWidths method added";
            treeNode54.Name = "Node3";
            treeNode54.Text = "DataViewRowColours method added";
            treeNode55.Name = "Node1";
            treeNode55.Text = "LDControls";
            treeNode56.Name = "Node1";
            treeNode56.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode57.Name = "Node0";
            treeNode57.Text = "General";
            treeNode58.Name = "Node1";
            treeNode58.Text = "SetCentre method added";
            treeNode59.Name = "Node4";
            treeNode59.Text = "A 3rd rotation added";
            treeNode60.Name = "Node3";
            treeNode60.Text = "BoundingBox method added";
            treeNode61.Name = "Node0";
            treeNode61.Text = "LD3DView";
            treeNode62.Name = "Node3";
            treeNode62.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode63.Name = "Node2";
            treeNode63.Text = "LDDatabase";
            treeNode64.Name = "Node1";
            treeNode64.Text = "PlayMusic2 method added";
            treeNode65.Name = "Node2";
            treeNode65.Text = "Channel parameter added";
            treeNode66.Name = "Node0";
            treeNode66.Text = "LDMusic";
            treeNode67.Name = "Node0";
            treeNode67.Text = "Version 1.2.11.0";
            treeNode68.Name = "Node1";
            treeNode68.Text = "SetButtonStyle method added";
            treeNode69.Name = "Node0";
            treeNode69.Text = "LDControls";
            treeNode70.Name = "Node1";
            treeNode70.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode71.Name = "Node2";
            treeNode71.Text = "SetBillBoard method added";
            treeNode72.Name = "Node0";
            treeNode72.Text = "GetCameraUpDirection method added";
            treeNode73.Name = "Node1";
            treeNode73.Text = "Gradient brushes can be used";
            treeNode74.Name = "Node2";
            treeNode74.Text = "AutoControl method added";
            treeNode75.Name = "Node0";
            treeNode75.Text = "SpecularExponent property added";
            treeNode76.Name = "Node0";
            treeNode76.Text = "LD3DView";
            treeNode77.Name = "Node1";
            treeNode77.Text = "AddText method to annotate an image with text added";
            treeNode78.Name = "Node0";
            treeNode78.Text = "LDImage";
            treeNode79.Name = "Node4";
            treeNode79.Text = "BrushText for text on a brush added";
            treeNode80.Name = "Node0";
            treeNode80.Text = "Skew shapes method added";
            treeNode81.Name = "Node3";
            treeNode81.Text = "LDShapes";
            treeNode82.Name = "Node0";
            treeNode82.Text = "Version 1.2.10.0";
            treeNode83.Name = "Node1";
            treeNode83.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode84.Name = "Node0";
            treeNode84.Text = "LDUnits";
            treeNode85.Name = "Node1";
            treeNode85.Text = "Possible issue with FixSigFig fixed";
            treeNode86.Name = "Node0";
            treeNode86.Text = "LDMath";
            treeNode87.Name = "Node3";
            treeNode87.Text = "GetIndex method added (for SB arrays)";
            treeNode88.Name = "Node2";
            treeNode88.Text = "LDArray";
            treeNode89.Name = "Node5";
            treeNode89.Text = "Resize mode property added";
            treeNode90.Name = "Node6";
            treeNode90.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode91.Name = "Node4";
            treeNode91.Text = "LDGraphicsWindow";
            treeNode92.Name = "Node8";
            treeNode92.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode93.Name = "Node9";
            treeNode93.Text = "DataViewAllowUserEntry method added";
            treeNode94.Name = "Node7";
            treeNode94.Text = "LDControls";
            treeNode95.Name = "Node0";
            treeNode95.Text = "Version 1.2.9.0";
            treeNode96.Name = "Node1";
            treeNode96.Text = "New extended math object, starting with FFT";
            treeNode97.Name = "Node0";
            treeNode97.Text = "LDMathX";
            treeNode98.Name = "Node1";
            treeNode98.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode99.Name = "Node0";
            treeNode99.Text = "LDControls";
            treeNode100.Name = "Node3";
            treeNode100.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode101.Name = "Node2";
            treeNode101.Text = "LDArray";
            treeNode102.Name = "Node5";
            treeNode102.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode103.Name = "Node4";
            treeNode103.Text = "LDList";
            treeNode104.Name = "Node0";
            treeNode104.Text = "Version 1.2.8.0";
            treeNode105.Name = "Node2";
            treeNode105.Text = "Error handling, additional settings and multiple ports supported";
            treeNode106.Name = "Node1";
            treeNode106.Text = "LDCommPort";
            treeNode107.Name = "Node1";
            treeNode107.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode108.Name = "Node1";
            treeNode108.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode109.Name = "Node0";
            treeNode109.Text = "LDImage and LDWebCam";
            treeNode110.Name = "Node1";
            treeNode110.Text = "Bitwise operations object added";
            treeNode111.Name = "Node0";
            treeNode111.Text = "LDBits";
            treeNode112.Name = "Node1";
            treeNode112.Text = "Extended text encoding property added";
            treeNode113.Name = "Node0";
            treeNode113.Text = "TextWindow colours can be changed";
            treeNode114.Name = "Node0";
            treeNode114.Text = "LDTextWindow";
            treeNode115.Name = "Node1";
            treeNode115.Text = "GetWorkingImagePixelARGB method added";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDImage";
            treeNode117.Name = "Node1";
            treeNode117.Text = "RasteriseTurtleLines method added";
            treeNode118.Name = "Node0";
            treeNode118.Text = "LDShapes";
            treeNode119.Name = "Node0";
            treeNode119.Text = "Version 1.2.7.0";
            treeNode120.Name = "Node1";
            treeNode120.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode121.Name = "Node0";
            treeNode121.Text = "LDDialogs";
            treeNode122.Name = "Node1";
            treeNode122.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode123.Name = "Node2";
            treeNode123.Text = "ToggleSensor added";
            treeNode124.Name = "Node0";
            treeNode124.Text = "LDPhysics";
            treeNode125.Name = "Node1";
            treeNode125.Text = "Allow multiple copies of the webcam image";
            treeNode126.Name = "Node0";
            treeNode126.Text = "LDWebCam";
            treeNode127.Name = "Node1";
            treeNode127.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode128.Name = "Node0";
            treeNode128.Text = "MetaData method added";
            treeNode129.Name = "Node0";
            treeNode129.Text = "LDImage";
            treeNode130.Name = "Node0";
            treeNode130.Text = "Version 1.2.6.0";
            treeNode131.Name = "Node2";
            treeNode131.Text = "FixSigFig and FixDecimal methods added";
            treeNode132.Name = "Node3";
            treeNode132.Text = "MinNumber and MaxNumber properties added";
            treeNode133.Name = "Node1";
            treeNode133.Text = "LDMath";
            treeNode134.Name = "Node1";
            treeNode134.Text = "SliderMaximum property added";
            treeNode135.Name = "Node0";
            treeNode135.Text = "LDControls";
            treeNode136.Name = "Node1";
            treeNode136.Text = "ZoomAll method added";
            treeNode137.Name = "Node0";
            treeNode137.Text = "LDShapes";
            treeNode138.Name = "Node1";
            treeNode138.Text = "Reposition methods and properties added";
            treeNode139.Name = "Node0";
            treeNode139.Text = "LDGraphicsWindow";
            treeNode140.Name = "Node1";
            treeNode140.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode141.Name = "Node0";
            treeNode141.Text = "LDImage";
            treeNode142.Name = "Node1";
            treeNode142.Text = "MouseScroll parameter added";
            treeNode143.Name = "Node0";
            treeNode143.Text = "LDScrollBars";
            treeNode144.Name = "Node0";
            treeNode144.Text = "Version 1.2.5.0";
            treeNode145.Name = "Node0";
            treeNode145.Text = "New object added (previously a separate extension)";
            treeNode146.Name = "Node1";
            treeNode146.Text = "Async, Loop, Volume and Pan properties added";
            treeNode147.Name = "Node2";
            treeNode147.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode148.Name = "Node1";
            treeNode148.Text = "LDWaveForm";
            treeNode149.Name = "Node1";
            treeNode149.Text = "New object added to get input from gamepads or joysticks";
            treeNode150.Name = "Node0";
            treeNode150.Text = "LDController";
            treeNode151.Name = "Node1";
            treeNode151.Text = "RayCast method added";
            treeNode152.Name = "Node0";
            treeNode152.Text = "LDPhysics";
            treeNode153.Name = "Node0";
            treeNode153.Text = "Version 1.2.4.0";
            treeNode154.Name = "Node2";
            treeNode154.Text = "New object to apply effects to any shape or control";
            treeNode155.Name = "Node1";
            treeNode155.Text = "LDEffects";
            treeNode156.Name = "Node1";
            treeNode156.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode157.Name = "Node0";
            treeNode157.Text = "LDFigures";
            treeNode158.Name = "Node1";
            treeNode158.Text = "SetGroup method added";
            treeNode159.Name = "Node2";
            treeNode159.Text = "GetContacts method added";
            treeNode160.Name = "Node0";
            treeNode160.Text = "GetAllShapesAt method added";
            treeNode161.Name = "Node0";
            treeNode161.Text = "LDPhysics";
            treeNode162.Name = "Node2";
            treeNode162.Text = "SetImage handles images with transparency";
            treeNode163.Name = "Node0";
            treeNode163.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode164.Name = "Node1";
            treeNode164.Text = "LDClipboard";
            treeNode165.Name = "Node0";
            treeNode165.Text = "Version 1.2.3.0";
            treeNode166.Name = "Node2";
            treeNode166.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode167.Name = "Node1";
            treeNode167.Text = "LDShapes";
            treeNode168.Name = "Node4";
            treeNode168.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode169.Name = "Node3";
            treeNode169.Text = "LDFile";
            treeNode170.Name = "Node6";
            treeNode170.Text = "NewImage method added";
            treeNode171.Name = "Node5";
            treeNode171.Text = "LDImage";
            treeNode172.Name = "Node1";
            treeNode172.Text = "SetStartupPosition method added to position dialogs";
            treeNode173.Name = "Node0";
            treeNode173.Text = "LDDialogs";
            treeNode174.Name = "Node1";
            treeNode174.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode175.Name = "Node0";
            treeNode175.Text = "LDGraph";
            treeNode176.Name = "Node0";
            treeNode176.Text = "Version 1.2.2.0";
            treeNode177.Name = "Node2";
            treeNode177.Text = "Recompiled for Small Basic version 1.2";
            treeNode178.Name = "Node1";
            treeNode178.Text = "Version 1.2";
            treeNode179.Name = "Node0";
            treeNode179.Text = "Version 1.2.0.1";
            treeNode180.Name = "Node2";
            treeNode180.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode181.Name = "Node1";
            treeNode181.Text = "LDDialogs";
            treeNode182.Name = "Node1";
            treeNode182.Text = "Logical operations object added";
            treeNode183.Name = "Node0";
            treeNode183.Text = "LDLogic";
            treeNode184.Name = "Node4";
            treeNode184.Text = "CurrentCulture property added";
            treeNode185.Name = "Node3";
            treeNode185.Text = "LDUtilities";
            treeNode186.Name = "Node6";
            treeNode186.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode187.Name = "Node5";
            treeNode187.Text = "LDMath";
            treeNode188.Name = "Node0";
            treeNode188.Text = "Version 1.1.0.8";
            treeNode189.Name = "Node1";
            treeNode189.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode190.Name = "Node0";
            treeNode190.Text = "LDControls";
            treeNode191.Name = "Node1";
            treeNode191.Text = "Methods added to add and remove nodes and save xml file";
            treeNode192.Name = "Node0";
            treeNode192.Text = "LDxml";
            treeNode193.Name = "Node1";
            treeNode193.Text = "MusicPlayTime moved from LDFile";
            treeNode194.Name = "Node0";
            treeNode194.Text = "LDSound";
            treeNode195.Name = "Node0";
            treeNode195.Text = "Version 1.1.0.7";
            treeNode196.Name = "Node4";
            treeNode196.Text = "SplitImage method added";
            treeNode197.Name = "Node3";
            treeNode197.Text = "LDImage";
            treeNode198.Name = "Node6";
            treeNode198.Text = "EditTable and SaveTable methods added";
            treeNode199.Name = "Node5";
            treeNode199.Text = "LDDatabse";
            treeNode200.Name = "Node2";
            treeNode200.Text = "DataView control and methods added";
            treeNode201.Name = "Node1";
            treeNode201.Text = "LDControls";
            treeNode202.Name = "Node2";
            treeNode202.Text = "Version 1.1.0.6";
            treeNode203.Name = "Node2";
            treeNode203.Text = "Exists modified to check for directory as well as file";
            treeNode204.Name = "Node3";
            treeNode204.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode205.Name = "Node1";
            treeNode205.Text = "LDFile";
            treeNode206.Name = "Node5";
            treeNode206.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode207.Name = "Node6";
            treeNode207.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode208.Name = "Node9";
            treeNode208.Text = "Conditonal break point added";
            treeNode209.Name = "Node0";
            treeNode209.Text = "Step over button added";
            treeNode210.Name = "Node4";
            treeNode210.Text = "LDDebug";
            treeNode211.Name = "Node8";
            treeNode211.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode212.Name = "Node7";
            treeNode212.Text = "LDGraphicsWindow";
            treeNode213.Name = "Node1";
            treeNode213.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode214.Name = "Node0";
            treeNode214.Text = "LDResources";
            treeNode215.Name = "Node0";
            treeNode215.Text = "Version 1.1.0.5";
            treeNode216.Name = "Node2";
            treeNode216.Text = "ClipboardChanged event added";
            treeNode217.Name = "Node1";
            treeNode217.Text = "LDClipboard";
            treeNode218.Name = "Node1";
            treeNode218.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode219.Name = "Node0";
            treeNode219.Text = "LDFile";
            treeNode220.Name = "Node3";
            treeNode220.Text = "SetActive method added";
            treeNode221.Name = "Node2";
            treeNode221.Text = "LDGraphicsWindow";
            treeNode222.Name = "Node1";
            treeNode222.Text = "Parse xml file nodes";
            treeNode223.Name = "Node0";
            treeNode223.Text = "LDxml";
            treeNode224.Name = "Node3";
            treeNode224.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode225.Name = "Node2";
            treeNode225.Text = "General";
            treeNode226.Name = "Node0";
            treeNode226.Text = "Version 1.1.0.4";
            treeNode227.Name = "Node2";
            treeNode227.Text = "WakeAll method addded";
            treeNode228.Name = "Node1";
            treeNode228.Text = "LDPhysics";
            treeNode229.Name = "Node1";
            treeNode229.Text = "Clipboard methods added";
            treeNode230.Name = "Node0";
            treeNode230.Text = "LDClipboard";
            treeNode231.Name = "Node0";
            treeNode231.Text = "Version 1.1.0.3";
            treeNode232.Name = "Node6";
            treeNode232.Text = "SizeNWSE cursor added";
            treeNode233.Name = "Node5";
            treeNode233.Text = "LDCursors";
            treeNode234.Name = "Node8";
            treeNode234.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode235.Name = "Node7";
            treeNode235.Text = "LDGraph";
            treeNode236.Name = "Node1";
            treeNode236.Text = "SQLite updated for .Net 4.5";
            treeNode237.Name = "Node0";
            treeNode237.Text = "LDDataBase";
            treeNode238.Name = "Node4";
            treeNode238.Text = "Version 1.1.0.2";
            treeNode239.Name = "Node3";
            treeNode239.Text = "Recompiled for Small Basic version 1.1";
            treeNode240.Name = "Node2";
            treeNode240.Text = "Version 1.1";
            treeNode241.Name = "Node0";
            treeNode241.Text = "Version 1.1.0.1";
            treeNode242.Name = "Node12";
            treeNode242.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode243.Name = "Node13";
            treeNode243.Text = "RichTextBoxMargins method added";
            treeNode244.Name = "Node0";
            treeNode244.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode245.Name = "Node1";
            treeNode245.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode246.Name = "Node11";
            treeNode246.Text = "LDControls";
            treeNode247.Name = "Node3";
            treeNode247.Text = "Error reporting added";
            treeNode248.Name = "Node4";
            treeNode248.Text = "SetEncoding method added";
            treeNode249.Name = "Node2";
            treeNode249.Text = "LDCommPort";
            treeNode250.Name = "Node6";
            treeNode250.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode251.Name = "Node7";
            treeNode251.Text = "Export to excel fix for graph with no title";
            treeNode252.Name = "Node5";
            treeNode252.Text = "LDGraph";
            treeNode253.Name = "Node9";
            treeNode253.Text = "Negative restitution option when adding moving shape";
            treeNode254.Name = "Node8";
            treeNode254.Text = "LDPhysics";
            treeNode255.Name = "Node10";
            treeNode255.Text = "Version 1.0.0.133";
            treeNode256.Name = "Node2";
            treeNode256.Text = "Internal improvements to auto messaging";
            treeNode257.Name = "Node9";
            treeNode257.Text = "Name can be set and GetClients method added";
            treeNode258.Name = "Node1";
            treeNode258.Text = "LDClient";
            treeNode259.Name = "Node4";
            treeNode259.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode260.Name = "Node3";
            treeNode260.Text = "LDControls";
            treeNode261.Name = "Node8";
            treeNode261.Text = "Return message and possible file error fixed for Stop method";
            treeNode262.Name = "Node7";
            treeNode262.Text = "LDSound";
            treeNode263.Name = "Node0";
            treeNode263.Text = "Version 1.0.0.132";
            treeNode264.Name = "Node2";
            treeNode264.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode265.Name = "Node5";
            treeNode265.Text = "Compile method added to compile a Small Basic program";
            treeNode266.Name = "Node1";
            treeNode266.Text = "LDCall";
            treeNode267.Name = "Node4";
            treeNode267.Text = "Methods and code by Pappa Lapub added";
            treeNode268.Name = "Node3";
            treeNode268.Text = "LDShell";
            treeNode269.Name = "Node0";
            treeNode269.Text = "Version 1.0.0.131";
            treeNode270.Name = "Node6";
            treeNode270.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode271.Name = "Node7";
            treeNode271.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode272.Name = "Node8";
            treeNode272.Text = "Refactoring of all the pan, follow and box methods";
            treeNode273.Name = "Node6";
            treeNode273.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode274.Name = "Node8";
            treeNode274.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode275.Name = "Node5";
            treeNode275.Text = "LDPhysics";
            treeNode276.Name = "Node1";
            treeNode276.Text = "UseBinary property added";
            treeNode277.Name = "Node2";
            treeNode277.Text = "DoAsync property and associated completion events added";
            treeNode278.Name = "Node3";
            treeNode278.Text = "Delete method added";
            treeNode279.Name = "Node0";
            treeNode279.Text = "LDftp";
            treeNode280.Name = "Node5";
            treeNode280.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode281.Name = "Node4";
            treeNode281.Text = "LDCall";
            treeNode282.Name = "Node2";
            treeNode282.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode283.Name = "Node1";
            treeNode283.Text = "LDControls";
            treeNode284.Name = "Node4";
            treeNode284.Text = "Version 1.0.0.130";
            treeNode285.Name = "Node2";
            treeNode285.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode286.Name = "Node1";
            treeNode286.Text = "LDMath";
            treeNode287.Name = "Node1";
            treeNode287.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode288.Name = "Node0";
            treeNode288.Text = "LDPhysics";
            treeNode289.Name = "Node3";
            treeNode289.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode290.Name = "Node2";
            treeNode290.Text = "LDGraphicsWindow";
            treeNode291.Name = "Node1";
            treeNode291.Text = "FTP object methods added";
            treeNode292.Name = "Node0";
            treeNode292.Text = "LDftp";
            treeNode293.Name = "Node3";
            treeNode293.Text = "An existing file is replaced";
            treeNode294.Name = "Node2";
            treeNode294.Text = "LDZip";
            treeNode295.Name = "Node1";
            treeNode295.Text = "Size method added";
            treeNode296.Name = "Node0";
            treeNode296.Text = "LDFile";
            treeNode297.Name = "Node3";
            treeNode297.Text = "DownloadFile method added";
            treeNode298.Name = "Node2";
            treeNode298.Text = "LDNetwork";
            treeNode299.Name = "Node0";
            treeNode299.Text = "Version 1.0.0.129";
            treeNode300.Name = "Node2";
            treeNode300.Text = "Generalised joint connections added";
            treeNode301.Name = "Node0";
            treeNode301.Text = "AddExplosion method added";
            treeNode302.Name = "Node1";
            treeNode302.Text = "LDPhysics";
            treeNode303.Name = "Node1";
            treeNode303.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode304.Name = "Node0";
            treeNode304.Text = "LDShapes";
            treeNode305.Name = "Node0";
            treeNode305.Text = "Version 1.0.0.128";
            treeNode306.Name = "Node2";
            treeNode306.Text = "CheckServer method added";
            treeNode307.Name = "Node1";
            treeNode307.Text = "LDClient";
            treeNode308.Name = "Node1";
            treeNode308.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode309.Name = "Node2";
            treeNode309.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode310.Name = "Node3";
            treeNode310.Text = "GetAngle method added";
            treeNode311.Name = "Node4";
            treeNode311.Text = "Top-down tire (to model a car from above) methods added";
            treeNode312.Name = "Node0";
            treeNode312.Text = "LDPhysics";
            treeNode313.Name = "Node0";
            treeNode313.Text = "Version 1.0.0.127";
            treeNode314.Name = "Node7";
            treeNode314.Text = "Bug fixes for Overlap methods";
            treeNode315.Name = "Node6";
            treeNode315.Text = "LDShapes";
            treeNode316.Name = "Node0";
            treeNode316.Text = "Bug fix for multiple numeric sorts";
            treeNode317.Name = "Node9";
            treeNode317.Text = "ByValueWithIndex method added";
            treeNode318.Name = "Node8";
            treeNode318.Text = "LDSort";
            treeNode319.Name = "Node1";
            treeNode319.Text = "LAN method added to get local IP addresses";
            treeNode320.Name = "Node2";
            treeNode320.Text = "Ping method added";
            treeNode321.Name = "Node0";
            treeNode321.Text = "LDNetwork";
            treeNode322.Name = "Node1";
            treeNode322.Text = "LoadSVG method added";
            treeNode323.Name = "Node0";
            treeNode323.Text = "LDImage";
            treeNode324.Name = "Node3";
            treeNode324.Text = "Evaluate method added";
            treeNode325.Name = "Node2";
            treeNode325.Text = "LDMath";
            treeNode326.Name = "Node5";
            treeNode326.Text = "IncludeJScript method added";
            treeNode327.Name = "Node4";
            treeNode327.Text = "LDInline";
            treeNode328.Name = "Node5";
            treeNode328.Text = "Version 1.0.0.126";
            treeNode329.Name = "Node0";
            treeNode329.Text = "Special emphasis on async consistency";
            treeNode330.Name = "Node4";
            treeNode330.Text = "Simplified auto method for multi-player game data transfer";
            treeNode331.Name = "Node9";
            treeNode331.Text = "LDServer and LDClient objects added";
            treeNode332.Name = "Node2";
            treeNode332.Text = "GetWidth and GetHeight methods added";
            treeNode333.Name = "Node1";
            treeNode333.Text = "LDText";
            treeNode334.Name = "Node4";
            treeNode334.Text = "Bing web search";
            treeNode335.Name = "Node3";
            treeNode335.Text = "LDSearch";
            treeNode336.Name = "Node6";
            treeNode336.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode337.Name = "Node7";
            treeNode337.Text = "KeyScroll property added";
            treeNode338.Name = "Node5";
            treeNode338.Text = "LDScrollBars";
            treeNode339.Name = "Node9";
            treeNode339.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode340.Name = "Node8";
            treeNode340.Text = "LDShapes";
            treeNode341.Name = "Node1";
            treeNode341.Text = "SaveAs method bug fixed";
            treeNode342.Name = "Node0";
            treeNode342.Text = "LDImage";
            treeNode343.Name = "Node3";
            treeNode343.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode344.Name = "Node2";
            treeNode344.Text = "LDQueue";
            treeNode345.Name = "Node8";
            treeNode345.Text = "Version 1.0.0.125";
            treeNode346.Name = "Node7";
            treeNode346.Text = "Language translation object added";
            treeNode347.Name = "Node6";
            treeNode347.Text = "LDTranslate";
            treeNode348.Name = "Node5";
            treeNode348.Text = "Version 1.0.0.124";
            treeNode349.Name = "Node1";
            treeNode349.Text = "Mouse screen coordinate conversion parameters added";
            treeNode350.Name = "Node2";
            treeNode350.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode351.Name = "Node0";
            treeNode351.Text = "LDGraphicsWindow";
            treeNode352.Name = "Node4";
            treeNode352.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode353.Name = "Node3";
            treeNode353.Text = "LDUtilities";
            treeNode354.Name = "Node0";
            treeNode354.Text = "Version 1.0.0.123";
            treeNode355.Name = "Node5";
            treeNode355.Text = "ColorMatrix method added";
            treeNode356.Name = "Node0";
            treeNode356.Text = "Rotate method added";
            treeNode357.Name = "Node3";
            treeNode357.Text = "LDImage";
            treeNode358.Name = "Node1";
            treeNode358.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode359.Name = "Node0";
            treeNode359.Text = "LDChart";
            treeNode360.Name = "Node2";
            treeNode360.Text = "Version 1.0.0.122";
            treeNode361.Name = "Node2";
            treeNode361.Text = "EffectGamma added to darken and lighten";
            treeNode362.Name = "Node4";
            treeNode362.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode363.Name = "Node3";
            treeNode363.Text = "EffectContrast modified";
            treeNode364.Name = "Node0";
            treeNode364.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode365.Name = "Node1";
            treeNode365.Text = "LDImage";
            treeNode366.Name = "Node2";
            treeNode366.Text = "Error event added for all extension exceptions";
            treeNode367.Name = "Node1";
            treeNode367.Text = "LDEvents";
            treeNode368.Name = "Node1";
            treeNode368.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode369.Name = "Node0";
            treeNode369.Text = "LDMath";
            treeNode370.Name = "Node0";
            treeNode370.Text = "Version 1.0.0.121";
            treeNode371.Name = "Node2";
            treeNode371.Text = "FloodFill transparency effect fixed";
            treeNode372.Name = "Node1";
            treeNode372.Text = "LDGraphicsWindow";
            treeNode373.Name = "Node1";
            treeNode373.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode374.Name = "Node0";
            treeNode374.Text = "LDFile";
            treeNode375.Name = "Node1";
            treeNode375.Text = "EffectPixelate added";
            treeNode376.Name = "Node0";
            treeNode376.Text = "LDImage";
            treeNode377.Name = "Node1";
            treeNode377.Text = "Modified to work with Windows 8";
            treeNode378.Name = "Node0";
            treeNode378.Text = "LDWebCam";
            treeNode379.Name = "Node0";
            treeNode379.Text = "Version 1.0.0.120";
            treeNode380.Name = "Node2";
            treeNode380.Text = "FloodFill method added";
            treeNode381.Name = "Node1";
            treeNode381.Text = "LDGraphicsWindow";
            treeNode382.Name = "Node0";
            treeNode382.Text = "Version 1.0.0.119";
            treeNode383.Name = "Node0";
            treeNode383.Text = "SetShapeCursor method added";
            treeNode384.Name = "Node11";
            treeNode384.Text = "CreateCursor method added";
            treeNode385.Name = "Node9";
            treeNode385.Text = "LDCursors";
            treeNode386.Name = "Node2";
            treeNode386.Text = "SaveAs method to save in different file formats";
            treeNode387.Name = "Node0";
            treeNode387.Text = "Parameters added for some effects";
            treeNode388.Name = "Node1";
            treeNode388.Text = "LDImage";
            treeNode389.Name = "Node2";
            treeNode389.Text = "Parameters added for some effects";
            treeNode390.Name = "Node1";
            treeNode390.Text = "LDWebCam";
            treeNode391.Name = "Node1";
            treeNode391.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode392.Name = "Node0";
            treeNode392.Text = "SetFontFromFile method added for ttf fonts";
            treeNode393.Name = "Node0";
            treeNode393.Text = "LDGraphicsWindow";
            treeNode394.Name = "Node3";
            treeNode394.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode395.Name = "Node2";
            treeNode395.Text = "LDTextWindow";
            treeNode396.Name = "Node2";
            treeNode396.Text = "Zip methods moved here from LDUtilities";
            treeNode397.Name = "Node0";
            treeNode397.Text = "LDZip";
            treeNode398.Name = "Node3";
            treeNode398.Text = "Regex methods moved here from LDUtilities";
            treeNode399.Name = "Node1";
            treeNode399.Text = "LDRegex";
            treeNode400.Name = "Node1";
            treeNode400.Text = "ListViewRowCount method added";
            treeNode401.Name = "Node0";
            treeNode401.Text = "LDControls";
            treeNode402.Name = "Node3";
            treeNode402.Text = "Version 1.0.0.118";
            treeNode403.Name = "Node5";
            treeNode403.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode404.Name = "Node6";
            treeNode404.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode405.Name = "Node4";
            treeNode405.Text = "LDUtilities";
            treeNode406.Name = "Node10";
            treeNode406.Text = "SetUserCursor method added";
            treeNode407.Name = "Node4";
            treeNode407.Text = "LDCursors";
            treeNode408.Name = "Node3";
            treeNode408.Text = "Version 1.0.0.117";
            treeNode409.Name = "Node2";
            treeNode409.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode410.Name = "Node1";
            treeNode410.Text = "LDDictionary";
            treeNode411.Name = "Node0";
            treeNode411.Text = "Version 1.0.0.116";
            treeNode412.Name = "Node2";
            treeNode412.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode413.Name = "Node1";
            treeNode413.Text = "LDColours";
            treeNode414.Name = "Node4";
            treeNode414.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode415.Name = "Node3";
            treeNode415.Text = "LDShapes";
            treeNode416.Name = "Node1";
            treeNode416.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode417.Name = "Node0";
            treeNode417.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode418.Name = "Node1";
            treeNode418.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode419.Name = "Node0";
            treeNode419.Text = "LDGraph";
            treeNode420.Name = "Node0";
            treeNode420.Text = "Version 1.0.0.115";
            treeNode421.Name = "Node2";
            treeNode421.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode422.Name = "Node1";
            treeNode422.Text = "LDControls";
            treeNode423.Name = "Node4";
            treeNode423.Text = "RemoveTurtleLines method added";
            treeNode424.Name = "Node6";
            treeNode424.Text = "GetAllShapes method added";
            treeNode425.Name = "Node3";
            treeNode425.Text = "LDShapes";
            treeNode426.Name = "Node1";
            treeNode426.Text = "Odbc connection added";
            treeNode427.Name = "Node0";
            treeNode427.Text = "LDDatabase";
            treeNode428.Name = "Node0";
            treeNode428.Text = "Version 1.0.0.114";
            treeNode429.Name = "Node2";
            treeNode429.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode430.Name = "Node1";
            treeNode430.Text = "LDUtilities";
            treeNode431.Name = "Node4";
            treeNode431.Text = "ListView control added";
            treeNode432.Name = "Node5";
            treeNode432.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode433.Name = "Node3";
            treeNode433.Text = "LDControls";
            treeNode434.Name = "Node0";
            treeNode434.Text = "Version 1.0.0.113";
            treeNode435.Name = "Node2";
            treeNode435.Text = "Tone method added";
            treeNode436.Name = "Node1";
            treeNode436.Text = "LDSound";
            treeNode437.Name = "Node5";
            treeNode437.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode438.Name = "Node4";
            treeNode438.Text = "LDControls";
            treeNode439.Name = "Node0";
            treeNode439.Text = "Version 1.0.0.112";
            treeNode440.Name = "Node2";
            treeNode440.Text = "SqlServer and Access database support added";
            treeNode441.Name = "Node1";
            treeNode441.Text = "LDDataBase";
            treeNode442.Name = "Node4";
            treeNode442.Text = "FixFlickr method added";
            treeNode443.Name = "Node0";
            treeNode443.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode444.Name = "Node3";
            treeNode444.Text = "LDUtilities";
            treeNode445.Name = "Node0";
            treeNode445.Text = "Version 1.0.0.111";
            treeNode446.Name = "Node2";
            treeNode446.Text = "TextBoxTab method added";
            treeNode447.Name = "Node1";
            treeNode447.Text = "LDControls";
            treeNode448.Name = "Node0";
            treeNode448.Text = "Version 1.0.0.110";
            treeNode449.Name = "Node1";
            treeNode449.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode450.Name = "Node3";
            treeNode450.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode451.Name = "Node0";
            treeNode451.Text = "General";
            treeNode452.Name = "Node5";
            treeNode452.Text = "Exists method added to check if a file path exists or not";
            treeNode453.Name = "Node4";
            treeNode453.Text = "LDFile";
            treeNode454.Name = "Node7";
            treeNode454.Text = "Start method handles attaching to existing process without warning";
            treeNode455.Name = "Node6";
            treeNode455.Text = "LDProcess";
            treeNode456.Name = "Node1";
            treeNode456.Text = "MySQL database support added";
            treeNode457.Name = "Node0";
            treeNode457.Text = "LDDatabase";
            treeNode458.Name = "Node3";
            treeNode458.Text = "Add and Multiply methods honour transparency";
            treeNode459.Name = "Node4";
            treeNode459.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode460.Name = "Node2";
            treeNode460.Text = "LDImage";
            treeNode461.Name = "Node3";
            treeNode461.Text = "Version 1.0.0.109";
            treeNode462.Name = "Node2";
            treeNode462.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode463.Name = "Node1";
            treeNode463.Text = "LDTextWindow";
            treeNode464.Name = "Node0";
            treeNode464.Text = "Version 1.0.0.108";
            treeNode465.Name = "Node14";
            treeNode465.Text = "Transparent colour added";
            treeNode466.Name = "Node13";
            treeNode466.Text = "LDColours";
            treeNode467.Name = "Node16";
            treeNode467.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode468.Name = "Node15";
            treeNode468.Text = "LDDialogs";
            treeNode469.Name = "Node12";
            treeNode469.Text = "Version 1.0.0.107";
            treeNode470.Name = "Node8";
            treeNode470.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode471.Name = "Node7";
            treeNode471.Text = "LDControls";
            treeNode472.Name = "Node11";
            treeNode472.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode473.Name = "Node10";
            treeNode473.Text = "LDShapes";
            treeNode474.Name = "Node6";
            treeNode474.Text = "Version 1.0.0.106";
            treeNode475.Name = "Node5";
            treeNode475.Text = "Menu control added";
            treeNode476.Name = "Node4";
            treeNode476.Text = "LDControls";
            treeNode477.Name = "Node3";
            treeNode477.Text = "Version 1.0.0.105";
            treeNode478.Name = "Node5";
            treeNode478.Text = "ZipList method added";
            treeNode479.Name = "Node2";
            treeNode479.Text = "GetNextMapIndex method added";
            treeNode480.Name = "Node4";
            treeNode480.Text = "LDUtilities";
            treeNode481.Name = "Node1";
            treeNode481.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode482.Name = "Node0";
            treeNode482.Text = "LDShapes";
            treeNode483.Name = "Node3";
            treeNode483.Text = "Version 1.0.0.104";
            treeNode484.Name = "Node1";
            treeNode484.Text = "Transparency maintained for various methods";
            treeNode485.Name = "Node2";
            treeNode485.Text = "Effects bug fixed";
            treeNode486.Name = "Node0";
            treeNode486.Text = "LDImage";
            treeNode487.Name = "Node0";
            treeNode487.Text = "Version 1.0.0.103";
            treeNode488.Name = "Node1";
            treeNode488.Text = "Current application assemblies are all auto-referenced";
            treeNode489.Name = "Node0";
            treeNode489.Text = "LDInline";
            treeNode490.Name = "Node5";
            treeNode490.Text = "Version 1.0.0.102";
            treeNode491.Name = "Node1";
            treeNode491.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode492.Name = "Node2";
            treeNode492.Text = "LDInline.sb sample provided";
            treeNode493.Name = "Node0";
            treeNode493.Text = "LDInline";
            treeNode494.Name = "Node4";
            treeNode494.Text = "ExitButtonMode method added to control window close button state";
            treeNode495.Name = "Node3";
            treeNode495.Text = "LDUtilities";
            treeNode496.Name = "Node0";
            treeNode496.Text = "Version 1.0.0.101";
            treeNode497.Name = "Node1";
            treeNode497.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode498.Name = "Node0";
            treeNode498.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode499.Name = "Node0";
            treeNode499.Text = "LDTextWindow";
            treeNode500.Name = "Node0";
            treeNode500.Text = "Version 1.0.0.100";
            treeNode501.Name = "Node2";
            treeNode501.Text = "ReadANSIToArray method added";
            treeNode502.Name = "Node1";
            treeNode502.Text = "LDFile";
            treeNode503.Name = "Node1";
            treeNode503.Text = "DocumentViewer control added";
            treeNode504.Name = "Node0";
            treeNode504.Text = "LDControls";
            treeNode505.Name = "Node3";
            treeNode505.Text = "An object to batch update shapes (for speed reasons)";
            treeNode506.Name = "Node0";
            treeNode506.Text = "LDFastShapes.sb sample included";
            treeNode507.Name = "Node2";
            treeNode507.Text = "LDFastShapes";
            treeNode508.Name = "Node0";
            treeNode508.Text = "Version 1.0.0.99";
            treeNode509.Name = "Node1";
            treeNode509.Text = "Rendering performance improvements when many shapes present";
            treeNode510.Name = "Node0";
            treeNode510.Text = "LDPhysics";
            treeNode511.Name = "Node1";
            treeNode511.Text = "ANSItoUTF8 method added";
            treeNode512.Name = "Node2";
            treeNode512.Text = "ReadANSI method added";
            treeNode513.Name = "Node0";
            treeNode513.Text = "LDFile";
            treeNode514.Name = "Node1";
            treeNode514.Text = "Version 1.0.0.98";
            treeNode515.Name = "Node3";
            treeNode515.Text = "Move method added for tiangles, polygons and lines";
            treeNode516.Name = "Node4";
            treeNode516.Text = "RotateAbout method added";
            treeNode517.Name = "Node1";
            treeNode517.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode518.Name = "Node0";
            treeNode518.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode519.Name = "Node2";
            treeNode519.Text = "LDShapes";
            treeNode520.Name = "Node0";
            treeNode520.Text = "Version 1.0.0.97";
            treeNode521.Name = "Node4";
            treeNode521.Text = "A list storage object added";
            treeNode522.Name = "Node3";
            treeNode522.Text = "LDList";
            treeNode523.Name = "Node2";
            treeNode523.Text = "Version 1.0.0.96";
            treeNode524.Name = "Node4";
            treeNode524.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode525.Name = "Node3";
            treeNode525.Text = "LDQueue";
            treeNode526.Name = "Node6";
            treeNode526.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode527.Name = "Node5";
            treeNode527.Text = "LDNetwork";
            treeNode528.Name = "Node0";
            treeNode528.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode529.Name = "Node1";
            treeNode529.Text = "General";
            treeNode530.Name = "Node2";
            treeNode530.Text = "Version 1.0.0.95";
            treeNode531.Name = "Node2";
            treeNode531.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode532.Name = "Node1";
            treeNode532.Text = "LDEncryption";
            treeNode533.Name = "Node1";
            treeNode533.Text = "RandomNumberSeed property added";
            treeNode534.Name = "Node0";
            treeNode534.Text = "LDMath";
            treeNode535.Name = "Node1";
            treeNode535.Text = "SetGameData and GetGameData methods added";
            treeNode536.Name = "Node0";
            treeNode536.Text = "LDNetwork";
            treeNode537.Name = "Node0";
            treeNode537.Text = "Version 1.0.0.94";
            treeNode538.Name = "Node1";
            treeNode538.Text = "SliderGetValue method added";
            treeNode539.Name = "Node0";
            treeNode539.Text = "LDControls";
            treeNode540.Name = "Node5";
            treeNode540.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode541.Name = "Node2";
            treeNode541.Text = "LDUtilities";
            treeNode542.Name = "Node3";
            treeNode542.Text = "Encrypt and Decrypt methods added";
            treeNode543.Name = "Node4";
            treeNode543.Text = "MD5Hash method added";
            treeNode544.Name = "Node6";
            treeNode544.Text = "LDEncryption";
            treeNode545.Name = "Node0";
            treeNode545.Text = "Version 1.0.0.93";
            treeNode546.Name = "Node1";
            treeNode546.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode547.Name = "Node0";
            treeNode547.Text = "LDControls";
            treeNode548.Name = "Node0";
            treeNode548.Text = "Version 1.0.0.92";
            treeNode549.Name = "Node2";
            treeNode549.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode550.Name = "Node1";
            treeNode550.Text = "LDControls";
            treeNode551.Name = "Node1";
            treeNode551.Text = "Version 1.0.0.91";
            treeNode552.Name = "Node1";
            treeNode552.Text = "Font method added to modify shapes or controls that have text";
            treeNode553.Name = "Node0";
            treeNode553.Text = "LDShapes";
            treeNode554.Name = "Node1";
            treeNode554.Text = "MediaPlayer control added (play videos etc)";
            treeNode555.Name = "Node0";
            treeNode555.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode556.Name = "Node0";
            treeNode556.Text = "LDControls";
            treeNode557.Name = "Node1";
            treeNode557.Text = "Version 1.0.0.90";
            treeNode558.Name = "Node1";
            treeNode558.Text = "Autosize columns for ListView";
            treeNode559.Name = "Node2";
            treeNode559.Text = "LDDataBase.sb sample updated";
            treeNode560.Name = "Node0";
            treeNode560.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode561.Name = "Node0";
            treeNode561.Text = "LDDataBase";
            treeNode562.Name = "Node0";
            treeNode562.Text = "Version 1.0.0.89";
            treeNode563.Name = "Node4";
            treeNode563.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode564.Name = "Node3";
            treeNode564.Text = "LDScrollBars";
            treeNode565.Name = "Node1";
            treeNode565.Text = "CleanTemp method added";
            treeNode566.Name = "Node0";
            treeNode566.Text = "LDUtilities";
            treeNode567.Name = "Node1";
            treeNode567.Text = "SQLite database methods added";
            treeNode568.Name = "Node0";
            treeNode568.Text = "LDDataBase";
            treeNode569.Name = "Node2";
            treeNode569.Text = "Version 1.0.0.88";
            treeNode570.Name = "Node2";
            treeNode570.Text = "LastError now returns a text error";
            treeNode571.Name = "Node1";
            treeNode571.Text = "LDIOWarrior";
            treeNode572.Name = "Node1";
            treeNode572.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode573.Name = "Node0";
            treeNode573.Text = "LDScrollBars";
            treeNode574.Name = "Node0";
            treeNode574.Text = "Version 1.0.0.87";
            treeNode575.Name = "Node4";
            treeNode575.Text = "SetTurtleImage method added";
            treeNode576.Name = "Node3";
            treeNode576.Text = "LDShapes";
            treeNode577.Name = "Node1";
            treeNode577.Text = "Connect to IOWarrior USB devices";
            treeNode578.Name = "Node0";
            treeNode578.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode579.Name = "Node0";
            treeNode579.Text = "LDIOWarrior";
            treeNode580.Name = "Node2";
            treeNode580.Text = "Version 1.0.0.86";
            treeNode581.Name = "Node1";
            treeNode581.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode582.Name = "Node0";
            treeNode582.Text = "LDShapes";
            treeNode583.Name = "Node2";
            treeNode583.Text = "Version 1.0.0.85";
            treeNode584.Name = "Node4";
            treeNode584.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode585.Name = "Node3";
            treeNode585.Text = "LDFile";
            treeNode586.Name = "Node6";
            treeNode586.Text = "Crop method added";
            treeNode587.Name = "Node5";
            treeNode587.Text = "LDImage";
            treeNode588.Name = "Node1";
            treeNode588.Text = "LastDropFiles bug fixed";
            treeNode589.Name = "Node0";
            treeNode589.Text = "LDControls";
            treeNode590.Name = "Node2";
            treeNode590.Text = "Version 1.0.0.84";
            treeNode591.Name = "Node7";
            treeNode591.Text = "FileDropped event added";
            treeNode592.Name = "Node6";
            treeNode592.Text = "LDControls";
            treeNode593.Name = "Node1";
            treeNode593.Text = "Bug in Split corrected";
            treeNode594.Name = "Node0";
            treeNode594.Text = "LDText";
            treeNode595.Name = "Node5";
            treeNode595.Text = "Version 1.0.0.83";
            treeNode596.Name = "Node3";
            treeNode596.Text = "Title argument removed from AddComboBox";
            treeNode597.Name = "Node4";
            treeNode597.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode598.Name = "Node2";
            treeNode598.Text = "LDControls";
            treeNode599.Name = "Node1";
            treeNode599.Text = "Version 1.0.0.82";
            treeNode600.Name = "Node0";
            treeNode600.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode601.Name = "Node12";
            treeNode601.Text = "Program settings added";
            treeNode602.Name = "Node9";
            treeNode602.Text = "LDSettings";
            treeNode603.Name = "Node11";
            treeNode603.Text = "Get some system paths and user name";
            treeNode604.Name = "Node10";
            treeNode604.Text = "LDFile";
            treeNode605.Name = "Node14";
            treeNode605.Text = "System sounds added";
            treeNode606.Name = "Node13";
            treeNode606.Text = "LDSound";
            treeNode607.Name = "Node16";
            treeNode607.Text = "Binary, octal, hex and decimal conversions";
            treeNode608.Name = "Node15";
            treeNode608.Text = "LDMath";
            treeNode609.Name = "Node1";
            treeNode609.Text = "Replace method added";
            treeNode610.Name = "Node2";
            treeNode610.Text = "FindAll method added";
            treeNode611.Name = "Node0";
            treeNode611.Text = "LDText";
            treeNode612.Name = "Node8";
            treeNode612.Text = "Version 1.0.0.81";
            treeNode613.Name = "Node1";
            treeNode613.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode614.Name = "Node6";
            treeNode614.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode615.Name = "Node0";
            treeNode615.Text = "LDShapes";
            treeNode616.Name = "Node3";
            treeNode616.Text = "Truncate method added";
            treeNode617.Name = "Node2";
            treeNode617.Text = "LDMath";
            treeNode618.Name = "Node5";
            treeNode618.Text = "Additional text methods";
            treeNode619.Name = "Node4";
            treeNode619.Text = "LDText";
            treeNode620.Name = "Node0";
            treeNode620.Text = "Version 1.0.0.80";
            treeNode621.Name = "Node1";
            treeNode621.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode622.Name = "Node0";
            treeNode622.Text = "LDDialogs";
            treeNode623.Name = "Node1";
            treeNode623.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode624.Name = "Node0";
            treeNode624.Text = "LDUtilities";
            treeNode625.Name = "Node6";
            treeNode625.Text = "Version 1.0.0.79";
            treeNode626.Name = "Node2";
            treeNode626.Text = "Rasterize property added";
            treeNode627.Name = "Node5";
            treeNode627.Text = "Improvements associated with window resizing";
            treeNode628.Name = "Node1";
            treeNode628.Text = "LDScrollBars";
            treeNode629.Name = "Node4";
            treeNode629.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode630.Name = "Node3";
            treeNode630.Text = "LDUtilities";
            treeNode631.Name = "Node0";
            treeNode631.Text = "Version 1.0.0.78";
            treeNode632.Name = "Node1";
            treeNode632.Text = "Handle more than 100 drawables (rasterization)";
            treeNode633.Name = "Node0";
            treeNode633.Text = "LDScollBars";
            treeNode634.Name = "Node2";
            treeNode634.Text = "Version 1.0.0.77";
            treeNode635.Name = "Node1";
            treeNode635.Text = "Record sound from a microphone";
            treeNode636.Name = "Node0";
            treeNode636.Text = "LDSound";
            treeNode637.Name = "Node3";
            treeNode637.Text = "AnimateOpacity method added (flashing)";
            treeNode638.Name = "Node0";
            treeNode638.Text = "AnimateRotation method added (continuous rotation)";
            treeNode639.Name = "Node1";
            treeNode639.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode640.Name = "Node2";
            treeNode640.Text = "LDShapes";
            treeNode641.Name = "Node2";
            treeNode641.Text = "Version 1.0.0.76";
            treeNode642.Name = "Node1";
            treeNode642.Text = "AddAnimatedImage can use an ImageList image";
            treeNode643.Name = "Node0";
            treeNode643.Text = "LDShapes";
            treeNode644.Name = "Node0";
            treeNode644.Text = "Version 1.0.0.75";
            treeNode645.Name = "Node1";
            treeNode645.Text = "Initial graph axes scaling improvement";
            treeNode646.Name = "Node0";
            treeNode646.Text = "LDGraph";
            treeNode647.Name = "Node3";
            treeNode647.Text = "Methods to access a bluetooth device";
            treeNode648.Name = "Node0";
            treeNode648.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode649.Name = "Node2";
            treeNode649.Text = "LDBlueTooth";
            treeNode650.Name = "Node1";
            treeNode650.Text = "getFocus handles multiple LDWindows";
            treeNode651.Name = "Node0";
            treeNode651.Text = "LDFocus";
            treeNode652.Name = "Node0";
            treeNode652.Text = "Version 1.0.0.74";
            treeNode653.Name = "Node1";
            treeNode653.Text = "First pass at a generic USB (HID) device controller";
            treeNode654.Name = "Node0";
            treeNode654.Text = "LDHID";
            treeNode655.Name = "Node9";
            treeNode655.Text = "Version 1.0.0.73";
            treeNode656.Name = "Node8";
            treeNode656.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode657.Name = "Node7";
            treeNode657.Text = "LDGraph";
            treeNode658.Name = "Node6";
            treeNode658.Text = "Version 1.0.0.72";
            treeNode659.Name = "Node4";
            treeNode659.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode660.Name = "Node5";
            treeNode660.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode661.Name = "Node3";
            treeNode661.Text = "LDGraph";
            treeNode662.Name = "Node2";
            treeNode662.Text = "Version 1.0.0.71";
            treeNode663.Name = "Node1";
            treeNode663.Text = "Spurious error message fixed";
            treeNode664.Name = "Node2";
            treeNode664.Text = "CreateTrend data series creation method added";
            treeNode665.Name = "Node0";
            treeNode665.Text = "LDGraph";
            treeNode666.Name = "Node2";
            treeNode666.Text = "Version 1.0.0.70";
            treeNode667.Name = "Node1";
            treeNode667.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode668.Name = "Node0";
            treeNode668.Text = "LDControls";
            treeNode669.Name = "Node3";
            treeNode669.Text = "Version 1.0.0.69";
            treeNode670.Name = "Node2";
            treeNode670.Text = "Radio button control added";
            treeNode671.Name = "Node1";
            treeNode671.Text = "LDControls";
            treeNode672.Name = "Node0";
            treeNode672.Text = "Version 1.0.0.68";
            treeNode673.Name = "Node1";
            treeNode673.Text = "Bug fix for Copy";
            treeNode674.Name = "Node0";
            treeNode674.Text = "LDArray";
            treeNode675.Name = "Node2";
            treeNode675.Text = "Version 1.0.0.67";
            treeNode676.Name = "Node1";
            treeNode676.Text = "RegexMatch and RegexReplace methods added";
            treeNode677.Name = "Node0";
            treeNode677.Text = "LDUtilities";
            treeNode678.Name = "Node3";
            treeNode678.Text = "Version 1.0.0.66";
            treeNode679.Name = "Node2";
            treeNode679.Text = "Number culture conversions added";
            treeNode680.Name = "Node1";
            treeNode680.Text = "LDUtilities";
            treeNode681.Name = "Node0";
            treeNode681.Text = "Version 1.0.0.65";
            treeNode682.Name = "Node1";
            treeNode682.Text = "IsNumber method added";
            treeNode683.Name = "Node0";
            treeNode683.Text = "LDUtilities";
            treeNode684.Name = "Node2";
            treeNode684.Text = "Version 1.0.0.64";
            treeNode685.Name = "Node1";
            treeNode685.Text = "SetCursorPosition method added for textboxes";
            treeNode686.Name = "Node0";
            treeNode686.Text = "LDControls";
            treeNode687.Name = "Node4";
            treeNode687.Text = "Version 1.0.0.63";
            treeNode688.Name = "Node1";
            treeNode688.Text = "SetCursorToEnd method added for textboxes";
            treeNode689.Name = "Node3";
            treeNode689.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode690.Name = "Node0";
            treeNode690.Text = "LDControls";
            treeNode691.Name = "Node2";
            treeNode691.Text = "Version 1.0.0.62";
            treeNode692.Name = "Node1";
            treeNode692.Text = "Adding polygons not located at (0,0) corrected";
            treeNode693.Name = "Node0";
            treeNode693.Text = "LDPhysics";
            treeNode694.Name = "Node2";
            treeNode694.Text = "Version 1.0.0.61";
            treeNode695.Name = "Node1";
            treeNode695.Text = "GetFolder dialog added";
            treeNode696.Name = "Node0";
            treeNode696.Text = "LDDialogs";
            treeNode697.Name = "Node0";
            treeNode697.Text = "Version 1.0.0.60";
            treeNode698.Name = "Node10";
            treeNode698.Text = "Possible localization issue with Font size fixed";
            treeNode699.Name = "Node9";
            treeNode699.Text = "LDDialogs";
            treeNode700.Name = "Node8";
            treeNode700.Text = "Version 1.0.0.59";
            treeNode701.Name = "Node3";
            treeNode701.Text = "More internationalization fixes";
            treeNode702.Name = "Node2";
            treeNode702.Text = "ShowPrintPreview property added";
            treeNode703.Name = "Node1";
            treeNode703.Text = "LDUtilities";
            treeNode704.Name = "Node5";
            treeNode704.Text = "Possible error with gradient drawings fixed";
            treeNode705.Name = "Node4";
            treeNode705.Text = "LDShapes";
            treeNode706.Name = "Node7";
            treeNode706.Text = "Possible Listen event initialisation error fixed";
            treeNode707.Name = "Node6";
            treeNode707.Text = "LDSpeech";
            treeNode708.Name = "Node0";
            treeNode708.Text = "Version 1.0.0.58";
            treeNode709.Name = "Node7";
            treeNode709.Text = "Many possible internationisation issues fixed";
            treeNode710.Name = "Node4";
            treeNode710.Text = "Version 1.0.0.57";
            treeNode711.Name = "Node1";
            treeNode711.Text = "Emmisive colour correction for AddGeometry";
            treeNode712.Name = "Node2";
            treeNode712.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode713.Name = "Node0";
            treeNode713.Text = "LD3DView";
            treeNode714.Name = "Node1";
            treeNode714.Text = "CSVdeminiator property added";
            treeNode715.Name = "Node0";
            treeNode715.Text = "LDUtilities";
            treeNode716.Name = "Node5";
            treeNode716.Text = "Version 1.0.0.56";
            treeNode717.Name = "Node1";
            treeNode717.Text = "Improved error reporting";
            treeNode718.Name = "Node2";
            treeNode718.Text = "Culture invariant type conversions";
            treeNode719.Name = "Node1";
            treeNode719.Text = "LD3DView";
            treeNode720.Name = "Node4";
            treeNode720.Text = "ShowErrors method added";
            treeNode721.Name = "Node3";
            treeNode721.Text = "LDUtilities";
            treeNode722.Name = "Node0";
            treeNode722.Text = "Version 1.0.0.55";
            treeNode723.Name = "Node4";
            treeNode723.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode724.Name = "Node3";
            treeNode724.Text = "LDScrollBars";
            treeNode725.Name = "Node6";
            treeNode725.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode726.Name = "Node5";
            treeNode726.Text = "LDUtilities";
            treeNode727.Name = "Node2";
            treeNode727.Text = "Version 1.0.0.54";
            treeNode728.Name = "Node1";
            treeNode728.Text = "Debug window can be resized";
            treeNode729.Name = "Node0";
            treeNode729.Text = "LDDebug";
            treeNode730.Name = "Node1";
            treeNode730.Text = "PrintFile method added";
            treeNode731.Name = "Node0";
            treeNode731.Text = "LDFile";
            treeNode732.Name = "Node2";
            treeNode732.Text = "Version 1.0.0.53";
            treeNode733.Name = "Node1";
            treeNode733.Text = "SSL property option added";
            treeNode734.Name = "Node0";
            treeNode734.Text = "LDEmail";
            treeNode735.Name = "Node0";
            treeNode735.Text = "Version 1.0.0.52";
            treeNode736.Name = "Node1";
            treeNode736.Text = "Right Click Context menu added for any shape or control";
            treeNode737.Name = "Node0";
            treeNode737.Text = "LDControls";
            treeNode738.Name = "Node0";
            treeNode738.Text = "Version 1.0.0.51";
            treeNode739.Name = "Node1";
            treeNode739.Text = "Right click dropdown menu option added";
            treeNode740.Name = "Node0";
            treeNode740.Text = "LDDialogs";
            treeNode741.Name = "Node0";
            treeNode741.Text = "Version 1.0.0.50";
            treeNode742.Name = "Node1";
            treeNode742.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode743.Name = "Node0";
            treeNode743.Text = "LD3DView";
            treeNode744.Name = "Node0";
            treeNode744.Text = "Version 1.0.0.49";
            treeNode745.Name = "Node1";
            treeNode745.Text = "Performance improvements (some camera controls for this)";
            treeNode746.Name = "Node1";
            treeNode746.Text = "LoadModel (*.3ds) files added";
            treeNode747.Name = "Node0";
            treeNode747.Text = "LD3DView";
            treeNode748.Name = "Node3";
            treeNode748.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode749.Name = "Node2";
            treeNode749.Text = "LDShapes";
            treeNode750.Name = "Node0";
            treeNode750.Text = "Version 1.0.0.48";
            treeNode751.Name = "Node1";
            treeNode751.Text = "Some improvements including animations";
            treeNode752.Name = "Node0";
            treeNode752.Text = "LD3DView";
            treeNode753.Name = "Node0";
            treeNode753.Text = "Version 1.0.0.47";
            treeNode754.Name = "Node1";
            treeNode754.Text = "Some improvemts and new methods";
            treeNode755.Name = "Node0";
            treeNode755.Text = "LD3Dview";
            treeNode756.Name = "Node2";
            treeNode756.Text = "Version 1.0.0.46";
            treeNode757.Name = "Node1";
            treeNode757.Text = "A start at a 3D set of methods";
            treeNode758.Name = "Node0";
            treeNode758.Text = "LD3DView";
            treeNode759.Name = "Node10";
            treeNode759.Text = "Version 1.0.0.45";
            treeNode760.Name = "Node1";
            treeNode760.Text = "Create scrollbars for the GraphicsWindow";
            treeNode761.Name = "Node5";
            treeNode761.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode762.Name = "Node0";
            treeNode762.Text = "LDScrollBars";
            treeNode763.Name = "Node4";
            treeNode763.Text = "ColourList method added";
            treeNode764.Name = "Node3";
            treeNode764.Text = "LDUtilities";
            treeNode765.Name = "Node8";
            treeNode765.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode766.Name = "Node9";
            treeNode766.Text = "BackgroundImage method to set the background added";
            treeNode767.Name = "Node6";
            treeNode767.Text = "LDShapes";
            treeNode768.Name = "Node0";
            treeNode768.Text = "Version 1.0.0.44";
            treeNode769.Name = "Node1";
            treeNode769.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode770.Name = "Node0";
            treeNode770.Text = "LDUtilities";
            treeNode771.Name = "Node0";
            treeNode771.Text = "Version 1.0.0.43";
            treeNode772.Name = "Node1";
            treeNode772.Text = "Call Subs as functions with arguments";
            treeNode773.Name = "Node0";
            treeNode773.Text = "LDCall";
            treeNode774.Name = "Node0";
            treeNode774.Text = "Version 1.0.0.42";
            treeNode775.Name = "Node1";
            treeNode775.Text = "Font dialog added";
            treeNode776.Name = "Node2";
            treeNode776.Text = "Colours dialog moved here from LDColours";
            treeNode777.Name = "Node0";
            treeNode777.Text = "LDDialogs";
            treeNode778.Name = "Node9";
            treeNode778.Text = "Version 1.0.0.41";
            treeNode779.Name = "Node1";
            treeNode779.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode780.Name = "Node7";
            treeNode780.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode781.Name = "Node8";
            treeNode781.Text = "Some methods renamed";
            treeNode782.Name = "Node0";
            treeNode782.Text = "LDControls";
            treeNode783.Name = "Node3";
            treeNode783.Text = "HighScore method move here";
            treeNode784.Name = "Node2";
            treeNode784.Text = "LDNetwork";
            treeNode785.Name = "Node6";
            treeNode785.Text = "SetSize method added";
            treeNode786.Name = "Node5";
            treeNode786.Text = "LDShapes";
            treeNode787.Name = "Node3";
            treeNode787.Text = "Version 1.0.0.40";
            treeNode788.Name = "Node1";
            treeNode788.Text = "SelectTreeView method added";
            treeNode789.Name = "Node2";
            treeNode789.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode790.Name = "Node0";
            treeNode790.Text = "LDDialogs";
            treeNode791.Name = "Node1";
            treeNode791.Text = "Simple high score web method";
            treeNode792.Name = "Node0";
            treeNode792.Text = "LDHighScore";
            treeNode793.Name = "Node3";
            treeNode793.Text = "Version 1.0.0.39";
            treeNode794.Name = "Node2";
            treeNode794.Text = "RichTextBox methods improved";
            treeNode795.Name = "Node1";
            treeNode795.Text = "LDDialogs";
            treeNode796.Name = "Node1";
            treeNode796.Text = "Search, Load and Save methods added";
            treeNode797.Name = "Node0";
            treeNode797.Text = "LDArray";
            treeNode798.Name = "Node0";
            treeNode798.Text = "Version 1.0.0.38";
            treeNode799.Name = "Node1";
            treeNode799.Text = "Depreciated";
            treeNode800.Name = "Node0";
            treeNode800.Text = "LDWeather";
            treeNode801.Name = "Node1";
            treeNode801.Text = "Renamed from LDTrig and some more methods added";
            treeNode802.Name = "Node0";
            treeNode802.Text = "LDMath";
            treeNode803.Name = "Node3";
            treeNode803.Text = "RichTextBox method added";
            treeNode804.Name = "Node2";
            treeNode804.Text = "LDDialogs";
            treeNode805.Name = "Node5";
            treeNode805.Text = "FontList method added";
            treeNode806.Name = "Node4";
            treeNode806.Text = "LDUtilities";
            treeNode807.Name = "Node2";
            treeNode807.Text = "Version 1.0.0.37";
            treeNode808.Name = "Node1";
            treeNode808.Text = "Zip method extended";
            treeNode809.Name = "Node0";
            treeNode809.Text = "LDUtilities";
            treeNode810.Name = "Node2";
            treeNode810.Text = "Version 1.0.0.36";
            treeNode811.Name = "Node1";
            treeNode811.Text = "Collapse and expand treeview nodes method added";
            treeNode812.Name = "Node0";
            treeNode812.Text = "LDDialogs";
            treeNode813.Name = "Node5";
            treeNode813.Text = "Version 1.0.0.35";
            treeNode814.Name = "Node1";
            treeNode814.Text = "Arguments added to Start method";
            treeNode815.Name = "Node0";
            treeNode815.Text = "LDProcess";
            treeNode816.Name = "Node4";
            treeNode816.Text = "Zip compression methods added";
            treeNode817.Name = "Node2";
            treeNode817.Text = "LDUtilities";
            treeNode818.Name = "Node2";
            treeNode818.Text = "Version 1.0.0.34";
            treeNode819.Name = "Node1";
            treeNode819.Text = "GWStyle property added";
            treeNode820.Name = "Node0";
            treeNode820.Text = "LDUtilities";
            treeNode821.Name = "Node1";
            treeNode821.Text = "TreeView and associated events added";
            treeNode822.Name = "Node0";
            treeNode822.Text = "LDDialogs";
            treeNode823.Name = "Node0";
            treeNode823.Text = "Version 1.0.0.33";
            treeNode824.Name = "Node1";
            treeNode824.Text = "Possible end points not plotting bug fixed";
            treeNode825.Name = "Node0";
            treeNode825.Text = "LDGraph";
            treeNode826.Name = "Node2";
            treeNode826.Text = "Version 1.0.0.32";
            treeNode827.Name = "Node1";
            treeNode827.Text = "Activated event and Active property addded";
            treeNode828.Name = "Node0";
            treeNode828.Text = "LDWindows";
            treeNode829.Name = "Node0";
            treeNode829.Text = "Version 1.0.0.31";
            treeNode830.Name = "Node1";
            treeNode830.Text = "Create multiple GraphicsWindows";
            treeNode831.Name = "Node0";
            treeNode831.Text = "LDWindows";
            treeNode832.Name = "Node0";
            treeNode832.Text = "Version 1.0.0.30";
            treeNode833.Name = "Node1";
            treeNode833.Text = "Email sending method";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDMail";
            treeNode835.Name = "Node1";
            treeNode835.Text = "Add and Multiply methods bug fixed";
            treeNode836.Name = "Node2";
            treeNode836.Text = "Image statistics combined into one method";
            treeNode837.Name = "Node3";
            treeNode837.Text = "Histogram method added";
            treeNode838.Name = "Node0";
            treeNode838.Text = "LDImage";
            treeNode839.Name = "Node0";
            treeNode839.Text = "Version 1.0.0.29";
            treeNode840.Name = "Node1";
            treeNode840.Text = "SnapshotToImageList method added";
            treeNode841.Name = "Node0";
            treeNode841.Text = "LDWebCam";
            treeNode842.Name = "Node3";
            treeNode842.Text = "ImageList image manipulation methods";
            treeNode843.Name = "Node2";
            treeNode843.Text = "LDImage";
            treeNode844.Name = "Node0";
            treeNode844.Text = "Version 1.0.0.28";
            treeNode845.Name = "Node1";
            treeNode845.Text = "SortIndex bugfix for null values";
            treeNode846.Name = "Node0";
            treeNode846.Text = "LDArray";
            treeNode847.Name = "Node1";
            treeNode847.Text = "SnapshotToFile bug fixed";
            treeNode848.Name = "Node0";
            treeNode848.Text = "LDWebCam";
            treeNode849.Name = "Node0";
            treeNode849.Text = "Version 1.0.0.27";
            treeNode850.Name = "Node1";
            treeNode850.Text = "SortIndex method added";
            treeNode851.Name = "Node0";
            treeNode851.Text = "LDArray";
            treeNode852.Name = "Node1";
            treeNode852.Text = "Web based weather report data added";
            treeNode853.Name = "Node0";
            treeNode853.Text = "LDWeather";
            treeNode854.Name = "Node3";
            treeNode854.Text = "DataReceived event added";
            treeNode855.Name = "Node2";
            treeNode855.Text = "LDCommPort";
            treeNode856.Name = "Node0";
            treeNode856.Text = "Version 1.0.0.26";
            treeNode857.Name = "Node1";
            treeNode857.Text = "Speech recognition added";
            treeNode858.Name = "Node0";
            treeNode858.Text = "LDSpeech";
            treeNode859.Name = "Node0";
            treeNode859.Text = "Version 1.0.0.25";
            treeNode860.Name = "Node4";
            treeNode860.Text = "More methods added and some internal code optimised";
            treeNode861.Name = "Node0";
            treeNode861.Text = "LDArray & LDMatrix";
            treeNode862.Name = "Node1";
            treeNode862.Text = "KeyDown method added";
            treeNode863.Name = "Node0";
            treeNode863.Text = "LDUtilities";
            treeNode864.Name = "Node1";
            treeNode864.Text = "GetAllShapesAt method added";
            treeNode865.Name = "Node0";
            treeNode865.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode866.Name = "Node0";
            treeNode866.Text = "LDShapes";
            treeNode867.Name = "Node0";
            treeNode867.Text = "Version 1.0.0.24";
            treeNode868.Name = "Node1";
            treeNode868.Text = "OpenFile and SaveFile dialogs added";
            treeNode869.Name = "Node0";
            treeNode869.Text = "LDDialogs";
            treeNode870.Name = "Node2";
            treeNode870.Text = "Matrix methods, for example to solve linear equations";
            treeNode871.Name = "Node1";
            treeNode871.Text = "LDMatrix";
            treeNode872.Name = "Node0";
            treeNode872.Text = "Version 1.0.0.23";
            treeNode873.Name = "Node1";
            treeNode873.Text = "Sorting method added";
            treeNode874.Name = "Node0";
            treeNode874.Text = "LDArray";
            treeNode875.Name = "Node0";
            treeNode875.Text = "Version 1.0.0.22";
            treeNode876.Name = "Node2";
            treeNode876.Text = "Velocity Threshold setting added";
            treeNode877.Name = "Node1";
            treeNode877.Text = "LDPhysics";
            treeNode878.Name = "Node0";
            treeNode878.Text = "Version 1.0.0.21";
            treeNode879.Name = "Node3";
            treeNode879.Text = "SetDamping method added";
            treeNode880.Name = "Node2";
            treeNode880.Text = "LDPhysics";
            treeNode881.Name = "Node1";
            treeNode881.Text = "Version 1.0.0.20";
            treeNode882.Name = "Node1";
            treeNode882.Text = "Instrument name can be obtained from its number";
            treeNode883.Name = "Node0";
            treeNode883.Text = "LDMusic";
            treeNode884.Name = "Node0";
            treeNode884.Text = "Version 1.0.0.19";
            treeNode885.Name = "Node1";
            treeNode885.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode886.Name = "Node0";
            treeNode886.Text = "LDDialogs";
            treeNode887.Name = "Node1";
            treeNode887.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode888.Name = "Node2";
            treeNode888.Text = "Notes can also be played synchronously (chords)";
            treeNode889.Name = "Node0";
            treeNode889.Text = "LDMusic";
            treeNode890.Name = "Node0";
            treeNode890.Text = "Version 1.0.0.18";
            treeNode891.Name = "Node1";
            treeNode891.Text = "AnimationPause and AnimationResume methods added";
            treeNode892.Name = "Node0";
            treeNode892.Text = "LDShapes";
            treeNode893.Name = "Node1";
            treeNode893.Text = "Process list indexed by ID rather than name";
            treeNode894.Name = "Node0";
            treeNode894.Text = "LDProcess";
            treeNode895.Name = "Node1";
            treeNode895.Text = "Version 1.0.0.17";
            treeNode896.Name = "Node1";
            treeNode896.Text = "More effects added";
            treeNode897.Name = "Node0";
            treeNode897.Text = "LDWebCam";
            treeNode898.Name = "Node1";
            treeNode898.Text = "Add or change an image on a button or image shape";
            treeNode899.Name = "Node1";
            treeNode899.Text = "Add an animated gif or tiled image";
            treeNode900.Name = "Node0";
            treeNode900.Text = "LDShapes";
            treeNode901.Name = "Node0";
            treeNode901.Text = "Version 1.0.0.16";
            treeNode902.Name = "Node1";
            treeNode902.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode903.Name = "Node0";
            treeNode903.Text = "LDWebCam";
            treeNode904.Name = "Node0";
            treeNode904.Text = "Version 1.0.0.15";
            treeNode905.Name = "Node2";
            treeNode905.Text = "Variables may be changed during a debug session";
            treeNode906.Name = "Node1";
            treeNode906.Text = "LDDebug";
            treeNode907.Name = "Node0";
            treeNode907.Text = "Version 1.0.0.14";
            treeNode908.Name = "Node1";
            treeNode908.Text = "A basic debugging tool";
            treeNode909.Name = "Node0";
            treeNode909.Text = "LDDebug";
            treeNode910.Name = "Node0";
            treeNode910.Text = "Version 1.0.0.13";
            treeNode911.Name = "Node2";
            treeNode911.Text = "Methods to convert between HSL and RGB";
            treeNode912.Name = "Node18";
            treeNode912.Text = "Method to set colour opacity";
            treeNode913.Name = "Node19";
            treeNode913.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode914.Name = "Node1";
            treeNode914.Text = "LDColours";
            treeNode915.Name = "Node4";
            treeNode915.Text = "Methods to add and subtract dates and times";
            treeNode916.Name = "Node3";
            treeNode916.Text = "LDDateTime";
            treeNode917.Name = "Node6";
            treeNode917.Text = "Waiting overlay, Calendar and About popups";
            treeNode918.Name = "Node17";
            treeNode918.Text = "Tooltips";
            treeNode919.Name = "Node5";
            treeNode919.Text = "LDDialogs";
            treeNode920.Name = "Node8";
            treeNode920.Text = "File change event";
            treeNode921.Name = "Node7";
            treeNode921.Text = "LDEvents";
            treeNode922.Name = "Node0";
            treeNode922.Text = "Version 1.0.0.12";
            treeNode923.Name = "Node12";
            treeNode923.Text = "Methods to sort arrays by index or value";
            treeNode924.Name = "Node22";
            treeNode924.Text = "Sorting by number and character strings";
            treeNode925.Name = "Node11";
            treeNode925.Text = "LDSort";
            treeNode926.Name = "Node14";
            treeNode926.Text = "Statistics on any array and distribution generation";
            treeNode927.Name = "Node20";
            treeNode927.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode928.Name = "Node21";
            treeNode928.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode929.Name = "Node13";
            treeNode929.Text = "LDStatistics";
            treeNode930.Name = "Node16";
            treeNode930.Text = "Voice and volume added";
            treeNode931.Name = "Node15";
            treeNode931.Text = "LDSpeech";
            treeNode932.Name = "Node9";
            treeNode932.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode41,
            treeNode52,
            treeNode67,
            treeNode82,
            treeNode95,
            treeNode104,
            treeNode119,
            treeNode130,
            treeNode144,
            treeNode153,
            treeNode165,
            treeNode176,
            treeNode179,
            treeNode188,
            treeNode195,
            treeNode202,
            treeNode215,
            treeNode226,
            treeNode231,
            treeNode238,
            treeNode241,
            treeNode255,
            treeNode263,
            treeNode269,
            treeNode284,
            treeNode299,
            treeNode305,
            treeNode313,
            treeNode328,
            treeNode345,
            treeNode348,
            treeNode354,
            treeNode360,
            treeNode370,
            treeNode379,
            treeNode382,
            treeNode402,
            treeNode408,
            treeNode411,
            treeNode420,
            treeNode428,
            treeNode434,
            treeNode439,
            treeNode445,
            treeNode448,
            treeNode461,
            treeNode464,
            treeNode469,
            treeNode474,
            treeNode477,
            treeNode483,
            treeNode487,
            treeNode490,
            treeNode496,
            treeNode500,
            treeNode508,
            treeNode514,
            treeNode520,
            treeNode523,
            treeNode530,
            treeNode537,
            treeNode545,
            treeNode548,
            treeNode551,
            treeNode557,
            treeNode562,
            treeNode569,
            treeNode574,
            treeNode580,
            treeNode583,
            treeNode590,
            treeNode595,
            treeNode599,
            treeNode612,
            treeNode620,
            treeNode625,
            treeNode631,
            treeNode634,
            treeNode641,
            treeNode644,
            treeNode652,
            treeNode655,
            treeNode658,
            treeNode662,
            treeNode666,
            treeNode669,
            treeNode672,
            treeNode675,
            treeNode678,
            treeNode681,
            treeNode684,
            treeNode687,
            treeNode691,
            treeNode694,
            treeNode697,
            treeNode700,
            treeNode708,
            treeNode710,
            treeNode716,
            treeNode722,
            treeNode727,
            treeNode732,
            treeNode735,
            treeNode738,
            treeNode741,
            treeNode744,
            treeNode750,
            treeNode753,
            treeNode756,
            treeNode759,
            treeNode768,
            treeNode771,
            treeNode774,
            treeNode778,
            treeNode787,
            treeNode793,
            treeNode798,
            treeNode807,
            treeNode810,
            treeNode813,
            treeNode818,
            treeNode823,
            treeNode826,
            treeNode829,
            treeNode832,
            treeNode839,
            treeNode844,
            treeNode849,
            treeNode856,
            treeNode859,
            treeNode867,
            treeNode872,
            treeNode875,
            treeNode878,
            treeNode881,
            treeNode884,
            treeNode890,
            treeNode895,
            treeNode901,
            treeNode904,
            treeNode907,
            treeNode910,
            treeNode922,
            treeNode932});
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