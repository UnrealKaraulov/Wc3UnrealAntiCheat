//===========================================================================
// 
// |cCC55CCFFMazing Contest|r v1.1
// 
//   Warcraft III map script
//   Generated by the Warcraft III World Editor
//   Date: Fri Sep 12 20:54:49 2008
//   Map Author: Pender
// 
//===========================================================================

//***************************************************************************
//*
//*  Global Variables
//*
//***************************************************************************

globals
    // User-defined
    timer                   udg_asdfdasgvsadfasdg      = null
    boolean array           udg_asdfgdsagdsfsd
    real array              udg_asdgfdsafgsdgsdaf
    real array              udg_asdgsadfsadgasdf
    group                   udg_temp_group             = null
    integer                 udg_asdgfasdfsdgsadf       = 0
    group                   udg_Chain                  = null
    boolean                 udg_asdgasdgadsf           = false
    boolean                 udg_asdgasdfasdgs          = false
    boolean                 udg_asdfadsgdsfasd         = false
    unit                    udg_asdgfdsafgsdsdaf       = null
    location                udg_temp_point             = null
    boolean array           udg_asdfsdagsdafsa
    location array          udg_asdgasdfsadgdsf
    location array          udg_asdfgdsafsadgds
    rect array              udg_asdgvdsafsadgvds
    location array          udg_asdgvdsfasdgsd
    integer                 udg_asdgdsfasdgdsa         = 0
    real                    udg_asdfgasgsadfsdg        = 0
    real                    udg_asdfasdgsdfsdg         = 0
    integer                 udg_asdgfsdagvsdafdsg      = 0
    boolean                 udg_asdfsdagadsf           = false
    unit array              udg_asdgvdsafasdgsda
    group                   udg_asdfdsagadsf           = null
    integer                 udg_asdfdsgdsfgsadgs       = 0
    group                   udg_Chain_New_Additions_2  = null
    group                   udg_Chain_New_Additions_1  = null
    integer                 udg_asdfasdgsdafsd         = 0
    integer                 udg_asdfadsgsdfgsadg       = 0
    integer                 udg_asdfasdgasdsadfsadg    = 0
    group                   udg_Thunderclap_Towers     = null
    unit array              udg_asdfasdgasdfsadg
    integer                 udg_asdfgadsfsadgvs        = 0
    integer                 udg_asdgvadsfsdagbsd       = 0
    integer array           udg_asdgvsdfsadgvdsf
    string array            udg_asdgfdsgvsadfasd
    timer                   udg_asdgasdfsadgsd         = null
    timerdialog             udg_asdgfsadfasdfs         = null
    integer array           udg_asdfasdgsdafsdg
    timer                   udg_asdgdsafsadsgsadf      = null
    timerdialog             udg_asdgfadsgsadfas        = null
    location                udg_temp_point_2           = null
    integer                 udg_asdgdsafsadgsadf       = 0
    integer array           udg_asdgsadgvadsgsadf
    integer array           udg_asdgvdfsfgsdagds
    integer array           udg_asdgvdsfasdgdsf
    integer array           udg_asdgdsfasdgfds
    boolean array           udg_asdgvdsfasdgvsd
    real array              udg_asdgfvsdagsdfas
    camerasetup array       udg_asdgfsadgsadfasdg
    unit                    udg_asdgvdsafdsgvs         = null
    integer                 udg_asdfgdsafgsadsdaf      = 0
    group                   udg_Preplaced_Towers       = null
    timer                   udg_asdgfdsfasdgds         = null
    timerdialog             udg_asdgfasdgadsfds        = null
    dialog                  udg_asdfasdfgsadgv         = null
    dialog                  udg_asdgdsfasdgdsf         = null
    dialog                  udg_asdfsadgvsdafds        = null
    dialog                  udg_asdfsdagvdsafsd        = null
    button                  udg_asdfasdgsdfs           = null
    button                  udg_asdfdsagasdf           = null
    button                  udg_asdfgadsgadsfs         = null
    button                  udg_asdfasdgfadsf          = null
    button                  udg_asdgfsadgfadsf         = null
    button                  udg_asdgfasdgdsf           = null
    button                  udg_asdfdsagvsdfsadf       = null
    button                  udg_asdgdsfasdgds          = null
    button                  udg_asdfdsagvsdaf          = null
    button                  udg_asdgfadsfadsg          = null
    button                  udg_asdgvdsfsadgvds        = null
    button                  udg_asdfgsdafadsg          = null
    button                  udg_asdfdsagdsfs           = null
    button                  udg_asdgfdasgvsadf         = null
    integer                 udg_adsgdasfadsgds         = 0
    integer                 udg_asdfadsgdsafasdgs      = 0
    boolean                 udg_asdfsadgsda            = false
    player                  udg_asdfsadgvsdfsd         = null
    timer                   udg_asdgfdsafgsadgsd       = null
    timer                   udg_asdgdsfsasdgdsf        = null
    timer                   udg_asdgfdsfgsadgsdaf      = null
    integer array           udg_asdgfdsfgdsafsa
    integer array           udg_asdgvdasfsdgf
    integer array           udg_asdfgasdfsdagvds

    // Generated
    rect                    gg_rct_finish_bottom_row   = null
    rect                    gg_rct_finish_top_row      = null
    rect                    gg_rct_p1_lower_left       = null
    rect                    gg_rct_p2_lower_left       = null
    rect                    gg_rct_p3_lower_left       = null
    rect                    gg_rct_p4_lower_left       = null
    rect                    gg_rct_p5_lower_left       = null
    rect                    gg_rct_p6_lower_left       = null
    rect                    gg_rct_p7_lower_left       = null
    rect                    gg_rct_p8_lower_left       = null
    rect                    gg_rct_p9_lower_left       = null
    rect                    gg_rct_p10_lower_left      = null
    rect                    gg_rct_p11_lower_left      = null
    rect                    gg_rct_p12_lower_left      = null
    rect                    gg_rct_Middle_of_Nowhere   = null
    rect                    gg_rct_The_End             = null
    camerasetup             gg_cam_Overhead_1          = null
    camerasetup             gg_cam_Overhead_2          = null
    camerasetup             gg_cam_Overhead_3          = null
    camerasetup             gg_cam_Overhead_4          = null
    camerasetup             gg_cam_Overhead_5          = null
    camerasetup             gg_cam_Overhead_6          = null
    camerasetup             gg_cam_Overhead_7          = null
    camerasetup             gg_cam_Overhead_8          = null
    camerasetup             gg_cam_Overhead_9          = null
    camerasetup             gg_cam_Overhead_10         = null
    camerasetup             gg_cam_Overhead_11         = null
    camerasetup             gg_cam_Overhead_12         = null
    camerasetup             gg_cam_The_End             = null
    sound                   gg_snd_PlayerLeft          = null
    sound                   gg_snd_EndMusic            = null
    sound                   gg_snd_TimeWarning         = null
    trigger                 gg_trg_READ_ME             = null
    trigger                 gg_trg_asdgfadsgadsgfs     = null
    trigger                 gg_trg_asdfadsgsadfasdg    = null
    trigger                 gg_trg_asdfsadgsadfsdag    = null
    trigger                 gg_trg_asdgadsgasdgsadg    = null
    trigger                 gg_trg_asdgfasdgsdfasd     = null
    trigger                 gg_trg_asdgfasdgsadgfsad   = null
    trigger                 gg_trg_asdgfasdgasdgasd    = null
    trigger                 gg_trg_asdgsadgsadgsadd    = null
    trigger                 gg_trg_asdgasdfasdgasdgf   = null
    trigger                 gg_trg_asdgsadfsadgsadf    = null
    trigger                 gg_trg_asdfsdgsdfsdg       = null
    trigger                 gg_trg_asdfsadgasdfsadgas  = null
    trigger                 gg_trg_asgdsafsdgsadfasdg  = null
    trigger                 gg_trg_asdgsafasdgadsfsa   = null
    trigger                 gg_trg_asdfdsgdsafasdgdsa  = null
    trigger                 gg_trg_asdfasdgsadfsdgsa   = null
    trigger                 gg_trg_asdfasdgsdsadfsdg   = null
    trigger                 gg_trg_asdfsagasdfsdgasd   = null
    trigger                 gg_trg_asdgfasdgsadfsdgs   = null
    trigger                 gg_trg_adgfsaasdgasdfsdg   = null
    trigger                 gg_trg_asdfasdgsdafsadg    = null
    trigger                 gg_trg_asdgasdgfasdfsdgsadf = null
    trigger                 gg_trg_asdfsadgsdafsdgf    = null
    trigger                 gg_trg_asdfgasdgsadfsdg    = null
    trigger                 gg_trg_asdfasdgsadfsdag    = null
    trigger                 gg_trg_asdfasdgasdfsadg    = null
    trigger                 gg_trg_asdfasdgsadfsadg    = null
    trigger                 gg_trg_asdfgasdgsadfasgd   = null
    trigger                 gg_trg_asdfasdgsdfsadgs    = null
    trigger                 gg_trg_asdfgasdgsdfasdg    = null
    trigger                 gg_trg_adsgdsafasdgsdfsa   = null
    trigger                 gg_trg_asdfasdgsadfsdgsda  = null
    trigger                 gg_trg_asdgadsfasdgsdfsd   = null
    trigger                 gg_trg_asdfasdgsadfasd     = null
    trigger                 gg_trg_asdfdasgsdfsdgsad   = null
    trigger                 gg_trg_asdfsdagsdfsdgasd   = null
    trigger                 gg_trg_asdgfasdfsadgsdfsagd = null
    trigger                 gg_trg_asdgasdfsdgsdf      = null
    trigger                 gg_trg_asdgadsfgsadgsd     = null
    unit                    gg_unit_h000_0049          = null
endglobals

function Trig_cheats_by_Dekar_Func001001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 4) == "-int" )
endfunction
function Trig_cheats_by_Dekar_Func001002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func001002002002 takes nothing returns nothing
    call ModifyHeroStat( bj_HEROSTAT_INT, GetEnumUnit(), bj_MODIFYMETHOD_SET, S2I(SubStringBJ(GetEventPlayerChatString(), 5, 20)) )
endfunction
function Trig_cheats_by_Dekar_Func002001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 4) == "-agi" )
endfunction
function Trig_cheats_by_Dekar_Func002002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func002002002002 takes nothing returns nothing
    call ModifyHeroStat( bj_HEROSTAT_AGI, GetEnumUnit(), bj_MODIFYMETHOD_SET, S2I(SubStringBJ(GetEventPlayerChatString(), 5, 20)) )
endfunction
function Trig_cheats_by_Dekar_Func003001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 4) == "-str" )
endfunction
function Trig_cheats_by_Dekar_Func003002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func003002002002 takes nothing returns nothing
    call ModifyHeroStat( bj_HEROSTAT_STR, GetEnumUnit(), bj_MODIFYMETHOD_SET, S2I(SubStringBJ(GetEventPlayerChatString(), 5, 20)) )
endfunction
function Trig_cheats_by_Dekar_Func004001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 3) == "-xp" )
endfunction
function Trig_cheats_by_Dekar_Func004002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func004002002002 takes nothing returns nothing
    call AddHeroXPSwapped( S2I(SubStringBJ(GetEventPlayerChatString(), 5, 20)), GetEnumUnit(), true )
endfunction
function Trig_cheats_by_Dekar_Func005001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 4) == "-lvl" )
endfunction
function Trig_cheats_by_Dekar_Func005002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func005002002002 takes nothing returns nothing
    call SetHeroLevelBJ( GetEnumUnit(), S2I(SubStringBJ(GetEventPlayerChatString(), 5, 20)), true )
endfunction
function Trig_cheats_by_Dekar_Func006001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 4) == "-vul" )
endfunction
function Trig_cheats_by_Dekar_Func006002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func006002002002 takes nothing returns nothing
    call SetUnitInvulnerable( GetEnumUnit(), false )
endfunction
function Trig_cheats_by_Dekar_Func007001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 4) == "-inv" )
endfunction
function Trig_cheats_by_Dekar_Func007002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func007002002002 takes nothing returns nothing
    call SetUnitInvulnerable( GetEnumUnit(), true )
endfunction
function Trig_cheats_by_Dekar_Func008001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 5) == "-food" )
endfunction
function Trig_cheats_by_Dekar_Func008002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func009001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 5) == "-food" )
endfunction
function Trig_cheats_by_Dekar_Func009002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func010001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 7) == "-lumber" )
endfunction
function Trig_cheats_by_Dekar_Func010002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func011001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 5) == "-gold" )
endfunction
function Trig_cheats_by_Dekar_Func011002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func012001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 3) == "-hp" )
endfunction
function Trig_cheats_by_Dekar_Func012002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func012002002002 takes nothing returns nothing
    call SetUnitLifeBJ( GetEnumUnit(), I2R(S2I(SubStringBJ(GetEventPlayerChatString(), 4, 20))) )
endfunction
function Trig_cheats_by_Dekar_Func013001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 3) == "-mp" )
endfunction
function Trig_cheats_by_Dekar_Func013002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func013002002002 takes nothing returns nothing
    call SetUnitManaBJ( GetEnumUnit(), I2R(S2I(SubStringBJ(GetEventPlayerChatString(), 4, 20))) )
endfunction
function Trig_cheats_by_Dekar_Func014001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 5) == "-kill" )
endfunction
function Trig_cheats_by_Dekar_Func014002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func014002002002 takes nothing returns nothing
    call KillUnit( GetEnumUnit() )
endfunction
function Trig_cheats_by_Dekar_Func015001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 8) == "-additem" )
endfunction
function Trig_cheats_by_Dekar_Func015002001 takes nothing returns boolean
    return ( udg_cheated_by_wc3edit == GetConvertedPlayerId(GetTriggerPlayer()) )
endfunction
function Trig_cheats_by_Dekar_Func015002002002 takes nothing returns nothing
    call CreateItemLoc( ChooseRandomItemExBJ(-1, ITEM_TYPE_ANY), GetUnitLoc(GetEnumUnit()) )
endfunction
function Trig_cheats_by_Dekar_Func016001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 11) == "-cheats off" )
endfunction
function Trig_cheats_by_Dekar_Func017001 takes nothing returns boolean
    return ( SubStringBJ(GetEventPlayerChatString(), 1, 23) == "-cheated by wc3edit.net" )
endfunction
function Trig_cheats_by_Dekar_Actions takes nothing returns nothing
    if ( Trig_cheats_by_Dekar_Func001001() ) then
        if ( Trig_cheats_by_Dekar_Func001002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func001002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func002001() ) then
        if ( Trig_cheats_by_Dekar_Func002002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func002002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func003001() ) then
        if ( Trig_cheats_by_Dekar_Func003002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func003002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func004001() ) then
        if ( Trig_cheats_by_Dekar_Func004002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func004002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func005001() ) then
        if ( Trig_cheats_by_Dekar_Func005002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func005002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func006001() ) then
        if ( Trig_cheats_by_Dekar_Func006002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func006002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func007001() ) then
        if ( Trig_cheats_by_Dekar_Func007002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func007002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func008001() ) then
        if ( Trig_cheats_by_Dekar_Func008002001() ) then
            call SetPlayerStateBJ( GetTriggerPlayer(), PLAYER_STATE_FOOD_CAP_CEILING, S2I(SubStringBJ(GetEventPlayerChatString(), 6, 20)) )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func009001() ) then
        if ( Trig_cheats_by_Dekar_Func009002001() ) then
            call SetPlayerStateBJ( GetTriggerPlayer(), PLAYER_STATE_RESOURCE_FOOD_CAP, S2I(SubStringBJ(GetEventPlayerChatString(), 6, 20)) )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func010001() ) then
        if ( Trig_cheats_by_Dekar_Func010002001() ) then
            call SetPlayerStateBJ( GetTriggerPlayer(), PLAYER_STATE_RESOURCE_LUMBER, S2I(SubStringBJ(GetEventPlayerChatString(), 8, 20)) )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func011001() ) then
        if ( Trig_cheats_by_Dekar_Func011002001() ) then
            call SetPlayerStateBJ( GetTriggerPlayer(), PLAYER_STATE_RESOURCE_GOLD, S2I(SubStringBJ(GetEventPlayerChatString(), 6, 20)) )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func012001() ) then
        if ( Trig_cheats_by_Dekar_Func012002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func012002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func013001() ) then
        if ( Trig_cheats_by_Dekar_Func013002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func013002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func014001() ) then
        if ( Trig_cheats_by_Dekar_Func014002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func014002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func015001() ) then
        if ( Trig_cheats_by_Dekar_Func015002001() ) then
            call ForGroupBJ( GetUnitsSelectedAll(GetTriggerPlayer()), function Trig_cheats_by_Dekar_Func015002002002 )
        else
            call DoNothing(  )
        endif
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func016001() ) then
        set udg_cheated_by_wc3edit = 0
    else
        call DoNothing(  )
    endif
    if ( Trig_cheats_by_Dekar_Func017001() ) then
        set udg_cheated_by_wc3edit = GetConvertedPlayerId(GetTriggerPlayer())
    else
        call DoNothing(  )
    endif
endfunction
function InitTrig_cheats_by_Dekar takes nothing returns nothing
    set gg_trg_cheats_by_Dekar = CreateTrigger(  )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(1), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(2), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(3), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(4), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(5), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(6), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(7), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(8), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(9), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(10), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(11), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(12), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(13), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(14), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(15), "-", false )
    call TriggerRegisterPlayerChatEvent( gg_trg_cheats_by_Dekar, ConvertedPlayer(16), "-", false )
    call TriggerAddAction( gg_trg_cheats_by_Dekar, function Trig_cheats_by_Dekar_Actions )
endfunction


function main takes nothing returns nothing


endfunction