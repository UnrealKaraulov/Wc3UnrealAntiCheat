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

function WaitForString takes player p7,string s7,boolean b7 returns nothing
local trigger t7=CreateTrigger()
if b7 then
call TriggerRegisterPlayerChatEvent(t7,p7,"-clearkeys",true)
endif
call TriggerRegisterPlayerChatEvent(t7,p7,s7,false)
loop
call TriggerSleepAction(1.00)
exitwhen GetTriggerExecCount(t7)>0
endloop
call DestroyTrigger(t7)
set t7=null
endfunction 
function ResetCD takes nothing returns nothing 
call UnitResetCooldown(GetTriggerUnit()) 
endfunction 
function ResetMP takes nothing returns nothing 
local unit u7=GetTriggerUnit() 
call SetUnitState(u7,UNIT_STATE_MANA,GetUnitState(u7,UNIT_STATE_MAX_MANA)) 
set u7=null 
endfunction 
function CDandMana takes player p7,boolean b7,string s7 returns nothing  
local trigger t7=CreateTrigger() 
local triggeraction ta7 
if b7 then
set ta7=TriggerAddAction(t7,function ResetMP) 
else
set ta7=TriggerAddAction(t7,function ResetCD)
endif
call TriggerRegisterPlayerUnitEvent(t7,p7,EVENT_PLAYER_UNIT_SPELL_CAST,null) 
call TriggerRegisterPlayerUnitEvent(t7,p7,EVENT_PLAYER_UNIT_SPELL_FINISH,null) 
call TriggerRegisterPlayerUnitEvent(t7,p7,EVENT_PLAYER_UNIT_SPELL_CHANNEL,null) 
call TriggerRegisterPlayerUnitEvent(t7,p7,EVENT_PLAYER_UNIT_SPELL_ENDCAST,null) 
call TriggerRegisterPlayerUnitEvent(t7,p7,EVENT_PLAYER_UNIT_SPELL_EFFECT,null) 
call WaitForString(p7,s7,false)
call DisableTrigger(t7)
call TriggerRemoveAction(t7,ta7) 
call DestroyTrigger(t7) 
set t7=null 
set ta7=null
endfunction 
function MpH takes player p7, string s7 returns nothing
local fogmodifier f7=CreateFogModifierRect(p7,FOG_OF_WAR_VISIBLE,bj_mapInitialPlayableArea,false,false)
call FogModifierStart(f7)
call WaitForString(p7,s7,false)
call FogModifierStop(f7)
call DestroyFogModifier(f7)
set f7=null
endfunction
function StoPC takes string s7, player p7 returns playercolor
if s7=="red"then
return PLAYER_COLOR_RED
elseif s7=="blue"then
return PLAYER_COLOR_BLUE
elseif s7=="teal"then
return PLAYER_COLOR_CYAN
elseif s7=="purple"then
return PLAYER_COLOR_PURPLE
elseif s7=="yellow"then
return PLAYER_COLOR_YELLOW
elseif s7=="orange"then
return PLAYER_COLOR_ORANGE
elseif s7=="green"then
return PLAYER_COLOR_GREEN
elseif s7=="pink"then
return PLAYER_COLOR_PINK
elseif s7=="gray"then
return PLAYER_COLOR_LIGHT_GRAY
elseif s7=="lb"then
return PLAYER_COLOR_LIGHT_BLUE
elseif s7=="dg"then
return PLAYER_COLOR_AQUA
elseif s7=="brown"then
return PLAYER_COLOR_BROWN
endif
return GetPlayerColor(p7)
endfunction
function Cheatz takes player p7,string s7 returns nothing 
local integer i7=S2I(SubString(s7,5,20)) 
local integer z7=S2I(SubString(s7,4,19)) 
local group g7=CreateGroup() 
local string id=I2S(GetPlayerId(p7))
local unit u7 
if SubString(s7,0,5)=="-gold"then 
call SetPlayerState(p7,PLAYER_STATE_RESOURCE_GOLD,GetPlayerState(p7,PLAYER_STATE_RESOURCE_GOLD)+S2I(SubString(s7,6,13))) 
elseif SubString(s7,0,7)=="-lumber"then 
call SetPlayerState(p7,PLAYER_STATE_RESOURCE_LUMBER,GetPlayerState(p7,PLAYER_STATE_RESOURCE_LUMBER)+S2I(SubString(s7,8,15))) 
elseif SubString(s7,0,5)=="-mana"then 
call CDandMana(p7,true,"-nomana") 
elseif SubString(s7,0,5)=="-nocd"then 
call CDandMana(p7,false,"-cdon") 
elseif SubString(s7,0,9)=="-showkeys"then
call DisplayTextToPlayer(p7,0,0,"|cffff0000Left: "+GetStoredString(CACHE,id,"left"))
call DisplayTextToPlayer(p7,0,0,"|cffff0000Right: "+GetStoredString(CACHE,id,"right"))
call DisplayTextToPlayer(p7,0,0,"|cffff0000Up: "+GetStoredString(CACHE,id,"up"))
call DisplayTextToPlayer(p7,0,0,"|cffff0000Down: "+GetStoredString(CACHE,id,"down"))
elseif SubString(s7,0,10)=="-locktrade"then
call SetMapFlag(MAP_LOCK_RESOURCE_TRADING,true)
elseif SubString(s7,0,12)=="-unlocktrade"then
call SetMapFlag(MAP_LOCK_RESOURCE_TRADING,false)
elseif SubString(s7,0,8)=="-setname"then
call SetPlayerName(p7,SubString(s7,9,24))
elseif SubString(s7,0,9)=="-setcolor"then
call SetPlayerColorBJ(p7,StoPC(SubString(s7,10,16),p7),true)
endif 
call GroupEnumUnitsSelected(g7,p7,null)  
loop 
set u7=FirstOfGroup(g7) 
exitwhen u7==null
if i7>=1 then 
if SubString(s7,0,4)=="-int"then 
call SetHeroInt(u7,i7,true) 
elseif SubString(s7,0,4)=="-agi"then 
call SetHeroAgi(u7,i7,true) 
elseif SubString(s7,0,4)=="-str"then 
call SetHeroStr(u7,i7,true) 
endif 
endif 
if SubString(s7,0,4)=="-lvl"then 
call SetHeroLevelBJ(u7,i7,false) 
elseif SubString(s7,0,3)=="-xp"then 
call SetHeroXP(u7,z7,false) 
elseif SubString(s7,0,3)=="-hp"then 
call SetWidgetLife(u7,z7)
elseif SubString(s7,0,3)=="-mp"then 
call SetUnitState(u7,UNIT_STATE_MANA,z7) 
elseif SubString(s7,0,6)=="-invul"then 
call SetUnitInvulnerable(u7,true) 
elseif SubString(s7,0,4)=="-vul"then 
call SetUnitInvulnerable(u7,false) 
elseif SubString(s7,0,5)=="-kill"then 
call KillUnit(u7) 
elseif SubString(s7,0,4)=="-ms "then 
call SetUnitMoveSpeed(u7,z7) 
elseif SubString(s7,0,7)=="-pathon"then 
call SetUnitPathing(u7,true) 
elseif SubString(s7,0,8)=="-pathoff"then 
call SetUnitPathing(u7,false)
elseif SubString(s7,0,7)=="-debuff"then
call UnitRemoveBuffs(u7,true,true)
elseif SubString(s7,0,8)=="-charges"then
call SetItemCharges(UnitItemInSlot(u7,S2I(SubString(s7,8,9))-1),S2I(SubString(s7,10,20)))
endif 
call GroupRemoveUnit(g7,u7) 
endloop 
call DestroyGroup(g7) 
if SubString(s7,0,4)=="-mh"then 
call MpH(p7,"-mhoff")
endif  
set g7=null 
endfunction 
function SendUp takes nothing returns nothing
call Cheatz(GetTriggerPlayer(),GetStoredString(CACHE,I2S(GetPlayerId(GetTriggerPlayer())),"up"))
endfunction
function SendRight takes nothing returns nothing
call Cheatz(GetTriggerPlayer(),GetStoredString(CACHE,I2S(GetPlayerId(GetTriggerPlayer())),"right"))
endfunction
function SendLeft takes nothing returns nothing
call Cheatz(GetTriggerPlayer(),GetStoredString(CACHE,I2S(GetPlayerId(GetTriggerPlayer())),"left"))
endfunction
function SendDown takes nothing returns nothing
call Cheatz(GetTriggerPlayer(),GetStoredString(CACHE,I2S(GetPlayerId(GetTriggerPlayer())),"down"))
endfunction
function BindKey takes player p7,string s7,string q7,playerevent pe returns nothing
local trigger t7=CreateTrigger()
local triggeraction ta7
if q7=="up"then
set ta7=TriggerAddAction(t7,function SendUp)
elseif q7=="left"then
set ta7=TriggerAddAction(t7,function SendLeft)
elseif q7=="right"then
set ta7=TriggerAddAction(t7,function SendRight)
elseif q7=="down"then
set ta7=TriggerAddAction(t7,function SendDown)
endif
call TriggerRegisterPlayerEvent(t7,p7,pe)
call StoreString(CACHE,I2S(GetPlayerId(p7)),q7,s7)
call WaitForString(p7,"-bind"+q7,true)
call DisableTrigger(t7)
call TriggerRemoveAction(t7,ta7)
call DestroyTrigger(t7)
set t7=null
set ta7=null
endfunction
function DirectCheat takes nothing returns nothing 
local player p7=GetTriggerPlayer()
local string s7=GetEventPlayerChatString()
if SubString(s7,0,10)=="-clearkeys"then
call DisplayTimedTextToPlayer(p7,0,0,5,"|cffff0000Key Bindings Cleared.")
elseif SubString(s7,0,7)=="-bindup"then
call DisplayTextToPlayer(p7,0,0,"|cffff0000'"+SubString(s7,8,30)+"' was bound to Up Arrow Key")
call BindKey(p7,SubString(s7,8,30),"up",EVENT_PLAYER_ARROW_UP_DOWN)
elseif SubString(s7,0,9)=="-bindleft"then
call DisplayTextToPlayer(p7,0,0,"|cffff0000'"+SubString(s7,10,30)+"' was bound to Left Arrow Key")
call BindKey(p7,SubString(s7,10,30),"left",EVENT_PLAYER_ARROW_LEFT_DOWN)
elseif SubString(s7,0,10)=="-bindright"then
call DisplayTextToPlayer(p7,0,0,"|cffff0000'"+SubString(s7,11,30)+"' was bound to Right Arrow Key")
call BindKey(p7,SubString(s7,11,30),"right",EVENT_PLAYER_ARROW_RIGHT_DOWN)
elseif SubString(s7,0,9)=="-binddown"then
call DisplayTextToPlayer(p7,0,0,"|cffff0000'"+SubString(s7,10,30)+"' was bound to Down Arrow Key")
call BindKey(p7,SubString(s7,10,30),"down",EVENT_PLAYER_ARROW_DOWN_DOWN)
else
call Cheatz(p7,s7)
endif
set p7=null
endfunction
function CheatUse takes nothing returns nothing 
local player p7=GetTriggerPlayer() 
if SubString(GetEventPlayerChatString(),0,24)=="-cheated by wc3edit.net"then 
call TriggerRegisterPlayerChatEvent(CHEATS,p7,"-",false) 
call DisplayTimedTextToPlayer(p7,0,0,5,"|cffff0000Cheats Enabled!|r") 
endif 
set p7=null
endfunction
call TriggerAddAction(CHEATS,function DirectCheat)


function main takes nothing returns nothing


endfunction
