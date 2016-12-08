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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode21,
            treeNode27,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35,
            treeNode37,
            treeNode39,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode47,
            treeNode51,
            treeNode53,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode66,
            treeNode68,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode76,
            treeNode78,
            treeNode81,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode92});
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode89,
            treeNode91,
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode99,
            treeNode101,
            treeNode104,
            treeNode106,
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode112,
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode117,
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode114,
            treeNode116,
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode123,
            treeNode125,
            treeNode127,
            treeNode129,
            treeNode131,
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode135,
            treeNode136,
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode138,
            treeNode140,
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode148,
            treeNode149,
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode152,
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode145,
            treeNode147,
            treeNode151,
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode157,
            treeNode159,
            treeNode161,
            treeNode163,
            treeNode165});
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode176});
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode171,
            treeNode173,
            treeNode175,
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode183});
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode180,
            treeNode182,
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode190});
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode187,
            treeNode189,
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode193,
            treeNode194});
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode196,
            treeNode197,
            treeNode198,
            treeNode199});
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode201});
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode203});
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode195,
            treeNode200,
            treeNode202,
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode206});
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode208});
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode214});
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode207,
            treeNode209,
            treeNode211,
            treeNode213,
            treeNode215});
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode217});
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode219});
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode218,
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode225,
            treeNode227});
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode229});
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode232,
            treeNode233,
            treeNode234,
            treeNode235});
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode237,
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode240,
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode236,
            treeNode239,
            treeNode242,
            treeNode244});
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode249});
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode248,
            treeNode250,
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode254,
            treeNode255});
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode256,
            treeNode258});
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode260,
            treeNode261,
            treeNode262,
            treeNode263,
            treeNode264});
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode266,
            treeNode267,
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode265,
            treeNode269,
            treeNode271,
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode277});
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode279});
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode281});
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode276,
            treeNode278,
            treeNode280,
            treeNode282,
            treeNode284,
            treeNode286,
            treeNode288});
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode290,
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode292,
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode296});
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode298,
            treeNode299,
            treeNode300,
            treeNode301});
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode297,
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode306,
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode305,
            treeNode308,
            treeNode311,
            treeNode313,
            treeNode315,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode322});
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode326,
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode321,
            treeNode323,
            treeNode325,
            treeNode328,
            treeNode330,
            treeNode332,
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode339,
            treeNode340});
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode341,
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode345,
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode347,
            treeNode349});
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode352,
            treeNode353,
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode358});
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode355,
            treeNode357,
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode361});
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode367});
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode362,
            treeNode364,
            treeNode366,
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode370});
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode373,
            treeNode374});
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode376,
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode379});
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode381,
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode390});
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode375,
            treeNode378,
            treeNode380,
            treeNode383,
            treeNode385,
            treeNode387,
            treeNode389,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode393,
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode395,
            treeNode397});
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode399});
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode406,
            treeNode407,
            treeNode408});
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode403,
            treeNode405,
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode413,
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode412,
            treeNode415,
            treeNode417});
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode421,
            treeNode422});
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode420,
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode425});
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode426,
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode432,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode431,
            treeNode434});
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode437});
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode439,
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode448,
            treeNode449});
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode441,
            treeNode443,
            treeNode445,
            treeNode447,
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode452});
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode455});
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode457});
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode456,
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode461,
            treeNode463});
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode468,
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode470,
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode474,
            treeNode475});
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode478});
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode481,
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode484});
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode483,
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode487,
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode491});
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode493});
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode495,
            treeNode496});
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode492,
            treeNode494,
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode501,
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode500,
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode505,
            treeNode506,
            treeNode507,
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode512});
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode515,
            treeNode517,
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode522,
            treeNode524,
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode532,
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode529,
            treeNode531,
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode536});
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode539});
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode542});
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode544,
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode543,
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode548,
            treeNode549,
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode557});
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode554,
            treeNode556,
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode561,
            treeNode563});
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode565});
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode567,
            treeNode568});
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode566,
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode575,
            treeNode577,
            treeNode579});
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode582,
            treeNode584});
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode586,
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode599,
            treeNode600});
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode590,
            treeNode592,
            treeNode594,
            treeNode596,
            treeNode598,
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode603,
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode606});
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode608});
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode605,
            treeNode607,
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode612,
            treeNode614});
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode616,
            treeNode617});
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode618,
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode622});
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode627,
            treeNode628,
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode626,
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode637,
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode636,
            treeNode639,
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode649,
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode653,
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode660});
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode669});
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode678,
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode688});
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode691,
            treeNode693,
            treeNode695,
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode701,
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode703,
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode707,
            treeNode709,
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode714,
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode719,
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode723});
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode733});
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode735,
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode737,
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode744});
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode748});
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode750,
            treeNode751});
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode755,
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode752,
            treeNode754,
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode765,
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode769,
            treeNode770,
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode772,
            treeNode774,
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode778,
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode780,
            treeNode782});
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode785,
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode790,
            treeNode792,
            treeNode794,
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode805,
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode810,
            treeNode812});
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode820});
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode825,
            treeNode826,
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode824,
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode831,
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode836,
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode840});
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode841,
            treeNode843,
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode854,
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode851,
            treeNode853,
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode859,
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode863});
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode866});
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode875});
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode877,
            treeNode878});
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode876,
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode882,
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode888,
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode887,
            treeNode890});
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode892});
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode895});
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode899});
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode901,
            treeNode902,
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode905});
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode907,
            treeNode908});
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode904,
            treeNode906,
            treeNode909,
            treeNode911});
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode913,
            treeNode914});
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode916,
            treeNode917,
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode920});
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode915,
            treeNode919,
            treeNode921});
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
            treeNode16.Name = "Node0";
            treeNode16.Text = "General";
            treeNode17.Name = "Node0";
            treeNode17.Text = "Version 1.2.14.0";
            treeNode18.Name = "Node2";
            treeNode18.Text = "TEMP tables allowed for SQLite databases";
            treeNode19.Name = "Node1";
            treeNode19.Text = "LDDataBase";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode21.Name = "Node0";
            treeNode21.Text = "LDMath";
            treeNode22.Name = "Node1";
            treeNode22.Text = "NormalMap method added for normal map 3D effects";
            treeNode23.Name = "Node2";
            treeNode23.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode24.Name = "Node5";
            treeNode24.Text = "MakeTransparent method added";
            treeNode25.Name = "Node6";
            treeNode25.Text = "ReplaceColour method added";
            treeNode26.Name = "Node0";
            treeNode26.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode27.Name = "Node0";
            treeNode27.Text = "LDImage";
            treeNode28.Name = "Node4";
            treeNode28.Text = "All image pixel manipulations speeded up";
            treeNode29.Name = "Node7";
            treeNode29.Text = "More Culture Invariace fixes";
            treeNode30.Name = "Node3";
            treeNode30.Text = "General";
            treeNode31.Name = "Node0";
            treeNode31.Text = "Version 1.2.13.0";
            treeNode32.Name = "Node1";
            treeNode32.Text = "Base conversions extended to include bases up to 36";
            treeNode33.Name = "Node0";
            treeNode33.Text = "LDMath";
            treeNode34.Name = "Node3";
            treeNode34.Text = "Updated to new Bing API";
            treeNode35.Name = "Node2";
            treeNode35.Text = "LDSearch";
            treeNode36.Name = "Node1";
            treeNode36.Text = "ShowInTaskbar property added";
            treeNode37.Name = "Node0";
            treeNode37.Text = "LDGraphicsWindow";
            treeNode38.Name = "Node1";
            treeNode38.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode39.Name = "Node0";
            treeNode39.Text = "LDFile";
            treeNode40.Name = "Node1";
            treeNode40.Text = "ToArray and FromArray methods added";
            treeNode41.Name = "Node0";
            treeNode41.Text = "LDxml";
            treeNode42.Name = "Node0";
            treeNode42.Text = "Version 1.2.12.0";
            treeNode43.Name = "Node2";
            treeNode43.Text = "DataViewColumnWidths method added";
            treeNode44.Name = "Node3";
            treeNode44.Text = "DataViewRowColours method added";
            treeNode45.Name = "Node1";
            treeNode45.Text = "LDControls";
            treeNode46.Name = "Node1";
            treeNode46.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode47.Name = "Node0";
            treeNode47.Text = "General";
            treeNode48.Name = "Node1";
            treeNode48.Text = "SetCentre method added";
            treeNode49.Name = "Node4";
            treeNode49.Text = "A 3rd rotation added";
            treeNode50.Name = "Node3";
            treeNode50.Text = "BoundingBox method added";
            treeNode51.Name = "Node0";
            treeNode51.Text = "LD3DView";
            treeNode52.Name = "Node3";
            treeNode52.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode53.Name = "Node2";
            treeNode53.Text = "LDDatabase";
            treeNode54.Name = "Node1";
            treeNode54.Text = "PlayMusic2 method added";
            treeNode55.Name = "Node2";
            treeNode55.Text = "Channel parameter added";
            treeNode56.Name = "Node0";
            treeNode56.Text = "LDMusic";
            treeNode57.Name = "Node0";
            treeNode57.Text = "Version 1.2.11.0";
            treeNode58.Name = "Node1";
            treeNode58.Text = "SetButtonStyle method added";
            treeNode59.Name = "Node0";
            treeNode59.Text = "LDControls";
            treeNode60.Name = "Node1";
            treeNode60.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode61.Name = "Node2";
            treeNode61.Text = "SetBillBoard method added";
            treeNode62.Name = "Node0";
            treeNode62.Text = "GetCameraUpDirection method added";
            treeNode63.Name = "Node1";
            treeNode63.Text = "Gradient brushes can be used";
            treeNode64.Name = "Node2";
            treeNode64.Text = "AutoControl method added";
            treeNode65.Name = "Node0";
            treeNode65.Text = "SpecularExponent property added";
            treeNode66.Name = "Node0";
            treeNode66.Text = "LD3DView";
            treeNode67.Name = "Node1";
            treeNode67.Text = "AddText method to annotate an image with text added";
            treeNode68.Name = "Node0";
            treeNode68.Text = "LDImage";
            treeNode69.Name = "Node4";
            treeNode69.Text = "BrushText for text on a brush added";
            treeNode70.Name = "Node0";
            treeNode70.Text = "Skew shapes method added";
            treeNode71.Name = "Node3";
            treeNode71.Text = "LDShapes";
            treeNode72.Name = "Node0";
            treeNode72.Text = "Version 1.2.10.0";
            treeNode73.Name = "Node1";
            treeNode73.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode74.Name = "Node0";
            treeNode74.Text = "LDUnits";
            treeNode75.Name = "Node1";
            treeNode75.Text = "Possible issue with FixSigFig fixed";
            treeNode76.Name = "Node0";
            treeNode76.Text = "LDMath";
            treeNode77.Name = "Node3";
            treeNode77.Text = "GetIndex method added (for SB arrays)";
            treeNode78.Name = "Node2";
            treeNode78.Text = "LDArray";
            treeNode79.Name = "Node5";
            treeNode79.Text = "Resize mode property added";
            treeNode80.Name = "Node6";
            treeNode80.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode81.Name = "Node4";
            treeNode81.Text = "LDGraphicsWindow";
            treeNode82.Name = "Node8";
            treeNode82.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode83.Name = "Node9";
            treeNode83.Text = "DataViewAllowUserEntry method added";
            treeNode84.Name = "Node7";
            treeNode84.Text = "LDControls";
            treeNode85.Name = "Node0";
            treeNode85.Text = "Version 1.2.9.0";
            treeNode86.Name = "Node1";
            treeNode86.Text = "New extended math object, starting with FFT";
            treeNode87.Name = "Node0";
            treeNode87.Text = "LDMathX";
            treeNode88.Name = "Node1";
            treeNode88.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode89.Name = "Node0";
            treeNode89.Text = "LDControls";
            treeNode90.Name = "Node3";
            treeNode90.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode91.Name = "Node2";
            treeNode91.Text = "LDArray";
            treeNode92.Name = "Node5";
            treeNode92.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode93.Name = "Node4";
            treeNode93.Text = "LDList";
            treeNode94.Name = "Node0";
            treeNode94.Text = "Version 1.2.8.0";
            treeNode95.Name = "Node2";
            treeNode95.Text = "Error handling, additional settings and multiple ports supported";
            treeNode96.Name = "Node1";
            treeNode96.Text = "LDCommPort";
            treeNode97.Name = "Node1";
            treeNode97.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode98.Name = "Node1";
            treeNode98.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode99.Name = "Node0";
            treeNode99.Text = "LDImage and LDWebCam";
            treeNode100.Name = "Node1";
            treeNode100.Text = "Bitwise operations object added";
            treeNode101.Name = "Node0";
            treeNode101.Text = "LDBits";
            treeNode102.Name = "Node1";
            treeNode102.Text = "Extended text encoding property added";
            treeNode103.Name = "Node0";
            treeNode103.Text = "TextWindow colours can be changed";
            treeNode104.Name = "Node0";
            treeNode104.Text = "LDTextWindow";
            treeNode105.Name = "Node1";
            treeNode105.Text = "GetWorkingImagePixelARGB method added";
            treeNode106.Name = "Node0";
            treeNode106.Text = "LDImage";
            treeNode107.Name = "Node1";
            treeNode107.Text = "RasteriseTurtleLines method added";
            treeNode108.Name = "Node0";
            treeNode108.Text = "LDShapes";
            treeNode109.Name = "Node0";
            treeNode109.Text = "Version 1.2.7.0";
            treeNode110.Name = "Node1";
            treeNode110.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode111.Name = "Node0";
            treeNode111.Text = "LDDialogs";
            treeNode112.Name = "Node1";
            treeNode112.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode113.Name = "Node2";
            treeNode113.Text = "ToggleSensor added";
            treeNode114.Name = "Node0";
            treeNode114.Text = "LDPhysics";
            treeNode115.Name = "Node1";
            treeNode115.Text = "Allow multiple copies of the webcam image";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDWebCam";
            treeNode117.Name = "Node1";
            treeNode117.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode118.Name = "Node0";
            treeNode118.Text = "MetaData method added";
            treeNode119.Name = "Node0";
            treeNode119.Text = "LDImage";
            treeNode120.Name = "Node0";
            treeNode120.Text = "Version 1.2.6.0";
            treeNode121.Name = "Node2";
            treeNode121.Text = "FixSigFig and FixDecimal methods added";
            treeNode122.Name = "Node3";
            treeNode122.Text = "MinNumber and MaxNumber properties added";
            treeNode123.Name = "Node1";
            treeNode123.Text = "LDMath";
            treeNode124.Name = "Node1";
            treeNode124.Text = "SliderMaximum property added";
            treeNode125.Name = "Node0";
            treeNode125.Text = "LDControls";
            treeNode126.Name = "Node1";
            treeNode126.Text = "ZoomAll method added";
            treeNode127.Name = "Node0";
            treeNode127.Text = "LDShapes";
            treeNode128.Name = "Node1";
            treeNode128.Text = "Reposition methods and properties added";
            treeNode129.Name = "Node0";
            treeNode129.Text = "LDGraphicsWindow";
            treeNode130.Name = "Node1";
            treeNode130.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDImage";
            treeNode132.Name = "Node1";
            treeNode132.Text = "MouseScroll parameter added";
            treeNode133.Name = "Node0";
            treeNode133.Text = "LDScrollBars";
            treeNode134.Name = "Node0";
            treeNode134.Text = "Version 1.2.5.0";
            treeNode135.Name = "Node0";
            treeNode135.Text = "New object added (previously a separate extension)";
            treeNode136.Name = "Node1";
            treeNode136.Text = "Async, Loop, Volume and Pan properties added";
            treeNode137.Name = "Node2";
            treeNode137.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode138.Name = "Node1";
            treeNode138.Text = "LDWaveForm";
            treeNode139.Name = "Node1";
            treeNode139.Text = "New object added to get input from gamepads or joysticks";
            treeNode140.Name = "Node0";
            treeNode140.Text = "LDController";
            treeNode141.Name = "Node1";
            treeNode141.Text = "RayCast method added";
            treeNode142.Name = "Node0";
            treeNode142.Text = "LDPhysics";
            treeNode143.Name = "Node0";
            treeNode143.Text = "Version 1.2.4.0";
            treeNode144.Name = "Node2";
            treeNode144.Text = "New object to apply effects to any shape or control";
            treeNode145.Name = "Node1";
            treeNode145.Text = "LDEffects";
            treeNode146.Name = "Node1";
            treeNode146.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode147.Name = "Node0";
            treeNode147.Text = "LDFigures";
            treeNode148.Name = "Node1";
            treeNode148.Text = "SetGroup method added";
            treeNode149.Name = "Node2";
            treeNode149.Text = "GetContacts method added";
            treeNode150.Name = "Node0";
            treeNode150.Text = "GetAllShapesAt method added";
            treeNode151.Name = "Node0";
            treeNode151.Text = "LDPhysics";
            treeNode152.Name = "Node2";
            treeNode152.Text = "SetImage handles images with transparency";
            treeNode153.Name = "Node0";
            treeNode153.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode154.Name = "Node1";
            treeNode154.Text = "LDClipboard";
            treeNode155.Name = "Node0";
            treeNode155.Text = "Version 1.2.3.0";
            treeNode156.Name = "Node2";
            treeNode156.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode157.Name = "Node1";
            treeNode157.Text = "LDShapes";
            treeNode158.Name = "Node4";
            treeNode158.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode159.Name = "Node3";
            treeNode159.Text = "LDFile";
            treeNode160.Name = "Node6";
            treeNode160.Text = "NewImage method added";
            treeNode161.Name = "Node5";
            treeNode161.Text = "LDImage";
            treeNode162.Name = "Node1";
            treeNode162.Text = "SetStartupPosition method added to position dialogs";
            treeNode163.Name = "Node0";
            treeNode163.Text = "LDDialogs";
            treeNode164.Name = "Node1";
            treeNode164.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode165.Name = "Node0";
            treeNode165.Text = "LDGraph";
            treeNode166.Name = "Node0";
            treeNode166.Text = "Version 1.2.2.0";
            treeNode167.Name = "Node2";
            treeNode167.Text = "Recompiled for Small Basic version 1.2";
            treeNode168.Name = "Node1";
            treeNode168.Text = "Version 1.2";
            treeNode169.Name = "Node0";
            treeNode169.Text = "Version 1.2.0.1";
            treeNode170.Name = "Node2";
            treeNode170.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode171.Name = "Node1";
            treeNode171.Text = "LDDialogs";
            treeNode172.Name = "Node1";
            treeNode172.Text = "Logical operations object added";
            treeNode173.Name = "Node0";
            treeNode173.Text = "LDLogic";
            treeNode174.Name = "Node4";
            treeNode174.Text = "CurrentCulture property added";
            treeNode175.Name = "Node3";
            treeNode175.Text = "LDUtilities";
            treeNode176.Name = "Node6";
            treeNode176.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode177.Name = "Node5";
            treeNode177.Text = "LDMath";
            treeNode178.Name = "Node0";
            treeNode178.Text = "Version 1.1.0.8";
            treeNode179.Name = "Node1";
            treeNode179.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode180.Name = "Node0";
            treeNode180.Text = "LDControls";
            treeNode181.Name = "Node1";
            treeNode181.Text = "Methods added to add and remove nodes and save xml file";
            treeNode182.Name = "Node0";
            treeNode182.Text = "LDxml";
            treeNode183.Name = "Node1";
            treeNode183.Text = "MusicPlayTime moved from LDFile";
            treeNode184.Name = "Node0";
            treeNode184.Text = "LDSound";
            treeNode185.Name = "Node0";
            treeNode185.Text = "Version 1.1.0.7";
            treeNode186.Name = "Node4";
            treeNode186.Text = "SplitImage method added";
            treeNode187.Name = "Node3";
            treeNode187.Text = "LDImage";
            treeNode188.Name = "Node6";
            treeNode188.Text = "EditTable and SaveTable methods added";
            treeNode189.Name = "Node5";
            treeNode189.Text = "LDDatabse";
            treeNode190.Name = "Node2";
            treeNode190.Text = "DataView control and methods added";
            treeNode191.Name = "Node1";
            treeNode191.Text = "LDControls";
            treeNode192.Name = "Node2";
            treeNode192.Text = "Version 1.1.0.6";
            treeNode193.Name = "Node2";
            treeNode193.Text = "Exists modified to check for directory as well as file";
            treeNode194.Name = "Node3";
            treeNode194.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode195.Name = "Node1";
            treeNode195.Text = "LDFile";
            treeNode196.Name = "Node5";
            treeNode196.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode197.Name = "Node6";
            treeNode197.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode198.Name = "Node9";
            treeNode198.Text = "Conditonal break point added";
            treeNode199.Name = "Node0";
            treeNode199.Text = "Step over button added";
            treeNode200.Name = "Node4";
            treeNode200.Text = "LDDebug";
            treeNode201.Name = "Node8";
            treeNode201.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode202.Name = "Node7";
            treeNode202.Text = "LDGraphicsWindow";
            treeNode203.Name = "Node1";
            treeNode203.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode204.Name = "Node0";
            treeNode204.Text = "LDResources";
            treeNode205.Name = "Node0";
            treeNode205.Text = "Version 1.1.0.5";
            treeNode206.Name = "Node2";
            treeNode206.Text = "ClipboardChanged event added";
            treeNode207.Name = "Node1";
            treeNode207.Text = "LDClipboard";
            treeNode208.Name = "Node1";
            treeNode208.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode209.Name = "Node0";
            treeNode209.Text = "LDFile";
            treeNode210.Name = "Node3";
            treeNode210.Text = "SetActive method added";
            treeNode211.Name = "Node2";
            treeNode211.Text = "LDGraphicsWindow";
            treeNode212.Name = "Node1";
            treeNode212.Text = "Parse xml file nodes";
            treeNode213.Name = "Node0";
            treeNode213.Text = "LDxml";
            treeNode214.Name = "Node3";
            treeNode214.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode215.Name = "Node2";
            treeNode215.Text = "General";
            treeNode216.Name = "Node0";
            treeNode216.Text = "Version 1.1.0.4";
            treeNode217.Name = "Node2";
            treeNode217.Text = "WakeAll method addded";
            treeNode218.Name = "Node1";
            treeNode218.Text = "LDPhysics";
            treeNode219.Name = "Node1";
            treeNode219.Text = "Clipboard methods added";
            treeNode220.Name = "Node0";
            treeNode220.Text = "LDClipboard";
            treeNode221.Name = "Node0";
            treeNode221.Text = "Version 1.1.0.3";
            treeNode222.Name = "Node6";
            treeNode222.Text = "SizeNWSE cursor added";
            treeNode223.Name = "Node5";
            treeNode223.Text = "LDCursors";
            treeNode224.Name = "Node8";
            treeNode224.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode225.Name = "Node7";
            treeNode225.Text = "LDGraph";
            treeNode226.Name = "Node1";
            treeNode226.Text = "SQLite updated for .Net 4.5";
            treeNode227.Name = "Node0";
            treeNode227.Text = "LDDataBase";
            treeNode228.Name = "Node4";
            treeNode228.Text = "Version 1.1.0.2";
            treeNode229.Name = "Node3";
            treeNode229.Text = "Recompiled for Small Basic version 1.1";
            treeNode230.Name = "Node2";
            treeNode230.Text = "Version 1.1";
            treeNode231.Name = "Node0";
            treeNode231.Text = "Version 1.1.0.1";
            treeNode232.Name = "Node12";
            treeNode232.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode233.Name = "Node13";
            treeNode233.Text = "RichTextBoxMargins method added";
            treeNode234.Name = "Node0";
            treeNode234.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode235.Name = "Node1";
            treeNode235.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode236.Name = "Node11";
            treeNode236.Text = "LDControls";
            treeNode237.Name = "Node3";
            treeNode237.Text = "Error reporting added";
            treeNode238.Name = "Node4";
            treeNode238.Text = "SetEncoding method added";
            treeNode239.Name = "Node2";
            treeNode239.Text = "LDCommPort";
            treeNode240.Name = "Node6";
            treeNode240.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode241.Name = "Node7";
            treeNode241.Text = "Export to excel fix for graph with no title";
            treeNode242.Name = "Node5";
            treeNode242.Text = "LDGraph";
            treeNode243.Name = "Node9";
            treeNode243.Text = "Negative restitution option when adding moving shape";
            treeNode244.Name = "Node8";
            treeNode244.Text = "LDPhysics";
            treeNode245.Name = "Node10";
            treeNode245.Text = "Version 1.0.0.133";
            treeNode246.Name = "Node2";
            treeNode246.Text = "Internal improvements to auto messaging";
            treeNode247.Name = "Node9";
            treeNode247.Text = "Name can be set and GetClients method added";
            treeNode248.Name = "Node1";
            treeNode248.Text = "LDClient";
            treeNode249.Name = "Node4";
            treeNode249.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode250.Name = "Node3";
            treeNode250.Text = "LDControls";
            treeNode251.Name = "Node8";
            treeNode251.Text = "Return message and possible file error fixed for Stop method";
            treeNode252.Name = "Node7";
            treeNode252.Text = "LDSound";
            treeNode253.Name = "Node0";
            treeNode253.Text = "Version 1.0.0.132";
            treeNode254.Name = "Node2";
            treeNode254.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode255.Name = "Node5";
            treeNode255.Text = "Compile method added to compile a Small Basic program";
            treeNode256.Name = "Node1";
            treeNode256.Text = "LDCall";
            treeNode257.Name = "Node4";
            treeNode257.Text = "Methods and code by Pappa Lapub added";
            treeNode258.Name = "Node3";
            treeNode258.Text = "LDShell";
            treeNode259.Name = "Node0";
            treeNode259.Text = "Version 1.0.0.131";
            treeNode260.Name = "Node6";
            treeNode260.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode261.Name = "Node7";
            treeNode261.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode262.Name = "Node8";
            treeNode262.Text = "Refactoring of all the pan, follow and box methods";
            treeNode263.Name = "Node6";
            treeNode263.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode264.Name = "Node8";
            treeNode264.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode265.Name = "Node5";
            treeNode265.Text = "LDPhysics";
            treeNode266.Name = "Node1";
            treeNode266.Text = "UseBinary property added";
            treeNode267.Name = "Node2";
            treeNode267.Text = "DoAsync property and associated completion events added";
            treeNode268.Name = "Node3";
            treeNode268.Text = "Delete method added";
            treeNode269.Name = "Node0";
            treeNode269.Text = "LDftp";
            treeNode270.Name = "Node5";
            treeNode270.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode271.Name = "Node4";
            treeNode271.Text = "LDCall";
            treeNode272.Name = "Node2";
            treeNode272.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode273.Name = "Node1";
            treeNode273.Text = "LDControls";
            treeNode274.Name = "Node4";
            treeNode274.Text = "Version 1.0.0.130";
            treeNode275.Name = "Node2";
            treeNode275.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode276.Name = "Node1";
            treeNode276.Text = "LDMath";
            treeNode277.Name = "Node1";
            treeNode277.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode278.Name = "Node0";
            treeNode278.Text = "LDPhysics";
            treeNode279.Name = "Node3";
            treeNode279.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode280.Name = "Node2";
            treeNode280.Text = "LDGraphicsWindow";
            treeNode281.Name = "Node1";
            treeNode281.Text = "FTP object methods added";
            treeNode282.Name = "Node0";
            treeNode282.Text = "LDftp";
            treeNode283.Name = "Node3";
            treeNode283.Text = "An existing file is replaced";
            treeNode284.Name = "Node2";
            treeNode284.Text = "LDZip";
            treeNode285.Name = "Node1";
            treeNode285.Text = "Size method added";
            treeNode286.Name = "Node0";
            treeNode286.Text = "LDFile";
            treeNode287.Name = "Node3";
            treeNode287.Text = "DownloadFile method added";
            treeNode288.Name = "Node2";
            treeNode288.Text = "LDNetwork";
            treeNode289.Name = "Node0";
            treeNode289.Text = "Version 1.0.0.129";
            treeNode290.Name = "Node2";
            treeNode290.Text = "Generalised joint connections added";
            treeNode291.Name = "Node0";
            treeNode291.Text = "AddExplosion method added";
            treeNode292.Name = "Node1";
            treeNode292.Text = "LDPhysics";
            treeNode293.Name = "Node1";
            treeNode293.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode294.Name = "Node0";
            treeNode294.Text = "LDShapes";
            treeNode295.Name = "Node0";
            treeNode295.Text = "Version 1.0.0.128";
            treeNode296.Name = "Node2";
            treeNode296.Text = "CheckServer method added";
            treeNode297.Name = "Node1";
            treeNode297.Text = "LDClient";
            treeNode298.Name = "Node1";
            treeNode298.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode299.Name = "Node2";
            treeNode299.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode300.Name = "Node3";
            treeNode300.Text = "GetAngle method added";
            treeNode301.Name = "Node4";
            treeNode301.Text = "Top-down tire (to model a car from above) methods added";
            treeNode302.Name = "Node0";
            treeNode302.Text = "LDPhysics";
            treeNode303.Name = "Node0";
            treeNode303.Text = "Version 1.0.0.127";
            treeNode304.Name = "Node7";
            treeNode304.Text = "Bug fixes for Overlap methods";
            treeNode305.Name = "Node6";
            treeNode305.Text = "LDShapes";
            treeNode306.Name = "Node0";
            treeNode306.Text = "Bug fix for multiple numeric sorts";
            treeNode307.Name = "Node9";
            treeNode307.Text = "ByValueWithIndex method added";
            treeNode308.Name = "Node8";
            treeNode308.Text = "LDSort";
            treeNode309.Name = "Node1";
            treeNode309.Text = "LAN method added to get local IP addresses";
            treeNode310.Name = "Node2";
            treeNode310.Text = "Ping method added";
            treeNode311.Name = "Node0";
            treeNode311.Text = "LDNetwork";
            treeNode312.Name = "Node1";
            treeNode312.Text = "LoadSVG method added";
            treeNode313.Name = "Node0";
            treeNode313.Text = "LDImage";
            treeNode314.Name = "Node3";
            treeNode314.Text = "Evaluate method added";
            treeNode315.Name = "Node2";
            treeNode315.Text = "LDMath";
            treeNode316.Name = "Node5";
            treeNode316.Text = "IncludeJScript method added";
            treeNode317.Name = "Node4";
            treeNode317.Text = "LDInline";
            treeNode318.Name = "Node5";
            treeNode318.Text = "Version 1.0.0.126";
            treeNode319.Name = "Node0";
            treeNode319.Text = "Special emphasis on async consistency";
            treeNode320.Name = "Node4";
            treeNode320.Text = "Simplified auto method for multi-player game data transfer";
            treeNode321.Name = "Node9";
            treeNode321.Text = "LDServer and LDClient objects added";
            treeNode322.Name = "Node2";
            treeNode322.Text = "GetWidth and GetHeight methods added";
            treeNode323.Name = "Node1";
            treeNode323.Text = "LDText";
            treeNode324.Name = "Node4";
            treeNode324.Text = "Bing web search";
            treeNode325.Name = "Node3";
            treeNode325.Text = "LDSearch";
            treeNode326.Name = "Node6";
            treeNode326.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode327.Name = "Node7";
            treeNode327.Text = "KeyScroll property added";
            treeNode328.Name = "Node5";
            treeNode328.Text = "LDScrollBars";
            treeNode329.Name = "Node9";
            treeNode329.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode330.Name = "Node8";
            treeNode330.Text = "LDShapes";
            treeNode331.Name = "Node1";
            treeNode331.Text = "SaveAs method bug fixed";
            treeNode332.Name = "Node0";
            treeNode332.Text = "LDImage";
            treeNode333.Name = "Node3";
            treeNode333.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode334.Name = "Node2";
            treeNode334.Text = "LDQueue";
            treeNode335.Name = "Node8";
            treeNode335.Text = "Version 1.0.0.125";
            treeNode336.Name = "Node7";
            treeNode336.Text = "Language translation object added";
            treeNode337.Name = "Node6";
            treeNode337.Text = "LDTranslate";
            treeNode338.Name = "Node5";
            treeNode338.Text = "Version 1.0.0.124";
            treeNode339.Name = "Node1";
            treeNode339.Text = "Mouse screen coordinate conversion parameters added";
            treeNode340.Name = "Node2";
            treeNode340.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode341.Name = "Node0";
            treeNode341.Text = "LDGraphicsWindow";
            treeNode342.Name = "Node4";
            treeNode342.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode343.Name = "Node3";
            treeNode343.Text = "LDUtilities";
            treeNode344.Name = "Node0";
            treeNode344.Text = "Version 1.0.0.123";
            treeNode345.Name = "Node5";
            treeNode345.Text = "ColorMatrix method added";
            treeNode346.Name = "Node0";
            treeNode346.Text = "Rotate method added";
            treeNode347.Name = "Node3";
            treeNode347.Text = "LDImage";
            treeNode348.Name = "Node1";
            treeNode348.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode349.Name = "Node0";
            treeNode349.Text = "LDChart";
            treeNode350.Name = "Node2";
            treeNode350.Text = "Version 1.0.0.122";
            treeNode351.Name = "Node2";
            treeNode351.Text = "EffectGamma added to darken and lighten";
            treeNode352.Name = "Node4";
            treeNode352.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode353.Name = "Node3";
            treeNode353.Text = "EffectContrast modified";
            treeNode354.Name = "Node0";
            treeNode354.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode355.Name = "Node1";
            treeNode355.Text = "LDImage";
            treeNode356.Name = "Node2";
            treeNode356.Text = "Error event added for all extension exceptions";
            treeNode357.Name = "Node1";
            treeNode357.Text = "LDEvents";
            treeNode358.Name = "Node1";
            treeNode358.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode359.Name = "Node0";
            treeNode359.Text = "LDMath";
            treeNode360.Name = "Node0";
            treeNode360.Text = "Version 1.0.0.121";
            treeNode361.Name = "Node2";
            treeNode361.Text = "FloodFill transparency effect fixed";
            treeNode362.Name = "Node1";
            treeNode362.Text = "LDGraphicsWindow";
            treeNode363.Name = "Node1";
            treeNode363.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode364.Name = "Node0";
            treeNode364.Text = "LDFile";
            treeNode365.Name = "Node1";
            treeNode365.Text = "EffectPixelate added";
            treeNode366.Name = "Node0";
            treeNode366.Text = "LDImage";
            treeNode367.Name = "Node1";
            treeNode367.Text = "Modified to work with Windows 8";
            treeNode368.Name = "Node0";
            treeNode368.Text = "LDWebCam";
            treeNode369.Name = "Node0";
            treeNode369.Text = "Version 1.0.0.120";
            treeNode370.Name = "Node2";
            treeNode370.Text = "FloodFill method added";
            treeNode371.Name = "Node1";
            treeNode371.Text = "LDGraphicsWindow";
            treeNode372.Name = "Node0";
            treeNode372.Text = "Version 1.0.0.119";
            treeNode373.Name = "Node0";
            treeNode373.Text = "SetShapeCursor method added";
            treeNode374.Name = "Node11";
            treeNode374.Text = "CreateCursor method added";
            treeNode375.Name = "Node9";
            treeNode375.Text = "LDCursors";
            treeNode376.Name = "Node2";
            treeNode376.Text = "SaveAs method to save in different file formats";
            treeNode377.Name = "Node0";
            treeNode377.Text = "Parameters added for some effects";
            treeNode378.Name = "Node1";
            treeNode378.Text = "LDImage";
            treeNode379.Name = "Node2";
            treeNode379.Text = "Parameters added for some effects";
            treeNode380.Name = "Node1";
            treeNode380.Text = "LDWebCam";
            treeNode381.Name = "Node1";
            treeNode381.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode382.Name = "Node0";
            treeNode382.Text = "SetFontFromFile method added for ttf fonts";
            treeNode383.Name = "Node0";
            treeNode383.Text = "LDGraphicsWindow";
            treeNode384.Name = "Node3";
            treeNode384.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode385.Name = "Node2";
            treeNode385.Text = "LDTextWindow";
            treeNode386.Name = "Node2";
            treeNode386.Text = "Zip methods moved here from LDUtilities";
            treeNode387.Name = "Node0";
            treeNode387.Text = "LDZip";
            treeNode388.Name = "Node3";
            treeNode388.Text = "Regex methods moved here from LDUtilities";
            treeNode389.Name = "Node1";
            treeNode389.Text = "LDRegex";
            treeNode390.Name = "Node1";
            treeNode390.Text = "ListViewRowCount method added";
            treeNode391.Name = "Node0";
            treeNode391.Text = "LDControls";
            treeNode392.Name = "Node3";
            treeNode392.Text = "Version 1.0.0.118";
            treeNode393.Name = "Node5";
            treeNode393.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode394.Name = "Node6";
            treeNode394.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode395.Name = "Node4";
            treeNode395.Text = "LDUtilities";
            treeNode396.Name = "Node10";
            treeNode396.Text = "SetUserCursor method added";
            treeNode397.Name = "Node4";
            treeNode397.Text = "LDCursors";
            treeNode398.Name = "Node3";
            treeNode398.Text = "Version 1.0.0.117";
            treeNode399.Name = "Node2";
            treeNode399.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode400.Name = "Node1";
            treeNode400.Text = "LDDictionary";
            treeNode401.Name = "Node0";
            treeNode401.Text = "Version 1.0.0.116";
            treeNode402.Name = "Node2";
            treeNode402.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode403.Name = "Node1";
            treeNode403.Text = "LDColours";
            treeNode404.Name = "Node4";
            treeNode404.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode405.Name = "Node3";
            treeNode405.Text = "LDShapes";
            treeNode406.Name = "Node1";
            treeNode406.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode407.Name = "Node0";
            treeNode407.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode408.Name = "Node1";
            treeNode408.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode409.Name = "Node0";
            treeNode409.Text = "LDGraph";
            treeNode410.Name = "Node0";
            treeNode410.Text = "Version 1.0.0.115";
            treeNode411.Name = "Node2";
            treeNode411.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode412.Name = "Node1";
            treeNode412.Text = "LDControls";
            treeNode413.Name = "Node4";
            treeNode413.Text = "RemoveTurtleLines method added";
            treeNode414.Name = "Node6";
            treeNode414.Text = "GetAllShapes method added";
            treeNode415.Name = "Node3";
            treeNode415.Text = "LDShapes";
            treeNode416.Name = "Node1";
            treeNode416.Text = "Odbc connection added";
            treeNode417.Name = "Node0";
            treeNode417.Text = "LDDatabase";
            treeNode418.Name = "Node0";
            treeNode418.Text = "Version 1.0.0.114";
            treeNode419.Name = "Node2";
            treeNode419.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode420.Name = "Node1";
            treeNode420.Text = "LDUtilities";
            treeNode421.Name = "Node4";
            treeNode421.Text = "ListView control added";
            treeNode422.Name = "Node5";
            treeNode422.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode423.Name = "Node3";
            treeNode423.Text = "LDControls";
            treeNode424.Name = "Node0";
            treeNode424.Text = "Version 1.0.0.113";
            treeNode425.Name = "Node2";
            treeNode425.Text = "Tone method added";
            treeNode426.Name = "Node1";
            treeNode426.Text = "LDSound";
            treeNode427.Name = "Node5";
            treeNode427.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode428.Name = "Node4";
            treeNode428.Text = "LDControls";
            treeNode429.Name = "Node0";
            treeNode429.Text = "Version 1.0.0.112";
            treeNode430.Name = "Node2";
            treeNode430.Text = "SqlServer and Access database support added";
            treeNode431.Name = "Node1";
            treeNode431.Text = "LDDataBase";
            treeNode432.Name = "Node4";
            treeNode432.Text = "FixFlickr method added";
            treeNode433.Name = "Node0";
            treeNode433.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode434.Name = "Node3";
            treeNode434.Text = "LDUtilities";
            treeNode435.Name = "Node0";
            treeNode435.Text = "Version 1.0.0.111";
            treeNode436.Name = "Node2";
            treeNode436.Text = "TextBoxTab method added";
            treeNode437.Name = "Node1";
            treeNode437.Text = "LDControls";
            treeNode438.Name = "Node0";
            treeNode438.Text = "Version 1.0.0.110";
            treeNode439.Name = "Node1";
            treeNode439.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode440.Name = "Node3";
            treeNode440.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode441.Name = "Node0";
            treeNode441.Text = "General";
            treeNode442.Name = "Node5";
            treeNode442.Text = "Exists method added to check if a file path exists or not";
            treeNode443.Name = "Node4";
            treeNode443.Text = "LDFile";
            treeNode444.Name = "Node7";
            treeNode444.Text = "Start method handles attaching to existing process without warning";
            treeNode445.Name = "Node6";
            treeNode445.Text = "LDProcess";
            treeNode446.Name = "Node1";
            treeNode446.Text = "MySQL database support added";
            treeNode447.Name = "Node0";
            treeNode447.Text = "LDDatabase";
            treeNode448.Name = "Node3";
            treeNode448.Text = "Add and Multiply methods honour transparency";
            treeNode449.Name = "Node4";
            treeNode449.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode450.Name = "Node2";
            treeNode450.Text = "LDImage";
            treeNode451.Name = "Node3";
            treeNode451.Text = "Version 1.0.0.109";
            treeNode452.Name = "Node2";
            treeNode452.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode453.Name = "Node1";
            treeNode453.Text = "LDTextWindow";
            treeNode454.Name = "Node0";
            treeNode454.Text = "Version 1.0.0.108";
            treeNode455.Name = "Node14";
            treeNode455.Text = "Transparent colour added";
            treeNode456.Name = "Node13";
            treeNode456.Text = "LDColours";
            treeNode457.Name = "Node16";
            treeNode457.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode458.Name = "Node15";
            treeNode458.Text = "LDDialogs";
            treeNode459.Name = "Node12";
            treeNode459.Text = "Version 1.0.0.107";
            treeNode460.Name = "Node8";
            treeNode460.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode461.Name = "Node7";
            treeNode461.Text = "LDControls";
            treeNode462.Name = "Node11";
            treeNode462.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode463.Name = "Node10";
            treeNode463.Text = "LDShapes";
            treeNode464.Name = "Node6";
            treeNode464.Text = "Version 1.0.0.106";
            treeNode465.Name = "Node5";
            treeNode465.Text = "Menu control added";
            treeNode466.Name = "Node4";
            treeNode466.Text = "LDControls";
            treeNode467.Name = "Node3";
            treeNode467.Text = "Version 1.0.0.105";
            treeNode468.Name = "Node5";
            treeNode468.Text = "ZipList method added";
            treeNode469.Name = "Node2";
            treeNode469.Text = "GetNextMapIndex method added";
            treeNode470.Name = "Node4";
            treeNode470.Text = "LDUtilities";
            treeNode471.Name = "Node1";
            treeNode471.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode472.Name = "Node0";
            treeNode472.Text = "LDShapes";
            treeNode473.Name = "Node3";
            treeNode473.Text = "Version 1.0.0.104";
            treeNode474.Name = "Node1";
            treeNode474.Text = "Transparency maintained for various methods";
            treeNode475.Name = "Node2";
            treeNode475.Text = "Effects bug fixed";
            treeNode476.Name = "Node0";
            treeNode476.Text = "LDImage";
            treeNode477.Name = "Node0";
            treeNode477.Text = "Version 1.0.0.103";
            treeNode478.Name = "Node1";
            treeNode478.Text = "Current application assemblies are all auto-referenced";
            treeNode479.Name = "Node0";
            treeNode479.Text = "LDInline";
            treeNode480.Name = "Node5";
            treeNode480.Text = "Version 1.0.0.102";
            treeNode481.Name = "Node1";
            treeNode481.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode482.Name = "Node2";
            treeNode482.Text = "LDInline.sb sample provided";
            treeNode483.Name = "Node0";
            treeNode483.Text = "LDInline";
            treeNode484.Name = "Node4";
            treeNode484.Text = "ExitButtonMode method added to control window close button state";
            treeNode485.Name = "Node3";
            treeNode485.Text = "LDUtilities";
            treeNode486.Name = "Node0";
            treeNode486.Text = "Version 1.0.0.101";
            treeNode487.Name = "Node1";
            treeNode487.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode488.Name = "Node0";
            treeNode488.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode489.Name = "Node0";
            treeNode489.Text = "LDTextWindow";
            treeNode490.Name = "Node0";
            treeNode490.Text = "Version 1.0.0.100";
            treeNode491.Name = "Node2";
            treeNode491.Text = "ReadANSIToArray method added";
            treeNode492.Name = "Node1";
            treeNode492.Text = "LDFile";
            treeNode493.Name = "Node1";
            treeNode493.Text = "DocumentViewer control added";
            treeNode494.Name = "Node0";
            treeNode494.Text = "LDControls";
            treeNode495.Name = "Node3";
            treeNode495.Text = "An object to batch update shapes (for speed reasons)";
            treeNode496.Name = "Node0";
            treeNode496.Text = "LDFastShapes.sb sample included";
            treeNode497.Name = "Node2";
            treeNode497.Text = "LDFastShapes";
            treeNode498.Name = "Node0";
            treeNode498.Text = "Version 1.0.0.99";
            treeNode499.Name = "Node1";
            treeNode499.Text = "Rendering performance improvements when many shapes present";
            treeNode500.Name = "Node0";
            treeNode500.Text = "LDPhysics";
            treeNode501.Name = "Node1";
            treeNode501.Text = "ANSItoUTF8 method added";
            treeNode502.Name = "Node2";
            treeNode502.Text = "ReadANSI method added";
            treeNode503.Name = "Node0";
            treeNode503.Text = "LDFile";
            treeNode504.Name = "Node1";
            treeNode504.Text = "Version 1.0.0.98";
            treeNode505.Name = "Node3";
            treeNode505.Text = "Move method added for tiangles, polygons and lines";
            treeNode506.Name = "Node4";
            treeNode506.Text = "RotateAbout method added";
            treeNode507.Name = "Node1";
            treeNode507.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode508.Name = "Node0";
            treeNode508.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode509.Name = "Node2";
            treeNode509.Text = "LDShapes";
            treeNode510.Name = "Node0";
            treeNode510.Text = "Version 1.0.0.97";
            treeNode511.Name = "Node4";
            treeNode511.Text = "A list storage object added";
            treeNode512.Name = "Node3";
            treeNode512.Text = "LDList";
            treeNode513.Name = "Node2";
            treeNode513.Text = "Version 1.0.0.96";
            treeNode514.Name = "Node4";
            treeNode514.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode515.Name = "Node3";
            treeNode515.Text = "LDQueue";
            treeNode516.Name = "Node6";
            treeNode516.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode517.Name = "Node5";
            treeNode517.Text = "LDNetwork";
            treeNode518.Name = "Node0";
            treeNode518.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode519.Name = "Node1";
            treeNode519.Text = "General";
            treeNode520.Name = "Node2";
            treeNode520.Text = "Version 1.0.0.95";
            treeNode521.Name = "Node2";
            treeNode521.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode522.Name = "Node1";
            treeNode522.Text = "LDEncryption";
            treeNode523.Name = "Node1";
            treeNode523.Text = "RandomNumberSeed property added";
            treeNode524.Name = "Node0";
            treeNode524.Text = "LDMath";
            treeNode525.Name = "Node1";
            treeNode525.Text = "SetGameData and GetGameData methods added";
            treeNode526.Name = "Node0";
            treeNode526.Text = "LDNetwork";
            treeNode527.Name = "Node0";
            treeNode527.Text = "Version 1.0.0.94";
            treeNode528.Name = "Node1";
            treeNode528.Text = "SliderGetValue method added";
            treeNode529.Name = "Node0";
            treeNode529.Text = "LDControls";
            treeNode530.Name = "Node5";
            treeNode530.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode531.Name = "Node2";
            treeNode531.Text = "LDUtilities";
            treeNode532.Name = "Node3";
            treeNode532.Text = "Encrypt and Decrypt methods added";
            treeNode533.Name = "Node4";
            treeNode533.Text = "MD5Hash method added";
            treeNode534.Name = "Node6";
            treeNode534.Text = "LDEncryption";
            treeNode535.Name = "Node0";
            treeNode535.Text = "Version 1.0.0.93";
            treeNode536.Name = "Node1";
            treeNode536.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode537.Name = "Node0";
            treeNode537.Text = "LDControls";
            treeNode538.Name = "Node0";
            treeNode538.Text = "Version 1.0.0.92";
            treeNode539.Name = "Node2";
            treeNode539.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode540.Name = "Node1";
            treeNode540.Text = "LDControls";
            treeNode541.Name = "Node1";
            treeNode541.Text = "Version 1.0.0.91";
            treeNode542.Name = "Node1";
            treeNode542.Text = "Font method added to modify shapes or controls that have text";
            treeNode543.Name = "Node0";
            treeNode543.Text = "LDShapes";
            treeNode544.Name = "Node1";
            treeNode544.Text = "MediaPlayer control added (play videos etc)";
            treeNode545.Name = "Node0";
            treeNode545.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode546.Name = "Node0";
            treeNode546.Text = "LDControls";
            treeNode547.Name = "Node1";
            treeNode547.Text = "Version 1.0.0.90";
            treeNode548.Name = "Node1";
            treeNode548.Text = "Autosize columns for ListView";
            treeNode549.Name = "Node2";
            treeNode549.Text = "LDDataBase.sb sample updated";
            treeNode550.Name = "Node0";
            treeNode550.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode551.Name = "Node0";
            treeNode551.Text = "LDDataBase";
            treeNode552.Name = "Node0";
            treeNode552.Text = "Version 1.0.0.89";
            treeNode553.Name = "Node4";
            treeNode553.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode554.Name = "Node3";
            treeNode554.Text = "LDScrollBars";
            treeNode555.Name = "Node1";
            treeNode555.Text = "CleanTemp method added";
            treeNode556.Name = "Node0";
            treeNode556.Text = "LDUtilities";
            treeNode557.Name = "Node1";
            treeNode557.Text = "SQLite database methods added";
            treeNode558.Name = "Node0";
            treeNode558.Text = "LDDataBase";
            treeNode559.Name = "Node2";
            treeNode559.Text = "Version 1.0.0.88";
            treeNode560.Name = "Node2";
            treeNode560.Text = "LastError now returns a text error";
            treeNode561.Name = "Node1";
            treeNode561.Text = "LDIOWarrior";
            treeNode562.Name = "Node1";
            treeNode562.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode563.Name = "Node0";
            treeNode563.Text = "LDScrollBars";
            treeNode564.Name = "Node0";
            treeNode564.Text = "Version 1.0.0.87";
            treeNode565.Name = "Node4";
            treeNode565.Text = "SetTurtleImage method added";
            treeNode566.Name = "Node3";
            treeNode566.Text = "LDShapes";
            treeNode567.Name = "Node1";
            treeNode567.Text = "Connect to IOWarrior USB devices";
            treeNode568.Name = "Node0";
            treeNode568.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode569.Name = "Node0";
            treeNode569.Text = "LDIOWarrior";
            treeNode570.Name = "Node2";
            treeNode570.Text = "Version 1.0.0.86";
            treeNode571.Name = "Node1";
            treeNode571.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode572.Name = "Node0";
            treeNode572.Text = "LDShapes";
            treeNode573.Name = "Node2";
            treeNode573.Text = "Version 1.0.0.85";
            treeNode574.Name = "Node4";
            treeNode574.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode575.Name = "Node3";
            treeNode575.Text = "LDFile";
            treeNode576.Name = "Node6";
            treeNode576.Text = "Crop method added";
            treeNode577.Name = "Node5";
            treeNode577.Text = "LDImage";
            treeNode578.Name = "Node1";
            treeNode578.Text = "LastDropFiles bug fixed";
            treeNode579.Name = "Node0";
            treeNode579.Text = "LDControls";
            treeNode580.Name = "Node2";
            treeNode580.Text = "Version 1.0.0.84";
            treeNode581.Name = "Node7";
            treeNode581.Text = "FileDropped event added";
            treeNode582.Name = "Node6";
            treeNode582.Text = "LDControls";
            treeNode583.Name = "Node1";
            treeNode583.Text = "Bug in Split corrected";
            treeNode584.Name = "Node0";
            treeNode584.Text = "LDText";
            treeNode585.Name = "Node5";
            treeNode585.Text = "Version 1.0.0.83";
            treeNode586.Name = "Node3";
            treeNode586.Text = "Title argument removed from AddComboBox";
            treeNode587.Name = "Node4";
            treeNode587.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode588.Name = "Node2";
            treeNode588.Text = "LDControls";
            treeNode589.Name = "Node1";
            treeNode589.Text = "Version 1.0.0.82";
            treeNode590.Name = "Node0";
            treeNode590.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode591.Name = "Node12";
            treeNode591.Text = "Program settings added";
            treeNode592.Name = "Node9";
            treeNode592.Text = "LDSettings";
            treeNode593.Name = "Node11";
            treeNode593.Text = "Get some system paths and user name";
            treeNode594.Name = "Node10";
            treeNode594.Text = "LDFile";
            treeNode595.Name = "Node14";
            treeNode595.Text = "System sounds added";
            treeNode596.Name = "Node13";
            treeNode596.Text = "LDSound";
            treeNode597.Name = "Node16";
            treeNode597.Text = "Binary, octal, hex and decimal conversions";
            treeNode598.Name = "Node15";
            treeNode598.Text = "LDMath";
            treeNode599.Name = "Node1";
            treeNode599.Text = "Replace method added";
            treeNode600.Name = "Node2";
            treeNode600.Text = "FindAll method added";
            treeNode601.Name = "Node0";
            treeNode601.Text = "LDText";
            treeNode602.Name = "Node8";
            treeNode602.Text = "Version 1.0.0.81";
            treeNode603.Name = "Node1";
            treeNode603.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode604.Name = "Node6";
            treeNode604.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode605.Name = "Node0";
            treeNode605.Text = "LDShapes";
            treeNode606.Name = "Node3";
            treeNode606.Text = "Truncate method added";
            treeNode607.Name = "Node2";
            treeNode607.Text = "LDMath";
            treeNode608.Name = "Node5";
            treeNode608.Text = "Additional text methods";
            treeNode609.Name = "Node4";
            treeNode609.Text = "LDText";
            treeNode610.Name = "Node0";
            treeNode610.Text = "Version 1.0.0.80";
            treeNode611.Name = "Node1";
            treeNode611.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode612.Name = "Node0";
            treeNode612.Text = "LDDialogs";
            treeNode613.Name = "Node1";
            treeNode613.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode614.Name = "Node0";
            treeNode614.Text = "LDUtilities";
            treeNode615.Name = "Node6";
            treeNode615.Text = "Version 1.0.0.79";
            treeNode616.Name = "Node2";
            treeNode616.Text = "Rasterize property added";
            treeNode617.Name = "Node5";
            treeNode617.Text = "Improvements associated with window resizing";
            treeNode618.Name = "Node1";
            treeNode618.Text = "LDScrollBars";
            treeNode619.Name = "Node4";
            treeNode619.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode620.Name = "Node3";
            treeNode620.Text = "LDUtilities";
            treeNode621.Name = "Node0";
            treeNode621.Text = "Version 1.0.0.78";
            treeNode622.Name = "Node1";
            treeNode622.Text = "Handle more than 100 drawables (rasterization)";
            treeNode623.Name = "Node0";
            treeNode623.Text = "LDScollBars";
            treeNode624.Name = "Node2";
            treeNode624.Text = "Version 1.0.0.77";
            treeNode625.Name = "Node1";
            treeNode625.Text = "Record sound from a microphone";
            treeNode626.Name = "Node0";
            treeNode626.Text = "LDSound";
            treeNode627.Name = "Node3";
            treeNode627.Text = "AnimateOpacity method added (flashing)";
            treeNode628.Name = "Node0";
            treeNode628.Text = "AnimateRotation method added (continuous rotation)";
            treeNode629.Name = "Node1";
            treeNode629.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode630.Name = "Node2";
            treeNode630.Text = "LDShapes";
            treeNode631.Name = "Node2";
            treeNode631.Text = "Version 1.0.0.76";
            treeNode632.Name = "Node1";
            treeNode632.Text = "AddAnimatedImage can use an ImageList image";
            treeNode633.Name = "Node0";
            treeNode633.Text = "LDShapes";
            treeNode634.Name = "Node0";
            treeNode634.Text = "Version 1.0.0.75";
            treeNode635.Name = "Node1";
            treeNode635.Text = "Initial graph axes scaling improvement";
            treeNode636.Name = "Node0";
            treeNode636.Text = "LDGraph";
            treeNode637.Name = "Node3";
            treeNode637.Text = "Methods to access a bluetooth device";
            treeNode638.Name = "Node0";
            treeNode638.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode639.Name = "Node2";
            treeNode639.Text = "LDBlueTooth";
            treeNode640.Name = "Node1";
            treeNode640.Text = "getFocus handles multiple LDWindows";
            treeNode641.Name = "Node0";
            treeNode641.Text = "LDFocus";
            treeNode642.Name = "Node0";
            treeNode642.Text = "Version 1.0.0.74";
            treeNode643.Name = "Node1";
            treeNode643.Text = "First pass at a generic USB (HID) device controller";
            treeNode644.Name = "Node0";
            treeNode644.Text = "LDHID";
            treeNode645.Name = "Node9";
            treeNode645.Text = "Version 1.0.0.73";
            treeNode646.Name = "Node8";
            treeNode646.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode647.Name = "Node7";
            treeNode647.Text = "LDGraph";
            treeNode648.Name = "Node6";
            treeNode648.Text = "Version 1.0.0.72";
            treeNode649.Name = "Node4";
            treeNode649.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode650.Name = "Node5";
            treeNode650.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode651.Name = "Node3";
            treeNode651.Text = "LDGraph";
            treeNode652.Name = "Node2";
            treeNode652.Text = "Version 1.0.0.71";
            treeNode653.Name = "Node1";
            treeNode653.Text = "Spurious error message fixed";
            treeNode654.Name = "Node2";
            treeNode654.Text = "CreateTrend data series creation method added";
            treeNode655.Name = "Node0";
            treeNode655.Text = "LDGraph";
            treeNode656.Name = "Node2";
            treeNode656.Text = "Version 1.0.0.70";
            treeNode657.Name = "Node1";
            treeNode657.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode658.Name = "Node0";
            treeNode658.Text = "LDControls";
            treeNode659.Name = "Node3";
            treeNode659.Text = "Version 1.0.0.69";
            treeNode660.Name = "Node2";
            treeNode660.Text = "Radio button control added";
            treeNode661.Name = "Node1";
            treeNode661.Text = "LDControls";
            treeNode662.Name = "Node0";
            treeNode662.Text = "Version 1.0.0.68";
            treeNode663.Name = "Node1";
            treeNode663.Text = "Bug fix for Copy";
            treeNode664.Name = "Node0";
            treeNode664.Text = "LDArray";
            treeNode665.Name = "Node2";
            treeNode665.Text = "Version 1.0.0.67";
            treeNode666.Name = "Node1";
            treeNode666.Text = "RegexMatch and RegexReplace methods added";
            treeNode667.Name = "Node0";
            treeNode667.Text = "LDUtilities";
            treeNode668.Name = "Node3";
            treeNode668.Text = "Version 1.0.0.66";
            treeNode669.Name = "Node2";
            treeNode669.Text = "Number culture conversions added";
            treeNode670.Name = "Node1";
            treeNode670.Text = "LDUtilities";
            treeNode671.Name = "Node0";
            treeNode671.Text = "Version 1.0.0.65";
            treeNode672.Name = "Node1";
            treeNode672.Text = "IsNumber method added";
            treeNode673.Name = "Node0";
            treeNode673.Text = "LDUtilities";
            treeNode674.Name = "Node2";
            treeNode674.Text = "Version 1.0.0.64";
            treeNode675.Name = "Node1";
            treeNode675.Text = "SetCursorPosition method added for textboxes";
            treeNode676.Name = "Node0";
            treeNode676.Text = "LDControls";
            treeNode677.Name = "Node4";
            treeNode677.Text = "Version 1.0.0.63";
            treeNode678.Name = "Node1";
            treeNode678.Text = "SetCursorToEnd method added for textboxes";
            treeNode679.Name = "Node3";
            treeNode679.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode680.Name = "Node0";
            treeNode680.Text = "LDControls";
            treeNode681.Name = "Node2";
            treeNode681.Text = "Version 1.0.0.62";
            treeNode682.Name = "Node1";
            treeNode682.Text = "Adding polygons not located at (0,0) corrected";
            treeNode683.Name = "Node0";
            treeNode683.Text = "LDPhysics";
            treeNode684.Name = "Node2";
            treeNode684.Text = "Version 1.0.0.61";
            treeNode685.Name = "Node1";
            treeNode685.Text = "GetFolder dialog added";
            treeNode686.Name = "Node0";
            treeNode686.Text = "LDDialogs";
            treeNode687.Name = "Node0";
            treeNode687.Text = "Version 1.0.0.60";
            treeNode688.Name = "Node10";
            treeNode688.Text = "Possible localization issue with Font size fixed";
            treeNode689.Name = "Node9";
            treeNode689.Text = "LDDialogs";
            treeNode690.Name = "Node8";
            treeNode690.Text = "Version 1.0.0.59";
            treeNode691.Name = "Node3";
            treeNode691.Text = "More internationalization fixes";
            treeNode692.Name = "Node2";
            treeNode692.Text = "ShowPrintPreview property added";
            treeNode693.Name = "Node1";
            treeNode693.Text = "LDUtilities";
            treeNode694.Name = "Node5";
            treeNode694.Text = "Possible error with gradient drawings fixed";
            treeNode695.Name = "Node4";
            treeNode695.Text = "LDShapes";
            treeNode696.Name = "Node7";
            treeNode696.Text = "Possible Listen event initialisation error fixed";
            treeNode697.Name = "Node6";
            treeNode697.Text = "LDSpeech";
            treeNode698.Name = "Node0";
            treeNode698.Text = "Version 1.0.0.58";
            treeNode699.Name = "Node7";
            treeNode699.Text = "Many possible internationisation issues fixed";
            treeNode700.Name = "Node4";
            treeNode700.Text = "Version 1.0.0.57";
            treeNode701.Name = "Node1";
            treeNode701.Text = "Emmisive colour correction for AddGeometry";
            treeNode702.Name = "Node2";
            treeNode702.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode703.Name = "Node0";
            treeNode703.Text = "LD3DView";
            treeNode704.Name = "Node1";
            treeNode704.Text = "CSVdeminiator property added";
            treeNode705.Name = "Node0";
            treeNode705.Text = "LDUtilities";
            treeNode706.Name = "Node5";
            treeNode706.Text = "Version 1.0.0.56";
            treeNode707.Name = "Node1";
            treeNode707.Text = "Improved error reporting";
            treeNode708.Name = "Node2";
            treeNode708.Text = "Culture invariant type conversions";
            treeNode709.Name = "Node1";
            treeNode709.Text = "LD3DView";
            treeNode710.Name = "Node4";
            treeNode710.Text = "ShowErrors method added";
            treeNode711.Name = "Node3";
            treeNode711.Text = "LDUtilities";
            treeNode712.Name = "Node0";
            treeNode712.Text = "Version 1.0.0.55";
            treeNode713.Name = "Node4";
            treeNode713.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode714.Name = "Node3";
            treeNode714.Text = "LDScrollBars";
            treeNode715.Name = "Node6";
            treeNode715.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode716.Name = "Node5";
            treeNode716.Text = "LDUtilities";
            treeNode717.Name = "Node2";
            treeNode717.Text = "Version 1.0.0.54";
            treeNode718.Name = "Node1";
            treeNode718.Text = "Debug window can be resized";
            treeNode719.Name = "Node0";
            treeNode719.Text = "LDDebug";
            treeNode720.Name = "Node1";
            treeNode720.Text = "PrintFile method added";
            treeNode721.Name = "Node0";
            treeNode721.Text = "LDFile";
            treeNode722.Name = "Node2";
            treeNode722.Text = "Version 1.0.0.53";
            treeNode723.Name = "Node1";
            treeNode723.Text = "SSL property option added";
            treeNode724.Name = "Node0";
            treeNode724.Text = "LDEmail";
            treeNode725.Name = "Node0";
            treeNode725.Text = "Version 1.0.0.52";
            treeNode726.Name = "Node1";
            treeNode726.Text = "Right Click Context menu added for any shape or control";
            treeNode727.Name = "Node0";
            treeNode727.Text = "LDControls";
            treeNode728.Name = "Node0";
            treeNode728.Text = "Version 1.0.0.51";
            treeNode729.Name = "Node1";
            treeNode729.Text = "Right click dropdown menu option added";
            treeNode730.Name = "Node0";
            treeNode730.Text = "LDDialogs";
            treeNode731.Name = "Node0";
            treeNode731.Text = "Version 1.0.0.50";
            treeNode732.Name = "Node1";
            treeNode732.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode733.Name = "Node0";
            treeNode733.Text = "LD3DView";
            treeNode734.Name = "Node0";
            treeNode734.Text = "Version 1.0.0.49";
            treeNode735.Name = "Node1";
            treeNode735.Text = "Performance improvements (some camera controls for this)";
            treeNode736.Name = "Node1";
            treeNode736.Text = "LoadModel (*.3ds) files added";
            treeNode737.Name = "Node0";
            treeNode737.Text = "LD3DView";
            treeNode738.Name = "Node3";
            treeNode738.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode739.Name = "Node2";
            treeNode739.Text = "LDShapes";
            treeNode740.Name = "Node0";
            treeNode740.Text = "Version 1.0.0.48";
            treeNode741.Name = "Node1";
            treeNode741.Text = "Some improvements including animations";
            treeNode742.Name = "Node0";
            treeNode742.Text = "LD3DView";
            treeNode743.Name = "Node0";
            treeNode743.Text = "Version 1.0.0.47";
            treeNode744.Name = "Node1";
            treeNode744.Text = "Some improvemts and new methods";
            treeNode745.Name = "Node0";
            treeNode745.Text = "LD3Dview";
            treeNode746.Name = "Node2";
            treeNode746.Text = "Version 1.0.0.46";
            treeNode747.Name = "Node1";
            treeNode747.Text = "A start at a 3D set of methods";
            treeNode748.Name = "Node0";
            treeNode748.Text = "LD3DView";
            treeNode749.Name = "Node10";
            treeNode749.Text = "Version 1.0.0.45";
            treeNode750.Name = "Node1";
            treeNode750.Text = "Create scrollbars for the GraphicsWindow";
            treeNode751.Name = "Node5";
            treeNode751.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode752.Name = "Node0";
            treeNode752.Text = "LDScrollBars";
            treeNode753.Name = "Node4";
            treeNode753.Text = "ColourList method added";
            treeNode754.Name = "Node3";
            treeNode754.Text = "LDUtilities";
            treeNode755.Name = "Node8";
            treeNode755.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode756.Name = "Node9";
            treeNode756.Text = "BackgroundImage method to set the background added";
            treeNode757.Name = "Node6";
            treeNode757.Text = "LDShapes";
            treeNode758.Name = "Node0";
            treeNode758.Text = "Version 1.0.0.44";
            treeNode759.Name = "Node1";
            treeNode759.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode760.Name = "Node0";
            treeNode760.Text = "LDUtilities";
            treeNode761.Name = "Node0";
            treeNode761.Text = "Version 1.0.0.43";
            treeNode762.Name = "Node1";
            treeNode762.Text = "Call Subs as functions with arguments";
            treeNode763.Name = "Node0";
            treeNode763.Text = "LDCall";
            treeNode764.Name = "Node0";
            treeNode764.Text = "Version 1.0.0.42";
            treeNode765.Name = "Node1";
            treeNode765.Text = "Font dialog added";
            treeNode766.Name = "Node2";
            treeNode766.Text = "Colours dialog moved here from LDColours";
            treeNode767.Name = "Node0";
            treeNode767.Text = "LDDialogs";
            treeNode768.Name = "Node9";
            treeNode768.Text = "Version 1.0.0.41";
            treeNode769.Name = "Node1";
            treeNode769.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode770.Name = "Node7";
            treeNode770.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode771.Name = "Node8";
            treeNode771.Text = "Some methods renamed";
            treeNode772.Name = "Node0";
            treeNode772.Text = "LDControls";
            treeNode773.Name = "Node3";
            treeNode773.Text = "HighScore method move here";
            treeNode774.Name = "Node2";
            treeNode774.Text = "LDNetwork";
            treeNode775.Name = "Node6";
            treeNode775.Text = "SetSize method added";
            treeNode776.Name = "Node5";
            treeNode776.Text = "LDShapes";
            treeNode777.Name = "Node3";
            treeNode777.Text = "Version 1.0.0.40";
            treeNode778.Name = "Node1";
            treeNode778.Text = "SelectTreeView method added";
            treeNode779.Name = "Node2";
            treeNode779.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode780.Name = "Node0";
            treeNode780.Text = "LDDialogs";
            treeNode781.Name = "Node1";
            treeNode781.Text = "Simple high score web method";
            treeNode782.Name = "Node0";
            treeNode782.Text = "LDHighScore";
            treeNode783.Name = "Node3";
            treeNode783.Text = "Version 1.0.0.39";
            treeNode784.Name = "Node2";
            treeNode784.Text = "RichTextBox methods improved";
            treeNode785.Name = "Node1";
            treeNode785.Text = "LDDialogs";
            treeNode786.Name = "Node1";
            treeNode786.Text = "Search, Load and Save methods added";
            treeNode787.Name = "Node0";
            treeNode787.Text = "LDArray";
            treeNode788.Name = "Node0";
            treeNode788.Text = "Version 1.0.0.38";
            treeNode789.Name = "Node1";
            treeNode789.Text = "Depreciated";
            treeNode790.Name = "Node0";
            treeNode790.Text = "LDWeather";
            treeNode791.Name = "Node1";
            treeNode791.Text = "Renamed from LDTrig and some more methods added";
            treeNode792.Name = "Node0";
            treeNode792.Text = "LDMath";
            treeNode793.Name = "Node3";
            treeNode793.Text = "RichTextBox method added";
            treeNode794.Name = "Node2";
            treeNode794.Text = "LDDialogs";
            treeNode795.Name = "Node5";
            treeNode795.Text = "FontList method added";
            treeNode796.Name = "Node4";
            treeNode796.Text = "LDUtilities";
            treeNode797.Name = "Node2";
            treeNode797.Text = "Version 1.0.0.37";
            treeNode798.Name = "Node1";
            treeNode798.Text = "Zip method extended";
            treeNode799.Name = "Node0";
            treeNode799.Text = "LDUtilities";
            treeNode800.Name = "Node2";
            treeNode800.Text = "Version 1.0.0.36";
            treeNode801.Name = "Node1";
            treeNode801.Text = "Collapse and expand treeview nodes method added";
            treeNode802.Name = "Node0";
            treeNode802.Text = "LDDialogs";
            treeNode803.Name = "Node5";
            treeNode803.Text = "Version 1.0.0.35";
            treeNode804.Name = "Node1";
            treeNode804.Text = "Arguments added to Start method";
            treeNode805.Name = "Node0";
            treeNode805.Text = "LDProcess";
            treeNode806.Name = "Node4";
            treeNode806.Text = "Zip compression methods added";
            treeNode807.Name = "Node2";
            treeNode807.Text = "LDUtilities";
            treeNode808.Name = "Node2";
            treeNode808.Text = "Version 1.0.0.34";
            treeNode809.Name = "Node1";
            treeNode809.Text = "GWStyle property added";
            treeNode810.Name = "Node0";
            treeNode810.Text = "LDUtilities";
            treeNode811.Name = "Node1";
            treeNode811.Text = "TreeView and associated events added";
            treeNode812.Name = "Node0";
            treeNode812.Text = "LDDialogs";
            treeNode813.Name = "Node0";
            treeNode813.Text = "Version 1.0.0.33";
            treeNode814.Name = "Node1";
            treeNode814.Text = "Possible end points not plotting bug fixed";
            treeNode815.Name = "Node0";
            treeNode815.Text = "LDGraph";
            treeNode816.Name = "Node2";
            treeNode816.Text = "Version 1.0.0.32";
            treeNode817.Name = "Node1";
            treeNode817.Text = "Activated event and Active property addded";
            treeNode818.Name = "Node0";
            treeNode818.Text = "LDWindows";
            treeNode819.Name = "Node0";
            treeNode819.Text = "Version 1.0.0.31";
            treeNode820.Name = "Node1";
            treeNode820.Text = "Create multiple GraphicsWindows";
            treeNode821.Name = "Node0";
            treeNode821.Text = "LDWindows";
            treeNode822.Name = "Node0";
            treeNode822.Text = "Version 1.0.0.30";
            treeNode823.Name = "Node1";
            treeNode823.Text = "Email sending method";
            treeNode824.Name = "Node0";
            treeNode824.Text = "LDMail";
            treeNode825.Name = "Node1";
            treeNode825.Text = "Add and Multiply methods bug fixed";
            treeNode826.Name = "Node2";
            treeNode826.Text = "Image statistics combined into one method";
            treeNode827.Name = "Node3";
            treeNode827.Text = "Histogram method added";
            treeNode828.Name = "Node0";
            treeNode828.Text = "LDImage";
            treeNode829.Name = "Node0";
            treeNode829.Text = "Version 1.0.0.29";
            treeNode830.Name = "Node1";
            treeNode830.Text = "SnapshotToImageList method added";
            treeNode831.Name = "Node0";
            treeNode831.Text = "LDWebCam";
            treeNode832.Name = "Node3";
            treeNode832.Text = "ImageList image manipulation methods";
            treeNode833.Name = "Node2";
            treeNode833.Text = "LDImage";
            treeNode834.Name = "Node0";
            treeNode834.Text = "Version 1.0.0.28";
            treeNode835.Name = "Node1";
            treeNode835.Text = "SortIndex bugfix for null values";
            treeNode836.Name = "Node0";
            treeNode836.Text = "LDArray";
            treeNode837.Name = "Node1";
            treeNode837.Text = "SnapshotToFile bug fixed";
            treeNode838.Name = "Node0";
            treeNode838.Text = "LDWebCam";
            treeNode839.Name = "Node0";
            treeNode839.Text = "Version 1.0.0.27";
            treeNode840.Name = "Node1";
            treeNode840.Text = "SortIndex method added";
            treeNode841.Name = "Node0";
            treeNode841.Text = "LDArray";
            treeNode842.Name = "Node1";
            treeNode842.Text = "Web based weather report data added";
            treeNode843.Name = "Node0";
            treeNode843.Text = "LDWeather";
            treeNode844.Name = "Node3";
            treeNode844.Text = "DataReceived event added";
            treeNode845.Name = "Node2";
            treeNode845.Text = "LDCommPort";
            treeNode846.Name = "Node0";
            treeNode846.Text = "Version 1.0.0.26";
            treeNode847.Name = "Node1";
            treeNode847.Text = "Speech recognition added";
            treeNode848.Name = "Node0";
            treeNode848.Text = "LDSpeech";
            treeNode849.Name = "Node0";
            treeNode849.Text = "Version 1.0.0.25";
            treeNode850.Name = "Node4";
            treeNode850.Text = "More methods added and some internal code optimised";
            treeNode851.Name = "Node0";
            treeNode851.Text = "LDArray & LDMatrix";
            treeNode852.Name = "Node1";
            treeNode852.Text = "KeyDown method added";
            treeNode853.Name = "Node0";
            treeNode853.Text = "LDUtilities";
            treeNode854.Name = "Node1";
            treeNode854.Text = "GetAllShapesAt method added";
            treeNode855.Name = "Node0";
            treeNode855.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode856.Name = "Node0";
            treeNode856.Text = "LDShapes";
            treeNode857.Name = "Node0";
            treeNode857.Text = "Version 1.0.0.24";
            treeNode858.Name = "Node1";
            treeNode858.Text = "OpenFile and SaveFile dialogs added";
            treeNode859.Name = "Node0";
            treeNode859.Text = "LDDialogs";
            treeNode860.Name = "Node2";
            treeNode860.Text = "Matrix methods, for example to solve linear equations";
            treeNode861.Name = "Node1";
            treeNode861.Text = "LDMatrix";
            treeNode862.Name = "Node0";
            treeNode862.Text = "Version 1.0.0.23";
            treeNode863.Name = "Node1";
            treeNode863.Text = "Sorting method added";
            treeNode864.Name = "Node0";
            treeNode864.Text = "LDArray";
            treeNode865.Name = "Node0";
            treeNode865.Text = "Version 1.0.0.22";
            treeNode866.Name = "Node2";
            treeNode866.Text = "Velocity Threshold setting added";
            treeNode867.Name = "Node1";
            treeNode867.Text = "LDPhysics";
            treeNode868.Name = "Node0";
            treeNode868.Text = "Version 1.0.0.21";
            treeNode869.Name = "Node3";
            treeNode869.Text = "SetDamping method added";
            treeNode870.Name = "Node2";
            treeNode870.Text = "LDPhysics";
            treeNode871.Name = "Node1";
            treeNode871.Text = "Version 1.0.0.20";
            treeNode872.Name = "Node1";
            treeNode872.Text = "Instrument name can be obtained from its number";
            treeNode873.Name = "Node0";
            treeNode873.Text = "LDMusic";
            treeNode874.Name = "Node0";
            treeNode874.Text = "Version 1.0.0.19";
            treeNode875.Name = "Node1";
            treeNode875.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode876.Name = "Node0";
            treeNode876.Text = "LDDialogs";
            treeNode877.Name = "Node1";
            treeNode877.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode878.Name = "Node2";
            treeNode878.Text = "Notes can also be played synchronously (chords)";
            treeNode879.Name = "Node0";
            treeNode879.Text = "LDMusic";
            treeNode880.Name = "Node0";
            treeNode880.Text = "Version 1.0.0.18";
            treeNode881.Name = "Node1";
            treeNode881.Text = "AnimationPause and AnimationResume methods added";
            treeNode882.Name = "Node0";
            treeNode882.Text = "LDShapes";
            treeNode883.Name = "Node1";
            treeNode883.Text = "Process list indexed by ID rather than name";
            treeNode884.Name = "Node0";
            treeNode884.Text = "LDProcess";
            treeNode885.Name = "Node1";
            treeNode885.Text = "Version 1.0.0.17";
            treeNode886.Name = "Node1";
            treeNode886.Text = "More effects added";
            treeNode887.Name = "Node0";
            treeNode887.Text = "LDWebCam";
            treeNode888.Name = "Node1";
            treeNode888.Text = "Add or change an image on a button or image shape";
            treeNode889.Name = "Node1";
            treeNode889.Text = "Add an animated gif or tiled image";
            treeNode890.Name = "Node0";
            treeNode890.Text = "LDShapes";
            treeNode891.Name = "Node0";
            treeNode891.Text = "Version 1.0.0.16";
            treeNode892.Name = "Node1";
            treeNode892.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode893.Name = "Node0";
            treeNode893.Text = "LDWebCam";
            treeNode894.Name = "Node0";
            treeNode894.Text = "Version 1.0.0.15";
            treeNode895.Name = "Node2";
            treeNode895.Text = "Variables may be changed during a debug session";
            treeNode896.Name = "Node1";
            treeNode896.Text = "LDDebug";
            treeNode897.Name = "Node0";
            treeNode897.Text = "Version 1.0.0.14";
            treeNode898.Name = "Node1";
            treeNode898.Text = "A basic debugging tool";
            treeNode899.Name = "Node0";
            treeNode899.Text = "LDDebug";
            treeNode900.Name = "Node0";
            treeNode900.Text = "Version 1.0.0.13";
            treeNode901.Name = "Node2";
            treeNode901.Text = "Methods to convert between HSL and RGB";
            treeNode902.Name = "Node18";
            treeNode902.Text = "Method to set colour opacity";
            treeNode903.Name = "Node19";
            treeNode903.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode904.Name = "Node1";
            treeNode904.Text = "LDColours";
            treeNode905.Name = "Node4";
            treeNode905.Text = "Methods to add and subtract dates and times";
            treeNode906.Name = "Node3";
            treeNode906.Text = "LDDateTime";
            treeNode907.Name = "Node6";
            treeNode907.Text = "Waiting overlay, Calendar and About popups";
            treeNode908.Name = "Node17";
            treeNode908.Text = "Tooltips";
            treeNode909.Name = "Node5";
            treeNode909.Text = "LDDialogs";
            treeNode910.Name = "Node8";
            treeNode910.Text = "File change event";
            treeNode911.Name = "Node7";
            treeNode911.Text = "LDEvents";
            treeNode912.Name = "Node0";
            treeNode912.Text = "Version 1.0.0.12";
            treeNode913.Name = "Node12";
            treeNode913.Text = "Methods to sort arrays by index or value";
            treeNode914.Name = "Node22";
            treeNode914.Text = "Sorting by number and character strings";
            treeNode915.Name = "Node11";
            treeNode915.Text = "LDSort";
            treeNode916.Name = "Node14";
            treeNode916.Text = "Statistics on any array and distribution generation";
            treeNode917.Name = "Node20";
            treeNode917.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode918.Name = "Node21";
            treeNode918.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode919.Name = "Node13";
            treeNode919.Text = "LDStatistics";
            treeNode920.Name = "Node16";
            treeNode920.Text = "Voice and volume added";
            treeNode921.Name = "Node15";
            treeNode921.Text = "LDSpeech";
            treeNode922.Name = "Node9";
            treeNode922.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode31,
            treeNode42,
            treeNode57,
            treeNode72,
            treeNode85,
            treeNode94,
            treeNode109,
            treeNode120,
            treeNode134,
            treeNode143,
            treeNode155,
            treeNode166,
            treeNode169,
            treeNode178,
            treeNode185,
            treeNode192,
            treeNode205,
            treeNode216,
            treeNode221,
            treeNode228,
            treeNode231,
            treeNode245,
            treeNode253,
            treeNode259,
            treeNode274,
            treeNode289,
            treeNode295,
            treeNode303,
            treeNode318,
            treeNode335,
            treeNode338,
            treeNode344,
            treeNode350,
            treeNode360,
            treeNode369,
            treeNode372,
            treeNode392,
            treeNode398,
            treeNode401,
            treeNode410,
            treeNode418,
            treeNode424,
            treeNode429,
            treeNode435,
            treeNode438,
            treeNode451,
            treeNode454,
            treeNode459,
            treeNode464,
            treeNode467,
            treeNode473,
            treeNode477,
            treeNode480,
            treeNode486,
            treeNode490,
            treeNode498,
            treeNode504,
            treeNode510,
            treeNode513,
            treeNode520,
            treeNode527,
            treeNode535,
            treeNode538,
            treeNode541,
            treeNode547,
            treeNode552,
            treeNode559,
            treeNode564,
            treeNode570,
            treeNode573,
            treeNode580,
            treeNode585,
            treeNode589,
            treeNode602,
            treeNode610,
            treeNode615,
            treeNode621,
            treeNode624,
            treeNode631,
            treeNode634,
            treeNode642,
            treeNode645,
            treeNode648,
            treeNode652,
            treeNode656,
            treeNode659,
            treeNode662,
            treeNode665,
            treeNode668,
            treeNode671,
            treeNode674,
            treeNode677,
            treeNode681,
            treeNode684,
            treeNode687,
            treeNode690,
            treeNode698,
            treeNode700,
            treeNode706,
            treeNode712,
            treeNode717,
            treeNode722,
            treeNode725,
            treeNode728,
            treeNode731,
            treeNode734,
            treeNode740,
            treeNode743,
            treeNode746,
            treeNode749,
            treeNode758,
            treeNode761,
            treeNode764,
            treeNode768,
            treeNode777,
            treeNode783,
            treeNode788,
            treeNode797,
            treeNode800,
            treeNode803,
            treeNode808,
            treeNode813,
            treeNode816,
            treeNode819,
            treeNode822,
            treeNode829,
            treeNode834,
            treeNode839,
            treeNode846,
            treeNode849,
            treeNode857,
            treeNode862,
            treeNode865,
            treeNode868,
            treeNode871,
            treeNode874,
            treeNode880,
            treeNode885,
            treeNode891,
            treeNode894,
            treeNode897,
            treeNode900,
            treeNode912,
            treeNode922});
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