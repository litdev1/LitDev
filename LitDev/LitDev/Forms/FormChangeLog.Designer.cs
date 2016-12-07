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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode19,
            treeNode25,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode33,
            treeNode35,
            treeNode37,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode45,
            treeNode49,
            treeNode51,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode64,
            treeNode66,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode74,
            treeNode76,
            treeNode79,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode87,
            treeNode89,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode94,
            treeNode97,
            treeNode99,
            treeNode102,
            treeNode104,
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode110,
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode115,
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode109,
            treeNode112,
            treeNode114,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode123,
            treeNode125,
            treeNode127,
            treeNode129,
            treeNode131});
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode133,
            treeNode134,
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode136,
            treeNode138,
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode146,
            treeNode147,
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode150,
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode143,
            treeNode145,
            treeNode149,
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode155,
            treeNode157,
            treeNode159,
            treeNode161,
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode165});
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode169,
            treeNode171,
            treeNode173,
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode178,
            treeNode180,
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode185,
            treeNode187,
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode191,
            treeNode192});
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode194,
            treeNode195,
            treeNode196,
            treeNode197});
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode199});
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode201});
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode193,
            treeNode198,
            treeNode200,
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode206});
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode208});
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode205,
            treeNode207,
            treeNode209,
            treeNode211,
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode215});
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode217});
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode216,
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode221,
            treeNode223,
            treeNode225});
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode227});
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode230,
            treeNode231,
            treeNode232,
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode238,
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode234,
            treeNode237,
            treeNode240,
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode244,
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode249});
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode248,
            treeNode250});
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode252,
            treeNode253});
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode255});
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode254,
            treeNode256});
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode258,
            treeNode259,
            treeNode260,
            treeNode261,
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode264,
            treeNode265,
            treeNode266});
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode263,
            treeNode267,
            treeNode269,
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode277});
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode279});
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode281});
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode274,
            treeNode276,
            treeNode278,
            treeNode280,
            treeNode282,
            treeNode284,
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode290,
            treeNode292});
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode296,
            treeNode297,
            treeNode298,
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode295,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode304,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode307,
            treeNode308});
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode303,
            treeNode306,
            treeNode309,
            treeNode311,
            treeNode313,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode317,
            treeNode318});
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode322});
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode324,
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode321,
            treeNode323,
            treeNode326,
            treeNode328,
            treeNode330,
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode335});
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode337,
            treeNode338});
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode340});
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode339,
            treeNode341});
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode343,
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode345,
            treeNode347});
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode349,
            treeNode350,
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode353,
            treeNode355,
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode361});
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode360,
            treeNode362,
            treeNode364,
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode371,
            treeNode372});
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode374,
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode379,
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode373,
            treeNode376,
            treeNode378,
            treeNode381,
            treeNode383,
            treeNode385,
            treeNode387,
            treeNode389});
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode391,
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode393,
            treeNode395});
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode397});
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode404,
            treeNode405,
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode401,
            treeNode403,
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode411,
            treeNode412});
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode410,
            treeNode413,
            treeNode415});
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode417});
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode419,
            treeNode420});
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode418,
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode425});
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode424,
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode430,
            treeNode431});
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode429,
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode434});
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode435});
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode437,
            treeNode438});
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode446,
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode439,
            treeNode441,
            treeNode443,
            treeNode445,
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode455});
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode454,
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode459,
            treeNode461});
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode463});
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode464});
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode466,
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode468,
            treeNode470});
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode472,
            treeNode473});
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode479,
            treeNode480});
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode481,
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode485,
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode487});
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode491});
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode493,
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode490,
            treeNode492,
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode499,
            treeNode500});
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode498,
            treeNode501});
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode503,
            treeNode504,
            treeNode505,
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode507});
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode510});
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode512});
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode513,
            treeNode515,
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode520,
            treeNode522,
            treeNode524});
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode530,
            treeNode531});
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode527,
            treeNode529,
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode542,
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode541,
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode546,
            treeNode547,
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode549});
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode552,
            treeNode554,
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode559,
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode563});
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode565,
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode564,
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode570});
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode573,
            treeNode575,
            treeNode577});
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode579});
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode580,
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode584,
            treeNode585});
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode586});
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode597,
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode588,
            treeNode590,
            treeNode592,
            treeNode594,
            treeNode596,
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode601,
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode606});
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode603,
            treeNode605,
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode610,
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode614,
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode617});
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode616,
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode625,
            treeNode626,
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode624,
            treeNode628});
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode631});
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode635,
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode634,
            treeNode637,
            treeNode639});
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode642});
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode647,
            treeNode648});
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode651,
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode656});
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode667});
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode670});
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode676,
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode681});
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode689,
            treeNode691,
            treeNode693,
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode699,
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode701,
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode705,
            treeNode707,
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode712,
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode717,
            treeNode719});
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode733,
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode735,
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode748,
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode751});
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode753,
            treeNode754});
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode750,
            treeNode752,
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode763,
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode767,
            treeNode768,
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode770,
            treeNode772,
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode776,
            treeNode777});
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode778,
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode782});
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode783,
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode788,
            treeNode790,
            treeNode792,
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode800});
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode803,
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode808,
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode812});
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode823,
            treeNode824,
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode822,
            treeNode826});
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode829,
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode834,
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode840});
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode839,
            treeNode841,
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode845});
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode852,
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode849,
            treeNode851,
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode857,
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode871});
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode875,
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode874,
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode880,
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode886,
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode885,
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode890});
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode891});
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode894});
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode896});
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode897});
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode899,
            treeNode900,
            treeNode901});
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode905,
            treeNode906});
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode908});
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode902,
            treeNode904,
            treeNode907,
            treeNode909});
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode911,
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode914,
            treeNode915,
            treeNode916});
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode918});
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode913,
            treeNode917,
            treeNode919});
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
            treeNode14.Name = "Node0";
            treeNode14.Text = "General";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Version 1.2.14.0";
            treeNode16.Name = "Node2";
            treeNode16.Text = "TEMP tables allowed for SQLite databases";
            treeNode17.Name = "Node1";
            treeNode17.Text = "LDDataBase";
            treeNode18.Name = "Node1";
            treeNode18.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode19.Name = "Node0";
            treeNode19.Text = "LDMath";
            treeNode20.Name = "Node1";
            treeNode20.Text = "NormalMap method added for normal map 3D effects";
            treeNode21.Name = "Node2";
            treeNode21.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode22.Name = "Node5";
            treeNode22.Text = "MakeTransparent method added";
            treeNode23.Name = "Node6";
            treeNode23.Text = "ReplaceColour method added";
            treeNode24.Name = "Node0";
            treeNode24.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode25.Name = "Node0";
            treeNode25.Text = "LDImage";
            treeNode26.Name = "Node4";
            treeNode26.Text = "All image pixel manipulations speeded up";
            treeNode27.Name = "Node7";
            treeNode27.Text = "More Culture Invariace fixes";
            treeNode28.Name = "Node3";
            treeNode28.Text = "General";
            treeNode29.Name = "Node0";
            treeNode29.Text = "Version 1.2.13.0";
            treeNode30.Name = "Node1";
            treeNode30.Text = "Base conversions extended to include bases up to 36";
            treeNode31.Name = "Node0";
            treeNode31.Text = "LDMath";
            treeNode32.Name = "Node3";
            treeNode32.Text = "Updated to new Bing API";
            treeNode33.Name = "Node2";
            treeNode33.Text = "LDSearch";
            treeNode34.Name = "Node1";
            treeNode34.Text = "ShowInTaskbar property added";
            treeNode35.Name = "Node0";
            treeNode35.Text = "LDGraphicsWindow";
            treeNode36.Name = "Node1";
            treeNode36.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode37.Name = "Node0";
            treeNode37.Text = "LDFile";
            treeNode38.Name = "Node1";
            treeNode38.Text = "ToArray and FromArray methods added";
            treeNode39.Name = "Node0";
            treeNode39.Text = "LDxml";
            treeNode40.Name = "Node0";
            treeNode40.Text = "Version 1.2.12.0";
            treeNode41.Name = "Node2";
            treeNode41.Text = "DataViewColumnWidths method added";
            treeNode42.Name = "Node3";
            treeNode42.Text = "DataViewRowColours method added";
            treeNode43.Name = "Node1";
            treeNode43.Text = "LDControls";
            treeNode44.Name = "Node1";
            treeNode44.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode45.Name = "Node0";
            treeNode45.Text = "General";
            treeNode46.Name = "Node1";
            treeNode46.Text = "SetCentre method added";
            treeNode47.Name = "Node4";
            treeNode47.Text = "A 3rd rotation added";
            treeNode48.Name = "Node3";
            treeNode48.Text = "BoundingBox method added";
            treeNode49.Name = "Node0";
            treeNode49.Text = "LD3DView";
            treeNode50.Name = "Node3";
            treeNode50.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode51.Name = "Node2";
            treeNode51.Text = "LDDatabase";
            treeNode52.Name = "Node1";
            treeNode52.Text = "PlayMusic2 method added";
            treeNode53.Name = "Node2";
            treeNode53.Text = "Channel parameter added";
            treeNode54.Name = "Node0";
            treeNode54.Text = "LDMusic";
            treeNode55.Name = "Node0";
            treeNode55.Text = "Version 1.2.11.0";
            treeNode56.Name = "Node1";
            treeNode56.Text = "SetButtonStyle method added";
            treeNode57.Name = "Node0";
            treeNode57.Text = "LDControls";
            treeNode58.Name = "Node1";
            treeNode58.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode59.Name = "Node2";
            treeNode59.Text = "SetBillBoard method added";
            treeNode60.Name = "Node0";
            treeNode60.Text = "GetCameraUpDirection method added";
            treeNode61.Name = "Node1";
            treeNode61.Text = "Gradient brushes can be used";
            treeNode62.Name = "Node2";
            treeNode62.Text = "AutoControl method added";
            treeNode63.Name = "Node0";
            treeNode63.Text = "SpecularExponent property added";
            treeNode64.Name = "Node0";
            treeNode64.Text = "LD3DView";
            treeNode65.Name = "Node1";
            treeNode65.Text = "AddText method to annotate an image with text added";
            treeNode66.Name = "Node0";
            treeNode66.Text = "LDImage";
            treeNode67.Name = "Node4";
            treeNode67.Text = "BrushText for text on a brush added";
            treeNode68.Name = "Node0";
            treeNode68.Text = "Skew shapes method added";
            treeNode69.Name = "Node3";
            treeNode69.Text = "LDShapes";
            treeNode70.Name = "Node0";
            treeNode70.Text = "Version 1.2.10.0";
            treeNode71.Name = "Node1";
            treeNode71.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode72.Name = "Node0";
            treeNode72.Text = "LDUnits";
            treeNode73.Name = "Node1";
            treeNode73.Text = "Possible issue with FixSigFig fixed";
            treeNode74.Name = "Node0";
            treeNode74.Text = "LDMath";
            treeNode75.Name = "Node3";
            treeNode75.Text = "GetIndex method added (for SB arrays)";
            treeNode76.Name = "Node2";
            treeNode76.Text = "LDArray";
            treeNode77.Name = "Node5";
            treeNode77.Text = "Resize mode property added";
            treeNode78.Name = "Node6";
            treeNode78.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode79.Name = "Node4";
            treeNode79.Text = "LDGraphicsWindow";
            treeNode80.Name = "Node8";
            treeNode80.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode81.Name = "Node9";
            treeNode81.Text = "DataViewAllowUserEntry method added";
            treeNode82.Name = "Node7";
            treeNode82.Text = "LDControls";
            treeNode83.Name = "Node0";
            treeNode83.Text = "Version 1.2.9.0";
            treeNode84.Name = "Node1";
            treeNode84.Text = "New extended math object, starting with FFT";
            treeNode85.Name = "Node0";
            treeNode85.Text = "LDMathX";
            treeNode86.Name = "Node1";
            treeNode86.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode87.Name = "Node0";
            treeNode87.Text = "LDControls";
            treeNode88.Name = "Node3";
            treeNode88.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode89.Name = "Node2";
            treeNode89.Text = "LDArray";
            treeNode90.Name = "Node5";
            treeNode90.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode91.Name = "Node4";
            treeNode91.Text = "LDList";
            treeNode92.Name = "Node0";
            treeNode92.Text = "Version 1.2.8.0";
            treeNode93.Name = "Node2";
            treeNode93.Text = "Error handling, additional settings and multiple ports supported";
            treeNode94.Name = "Node1";
            treeNode94.Text = "LDCommPort";
            treeNode95.Name = "Node1";
            treeNode95.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode96.Name = "Node1";
            treeNode96.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode97.Name = "Node0";
            treeNode97.Text = "LDImage and LDWebCam";
            treeNode98.Name = "Node1";
            treeNode98.Text = "Bitwise operations object added";
            treeNode99.Name = "Node0";
            treeNode99.Text = "LDBits";
            treeNode100.Name = "Node1";
            treeNode100.Text = "Extended text encoding property added";
            treeNode101.Name = "Node0";
            treeNode101.Text = "TextWindow colours can be changed";
            treeNode102.Name = "Node0";
            treeNode102.Text = "LDTextWindow";
            treeNode103.Name = "Node1";
            treeNode103.Text = "GetWorkingImagePixelARGB method added";
            treeNode104.Name = "Node0";
            treeNode104.Text = "LDImage";
            treeNode105.Name = "Node1";
            treeNode105.Text = "RasteriseTurtleLines method added";
            treeNode106.Name = "Node0";
            treeNode106.Text = "LDShapes";
            treeNode107.Name = "Node0";
            treeNode107.Text = "Version 1.2.7.0";
            treeNode108.Name = "Node1";
            treeNode108.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode109.Name = "Node0";
            treeNode109.Text = "LDDialogs";
            treeNode110.Name = "Node1";
            treeNode110.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode111.Name = "Node2";
            treeNode111.Text = "ToggleSensor added";
            treeNode112.Name = "Node0";
            treeNode112.Text = "LDPhysics";
            treeNode113.Name = "Node1";
            treeNode113.Text = "Allow multiple copies of the webcam image";
            treeNode114.Name = "Node0";
            treeNode114.Text = "LDWebCam";
            treeNode115.Name = "Node1";
            treeNode115.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode116.Name = "Node0";
            treeNode116.Text = "MetaData method added";
            treeNode117.Name = "Node0";
            treeNode117.Text = "LDImage";
            treeNode118.Name = "Node0";
            treeNode118.Text = "Version 1.2.6.0";
            treeNode119.Name = "Node2";
            treeNode119.Text = "FixSigFig and FixDecimal methods added";
            treeNode120.Name = "Node3";
            treeNode120.Text = "MinNumber and MaxNumber properties added";
            treeNode121.Name = "Node1";
            treeNode121.Text = "LDMath";
            treeNode122.Name = "Node1";
            treeNode122.Text = "SliderMaximum property added";
            treeNode123.Name = "Node0";
            treeNode123.Text = "LDControls";
            treeNode124.Name = "Node1";
            treeNode124.Text = "ZoomAll method added";
            treeNode125.Name = "Node0";
            treeNode125.Text = "LDShapes";
            treeNode126.Name = "Node1";
            treeNode126.Text = "Reposition methods and properties added";
            treeNode127.Name = "Node0";
            treeNode127.Text = "LDGraphicsWindow";
            treeNode128.Name = "Node1";
            treeNode128.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode129.Name = "Node0";
            treeNode129.Text = "LDImage";
            treeNode130.Name = "Node1";
            treeNode130.Text = "MouseScroll parameter added";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDScrollBars";
            treeNode132.Name = "Node0";
            treeNode132.Text = "Version 1.2.5.0";
            treeNode133.Name = "Node0";
            treeNode133.Text = "New object added (previously a separate extension)";
            treeNode134.Name = "Node1";
            treeNode134.Text = "Async, Loop, Volume and Pan properties added";
            treeNode135.Name = "Node2";
            treeNode135.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode136.Name = "Node1";
            treeNode136.Text = "LDWaveForm";
            treeNode137.Name = "Node1";
            treeNode137.Text = "New object added to get input from gamepads or joysticks";
            treeNode138.Name = "Node0";
            treeNode138.Text = "LDController";
            treeNode139.Name = "Node1";
            treeNode139.Text = "RayCast method added";
            treeNode140.Name = "Node0";
            treeNode140.Text = "LDPhysics";
            treeNode141.Name = "Node0";
            treeNode141.Text = "Version 1.2.4.0";
            treeNode142.Name = "Node2";
            treeNode142.Text = "New object to apply effects to any shape or control";
            treeNode143.Name = "Node1";
            treeNode143.Text = "LDEffects";
            treeNode144.Name = "Node1";
            treeNode144.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode145.Name = "Node0";
            treeNode145.Text = "LDFigures";
            treeNode146.Name = "Node1";
            treeNode146.Text = "SetGroup method added";
            treeNode147.Name = "Node2";
            treeNode147.Text = "GetContacts method added";
            treeNode148.Name = "Node0";
            treeNode148.Text = "GetAllShapesAt method added";
            treeNode149.Name = "Node0";
            treeNode149.Text = "LDPhysics";
            treeNode150.Name = "Node2";
            treeNode150.Text = "SetImage handles images with transparency";
            treeNode151.Name = "Node0";
            treeNode151.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode152.Name = "Node1";
            treeNode152.Text = "LDClipboard";
            treeNode153.Name = "Node0";
            treeNode153.Text = "Version 1.2.3.0";
            treeNode154.Name = "Node2";
            treeNode154.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode155.Name = "Node1";
            treeNode155.Text = "LDShapes";
            treeNode156.Name = "Node4";
            treeNode156.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode157.Name = "Node3";
            treeNode157.Text = "LDFile";
            treeNode158.Name = "Node6";
            treeNode158.Text = "NewImage method added";
            treeNode159.Name = "Node5";
            treeNode159.Text = "LDImage";
            treeNode160.Name = "Node1";
            treeNode160.Text = "SetStartupPosition method added to position dialogs";
            treeNode161.Name = "Node0";
            treeNode161.Text = "LDDialogs";
            treeNode162.Name = "Node1";
            treeNode162.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode163.Name = "Node0";
            treeNode163.Text = "LDGraph";
            treeNode164.Name = "Node0";
            treeNode164.Text = "Version 1.2.2.0";
            treeNode165.Name = "Node2";
            treeNode165.Text = "Recompiled for Small Basic version 1.2";
            treeNode166.Name = "Node1";
            treeNode166.Text = "Version 1.2";
            treeNode167.Name = "Node0";
            treeNode167.Text = "Version 1.2.0.1";
            treeNode168.Name = "Node2";
            treeNode168.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode169.Name = "Node1";
            treeNode169.Text = "LDDialogs";
            treeNode170.Name = "Node1";
            treeNode170.Text = "Logical operations object added";
            treeNode171.Name = "Node0";
            treeNode171.Text = "LDLogic";
            treeNode172.Name = "Node4";
            treeNode172.Text = "CurrentCulture property added";
            treeNode173.Name = "Node3";
            treeNode173.Text = "LDUtilities";
            treeNode174.Name = "Node6";
            treeNode174.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode175.Name = "Node5";
            treeNode175.Text = "LDMath";
            treeNode176.Name = "Node0";
            treeNode176.Text = "Version 1.1.0.8";
            treeNode177.Name = "Node1";
            treeNode177.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode178.Name = "Node0";
            treeNode178.Text = "LDControls";
            treeNode179.Name = "Node1";
            treeNode179.Text = "Methods added to add and remove nodes and save xml file";
            treeNode180.Name = "Node0";
            treeNode180.Text = "LDxml";
            treeNode181.Name = "Node1";
            treeNode181.Text = "MusicPlayTime moved from LDFile";
            treeNode182.Name = "Node0";
            treeNode182.Text = "LDSound";
            treeNode183.Name = "Node0";
            treeNode183.Text = "Version 1.1.0.7";
            treeNode184.Name = "Node4";
            treeNode184.Text = "SplitImage method added";
            treeNode185.Name = "Node3";
            treeNode185.Text = "LDImage";
            treeNode186.Name = "Node6";
            treeNode186.Text = "EditTable and SaveTable methods added";
            treeNode187.Name = "Node5";
            treeNode187.Text = "LDDatabse";
            treeNode188.Name = "Node2";
            treeNode188.Text = "DataView control and methods added";
            treeNode189.Name = "Node1";
            treeNode189.Text = "LDControls";
            treeNode190.Name = "Node2";
            treeNode190.Text = "Version 1.1.0.6";
            treeNode191.Name = "Node2";
            treeNode191.Text = "Exists modified to check for directory as well as file";
            treeNode192.Name = "Node3";
            treeNode192.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode193.Name = "Node1";
            treeNode193.Text = "LDFile";
            treeNode194.Name = "Node5";
            treeNode194.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode195.Name = "Node6";
            treeNode195.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode196.Name = "Node9";
            treeNode196.Text = "Conditonal break point added";
            treeNode197.Name = "Node0";
            treeNode197.Text = "Step over button added";
            treeNode198.Name = "Node4";
            treeNode198.Text = "LDDebug";
            treeNode199.Name = "Node8";
            treeNode199.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode200.Name = "Node7";
            treeNode200.Text = "LDGraphicsWindow";
            treeNode201.Name = "Node1";
            treeNode201.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode202.Name = "Node0";
            treeNode202.Text = "LDResources";
            treeNode203.Name = "Node0";
            treeNode203.Text = "Version 1.1.0.5";
            treeNode204.Name = "Node2";
            treeNode204.Text = "ClipboardChanged event added";
            treeNode205.Name = "Node1";
            treeNode205.Text = "LDClipboard";
            treeNode206.Name = "Node1";
            treeNode206.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode207.Name = "Node0";
            treeNode207.Text = "LDFile";
            treeNode208.Name = "Node3";
            treeNode208.Text = "SetActive method added";
            treeNode209.Name = "Node2";
            treeNode209.Text = "LDGraphicsWindow";
            treeNode210.Name = "Node1";
            treeNode210.Text = "Parse xml file nodes";
            treeNode211.Name = "Node0";
            treeNode211.Text = "LDxml";
            treeNode212.Name = "Node3";
            treeNode212.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode213.Name = "Node2";
            treeNode213.Text = "General";
            treeNode214.Name = "Node0";
            treeNode214.Text = "Version 1.1.0.4";
            treeNode215.Name = "Node2";
            treeNode215.Text = "WakeAll method addded";
            treeNode216.Name = "Node1";
            treeNode216.Text = "LDPhysics";
            treeNode217.Name = "Node1";
            treeNode217.Text = "Clipboard methods added";
            treeNode218.Name = "Node0";
            treeNode218.Text = "LDClipboard";
            treeNode219.Name = "Node0";
            treeNode219.Text = "Version 1.1.0.3";
            treeNode220.Name = "Node6";
            treeNode220.Text = "SizeNWSE cursor added";
            treeNode221.Name = "Node5";
            treeNode221.Text = "LDCursors";
            treeNode222.Name = "Node8";
            treeNode222.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode223.Name = "Node7";
            treeNode223.Text = "LDGraph";
            treeNode224.Name = "Node1";
            treeNode224.Text = "SQLite updated for .Net 4.5";
            treeNode225.Name = "Node0";
            treeNode225.Text = "LDDataBase";
            treeNode226.Name = "Node4";
            treeNode226.Text = "Version 1.1.0.2";
            treeNode227.Name = "Node3";
            treeNode227.Text = "Recompiled for Small Basic version 1.1";
            treeNode228.Name = "Node2";
            treeNode228.Text = "Version 1.1";
            treeNode229.Name = "Node0";
            treeNode229.Text = "Version 1.1.0.1";
            treeNode230.Name = "Node12";
            treeNode230.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode231.Name = "Node13";
            treeNode231.Text = "RichTextBoxMargins method added";
            treeNode232.Name = "Node0";
            treeNode232.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode233.Name = "Node1";
            treeNode233.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode234.Name = "Node11";
            treeNode234.Text = "LDControls";
            treeNode235.Name = "Node3";
            treeNode235.Text = "Error reporting added";
            treeNode236.Name = "Node4";
            treeNode236.Text = "SetEncoding method added";
            treeNode237.Name = "Node2";
            treeNode237.Text = "LDCommPort";
            treeNode238.Name = "Node6";
            treeNode238.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode239.Name = "Node7";
            treeNode239.Text = "Export to excel fix for graph with no title";
            treeNode240.Name = "Node5";
            treeNode240.Text = "LDGraph";
            treeNode241.Name = "Node9";
            treeNode241.Text = "Negative restitution option when adding moving shape";
            treeNode242.Name = "Node8";
            treeNode242.Text = "LDPhysics";
            treeNode243.Name = "Node10";
            treeNode243.Text = "Version 1.0.0.133";
            treeNode244.Name = "Node2";
            treeNode244.Text = "Internal improvements to auto messaging";
            treeNode245.Name = "Node9";
            treeNode245.Text = "Name can be set and GetClients method added";
            treeNode246.Name = "Node1";
            treeNode246.Text = "LDClient";
            treeNode247.Name = "Node4";
            treeNode247.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode248.Name = "Node3";
            treeNode248.Text = "LDControls";
            treeNode249.Name = "Node8";
            treeNode249.Text = "Return message and possible file error fixed for Stop method";
            treeNode250.Name = "Node7";
            treeNode250.Text = "LDSound";
            treeNode251.Name = "Node0";
            treeNode251.Text = "Version 1.0.0.132";
            treeNode252.Name = "Node2";
            treeNode252.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode253.Name = "Node5";
            treeNode253.Text = "Compile method added to compile a Small Basic program";
            treeNode254.Name = "Node1";
            treeNode254.Text = "LDCall";
            treeNode255.Name = "Node4";
            treeNode255.Text = "Methods and code by Pappa Lapub added";
            treeNode256.Name = "Node3";
            treeNode256.Text = "LDShell";
            treeNode257.Name = "Node0";
            treeNode257.Text = "Version 1.0.0.131";
            treeNode258.Name = "Node6";
            treeNode258.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode259.Name = "Node7";
            treeNode259.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode260.Name = "Node8";
            treeNode260.Text = "Refactoring of all the pan, follow and box methods";
            treeNode261.Name = "Node6";
            treeNode261.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode262.Name = "Node8";
            treeNode262.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode263.Name = "Node5";
            treeNode263.Text = "LDPhysics";
            treeNode264.Name = "Node1";
            treeNode264.Text = "UseBinary property added";
            treeNode265.Name = "Node2";
            treeNode265.Text = "DoAsync property and associated completion events added";
            treeNode266.Name = "Node3";
            treeNode266.Text = "Delete method added";
            treeNode267.Name = "Node0";
            treeNode267.Text = "LDftp";
            treeNode268.Name = "Node5";
            treeNode268.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode269.Name = "Node4";
            treeNode269.Text = "LDCall";
            treeNode270.Name = "Node2";
            treeNode270.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode271.Name = "Node1";
            treeNode271.Text = "LDControls";
            treeNode272.Name = "Node4";
            treeNode272.Text = "Version 1.0.0.130";
            treeNode273.Name = "Node2";
            treeNode273.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode274.Name = "Node1";
            treeNode274.Text = "LDMath";
            treeNode275.Name = "Node1";
            treeNode275.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode276.Name = "Node0";
            treeNode276.Text = "LDPhysics";
            treeNode277.Name = "Node3";
            treeNode277.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode278.Name = "Node2";
            treeNode278.Text = "LDGraphicsWindow";
            treeNode279.Name = "Node1";
            treeNode279.Text = "FTP object methods added";
            treeNode280.Name = "Node0";
            treeNode280.Text = "LDftp";
            treeNode281.Name = "Node3";
            treeNode281.Text = "An existing file is replaced";
            treeNode282.Name = "Node2";
            treeNode282.Text = "LDZip";
            treeNode283.Name = "Node1";
            treeNode283.Text = "Size method added";
            treeNode284.Name = "Node0";
            treeNode284.Text = "LDFile";
            treeNode285.Name = "Node3";
            treeNode285.Text = "DownloadFile method added";
            treeNode286.Name = "Node2";
            treeNode286.Text = "LDNetwork";
            treeNode287.Name = "Node0";
            treeNode287.Text = "Version 1.0.0.129";
            treeNode288.Name = "Node2";
            treeNode288.Text = "Generalised joint connections added";
            treeNode289.Name = "Node0";
            treeNode289.Text = "AddExplosion method added";
            treeNode290.Name = "Node1";
            treeNode290.Text = "LDPhysics";
            treeNode291.Name = "Node1";
            treeNode291.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode292.Name = "Node0";
            treeNode292.Text = "LDShapes";
            treeNode293.Name = "Node0";
            treeNode293.Text = "Version 1.0.0.128";
            treeNode294.Name = "Node2";
            treeNode294.Text = "CheckServer method added";
            treeNode295.Name = "Node1";
            treeNode295.Text = "LDClient";
            treeNode296.Name = "Node1";
            treeNode296.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode297.Name = "Node2";
            treeNode297.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode298.Name = "Node3";
            treeNode298.Text = "GetAngle method added";
            treeNode299.Name = "Node4";
            treeNode299.Text = "Top-down tire (to model a car from above) methods added";
            treeNode300.Name = "Node0";
            treeNode300.Text = "LDPhysics";
            treeNode301.Name = "Node0";
            treeNode301.Text = "Version 1.0.0.127";
            treeNode302.Name = "Node7";
            treeNode302.Text = "Bug fixes for Overlap methods";
            treeNode303.Name = "Node6";
            treeNode303.Text = "LDShapes";
            treeNode304.Name = "Node0";
            treeNode304.Text = "Bug fix for multiple numeric sorts";
            treeNode305.Name = "Node9";
            treeNode305.Text = "ByValueWithIndex method added";
            treeNode306.Name = "Node8";
            treeNode306.Text = "LDSort";
            treeNode307.Name = "Node1";
            treeNode307.Text = "LAN method added to get local IP addresses";
            treeNode308.Name = "Node2";
            treeNode308.Text = "Ping method added";
            treeNode309.Name = "Node0";
            treeNode309.Text = "LDNetwork";
            treeNode310.Name = "Node1";
            treeNode310.Text = "LoadSVG method added";
            treeNode311.Name = "Node0";
            treeNode311.Text = "LDImage";
            treeNode312.Name = "Node3";
            treeNode312.Text = "Evaluate method added";
            treeNode313.Name = "Node2";
            treeNode313.Text = "LDMath";
            treeNode314.Name = "Node5";
            treeNode314.Text = "IncludeJScript method added";
            treeNode315.Name = "Node4";
            treeNode315.Text = "LDInline";
            treeNode316.Name = "Node5";
            treeNode316.Text = "Version 1.0.0.126";
            treeNode317.Name = "Node0";
            treeNode317.Text = "Special emphasis on async consistency";
            treeNode318.Name = "Node4";
            treeNode318.Text = "Simplified auto method for multi-player game data transfer";
            treeNode319.Name = "Node9";
            treeNode319.Text = "LDServer and LDClient objects added";
            treeNode320.Name = "Node2";
            treeNode320.Text = "GetWidth and GetHeight methods added";
            treeNode321.Name = "Node1";
            treeNode321.Text = "LDText";
            treeNode322.Name = "Node4";
            treeNode322.Text = "Bing web search";
            treeNode323.Name = "Node3";
            treeNode323.Text = "LDSearch";
            treeNode324.Name = "Node6";
            treeNode324.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode325.Name = "Node7";
            treeNode325.Text = "KeyScroll property added";
            treeNode326.Name = "Node5";
            treeNode326.Text = "LDScrollBars";
            treeNode327.Name = "Node9";
            treeNode327.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode328.Name = "Node8";
            treeNode328.Text = "LDShapes";
            treeNode329.Name = "Node1";
            treeNode329.Text = "SaveAs method bug fixed";
            treeNode330.Name = "Node0";
            treeNode330.Text = "LDImage";
            treeNode331.Name = "Node3";
            treeNode331.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode332.Name = "Node2";
            treeNode332.Text = "LDQueue";
            treeNode333.Name = "Node8";
            treeNode333.Text = "Version 1.0.0.125";
            treeNode334.Name = "Node7";
            treeNode334.Text = "Language translation object added";
            treeNode335.Name = "Node6";
            treeNode335.Text = "LDTranslate";
            treeNode336.Name = "Node5";
            treeNode336.Text = "Version 1.0.0.124";
            treeNode337.Name = "Node1";
            treeNode337.Text = "Mouse screen coordinate conversion parameters added";
            treeNode338.Name = "Node2";
            treeNode338.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode339.Name = "Node0";
            treeNode339.Text = "LDGraphicsWindow";
            treeNode340.Name = "Node4";
            treeNode340.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode341.Name = "Node3";
            treeNode341.Text = "LDUtilities";
            treeNode342.Name = "Node0";
            treeNode342.Text = "Version 1.0.0.123";
            treeNode343.Name = "Node5";
            treeNode343.Text = "ColorMatrix method added";
            treeNode344.Name = "Node0";
            treeNode344.Text = "Rotate method added";
            treeNode345.Name = "Node3";
            treeNode345.Text = "LDImage";
            treeNode346.Name = "Node1";
            treeNode346.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode347.Name = "Node0";
            treeNode347.Text = "LDChart";
            treeNode348.Name = "Node2";
            treeNode348.Text = "Version 1.0.0.122";
            treeNode349.Name = "Node2";
            treeNode349.Text = "EffectGamma added to darken and lighten";
            treeNode350.Name = "Node4";
            treeNode350.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode351.Name = "Node3";
            treeNode351.Text = "EffectContrast modified";
            treeNode352.Name = "Node0";
            treeNode352.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode353.Name = "Node1";
            treeNode353.Text = "LDImage";
            treeNode354.Name = "Node2";
            treeNode354.Text = "Error event added for all extension exceptions";
            treeNode355.Name = "Node1";
            treeNode355.Text = "LDEvents";
            treeNode356.Name = "Node1";
            treeNode356.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode357.Name = "Node0";
            treeNode357.Text = "LDMath";
            treeNode358.Name = "Node0";
            treeNode358.Text = "Version 1.0.0.121";
            treeNode359.Name = "Node2";
            treeNode359.Text = "FloodFill transparency effect fixed";
            treeNode360.Name = "Node1";
            treeNode360.Text = "LDGraphicsWindow";
            treeNode361.Name = "Node1";
            treeNode361.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode362.Name = "Node0";
            treeNode362.Text = "LDFile";
            treeNode363.Name = "Node1";
            treeNode363.Text = "EffectPixelate added";
            treeNode364.Name = "Node0";
            treeNode364.Text = "LDImage";
            treeNode365.Name = "Node1";
            treeNode365.Text = "Modified to work with Windows 8";
            treeNode366.Name = "Node0";
            treeNode366.Text = "LDWebCam";
            treeNode367.Name = "Node0";
            treeNode367.Text = "Version 1.0.0.120";
            treeNode368.Name = "Node2";
            treeNode368.Text = "FloodFill method added";
            treeNode369.Name = "Node1";
            treeNode369.Text = "LDGraphicsWindow";
            treeNode370.Name = "Node0";
            treeNode370.Text = "Version 1.0.0.119";
            treeNode371.Name = "Node0";
            treeNode371.Text = "SetShapeCursor method added";
            treeNode372.Name = "Node11";
            treeNode372.Text = "CreateCursor method added";
            treeNode373.Name = "Node9";
            treeNode373.Text = "LDCursors";
            treeNode374.Name = "Node2";
            treeNode374.Text = "SaveAs method to save in different file formats";
            treeNode375.Name = "Node0";
            treeNode375.Text = "Parameters added for some effects";
            treeNode376.Name = "Node1";
            treeNode376.Text = "LDImage";
            treeNode377.Name = "Node2";
            treeNode377.Text = "Parameters added for some effects";
            treeNode378.Name = "Node1";
            treeNode378.Text = "LDWebCam";
            treeNode379.Name = "Node1";
            treeNode379.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode380.Name = "Node0";
            treeNode380.Text = "SetFontFromFile method added for ttf fonts";
            treeNode381.Name = "Node0";
            treeNode381.Text = "LDGraphicsWindow";
            treeNode382.Name = "Node3";
            treeNode382.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode383.Name = "Node2";
            treeNode383.Text = "LDTextWindow";
            treeNode384.Name = "Node2";
            treeNode384.Text = "Zip methods moved here from LDUtilities";
            treeNode385.Name = "Node0";
            treeNode385.Text = "LDZip";
            treeNode386.Name = "Node3";
            treeNode386.Text = "Regex methods moved here from LDUtilities";
            treeNode387.Name = "Node1";
            treeNode387.Text = "LDRegex";
            treeNode388.Name = "Node1";
            treeNode388.Text = "ListViewRowCount method added";
            treeNode389.Name = "Node0";
            treeNode389.Text = "LDControls";
            treeNode390.Name = "Node3";
            treeNode390.Text = "Version 1.0.0.118";
            treeNode391.Name = "Node5";
            treeNode391.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode392.Name = "Node6";
            treeNode392.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode393.Name = "Node4";
            treeNode393.Text = "LDUtilities";
            treeNode394.Name = "Node10";
            treeNode394.Text = "SetUserCursor method added";
            treeNode395.Name = "Node4";
            treeNode395.Text = "LDCursors";
            treeNode396.Name = "Node3";
            treeNode396.Text = "Version 1.0.0.117";
            treeNode397.Name = "Node2";
            treeNode397.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode398.Name = "Node1";
            treeNode398.Text = "LDDictionary";
            treeNode399.Name = "Node0";
            treeNode399.Text = "Version 1.0.0.116";
            treeNode400.Name = "Node2";
            treeNode400.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode401.Name = "Node1";
            treeNode401.Text = "LDColours";
            treeNode402.Name = "Node4";
            treeNode402.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode403.Name = "Node3";
            treeNode403.Text = "LDShapes";
            treeNode404.Name = "Node1";
            treeNode404.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode405.Name = "Node0";
            treeNode405.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode406.Name = "Node1";
            treeNode406.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode407.Name = "Node0";
            treeNode407.Text = "LDGraph";
            treeNode408.Name = "Node0";
            treeNode408.Text = "Version 1.0.0.115";
            treeNode409.Name = "Node2";
            treeNode409.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode410.Name = "Node1";
            treeNode410.Text = "LDControls";
            treeNode411.Name = "Node4";
            treeNode411.Text = "RemoveTurtleLines method added";
            treeNode412.Name = "Node6";
            treeNode412.Text = "GetAllShapes method added";
            treeNode413.Name = "Node3";
            treeNode413.Text = "LDShapes";
            treeNode414.Name = "Node1";
            treeNode414.Text = "Odbc connection added";
            treeNode415.Name = "Node0";
            treeNode415.Text = "LDDatabase";
            treeNode416.Name = "Node0";
            treeNode416.Text = "Version 1.0.0.114";
            treeNode417.Name = "Node2";
            treeNode417.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode418.Name = "Node1";
            treeNode418.Text = "LDUtilities";
            treeNode419.Name = "Node4";
            treeNode419.Text = "ListView control added";
            treeNode420.Name = "Node5";
            treeNode420.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode421.Name = "Node3";
            treeNode421.Text = "LDControls";
            treeNode422.Name = "Node0";
            treeNode422.Text = "Version 1.0.0.113";
            treeNode423.Name = "Node2";
            treeNode423.Text = "Tone method added";
            treeNode424.Name = "Node1";
            treeNode424.Text = "LDSound";
            treeNode425.Name = "Node5";
            treeNode425.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode426.Name = "Node4";
            treeNode426.Text = "LDControls";
            treeNode427.Name = "Node0";
            treeNode427.Text = "Version 1.0.0.112";
            treeNode428.Name = "Node2";
            treeNode428.Text = "SqlServer and Access database support added";
            treeNode429.Name = "Node1";
            treeNode429.Text = "LDDataBase";
            treeNode430.Name = "Node4";
            treeNode430.Text = "FixFlickr method added";
            treeNode431.Name = "Node0";
            treeNode431.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode432.Name = "Node3";
            treeNode432.Text = "LDUtilities";
            treeNode433.Name = "Node0";
            treeNode433.Text = "Version 1.0.0.111";
            treeNode434.Name = "Node2";
            treeNode434.Text = "TextBoxTab method added";
            treeNode435.Name = "Node1";
            treeNode435.Text = "LDControls";
            treeNode436.Name = "Node0";
            treeNode436.Text = "Version 1.0.0.110";
            treeNode437.Name = "Node1";
            treeNode437.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode438.Name = "Node3";
            treeNode438.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode439.Name = "Node0";
            treeNode439.Text = "General";
            treeNode440.Name = "Node5";
            treeNode440.Text = "Exists method added to check if a file path exists or not";
            treeNode441.Name = "Node4";
            treeNode441.Text = "LDFile";
            treeNode442.Name = "Node7";
            treeNode442.Text = "Start method handles attaching to existing process without warning";
            treeNode443.Name = "Node6";
            treeNode443.Text = "LDProcess";
            treeNode444.Name = "Node1";
            treeNode444.Text = "MySQL database support added";
            treeNode445.Name = "Node0";
            treeNode445.Text = "LDDatabase";
            treeNode446.Name = "Node3";
            treeNode446.Text = "Add and Multiply methods honour transparency";
            treeNode447.Name = "Node4";
            treeNode447.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode448.Name = "Node2";
            treeNode448.Text = "LDImage";
            treeNode449.Name = "Node3";
            treeNode449.Text = "Version 1.0.0.109";
            treeNode450.Name = "Node2";
            treeNode450.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode451.Name = "Node1";
            treeNode451.Text = "LDTextWindow";
            treeNode452.Name = "Node0";
            treeNode452.Text = "Version 1.0.0.108";
            treeNode453.Name = "Node14";
            treeNode453.Text = "Transparent colour added";
            treeNode454.Name = "Node13";
            treeNode454.Text = "LDColours";
            treeNode455.Name = "Node16";
            treeNode455.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode456.Name = "Node15";
            treeNode456.Text = "LDDialogs";
            treeNode457.Name = "Node12";
            treeNode457.Text = "Version 1.0.0.107";
            treeNode458.Name = "Node8";
            treeNode458.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode459.Name = "Node7";
            treeNode459.Text = "LDControls";
            treeNode460.Name = "Node11";
            treeNode460.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode461.Name = "Node10";
            treeNode461.Text = "LDShapes";
            treeNode462.Name = "Node6";
            treeNode462.Text = "Version 1.0.0.106";
            treeNode463.Name = "Node5";
            treeNode463.Text = "Menu control added";
            treeNode464.Name = "Node4";
            treeNode464.Text = "LDControls";
            treeNode465.Name = "Node3";
            treeNode465.Text = "Version 1.0.0.105";
            treeNode466.Name = "Node5";
            treeNode466.Text = "ZipList method added";
            treeNode467.Name = "Node2";
            treeNode467.Text = "GetNextMapIndex method added";
            treeNode468.Name = "Node4";
            treeNode468.Text = "LDUtilities";
            treeNode469.Name = "Node1";
            treeNode469.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode470.Name = "Node0";
            treeNode470.Text = "LDShapes";
            treeNode471.Name = "Node3";
            treeNode471.Text = "Version 1.0.0.104";
            treeNode472.Name = "Node1";
            treeNode472.Text = "Transparency maintained for various methods";
            treeNode473.Name = "Node2";
            treeNode473.Text = "Effects bug fixed";
            treeNode474.Name = "Node0";
            treeNode474.Text = "LDImage";
            treeNode475.Name = "Node0";
            treeNode475.Text = "Version 1.0.0.103";
            treeNode476.Name = "Node1";
            treeNode476.Text = "Current application assemblies are all auto-referenced";
            treeNode477.Name = "Node0";
            treeNode477.Text = "LDInline";
            treeNode478.Name = "Node5";
            treeNode478.Text = "Version 1.0.0.102";
            treeNode479.Name = "Node1";
            treeNode479.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode480.Name = "Node2";
            treeNode480.Text = "LDInline.sb sample provided";
            treeNode481.Name = "Node0";
            treeNode481.Text = "LDInline";
            treeNode482.Name = "Node4";
            treeNode482.Text = "ExitButtonMode method added to control window close button state";
            treeNode483.Name = "Node3";
            treeNode483.Text = "LDUtilities";
            treeNode484.Name = "Node0";
            treeNode484.Text = "Version 1.0.0.101";
            treeNode485.Name = "Node1";
            treeNode485.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode486.Name = "Node0";
            treeNode486.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode487.Name = "Node0";
            treeNode487.Text = "LDTextWindow";
            treeNode488.Name = "Node0";
            treeNode488.Text = "Version 1.0.0.100";
            treeNode489.Name = "Node2";
            treeNode489.Text = "ReadANSIToArray method added";
            treeNode490.Name = "Node1";
            treeNode490.Text = "LDFile";
            treeNode491.Name = "Node1";
            treeNode491.Text = "DocumentViewer control added";
            treeNode492.Name = "Node0";
            treeNode492.Text = "LDControls";
            treeNode493.Name = "Node3";
            treeNode493.Text = "An object to batch update shapes (for speed reasons)";
            treeNode494.Name = "Node0";
            treeNode494.Text = "LDFastShapes.sb sample included";
            treeNode495.Name = "Node2";
            treeNode495.Text = "LDFastShapes";
            treeNode496.Name = "Node0";
            treeNode496.Text = "Version 1.0.0.99";
            treeNode497.Name = "Node1";
            treeNode497.Text = "Rendering performance improvements when many shapes present";
            treeNode498.Name = "Node0";
            treeNode498.Text = "LDPhysics";
            treeNode499.Name = "Node1";
            treeNode499.Text = "ANSItoUTF8 method added";
            treeNode500.Name = "Node2";
            treeNode500.Text = "ReadANSI method added";
            treeNode501.Name = "Node0";
            treeNode501.Text = "LDFile";
            treeNode502.Name = "Node1";
            treeNode502.Text = "Version 1.0.0.98";
            treeNode503.Name = "Node3";
            treeNode503.Text = "Move method added for tiangles, polygons and lines";
            treeNode504.Name = "Node4";
            treeNode504.Text = "RotateAbout method added";
            treeNode505.Name = "Node1";
            treeNode505.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode506.Name = "Node0";
            treeNode506.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode507.Name = "Node2";
            treeNode507.Text = "LDShapes";
            treeNode508.Name = "Node0";
            treeNode508.Text = "Version 1.0.0.97";
            treeNode509.Name = "Node4";
            treeNode509.Text = "A list storage object added";
            treeNode510.Name = "Node3";
            treeNode510.Text = "LDList";
            treeNode511.Name = "Node2";
            treeNode511.Text = "Version 1.0.0.96";
            treeNode512.Name = "Node4";
            treeNode512.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode513.Name = "Node3";
            treeNode513.Text = "LDQueue";
            treeNode514.Name = "Node6";
            treeNode514.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode515.Name = "Node5";
            treeNode515.Text = "LDNetwork";
            treeNode516.Name = "Node0";
            treeNode516.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode517.Name = "Node1";
            treeNode517.Text = "General";
            treeNode518.Name = "Node2";
            treeNode518.Text = "Version 1.0.0.95";
            treeNode519.Name = "Node2";
            treeNode519.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode520.Name = "Node1";
            treeNode520.Text = "LDEncryption";
            treeNode521.Name = "Node1";
            treeNode521.Text = "RandomNumberSeed property added";
            treeNode522.Name = "Node0";
            treeNode522.Text = "LDMath";
            treeNode523.Name = "Node1";
            treeNode523.Text = "SetGameData and GetGameData methods added";
            treeNode524.Name = "Node0";
            treeNode524.Text = "LDNetwork";
            treeNode525.Name = "Node0";
            treeNode525.Text = "Version 1.0.0.94";
            treeNode526.Name = "Node1";
            treeNode526.Text = "SliderGetValue method added";
            treeNode527.Name = "Node0";
            treeNode527.Text = "LDControls";
            treeNode528.Name = "Node5";
            treeNode528.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode529.Name = "Node2";
            treeNode529.Text = "LDUtilities";
            treeNode530.Name = "Node3";
            treeNode530.Text = "Encrypt and Decrypt methods added";
            treeNode531.Name = "Node4";
            treeNode531.Text = "MD5Hash method added";
            treeNode532.Name = "Node6";
            treeNode532.Text = "LDEncryption";
            treeNode533.Name = "Node0";
            treeNode533.Text = "Version 1.0.0.93";
            treeNode534.Name = "Node1";
            treeNode534.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode535.Name = "Node0";
            treeNode535.Text = "LDControls";
            treeNode536.Name = "Node0";
            treeNode536.Text = "Version 1.0.0.92";
            treeNode537.Name = "Node2";
            treeNode537.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode538.Name = "Node1";
            treeNode538.Text = "LDControls";
            treeNode539.Name = "Node1";
            treeNode539.Text = "Version 1.0.0.91";
            treeNode540.Name = "Node1";
            treeNode540.Text = "Font method added to modify shapes or controls that have text";
            treeNode541.Name = "Node0";
            treeNode541.Text = "LDShapes";
            treeNode542.Name = "Node1";
            treeNode542.Text = "MediaPlayer control added (play videos etc)";
            treeNode543.Name = "Node0";
            treeNode543.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode544.Name = "Node0";
            treeNode544.Text = "LDControls";
            treeNode545.Name = "Node1";
            treeNode545.Text = "Version 1.0.0.90";
            treeNode546.Name = "Node1";
            treeNode546.Text = "Autosize columns for ListView";
            treeNode547.Name = "Node2";
            treeNode547.Text = "LDDataBase.sb sample updated";
            treeNode548.Name = "Node0";
            treeNode548.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode549.Name = "Node0";
            treeNode549.Text = "LDDataBase";
            treeNode550.Name = "Node0";
            treeNode550.Text = "Version 1.0.0.89";
            treeNode551.Name = "Node4";
            treeNode551.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode552.Name = "Node3";
            treeNode552.Text = "LDScrollBars";
            treeNode553.Name = "Node1";
            treeNode553.Text = "CleanTemp method added";
            treeNode554.Name = "Node0";
            treeNode554.Text = "LDUtilities";
            treeNode555.Name = "Node1";
            treeNode555.Text = "SQLite database methods added";
            treeNode556.Name = "Node0";
            treeNode556.Text = "LDDataBase";
            treeNode557.Name = "Node2";
            treeNode557.Text = "Version 1.0.0.88";
            treeNode558.Name = "Node2";
            treeNode558.Text = "LastError now returns a text error";
            treeNode559.Name = "Node1";
            treeNode559.Text = "LDIOWarrior";
            treeNode560.Name = "Node1";
            treeNode560.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode561.Name = "Node0";
            treeNode561.Text = "LDScrollBars";
            treeNode562.Name = "Node0";
            treeNode562.Text = "Version 1.0.0.87";
            treeNode563.Name = "Node4";
            treeNode563.Text = "SetTurtleImage method added";
            treeNode564.Name = "Node3";
            treeNode564.Text = "LDShapes";
            treeNode565.Name = "Node1";
            treeNode565.Text = "Connect to IOWarrior USB devices";
            treeNode566.Name = "Node0";
            treeNode566.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode567.Name = "Node0";
            treeNode567.Text = "LDIOWarrior";
            treeNode568.Name = "Node2";
            treeNode568.Text = "Version 1.0.0.86";
            treeNode569.Name = "Node1";
            treeNode569.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode570.Name = "Node0";
            treeNode570.Text = "LDShapes";
            treeNode571.Name = "Node2";
            treeNode571.Text = "Version 1.0.0.85";
            treeNode572.Name = "Node4";
            treeNode572.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode573.Name = "Node3";
            treeNode573.Text = "LDFile";
            treeNode574.Name = "Node6";
            treeNode574.Text = "Crop method added";
            treeNode575.Name = "Node5";
            treeNode575.Text = "LDImage";
            treeNode576.Name = "Node1";
            treeNode576.Text = "LastDropFiles bug fixed";
            treeNode577.Name = "Node0";
            treeNode577.Text = "LDControls";
            treeNode578.Name = "Node2";
            treeNode578.Text = "Version 1.0.0.84";
            treeNode579.Name = "Node7";
            treeNode579.Text = "FileDropped event added";
            treeNode580.Name = "Node6";
            treeNode580.Text = "LDControls";
            treeNode581.Name = "Node1";
            treeNode581.Text = "Bug in Split corrected";
            treeNode582.Name = "Node0";
            treeNode582.Text = "LDText";
            treeNode583.Name = "Node5";
            treeNode583.Text = "Version 1.0.0.83";
            treeNode584.Name = "Node3";
            treeNode584.Text = "Title argument removed from AddComboBox";
            treeNode585.Name = "Node4";
            treeNode585.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode586.Name = "Node2";
            treeNode586.Text = "LDControls";
            treeNode587.Name = "Node1";
            treeNode587.Text = "Version 1.0.0.82";
            treeNode588.Name = "Node0";
            treeNode588.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode589.Name = "Node12";
            treeNode589.Text = "Program settings added";
            treeNode590.Name = "Node9";
            treeNode590.Text = "LDSettings";
            treeNode591.Name = "Node11";
            treeNode591.Text = "Get some system paths and user name";
            treeNode592.Name = "Node10";
            treeNode592.Text = "LDFile";
            treeNode593.Name = "Node14";
            treeNode593.Text = "System sounds added";
            treeNode594.Name = "Node13";
            treeNode594.Text = "LDSound";
            treeNode595.Name = "Node16";
            treeNode595.Text = "Binary, octal, hex and decimal conversions";
            treeNode596.Name = "Node15";
            treeNode596.Text = "LDMath";
            treeNode597.Name = "Node1";
            treeNode597.Text = "Replace method added";
            treeNode598.Name = "Node2";
            treeNode598.Text = "FindAll method added";
            treeNode599.Name = "Node0";
            treeNode599.Text = "LDText";
            treeNode600.Name = "Node8";
            treeNode600.Text = "Version 1.0.0.81";
            treeNode601.Name = "Node1";
            treeNode601.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode602.Name = "Node6";
            treeNode602.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode603.Name = "Node0";
            treeNode603.Text = "LDShapes";
            treeNode604.Name = "Node3";
            treeNode604.Text = "Truncate method added";
            treeNode605.Name = "Node2";
            treeNode605.Text = "LDMath";
            treeNode606.Name = "Node5";
            treeNode606.Text = "Additional text methods";
            treeNode607.Name = "Node4";
            treeNode607.Text = "LDText";
            treeNode608.Name = "Node0";
            treeNode608.Text = "Version 1.0.0.80";
            treeNode609.Name = "Node1";
            treeNode609.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode610.Name = "Node0";
            treeNode610.Text = "LDDialogs";
            treeNode611.Name = "Node1";
            treeNode611.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode612.Name = "Node0";
            treeNode612.Text = "LDUtilities";
            treeNode613.Name = "Node6";
            treeNode613.Text = "Version 1.0.0.79";
            treeNode614.Name = "Node2";
            treeNode614.Text = "Rasterize property added";
            treeNode615.Name = "Node5";
            treeNode615.Text = "Improvements associated with window resizing";
            treeNode616.Name = "Node1";
            treeNode616.Text = "LDScrollBars";
            treeNode617.Name = "Node4";
            treeNode617.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode618.Name = "Node3";
            treeNode618.Text = "LDUtilities";
            treeNode619.Name = "Node0";
            treeNode619.Text = "Version 1.0.0.78";
            treeNode620.Name = "Node1";
            treeNode620.Text = "Handle more than 100 drawables (rasterization)";
            treeNode621.Name = "Node0";
            treeNode621.Text = "LDScollBars";
            treeNode622.Name = "Node2";
            treeNode622.Text = "Version 1.0.0.77";
            treeNode623.Name = "Node1";
            treeNode623.Text = "Record sound from a microphone";
            treeNode624.Name = "Node0";
            treeNode624.Text = "LDSound";
            treeNode625.Name = "Node3";
            treeNode625.Text = "AnimateOpacity method added (flashing)";
            treeNode626.Name = "Node0";
            treeNode626.Text = "AnimateRotation method added (continuous rotation)";
            treeNode627.Name = "Node1";
            treeNode627.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode628.Name = "Node2";
            treeNode628.Text = "LDShapes";
            treeNode629.Name = "Node2";
            treeNode629.Text = "Version 1.0.0.76";
            treeNode630.Name = "Node1";
            treeNode630.Text = "AddAnimatedImage can use an ImageList image";
            treeNode631.Name = "Node0";
            treeNode631.Text = "LDShapes";
            treeNode632.Name = "Node0";
            treeNode632.Text = "Version 1.0.0.75";
            treeNode633.Name = "Node1";
            treeNode633.Text = "Initial graph axes scaling improvement";
            treeNode634.Name = "Node0";
            treeNode634.Text = "LDGraph";
            treeNode635.Name = "Node3";
            treeNode635.Text = "Methods to access a bluetooth device";
            treeNode636.Name = "Node0";
            treeNode636.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode637.Name = "Node2";
            treeNode637.Text = "LDBlueTooth";
            treeNode638.Name = "Node1";
            treeNode638.Text = "getFocus handles multiple LDWindows";
            treeNode639.Name = "Node0";
            treeNode639.Text = "LDFocus";
            treeNode640.Name = "Node0";
            treeNode640.Text = "Version 1.0.0.74";
            treeNode641.Name = "Node1";
            treeNode641.Text = "First pass at a generic USB (HID) device controller";
            treeNode642.Name = "Node0";
            treeNode642.Text = "LDHID";
            treeNode643.Name = "Node9";
            treeNode643.Text = "Version 1.0.0.73";
            treeNode644.Name = "Node8";
            treeNode644.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode645.Name = "Node7";
            treeNode645.Text = "LDGraph";
            treeNode646.Name = "Node6";
            treeNode646.Text = "Version 1.0.0.72";
            treeNode647.Name = "Node4";
            treeNode647.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode648.Name = "Node5";
            treeNode648.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode649.Name = "Node3";
            treeNode649.Text = "LDGraph";
            treeNode650.Name = "Node2";
            treeNode650.Text = "Version 1.0.0.71";
            treeNode651.Name = "Node1";
            treeNode651.Text = "Spurious error message fixed";
            treeNode652.Name = "Node2";
            treeNode652.Text = "CreateTrend data series creation method added";
            treeNode653.Name = "Node0";
            treeNode653.Text = "LDGraph";
            treeNode654.Name = "Node2";
            treeNode654.Text = "Version 1.0.0.70";
            treeNode655.Name = "Node1";
            treeNode655.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode656.Name = "Node0";
            treeNode656.Text = "LDControls";
            treeNode657.Name = "Node3";
            treeNode657.Text = "Version 1.0.0.69";
            treeNode658.Name = "Node2";
            treeNode658.Text = "Radio button control added";
            treeNode659.Name = "Node1";
            treeNode659.Text = "LDControls";
            treeNode660.Name = "Node0";
            treeNode660.Text = "Version 1.0.0.68";
            treeNode661.Name = "Node1";
            treeNode661.Text = "Bug fix for Copy";
            treeNode662.Name = "Node0";
            treeNode662.Text = "LDArray";
            treeNode663.Name = "Node2";
            treeNode663.Text = "Version 1.0.0.67";
            treeNode664.Name = "Node1";
            treeNode664.Text = "RegexMatch and RegexReplace methods added";
            treeNode665.Name = "Node0";
            treeNode665.Text = "LDUtilities";
            treeNode666.Name = "Node3";
            treeNode666.Text = "Version 1.0.0.66";
            treeNode667.Name = "Node2";
            treeNode667.Text = "Number culture conversions added";
            treeNode668.Name = "Node1";
            treeNode668.Text = "LDUtilities";
            treeNode669.Name = "Node0";
            treeNode669.Text = "Version 1.0.0.65";
            treeNode670.Name = "Node1";
            treeNode670.Text = "IsNumber method added";
            treeNode671.Name = "Node0";
            treeNode671.Text = "LDUtilities";
            treeNode672.Name = "Node2";
            treeNode672.Text = "Version 1.0.0.64";
            treeNode673.Name = "Node1";
            treeNode673.Text = "SetCursorPosition method added for textboxes";
            treeNode674.Name = "Node0";
            treeNode674.Text = "LDControls";
            treeNode675.Name = "Node4";
            treeNode675.Text = "Version 1.0.0.63";
            treeNode676.Name = "Node1";
            treeNode676.Text = "SetCursorToEnd method added for textboxes";
            treeNode677.Name = "Node3";
            treeNode677.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode678.Name = "Node0";
            treeNode678.Text = "LDControls";
            treeNode679.Name = "Node2";
            treeNode679.Text = "Version 1.0.0.62";
            treeNode680.Name = "Node1";
            treeNode680.Text = "Adding polygons not located at (0,0) corrected";
            treeNode681.Name = "Node0";
            treeNode681.Text = "LDPhysics";
            treeNode682.Name = "Node2";
            treeNode682.Text = "Version 1.0.0.61";
            treeNode683.Name = "Node1";
            treeNode683.Text = "GetFolder dialog added";
            treeNode684.Name = "Node0";
            treeNode684.Text = "LDDialogs";
            treeNode685.Name = "Node0";
            treeNode685.Text = "Version 1.0.0.60";
            treeNode686.Name = "Node10";
            treeNode686.Text = "Possible localization issue with Font size fixed";
            treeNode687.Name = "Node9";
            treeNode687.Text = "LDDialogs";
            treeNode688.Name = "Node8";
            treeNode688.Text = "Version 1.0.0.59";
            treeNode689.Name = "Node3";
            treeNode689.Text = "More internationalization fixes";
            treeNode690.Name = "Node2";
            treeNode690.Text = "ShowPrintPreview property added";
            treeNode691.Name = "Node1";
            treeNode691.Text = "LDUtilities";
            treeNode692.Name = "Node5";
            treeNode692.Text = "Possible error with gradient drawings fixed";
            treeNode693.Name = "Node4";
            treeNode693.Text = "LDShapes";
            treeNode694.Name = "Node7";
            treeNode694.Text = "Possible Listen event initialisation error fixed";
            treeNode695.Name = "Node6";
            treeNode695.Text = "LDSpeech";
            treeNode696.Name = "Node0";
            treeNode696.Text = "Version 1.0.0.58";
            treeNode697.Name = "Node7";
            treeNode697.Text = "Many possible internationisation issues fixed";
            treeNode698.Name = "Node4";
            treeNode698.Text = "Version 1.0.0.57";
            treeNode699.Name = "Node1";
            treeNode699.Text = "Emmisive colour correction for AddGeometry";
            treeNode700.Name = "Node2";
            treeNode700.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode701.Name = "Node0";
            treeNode701.Text = "LD3DView";
            treeNode702.Name = "Node1";
            treeNode702.Text = "CSVdeminiator property added";
            treeNode703.Name = "Node0";
            treeNode703.Text = "LDUtilities";
            treeNode704.Name = "Node5";
            treeNode704.Text = "Version 1.0.0.56";
            treeNode705.Name = "Node1";
            treeNode705.Text = "Improved error reporting";
            treeNode706.Name = "Node2";
            treeNode706.Text = "Culture invariant type conversions";
            treeNode707.Name = "Node1";
            treeNode707.Text = "LD3DView";
            treeNode708.Name = "Node4";
            treeNode708.Text = "ShowErrors method added";
            treeNode709.Name = "Node3";
            treeNode709.Text = "LDUtilities";
            treeNode710.Name = "Node0";
            treeNode710.Text = "Version 1.0.0.55";
            treeNode711.Name = "Node4";
            treeNode711.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode712.Name = "Node3";
            treeNode712.Text = "LDScrollBars";
            treeNode713.Name = "Node6";
            treeNode713.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode714.Name = "Node5";
            treeNode714.Text = "LDUtilities";
            treeNode715.Name = "Node2";
            treeNode715.Text = "Version 1.0.0.54";
            treeNode716.Name = "Node1";
            treeNode716.Text = "Debug window can be resized";
            treeNode717.Name = "Node0";
            treeNode717.Text = "LDDebug";
            treeNode718.Name = "Node1";
            treeNode718.Text = "PrintFile method added";
            treeNode719.Name = "Node0";
            treeNode719.Text = "LDFile";
            treeNode720.Name = "Node2";
            treeNode720.Text = "Version 1.0.0.53";
            treeNode721.Name = "Node1";
            treeNode721.Text = "SSL property option added";
            treeNode722.Name = "Node0";
            treeNode722.Text = "LDEmail";
            treeNode723.Name = "Node0";
            treeNode723.Text = "Version 1.0.0.52";
            treeNode724.Name = "Node1";
            treeNode724.Text = "Right Click Context menu added for any shape or control";
            treeNode725.Name = "Node0";
            treeNode725.Text = "LDControls";
            treeNode726.Name = "Node0";
            treeNode726.Text = "Version 1.0.0.51";
            treeNode727.Name = "Node1";
            treeNode727.Text = "Right click dropdown menu option added";
            treeNode728.Name = "Node0";
            treeNode728.Text = "LDDialogs";
            treeNode729.Name = "Node0";
            treeNode729.Text = "Version 1.0.0.50";
            treeNode730.Name = "Node1";
            treeNode730.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode731.Name = "Node0";
            treeNode731.Text = "LD3DView";
            treeNode732.Name = "Node0";
            treeNode732.Text = "Version 1.0.0.49";
            treeNode733.Name = "Node1";
            treeNode733.Text = "Performance improvements (some camera controls for this)";
            treeNode734.Name = "Node1";
            treeNode734.Text = "LoadModel (*.3ds) files added";
            treeNode735.Name = "Node0";
            treeNode735.Text = "LD3DView";
            treeNode736.Name = "Node3";
            treeNode736.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode737.Name = "Node2";
            treeNode737.Text = "LDShapes";
            treeNode738.Name = "Node0";
            treeNode738.Text = "Version 1.0.0.48";
            treeNode739.Name = "Node1";
            treeNode739.Text = "Some improvements including animations";
            treeNode740.Name = "Node0";
            treeNode740.Text = "LD3DView";
            treeNode741.Name = "Node0";
            treeNode741.Text = "Version 1.0.0.47";
            treeNode742.Name = "Node1";
            treeNode742.Text = "Some improvemts and new methods";
            treeNode743.Name = "Node0";
            treeNode743.Text = "LD3Dview";
            treeNode744.Name = "Node2";
            treeNode744.Text = "Version 1.0.0.46";
            treeNode745.Name = "Node1";
            treeNode745.Text = "A start at a 3D set of methods";
            treeNode746.Name = "Node0";
            treeNode746.Text = "LD3DView";
            treeNode747.Name = "Node10";
            treeNode747.Text = "Version 1.0.0.45";
            treeNode748.Name = "Node1";
            treeNode748.Text = "Create scrollbars for the GraphicsWindow";
            treeNode749.Name = "Node5";
            treeNode749.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode750.Name = "Node0";
            treeNode750.Text = "LDScrollBars";
            treeNode751.Name = "Node4";
            treeNode751.Text = "ColourList method added";
            treeNode752.Name = "Node3";
            treeNode752.Text = "LDUtilities";
            treeNode753.Name = "Node8";
            treeNode753.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode754.Name = "Node9";
            treeNode754.Text = "BackgroundImage method to set the background added";
            treeNode755.Name = "Node6";
            treeNode755.Text = "LDShapes";
            treeNode756.Name = "Node0";
            treeNode756.Text = "Version 1.0.0.44";
            treeNode757.Name = "Node1";
            treeNode757.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode758.Name = "Node0";
            treeNode758.Text = "LDUtilities";
            treeNode759.Name = "Node0";
            treeNode759.Text = "Version 1.0.0.43";
            treeNode760.Name = "Node1";
            treeNode760.Text = "Call Subs as functions with arguments";
            treeNode761.Name = "Node0";
            treeNode761.Text = "LDCall";
            treeNode762.Name = "Node0";
            treeNode762.Text = "Version 1.0.0.42";
            treeNode763.Name = "Node1";
            treeNode763.Text = "Font dialog added";
            treeNode764.Name = "Node2";
            treeNode764.Text = "Colours dialog moved here from LDColours";
            treeNode765.Name = "Node0";
            treeNode765.Text = "LDDialogs";
            treeNode766.Name = "Node9";
            treeNode766.Text = "Version 1.0.0.41";
            treeNode767.Name = "Node1";
            treeNode767.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode768.Name = "Node7";
            treeNode768.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode769.Name = "Node8";
            treeNode769.Text = "Some methods renamed";
            treeNode770.Name = "Node0";
            treeNode770.Text = "LDControls";
            treeNode771.Name = "Node3";
            treeNode771.Text = "HighScore method move here";
            treeNode772.Name = "Node2";
            treeNode772.Text = "LDNetwork";
            treeNode773.Name = "Node6";
            treeNode773.Text = "SetSize method added";
            treeNode774.Name = "Node5";
            treeNode774.Text = "LDShapes";
            treeNode775.Name = "Node3";
            treeNode775.Text = "Version 1.0.0.40";
            treeNode776.Name = "Node1";
            treeNode776.Text = "SelectTreeView method added";
            treeNode777.Name = "Node2";
            treeNode777.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode778.Name = "Node0";
            treeNode778.Text = "LDDialogs";
            treeNode779.Name = "Node1";
            treeNode779.Text = "Simple high score web method";
            treeNode780.Name = "Node0";
            treeNode780.Text = "LDHighScore";
            treeNode781.Name = "Node3";
            treeNode781.Text = "Version 1.0.0.39";
            treeNode782.Name = "Node2";
            treeNode782.Text = "RichTextBox methods improved";
            treeNode783.Name = "Node1";
            treeNode783.Text = "LDDialogs";
            treeNode784.Name = "Node1";
            treeNode784.Text = "Search, Load and Save methods added";
            treeNode785.Name = "Node0";
            treeNode785.Text = "LDArray";
            treeNode786.Name = "Node0";
            treeNode786.Text = "Version 1.0.0.38";
            treeNode787.Name = "Node1";
            treeNode787.Text = "Depreciated";
            treeNode788.Name = "Node0";
            treeNode788.Text = "LDWeather";
            treeNode789.Name = "Node1";
            treeNode789.Text = "Renamed from LDTrig and some more methods added";
            treeNode790.Name = "Node0";
            treeNode790.Text = "LDMath";
            treeNode791.Name = "Node3";
            treeNode791.Text = "RichTextBox method added";
            treeNode792.Name = "Node2";
            treeNode792.Text = "LDDialogs";
            treeNode793.Name = "Node5";
            treeNode793.Text = "FontList method added";
            treeNode794.Name = "Node4";
            treeNode794.Text = "LDUtilities";
            treeNode795.Name = "Node2";
            treeNode795.Text = "Version 1.0.0.37";
            treeNode796.Name = "Node1";
            treeNode796.Text = "Zip method extended";
            treeNode797.Name = "Node0";
            treeNode797.Text = "LDUtilities";
            treeNode798.Name = "Node2";
            treeNode798.Text = "Version 1.0.0.36";
            treeNode799.Name = "Node1";
            treeNode799.Text = "Collapse and expand treeview nodes method added";
            treeNode800.Name = "Node0";
            treeNode800.Text = "LDDialogs";
            treeNode801.Name = "Node5";
            treeNode801.Text = "Version 1.0.0.35";
            treeNode802.Name = "Node1";
            treeNode802.Text = "Arguments added to Start method";
            treeNode803.Name = "Node0";
            treeNode803.Text = "LDProcess";
            treeNode804.Name = "Node4";
            treeNode804.Text = "Zip compression methods added";
            treeNode805.Name = "Node2";
            treeNode805.Text = "LDUtilities";
            treeNode806.Name = "Node2";
            treeNode806.Text = "Version 1.0.0.34";
            treeNode807.Name = "Node1";
            treeNode807.Text = "GWStyle property added";
            treeNode808.Name = "Node0";
            treeNode808.Text = "LDUtilities";
            treeNode809.Name = "Node1";
            treeNode809.Text = "TreeView and associated events added";
            treeNode810.Name = "Node0";
            treeNode810.Text = "LDDialogs";
            treeNode811.Name = "Node0";
            treeNode811.Text = "Version 1.0.0.33";
            treeNode812.Name = "Node1";
            treeNode812.Text = "Possible end points not plotting bug fixed";
            treeNode813.Name = "Node0";
            treeNode813.Text = "LDGraph";
            treeNode814.Name = "Node2";
            treeNode814.Text = "Version 1.0.0.32";
            treeNode815.Name = "Node1";
            treeNode815.Text = "Activated event and Active property addded";
            treeNode816.Name = "Node0";
            treeNode816.Text = "LDWindows";
            treeNode817.Name = "Node0";
            treeNode817.Text = "Version 1.0.0.31";
            treeNode818.Name = "Node1";
            treeNode818.Text = "Create multiple GraphicsWindows";
            treeNode819.Name = "Node0";
            treeNode819.Text = "LDWindows";
            treeNode820.Name = "Node0";
            treeNode820.Text = "Version 1.0.0.30";
            treeNode821.Name = "Node1";
            treeNode821.Text = "Email sending method";
            treeNode822.Name = "Node0";
            treeNode822.Text = "LDMail";
            treeNode823.Name = "Node1";
            treeNode823.Text = "Add and Multiply methods bug fixed";
            treeNode824.Name = "Node2";
            treeNode824.Text = "Image statistics combined into one method";
            treeNode825.Name = "Node3";
            treeNode825.Text = "Histogram method added";
            treeNode826.Name = "Node0";
            treeNode826.Text = "LDImage";
            treeNode827.Name = "Node0";
            treeNode827.Text = "Version 1.0.0.29";
            treeNode828.Name = "Node1";
            treeNode828.Text = "SnapshotToImageList method added";
            treeNode829.Name = "Node0";
            treeNode829.Text = "LDWebCam";
            treeNode830.Name = "Node3";
            treeNode830.Text = "ImageList image manipulation methods";
            treeNode831.Name = "Node2";
            treeNode831.Text = "LDImage";
            treeNode832.Name = "Node0";
            treeNode832.Text = "Version 1.0.0.28";
            treeNode833.Name = "Node1";
            treeNode833.Text = "SortIndex bugfix for null values";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDArray";
            treeNode835.Name = "Node1";
            treeNode835.Text = "SnapshotToFile bug fixed";
            treeNode836.Name = "Node0";
            treeNode836.Text = "LDWebCam";
            treeNode837.Name = "Node0";
            treeNode837.Text = "Version 1.0.0.27";
            treeNode838.Name = "Node1";
            treeNode838.Text = "SortIndex method added";
            treeNode839.Name = "Node0";
            treeNode839.Text = "LDArray";
            treeNode840.Name = "Node1";
            treeNode840.Text = "Web based weather report data added";
            treeNode841.Name = "Node0";
            treeNode841.Text = "LDWeather";
            treeNode842.Name = "Node3";
            treeNode842.Text = "DataReceived event added";
            treeNode843.Name = "Node2";
            treeNode843.Text = "LDCommPort";
            treeNode844.Name = "Node0";
            treeNode844.Text = "Version 1.0.0.26";
            treeNode845.Name = "Node1";
            treeNode845.Text = "Speech recognition added";
            treeNode846.Name = "Node0";
            treeNode846.Text = "LDSpeech";
            treeNode847.Name = "Node0";
            treeNode847.Text = "Version 1.0.0.25";
            treeNode848.Name = "Node4";
            treeNode848.Text = "More methods added and some internal code optimised";
            treeNode849.Name = "Node0";
            treeNode849.Text = "LDArray & LDMatrix";
            treeNode850.Name = "Node1";
            treeNode850.Text = "KeyDown method added";
            treeNode851.Name = "Node0";
            treeNode851.Text = "LDUtilities";
            treeNode852.Name = "Node1";
            treeNode852.Text = "GetAllShapesAt method added";
            treeNode853.Name = "Node0";
            treeNode853.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode854.Name = "Node0";
            treeNode854.Text = "LDShapes";
            treeNode855.Name = "Node0";
            treeNode855.Text = "Version 1.0.0.24";
            treeNode856.Name = "Node1";
            treeNode856.Text = "OpenFile and SaveFile dialogs added";
            treeNode857.Name = "Node0";
            treeNode857.Text = "LDDialogs";
            treeNode858.Name = "Node2";
            treeNode858.Text = "Matrix methods, for example to solve linear equations";
            treeNode859.Name = "Node1";
            treeNode859.Text = "LDMatrix";
            treeNode860.Name = "Node0";
            treeNode860.Text = "Version 1.0.0.23";
            treeNode861.Name = "Node1";
            treeNode861.Text = "Sorting method added";
            treeNode862.Name = "Node0";
            treeNode862.Text = "LDArray";
            treeNode863.Name = "Node0";
            treeNode863.Text = "Version 1.0.0.22";
            treeNode864.Name = "Node2";
            treeNode864.Text = "Velocity Threshold setting added";
            treeNode865.Name = "Node1";
            treeNode865.Text = "LDPhysics";
            treeNode866.Name = "Node0";
            treeNode866.Text = "Version 1.0.0.21";
            treeNode867.Name = "Node3";
            treeNode867.Text = "SetDamping method added";
            treeNode868.Name = "Node2";
            treeNode868.Text = "LDPhysics";
            treeNode869.Name = "Node1";
            treeNode869.Text = "Version 1.0.0.20";
            treeNode870.Name = "Node1";
            treeNode870.Text = "Instrument name can be obtained from its number";
            treeNode871.Name = "Node0";
            treeNode871.Text = "LDMusic";
            treeNode872.Name = "Node0";
            treeNode872.Text = "Version 1.0.0.19";
            treeNode873.Name = "Node1";
            treeNode873.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode874.Name = "Node0";
            treeNode874.Text = "LDDialogs";
            treeNode875.Name = "Node1";
            treeNode875.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode876.Name = "Node2";
            treeNode876.Text = "Notes can also be played synchronously (chords)";
            treeNode877.Name = "Node0";
            treeNode877.Text = "LDMusic";
            treeNode878.Name = "Node0";
            treeNode878.Text = "Version 1.0.0.18";
            treeNode879.Name = "Node1";
            treeNode879.Text = "AnimationPause and AnimationResume methods added";
            treeNode880.Name = "Node0";
            treeNode880.Text = "LDShapes";
            treeNode881.Name = "Node1";
            treeNode881.Text = "Process list indexed by ID rather than name";
            treeNode882.Name = "Node0";
            treeNode882.Text = "LDProcess";
            treeNode883.Name = "Node1";
            treeNode883.Text = "Version 1.0.0.17";
            treeNode884.Name = "Node1";
            treeNode884.Text = "More effects added";
            treeNode885.Name = "Node0";
            treeNode885.Text = "LDWebCam";
            treeNode886.Name = "Node1";
            treeNode886.Text = "Add or change an image on a button or image shape";
            treeNode887.Name = "Node1";
            treeNode887.Text = "Add an animated gif or tiled image";
            treeNode888.Name = "Node0";
            treeNode888.Text = "LDShapes";
            treeNode889.Name = "Node0";
            treeNode889.Text = "Version 1.0.0.16";
            treeNode890.Name = "Node1";
            treeNode890.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode891.Name = "Node0";
            treeNode891.Text = "LDWebCam";
            treeNode892.Name = "Node0";
            treeNode892.Text = "Version 1.0.0.15";
            treeNode893.Name = "Node2";
            treeNode893.Text = "Variables may be changed during a debug session";
            treeNode894.Name = "Node1";
            treeNode894.Text = "LDDebug";
            treeNode895.Name = "Node0";
            treeNode895.Text = "Version 1.0.0.14";
            treeNode896.Name = "Node1";
            treeNode896.Text = "A basic debugging tool";
            treeNode897.Name = "Node0";
            treeNode897.Text = "LDDebug";
            treeNode898.Name = "Node0";
            treeNode898.Text = "Version 1.0.0.13";
            treeNode899.Name = "Node2";
            treeNode899.Text = "Methods to convert between HSL and RGB";
            treeNode900.Name = "Node18";
            treeNode900.Text = "Method to set colour opacity";
            treeNode901.Name = "Node19";
            treeNode901.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode902.Name = "Node1";
            treeNode902.Text = "LDColours";
            treeNode903.Name = "Node4";
            treeNode903.Text = "Methods to add and subtract dates and times";
            treeNode904.Name = "Node3";
            treeNode904.Text = "LDDateTime";
            treeNode905.Name = "Node6";
            treeNode905.Text = "Waiting overlay, Calendar and About popups";
            treeNode906.Name = "Node17";
            treeNode906.Text = "Tooltips";
            treeNode907.Name = "Node5";
            treeNode907.Text = "LDDialogs";
            treeNode908.Name = "Node8";
            treeNode908.Text = "File change event";
            treeNode909.Name = "Node7";
            treeNode909.Text = "LDEvents";
            treeNode910.Name = "Node0";
            treeNode910.Text = "Version 1.0.0.12";
            treeNode911.Name = "Node12";
            treeNode911.Text = "Methods to sort arrays by index or value";
            treeNode912.Name = "Node22";
            treeNode912.Text = "Sorting by number and character strings";
            treeNode913.Name = "Node11";
            treeNode913.Text = "LDSort";
            treeNode914.Name = "Node14";
            treeNode914.Text = "Statistics on any array and distribution generation";
            treeNode915.Name = "Node20";
            treeNode915.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode916.Name = "Node21";
            treeNode916.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode917.Name = "Node13";
            treeNode917.Text = "LDStatistics";
            treeNode918.Name = "Node16";
            treeNode918.Text = "Voice and volume added";
            treeNode919.Name = "Node15";
            treeNode919.Text = "LDSpeech";
            treeNode920.Name = "Node9";
            treeNode920.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode29,
            treeNode40,
            treeNode55,
            treeNode70,
            treeNode83,
            treeNode92,
            treeNode107,
            treeNode118,
            treeNode132,
            treeNode141,
            treeNode153,
            treeNode164,
            treeNode167,
            treeNode176,
            treeNode183,
            treeNode190,
            treeNode203,
            treeNode214,
            treeNode219,
            treeNode226,
            treeNode229,
            treeNode243,
            treeNode251,
            treeNode257,
            treeNode272,
            treeNode287,
            treeNode293,
            treeNode301,
            treeNode316,
            treeNode333,
            treeNode336,
            treeNode342,
            treeNode348,
            treeNode358,
            treeNode367,
            treeNode370,
            treeNode390,
            treeNode396,
            treeNode399,
            treeNode408,
            treeNode416,
            treeNode422,
            treeNode427,
            treeNode433,
            treeNode436,
            treeNode449,
            treeNode452,
            treeNode457,
            treeNode462,
            treeNode465,
            treeNode471,
            treeNode475,
            treeNode478,
            treeNode484,
            treeNode488,
            treeNode496,
            treeNode502,
            treeNode508,
            treeNode511,
            treeNode518,
            treeNode525,
            treeNode533,
            treeNode536,
            treeNode539,
            treeNode545,
            treeNode550,
            treeNode557,
            treeNode562,
            treeNode568,
            treeNode571,
            treeNode578,
            treeNode583,
            treeNode587,
            treeNode600,
            treeNode608,
            treeNode613,
            treeNode619,
            treeNode622,
            treeNode629,
            treeNode632,
            treeNode640,
            treeNode643,
            treeNode646,
            treeNode650,
            treeNode654,
            treeNode657,
            treeNode660,
            treeNode663,
            treeNode666,
            treeNode669,
            treeNode672,
            treeNode675,
            treeNode679,
            treeNode682,
            treeNode685,
            treeNode688,
            treeNode696,
            treeNode698,
            treeNode704,
            treeNode710,
            treeNode715,
            treeNode720,
            treeNode723,
            treeNode726,
            treeNode729,
            treeNode732,
            treeNode738,
            treeNode741,
            treeNode744,
            treeNode747,
            treeNode756,
            treeNode759,
            treeNode762,
            treeNode766,
            treeNode775,
            treeNode781,
            treeNode786,
            treeNode795,
            treeNode798,
            treeNode801,
            treeNode806,
            treeNode811,
            treeNode814,
            treeNode817,
            treeNode820,
            treeNode827,
            treeNode832,
            treeNode837,
            treeNode844,
            treeNode847,
            treeNode855,
            treeNode860,
            treeNode863,
            treeNode866,
            treeNode869,
            treeNode872,
            treeNode878,
            treeNode883,
            treeNode889,
            treeNode892,
            treeNode895,
            treeNode898,
            treeNode910,
            treeNode920});
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