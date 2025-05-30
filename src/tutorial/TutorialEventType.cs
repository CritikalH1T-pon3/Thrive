﻿/// <summary>
///   Types of tutorial events sent to the tutorial system
/// </summary>
public enum TutorialEventType
{
    /// <summary>
    ///   Player object was created, args is <see cref="MicrobeEventArgs"/>
    /// </summary>
    MicrobePlayerSpawned,

    /// <summary>
    ///   Rotation of the player in the microbe stage, args is <see cref="RotationEventArgs"/>
    /// </summary>
    MicrobePlayerOrientation,

    /// <summary>
    ///   Player movement in the microbe stage, args is <see cref="MicrobeMovementEventArgs"/>
    /// </summary>
    MicrobePlayerMovement,

    /// <summary>
    ///   There are tutorial-relevant compounds near the player, args is <see cref="EntityPositionEventArgs"/>
    /// </summary>
    MicrobeCompoundsNearPlayer,

    /// <summary>
    ///   There are tutorial relevant chunk near the player, args is <see cref="EntityPositionEventArgs"/>
    /// </summary>
    MicrobeChunksNearPlayer,

    /// <summary>
    ///   Reports the player compound amounts while they are alive, args is <see cref="CompoundBagEventArgs"/>
    /// </summary>
    MicrobePlayerCompounds,

    /// <summary>
    ///   Reports the player colony status while they are alive, args is <see cref="MicrobeColonyEventArgs"/>
    /// </summary>
    MicrobePlayerColony,

    /// <summary>
    ///   Reports total compounds the player has absorbed, args is <see cref="CompoundEventArgs"/>
    /// </summary>
    MicrobePlayerTotalCollected,

    /// <summary>
    ///   Player cell engulfment storage has reached full capacity
    /// </summary>
    MicrobePlayerEngulfmentFull,

    /// <summary>
    ///   Player cell engulfment storage is not at full capacity
    /// </summary>
    MicrobePlayerEngulfmentNotFull,

    /// <summary>
    ///   The player has been engulfed by a hostile and larger microbe
    /// </summary>
    MicrobePlayerIsEngulfed,

    /// <summary>
    ///   The player has engulfed an engulfable object
    /// </summary>
    MicrobePlayerEngulfing,

    /// <summary>
    ///   Player has died
    /// </summary>
    MicrobePlayerDied,

    /// <summary>
    ///   Player is ready to reproduce
    /// </summary>
    MicrobePlayerReadyToEdit,

    /// <summary>
    ///   Triggered when the player opens the process panel
    /// </summary>
    ProcessPanelOpened,

    /// <summary>
    ///   Triggered when a process panel process is set to be enabled
    /// </summary>
    ProcessPanelProcessEnabled,

    /// <summary>
    ///   Triggered when there is at least one member of the player species that has died / caused a
    ///   negative external effect
    /// </summary>
    PlayerSpeciesMemberDied,

    /// <summary>
    ///   Player presses the button the exit the microbe editor but has made no changes
    /// </summary>
    MicrobeEditorNoChangesMade,

    /// <summary>
    ///   Player entered the microbe stage
    /// </summary>
    EnteredMicrobeStage,

    /// <summary>
    ///   Player entered the microbe editor
    /// </summary>
    EnteredMicrobeEditor,

    /// <summary>
    ///   Player entered the multicellular stage
    /// </summary>
    EnteredMulticellularStage,

    /// <summary>
    ///   Player entered the multicellular editor
    /// </summary>
    EnteredMulticellularEditor,

    /// <summary>
    ///   Player changed the microbe editor tab, args is <see cref="StringEventArgs"/>
    /// </summary>
    MicrobeEditorTabChanged,

    /// <summary>
    ///   Player changed the <see cref="MicrobeEditorReportComponent"/> subtab, args is <see cref="StringEventArgs"/>
    /// </summary>
    ReportComponentSubtabChanged,

    /// <summary>
    ///   Player changed the sub-tab of the cell editor, args is <see cref="StringEventArgs"/>
    /// </summary>
    CellEditorTabChanged,

    /// <summary>
    ///   Player selected a patch in the microbe editor, args is <see cref="PatchEventArgs"/>
    /// </summary>
    MicrobeEditorPatchSelected,

    /// <summary>
    ///   Player selected an organelle to place in the editor, args is <see cref="StringEventArgs"/>
    /// </summary>
    MicrobeEditorOrganelleToPlaceChanged,

    /// <summary>
    ///   Player placed an organelle, args is <see cref="OrganellePlacedEventArgs"/>
    /// </summary>
    MicrobeEditorOrganellePlaced,

    /// <summary>
    ///   Player modified an organelle (modification was started, not finished yet)
    /// </summary>
    MicrobeEditorOrganelleModified,

    /// <summary>
    ///   Player undid an action in the editor, args is <see cref="EditorActionEventArgs"/>
    /// </summary>
    EditorUndo,

    /// <summary>
    ///   Player redid an action in the editor, args is <see cref="EditorActionEventArgs"/>
    /// </summary>
    EditorRedo,

    /// <summary>
    ///   Triggered when the player changes tolerances
    /// </summary>
    MicrobeEditorTolerancesModified,

    /// <summary>
    ///   The player pressed Shift+U to toggle enable unbind mode
    /// </summary>
    MicrobePlayerUnbindEnabled,

    /// <summary>
    ///   The player unbound any cell
    /// </summary>
    MicrobePlayerUnbound,

    /// <summary>
    ///   Player opened the auto-evo prediction details
    /// </summary>
    MicrobeEditorAutoEvoPredictionOpened,

    /// <summary>
    ///   Player enters a patch with more than 0 sunlight at noon
    /// </summary>
    MicrobePlayerEnterSunlightPatch,

    /// <summary>
    ///   The "Become multicellular" button is available to be clicked
    /// </summary>
    MicrobeBecomeMulticellularAvailable,

    /// <summary>
    ///   Player energy balance has been changed
    /// </summary>
    MicrobeEditorPlayerEnergyBalanceChanged,

    /// <summary>
    ///   Player created a migration with the migration manager
    /// </summary>
    EditorMigrationCreated,

    /// <summary>
    ///   Triggers when the first non-cytoplasm organelle divided
    /// </summary>
    MicrobeNonCytoplasmOrganelleDivided,

    /// <summary>
    ///   Triggered when the game is resumed from the paused state
    /// </summary>
    GameResumedByPlayer,
}
