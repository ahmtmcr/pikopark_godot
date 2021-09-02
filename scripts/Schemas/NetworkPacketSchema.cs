// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace NetworkPacket
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Vec2 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public Vec2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }

  public static Offset<NetworkPacket.Vec2> CreateVec2(FlatBufferBuilder builder, float X, float Y) {
    builder.Prep(4, 8);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<NetworkPacket.Vec2>(builder.Offset);
  }
};

public struct OtherPlayer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static OtherPlayer GetRootAsOtherPlayer(ByteBuffer _bb) { return GetRootAsOtherPlayer(_bb, new OtherPlayer()); }
  public static OtherPlayer GetRootAsOtherPlayer(ByteBuffer _bb, OtherPlayer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public OtherPlayer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Action { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public NetworkPacket.Vec2? Pos { get { int o = __p.__offset(6); return o != 0 ? (NetworkPacket.Vec2?)(new NetworkPacket.Vec2()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string Anim { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetAnimBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetAnimArray() { return __p.__vector_as_array<byte>(8); }
  public bool Direction { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static void StartOtherPlayer(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddAction(FlatBufferBuilder builder, int action) { builder.AddInt(0, action, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<NetworkPacket.Vec2> posOffset) { builder.AddStruct(1, posOffset.Value, 0); }
  public static void AddAnim(FlatBufferBuilder builder, StringOffset animOffset) { builder.AddOffset(2, animOffset.Value, 0); }
  public static void AddDirection(FlatBufferBuilder builder, bool direction) { builder.AddBool(3, direction, false); }
  public static Offset<NetworkPacket.OtherPlayer> EndOtherPlayer(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<NetworkPacket.OtherPlayer>(o);
  }
};

public struct platform : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static platform GetRootAsplatform(ByteBuffer _bb) { return GetRootAsplatform(_bb, new platform()); }
  public static platform GetRootAsplatform(ByteBuffer _bb, platform obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public platform __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Action { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public NetworkPacket.Vec2? Pos { get { int o = __p.__offset(6); return o != 0 ? (NetworkPacket.Vec2?)(new NetworkPacket.Vec2()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string Anim { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetAnimBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetAnimArray() { return __p.__vector_as_array<byte>(8); }

  public static void Startplatform(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddAction(FlatBufferBuilder builder, int action) { builder.AddInt(0, action, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<NetworkPacket.Vec2> posOffset) { builder.AddStruct(1, posOffset.Value, 0); }
  public static void AddAnim(FlatBufferBuilder builder, StringOffset animOffset) { builder.AddOffset(2, animOffset.Value, 0); }
  public static Offset<NetworkPacket.platform> Endplatform(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<NetworkPacket.platform>(o);
  }
};


}
