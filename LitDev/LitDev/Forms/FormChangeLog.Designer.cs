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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16,
            treeNode20,
            treeNode22,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode35,
            treeNode37,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode45,
            treeNode47,
            treeNode50,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode58,
            treeNode60,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode66,
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode68,
            treeNode70,
            treeNode73,
            treeNode75,
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode83,
            treeNode85,
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode94,
            treeNode96,
            treeNode98,
            treeNode100,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode104,
            treeNode105,
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode107,
            treeNode109,
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode117,
            treeNode118,
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode116,
            treeNode120,
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode131});
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode126,
            treeNode128,
            treeNode130,
            treeNode132,
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode140,
            treeNode142,
            treeNode144,
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode149,
            treeNode151,
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode156,
            treeNode158,
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode162,
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode165,
            treeNode166,
            treeNode167,
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode164,
            treeNode169,
            treeNode171,
            treeNode173});
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode183});
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode178,
            treeNode180,
            treeNode182,
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode187,
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode192,
            treeNode194,
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode199});
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode201,
            treeNode202,
            treeNode203,
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode206,
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode209,
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode205,
            treeNode208,
            treeNode211,
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode215,
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode217,
            treeNode219,
            treeNode221});
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode225,
            treeNode227});
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode229,
            treeNode230,
            treeNode231,
            treeNode232,
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode235,
            treeNode236,
            treeNode237});
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode234,
            treeNode238,
            treeNode240,
            treeNode242});
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode244});
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode246});
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode248});
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode250});
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode256});
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode245,
            treeNode247,
            treeNode249,
            treeNode251,
            treeNode253,
            treeNode255,
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode259,
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode261,
            treeNode263});
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode267,
            treeNode268,
            treeNode269,
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode266,
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode273});
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode275,
            treeNode276});
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode278,
            treeNode279});
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode281});
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode283});
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode274,
            treeNode277,
            treeNode280,
            treeNode282,
            treeNode284,
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode295,
            treeNode296});
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode298});
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode290,
            treeNode292,
            treeNode294,
            treeNode297,
            treeNode299,
            treeNode301,
            treeNode303});
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode308,
            treeNode309});
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode311});
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode310,
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode314,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode316,
            treeNode318});
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode320,
            treeNode321,
            treeNode322,
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode327});
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode324,
            treeNode326,
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode331,
            treeNode333,
            treeNode335,
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode340});
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode342,
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode345,
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode350,
            treeNode351});
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode353});
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode355});
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode359});
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode344,
            treeNode347,
            treeNode349,
            treeNode352,
            treeNode354,
            treeNode356,
            treeNode358,
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode362,
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode364,
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode375,
            treeNode376,
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode372,
            treeNode374,
            treeNode378});
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode382,
            treeNode383});
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode381,
            treeNode384,
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode390,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode389,
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode395,
            treeNode397});
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode399});
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode401,
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode400,
            treeNode403});
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode405});
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode408,
            treeNode409});
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode415});
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode417,
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode410,
            treeNode412,
            treeNode414,
            treeNode416,
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode422});
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode424});
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode426});
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode425,
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode429});
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode431});
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode430,
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode434});
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode435});
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode437,
            treeNode438});
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode439,
            treeNode441});
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode443,
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode445});
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode450,
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode453});
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode452,
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode456,
            treeNode457});
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode464,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode461,
            treeNode463,
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode468});
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode470,
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode469,
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode474,
            treeNode475,
            treeNode476,
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode478});
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode480});
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode487});
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode484,
            treeNode486,
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode490});
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode491,
            treeNode493,
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode501,
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode498,
            treeNode500,
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode505});
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode513,
            treeNode514});
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode512,
            treeNode515});
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode517,
            treeNode518,
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode522});
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode524});
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode523,
            treeNode525,
            treeNode527});
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode531});
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode530,
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode536,
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode535,
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode547});
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode544,
            treeNode546,
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode552});
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode551,
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode555,
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode557});
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode564});
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode568,
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode559,
            treeNode561,
            treeNode563,
            treeNode565,
            treeNode567,
            treeNode570});
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode572,
            treeNode573});
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode575});
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode577});
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode574,
            treeNode576,
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode580});
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode581,
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode585,
            treeNode586});
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode587,
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode594});
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode596,
            treeNode597,
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode595,
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode606,
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode605,
            treeNode608,
            treeNode610});
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode618,
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode622,
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode626});
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode632});
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode635});
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode639});
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode642});
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode645});
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode647,
            treeNode648});
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode651});
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode660,
            treeNode662,
            treeNode664,
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode670,
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode672,
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode676,
            treeNode678,
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode683,
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode688,
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode692});
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode695});
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode704,
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode707});
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode706,
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode719,
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode724,
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode721,
            treeNode723,
            treeNode726});
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode734,
            treeNode735});
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode738,
            treeNode739,
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode744});
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode741,
            treeNode743,
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode747,
            treeNode748});
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode749,
            treeNode751});
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode754,
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode759,
            treeNode761,
            treeNode763,
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode768});
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode774,
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode778});
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode779,
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode783});
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode790});
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode794,
            treeNode795,
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode793,
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode799});
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode800,
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode805,
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode810,
            treeNode812,
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode817});
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode823,
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode820,
            treeNode822,
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode829});
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode828,
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode839});
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode846,
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode845,
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode851,
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode857,
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode856,
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode865});
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode870,
            treeNode871,
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode876,
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode873,
            treeNode875,
            treeNode878,
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode882,
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode885,
            treeNode886,
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode884,
            treeNode888,
            treeNode890});
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
            treeNode1.Name = "Node1";
            treeNode1.Text = "Base conversions extended to include bases up to 36";
            treeNode2.Name = "Node0";
            treeNode2.Text = "LDMath";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Updated to new Bing API";
            treeNode4.Name = "Node2";
            treeNode4.Text = "LDSearch";
            treeNode5.Name = "Node1";
            treeNode5.Text = "ShowInTaskbar property added";
            treeNode6.Name = "Node0";
            treeNode6.Text = "LDGraphicsWindow";
            treeNode7.Name = "Node1";
            treeNode7.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode8.Name = "Node0";
            treeNode8.Text = "LDFile";
            treeNode9.Name = "Node1";
            treeNode9.Text = "ToArray and FromArray methods added";
            treeNode10.Name = "Node0";
            treeNode10.Text = "LDxml";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Version 1.2.12.0";
            treeNode12.Name = "Node2";
            treeNode12.Text = "DataViewColumnWidths method added";
            treeNode13.Name = "Node3";
            treeNode13.Text = "DataViewRowColours method added";
            treeNode14.Name = "Node1";
            treeNode14.Text = "LDControls";
            treeNode15.Name = "Node1";
            treeNode15.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode16.Name = "Node0";
            treeNode16.Text = "General";
            treeNode17.Name = "Node1";
            treeNode17.Text = "SetCentre method added";
            treeNode18.Name = "Node4";
            treeNode18.Text = "A 3rd rotation added";
            treeNode19.Name = "Node3";
            treeNode19.Text = "BoundingBox method added";
            treeNode20.Name = "Node0";
            treeNode20.Text = "LD3DView";
            treeNode21.Name = "Node3";
            treeNode21.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode22.Name = "Node2";
            treeNode22.Text = "LDDatabase";
            treeNode23.Name = "Node1";
            treeNode23.Text = "PlayMusic2 method added";
            treeNode24.Name = "Node2";
            treeNode24.Text = "Channel parameter added";
            treeNode25.Name = "Node0";
            treeNode25.Text = "LDMusic";
            treeNode26.Name = "Node0";
            treeNode26.Text = "Version 1.2.11.0";
            treeNode27.Name = "Node1";
            treeNode27.Text = "SetButtonStyle method added";
            treeNode28.Name = "Node0";
            treeNode28.Text = "LDControls";
            treeNode29.Name = "Node1";
            treeNode29.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode30.Name = "Node2";
            treeNode30.Text = "SetBillBoard method added";
            treeNode31.Name = "Node0";
            treeNode31.Text = "GetCameraUpDirection method added";
            treeNode32.Name = "Node1";
            treeNode32.Text = "Gradient brushes can be used";
            treeNode33.Name = "Node2";
            treeNode33.Text = "AutoControl method added";
            treeNode34.Name = "Node0";
            treeNode34.Text = "SpecularExponent property added";
            treeNode35.Name = "Node0";
            treeNode35.Text = "LD3DView";
            treeNode36.Name = "Node1";
            treeNode36.Text = "AddText method to annotate an image with text added";
            treeNode37.Name = "Node0";
            treeNode37.Text = "LDImage";
            treeNode38.Name = "Node4";
            treeNode38.Text = "BrushText for text on a brush added";
            treeNode39.Name = "Node0";
            treeNode39.Text = "Skew shapes method added";
            treeNode40.Name = "Node3";
            treeNode40.Text = "LDShapes";
            treeNode41.Name = "Node0";
            treeNode41.Text = "Version 1.2.10.0";
            treeNode42.Name = "Node1";
            treeNode42.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode43.Name = "Node0";
            treeNode43.Text = "LDUnits";
            treeNode44.Name = "Node1";
            treeNode44.Text = "Possible issue with FixSigFig fixed";
            treeNode45.Name = "Node0";
            treeNode45.Text = "LDMath";
            treeNode46.Name = "Node3";
            treeNode46.Text = "GetIndex method added (for SB arrays)";
            treeNode47.Name = "Node2";
            treeNode47.Text = "LDArray";
            treeNode48.Name = "Node5";
            treeNode48.Text = "Resize mode property added";
            treeNode49.Name = "Node6";
            treeNode49.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode50.Name = "Node4";
            treeNode50.Text = "LDGraphicsWindow";
            treeNode51.Name = "Node8";
            treeNode51.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode52.Name = "Node9";
            treeNode52.Text = "DataViewAllowUserEntry method added";
            treeNode53.Name = "Node7";
            treeNode53.Text = "LDControls";
            treeNode54.Name = "Node0";
            treeNode54.Text = "Version 1.2.9.0";
            treeNode55.Name = "Node1";
            treeNode55.Text = "New extended math object, starting with FFT";
            treeNode56.Name = "Node0";
            treeNode56.Text = "LDMathX";
            treeNode57.Name = "Node1";
            treeNode57.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode58.Name = "Node0";
            treeNode58.Text = "LDControls";
            treeNode59.Name = "Node3";
            treeNode59.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode60.Name = "Node2";
            treeNode60.Text = "LDArray";
            treeNode61.Name = "Node5";
            treeNode61.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode62.Name = "Node4";
            treeNode62.Text = "LDList";
            treeNode63.Name = "Node0";
            treeNode63.Text = "Version 1.2.8.0";
            treeNode64.Name = "Node2";
            treeNode64.Text = "Error handling, additional settings and multiple ports supported";
            treeNode65.Name = "Node1";
            treeNode65.Text = "LDCommPort";
            treeNode66.Name = "Node1";
            treeNode66.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode67.Name = "Node1";
            treeNode67.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode68.Name = "Node0";
            treeNode68.Text = "LDImage and LDWebCam";
            treeNode69.Name = "Node1";
            treeNode69.Text = "Bitwise operations object added";
            treeNode70.Name = "Node0";
            treeNode70.Text = "LDBits";
            treeNode71.Name = "Node1";
            treeNode71.Text = "Extended text encoding property added";
            treeNode72.Name = "Node0";
            treeNode72.Text = "TextWindow colours can be changed";
            treeNode73.Name = "Node0";
            treeNode73.Text = "LDTextWindow";
            treeNode74.Name = "Node1";
            treeNode74.Text = "GetWorkingImagePixelARGB method added";
            treeNode75.Name = "Node0";
            treeNode75.Text = "LDImage";
            treeNode76.Name = "Node1";
            treeNode76.Text = "RasteriseTurtleLines method added";
            treeNode77.Name = "Node0";
            treeNode77.Text = "LDShapes";
            treeNode78.Name = "Node0";
            treeNode78.Text = "Version 1.2.7.0";
            treeNode79.Name = "Node1";
            treeNode79.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode80.Name = "Node0";
            treeNode80.Text = "LDDialogs";
            treeNode81.Name = "Node1";
            treeNode81.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode82.Name = "Node2";
            treeNode82.Text = "ToggleSensor added";
            treeNode83.Name = "Node0";
            treeNode83.Text = "LDPhysics";
            treeNode84.Name = "Node1";
            treeNode84.Text = "Allow multiple copies of the webcam image";
            treeNode85.Name = "Node0";
            treeNode85.Text = "LDWebCam";
            treeNode86.Name = "Node1";
            treeNode86.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode87.Name = "Node0";
            treeNode87.Text = "MetaData method added";
            treeNode88.Name = "Node0";
            treeNode88.Text = "LDImage";
            treeNode89.Name = "Node0";
            treeNode89.Text = "Version 1.2.6.0";
            treeNode90.Name = "Node2";
            treeNode90.Text = "FixSigFig and FixDecimal methods added";
            treeNode91.Name = "Node3";
            treeNode91.Text = "MinNumber and MaxNumber properties added";
            treeNode92.Name = "Node1";
            treeNode92.Text = "LDMath";
            treeNode93.Name = "Node1";
            treeNode93.Text = "SliderMaximum property added";
            treeNode94.Name = "Node0";
            treeNode94.Text = "LDControls";
            treeNode95.Name = "Node1";
            treeNode95.Text = "ZoomAll method added";
            treeNode96.Name = "Node0";
            treeNode96.Text = "LDShapes";
            treeNode97.Name = "Node1";
            treeNode97.Text = "Reposition methods and properties added";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LDGraphicsWindow";
            treeNode99.Name = "Node1";
            treeNode99.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode100.Name = "Node0";
            treeNode100.Text = "LDImage";
            treeNode101.Name = "Node1";
            treeNode101.Text = "MouseScroll parameter added";
            treeNode102.Name = "Node0";
            treeNode102.Text = "LDScrollBars";
            treeNode103.Name = "Node0";
            treeNode103.Text = "Version 1.2.5.0";
            treeNode104.Name = "Node0";
            treeNode104.Text = "New object added (previously a separate extension)";
            treeNode105.Name = "Node1";
            treeNode105.Text = "Async, Loop, Volume and Pan properties added";
            treeNode106.Name = "Node2";
            treeNode106.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode107.Name = "Node1";
            treeNode107.Text = "LDWaveForm";
            treeNode108.Name = "Node1";
            treeNode108.Text = "New object added to get input from gamepads or joysticks";
            treeNode109.Name = "Node0";
            treeNode109.Text = "LDController";
            treeNode110.Name = "Node1";
            treeNode110.Text = "RayCast method added";
            treeNode111.Name = "Node0";
            treeNode111.Text = "LDPhysics";
            treeNode112.Name = "Node0";
            treeNode112.Text = "Version 1.2.4.0";
            treeNode113.Name = "Node2";
            treeNode113.Text = "New object to apply effects to any shape or control";
            treeNode114.Name = "Node1";
            treeNode114.Text = "LDEffects";
            treeNode115.Name = "Node1";
            treeNode115.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDFigures";
            treeNode117.Name = "Node1";
            treeNode117.Text = "SetGroup method added";
            treeNode118.Name = "Node2";
            treeNode118.Text = "GetContacts method added";
            treeNode119.Name = "Node0";
            treeNode119.Text = "GetAllShapesAt method added";
            treeNode120.Name = "Node0";
            treeNode120.Text = "LDPhysics";
            treeNode121.Name = "Node2";
            treeNode121.Text = "SetImage handles images with transparency";
            treeNode122.Name = "Node0";
            treeNode122.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode123.Name = "Node1";
            treeNode123.Text = "LDClipboard";
            treeNode124.Name = "Node0";
            treeNode124.Text = "Version 1.2.3.0";
            treeNode125.Name = "Node2";
            treeNode125.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode126.Name = "Node1";
            treeNode126.Text = "LDShapes";
            treeNode127.Name = "Node4";
            treeNode127.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode128.Name = "Node3";
            treeNode128.Text = "LDFile";
            treeNode129.Name = "Node6";
            treeNode129.Text = "NewImage method added";
            treeNode130.Name = "Node5";
            treeNode130.Text = "LDImage";
            treeNode131.Name = "Node1";
            treeNode131.Text = "SetStartupPosition method added to position dialogs";
            treeNode132.Name = "Node0";
            treeNode132.Text = "LDDialogs";
            treeNode133.Name = "Node1";
            treeNode133.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode134.Name = "Node0";
            treeNode134.Text = "LDGraph";
            treeNode135.Name = "Node0";
            treeNode135.Text = "Version 1.2.2.0";
            treeNode136.Name = "Node2";
            treeNode136.Text = "Recompiled for Small Basic version 1.2";
            treeNode137.Name = "Node1";
            treeNode137.Text = "Version 1.2";
            treeNode138.Name = "Node0";
            treeNode138.Text = "Version 1.2.0.1";
            treeNode139.Name = "Node2";
            treeNode139.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode140.Name = "Node1";
            treeNode140.Text = "LDDialogs";
            treeNode141.Name = "Node1";
            treeNode141.Text = "Logical operations object added";
            treeNode142.Name = "Node0";
            treeNode142.Text = "LDLogic";
            treeNode143.Name = "Node4";
            treeNode143.Text = "CurrentCulture property added";
            treeNode144.Name = "Node3";
            treeNode144.Text = "LDUtilities";
            treeNode145.Name = "Node6";
            treeNode145.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode146.Name = "Node5";
            treeNode146.Text = "LDMath";
            treeNode147.Name = "Node0";
            treeNode147.Text = "Version 1.1.0.8";
            treeNode148.Name = "Node1";
            treeNode148.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode149.Name = "Node0";
            treeNode149.Text = "LDControls";
            treeNode150.Name = "Node1";
            treeNode150.Text = "Methods added to add and remove nodes and save xml file";
            treeNode151.Name = "Node0";
            treeNode151.Text = "LDxml";
            treeNode152.Name = "Node1";
            treeNode152.Text = "MusicPlayTime moved from LDFile";
            treeNode153.Name = "Node0";
            treeNode153.Text = "LDSound";
            treeNode154.Name = "Node0";
            treeNode154.Text = "Version 1.1.0.7";
            treeNode155.Name = "Node4";
            treeNode155.Text = "SplitImage method added";
            treeNode156.Name = "Node3";
            treeNode156.Text = "LDImage";
            treeNode157.Name = "Node6";
            treeNode157.Text = "EditTable and SaveTable methods added";
            treeNode158.Name = "Node5";
            treeNode158.Text = "LDDatabse";
            treeNode159.Name = "Node2";
            treeNode159.Text = "DataView control and methods added";
            treeNode160.Name = "Node1";
            treeNode160.Text = "LDControls";
            treeNode161.Name = "Node2";
            treeNode161.Text = "Version 1.1.0.6";
            treeNode162.Name = "Node2";
            treeNode162.Text = "Exists modified to check for directory as well as file";
            treeNode163.Name = "Node3";
            treeNode163.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode164.Name = "Node1";
            treeNode164.Text = "LDFile";
            treeNode165.Name = "Node5";
            treeNode165.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode166.Name = "Node6";
            treeNode166.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode167.Name = "Node9";
            treeNode167.Text = "Conditonal break point added";
            treeNode168.Name = "Node0";
            treeNode168.Text = "Step over button added";
            treeNode169.Name = "Node4";
            treeNode169.Text = "LDDebug";
            treeNode170.Name = "Node8";
            treeNode170.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode171.Name = "Node7";
            treeNode171.Text = "LDGraphicsWindow";
            treeNode172.Name = "Node1";
            treeNode172.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode173.Name = "Node0";
            treeNode173.Text = "LDResources";
            treeNode174.Name = "Node0";
            treeNode174.Text = "Version 1.1.0.5";
            treeNode175.Name = "Node2";
            treeNode175.Text = "ClipboardChanged event added";
            treeNode176.Name = "Node1";
            treeNode176.Text = "LDClipboard";
            treeNode177.Name = "Node1";
            treeNode177.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode178.Name = "Node0";
            treeNode178.Text = "LDFile";
            treeNode179.Name = "Node3";
            treeNode179.Text = "SetActive method added";
            treeNode180.Name = "Node2";
            treeNode180.Text = "LDGraphicsWindow";
            treeNode181.Name = "Node1";
            treeNode181.Text = "Parse xml file nodes";
            treeNode182.Name = "Node0";
            treeNode182.Text = "LDxml";
            treeNode183.Name = "Node3";
            treeNode183.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode184.Name = "Node2";
            treeNode184.Text = "General";
            treeNode185.Name = "Node0";
            treeNode185.Text = "Version 1.1.0.4";
            treeNode186.Name = "Node2";
            treeNode186.Text = "WakeAll method addded";
            treeNode187.Name = "Node1";
            treeNode187.Text = "LDPhysics";
            treeNode188.Name = "Node1";
            treeNode188.Text = "Clipboard methods added";
            treeNode189.Name = "Node0";
            treeNode189.Text = "LDClipboard";
            treeNode190.Name = "Node0";
            treeNode190.Text = "Version 1.1.0.3";
            treeNode191.Name = "Node6";
            treeNode191.Text = "SizeNWSE cursor added";
            treeNode192.Name = "Node5";
            treeNode192.Text = "LDCursors";
            treeNode193.Name = "Node8";
            treeNode193.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode194.Name = "Node7";
            treeNode194.Text = "LDGraph";
            treeNode195.Name = "Node1";
            treeNode195.Text = "SQLite updated for .Net 4.5";
            treeNode196.Name = "Node0";
            treeNode196.Text = "LDDataBase";
            treeNode197.Name = "Node4";
            treeNode197.Text = "Version 1.1.0.2";
            treeNode198.Name = "Node3";
            treeNode198.Text = "Recompiled for Small Basic version 1.1";
            treeNode199.Name = "Node2";
            treeNode199.Text = "Version 1.1";
            treeNode200.Name = "Node0";
            treeNode200.Text = "Version 1.1.0.1";
            treeNode201.Name = "Node12";
            treeNode201.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode202.Name = "Node13";
            treeNode202.Text = "RichTextBoxMargins method added";
            treeNode203.Name = "Node0";
            treeNode203.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode204.Name = "Node1";
            treeNode204.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode205.Name = "Node11";
            treeNode205.Text = "LDControls";
            treeNode206.Name = "Node3";
            treeNode206.Text = "Error reporting added";
            treeNode207.Name = "Node4";
            treeNode207.Text = "SetEncoding method added";
            treeNode208.Name = "Node2";
            treeNode208.Text = "LDCommPort";
            treeNode209.Name = "Node6";
            treeNode209.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode210.Name = "Node7";
            treeNode210.Text = "Export to excel fix for graph with no title";
            treeNode211.Name = "Node5";
            treeNode211.Text = "LDGraph";
            treeNode212.Name = "Node9";
            treeNode212.Text = "Negative restitution option when adding moving shape";
            treeNode213.Name = "Node8";
            treeNode213.Text = "LDPhysics";
            treeNode214.Name = "Node10";
            treeNode214.Text = "Version 1.0.0.133";
            treeNode215.Name = "Node2";
            treeNode215.Text = "Internal improvements to auto messaging";
            treeNode216.Name = "Node9";
            treeNode216.Text = "Name can be set and GetClients method added";
            treeNode217.Name = "Node1";
            treeNode217.Text = "LDClient";
            treeNode218.Name = "Node4";
            treeNode218.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode219.Name = "Node3";
            treeNode219.Text = "LDControls";
            treeNode220.Name = "Node8";
            treeNode220.Text = "Return message and possible file error fixed for Stop method";
            treeNode221.Name = "Node7";
            treeNode221.Text = "LDSound";
            treeNode222.Name = "Node0";
            treeNode222.Text = "Version 1.0.0.132";
            treeNode223.Name = "Node2";
            treeNode223.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode224.Name = "Node5";
            treeNode224.Text = "Compile method added to compile a Small Basic program";
            treeNode225.Name = "Node1";
            treeNode225.Text = "LDCall";
            treeNode226.Name = "Node4";
            treeNode226.Text = "Methods and code by Pappa Lapub added";
            treeNode227.Name = "Node3";
            treeNode227.Text = "LDShell";
            treeNode228.Name = "Node0";
            treeNode228.Text = "Version 1.0.0.131";
            treeNode229.Name = "Node6";
            treeNode229.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode230.Name = "Node7";
            treeNode230.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode231.Name = "Node8";
            treeNode231.Text = "Refactoring of all the pan, follow and box methods";
            treeNode232.Name = "Node6";
            treeNode232.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode233.Name = "Node8";
            treeNode233.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode234.Name = "Node5";
            treeNode234.Text = "LDPhysics";
            treeNode235.Name = "Node1";
            treeNode235.Text = "UseBinary property added";
            treeNode236.Name = "Node2";
            treeNode236.Text = "DoAsync property and associated completion events added";
            treeNode237.Name = "Node3";
            treeNode237.Text = "Delete method added";
            treeNode238.Name = "Node0";
            treeNode238.Text = "LDftp";
            treeNode239.Name = "Node5";
            treeNode239.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode240.Name = "Node4";
            treeNode240.Text = "LDCall";
            treeNode241.Name = "Node2";
            treeNode241.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode242.Name = "Node1";
            treeNode242.Text = "LDControls";
            treeNode243.Name = "Node4";
            treeNode243.Text = "Version 1.0.0.130";
            treeNode244.Name = "Node2";
            treeNode244.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode245.Name = "Node1";
            treeNode245.Text = "LDMath";
            treeNode246.Name = "Node1";
            treeNode246.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode247.Name = "Node0";
            treeNode247.Text = "LDPhysics";
            treeNode248.Name = "Node3";
            treeNode248.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode249.Name = "Node2";
            treeNode249.Text = "LDGraphicsWindow";
            treeNode250.Name = "Node1";
            treeNode250.Text = "FTP object methods added";
            treeNode251.Name = "Node0";
            treeNode251.Text = "LDftp";
            treeNode252.Name = "Node3";
            treeNode252.Text = "An existing file is replaced";
            treeNode253.Name = "Node2";
            treeNode253.Text = "LDZip";
            treeNode254.Name = "Node1";
            treeNode254.Text = "Size method added";
            treeNode255.Name = "Node0";
            treeNode255.Text = "LDFile";
            treeNode256.Name = "Node3";
            treeNode256.Text = "DownloadFile method added";
            treeNode257.Name = "Node2";
            treeNode257.Text = "LDNetwork";
            treeNode258.Name = "Node0";
            treeNode258.Text = "Version 1.0.0.129";
            treeNode259.Name = "Node2";
            treeNode259.Text = "Generalised joint connections added";
            treeNode260.Name = "Node0";
            treeNode260.Text = "AddExplosion method added";
            treeNode261.Name = "Node1";
            treeNode261.Text = "LDPhysics";
            treeNode262.Name = "Node1";
            treeNode262.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode263.Name = "Node0";
            treeNode263.Text = "LDShapes";
            treeNode264.Name = "Node0";
            treeNode264.Text = "Version 1.0.0.128";
            treeNode265.Name = "Node2";
            treeNode265.Text = "CheckServer method added";
            treeNode266.Name = "Node1";
            treeNode266.Text = "LDClient";
            treeNode267.Name = "Node1";
            treeNode267.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode268.Name = "Node2";
            treeNode268.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode269.Name = "Node3";
            treeNode269.Text = "GetAngle method added";
            treeNode270.Name = "Node4";
            treeNode270.Text = "Top-down tire (to model a car from above) methods added";
            treeNode271.Name = "Node0";
            treeNode271.Text = "LDPhysics";
            treeNode272.Name = "Node0";
            treeNode272.Text = "Version 1.0.0.127";
            treeNode273.Name = "Node7";
            treeNode273.Text = "Bug fixes for Overlap methods";
            treeNode274.Name = "Node6";
            treeNode274.Text = "LDShapes";
            treeNode275.Name = "Node0";
            treeNode275.Text = "Bug fix for multiple numeric sorts";
            treeNode276.Name = "Node9";
            treeNode276.Text = "ByValueWithIndex method added";
            treeNode277.Name = "Node8";
            treeNode277.Text = "LDSort";
            treeNode278.Name = "Node1";
            treeNode278.Text = "LAN method added to get local IP addresses";
            treeNode279.Name = "Node2";
            treeNode279.Text = "Ping method added";
            treeNode280.Name = "Node0";
            treeNode280.Text = "LDNetwork";
            treeNode281.Name = "Node1";
            treeNode281.Text = "LoadSVG method added";
            treeNode282.Name = "Node0";
            treeNode282.Text = "LDImage";
            treeNode283.Name = "Node3";
            treeNode283.Text = "Evaluate method added";
            treeNode284.Name = "Node2";
            treeNode284.Text = "LDMath";
            treeNode285.Name = "Node5";
            treeNode285.Text = "IncludeJScript method added";
            treeNode286.Name = "Node4";
            treeNode286.Text = "LDInline";
            treeNode287.Name = "Node5";
            treeNode287.Text = "Version 1.0.0.126";
            treeNode288.Name = "Node0";
            treeNode288.Text = "Special emphasis on async consistency";
            treeNode289.Name = "Node4";
            treeNode289.Text = "Simplified auto method for multi-player game data transfer";
            treeNode290.Name = "Node9";
            treeNode290.Text = "LDServer and LDClient objects added";
            treeNode291.Name = "Node2";
            treeNode291.Text = "GetWidth and GetHeight methods added";
            treeNode292.Name = "Node1";
            treeNode292.Text = "LDText";
            treeNode293.Name = "Node4";
            treeNode293.Text = "Bing web search";
            treeNode294.Name = "Node3";
            treeNode294.Text = "LDSearch";
            treeNode295.Name = "Node6";
            treeNode295.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode296.Name = "Node7";
            treeNode296.Text = "KeyScroll property added";
            treeNode297.Name = "Node5";
            treeNode297.Text = "LDScrollBars";
            treeNode298.Name = "Node9";
            treeNode298.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode299.Name = "Node8";
            treeNode299.Text = "LDShapes";
            treeNode300.Name = "Node1";
            treeNode300.Text = "SaveAs method bug fixed";
            treeNode301.Name = "Node0";
            treeNode301.Text = "LDImage";
            treeNode302.Name = "Node3";
            treeNode302.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode303.Name = "Node2";
            treeNode303.Text = "LDQueue";
            treeNode304.Name = "Node8";
            treeNode304.Text = "Version 1.0.0.125";
            treeNode305.Name = "Node7";
            treeNode305.Text = "Language translation object added";
            treeNode306.Name = "Node6";
            treeNode306.Text = "LDTranslate";
            treeNode307.Name = "Node5";
            treeNode307.Text = "Version 1.0.0.124";
            treeNode308.Name = "Node1";
            treeNode308.Text = "Mouse screen coordinate conversion parameters added";
            treeNode309.Name = "Node2";
            treeNode309.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode310.Name = "Node0";
            treeNode310.Text = "LDGraphicsWindow";
            treeNode311.Name = "Node4";
            treeNode311.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode312.Name = "Node3";
            treeNode312.Text = "LDUtilities";
            treeNode313.Name = "Node0";
            treeNode313.Text = "Version 1.0.0.123";
            treeNode314.Name = "Node5";
            treeNode314.Text = "ColorMatrix method added";
            treeNode315.Name = "Node0";
            treeNode315.Text = "Rotate method added";
            treeNode316.Name = "Node3";
            treeNode316.Text = "LDImage";
            treeNode317.Name = "Node1";
            treeNode317.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode318.Name = "Node0";
            treeNode318.Text = "LDChart";
            treeNode319.Name = "Node2";
            treeNode319.Text = "Version 1.0.0.122";
            treeNode320.Name = "Node2";
            treeNode320.Text = "EffectGamma added to darken and lighten";
            treeNode321.Name = "Node4";
            treeNode321.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode322.Name = "Node3";
            treeNode322.Text = "EffectContrast modified";
            treeNode323.Name = "Node0";
            treeNode323.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode324.Name = "Node1";
            treeNode324.Text = "LDImage";
            treeNode325.Name = "Node2";
            treeNode325.Text = "Error event added for all extension exceptions";
            treeNode326.Name = "Node1";
            treeNode326.Text = "LDEvents";
            treeNode327.Name = "Node1";
            treeNode327.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode328.Name = "Node0";
            treeNode328.Text = "LDMath";
            treeNode329.Name = "Node0";
            treeNode329.Text = "Version 1.0.0.121";
            treeNode330.Name = "Node2";
            treeNode330.Text = "FloodFill transparency effect fixed";
            treeNode331.Name = "Node1";
            treeNode331.Text = "LDGraphicsWindow";
            treeNode332.Name = "Node1";
            treeNode332.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode333.Name = "Node0";
            treeNode333.Text = "LDFile";
            treeNode334.Name = "Node1";
            treeNode334.Text = "EffectPixelate added";
            treeNode335.Name = "Node0";
            treeNode335.Text = "LDImage";
            treeNode336.Name = "Node1";
            treeNode336.Text = "Modified to work with Windows 8";
            treeNode337.Name = "Node0";
            treeNode337.Text = "LDWebCam";
            treeNode338.Name = "Node0";
            treeNode338.Text = "Version 1.0.0.120";
            treeNode339.Name = "Node2";
            treeNode339.Text = "FloodFill method added";
            treeNode340.Name = "Node1";
            treeNode340.Text = "LDGraphicsWindow";
            treeNode341.Name = "Node0";
            treeNode341.Text = "Version 1.0.0.119";
            treeNode342.Name = "Node0";
            treeNode342.Text = "SetShapeCursor method added";
            treeNode343.Name = "Node11";
            treeNode343.Text = "CreateCursor method added";
            treeNode344.Name = "Node9";
            treeNode344.Text = "LDCursors";
            treeNode345.Name = "Node2";
            treeNode345.Text = "SaveAs method to save in different file formats";
            treeNode346.Name = "Node0";
            treeNode346.Text = "Parameters added for some effects";
            treeNode347.Name = "Node1";
            treeNode347.Text = "LDImage";
            treeNode348.Name = "Node2";
            treeNode348.Text = "Parameters added for some effects";
            treeNode349.Name = "Node1";
            treeNode349.Text = "LDWebCam";
            treeNode350.Name = "Node1";
            treeNode350.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode351.Name = "Node0";
            treeNode351.Text = "SetFontFromFile method added for ttf fonts";
            treeNode352.Name = "Node0";
            treeNode352.Text = "LDGraphicsWindow";
            treeNode353.Name = "Node3";
            treeNode353.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode354.Name = "Node2";
            treeNode354.Text = "LDTextWindow";
            treeNode355.Name = "Node2";
            treeNode355.Text = "Zip methods moved here from LDUtilities";
            treeNode356.Name = "Node0";
            treeNode356.Text = "LDZip";
            treeNode357.Name = "Node3";
            treeNode357.Text = "Regex methods moved here from LDUtilities";
            treeNode358.Name = "Node1";
            treeNode358.Text = "LDRegex";
            treeNode359.Name = "Node1";
            treeNode359.Text = "ListViewRowCount method added";
            treeNode360.Name = "Node0";
            treeNode360.Text = "LDControls";
            treeNode361.Name = "Node3";
            treeNode361.Text = "Version 1.0.0.118";
            treeNode362.Name = "Node5";
            treeNode362.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode363.Name = "Node6";
            treeNode363.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode364.Name = "Node4";
            treeNode364.Text = "LDUtilities";
            treeNode365.Name = "Node10";
            treeNode365.Text = "SetUserCursor method added";
            treeNode366.Name = "Node4";
            treeNode366.Text = "LDCursors";
            treeNode367.Name = "Node3";
            treeNode367.Text = "Version 1.0.0.117";
            treeNode368.Name = "Node2";
            treeNode368.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode369.Name = "Node1";
            treeNode369.Text = "LDDictionary";
            treeNode370.Name = "Node0";
            treeNode370.Text = "Version 1.0.0.116";
            treeNode371.Name = "Node2";
            treeNode371.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode372.Name = "Node1";
            treeNode372.Text = "LDColours";
            treeNode373.Name = "Node4";
            treeNode373.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode374.Name = "Node3";
            treeNode374.Text = "LDShapes";
            treeNode375.Name = "Node1";
            treeNode375.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode376.Name = "Node0";
            treeNode376.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode377.Name = "Node1";
            treeNode377.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode378.Name = "Node0";
            treeNode378.Text = "LDGraph";
            treeNode379.Name = "Node0";
            treeNode379.Text = "Version 1.0.0.115";
            treeNode380.Name = "Node2";
            treeNode380.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode381.Name = "Node1";
            treeNode381.Text = "LDControls";
            treeNode382.Name = "Node4";
            treeNode382.Text = "RemoveTurtleLines method added";
            treeNode383.Name = "Node6";
            treeNode383.Text = "GetAllShapes method added";
            treeNode384.Name = "Node3";
            treeNode384.Text = "LDShapes";
            treeNode385.Name = "Node1";
            treeNode385.Text = "Odbc connection added";
            treeNode386.Name = "Node0";
            treeNode386.Text = "LDDatabase";
            treeNode387.Name = "Node0";
            treeNode387.Text = "Version 1.0.0.114";
            treeNode388.Name = "Node2";
            treeNode388.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode389.Name = "Node1";
            treeNode389.Text = "LDUtilities";
            treeNode390.Name = "Node4";
            treeNode390.Text = "ListView control added";
            treeNode391.Name = "Node5";
            treeNode391.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode392.Name = "Node3";
            treeNode392.Text = "LDControls";
            treeNode393.Name = "Node0";
            treeNode393.Text = "Version 1.0.0.113";
            treeNode394.Name = "Node2";
            treeNode394.Text = "Tone method added";
            treeNode395.Name = "Node1";
            treeNode395.Text = "LDSound";
            treeNode396.Name = "Node5";
            treeNode396.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode397.Name = "Node4";
            treeNode397.Text = "LDControls";
            treeNode398.Name = "Node0";
            treeNode398.Text = "Version 1.0.0.112";
            treeNode399.Name = "Node2";
            treeNode399.Text = "SqlServer and Access database support added";
            treeNode400.Name = "Node1";
            treeNode400.Text = "LDDataBase";
            treeNode401.Name = "Node4";
            treeNode401.Text = "FixFlickr method added";
            treeNode402.Name = "Node0";
            treeNode402.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode403.Name = "Node3";
            treeNode403.Text = "LDUtilities";
            treeNode404.Name = "Node0";
            treeNode404.Text = "Version 1.0.0.111";
            treeNode405.Name = "Node2";
            treeNode405.Text = "TextBoxTab method added";
            treeNode406.Name = "Node1";
            treeNode406.Text = "LDControls";
            treeNode407.Name = "Node0";
            treeNode407.Text = "Version 1.0.0.110";
            treeNode408.Name = "Node1";
            treeNode408.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode409.Name = "Node3";
            treeNode409.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode410.Name = "Node0";
            treeNode410.Text = "General";
            treeNode411.Name = "Node5";
            treeNode411.Text = "Exists method added to check if a file path exists or not";
            treeNode412.Name = "Node4";
            treeNode412.Text = "LDFile";
            treeNode413.Name = "Node7";
            treeNode413.Text = "Start method handles attaching to existing process without warning";
            treeNode414.Name = "Node6";
            treeNode414.Text = "LDProcess";
            treeNode415.Name = "Node1";
            treeNode415.Text = "MySQL database support added";
            treeNode416.Name = "Node0";
            treeNode416.Text = "LDDatabase";
            treeNode417.Name = "Node3";
            treeNode417.Text = "Add and Multiply methods honour transparency";
            treeNode418.Name = "Node4";
            treeNode418.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode419.Name = "Node2";
            treeNode419.Text = "LDImage";
            treeNode420.Name = "Node3";
            treeNode420.Text = "Version 1.0.0.109";
            treeNode421.Name = "Node2";
            treeNode421.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode422.Name = "Node1";
            treeNode422.Text = "LDTextWindow";
            treeNode423.Name = "Node0";
            treeNode423.Text = "Version 1.0.0.108";
            treeNode424.Name = "Node14";
            treeNode424.Text = "Transparent colour added";
            treeNode425.Name = "Node13";
            treeNode425.Text = "LDColours";
            treeNode426.Name = "Node16";
            treeNode426.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode427.Name = "Node15";
            treeNode427.Text = "LDDialogs";
            treeNode428.Name = "Node12";
            treeNode428.Text = "Version 1.0.0.107";
            treeNode429.Name = "Node8";
            treeNode429.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode430.Name = "Node7";
            treeNode430.Text = "LDControls";
            treeNode431.Name = "Node11";
            treeNode431.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode432.Name = "Node10";
            treeNode432.Text = "LDShapes";
            treeNode433.Name = "Node6";
            treeNode433.Text = "Version 1.0.0.106";
            treeNode434.Name = "Node5";
            treeNode434.Text = "Menu control added";
            treeNode435.Name = "Node4";
            treeNode435.Text = "LDControls";
            treeNode436.Name = "Node3";
            treeNode436.Text = "Version 1.0.0.105";
            treeNode437.Name = "Node5";
            treeNode437.Text = "ZipList method added";
            treeNode438.Name = "Node2";
            treeNode438.Text = "GetNextMapIndex method added";
            treeNode439.Name = "Node4";
            treeNode439.Text = "LDUtilities";
            treeNode440.Name = "Node1";
            treeNode440.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode441.Name = "Node0";
            treeNode441.Text = "LDShapes";
            treeNode442.Name = "Node3";
            treeNode442.Text = "Version 1.0.0.104";
            treeNode443.Name = "Node1";
            treeNode443.Text = "Transparency maintained for various methods";
            treeNode444.Name = "Node2";
            treeNode444.Text = "Effects bug fixed";
            treeNode445.Name = "Node0";
            treeNode445.Text = "LDImage";
            treeNode446.Name = "Node0";
            treeNode446.Text = "Version 1.0.0.103";
            treeNode447.Name = "Node1";
            treeNode447.Text = "Current application assemblies are all auto-referenced";
            treeNode448.Name = "Node0";
            treeNode448.Text = "LDInline";
            treeNode449.Name = "Node5";
            treeNode449.Text = "Version 1.0.0.102";
            treeNode450.Name = "Node1";
            treeNode450.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode451.Name = "Node2";
            treeNode451.Text = "LDInline.sb sample provided";
            treeNode452.Name = "Node0";
            treeNode452.Text = "LDInline";
            treeNode453.Name = "Node4";
            treeNode453.Text = "ExitButtonMode method added to control window close button state";
            treeNode454.Name = "Node3";
            treeNode454.Text = "LDUtilities";
            treeNode455.Name = "Node0";
            treeNode455.Text = "Version 1.0.0.101";
            treeNode456.Name = "Node1";
            treeNode456.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode457.Name = "Node0";
            treeNode457.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode458.Name = "Node0";
            treeNode458.Text = "LDTextWindow";
            treeNode459.Name = "Node0";
            treeNode459.Text = "Version 1.0.0.100";
            treeNode460.Name = "Node2";
            treeNode460.Text = "ReadANSIToArray method added";
            treeNode461.Name = "Node1";
            treeNode461.Text = "LDFile";
            treeNode462.Name = "Node1";
            treeNode462.Text = "DocumentViewer control added";
            treeNode463.Name = "Node0";
            treeNode463.Text = "LDControls";
            treeNode464.Name = "Node3";
            treeNode464.Text = "An object to batch update shapes (for speed reasons)";
            treeNode465.Name = "Node0";
            treeNode465.Text = "LDFastShapes.sb sample included";
            treeNode466.Name = "Node2";
            treeNode466.Text = "LDFastShapes";
            treeNode467.Name = "Node0";
            treeNode467.Text = "Version 1.0.0.99";
            treeNode468.Name = "Node1";
            treeNode468.Text = "Rendering performance improvements when many shapes present";
            treeNode469.Name = "Node0";
            treeNode469.Text = "LDPhysics";
            treeNode470.Name = "Node1";
            treeNode470.Text = "ANSItoUTF8 method added";
            treeNode471.Name = "Node2";
            treeNode471.Text = "ReadANSI method added";
            treeNode472.Name = "Node0";
            treeNode472.Text = "LDFile";
            treeNode473.Name = "Node1";
            treeNode473.Text = "Version 1.0.0.98";
            treeNode474.Name = "Node3";
            treeNode474.Text = "Move method added for tiangles, polygons and lines";
            treeNode475.Name = "Node4";
            treeNode475.Text = "RotateAbout method added";
            treeNode476.Name = "Node1";
            treeNode476.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode477.Name = "Node0";
            treeNode477.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode478.Name = "Node2";
            treeNode478.Text = "LDShapes";
            treeNode479.Name = "Node0";
            treeNode479.Text = "Version 1.0.0.97";
            treeNode480.Name = "Node4";
            treeNode480.Text = "A list storage object added";
            treeNode481.Name = "Node3";
            treeNode481.Text = "LDList";
            treeNode482.Name = "Node2";
            treeNode482.Text = "Version 1.0.0.96";
            treeNode483.Name = "Node4";
            treeNode483.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode484.Name = "Node3";
            treeNode484.Text = "LDQueue";
            treeNode485.Name = "Node6";
            treeNode485.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode486.Name = "Node5";
            treeNode486.Text = "LDNetwork";
            treeNode487.Name = "Node0";
            treeNode487.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode488.Name = "Node1";
            treeNode488.Text = "General";
            treeNode489.Name = "Node2";
            treeNode489.Text = "Version 1.0.0.95";
            treeNode490.Name = "Node2";
            treeNode490.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode491.Name = "Node1";
            treeNode491.Text = "LDEncryption";
            treeNode492.Name = "Node1";
            treeNode492.Text = "RandomNumberSeed property added";
            treeNode493.Name = "Node0";
            treeNode493.Text = "LDMath";
            treeNode494.Name = "Node1";
            treeNode494.Text = "SetGameData and GetGameData methods added";
            treeNode495.Name = "Node0";
            treeNode495.Text = "LDNetwork";
            treeNode496.Name = "Node0";
            treeNode496.Text = "Version 1.0.0.94";
            treeNode497.Name = "Node1";
            treeNode497.Text = "SliderGetValue method added";
            treeNode498.Name = "Node0";
            treeNode498.Text = "LDControls";
            treeNode499.Name = "Node5";
            treeNode499.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode500.Name = "Node2";
            treeNode500.Text = "LDUtilities";
            treeNode501.Name = "Node3";
            treeNode501.Text = "Encrypt and Decrypt methods added";
            treeNode502.Name = "Node4";
            treeNode502.Text = "MD5Hash method added";
            treeNode503.Name = "Node6";
            treeNode503.Text = "LDEncryption";
            treeNode504.Name = "Node0";
            treeNode504.Text = "Version 1.0.0.93";
            treeNode505.Name = "Node1";
            treeNode505.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode506.Name = "Node0";
            treeNode506.Text = "LDControls";
            treeNode507.Name = "Node0";
            treeNode507.Text = "Version 1.0.0.92";
            treeNode508.Name = "Node2";
            treeNode508.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode509.Name = "Node1";
            treeNode509.Text = "LDControls";
            treeNode510.Name = "Node1";
            treeNode510.Text = "Version 1.0.0.91";
            treeNode511.Name = "Node1";
            treeNode511.Text = "Font method added to modify shapes or controls that have text";
            treeNode512.Name = "Node0";
            treeNode512.Text = "LDShapes";
            treeNode513.Name = "Node1";
            treeNode513.Text = "MediaPlayer control added (play videos etc)";
            treeNode514.Name = "Node0";
            treeNode514.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode515.Name = "Node0";
            treeNode515.Text = "LDControls";
            treeNode516.Name = "Node1";
            treeNode516.Text = "Version 1.0.0.90";
            treeNode517.Name = "Node1";
            treeNode517.Text = "Autosize columns for ListView";
            treeNode518.Name = "Node2";
            treeNode518.Text = "LDDataBase.sb sample updated";
            treeNode519.Name = "Node0";
            treeNode519.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode520.Name = "Node0";
            treeNode520.Text = "LDDataBase";
            treeNode521.Name = "Node0";
            treeNode521.Text = "Version 1.0.0.89";
            treeNode522.Name = "Node4";
            treeNode522.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode523.Name = "Node3";
            treeNode523.Text = "LDScrollBars";
            treeNode524.Name = "Node1";
            treeNode524.Text = "CleanTemp method added";
            treeNode525.Name = "Node0";
            treeNode525.Text = "LDUtilities";
            treeNode526.Name = "Node1";
            treeNode526.Text = "SQLite database methods added";
            treeNode527.Name = "Node0";
            treeNode527.Text = "LDDataBase";
            treeNode528.Name = "Node2";
            treeNode528.Text = "Version 1.0.0.88";
            treeNode529.Name = "Node2";
            treeNode529.Text = "LastError now returns a text error";
            treeNode530.Name = "Node1";
            treeNode530.Text = "LDIOWarrior";
            treeNode531.Name = "Node1";
            treeNode531.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode532.Name = "Node0";
            treeNode532.Text = "LDScrollBars";
            treeNode533.Name = "Node0";
            treeNode533.Text = "Version 1.0.0.87";
            treeNode534.Name = "Node4";
            treeNode534.Text = "SetTurtleImage method added";
            treeNode535.Name = "Node3";
            treeNode535.Text = "LDShapes";
            treeNode536.Name = "Node1";
            treeNode536.Text = "Connect to IOWarrior USB devices";
            treeNode537.Name = "Node0";
            treeNode537.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode538.Name = "Node0";
            treeNode538.Text = "LDIOWarrior";
            treeNode539.Name = "Node2";
            treeNode539.Text = "Version 1.0.0.86";
            treeNode540.Name = "Node1";
            treeNode540.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode541.Name = "Node0";
            treeNode541.Text = "LDShapes";
            treeNode542.Name = "Node2";
            treeNode542.Text = "Version 1.0.0.85";
            treeNode543.Name = "Node4";
            treeNode543.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode544.Name = "Node3";
            treeNode544.Text = "LDFile";
            treeNode545.Name = "Node6";
            treeNode545.Text = "Crop method added";
            treeNode546.Name = "Node5";
            treeNode546.Text = "LDImage";
            treeNode547.Name = "Node1";
            treeNode547.Text = "LastDropFiles bug fixed";
            treeNode548.Name = "Node0";
            treeNode548.Text = "LDControls";
            treeNode549.Name = "Node2";
            treeNode549.Text = "Version 1.0.0.84";
            treeNode550.Name = "Node7";
            treeNode550.Text = "FileDropped event added";
            treeNode551.Name = "Node6";
            treeNode551.Text = "LDControls";
            treeNode552.Name = "Node1";
            treeNode552.Text = "Bug in Split corrected";
            treeNode553.Name = "Node0";
            treeNode553.Text = "LDText";
            treeNode554.Name = "Node5";
            treeNode554.Text = "Version 1.0.0.83";
            treeNode555.Name = "Node3";
            treeNode555.Text = "Title argument removed from AddComboBox";
            treeNode556.Name = "Node4";
            treeNode556.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode557.Name = "Node2";
            treeNode557.Text = "LDControls";
            treeNode558.Name = "Node1";
            treeNode558.Text = "Version 1.0.0.82";
            treeNode559.Name = "Node0";
            treeNode559.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode560.Name = "Node12";
            treeNode560.Text = "Program settings added";
            treeNode561.Name = "Node9";
            treeNode561.Text = "LDSettings";
            treeNode562.Name = "Node11";
            treeNode562.Text = "Get some system paths and user name";
            treeNode563.Name = "Node10";
            treeNode563.Text = "LDFile";
            treeNode564.Name = "Node14";
            treeNode564.Text = "System sounds added";
            treeNode565.Name = "Node13";
            treeNode565.Text = "LDSound";
            treeNode566.Name = "Node16";
            treeNode566.Text = "Binary, octal, hex and decimal conversions";
            treeNode567.Name = "Node15";
            treeNode567.Text = "LDMath";
            treeNode568.Name = "Node1";
            treeNode568.Text = "Replace method added";
            treeNode569.Name = "Node2";
            treeNode569.Text = "FindAll method added";
            treeNode570.Name = "Node0";
            treeNode570.Text = "LDText";
            treeNode571.Name = "Node8";
            treeNode571.Text = "Version 1.0.0.81";
            treeNode572.Name = "Node1";
            treeNode572.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode573.Name = "Node6";
            treeNode573.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode574.Name = "Node0";
            treeNode574.Text = "LDShapes";
            treeNode575.Name = "Node3";
            treeNode575.Text = "Truncate method added";
            treeNode576.Name = "Node2";
            treeNode576.Text = "LDMath";
            treeNode577.Name = "Node5";
            treeNode577.Text = "Additional text methods";
            treeNode578.Name = "Node4";
            treeNode578.Text = "LDText";
            treeNode579.Name = "Node0";
            treeNode579.Text = "Version 1.0.0.80";
            treeNode580.Name = "Node1";
            treeNode580.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode581.Name = "Node0";
            treeNode581.Text = "LDDialogs";
            treeNode582.Name = "Node1";
            treeNode582.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode583.Name = "Node0";
            treeNode583.Text = "LDUtilities";
            treeNode584.Name = "Node6";
            treeNode584.Text = "Version 1.0.0.79";
            treeNode585.Name = "Node2";
            treeNode585.Text = "Rasterize property added";
            treeNode586.Name = "Node5";
            treeNode586.Text = "Improvements associated with window resizing";
            treeNode587.Name = "Node1";
            treeNode587.Text = "LDScrollBars";
            treeNode588.Name = "Node4";
            treeNode588.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode589.Name = "Node3";
            treeNode589.Text = "LDUtilities";
            treeNode590.Name = "Node0";
            treeNode590.Text = "Version 1.0.0.78";
            treeNode591.Name = "Node1";
            treeNode591.Text = "Handle more than 100 drawables (rasterization)";
            treeNode592.Name = "Node0";
            treeNode592.Text = "LDScollBars";
            treeNode593.Name = "Node2";
            treeNode593.Text = "Version 1.0.0.77";
            treeNode594.Name = "Node1";
            treeNode594.Text = "Record sound from a microphone";
            treeNode595.Name = "Node0";
            treeNode595.Text = "LDSound";
            treeNode596.Name = "Node3";
            treeNode596.Text = "AnimateOpacity method added (flashing)";
            treeNode597.Name = "Node0";
            treeNode597.Text = "AnimateRotation method added (continuous rotation)";
            treeNode598.Name = "Node1";
            treeNode598.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode599.Name = "Node2";
            treeNode599.Text = "LDShapes";
            treeNode600.Name = "Node2";
            treeNode600.Text = "Version 1.0.0.76";
            treeNode601.Name = "Node1";
            treeNode601.Text = "AddAnimatedImage can use an ImageList image";
            treeNode602.Name = "Node0";
            treeNode602.Text = "LDShapes";
            treeNode603.Name = "Node0";
            treeNode603.Text = "Version 1.0.0.75";
            treeNode604.Name = "Node1";
            treeNode604.Text = "Initial graph axes scaling improvement";
            treeNode605.Name = "Node0";
            treeNode605.Text = "LDGraph";
            treeNode606.Name = "Node3";
            treeNode606.Text = "Methods to access a bluetooth device";
            treeNode607.Name = "Node0";
            treeNode607.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode608.Name = "Node2";
            treeNode608.Text = "LDBlueTooth";
            treeNode609.Name = "Node1";
            treeNode609.Text = "getFocus handles multiple LDWindows";
            treeNode610.Name = "Node0";
            treeNode610.Text = "LDFocus";
            treeNode611.Name = "Node0";
            treeNode611.Text = "Version 1.0.0.74";
            treeNode612.Name = "Node1";
            treeNode612.Text = "First pass at a generic USB (HID) device controller";
            treeNode613.Name = "Node0";
            treeNode613.Text = "LDHID";
            treeNode614.Name = "Node9";
            treeNode614.Text = "Version 1.0.0.73";
            treeNode615.Name = "Node8";
            treeNode615.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode616.Name = "Node7";
            treeNode616.Text = "LDGraph";
            treeNode617.Name = "Node6";
            treeNode617.Text = "Version 1.0.0.72";
            treeNode618.Name = "Node4";
            treeNode618.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode619.Name = "Node5";
            treeNode619.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode620.Name = "Node3";
            treeNode620.Text = "LDGraph";
            treeNode621.Name = "Node2";
            treeNode621.Text = "Version 1.0.0.71";
            treeNode622.Name = "Node1";
            treeNode622.Text = "Spurious error message fixed";
            treeNode623.Name = "Node2";
            treeNode623.Text = "CreateTrend data series creation method added";
            treeNode624.Name = "Node0";
            treeNode624.Text = "LDGraph";
            treeNode625.Name = "Node2";
            treeNode625.Text = "Version 1.0.0.70";
            treeNode626.Name = "Node1";
            treeNode626.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode627.Name = "Node0";
            treeNode627.Text = "LDControls";
            treeNode628.Name = "Node3";
            treeNode628.Text = "Version 1.0.0.69";
            treeNode629.Name = "Node2";
            treeNode629.Text = "Radio button control added";
            treeNode630.Name = "Node1";
            treeNode630.Text = "LDControls";
            treeNode631.Name = "Node0";
            treeNode631.Text = "Version 1.0.0.68";
            treeNode632.Name = "Node1";
            treeNode632.Text = "Bug fix for Copy";
            treeNode633.Name = "Node0";
            treeNode633.Text = "LDArray";
            treeNode634.Name = "Node2";
            treeNode634.Text = "Version 1.0.0.67";
            treeNode635.Name = "Node1";
            treeNode635.Text = "RegexMatch and RegexReplace methods added";
            treeNode636.Name = "Node0";
            treeNode636.Text = "LDUtilities";
            treeNode637.Name = "Node3";
            treeNode637.Text = "Version 1.0.0.66";
            treeNode638.Name = "Node2";
            treeNode638.Text = "Number culture conversions added";
            treeNode639.Name = "Node1";
            treeNode639.Text = "LDUtilities";
            treeNode640.Name = "Node0";
            treeNode640.Text = "Version 1.0.0.65";
            treeNode641.Name = "Node1";
            treeNode641.Text = "IsNumber method added";
            treeNode642.Name = "Node0";
            treeNode642.Text = "LDUtilities";
            treeNode643.Name = "Node2";
            treeNode643.Text = "Version 1.0.0.64";
            treeNode644.Name = "Node1";
            treeNode644.Text = "SetCursorPosition method added for textboxes";
            treeNode645.Name = "Node0";
            treeNode645.Text = "LDControls";
            treeNode646.Name = "Node4";
            treeNode646.Text = "Version 1.0.0.63";
            treeNode647.Name = "Node1";
            treeNode647.Text = "SetCursorToEnd method added for textboxes";
            treeNode648.Name = "Node3";
            treeNode648.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode649.Name = "Node0";
            treeNode649.Text = "LDControls";
            treeNode650.Name = "Node2";
            treeNode650.Text = "Version 1.0.0.62";
            treeNode651.Name = "Node1";
            treeNode651.Text = "Adding polygons not located at (0,0) corrected";
            treeNode652.Name = "Node0";
            treeNode652.Text = "LDPhysics";
            treeNode653.Name = "Node2";
            treeNode653.Text = "Version 1.0.0.61";
            treeNode654.Name = "Node1";
            treeNode654.Text = "GetFolder dialog added";
            treeNode655.Name = "Node0";
            treeNode655.Text = "LDDialogs";
            treeNode656.Name = "Node0";
            treeNode656.Text = "Version 1.0.0.60";
            treeNode657.Name = "Node10";
            treeNode657.Text = "Possible localization issue with Font size fixed";
            treeNode658.Name = "Node9";
            treeNode658.Text = "LDDialogs";
            treeNode659.Name = "Node8";
            treeNode659.Text = "Version 1.0.0.59";
            treeNode660.Name = "Node3";
            treeNode660.Text = "More internationalization fixes";
            treeNode661.Name = "Node2";
            treeNode661.Text = "ShowPrintPreview property added";
            treeNode662.Name = "Node1";
            treeNode662.Text = "LDUtilities";
            treeNode663.Name = "Node5";
            treeNode663.Text = "Possible error with gradient drawings fixed";
            treeNode664.Name = "Node4";
            treeNode664.Text = "LDShapes";
            treeNode665.Name = "Node7";
            treeNode665.Text = "Possible Listen event initialisation error fixed";
            treeNode666.Name = "Node6";
            treeNode666.Text = "LDSpeech";
            treeNode667.Name = "Node0";
            treeNode667.Text = "Version 1.0.0.58";
            treeNode668.Name = "Node7";
            treeNode668.Text = "Many possible internationisation issues fixed";
            treeNode669.Name = "Node4";
            treeNode669.Text = "Version 1.0.0.57";
            treeNode670.Name = "Node1";
            treeNode670.Text = "Emmisive colour correction for AddGeometry";
            treeNode671.Name = "Node2";
            treeNode671.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode672.Name = "Node0";
            treeNode672.Text = "LD3DView";
            treeNode673.Name = "Node1";
            treeNode673.Text = "CSVdeminiator property added";
            treeNode674.Name = "Node0";
            treeNode674.Text = "LDUtilities";
            treeNode675.Name = "Node5";
            treeNode675.Text = "Version 1.0.0.56";
            treeNode676.Name = "Node1";
            treeNode676.Text = "Improved error reporting";
            treeNode677.Name = "Node2";
            treeNode677.Text = "Culture invariant type conversions";
            treeNode678.Name = "Node1";
            treeNode678.Text = "LD3DView";
            treeNode679.Name = "Node4";
            treeNode679.Text = "ShowErrors method added";
            treeNode680.Name = "Node3";
            treeNode680.Text = "LDUtilities";
            treeNode681.Name = "Node0";
            treeNode681.Text = "Version 1.0.0.55";
            treeNode682.Name = "Node4";
            treeNode682.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode683.Name = "Node3";
            treeNode683.Text = "LDScrollBars";
            treeNode684.Name = "Node6";
            treeNode684.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode685.Name = "Node5";
            treeNode685.Text = "LDUtilities";
            treeNode686.Name = "Node2";
            treeNode686.Text = "Version 1.0.0.54";
            treeNode687.Name = "Node1";
            treeNode687.Text = "Debug window can be resized";
            treeNode688.Name = "Node0";
            treeNode688.Text = "LDDebug";
            treeNode689.Name = "Node1";
            treeNode689.Text = "PrintFile method added";
            treeNode690.Name = "Node0";
            treeNode690.Text = "LDFile";
            treeNode691.Name = "Node2";
            treeNode691.Text = "Version 1.0.0.53";
            treeNode692.Name = "Node1";
            treeNode692.Text = "SSL property option added";
            treeNode693.Name = "Node0";
            treeNode693.Text = "LDEmail";
            treeNode694.Name = "Node0";
            treeNode694.Text = "Version 1.0.0.52";
            treeNode695.Name = "Node1";
            treeNode695.Text = "Right Click Context menu added for any shape or control";
            treeNode696.Name = "Node0";
            treeNode696.Text = "LDControls";
            treeNode697.Name = "Node0";
            treeNode697.Text = "Version 1.0.0.51";
            treeNode698.Name = "Node1";
            treeNode698.Text = "Right click dropdown menu option added";
            treeNode699.Name = "Node0";
            treeNode699.Text = "LDDialogs";
            treeNode700.Name = "Node0";
            treeNode700.Text = "Version 1.0.0.50";
            treeNode701.Name = "Node1";
            treeNode701.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode702.Name = "Node0";
            treeNode702.Text = "LD3DView";
            treeNode703.Name = "Node0";
            treeNode703.Text = "Version 1.0.0.49";
            treeNode704.Name = "Node1";
            treeNode704.Text = "Performance improvements (some camera controls for this)";
            treeNode705.Name = "Node1";
            treeNode705.Text = "LoadModel (*.3ds) files added";
            treeNode706.Name = "Node0";
            treeNode706.Text = "LD3DView";
            treeNode707.Name = "Node3";
            treeNode707.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode708.Name = "Node2";
            treeNode708.Text = "LDShapes";
            treeNode709.Name = "Node0";
            treeNode709.Text = "Version 1.0.0.48";
            treeNode710.Name = "Node1";
            treeNode710.Text = "Some improvements including animations";
            treeNode711.Name = "Node0";
            treeNode711.Text = "LD3DView";
            treeNode712.Name = "Node0";
            treeNode712.Text = "Version 1.0.0.47";
            treeNode713.Name = "Node1";
            treeNode713.Text = "Some improvemts and new methods";
            treeNode714.Name = "Node0";
            treeNode714.Text = "LD3Dview";
            treeNode715.Name = "Node2";
            treeNode715.Text = "Version 1.0.0.46";
            treeNode716.Name = "Node1";
            treeNode716.Text = "A start at a 3D set of methods";
            treeNode717.Name = "Node0";
            treeNode717.Text = "LD3DView";
            treeNode718.Name = "Node10";
            treeNode718.Text = "Version 1.0.0.45";
            treeNode719.Name = "Node1";
            treeNode719.Text = "Create scrollbars for the GraphicsWindow";
            treeNode720.Name = "Node5";
            treeNode720.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode721.Name = "Node0";
            treeNode721.Text = "LDScrollBars";
            treeNode722.Name = "Node4";
            treeNode722.Text = "ColourList method added";
            treeNode723.Name = "Node3";
            treeNode723.Text = "LDUtilities";
            treeNode724.Name = "Node8";
            treeNode724.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode725.Name = "Node9";
            treeNode725.Text = "BackgroundImage method to set the background added";
            treeNode726.Name = "Node6";
            treeNode726.Text = "LDShapes";
            treeNode727.Name = "Node0";
            treeNode727.Text = "Version 1.0.0.44";
            treeNode728.Name = "Node1";
            treeNode728.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode729.Name = "Node0";
            treeNode729.Text = "LDUtilities";
            treeNode730.Name = "Node0";
            treeNode730.Text = "Version 1.0.0.43";
            treeNode731.Name = "Node1";
            treeNode731.Text = "Call Subs as functions with arguments";
            treeNode732.Name = "Node0";
            treeNode732.Text = "LDCall";
            treeNode733.Name = "Node0";
            treeNode733.Text = "Version 1.0.0.42";
            treeNode734.Name = "Node1";
            treeNode734.Text = "Font dialog added";
            treeNode735.Name = "Node2";
            treeNode735.Text = "Colours dialog moved here from LDColours";
            treeNode736.Name = "Node0";
            treeNode736.Text = "LDDialogs";
            treeNode737.Name = "Node9";
            treeNode737.Text = "Version 1.0.0.41";
            treeNode738.Name = "Node1";
            treeNode738.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode739.Name = "Node7";
            treeNode739.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode740.Name = "Node8";
            treeNode740.Text = "Some methods renamed";
            treeNode741.Name = "Node0";
            treeNode741.Text = "LDControls";
            treeNode742.Name = "Node3";
            treeNode742.Text = "HighScore method move here";
            treeNode743.Name = "Node2";
            treeNode743.Text = "LDNetwork";
            treeNode744.Name = "Node6";
            treeNode744.Text = "SetSize method added";
            treeNode745.Name = "Node5";
            treeNode745.Text = "LDShapes";
            treeNode746.Name = "Node3";
            treeNode746.Text = "Version 1.0.0.40";
            treeNode747.Name = "Node1";
            treeNode747.Text = "SelectTreeView method added";
            treeNode748.Name = "Node2";
            treeNode748.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode749.Name = "Node0";
            treeNode749.Text = "LDDialogs";
            treeNode750.Name = "Node1";
            treeNode750.Text = "Simple high score web method";
            treeNode751.Name = "Node0";
            treeNode751.Text = "LDHighScore";
            treeNode752.Name = "Node3";
            treeNode752.Text = "Version 1.0.0.39";
            treeNode753.Name = "Node2";
            treeNode753.Text = "RichTextBox methods improved";
            treeNode754.Name = "Node1";
            treeNode754.Text = "LDDialogs";
            treeNode755.Name = "Node1";
            treeNode755.Text = "Search, Load and Save methods added";
            treeNode756.Name = "Node0";
            treeNode756.Text = "LDArray";
            treeNode757.Name = "Node0";
            treeNode757.Text = "Version 1.0.0.38";
            treeNode758.Name = "Node1";
            treeNode758.Text = "Depreciated";
            treeNode759.Name = "Node0";
            treeNode759.Text = "LDWeather";
            treeNode760.Name = "Node1";
            treeNode760.Text = "Renamed from LDTrig and some more methods added";
            treeNode761.Name = "Node0";
            treeNode761.Text = "LDMath";
            treeNode762.Name = "Node3";
            treeNode762.Text = "RichTextBox method added";
            treeNode763.Name = "Node2";
            treeNode763.Text = "LDDialogs";
            treeNode764.Name = "Node5";
            treeNode764.Text = "FontList method added";
            treeNode765.Name = "Node4";
            treeNode765.Text = "LDUtilities";
            treeNode766.Name = "Node2";
            treeNode766.Text = "Version 1.0.0.37";
            treeNode767.Name = "Node1";
            treeNode767.Text = "Zip method extended";
            treeNode768.Name = "Node0";
            treeNode768.Text = "LDUtilities";
            treeNode769.Name = "Node2";
            treeNode769.Text = "Version 1.0.0.36";
            treeNode770.Name = "Node1";
            treeNode770.Text = "Collapse and expand treeview nodes method added";
            treeNode771.Name = "Node0";
            treeNode771.Text = "LDDialogs";
            treeNode772.Name = "Node5";
            treeNode772.Text = "Version 1.0.0.35";
            treeNode773.Name = "Node1";
            treeNode773.Text = "Arguments added to Start method";
            treeNode774.Name = "Node0";
            treeNode774.Text = "LDProcess";
            treeNode775.Name = "Node4";
            treeNode775.Text = "Zip compression methods added";
            treeNode776.Name = "Node2";
            treeNode776.Text = "LDUtilities";
            treeNode777.Name = "Node2";
            treeNode777.Text = "Version 1.0.0.34";
            treeNode778.Name = "Node1";
            treeNode778.Text = "GWStyle property added";
            treeNode779.Name = "Node0";
            treeNode779.Text = "LDUtilities";
            treeNode780.Name = "Node1";
            treeNode780.Text = "TreeView and associated events added";
            treeNode781.Name = "Node0";
            treeNode781.Text = "LDDialogs";
            treeNode782.Name = "Node0";
            treeNode782.Text = "Version 1.0.0.33";
            treeNode783.Name = "Node1";
            treeNode783.Text = "Possible end points not plotting bug fixed";
            treeNode784.Name = "Node0";
            treeNode784.Text = "LDGraph";
            treeNode785.Name = "Node2";
            treeNode785.Text = "Version 1.0.0.32";
            treeNode786.Name = "Node1";
            treeNode786.Text = "Activated event and Active property addded";
            treeNode787.Name = "Node0";
            treeNode787.Text = "LDWindows";
            treeNode788.Name = "Node0";
            treeNode788.Text = "Version 1.0.0.31";
            treeNode789.Name = "Node1";
            treeNode789.Text = "Create multiple GraphicsWindows";
            treeNode790.Name = "Node0";
            treeNode790.Text = "LDWindows";
            treeNode791.Name = "Node0";
            treeNode791.Text = "Version 1.0.0.30";
            treeNode792.Name = "Node1";
            treeNode792.Text = "Email sending method";
            treeNode793.Name = "Node0";
            treeNode793.Text = "LDMail";
            treeNode794.Name = "Node1";
            treeNode794.Text = "Add and Multiply methods bug fixed";
            treeNode795.Name = "Node2";
            treeNode795.Text = "Image statistics combined into one method";
            treeNode796.Name = "Node3";
            treeNode796.Text = "Histogram method added";
            treeNode797.Name = "Node0";
            treeNode797.Text = "LDImage";
            treeNode798.Name = "Node0";
            treeNode798.Text = "Version 1.0.0.29";
            treeNode799.Name = "Node1";
            treeNode799.Text = "SnapshotToImageList method added";
            treeNode800.Name = "Node0";
            treeNode800.Text = "LDWebCam";
            treeNode801.Name = "Node3";
            treeNode801.Text = "ImageList image manipulation methods";
            treeNode802.Name = "Node2";
            treeNode802.Text = "LDImage";
            treeNode803.Name = "Node0";
            treeNode803.Text = "Version 1.0.0.28";
            treeNode804.Name = "Node1";
            treeNode804.Text = "SortIndex bugfix for null values";
            treeNode805.Name = "Node0";
            treeNode805.Text = "LDArray";
            treeNode806.Name = "Node1";
            treeNode806.Text = "SnapshotToFile bug fixed";
            treeNode807.Name = "Node0";
            treeNode807.Text = "LDWebCam";
            treeNode808.Name = "Node0";
            treeNode808.Text = "Version 1.0.0.27";
            treeNode809.Name = "Node1";
            treeNode809.Text = "SortIndex method added";
            treeNode810.Name = "Node0";
            treeNode810.Text = "LDArray";
            treeNode811.Name = "Node1";
            treeNode811.Text = "Web based weather report data added";
            treeNode812.Name = "Node0";
            treeNode812.Text = "LDWeather";
            treeNode813.Name = "Node3";
            treeNode813.Text = "DataReceived event added";
            treeNode814.Name = "Node2";
            treeNode814.Text = "LDCommPort";
            treeNode815.Name = "Node0";
            treeNode815.Text = "Version 1.0.0.26";
            treeNode816.Name = "Node1";
            treeNode816.Text = "Speech recognition added";
            treeNode817.Name = "Node0";
            treeNode817.Text = "LDSpeech";
            treeNode818.Name = "Node0";
            treeNode818.Text = "Version 1.0.0.25";
            treeNode819.Name = "Node4";
            treeNode819.Text = "More methods added and some internal code optimised";
            treeNode820.Name = "Node0";
            treeNode820.Text = "LDArray & LDMatrix";
            treeNode821.Name = "Node1";
            treeNode821.Text = "KeyDown method added";
            treeNode822.Name = "Node0";
            treeNode822.Text = "LDUtilities";
            treeNode823.Name = "Node1";
            treeNode823.Text = "GetAllShapesAt method added";
            treeNode824.Name = "Node0";
            treeNode824.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode825.Name = "Node0";
            treeNode825.Text = "LDShapes";
            treeNode826.Name = "Node0";
            treeNode826.Text = "Version 1.0.0.24";
            treeNode827.Name = "Node1";
            treeNode827.Text = "OpenFile and SaveFile dialogs added";
            treeNode828.Name = "Node0";
            treeNode828.Text = "LDDialogs";
            treeNode829.Name = "Node2";
            treeNode829.Text = "Matrix methods, for example to solve linear equations";
            treeNode830.Name = "Node1";
            treeNode830.Text = "LDMatrix";
            treeNode831.Name = "Node0";
            treeNode831.Text = "Version 1.0.0.23";
            treeNode832.Name = "Node1";
            treeNode832.Text = "Sorting method added";
            treeNode833.Name = "Node0";
            treeNode833.Text = "LDArray";
            treeNode834.Name = "Node0";
            treeNode834.Text = "Version 1.0.0.22";
            treeNode835.Name = "Node2";
            treeNode835.Text = "Velocity Threshold setting added";
            treeNode836.Name = "Node1";
            treeNode836.Text = "LDPhysics";
            treeNode837.Name = "Node0";
            treeNode837.Text = "Version 1.0.0.21";
            treeNode838.Name = "Node3";
            treeNode838.Text = "SetDamping method added";
            treeNode839.Name = "Node2";
            treeNode839.Text = "LDPhysics";
            treeNode840.Name = "Node1";
            treeNode840.Text = "Version 1.0.0.20";
            treeNode841.Name = "Node1";
            treeNode841.Text = "Instrument name can be obtained from its number";
            treeNode842.Name = "Node0";
            treeNode842.Text = "LDMusic";
            treeNode843.Name = "Node0";
            treeNode843.Text = "Version 1.0.0.19";
            treeNode844.Name = "Node1";
            treeNode844.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode845.Name = "Node0";
            treeNode845.Text = "LDDialogs";
            treeNode846.Name = "Node1";
            treeNode846.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode847.Name = "Node2";
            treeNode847.Text = "Notes can also be played synchronously (chords)";
            treeNode848.Name = "Node0";
            treeNode848.Text = "LDMusic";
            treeNode849.Name = "Node0";
            treeNode849.Text = "Version 1.0.0.18";
            treeNode850.Name = "Node1";
            treeNode850.Text = "AnimationPause and AnimationResume methods added";
            treeNode851.Name = "Node0";
            treeNode851.Text = "LDShapes";
            treeNode852.Name = "Node1";
            treeNode852.Text = "Process list indexed by ID rather than name";
            treeNode853.Name = "Node0";
            treeNode853.Text = "LDProcess";
            treeNode854.Name = "Node1";
            treeNode854.Text = "Version 1.0.0.17";
            treeNode855.Name = "Node1";
            treeNode855.Text = "More effects added";
            treeNode856.Name = "Node0";
            treeNode856.Text = "LDWebCam";
            treeNode857.Name = "Node1";
            treeNode857.Text = "Add or change an image on a button or image shape";
            treeNode858.Name = "Node1";
            treeNode858.Text = "Add an animated gif or tiled image";
            treeNode859.Name = "Node0";
            treeNode859.Text = "LDShapes";
            treeNode860.Name = "Node0";
            treeNode860.Text = "Version 1.0.0.16";
            treeNode861.Name = "Node1";
            treeNode861.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode862.Name = "Node0";
            treeNode862.Text = "LDWebCam";
            treeNode863.Name = "Node0";
            treeNode863.Text = "Version 1.0.0.15";
            treeNode864.Name = "Node2";
            treeNode864.Text = "Variables may be changed during a debug session";
            treeNode865.Name = "Node1";
            treeNode865.Text = "LDDebug";
            treeNode866.Name = "Node0";
            treeNode866.Text = "Version 1.0.0.14";
            treeNode867.Name = "Node1";
            treeNode867.Text = "A basic debugging tool";
            treeNode868.Name = "Node0";
            treeNode868.Text = "LDDebug";
            treeNode869.Name = "Node0";
            treeNode869.Text = "Version 1.0.0.13";
            treeNode870.Name = "Node2";
            treeNode870.Text = "Methods to convert between HSL and RGB";
            treeNode871.Name = "Node18";
            treeNode871.Text = "Method to set colour opacity";
            treeNode872.Name = "Node19";
            treeNode872.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode873.Name = "Node1";
            treeNode873.Text = "LDColours";
            treeNode874.Name = "Node4";
            treeNode874.Text = "Methods to add and subtract dates and times";
            treeNode875.Name = "Node3";
            treeNode875.Text = "LDDateTime";
            treeNode876.Name = "Node6";
            treeNode876.Text = "Waiting overlay, Calendar and About popups";
            treeNode877.Name = "Node17";
            treeNode877.Text = "Tooltips";
            treeNode878.Name = "Node5";
            treeNode878.Text = "LDDialogs";
            treeNode879.Name = "Node8";
            treeNode879.Text = "File change event";
            treeNode880.Name = "Node7";
            treeNode880.Text = "LDEvents";
            treeNode881.Name = "Node0";
            treeNode881.Text = "Version 1.0.0.12";
            treeNode882.Name = "Node12";
            treeNode882.Text = "Methods to sort arrays by index or value";
            treeNode883.Name = "Node22";
            treeNode883.Text = "Sorting by number and character strings";
            treeNode884.Name = "Node11";
            treeNode884.Text = "LDSort";
            treeNode885.Name = "Node14";
            treeNode885.Text = "Statistics on any array and distribution generation";
            treeNode886.Name = "Node20";
            treeNode886.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode887.Name = "Node21";
            treeNode887.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode888.Name = "Node13";
            treeNode888.Text = "LDStatistics";
            treeNode889.Name = "Node16";
            treeNode889.Text = "Voice and volume added";
            treeNode890.Name = "Node15";
            treeNode890.Text = "LDSpeech";
            treeNode891.Name = "Node9";
            treeNode891.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode26,
            treeNode41,
            treeNode54,
            treeNode63,
            treeNode78,
            treeNode89,
            treeNode103,
            treeNode112,
            treeNode124,
            treeNode135,
            treeNode138,
            treeNode147,
            treeNode154,
            treeNode161,
            treeNode174,
            treeNode185,
            treeNode190,
            treeNode197,
            treeNode200,
            treeNode214,
            treeNode222,
            treeNode228,
            treeNode243,
            treeNode258,
            treeNode264,
            treeNode272,
            treeNode287,
            treeNode304,
            treeNode307,
            treeNode313,
            treeNode319,
            treeNode329,
            treeNode338,
            treeNode341,
            treeNode361,
            treeNode367,
            treeNode370,
            treeNode379,
            treeNode387,
            treeNode393,
            treeNode398,
            treeNode404,
            treeNode407,
            treeNode420,
            treeNode423,
            treeNode428,
            treeNode433,
            treeNode436,
            treeNode442,
            treeNode446,
            treeNode449,
            treeNode455,
            treeNode459,
            treeNode467,
            treeNode473,
            treeNode479,
            treeNode482,
            treeNode489,
            treeNode496,
            treeNode504,
            treeNode507,
            treeNode510,
            treeNode516,
            treeNode521,
            treeNode528,
            treeNode533,
            treeNode539,
            treeNode542,
            treeNode549,
            treeNode554,
            treeNode558,
            treeNode571,
            treeNode579,
            treeNode584,
            treeNode590,
            treeNode593,
            treeNode600,
            treeNode603,
            treeNode611,
            treeNode614,
            treeNode617,
            treeNode621,
            treeNode625,
            treeNode628,
            treeNode631,
            treeNode634,
            treeNode637,
            treeNode640,
            treeNode643,
            treeNode646,
            treeNode650,
            treeNode653,
            treeNode656,
            treeNode659,
            treeNode667,
            treeNode669,
            treeNode675,
            treeNode681,
            treeNode686,
            treeNode691,
            treeNode694,
            treeNode697,
            treeNode700,
            treeNode703,
            treeNode709,
            treeNode712,
            treeNode715,
            treeNode718,
            treeNode727,
            treeNode730,
            treeNode733,
            treeNode737,
            treeNode746,
            treeNode752,
            treeNode757,
            treeNode766,
            treeNode769,
            treeNode772,
            treeNode777,
            treeNode782,
            treeNode785,
            treeNode788,
            treeNode791,
            treeNode798,
            treeNode803,
            treeNode808,
            treeNode815,
            treeNode818,
            treeNode826,
            treeNode831,
            treeNode834,
            treeNode837,
            treeNode840,
            treeNode843,
            treeNode849,
            treeNode854,
            treeNode860,
            treeNode863,
            treeNode866,
            treeNode869,
            treeNode881,
            treeNode891});
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