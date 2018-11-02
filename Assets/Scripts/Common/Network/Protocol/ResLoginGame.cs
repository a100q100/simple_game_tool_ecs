// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Protocol
{

using global::System;
using global::FlatBuffers;

public struct ResLoginGame : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ResLoginGame GetRootAsResLoginGame(ByteBuffer _bb) { return GetRootAsResLoginGame(_bb, new ResLoginGame()); }
  public static ResLoginGame GetRootAsResLoginGame(ByteBuffer _bb, ResLoginGame obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ResLoginGame __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool Result { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string AccountId { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAccountIdBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetAccountIdBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetAccountIdArray() { return __p.__vector_as_array<byte>(6); }
  public RoleInfoLite? RoleInfoLites(int j) { int o = __p.__offset(8); return o != 0 ? (RoleInfoLite?)(new RoleInfoLite()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RoleInfoLitesLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ResLoginGame> CreateResLoginGame(FlatBufferBuilder builder,
      bool result = false,
      StringOffset accountIdOffset = default(StringOffset),
      VectorOffset roleInfoLitesOffset = default(VectorOffset)) {
    builder.StartObject(3);
    ResLoginGame.AddRoleInfoLites(builder, roleInfoLitesOffset);
    ResLoginGame.AddAccountId(builder, accountIdOffset);
    ResLoginGame.AddResult(builder, result);
    return ResLoginGame.EndResLoginGame(builder);
  }

  public static void StartResLoginGame(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddResult(FlatBufferBuilder builder, bool result) { builder.AddBool(0, result, false); }
  public static void AddAccountId(FlatBufferBuilder builder, StringOffset accountIdOffset) { builder.AddOffset(1, accountIdOffset.Value, 0); }
  public static void AddRoleInfoLites(FlatBufferBuilder builder, VectorOffset roleInfoLitesOffset) { builder.AddOffset(2, roleInfoLitesOffset.Value, 0); }
  public static VectorOffset CreateRoleInfoLitesVector(FlatBufferBuilder builder, Offset<RoleInfoLite>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRoleInfoLitesVectorBlock(FlatBufferBuilder builder, Offset<RoleInfoLite>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRoleInfoLitesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ResLoginGame> EndResLoginGame(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ResLoginGame>(o);
  }
  public static void FinishResLoginGameBuffer(FlatBufferBuilder builder, Offset<ResLoginGame> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedResLoginGameBuffer(FlatBufferBuilder builder, Offset<ResLoginGame> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
