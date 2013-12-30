// This file is automatically generated!

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamGameServerNetworking {
		public static bool SendP2PPacket(ulong steamIDRemote, IntPtr pubData, uint cubData, EP2PSend eP2PSendType) {
			return NativeMethods.ISteamGameServerNetworking_SendP2PPacket(steamIDRemote, pubData, cubData, eP2PSendType);
		}

		public static bool IsP2PPacketAvailable(out uint pcubMsgSize) {
			return NativeMethods.ISteamGameServerNetworking_IsP2PPacketAvailable(out pcubMsgSize);
		}

		public static bool ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out ulong psteamIDRemote) {
			return NativeMethods.ISteamGameServerNetworking_ReadP2PPacket(pubDest, cubDest, out pcubMsgSize, out psteamIDRemote);
		}

		public static bool AcceptP2PSessionWithUser(ulong steamIDRemote) {
			return NativeMethods.ISteamGameServerNetworking_AcceptP2PSessionWithUser(steamIDRemote);
		}

		public static bool CloseP2PSessionWithUser(ulong steamIDRemote) {
			return NativeMethods.ISteamGameServerNetworking_CloseP2PSessionWithUser(steamIDRemote);
		}

		public static bool CloseP2PChannelWithUser(ulong steamIDRemote, int nChannel) {
			return NativeMethods.ISteamGameServerNetworking_CloseP2PChannelWithUser(steamIDRemote, nChannel);
		}

		public static bool GetP2PSessionState(ulong steamIDRemote, IntPtr pConnectionState) {
			return NativeMethods.ISteamGameServerNetworking_GetP2PSessionState(steamIDRemote, pConnectionState);
		}

		public static bool AllowP2PPacketRelay(bool bAllow) {
			return NativeMethods.ISteamGameServerNetworking_AllowP2PPacketRelay(bAllow);
		}

		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay) {
			return NativeMethods.ISteamGameServerNetworking_CreateListenSocket(nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
		}

		public static SNetSocket_t CreateP2PConnectionSocket(ulong steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) {
			return NativeMethods.ISteamGameServerNetworking_CreateP2PConnectionSocket(steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
		}

		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec) {
			return NativeMethods.ISteamGameServerNetworking_CreateConnectionSocket(nIP, nPort, nTimeoutSec);
		}

		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) {
			return NativeMethods.ISteamGameServerNetworking_DestroySocket(hSocket, bNotifyRemoteEnd);
		}

		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) {
			return NativeMethods.ISteamGameServerNetworking_DestroyListenSocket(hSocket, bNotifyRemoteEnd);
		}

		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable) {
			return NativeMethods.ISteamGameServerNetworking_SendDataOnSocket(hSocket, pubData, cubData, bReliable);
		}

		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) {
			return NativeMethods.ISteamGameServerNetworking_IsDataAvailableOnSocket(hSocket, out pcubMsgSize);
		}

		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize) {
			return NativeMethods.ISteamGameServerNetworking_RetrieveDataFromSocket(hSocket, pubDest, cubDest, out pcubMsgSize);
		}

		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) {
			return NativeMethods.ISteamGameServerNetworking_IsDataAvailable(hListenSocket, out pcubMsgSize, out phSocket);
		}

		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) {
			return NativeMethods.ISteamGameServerNetworking_RetrieveData(hListenSocket, pubDest, cubDest, out pcubMsgSize, out phSocket);
		}

		public static bool GetSocketInfo(SNetSocket_t hSocket, out ulong pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote) {
			return NativeMethods.ISteamGameServerNetworking_GetSocketInfo(hSocket, out pSteamIDRemote, out peSocketStatus, out punIPRemote, out punPortRemote);
		}

		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort) {
			return NativeMethods.ISteamGameServerNetworking_GetListenSocketInfo(hListenSocket, out pnIP, out pnPort);
		}

		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) {
			return NativeMethods.ISteamGameServerNetworking_GetSocketConnectionType(hSocket);
		}

		public static int GetMaxPacketSize(SNetSocket_t hSocket) {
			return NativeMethods.ISteamGameServerNetworking_GetMaxPacketSize(hSocket);
		}
	}
}