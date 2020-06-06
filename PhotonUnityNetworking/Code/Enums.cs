// ----------------------------------------------------------------------------
// <copyright file="Enums.cs" company="Exit Games GmbH">
//   PhotonNetwork Framework for Unity - Copyright (C) 2018 Exit Games GmbH
// </copyright>
// <summary>
// Wraps up several enumerations for PUN.
// </summary>
// <author>developer@exitgames.com</author>
// ----------------------------------------------------------------------------


namespace Photon.Pun
{
    /// <summary>Which PhotonNetwork method was called to connect(which influences the regions we want pinged)调用了哪个PhotonNetwork方法进行连接（这会影响我们要ping的区域）.</summary>
    /// <remarks>PhotonNetwork.ConnectUsingSettings will call either ConnectToMaster , ConnectToRegion or ConnectToBest, depending on the settings.PhotonNetwork.ConnectUsingSettings将根据设置调用ConnectToMaster，ConnectToRegion或ConnectToBest。</remarks>
    public enum ConnectMethod { NotCalled, ConnectToMaster, ConnectToRegion, ConnectToBest }


    /// <summary>Used to define the level of logging output created by the PUN classes. Either log errors, info (some more) or full.用于定义PUN类创建的日志记录输出的级别。日志错误，信息（更多）或完整。</summary>
    /// \ingroup publicApi
    public enum PunLogLevel
    {
        /// <summary>Show only errors. Minimal output. Note: Some might be "runtime errors" which you have to expect.仅显示错误。最小的输出。注意：有些可能是您必须期望的“运行时错误”。</summary>
        ErrorsOnly,

        /// <summary>Logs some of the workflow, calls and results.记录一些工作流，调用和结果。</summary>
        Informational,

        /// <summary>Every available log call gets into the console/log. Only use for debugging.每个可用的日志调用都会进入控制台/日志。仅用于调试。</summary>
        Full
    }


    /// <summary>Enum of "target" options for RPCs. These define which remote clients get your RPC call. RPC的“目标”选项的枚举。这些定义了哪些远程客户端获得您的RPC调用。 </summary>
    /// \ingroup publicApi
    public enum RpcTarget
    {
        /// <summary>Sends the RPC to everyone else and executes it immediately on this client. Player who join later will not execute this RPC.将RPC发送给其他所有人，并立即在此客户端上执行它。稍后加入的玩家将不会执行此RPC。</summary>
        All,

        /// <summary>Sends the RPC to everyone else. This client does not execute the RPC. Player who join later will not execute this RPC.将RPC发送给其他所有人。该客户端不执行RPC。稍后加入的玩家将不会执行此RPC。</summary>
        Others,

        /// <summary>Sends the RPC to MasterClient only. Careful: The MasterClient might disconnect before it executes the RPC and that might cause dropped RPCs.仅将RPC发送到MasterClient。注意：MasterClient在执行RPC之前可能会断开连接，这可能会导致RPC丢失。</summary>
        MasterClient,

        /// <summary>Sends the RPC to everyone else and executes it immediately on this client. New players get the RPC when they join as it's buffered (until this client leaves).将RPC发送给其他所有人，并立即在此客户端上执行它。新玩家在加入RPC时会获得RPC缓冲（直到此客户端离开）。</summary>
        AllBuffered,

        /// <summary>Sends the RPC to everyone. This client does not execute the RPC. New players get the RPC when they join as it's buffered (until this client leaves).将RPC发送给所有人。该客户端不执行RPC。新玩家在加入RPC时会获得RPC缓冲（直到此客户端离开）。</summary>
        OthersBuffered,

        /// <summary>Sends the RPC to everyone (including this client) through the server.通过服务器将RPC发送给所有人（包括该客户端）。</summary>
        /// <remarks>
        /// This client executes the RPC like any other when it received it from the server.当此客户端从服务器接收到RPC时，它将像其他客户端一样执行RPC。
        /// Benefit: The server's order of sending the RPCs is the same on all clients.好处：服务器在所有客户端上发送RPC的顺序都是相同的。
        /// </remarks>
        AllViaServer,

        /// <summary>Sends the RPC to everyone (including this client) through the server and buffers it for players joining later.通过服务器将RPC发送给所有人（包括该客户端），并将其缓冲以供以后加入的玩家使用</summary>
        /// <remarks>
        /// This client executes the RPC like any other when it received it from the server.当此客户端从服务器接收到RPC时，它将像其他客户端一样执行RPC。
        /// Benefit: The server's order of sending the RPCs is the same on all clients.好处：服务器在所有客户端上发送RPC的顺序都是相同的。
        /// </remarks>
        AllBufferedViaServer
    }


    public enum ViewSynchronization { Off, ReliableDeltaCompressed, Unreliable, UnreliableOnChange }


    /// <summary>
    /// Options to define how Ownership Transfer is handled per PhotonView.用于定义如何处理每个PhotonView所有权转移的选项。
    /// </summary>
    /// <remarks>
    /// This setting affects how RequestOwnership and TransferOwnership work at runtime.此设置影响运行时RequestOwnership和TransferOwnership的工作方式。
    /// </remarks>
    public enum OwnershipOption
    {
        /// <summary>
        /// Ownership is fixed. Instantiated objects stick with their creator, scene objects always belong to the Master Client.所有权是固定的。实例化的对象依附其创建者，场景对象始终属于主客户端。
        /// </summary>
        Fixed,
        /// <summary>
        /// Ownership can be taken away from the current owner who can't object.所有权可以从不反对的当前所有者手中夺走。
        /// </summary>
        Takeover,
        /// <summary>
        /// Ownership can be requested with PhotonView.RequestOwnership but the current owner has to agree to give up ownership.可以通过PhotonView.RequestOwnership请求所有权，但是当前所有者必须同意放弃所有权。
        /// </summary>
        /// <remarks>The current owner has to implement IPunCallbacks.OnOwnershipRequest to react to the ownership request.当前所有者必须实现IPunCallbacks.OnOwnershipRequest以响应所有权请求。</remarks>
        Request
    }
}