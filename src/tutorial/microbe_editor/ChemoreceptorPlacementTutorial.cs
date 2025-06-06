﻿namespace Tutorial;

using System;

/// <summary>
///   Notifies the player about the chemoreceptor existing
/// </summary>
public class ChemoreceptorPlacementTutorial : CellEditorEntryCountingTutorial
{
    private readonly OrganelleDefinition chemoreceptor =
        SimulationParameters.Instance.GetOrganelleType("chemoreceptor");

    public ChemoreceptorPlacementTutorial()
    {
        CanTrigger = false;
    }

    public override string ClosedByName => "ChemoreceptorPlacementTutorial";

    protected override int TriggersOnNthEditorSession => 5;

    public override void ApplyGUIState(MicrobeEditorTutorialGUI gui)
    {
        gui.ChemoreceptorPlacementTutorialVisible = ShownCurrently;
    }

    public override bool CheckEvent(TutorialState overallState, TutorialEventType eventType, EventArgs args,
        object sender)
    {
        if (base.CheckEvent(overallState, eventType, args, sender))
            return true;

        switch (eventType)
        {
            case TutorialEventType.MicrobeEditorOrganellePlaced:
            {
                if (args is not OrganellePlacedEventArgs organellePlacedEventArgs ||
                    organellePlacedEventArgs.Definition.InternalName != chemoreceptor.InternalName)
                {
                    break;
                }

                if (ShownCurrently)
                {
                    Hide();
                }
                else if (!HasBeenShown)
                {
                    // Don't show the tutorial later if the player has already figured out placing a chemoreceptor
                    Inhibit();
                }

                break;
            }
        }

        return false;
    }
}
