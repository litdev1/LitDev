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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11,
            treeNode17,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode25,
            treeNode27,
            treeNode29,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode37,
            treeNode41,
            treeNode43,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode56,
            treeNode58,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode66,
            treeNode68,
            treeNode71,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode79,
            treeNode81,
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode89,
            treeNode91,
            treeNode94,
            treeNode96,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode107,
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode104,
            treeNode106,
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode114});
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode115,
            treeNode117,
            treeNode119,
            treeNode121,
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode125,
            treeNode126,
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode131});
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode130,
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode138,
            treeNode139,
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode142,
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode135,
            treeNode137,
            treeNode141,
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode147,
            treeNode149,
            treeNode151,
            treeNode153,
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode161,
            treeNode163,
            treeNode165,
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode169});
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode171});
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode173});
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode170,
            treeNode172,
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode176});
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode180});
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode177,
            treeNode179,
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode183,
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode186,
            treeNode187,
            treeNode188,
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode185,
            treeNode190,
            treeNode192,
            treeNode194});
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode197,
            treeNode199,
            treeNode201,
            treeNode203,
            treeNode205});
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode208,
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode214});
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode213,
            treeNode215,
            treeNode217});
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode219});
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode222,
            treeNode223,
            treeNode224,
            treeNode225});
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode227,
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode230,
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode226,
            treeNode229,
            treeNode232,
            treeNode234});
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode236,
            treeNode237});
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode238,
            treeNode240,
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode244,
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode251,
            treeNode252,
            treeNode253,
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode256,
            treeNode257,
            treeNode258});
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode255,
            treeNode259,
            treeNode261,
            treeNode263});
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode267});
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode269});
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode277});
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode266,
            treeNode268,
            treeNode270,
            treeNode272,
            treeNode274,
            treeNode276,
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode280,
            treeNode281});
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode282,
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode289,
            treeNode290,
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode287,
            treeNode292});
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode296,
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode299,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode295,
            treeNode298,
            treeNode301,
            treeNode303,
            treeNode305,
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode316,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode319});
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode321});
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode311,
            treeNode313,
            treeNode315,
            treeNode318,
            treeNode320,
            treeNode322,
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode329,
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode331,
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode335,
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode338});
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode337,
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode341,
            treeNode342,
            treeNode343,
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode345,
            treeNode347,
            treeNode349});
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode351});
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode353});
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode355});
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode352,
            treeNode354,
            treeNode356,
            treeNode358});
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode361});
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode363,
            treeNode364});
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode366,
            treeNode367});
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode371,
            treeNode372});
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode374});
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode376});
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode365,
            treeNode368,
            treeNode370,
            treeNode373,
            treeNode375,
            treeNode377,
            treeNode379,
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode383,
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode385,
            treeNode387});
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode389});
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode390});
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode396,
            treeNode397,
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode393,
            treeNode395,
            treeNode399});
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode401});
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode403,
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode402,
            treeNode405,
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode411,
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode410,
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode415});
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode417});
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode416,
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode420});
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode422,
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode421,
            treeNode424});
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode429,
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode434});
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode438,
            treeNode439});
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode431,
            treeNode433,
            treeNode435,
            treeNode437,
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode445});
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode446,
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode452});
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode451,
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode455});
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode458,
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode461});
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode460,
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode464,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode468});
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode471,
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode473,
            treeNode475});
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode477,
            treeNode478});
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode485,
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode482,
            treeNode484,
            treeNode487});
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode491,
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode490,
            treeNode493});
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode495,
            treeNode496,
            treeNode497,
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode501});
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode505,
            treeNode507,
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode515});
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode512,
            treeNode514,
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode522,
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode519,
            treeNode521,
            treeNode524});
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode527});
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode534,
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode533,
            treeNode536});
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode538,
            treeNode539,
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode547});
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode544,
            treeNode546,
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode552});
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode551,
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode557,
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode556,
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode564});
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode568});
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode565,
            treeNode567,
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode573});
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode572,
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode576,
            treeNode577});
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode585});
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode589,
            treeNode590});
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode580,
            treeNode582,
            treeNode584,
            treeNode586,
            treeNode588,
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode593,
            treeNode594});
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode596});
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode595,
            treeNode597,
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode602,
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode606,
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode608,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode617,
            treeNode618,
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode616,
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode622});
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode627,
            treeNode628});
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode626,
            treeNode629,
            treeNode631});
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode634});
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode637});
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode639,
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode643,
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode648});
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode656});
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode660});
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode668,
            treeNode669});
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode681,
            treeNode683,
            treeNode685,
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode691,
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode693,
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode697,
            treeNode699,
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode704,
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode709,
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode719});
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode723});
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode725,
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode727,
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode735});
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode740,
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode745,
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode742,
            treeNode744,
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode755,
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode759,
            treeNode760,
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode763});
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode762,
            treeNode764,
            treeNode766});
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode768,
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode770,
            treeNode772});
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode775,
            treeNode777});
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode780,
            treeNode782,
            treeNode784,
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode788});
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode795,
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode800,
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode815,
            treeNode816,
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode814,
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode820});
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode822});
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode821,
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode826,
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode834});
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode831,
            treeNode833,
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode840});
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode844,
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode841,
            treeNode843,
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode849,
            treeNode851});
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode857});
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode860});
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode863});
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode867,
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode866,
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode872,
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode878,
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode877,
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode885});
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode891,
            treeNode892,
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode895});
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode897,
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode900});
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode894,
            treeNode896,
            treeNode899,
            treeNode901});
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode903,
            treeNode904});
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode906,
            treeNode907,
            treeNode908});
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode905,
            treeNode909,
            treeNode911});
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
            treeNode7.Name = "Node0";
            treeNode7.Text = "Version 1.2.14.0";
            treeNode8.Name = "Node2";
            treeNode8.Text = "TEMP tables allowed for SQLite databases";
            treeNode9.Name = "Node1";
            treeNode9.Text = "LDDataBase";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode11.Name = "Node0";
            treeNode11.Text = "LDMath";
            treeNode12.Name = "Node1";
            treeNode12.Text = "NormalMap method added for normal map 3D effects";
            treeNode13.Name = "Node2";
            treeNode13.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode14.Name = "Node5";
            treeNode14.Text = "MakeTransparent method added";
            treeNode15.Name = "Node6";
            treeNode15.Text = "ReplaceColour method added";
            treeNode16.Name = "Node0";
            treeNode16.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode17.Name = "Node0";
            treeNode17.Text = "LDImage";
            treeNode18.Name = "Node4";
            treeNode18.Text = "All image pixel manipulations speeded up";
            treeNode19.Name = "Node7";
            treeNode19.Text = "More Culture Invariace fixes";
            treeNode20.Name = "Node3";
            treeNode20.Text = "General";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Version 1.2.13.0";
            treeNode22.Name = "Node1";
            treeNode22.Text = "Base conversions extended to include bases up to 36";
            treeNode23.Name = "Node0";
            treeNode23.Text = "LDMath";
            treeNode24.Name = "Node3";
            treeNode24.Text = "Updated to new Bing API";
            treeNode25.Name = "Node2";
            treeNode25.Text = "LDSearch";
            treeNode26.Name = "Node1";
            treeNode26.Text = "ShowInTaskbar property added";
            treeNode27.Name = "Node0";
            treeNode27.Text = "LDGraphicsWindow";
            treeNode28.Name = "Node1";
            treeNode28.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode29.Name = "Node0";
            treeNode29.Text = "LDFile";
            treeNode30.Name = "Node1";
            treeNode30.Text = "ToArray and FromArray methods added";
            treeNode31.Name = "Node0";
            treeNode31.Text = "LDxml";
            treeNode32.Name = "Node0";
            treeNode32.Text = "Version 1.2.12.0";
            treeNode33.Name = "Node2";
            treeNode33.Text = "DataViewColumnWidths method added";
            treeNode34.Name = "Node3";
            treeNode34.Text = "DataViewRowColours method added";
            treeNode35.Name = "Node1";
            treeNode35.Text = "LDControls";
            treeNode36.Name = "Node1";
            treeNode36.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode37.Name = "Node0";
            treeNode37.Text = "General";
            treeNode38.Name = "Node1";
            treeNode38.Text = "SetCentre method added";
            treeNode39.Name = "Node4";
            treeNode39.Text = "A 3rd rotation added";
            treeNode40.Name = "Node3";
            treeNode40.Text = "BoundingBox method added";
            treeNode41.Name = "Node0";
            treeNode41.Text = "LD3DView";
            treeNode42.Name = "Node3";
            treeNode42.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode43.Name = "Node2";
            treeNode43.Text = "LDDatabase";
            treeNode44.Name = "Node1";
            treeNode44.Text = "PlayMusic2 method added";
            treeNode45.Name = "Node2";
            treeNode45.Text = "Channel parameter added";
            treeNode46.Name = "Node0";
            treeNode46.Text = "LDMusic";
            treeNode47.Name = "Node0";
            treeNode47.Text = "Version 1.2.11.0";
            treeNode48.Name = "Node1";
            treeNode48.Text = "SetButtonStyle method added";
            treeNode49.Name = "Node0";
            treeNode49.Text = "LDControls";
            treeNode50.Name = "Node1";
            treeNode50.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode51.Name = "Node2";
            treeNode51.Text = "SetBillBoard method added";
            treeNode52.Name = "Node0";
            treeNode52.Text = "GetCameraUpDirection method added";
            treeNode53.Name = "Node1";
            treeNode53.Text = "Gradient brushes can be used";
            treeNode54.Name = "Node2";
            treeNode54.Text = "AutoControl method added";
            treeNode55.Name = "Node0";
            treeNode55.Text = "SpecularExponent property added";
            treeNode56.Name = "Node0";
            treeNode56.Text = "LD3DView";
            treeNode57.Name = "Node1";
            treeNode57.Text = "AddText method to annotate an image with text added";
            treeNode58.Name = "Node0";
            treeNode58.Text = "LDImage";
            treeNode59.Name = "Node4";
            treeNode59.Text = "BrushText for text on a brush added";
            treeNode60.Name = "Node0";
            treeNode60.Text = "Skew shapes method added";
            treeNode61.Name = "Node3";
            treeNode61.Text = "LDShapes";
            treeNode62.Name = "Node0";
            treeNode62.Text = "Version 1.2.10.0";
            treeNode63.Name = "Node1";
            treeNode63.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode64.Name = "Node0";
            treeNode64.Text = "LDUnits";
            treeNode65.Name = "Node1";
            treeNode65.Text = "Possible issue with FixSigFig fixed";
            treeNode66.Name = "Node0";
            treeNode66.Text = "LDMath";
            treeNode67.Name = "Node3";
            treeNode67.Text = "GetIndex method added (for SB arrays)";
            treeNode68.Name = "Node2";
            treeNode68.Text = "LDArray";
            treeNode69.Name = "Node5";
            treeNode69.Text = "Resize mode property added";
            treeNode70.Name = "Node6";
            treeNode70.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode71.Name = "Node4";
            treeNode71.Text = "LDGraphicsWindow";
            treeNode72.Name = "Node8";
            treeNode72.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode73.Name = "Node9";
            treeNode73.Text = "DataViewAllowUserEntry method added";
            treeNode74.Name = "Node7";
            treeNode74.Text = "LDControls";
            treeNode75.Name = "Node0";
            treeNode75.Text = "Version 1.2.9.0";
            treeNode76.Name = "Node1";
            treeNode76.Text = "New extended math object, starting with FFT";
            treeNode77.Name = "Node0";
            treeNode77.Text = "LDMathX";
            treeNode78.Name = "Node1";
            treeNode78.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode79.Name = "Node0";
            treeNode79.Text = "LDControls";
            treeNode80.Name = "Node3";
            treeNode80.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode81.Name = "Node2";
            treeNode81.Text = "LDArray";
            treeNode82.Name = "Node5";
            treeNode82.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode83.Name = "Node4";
            treeNode83.Text = "LDList";
            treeNode84.Name = "Node0";
            treeNode84.Text = "Version 1.2.8.0";
            treeNode85.Name = "Node2";
            treeNode85.Text = "Error handling, additional settings and multiple ports supported";
            treeNode86.Name = "Node1";
            treeNode86.Text = "LDCommPort";
            treeNode87.Name = "Node1";
            treeNode87.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode88.Name = "Node1";
            treeNode88.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode89.Name = "Node0";
            treeNode89.Text = "LDImage and LDWebCam";
            treeNode90.Name = "Node1";
            treeNode90.Text = "Bitwise operations object added";
            treeNode91.Name = "Node0";
            treeNode91.Text = "LDBits";
            treeNode92.Name = "Node1";
            treeNode92.Text = "Extended text encoding property added";
            treeNode93.Name = "Node0";
            treeNode93.Text = "TextWindow colours can be changed";
            treeNode94.Name = "Node0";
            treeNode94.Text = "LDTextWindow";
            treeNode95.Name = "Node1";
            treeNode95.Text = "GetWorkingImagePixelARGB method added";
            treeNode96.Name = "Node0";
            treeNode96.Text = "LDImage";
            treeNode97.Name = "Node1";
            treeNode97.Text = "RasteriseTurtleLines method added";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LDShapes";
            treeNode99.Name = "Node0";
            treeNode99.Text = "Version 1.2.7.0";
            treeNode100.Name = "Node1";
            treeNode100.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode101.Name = "Node0";
            treeNode101.Text = "LDDialogs";
            treeNode102.Name = "Node1";
            treeNode102.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode103.Name = "Node2";
            treeNode103.Text = "ToggleSensor added";
            treeNode104.Name = "Node0";
            treeNode104.Text = "LDPhysics";
            treeNode105.Name = "Node1";
            treeNode105.Text = "Allow multiple copies of the webcam image";
            treeNode106.Name = "Node0";
            treeNode106.Text = "LDWebCam";
            treeNode107.Name = "Node1";
            treeNode107.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode108.Name = "Node0";
            treeNode108.Text = "MetaData method added";
            treeNode109.Name = "Node0";
            treeNode109.Text = "LDImage";
            treeNode110.Name = "Node0";
            treeNode110.Text = "Version 1.2.6.0";
            treeNode111.Name = "Node2";
            treeNode111.Text = "FixSigFig and FixDecimal methods added";
            treeNode112.Name = "Node3";
            treeNode112.Text = "MinNumber and MaxNumber properties added";
            treeNode113.Name = "Node1";
            treeNode113.Text = "LDMath";
            treeNode114.Name = "Node1";
            treeNode114.Text = "SliderMaximum property added";
            treeNode115.Name = "Node0";
            treeNode115.Text = "LDControls";
            treeNode116.Name = "Node1";
            treeNode116.Text = "ZoomAll method added";
            treeNode117.Name = "Node0";
            treeNode117.Text = "LDShapes";
            treeNode118.Name = "Node1";
            treeNode118.Text = "Reposition methods and properties added";
            treeNode119.Name = "Node0";
            treeNode119.Text = "LDGraphicsWindow";
            treeNode120.Name = "Node1";
            treeNode120.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode121.Name = "Node0";
            treeNode121.Text = "LDImage";
            treeNode122.Name = "Node1";
            treeNode122.Text = "MouseScroll parameter added";
            treeNode123.Name = "Node0";
            treeNode123.Text = "LDScrollBars";
            treeNode124.Name = "Node0";
            treeNode124.Text = "Version 1.2.5.0";
            treeNode125.Name = "Node0";
            treeNode125.Text = "New object added (previously a separate extension)";
            treeNode126.Name = "Node1";
            treeNode126.Text = "Async, Loop, Volume and Pan properties added";
            treeNode127.Name = "Node2";
            treeNode127.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode128.Name = "Node1";
            treeNode128.Text = "LDWaveForm";
            treeNode129.Name = "Node1";
            treeNode129.Text = "New object added to get input from gamepads or joysticks";
            treeNode130.Name = "Node0";
            treeNode130.Text = "LDController";
            treeNode131.Name = "Node1";
            treeNode131.Text = "RayCast method added";
            treeNode132.Name = "Node0";
            treeNode132.Text = "LDPhysics";
            treeNode133.Name = "Node0";
            treeNode133.Text = "Version 1.2.4.0";
            treeNode134.Name = "Node2";
            treeNode134.Text = "New object to apply effects to any shape or control";
            treeNode135.Name = "Node1";
            treeNode135.Text = "LDEffects";
            treeNode136.Name = "Node1";
            treeNode136.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode137.Name = "Node0";
            treeNode137.Text = "LDFigures";
            treeNode138.Name = "Node1";
            treeNode138.Text = "SetGroup method added";
            treeNode139.Name = "Node2";
            treeNode139.Text = "GetContacts method added";
            treeNode140.Name = "Node0";
            treeNode140.Text = "GetAllShapesAt method added";
            treeNode141.Name = "Node0";
            treeNode141.Text = "LDPhysics";
            treeNode142.Name = "Node2";
            treeNode142.Text = "SetImage handles images with transparency";
            treeNode143.Name = "Node0";
            treeNode143.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode144.Name = "Node1";
            treeNode144.Text = "LDClipboard";
            treeNode145.Name = "Node0";
            treeNode145.Text = "Version 1.2.3.0";
            treeNode146.Name = "Node2";
            treeNode146.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode147.Name = "Node1";
            treeNode147.Text = "LDShapes";
            treeNode148.Name = "Node4";
            treeNode148.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode149.Name = "Node3";
            treeNode149.Text = "LDFile";
            treeNode150.Name = "Node6";
            treeNode150.Text = "NewImage method added";
            treeNode151.Name = "Node5";
            treeNode151.Text = "LDImage";
            treeNode152.Name = "Node1";
            treeNode152.Text = "SetStartupPosition method added to position dialogs";
            treeNode153.Name = "Node0";
            treeNode153.Text = "LDDialogs";
            treeNode154.Name = "Node1";
            treeNode154.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode155.Name = "Node0";
            treeNode155.Text = "LDGraph";
            treeNode156.Name = "Node0";
            treeNode156.Text = "Version 1.2.2.0";
            treeNode157.Name = "Node2";
            treeNode157.Text = "Recompiled for Small Basic version 1.2";
            treeNode158.Name = "Node1";
            treeNode158.Text = "Version 1.2";
            treeNode159.Name = "Node0";
            treeNode159.Text = "Version 1.2.0.1";
            treeNode160.Name = "Node2";
            treeNode160.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode161.Name = "Node1";
            treeNode161.Text = "LDDialogs";
            treeNode162.Name = "Node1";
            treeNode162.Text = "Logical operations object added";
            treeNode163.Name = "Node0";
            treeNode163.Text = "LDLogic";
            treeNode164.Name = "Node4";
            treeNode164.Text = "CurrentCulture property added";
            treeNode165.Name = "Node3";
            treeNode165.Text = "LDUtilities";
            treeNode166.Name = "Node6";
            treeNode166.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode167.Name = "Node5";
            treeNode167.Text = "LDMath";
            treeNode168.Name = "Node0";
            treeNode168.Text = "Version 1.1.0.8";
            treeNode169.Name = "Node1";
            treeNode169.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode170.Name = "Node0";
            treeNode170.Text = "LDControls";
            treeNode171.Name = "Node1";
            treeNode171.Text = "Methods added to add and remove nodes and save xml file";
            treeNode172.Name = "Node0";
            treeNode172.Text = "LDxml";
            treeNode173.Name = "Node1";
            treeNode173.Text = "MusicPlayTime moved from LDFile";
            treeNode174.Name = "Node0";
            treeNode174.Text = "LDSound";
            treeNode175.Name = "Node0";
            treeNode175.Text = "Version 1.1.0.7";
            treeNode176.Name = "Node4";
            treeNode176.Text = "SplitImage method added";
            treeNode177.Name = "Node3";
            treeNode177.Text = "LDImage";
            treeNode178.Name = "Node6";
            treeNode178.Text = "EditTable and SaveTable methods added";
            treeNode179.Name = "Node5";
            treeNode179.Text = "LDDatabse";
            treeNode180.Name = "Node2";
            treeNode180.Text = "DataView control and methods added";
            treeNode181.Name = "Node1";
            treeNode181.Text = "LDControls";
            treeNode182.Name = "Node2";
            treeNode182.Text = "Version 1.1.0.6";
            treeNode183.Name = "Node2";
            treeNode183.Text = "Exists modified to check for directory as well as file";
            treeNode184.Name = "Node3";
            treeNode184.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode185.Name = "Node1";
            treeNode185.Text = "LDFile";
            treeNode186.Name = "Node5";
            treeNode186.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode187.Name = "Node6";
            treeNode187.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode188.Name = "Node9";
            treeNode188.Text = "Conditonal break point added";
            treeNode189.Name = "Node0";
            treeNode189.Text = "Step over button added";
            treeNode190.Name = "Node4";
            treeNode190.Text = "LDDebug";
            treeNode191.Name = "Node8";
            treeNode191.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode192.Name = "Node7";
            treeNode192.Text = "LDGraphicsWindow";
            treeNode193.Name = "Node1";
            treeNode193.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode194.Name = "Node0";
            treeNode194.Text = "LDResources";
            treeNode195.Name = "Node0";
            treeNode195.Text = "Version 1.1.0.5";
            treeNode196.Name = "Node2";
            treeNode196.Text = "ClipboardChanged event added";
            treeNode197.Name = "Node1";
            treeNode197.Text = "LDClipboard";
            treeNode198.Name = "Node1";
            treeNode198.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode199.Name = "Node0";
            treeNode199.Text = "LDFile";
            treeNode200.Name = "Node3";
            treeNode200.Text = "SetActive method added";
            treeNode201.Name = "Node2";
            treeNode201.Text = "LDGraphicsWindow";
            treeNode202.Name = "Node1";
            treeNode202.Text = "Parse xml file nodes";
            treeNode203.Name = "Node0";
            treeNode203.Text = "LDxml";
            treeNode204.Name = "Node3";
            treeNode204.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode205.Name = "Node2";
            treeNode205.Text = "General";
            treeNode206.Name = "Node0";
            treeNode206.Text = "Version 1.1.0.4";
            treeNode207.Name = "Node2";
            treeNode207.Text = "WakeAll method addded";
            treeNode208.Name = "Node1";
            treeNode208.Text = "LDPhysics";
            treeNode209.Name = "Node1";
            treeNode209.Text = "Clipboard methods added";
            treeNode210.Name = "Node0";
            treeNode210.Text = "LDClipboard";
            treeNode211.Name = "Node0";
            treeNode211.Text = "Version 1.1.0.3";
            treeNode212.Name = "Node6";
            treeNode212.Text = "SizeNWSE cursor added";
            treeNode213.Name = "Node5";
            treeNode213.Text = "LDCursors";
            treeNode214.Name = "Node8";
            treeNode214.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode215.Name = "Node7";
            treeNode215.Text = "LDGraph";
            treeNode216.Name = "Node1";
            treeNode216.Text = "SQLite updated for .Net 4.5";
            treeNode217.Name = "Node0";
            treeNode217.Text = "LDDataBase";
            treeNode218.Name = "Node4";
            treeNode218.Text = "Version 1.1.0.2";
            treeNode219.Name = "Node3";
            treeNode219.Text = "Recompiled for Small Basic version 1.1";
            treeNode220.Name = "Node2";
            treeNode220.Text = "Version 1.1";
            treeNode221.Name = "Node0";
            treeNode221.Text = "Version 1.1.0.1";
            treeNode222.Name = "Node12";
            treeNode222.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode223.Name = "Node13";
            treeNode223.Text = "RichTextBoxMargins method added";
            treeNode224.Name = "Node0";
            treeNode224.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode225.Name = "Node1";
            treeNode225.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode226.Name = "Node11";
            treeNode226.Text = "LDControls";
            treeNode227.Name = "Node3";
            treeNode227.Text = "Error reporting added";
            treeNode228.Name = "Node4";
            treeNode228.Text = "SetEncoding method added";
            treeNode229.Name = "Node2";
            treeNode229.Text = "LDCommPort";
            treeNode230.Name = "Node6";
            treeNode230.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode231.Name = "Node7";
            treeNode231.Text = "Export to excel fix for graph with no title";
            treeNode232.Name = "Node5";
            treeNode232.Text = "LDGraph";
            treeNode233.Name = "Node9";
            treeNode233.Text = "Negative restitution option when adding moving shape";
            treeNode234.Name = "Node8";
            treeNode234.Text = "LDPhysics";
            treeNode235.Name = "Node10";
            treeNode235.Text = "Version 1.0.0.133";
            treeNode236.Name = "Node2";
            treeNode236.Text = "Internal improvements to auto messaging";
            treeNode237.Name = "Node9";
            treeNode237.Text = "Name can be set and GetClients method added";
            treeNode238.Name = "Node1";
            treeNode238.Text = "LDClient";
            treeNode239.Name = "Node4";
            treeNode239.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode240.Name = "Node3";
            treeNode240.Text = "LDControls";
            treeNode241.Name = "Node8";
            treeNode241.Text = "Return message and possible file error fixed for Stop method";
            treeNode242.Name = "Node7";
            treeNode242.Text = "LDSound";
            treeNode243.Name = "Node0";
            treeNode243.Text = "Version 1.0.0.132";
            treeNode244.Name = "Node2";
            treeNode244.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode245.Name = "Node5";
            treeNode245.Text = "Compile method added to compile a Small Basic program";
            treeNode246.Name = "Node1";
            treeNode246.Text = "LDCall";
            treeNode247.Name = "Node4";
            treeNode247.Text = "Methods and code by Pappa Lapub added";
            treeNode248.Name = "Node3";
            treeNode248.Text = "LDShell";
            treeNode249.Name = "Node0";
            treeNode249.Text = "Version 1.0.0.131";
            treeNode250.Name = "Node6";
            treeNode250.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode251.Name = "Node7";
            treeNode251.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode252.Name = "Node8";
            treeNode252.Text = "Refactoring of all the pan, follow and box methods";
            treeNode253.Name = "Node6";
            treeNode253.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode254.Name = "Node8";
            treeNode254.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode255.Name = "Node5";
            treeNode255.Text = "LDPhysics";
            treeNode256.Name = "Node1";
            treeNode256.Text = "UseBinary property added";
            treeNode257.Name = "Node2";
            treeNode257.Text = "DoAsync property and associated completion events added";
            treeNode258.Name = "Node3";
            treeNode258.Text = "Delete method added";
            treeNode259.Name = "Node0";
            treeNode259.Text = "LDftp";
            treeNode260.Name = "Node5";
            treeNode260.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode261.Name = "Node4";
            treeNode261.Text = "LDCall";
            treeNode262.Name = "Node2";
            treeNode262.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode263.Name = "Node1";
            treeNode263.Text = "LDControls";
            treeNode264.Name = "Node4";
            treeNode264.Text = "Version 1.0.0.130";
            treeNode265.Name = "Node2";
            treeNode265.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode266.Name = "Node1";
            treeNode266.Text = "LDMath";
            treeNode267.Name = "Node1";
            treeNode267.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode268.Name = "Node0";
            treeNode268.Text = "LDPhysics";
            treeNode269.Name = "Node3";
            treeNode269.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode270.Name = "Node2";
            treeNode270.Text = "LDGraphicsWindow";
            treeNode271.Name = "Node1";
            treeNode271.Text = "FTP object methods added";
            treeNode272.Name = "Node0";
            treeNode272.Text = "LDftp";
            treeNode273.Name = "Node3";
            treeNode273.Text = "An existing file is replaced";
            treeNode274.Name = "Node2";
            treeNode274.Text = "LDZip";
            treeNode275.Name = "Node1";
            treeNode275.Text = "Size method added";
            treeNode276.Name = "Node0";
            treeNode276.Text = "LDFile";
            treeNode277.Name = "Node3";
            treeNode277.Text = "DownloadFile method added";
            treeNode278.Name = "Node2";
            treeNode278.Text = "LDNetwork";
            treeNode279.Name = "Node0";
            treeNode279.Text = "Version 1.0.0.129";
            treeNode280.Name = "Node2";
            treeNode280.Text = "Generalised joint connections added";
            treeNode281.Name = "Node0";
            treeNode281.Text = "AddExplosion method added";
            treeNode282.Name = "Node1";
            treeNode282.Text = "LDPhysics";
            treeNode283.Name = "Node1";
            treeNode283.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode284.Name = "Node0";
            treeNode284.Text = "LDShapes";
            treeNode285.Name = "Node0";
            treeNode285.Text = "Version 1.0.0.128";
            treeNode286.Name = "Node2";
            treeNode286.Text = "CheckServer method added";
            treeNode287.Name = "Node1";
            treeNode287.Text = "LDClient";
            treeNode288.Name = "Node1";
            treeNode288.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode289.Name = "Node2";
            treeNode289.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode290.Name = "Node3";
            treeNode290.Text = "GetAngle method added";
            treeNode291.Name = "Node4";
            treeNode291.Text = "Top-down tire (to model a car from above) methods added";
            treeNode292.Name = "Node0";
            treeNode292.Text = "LDPhysics";
            treeNode293.Name = "Node0";
            treeNode293.Text = "Version 1.0.0.127";
            treeNode294.Name = "Node7";
            treeNode294.Text = "Bug fixes for Overlap methods";
            treeNode295.Name = "Node6";
            treeNode295.Text = "LDShapes";
            treeNode296.Name = "Node0";
            treeNode296.Text = "Bug fix for multiple numeric sorts";
            treeNode297.Name = "Node9";
            treeNode297.Text = "ByValueWithIndex method added";
            treeNode298.Name = "Node8";
            treeNode298.Text = "LDSort";
            treeNode299.Name = "Node1";
            treeNode299.Text = "LAN method added to get local IP addresses";
            treeNode300.Name = "Node2";
            treeNode300.Text = "Ping method added";
            treeNode301.Name = "Node0";
            treeNode301.Text = "LDNetwork";
            treeNode302.Name = "Node1";
            treeNode302.Text = "LoadSVG method added";
            treeNode303.Name = "Node0";
            treeNode303.Text = "LDImage";
            treeNode304.Name = "Node3";
            treeNode304.Text = "Evaluate method added";
            treeNode305.Name = "Node2";
            treeNode305.Text = "LDMath";
            treeNode306.Name = "Node5";
            treeNode306.Text = "IncludeJScript method added";
            treeNode307.Name = "Node4";
            treeNode307.Text = "LDInline";
            treeNode308.Name = "Node5";
            treeNode308.Text = "Version 1.0.0.126";
            treeNode309.Name = "Node0";
            treeNode309.Text = "Special emphasis on async consistency";
            treeNode310.Name = "Node4";
            treeNode310.Text = "Simplified auto method for multi-player game data transfer";
            treeNode311.Name = "Node9";
            treeNode311.Text = "LDServer and LDClient objects added";
            treeNode312.Name = "Node2";
            treeNode312.Text = "GetWidth and GetHeight methods added";
            treeNode313.Name = "Node1";
            treeNode313.Text = "LDText";
            treeNode314.Name = "Node4";
            treeNode314.Text = "Bing web search";
            treeNode315.Name = "Node3";
            treeNode315.Text = "LDSearch";
            treeNode316.Name = "Node6";
            treeNode316.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode317.Name = "Node7";
            treeNode317.Text = "KeyScroll property added";
            treeNode318.Name = "Node5";
            treeNode318.Text = "LDScrollBars";
            treeNode319.Name = "Node9";
            treeNode319.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode320.Name = "Node8";
            treeNode320.Text = "LDShapes";
            treeNode321.Name = "Node1";
            treeNode321.Text = "SaveAs method bug fixed";
            treeNode322.Name = "Node0";
            treeNode322.Text = "LDImage";
            treeNode323.Name = "Node3";
            treeNode323.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode324.Name = "Node2";
            treeNode324.Text = "LDQueue";
            treeNode325.Name = "Node8";
            treeNode325.Text = "Version 1.0.0.125";
            treeNode326.Name = "Node7";
            treeNode326.Text = "Language translation object added";
            treeNode327.Name = "Node6";
            treeNode327.Text = "LDTranslate";
            treeNode328.Name = "Node5";
            treeNode328.Text = "Version 1.0.0.124";
            treeNode329.Name = "Node1";
            treeNode329.Text = "Mouse screen coordinate conversion parameters added";
            treeNode330.Name = "Node2";
            treeNode330.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode331.Name = "Node0";
            treeNode331.Text = "LDGraphicsWindow";
            treeNode332.Name = "Node4";
            treeNode332.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode333.Name = "Node3";
            treeNode333.Text = "LDUtilities";
            treeNode334.Name = "Node0";
            treeNode334.Text = "Version 1.0.0.123";
            treeNode335.Name = "Node5";
            treeNode335.Text = "ColorMatrix method added";
            treeNode336.Name = "Node0";
            treeNode336.Text = "Rotate method added";
            treeNode337.Name = "Node3";
            treeNode337.Text = "LDImage";
            treeNode338.Name = "Node1";
            treeNode338.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode339.Name = "Node0";
            treeNode339.Text = "LDChart";
            treeNode340.Name = "Node2";
            treeNode340.Text = "Version 1.0.0.122";
            treeNode341.Name = "Node2";
            treeNode341.Text = "EffectGamma added to darken and lighten";
            treeNode342.Name = "Node4";
            treeNode342.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode343.Name = "Node3";
            treeNode343.Text = "EffectContrast modified";
            treeNode344.Name = "Node0";
            treeNode344.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode345.Name = "Node1";
            treeNode345.Text = "LDImage";
            treeNode346.Name = "Node2";
            treeNode346.Text = "Error event added for all extension exceptions";
            treeNode347.Name = "Node1";
            treeNode347.Text = "LDEvents";
            treeNode348.Name = "Node1";
            treeNode348.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode349.Name = "Node0";
            treeNode349.Text = "LDMath";
            treeNode350.Name = "Node0";
            treeNode350.Text = "Version 1.0.0.121";
            treeNode351.Name = "Node2";
            treeNode351.Text = "FloodFill transparency effect fixed";
            treeNode352.Name = "Node1";
            treeNode352.Text = "LDGraphicsWindow";
            treeNode353.Name = "Node1";
            treeNode353.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode354.Name = "Node0";
            treeNode354.Text = "LDFile";
            treeNode355.Name = "Node1";
            treeNode355.Text = "EffectPixelate added";
            treeNode356.Name = "Node0";
            treeNode356.Text = "LDImage";
            treeNode357.Name = "Node1";
            treeNode357.Text = "Modified to work with Windows 8";
            treeNode358.Name = "Node0";
            treeNode358.Text = "LDWebCam";
            treeNode359.Name = "Node0";
            treeNode359.Text = "Version 1.0.0.120";
            treeNode360.Name = "Node2";
            treeNode360.Text = "FloodFill method added";
            treeNode361.Name = "Node1";
            treeNode361.Text = "LDGraphicsWindow";
            treeNode362.Name = "Node0";
            treeNode362.Text = "Version 1.0.0.119";
            treeNode363.Name = "Node0";
            treeNode363.Text = "SetShapeCursor method added";
            treeNode364.Name = "Node11";
            treeNode364.Text = "CreateCursor method added";
            treeNode365.Name = "Node9";
            treeNode365.Text = "LDCursors";
            treeNode366.Name = "Node2";
            treeNode366.Text = "SaveAs method to save in different file formats";
            treeNode367.Name = "Node0";
            treeNode367.Text = "Parameters added for some effects";
            treeNode368.Name = "Node1";
            treeNode368.Text = "LDImage";
            treeNode369.Name = "Node2";
            treeNode369.Text = "Parameters added for some effects";
            treeNode370.Name = "Node1";
            treeNode370.Text = "LDWebCam";
            treeNode371.Name = "Node1";
            treeNode371.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode372.Name = "Node0";
            treeNode372.Text = "SetFontFromFile method added for ttf fonts";
            treeNode373.Name = "Node0";
            treeNode373.Text = "LDGraphicsWindow";
            treeNode374.Name = "Node3";
            treeNode374.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode375.Name = "Node2";
            treeNode375.Text = "LDTextWindow";
            treeNode376.Name = "Node2";
            treeNode376.Text = "Zip methods moved here from LDUtilities";
            treeNode377.Name = "Node0";
            treeNode377.Text = "LDZip";
            treeNode378.Name = "Node3";
            treeNode378.Text = "Regex methods moved here from LDUtilities";
            treeNode379.Name = "Node1";
            treeNode379.Text = "LDRegex";
            treeNode380.Name = "Node1";
            treeNode380.Text = "ListViewRowCount method added";
            treeNode381.Name = "Node0";
            treeNode381.Text = "LDControls";
            treeNode382.Name = "Node3";
            treeNode382.Text = "Version 1.0.0.118";
            treeNode383.Name = "Node5";
            treeNode383.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode384.Name = "Node6";
            treeNode384.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode385.Name = "Node4";
            treeNode385.Text = "LDUtilities";
            treeNode386.Name = "Node10";
            treeNode386.Text = "SetUserCursor method added";
            treeNode387.Name = "Node4";
            treeNode387.Text = "LDCursors";
            treeNode388.Name = "Node3";
            treeNode388.Text = "Version 1.0.0.117";
            treeNode389.Name = "Node2";
            treeNode389.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode390.Name = "Node1";
            treeNode390.Text = "LDDictionary";
            treeNode391.Name = "Node0";
            treeNode391.Text = "Version 1.0.0.116";
            treeNode392.Name = "Node2";
            treeNode392.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode393.Name = "Node1";
            treeNode393.Text = "LDColours";
            treeNode394.Name = "Node4";
            treeNode394.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode395.Name = "Node3";
            treeNode395.Text = "LDShapes";
            treeNode396.Name = "Node1";
            treeNode396.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode397.Name = "Node0";
            treeNode397.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode398.Name = "Node1";
            treeNode398.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode399.Name = "Node0";
            treeNode399.Text = "LDGraph";
            treeNode400.Name = "Node0";
            treeNode400.Text = "Version 1.0.0.115";
            treeNode401.Name = "Node2";
            treeNode401.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode402.Name = "Node1";
            treeNode402.Text = "LDControls";
            treeNode403.Name = "Node4";
            treeNode403.Text = "RemoveTurtleLines method added";
            treeNode404.Name = "Node6";
            treeNode404.Text = "GetAllShapes method added";
            treeNode405.Name = "Node3";
            treeNode405.Text = "LDShapes";
            treeNode406.Name = "Node1";
            treeNode406.Text = "Odbc connection added";
            treeNode407.Name = "Node0";
            treeNode407.Text = "LDDatabase";
            treeNode408.Name = "Node0";
            treeNode408.Text = "Version 1.0.0.114";
            treeNode409.Name = "Node2";
            treeNode409.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode410.Name = "Node1";
            treeNode410.Text = "LDUtilities";
            treeNode411.Name = "Node4";
            treeNode411.Text = "ListView control added";
            treeNode412.Name = "Node5";
            treeNode412.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode413.Name = "Node3";
            treeNode413.Text = "LDControls";
            treeNode414.Name = "Node0";
            treeNode414.Text = "Version 1.0.0.113";
            treeNode415.Name = "Node2";
            treeNode415.Text = "Tone method added";
            treeNode416.Name = "Node1";
            treeNode416.Text = "LDSound";
            treeNode417.Name = "Node5";
            treeNode417.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode418.Name = "Node4";
            treeNode418.Text = "LDControls";
            treeNode419.Name = "Node0";
            treeNode419.Text = "Version 1.0.0.112";
            treeNode420.Name = "Node2";
            treeNode420.Text = "SqlServer and Access database support added";
            treeNode421.Name = "Node1";
            treeNode421.Text = "LDDataBase";
            treeNode422.Name = "Node4";
            treeNode422.Text = "FixFlickr method added";
            treeNode423.Name = "Node0";
            treeNode423.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode424.Name = "Node3";
            treeNode424.Text = "LDUtilities";
            treeNode425.Name = "Node0";
            treeNode425.Text = "Version 1.0.0.111";
            treeNode426.Name = "Node2";
            treeNode426.Text = "TextBoxTab method added";
            treeNode427.Name = "Node1";
            treeNode427.Text = "LDControls";
            treeNode428.Name = "Node0";
            treeNode428.Text = "Version 1.0.0.110";
            treeNode429.Name = "Node1";
            treeNode429.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode430.Name = "Node3";
            treeNode430.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode431.Name = "Node0";
            treeNode431.Text = "General";
            treeNode432.Name = "Node5";
            treeNode432.Text = "Exists method added to check if a file path exists or not";
            treeNode433.Name = "Node4";
            treeNode433.Text = "LDFile";
            treeNode434.Name = "Node7";
            treeNode434.Text = "Start method handles attaching to existing process without warning";
            treeNode435.Name = "Node6";
            treeNode435.Text = "LDProcess";
            treeNode436.Name = "Node1";
            treeNode436.Text = "MySQL database support added";
            treeNode437.Name = "Node0";
            treeNode437.Text = "LDDatabase";
            treeNode438.Name = "Node3";
            treeNode438.Text = "Add and Multiply methods honour transparency";
            treeNode439.Name = "Node4";
            treeNode439.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode440.Name = "Node2";
            treeNode440.Text = "LDImage";
            treeNode441.Name = "Node3";
            treeNode441.Text = "Version 1.0.0.109";
            treeNode442.Name = "Node2";
            treeNode442.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode443.Name = "Node1";
            treeNode443.Text = "LDTextWindow";
            treeNode444.Name = "Node0";
            treeNode444.Text = "Version 1.0.0.108";
            treeNode445.Name = "Node14";
            treeNode445.Text = "Transparent colour added";
            treeNode446.Name = "Node13";
            treeNode446.Text = "LDColours";
            treeNode447.Name = "Node16";
            treeNode447.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode448.Name = "Node15";
            treeNode448.Text = "LDDialogs";
            treeNode449.Name = "Node12";
            treeNode449.Text = "Version 1.0.0.107";
            treeNode450.Name = "Node8";
            treeNode450.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode451.Name = "Node7";
            treeNode451.Text = "LDControls";
            treeNode452.Name = "Node11";
            treeNode452.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode453.Name = "Node10";
            treeNode453.Text = "LDShapes";
            treeNode454.Name = "Node6";
            treeNode454.Text = "Version 1.0.0.106";
            treeNode455.Name = "Node5";
            treeNode455.Text = "Menu control added";
            treeNode456.Name = "Node4";
            treeNode456.Text = "LDControls";
            treeNode457.Name = "Node3";
            treeNode457.Text = "Version 1.0.0.105";
            treeNode458.Name = "Node5";
            treeNode458.Text = "ZipList method added";
            treeNode459.Name = "Node2";
            treeNode459.Text = "GetNextMapIndex method added";
            treeNode460.Name = "Node4";
            treeNode460.Text = "LDUtilities";
            treeNode461.Name = "Node1";
            treeNode461.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode462.Name = "Node0";
            treeNode462.Text = "LDShapes";
            treeNode463.Name = "Node3";
            treeNode463.Text = "Version 1.0.0.104";
            treeNode464.Name = "Node1";
            treeNode464.Text = "Transparency maintained for various methods";
            treeNode465.Name = "Node2";
            treeNode465.Text = "Effects bug fixed";
            treeNode466.Name = "Node0";
            treeNode466.Text = "LDImage";
            treeNode467.Name = "Node0";
            treeNode467.Text = "Version 1.0.0.103";
            treeNode468.Name = "Node1";
            treeNode468.Text = "Current application assemblies are all auto-referenced";
            treeNode469.Name = "Node0";
            treeNode469.Text = "LDInline";
            treeNode470.Name = "Node5";
            treeNode470.Text = "Version 1.0.0.102";
            treeNode471.Name = "Node1";
            treeNode471.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode472.Name = "Node2";
            treeNode472.Text = "LDInline.sb sample provided";
            treeNode473.Name = "Node0";
            treeNode473.Text = "LDInline";
            treeNode474.Name = "Node4";
            treeNode474.Text = "ExitButtonMode method added to control window close button state";
            treeNode475.Name = "Node3";
            treeNode475.Text = "LDUtilities";
            treeNode476.Name = "Node0";
            treeNode476.Text = "Version 1.0.0.101";
            treeNode477.Name = "Node1";
            treeNode477.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode478.Name = "Node0";
            treeNode478.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode479.Name = "Node0";
            treeNode479.Text = "LDTextWindow";
            treeNode480.Name = "Node0";
            treeNode480.Text = "Version 1.0.0.100";
            treeNode481.Name = "Node2";
            treeNode481.Text = "ReadANSIToArray method added";
            treeNode482.Name = "Node1";
            treeNode482.Text = "LDFile";
            treeNode483.Name = "Node1";
            treeNode483.Text = "DocumentViewer control added";
            treeNode484.Name = "Node0";
            treeNode484.Text = "LDControls";
            treeNode485.Name = "Node3";
            treeNode485.Text = "An object to batch update shapes (for speed reasons)";
            treeNode486.Name = "Node0";
            treeNode486.Text = "LDFastShapes.sb sample included";
            treeNode487.Name = "Node2";
            treeNode487.Text = "LDFastShapes";
            treeNode488.Name = "Node0";
            treeNode488.Text = "Version 1.0.0.99";
            treeNode489.Name = "Node1";
            treeNode489.Text = "Rendering performance improvements when many shapes present";
            treeNode490.Name = "Node0";
            treeNode490.Text = "LDPhysics";
            treeNode491.Name = "Node1";
            treeNode491.Text = "ANSItoUTF8 method added";
            treeNode492.Name = "Node2";
            treeNode492.Text = "ReadANSI method added";
            treeNode493.Name = "Node0";
            treeNode493.Text = "LDFile";
            treeNode494.Name = "Node1";
            treeNode494.Text = "Version 1.0.0.98";
            treeNode495.Name = "Node3";
            treeNode495.Text = "Move method added for tiangles, polygons and lines";
            treeNode496.Name = "Node4";
            treeNode496.Text = "RotateAbout method added";
            treeNode497.Name = "Node1";
            treeNode497.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode498.Name = "Node0";
            treeNode498.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode499.Name = "Node2";
            treeNode499.Text = "LDShapes";
            treeNode500.Name = "Node0";
            treeNode500.Text = "Version 1.0.0.97";
            treeNode501.Name = "Node4";
            treeNode501.Text = "A list storage object added";
            treeNode502.Name = "Node3";
            treeNode502.Text = "LDList";
            treeNode503.Name = "Node2";
            treeNode503.Text = "Version 1.0.0.96";
            treeNode504.Name = "Node4";
            treeNode504.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode505.Name = "Node3";
            treeNode505.Text = "LDQueue";
            treeNode506.Name = "Node6";
            treeNode506.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode507.Name = "Node5";
            treeNode507.Text = "LDNetwork";
            treeNode508.Name = "Node0";
            treeNode508.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode509.Name = "Node1";
            treeNode509.Text = "General";
            treeNode510.Name = "Node2";
            treeNode510.Text = "Version 1.0.0.95";
            treeNode511.Name = "Node2";
            treeNode511.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode512.Name = "Node1";
            treeNode512.Text = "LDEncryption";
            treeNode513.Name = "Node1";
            treeNode513.Text = "RandomNumberSeed property added";
            treeNode514.Name = "Node0";
            treeNode514.Text = "LDMath";
            treeNode515.Name = "Node1";
            treeNode515.Text = "SetGameData and GetGameData methods added";
            treeNode516.Name = "Node0";
            treeNode516.Text = "LDNetwork";
            treeNode517.Name = "Node0";
            treeNode517.Text = "Version 1.0.0.94";
            treeNode518.Name = "Node1";
            treeNode518.Text = "SliderGetValue method added";
            treeNode519.Name = "Node0";
            treeNode519.Text = "LDControls";
            treeNode520.Name = "Node5";
            treeNode520.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode521.Name = "Node2";
            treeNode521.Text = "LDUtilities";
            treeNode522.Name = "Node3";
            treeNode522.Text = "Encrypt and Decrypt methods added";
            treeNode523.Name = "Node4";
            treeNode523.Text = "MD5Hash method added";
            treeNode524.Name = "Node6";
            treeNode524.Text = "LDEncryption";
            treeNode525.Name = "Node0";
            treeNode525.Text = "Version 1.0.0.93";
            treeNode526.Name = "Node1";
            treeNode526.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode527.Name = "Node0";
            treeNode527.Text = "LDControls";
            treeNode528.Name = "Node0";
            treeNode528.Text = "Version 1.0.0.92";
            treeNode529.Name = "Node2";
            treeNode529.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode530.Name = "Node1";
            treeNode530.Text = "LDControls";
            treeNode531.Name = "Node1";
            treeNode531.Text = "Version 1.0.0.91";
            treeNode532.Name = "Node1";
            treeNode532.Text = "Font method added to modify shapes or controls that have text";
            treeNode533.Name = "Node0";
            treeNode533.Text = "LDShapes";
            treeNode534.Name = "Node1";
            treeNode534.Text = "MediaPlayer control added (play videos etc)";
            treeNode535.Name = "Node0";
            treeNode535.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode536.Name = "Node0";
            treeNode536.Text = "LDControls";
            treeNode537.Name = "Node1";
            treeNode537.Text = "Version 1.0.0.90";
            treeNode538.Name = "Node1";
            treeNode538.Text = "Autosize columns for ListView";
            treeNode539.Name = "Node2";
            treeNode539.Text = "LDDataBase.sb sample updated";
            treeNode540.Name = "Node0";
            treeNode540.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode541.Name = "Node0";
            treeNode541.Text = "LDDataBase";
            treeNode542.Name = "Node0";
            treeNode542.Text = "Version 1.0.0.89";
            treeNode543.Name = "Node4";
            treeNode543.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode544.Name = "Node3";
            treeNode544.Text = "LDScrollBars";
            treeNode545.Name = "Node1";
            treeNode545.Text = "CleanTemp method added";
            treeNode546.Name = "Node0";
            treeNode546.Text = "LDUtilities";
            treeNode547.Name = "Node1";
            treeNode547.Text = "SQLite database methods added";
            treeNode548.Name = "Node0";
            treeNode548.Text = "LDDataBase";
            treeNode549.Name = "Node2";
            treeNode549.Text = "Version 1.0.0.88";
            treeNode550.Name = "Node2";
            treeNode550.Text = "LastError now returns a text error";
            treeNode551.Name = "Node1";
            treeNode551.Text = "LDIOWarrior";
            treeNode552.Name = "Node1";
            treeNode552.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode553.Name = "Node0";
            treeNode553.Text = "LDScrollBars";
            treeNode554.Name = "Node0";
            treeNode554.Text = "Version 1.0.0.87";
            treeNode555.Name = "Node4";
            treeNode555.Text = "SetTurtleImage method added";
            treeNode556.Name = "Node3";
            treeNode556.Text = "LDShapes";
            treeNode557.Name = "Node1";
            treeNode557.Text = "Connect to IOWarrior USB devices";
            treeNode558.Name = "Node0";
            treeNode558.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode559.Name = "Node0";
            treeNode559.Text = "LDIOWarrior";
            treeNode560.Name = "Node2";
            treeNode560.Text = "Version 1.0.0.86";
            treeNode561.Name = "Node1";
            treeNode561.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode562.Name = "Node0";
            treeNode562.Text = "LDShapes";
            treeNode563.Name = "Node2";
            treeNode563.Text = "Version 1.0.0.85";
            treeNode564.Name = "Node4";
            treeNode564.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode565.Name = "Node3";
            treeNode565.Text = "LDFile";
            treeNode566.Name = "Node6";
            treeNode566.Text = "Crop method added";
            treeNode567.Name = "Node5";
            treeNode567.Text = "LDImage";
            treeNode568.Name = "Node1";
            treeNode568.Text = "LastDropFiles bug fixed";
            treeNode569.Name = "Node0";
            treeNode569.Text = "LDControls";
            treeNode570.Name = "Node2";
            treeNode570.Text = "Version 1.0.0.84";
            treeNode571.Name = "Node7";
            treeNode571.Text = "FileDropped event added";
            treeNode572.Name = "Node6";
            treeNode572.Text = "LDControls";
            treeNode573.Name = "Node1";
            treeNode573.Text = "Bug in Split corrected";
            treeNode574.Name = "Node0";
            treeNode574.Text = "LDText";
            treeNode575.Name = "Node5";
            treeNode575.Text = "Version 1.0.0.83";
            treeNode576.Name = "Node3";
            treeNode576.Text = "Title argument removed from AddComboBox";
            treeNode577.Name = "Node4";
            treeNode577.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode578.Name = "Node2";
            treeNode578.Text = "LDControls";
            treeNode579.Name = "Node1";
            treeNode579.Text = "Version 1.0.0.82";
            treeNode580.Name = "Node0";
            treeNode580.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode581.Name = "Node12";
            treeNode581.Text = "Program settings added";
            treeNode582.Name = "Node9";
            treeNode582.Text = "LDSettings";
            treeNode583.Name = "Node11";
            treeNode583.Text = "Get some system paths and user name";
            treeNode584.Name = "Node10";
            treeNode584.Text = "LDFile";
            treeNode585.Name = "Node14";
            treeNode585.Text = "System sounds added";
            treeNode586.Name = "Node13";
            treeNode586.Text = "LDSound";
            treeNode587.Name = "Node16";
            treeNode587.Text = "Binary, octal, hex and decimal conversions";
            treeNode588.Name = "Node15";
            treeNode588.Text = "LDMath";
            treeNode589.Name = "Node1";
            treeNode589.Text = "Replace method added";
            treeNode590.Name = "Node2";
            treeNode590.Text = "FindAll method added";
            treeNode591.Name = "Node0";
            treeNode591.Text = "LDText";
            treeNode592.Name = "Node8";
            treeNode592.Text = "Version 1.0.0.81";
            treeNode593.Name = "Node1";
            treeNode593.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode594.Name = "Node6";
            treeNode594.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode595.Name = "Node0";
            treeNode595.Text = "LDShapes";
            treeNode596.Name = "Node3";
            treeNode596.Text = "Truncate method added";
            treeNode597.Name = "Node2";
            treeNode597.Text = "LDMath";
            treeNode598.Name = "Node5";
            treeNode598.Text = "Additional text methods";
            treeNode599.Name = "Node4";
            treeNode599.Text = "LDText";
            treeNode600.Name = "Node0";
            treeNode600.Text = "Version 1.0.0.80";
            treeNode601.Name = "Node1";
            treeNode601.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode602.Name = "Node0";
            treeNode602.Text = "LDDialogs";
            treeNode603.Name = "Node1";
            treeNode603.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode604.Name = "Node0";
            treeNode604.Text = "LDUtilities";
            treeNode605.Name = "Node6";
            treeNode605.Text = "Version 1.0.0.79";
            treeNode606.Name = "Node2";
            treeNode606.Text = "Rasterize property added";
            treeNode607.Name = "Node5";
            treeNode607.Text = "Improvements associated with window resizing";
            treeNode608.Name = "Node1";
            treeNode608.Text = "LDScrollBars";
            treeNode609.Name = "Node4";
            treeNode609.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode610.Name = "Node3";
            treeNode610.Text = "LDUtilities";
            treeNode611.Name = "Node0";
            treeNode611.Text = "Version 1.0.0.78";
            treeNode612.Name = "Node1";
            treeNode612.Text = "Handle more than 100 drawables (rasterization)";
            treeNode613.Name = "Node0";
            treeNode613.Text = "LDScollBars";
            treeNode614.Name = "Node2";
            treeNode614.Text = "Version 1.0.0.77";
            treeNode615.Name = "Node1";
            treeNode615.Text = "Record sound from a microphone";
            treeNode616.Name = "Node0";
            treeNode616.Text = "LDSound";
            treeNode617.Name = "Node3";
            treeNode617.Text = "AnimateOpacity method added (flashing)";
            treeNode618.Name = "Node0";
            treeNode618.Text = "AnimateRotation method added (continuous rotation)";
            treeNode619.Name = "Node1";
            treeNode619.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode620.Name = "Node2";
            treeNode620.Text = "LDShapes";
            treeNode621.Name = "Node2";
            treeNode621.Text = "Version 1.0.0.76";
            treeNode622.Name = "Node1";
            treeNode622.Text = "AddAnimatedImage can use an ImageList image";
            treeNode623.Name = "Node0";
            treeNode623.Text = "LDShapes";
            treeNode624.Name = "Node0";
            treeNode624.Text = "Version 1.0.0.75";
            treeNode625.Name = "Node1";
            treeNode625.Text = "Initial graph axes scaling improvement";
            treeNode626.Name = "Node0";
            treeNode626.Text = "LDGraph";
            treeNode627.Name = "Node3";
            treeNode627.Text = "Methods to access a bluetooth device";
            treeNode628.Name = "Node0";
            treeNode628.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode629.Name = "Node2";
            treeNode629.Text = "LDBlueTooth";
            treeNode630.Name = "Node1";
            treeNode630.Text = "getFocus handles multiple LDWindows";
            treeNode631.Name = "Node0";
            treeNode631.Text = "LDFocus";
            treeNode632.Name = "Node0";
            treeNode632.Text = "Version 1.0.0.74";
            treeNode633.Name = "Node1";
            treeNode633.Text = "First pass at a generic USB (HID) device controller";
            treeNode634.Name = "Node0";
            treeNode634.Text = "LDHID";
            treeNode635.Name = "Node9";
            treeNode635.Text = "Version 1.0.0.73";
            treeNode636.Name = "Node8";
            treeNode636.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode637.Name = "Node7";
            treeNode637.Text = "LDGraph";
            treeNode638.Name = "Node6";
            treeNode638.Text = "Version 1.0.0.72";
            treeNode639.Name = "Node4";
            treeNode639.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode640.Name = "Node5";
            treeNode640.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode641.Name = "Node3";
            treeNode641.Text = "LDGraph";
            treeNode642.Name = "Node2";
            treeNode642.Text = "Version 1.0.0.71";
            treeNode643.Name = "Node1";
            treeNode643.Text = "Spurious error message fixed";
            treeNode644.Name = "Node2";
            treeNode644.Text = "CreateTrend data series creation method added";
            treeNode645.Name = "Node0";
            treeNode645.Text = "LDGraph";
            treeNode646.Name = "Node2";
            treeNode646.Text = "Version 1.0.0.70";
            treeNode647.Name = "Node1";
            treeNode647.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode648.Name = "Node0";
            treeNode648.Text = "LDControls";
            treeNode649.Name = "Node3";
            treeNode649.Text = "Version 1.0.0.69";
            treeNode650.Name = "Node2";
            treeNode650.Text = "Radio button control added";
            treeNode651.Name = "Node1";
            treeNode651.Text = "LDControls";
            treeNode652.Name = "Node0";
            treeNode652.Text = "Version 1.0.0.68";
            treeNode653.Name = "Node1";
            treeNode653.Text = "Bug fix for Copy";
            treeNode654.Name = "Node0";
            treeNode654.Text = "LDArray";
            treeNode655.Name = "Node2";
            treeNode655.Text = "Version 1.0.0.67";
            treeNode656.Name = "Node1";
            treeNode656.Text = "RegexMatch and RegexReplace methods added";
            treeNode657.Name = "Node0";
            treeNode657.Text = "LDUtilities";
            treeNode658.Name = "Node3";
            treeNode658.Text = "Version 1.0.0.66";
            treeNode659.Name = "Node2";
            treeNode659.Text = "Number culture conversions added";
            treeNode660.Name = "Node1";
            treeNode660.Text = "LDUtilities";
            treeNode661.Name = "Node0";
            treeNode661.Text = "Version 1.0.0.65";
            treeNode662.Name = "Node1";
            treeNode662.Text = "IsNumber method added";
            treeNode663.Name = "Node0";
            treeNode663.Text = "LDUtilities";
            treeNode664.Name = "Node2";
            treeNode664.Text = "Version 1.0.0.64";
            treeNode665.Name = "Node1";
            treeNode665.Text = "SetCursorPosition method added for textboxes";
            treeNode666.Name = "Node0";
            treeNode666.Text = "LDControls";
            treeNode667.Name = "Node4";
            treeNode667.Text = "Version 1.0.0.63";
            treeNode668.Name = "Node1";
            treeNode668.Text = "SetCursorToEnd method added for textboxes";
            treeNode669.Name = "Node3";
            treeNode669.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode670.Name = "Node0";
            treeNode670.Text = "LDControls";
            treeNode671.Name = "Node2";
            treeNode671.Text = "Version 1.0.0.62";
            treeNode672.Name = "Node1";
            treeNode672.Text = "Adding polygons not located at (0,0) corrected";
            treeNode673.Name = "Node0";
            treeNode673.Text = "LDPhysics";
            treeNode674.Name = "Node2";
            treeNode674.Text = "Version 1.0.0.61";
            treeNode675.Name = "Node1";
            treeNode675.Text = "GetFolder dialog added";
            treeNode676.Name = "Node0";
            treeNode676.Text = "LDDialogs";
            treeNode677.Name = "Node0";
            treeNode677.Text = "Version 1.0.0.60";
            treeNode678.Name = "Node10";
            treeNode678.Text = "Possible localization issue with Font size fixed";
            treeNode679.Name = "Node9";
            treeNode679.Text = "LDDialogs";
            treeNode680.Name = "Node8";
            treeNode680.Text = "Version 1.0.0.59";
            treeNode681.Name = "Node3";
            treeNode681.Text = "More internationalization fixes";
            treeNode682.Name = "Node2";
            treeNode682.Text = "ShowPrintPreview property added";
            treeNode683.Name = "Node1";
            treeNode683.Text = "LDUtilities";
            treeNode684.Name = "Node5";
            treeNode684.Text = "Possible error with gradient drawings fixed";
            treeNode685.Name = "Node4";
            treeNode685.Text = "LDShapes";
            treeNode686.Name = "Node7";
            treeNode686.Text = "Possible Listen event initialisation error fixed";
            treeNode687.Name = "Node6";
            treeNode687.Text = "LDSpeech";
            treeNode688.Name = "Node0";
            treeNode688.Text = "Version 1.0.0.58";
            treeNode689.Name = "Node7";
            treeNode689.Text = "Many possible internationisation issues fixed";
            treeNode690.Name = "Node4";
            treeNode690.Text = "Version 1.0.0.57";
            treeNode691.Name = "Node1";
            treeNode691.Text = "Emmisive colour correction for AddGeometry";
            treeNode692.Name = "Node2";
            treeNode692.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode693.Name = "Node0";
            treeNode693.Text = "LD3DView";
            treeNode694.Name = "Node1";
            treeNode694.Text = "CSVdeminiator property added";
            treeNode695.Name = "Node0";
            treeNode695.Text = "LDUtilities";
            treeNode696.Name = "Node5";
            treeNode696.Text = "Version 1.0.0.56";
            treeNode697.Name = "Node1";
            treeNode697.Text = "Improved error reporting";
            treeNode698.Name = "Node2";
            treeNode698.Text = "Culture invariant type conversions";
            treeNode699.Name = "Node1";
            treeNode699.Text = "LD3DView";
            treeNode700.Name = "Node4";
            treeNode700.Text = "ShowErrors method added";
            treeNode701.Name = "Node3";
            treeNode701.Text = "LDUtilities";
            treeNode702.Name = "Node0";
            treeNode702.Text = "Version 1.0.0.55";
            treeNode703.Name = "Node4";
            treeNode703.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode704.Name = "Node3";
            treeNode704.Text = "LDScrollBars";
            treeNode705.Name = "Node6";
            treeNode705.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode706.Name = "Node5";
            treeNode706.Text = "LDUtilities";
            treeNode707.Name = "Node2";
            treeNode707.Text = "Version 1.0.0.54";
            treeNode708.Name = "Node1";
            treeNode708.Text = "Debug window can be resized";
            treeNode709.Name = "Node0";
            treeNode709.Text = "LDDebug";
            treeNode710.Name = "Node1";
            treeNode710.Text = "PrintFile method added";
            treeNode711.Name = "Node0";
            treeNode711.Text = "LDFile";
            treeNode712.Name = "Node2";
            treeNode712.Text = "Version 1.0.0.53";
            treeNode713.Name = "Node1";
            treeNode713.Text = "SSL property option added";
            treeNode714.Name = "Node0";
            treeNode714.Text = "LDEmail";
            treeNode715.Name = "Node0";
            treeNode715.Text = "Version 1.0.0.52";
            treeNode716.Name = "Node1";
            treeNode716.Text = "Right Click Context menu added for any shape or control";
            treeNode717.Name = "Node0";
            treeNode717.Text = "LDControls";
            treeNode718.Name = "Node0";
            treeNode718.Text = "Version 1.0.0.51";
            treeNode719.Name = "Node1";
            treeNode719.Text = "Right click dropdown menu option added";
            treeNode720.Name = "Node0";
            treeNode720.Text = "LDDialogs";
            treeNode721.Name = "Node0";
            treeNode721.Text = "Version 1.0.0.50";
            treeNode722.Name = "Node1";
            treeNode722.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode723.Name = "Node0";
            treeNode723.Text = "LD3DView";
            treeNode724.Name = "Node0";
            treeNode724.Text = "Version 1.0.0.49";
            treeNode725.Name = "Node1";
            treeNode725.Text = "Performance improvements (some camera controls for this)";
            treeNode726.Name = "Node1";
            treeNode726.Text = "LoadModel (*.3ds) files added";
            treeNode727.Name = "Node0";
            treeNode727.Text = "LD3DView";
            treeNode728.Name = "Node3";
            treeNode728.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode729.Name = "Node2";
            treeNode729.Text = "LDShapes";
            treeNode730.Name = "Node0";
            treeNode730.Text = "Version 1.0.0.48";
            treeNode731.Name = "Node1";
            treeNode731.Text = "Some improvements including animations";
            treeNode732.Name = "Node0";
            treeNode732.Text = "LD3DView";
            treeNode733.Name = "Node0";
            treeNode733.Text = "Version 1.0.0.47";
            treeNode734.Name = "Node1";
            treeNode734.Text = "Some improvemts and new methods";
            treeNode735.Name = "Node0";
            treeNode735.Text = "LD3Dview";
            treeNode736.Name = "Node2";
            treeNode736.Text = "Version 1.0.0.46";
            treeNode737.Name = "Node1";
            treeNode737.Text = "A start at a 3D set of methods";
            treeNode738.Name = "Node0";
            treeNode738.Text = "LD3DView";
            treeNode739.Name = "Node10";
            treeNode739.Text = "Version 1.0.0.45";
            treeNode740.Name = "Node1";
            treeNode740.Text = "Create scrollbars for the GraphicsWindow";
            treeNode741.Name = "Node5";
            treeNode741.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode742.Name = "Node0";
            treeNode742.Text = "LDScrollBars";
            treeNode743.Name = "Node4";
            treeNode743.Text = "ColourList method added";
            treeNode744.Name = "Node3";
            treeNode744.Text = "LDUtilities";
            treeNode745.Name = "Node8";
            treeNode745.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode746.Name = "Node9";
            treeNode746.Text = "BackgroundImage method to set the background added";
            treeNode747.Name = "Node6";
            treeNode747.Text = "LDShapes";
            treeNode748.Name = "Node0";
            treeNode748.Text = "Version 1.0.0.44";
            treeNode749.Name = "Node1";
            treeNode749.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode750.Name = "Node0";
            treeNode750.Text = "LDUtilities";
            treeNode751.Name = "Node0";
            treeNode751.Text = "Version 1.0.0.43";
            treeNode752.Name = "Node1";
            treeNode752.Text = "Call Subs as functions with arguments";
            treeNode753.Name = "Node0";
            treeNode753.Text = "LDCall";
            treeNode754.Name = "Node0";
            treeNode754.Text = "Version 1.0.0.42";
            treeNode755.Name = "Node1";
            treeNode755.Text = "Font dialog added";
            treeNode756.Name = "Node2";
            treeNode756.Text = "Colours dialog moved here from LDColours";
            treeNode757.Name = "Node0";
            treeNode757.Text = "LDDialogs";
            treeNode758.Name = "Node9";
            treeNode758.Text = "Version 1.0.0.41";
            treeNode759.Name = "Node1";
            treeNode759.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode760.Name = "Node7";
            treeNode760.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode761.Name = "Node8";
            treeNode761.Text = "Some methods renamed";
            treeNode762.Name = "Node0";
            treeNode762.Text = "LDControls";
            treeNode763.Name = "Node3";
            treeNode763.Text = "HighScore method move here";
            treeNode764.Name = "Node2";
            treeNode764.Text = "LDNetwork";
            treeNode765.Name = "Node6";
            treeNode765.Text = "SetSize method added";
            treeNode766.Name = "Node5";
            treeNode766.Text = "LDShapes";
            treeNode767.Name = "Node3";
            treeNode767.Text = "Version 1.0.0.40";
            treeNode768.Name = "Node1";
            treeNode768.Text = "SelectTreeView method added";
            treeNode769.Name = "Node2";
            treeNode769.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode770.Name = "Node0";
            treeNode770.Text = "LDDialogs";
            treeNode771.Name = "Node1";
            treeNode771.Text = "Simple high score web method";
            treeNode772.Name = "Node0";
            treeNode772.Text = "LDHighScore";
            treeNode773.Name = "Node3";
            treeNode773.Text = "Version 1.0.0.39";
            treeNode774.Name = "Node2";
            treeNode774.Text = "RichTextBox methods improved";
            treeNode775.Name = "Node1";
            treeNode775.Text = "LDDialogs";
            treeNode776.Name = "Node1";
            treeNode776.Text = "Search, Load and Save methods added";
            treeNode777.Name = "Node0";
            treeNode777.Text = "LDArray";
            treeNode778.Name = "Node0";
            treeNode778.Text = "Version 1.0.0.38";
            treeNode779.Name = "Node1";
            treeNode779.Text = "Depreciated";
            treeNode780.Name = "Node0";
            treeNode780.Text = "LDWeather";
            treeNode781.Name = "Node1";
            treeNode781.Text = "Renamed from LDTrig and some more methods added";
            treeNode782.Name = "Node0";
            treeNode782.Text = "LDMath";
            treeNode783.Name = "Node3";
            treeNode783.Text = "RichTextBox method added";
            treeNode784.Name = "Node2";
            treeNode784.Text = "LDDialogs";
            treeNode785.Name = "Node5";
            treeNode785.Text = "FontList method added";
            treeNode786.Name = "Node4";
            treeNode786.Text = "LDUtilities";
            treeNode787.Name = "Node2";
            treeNode787.Text = "Version 1.0.0.37";
            treeNode788.Name = "Node1";
            treeNode788.Text = "Zip method extended";
            treeNode789.Name = "Node0";
            treeNode789.Text = "LDUtilities";
            treeNode790.Name = "Node2";
            treeNode790.Text = "Version 1.0.0.36";
            treeNode791.Name = "Node1";
            treeNode791.Text = "Collapse and expand treeview nodes method added";
            treeNode792.Name = "Node0";
            treeNode792.Text = "LDDialogs";
            treeNode793.Name = "Node5";
            treeNode793.Text = "Version 1.0.0.35";
            treeNode794.Name = "Node1";
            treeNode794.Text = "Arguments added to Start method";
            treeNode795.Name = "Node0";
            treeNode795.Text = "LDProcess";
            treeNode796.Name = "Node4";
            treeNode796.Text = "Zip compression methods added";
            treeNode797.Name = "Node2";
            treeNode797.Text = "LDUtilities";
            treeNode798.Name = "Node2";
            treeNode798.Text = "Version 1.0.0.34";
            treeNode799.Name = "Node1";
            treeNode799.Text = "GWStyle property added";
            treeNode800.Name = "Node0";
            treeNode800.Text = "LDUtilities";
            treeNode801.Name = "Node1";
            treeNode801.Text = "TreeView and associated events added";
            treeNode802.Name = "Node0";
            treeNode802.Text = "LDDialogs";
            treeNode803.Name = "Node0";
            treeNode803.Text = "Version 1.0.0.33";
            treeNode804.Name = "Node1";
            treeNode804.Text = "Possible end points not plotting bug fixed";
            treeNode805.Name = "Node0";
            treeNode805.Text = "LDGraph";
            treeNode806.Name = "Node2";
            treeNode806.Text = "Version 1.0.0.32";
            treeNode807.Name = "Node1";
            treeNode807.Text = "Activated event and Active property addded";
            treeNode808.Name = "Node0";
            treeNode808.Text = "LDWindows";
            treeNode809.Name = "Node0";
            treeNode809.Text = "Version 1.0.0.31";
            treeNode810.Name = "Node1";
            treeNode810.Text = "Create multiple GraphicsWindows";
            treeNode811.Name = "Node0";
            treeNode811.Text = "LDWindows";
            treeNode812.Name = "Node0";
            treeNode812.Text = "Version 1.0.0.30";
            treeNode813.Name = "Node1";
            treeNode813.Text = "Email sending method";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDMail";
            treeNode815.Name = "Node1";
            treeNode815.Text = "Add and Multiply methods bug fixed";
            treeNode816.Name = "Node2";
            treeNode816.Text = "Image statistics combined into one method";
            treeNode817.Name = "Node3";
            treeNode817.Text = "Histogram method added";
            treeNode818.Name = "Node0";
            treeNode818.Text = "LDImage";
            treeNode819.Name = "Node0";
            treeNode819.Text = "Version 1.0.0.29";
            treeNode820.Name = "Node1";
            treeNode820.Text = "SnapshotToImageList method added";
            treeNode821.Name = "Node0";
            treeNode821.Text = "LDWebCam";
            treeNode822.Name = "Node3";
            treeNode822.Text = "ImageList image manipulation methods";
            treeNode823.Name = "Node2";
            treeNode823.Text = "LDImage";
            treeNode824.Name = "Node0";
            treeNode824.Text = "Version 1.0.0.28";
            treeNode825.Name = "Node1";
            treeNode825.Text = "SortIndex bugfix for null values";
            treeNode826.Name = "Node0";
            treeNode826.Text = "LDArray";
            treeNode827.Name = "Node1";
            treeNode827.Text = "SnapshotToFile bug fixed";
            treeNode828.Name = "Node0";
            treeNode828.Text = "LDWebCam";
            treeNode829.Name = "Node0";
            treeNode829.Text = "Version 1.0.0.27";
            treeNode830.Name = "Node1";
            treeNode830.Text = "SortIndex method added";
            treeNode831.Name = "Node0";
            treeNode831.Text = "LDArray";
            treeNode832.Name = "Node1";
            treeNode832.Text = "Web based weather report data added";
            treeNode833.Name = "Node0";
            treeNode833.Text = "LDWeather";
            treeNode834.Name = "Node3";
            treeNode834.Text = "DataReceived event added";
            treeNode835.Name = "Node2";
            treeNode835.Text = "LDCommPort";
            treeNode836.Name = "Node0";
            treeNode836.Text = "Version 1.0.0.26";
            treeNode837.Name = "Node1";
            treeNode837.Text = "Speech recognition added";
            treeNode838.Name = "Node0";
            treeNode838.Text = "LDSpeech";
            treeNode839.Name = "Node0";
            treeNode839.Text = "Version 1.0.0.25";
            treeNode840.Name = "Node4";
            treeNode840.Text = "More methods added and some internal code optimised";
            treeNode841.Name = "Node0";
            treeNode841.Text = "LDArray & LDMatrix";
            treeNode842.Name = "Node1";
            treeNode842.Text = "KeyDown method added";
            treeNode843.Name = "Node0";
            treeNode843.Text = "LDUtilities";
            treeNode844.Name = "Node1";
            treeNode844.Text = "GetAllShapesAt method added";
            treeNode845.Name = "Node0";
            treeNode845.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode846.Name = "Node0";
            treeNode846.Text = "LDShapes";
            treeNode847.Name = "Node0";
            treeNode847.Text = "Version 1.0.0.24";
            treeNode848.Name = "Node1";
            treeNode848.Text = "OpenFile and SaveFile dialogs added";
            treeNode849.Name = "Node0";
            treeNode849.Text = "LDDialogs";
            treeNode850.Name = "Node2";
            treeNode850.Text = "Matrix methods, for example to solve linear equations";
            treeNode851.Name = "Node1";
            treeNode851.Text = "LDMatrix";
            treeNode852.Name = "Node0";
            treeNode852.Text = "Version 1.0.0.23";
            treeNode853.Name = "Node1";
            treeNode853.Text = "Sorting method added";
            treeNode854.Name = "Node0";
            treeNode854.Text = "LDArray";
            treeNode855.Name = "Node0";
            treeNode855.Text = "Version 1.0.0.22";
            treeNode856.Name = "Node2";
            treeNode856.Text = "Velocity Threshold setting added";
            treeNode857.Name = "Node1";
            treeNode857.Text = "LDPhysics";
            treeNode858.Name = "Node0";
            treeNode858.Text = "Version 1.0.0.21";
            treeNode859.Name = "Node3";
            treeNode859.Text = "SetDamping method added";
            treeNode860.Name = "Node2";
            treeNode860.Text = "LDPhysics";
            treeNode861.Name = "Node1";
            treeNode861.Text = "Version 1.0.0.20";
            treeNode862.Name = "Node1";
            treeNode862.Text = "Instrument name can be obtained from its number";
            treeNode863.Name = "Node0";
            treeNode863.Text = "LDMusic";
            treeNode864.Name = "Node0";
            treeNode864.Text = "Version 1.0.0.19";
            treeNode865.Name = "Node1";
            treeNode865.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode866.Name = "Node0";
            treeNode866.Text = "LDDialogs";
            treeNode867.Name = "Node1";
            treeNode867.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode868.Name = "Node2";
            treeNode868.Text = "Notes can also be played synchronously (chords)";
            treeNode869.Name = "Node0";
            treeNode869.Text = "LDMusic";
            treeNode870.Name = "Node0";
            treeNode870.Text = "Version 1.0.0.18";
            treeNode871.Name = "Node1";
            treeNode871.Text = "AnimationPause and AnimationResume methods added";
            treeNode872.Name = "Node0";
            treeNode872.Text = "LDShapes";
            treeNode873.Name = "Node1";
            treeNode873.Text = "Process list indexed by ID rather than name";
            treeNode874.Name = "Node0";
            treeNode874.Text = "LDProcess";
            treeNode875.Name = "Node1";
            treeNode875.Text = "Version 1.0.0.17";
            treeNode876.Name = "Node1";
            treeNode876.Text = "More effects added";
            treeNode877.Name = "Node0";
            treeNode877.Text = "LDWebCam";
            treeNode878.Name = "Node1";
            treeNode878.Text = "Add or change an image on a button or image shape";
            treeNode879.Name = "Node1";
            treeNode879.Text = "Add an animated gif or tiled image";
            treeNode880.Name = "Node0";
            treeNode880.Text = "LDShapes";
            treeNode881.Name = "Node0";
            treeNode881.Text = "Version 1.0.0.16";
            treeNode882.Name = "Node1";
            treeNode882.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode883.Name = "Node0";
            treeNode883.Text = "LDWebCam";
            treeNode884.Name = "Node0";
            treeNode884.Text = "Version 1.0.0.15";
            treeNode885.Name = "Node2";
            treeNode885.Text = "Variables may be changed during a debug session";
            treeNode886.Name = "Node1";
            treeNode886.Text = "LDDebug";
            treeNode887.Name = "Node0";
            treeNode887.Text = "Version 1.0.0.14";
            treeNode888.Name = "Node1";
            treeNode888.Text = "A basic debugging tool";
            treeNode889.Name = "Node0";
            treeNode889.Text = "LDDebug";
            treeNode890.Name = "Node0";
            treeNode890.Text = "Version 1.0.0.13";
            treeNode891.Name = "Node2";
            treeNode891.Text = "Methods to convert between HSL and RGB";
            treeNode892.Name = "Node18";
            treeNode892.Text = "Method to set colour opacity";
            treeNode893.Name = "Node19";
            treeNode893.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode894.Name = "Node1";
            treeNode894.Text = "LDColours";
            treeNode895.Name = "Node4";
            treeNode895.Text = "Methods to add and subtract dates and times";
            treeNode896.Name = "Node3";
            treeNode896.Text = "LDDateTime";
            treeNode897.Name = "Node6";
            treeNode897.Text = "Waiting overlay, Calendar and About popups";
            treeNode898.Name = "Node17";
            treeNode898.Text = "Tooltips";
            treeNode899.Name = "Node5";
            treeNode899.Text = "LDDialogs";
            treeNode900.Name = "Node8";
            treeNode900.Text = "File change event";
            treeNode901.Name = "Node7";
            treeNode901.Text = "LDEvents";
            treeNode902.Name = "Node0";
            treeNode902.Text = "Version 1.0.0.12";
            treeNode903.Name = "Node12";
            treeNode903.Text = "Methods to sort arrays by index or value";
            treeNode904.Name = "Node22";
            treeNode904.Text = "Sorting by number and character strings";
            treeNode905.Name = "Node11";
            treeNode905.Text = "LDSort";
            treeNode906.Name = "Node14";
            treeNode906.Text = "Statistics on any array and distribution generation";
            treeNode907.Name = "Node20";
            treeNode907.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode908.Name = "Node21";
            treeNode908.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode909.Name = "Node13";
            treeNode909.Text = "LDStatistics";
            treeNode910.Name = "Node16";
            treeNode910.Text = "Voice and volume added";
            treeNode911.Name = "Node15";
            treeNode911.Text = "LDSpeech";
            treeNode912.Name = "Node9";
            treeNode912.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode21,
            treeNode32,
            treeNode47,
            treeNode62,
            treeNode75,
            treeNode84,
            treeNode99,
            treeNode110,
            treeNode124,
            treeNode133,
            treeNode145,
            treeNode156,
            treeNode159,
            treeNode168,
            treeNode175,
            treeNode182,
            treeNode195,
            treeNode206,
            treeNode211,
            treeNode218,
            treeNode221,
            treeNode235,
            treeNode243,
            treeNode249,
            treeNode264,
            treeNode279,
            treeNode285,
            treeNode293,
            treeNode308,
            treeNode325,
            treeNode328,
            treeNode334,
            treeNode340,
            treeNode350,
            treeNode359,
            treeNode362,
            treeNode382,
            treeNode388,
            treeNode391,
            treeNode400,
            treeNode408,
            treeNode414,
            treeNode419,
            treeNode425,
            treeNode428,
            treeNode441,
            treeNode444,
            treeNode449,
            treeNode454,
            treeNode457,
            treeNode463,
            treeNode467,
            treeNode470,
            treeNode476,
            treeNode480,
            treeNode488,
            treeNode494,
            treeNode500,
            treeNode503,
            treeNode510,
            treeNode517,
            treeNode525,
            treeNode528,
            treeNode531,
            treeNode537,
            treeNode542,
            treeNode549,
            treeNode554,
            treeNode560,
            treeNode563,
            treeNode570,
            treeNode575,
            treeNode579,
            treeNode592,
            treeNode600,
            treeNode605,
            treeNode611,
            treeNode614,
            treeNode621,
            treeNode624,
            treeNode632,
            treeNode635,
            treeNode638,
            treeNode642,
            treeNode646,
            treeNode649,
            treeNode652,
            treeNode655,
            treeNode658,
            treeNode661,
            treeNode664,
            treeNode667,
            treeNode671,
            treeNode674,
            treeNode677,
            treeNode680,
            treeNode688,
            treeNode690,
            treeNode696,
            treeNode702,
            treeNode707,
            treeNode712,
            treeNode715,
            treeNode718,
            treeNode721,
            treeNode724,
            treeNode730,
            treeNode733,
            treeNode736,
            treeNode739,
            treeNode748,
            treeNode751,
            treeNode754,
            treeNode758,
            treeNode767,
            treeNode773,
            treeNode778,
            treeNode787,
            treeNode790,
            treeNode793,
            treeNode798,
            treeNode803,
            treeNode806,
            treeNode809,
            treeNode812,
            treeNode819,
            treeNode824,
            treeNode829,
            treeNode836,
            treeNode839,
            treeNode847,
            treeNode852,
            treeNode855,
            treeNode858,
            treeNode861,
            treeNode864,
            treeNode870,
            treeNode875,
            treeNode881,
            treeNode884,
            treeNode887,
            treeNode890,
            treeNode902,
            treeNode912});
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