using System;
using KSP.Localization;

namespace WingProcedural
{
    public class WPDebug : GameParameters.CustomParameterNode
    {
        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logCAV")]//Enable Aero Logging
        public bool logCAV = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logUpdate")]//Enable Update Logging
        public bool logUpdate = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logUpdateGeometry")]//Enable Geometry Logging
        public bool logUpdateGeometry = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logUpdateMaterials")]//Enable Material Logging
        public bool logUpdateMaterials = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logMeshReferences")]//Enable Mesh ref Logging
        public bool logMeshReferences = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logCheckMeshFilter")]//Enable Check Mesh Logging
        public bool logCheckMeshFilter = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logPropertyWindow")]//Enable Property Logging
        public bool logPropertyWindow = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logFlightSetup")]//Enable Flight Setup Logging
        public bool logFlightSetup = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logFieldSetup")]//Enable Field Setup Logging
        public bool logFieldSetup = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logFuel")]//Enable Fuel Logging
        public bool logFuel = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logLimits")]//Enable Limits Logging
        public bool logLimits = false;

        [GameParameters.CustomParameterUI("#B9_Aero_Wing_Procedural_Setting_logEvents")]//Enable Events Logging
        public bool logEvents = false;

		public override string Title => Localizer.Format("#B9_Aero_Wing_Procedural_Modtitle");//"B9 Procedural Wings"

		public override string Section => Localizer.Format("#B9_Aero_Wing_Procedural_Setting_SectionName");//"Editor Settings"

		public override int SectionOrder => 20;

		public override GameParameters.GameMode GameMode => GameParameters.GameMode.ANY;

		public override bool HasPresets => false;

		public override string DisplaySection => Localizer.Format("#B9_Aero_Wing_Procedural_Setting_DisplaySection");//"Graphics"
	}
}