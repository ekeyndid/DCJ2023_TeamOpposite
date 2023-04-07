/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID BUTTONCLICK = 4051332235U;
        static const AkUniqueID BUTTONHOVER = 3035572085U;
        static const AkUniqueID CORRUPTIONSHRINE = 91495195U;
        static const AkUniqueID ENTERCORRUPTION = 435007902U;
        static const AkUniqueID ENTERRADIANCE = 3224502346U;
        static const AkUniqueID MUSICSTART = 1122283870U;
        static const AkUniqueID PLAYERDEAD = 2356585300U;
        static const AkUniqueID PLAYERLOWHEALTH = 708819110U;
        static const AkUniqueID PLAYERPICKUP = 2734591854U;
        static const AkUniqueID PLAYERSTEP = 412471812U;
        static const AkUniqueID PLAYERSWORDSWING = 2216463249U;
        static const AkUniqueID RADIANTSHRINE = 1330694103U;
        static const AkUniqueID SKELETONATTACK = 4153337164U;
        static const AkUniqueID SKELETONDEAD = 1068009922U;
        static const AkUniqueID SKELETONHURT = 1260832867U;
        static const AkUniqueID STARTGAME = 1521187885U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace MUSICREGIONS
        {
            static const AkUniqueID GROUP = 2753803885U;

            namespace STATE
            {
                static const AkUniqueID MUSICCORRUPTION = 274529429U;
                static const AkUniqueID MUSICMENU = 4082046343U;
                static const AkUniqueID MUSICRADIANCE = 3468756197U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace MUSICREGIONS

        namespace PLAYERCORRUPTIONLEVEL
        {
            static const AkUniqueID GROUP = 4228978593U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PLAYERCORRUPT = 2428916733U;
                static const AkUniqueID PLAYERNEUTRAL = 2966196035U;
                static const AkUniqueID PLAYERRADIANT = 1149610459U;
            } // namespace STATE
        } // namespace PLAYERCORRUPTIONLEVEL

        namespace PLAYERLIFE
        {
            static const AkUniqueID GROUP = 444815956U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PLAYERALIVE = 2557321869U;
                static const AkUniqueID PLAYERDEAD = 2356585300U;
                static const AkUniqueID PLAYERLOWHP = 1849584180U;
            } // namespace STATE
        } // namespace PLAYERLIFE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEPS
        {
            static const AkUniqueID GROUP = 2385628198U;

            namespace SWITCH
            {
                static const AkUniqueID STEPCORRUPTION = 786608188U;
                static const AkUniqueID STEPRADIANCE = 198879084U;
            } // namespace SWITCH
        } // namespace FOOTSTEPS

    } // namespace SWITCHES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID GAMEPLAYLOOP = 1646894747U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMBIENT = 77978275U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID NON_WORLD = 838047381U;
        static const AkUniqueID NPCS = 833916109U;
        static const AkUniqueID OBJECTS = 1695690031U;
        static const AkUniqueID PLAYER = 1069431850U;
        static const AkUniqueID UI = 1551306167U;
        static const AkUniqueID VOICE = 3170124113U;
        static const AkUniqueID WORLD = 2609808943U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
