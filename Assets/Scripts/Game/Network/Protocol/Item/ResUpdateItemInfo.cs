// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Protocol.Item
{

using global::System;
using global::FlatBuffers;

public struct ResUpdateItemInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ResUpdateItemInfo GetRootAsResUpdateItemInfo(ByteBuffer _bb) { return GetRootAsResUpdateItemInfo(_bb, new ResUpdateItemInfo()); }
  public static ResUpdateItemInfo GetRootAsResUpdateItemInfo(ByteBuffer _bb, ResUpdateItemInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ResUpdateItemInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ItemInfo? ItemInfoList(int j) { int o = __p.__offset(4); return o != 0 ? (ItemInfo?)(new ItemInfo()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ItemInfoListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ResUpdateItemInfo> CreateResUpdateItemInfo(FlatBufferBuilder builder,
      VectorOffset itemInfoListOffset = default(VectorOffset)) {
    builder.StartObject(1);
    ResUpdateItemInfo.AddItemInfoList(builder, itemInfoListOffset);
    return ResUpdateItemInfo.EndResUpdateItemInfo(builder);
  }

  public static void StartResUpdateItemInfo(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItemInfoList(FlatBufferBuilder builder, VectorOffset itemInfoListOffset) { builder.AddOffset(0, itemInfoListOffset.Value, 0); }
  public static VectorOffset CreateItemInfoListVector(FlatBufferBuilder builder, Offset<ItemInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateItemInfoListVectorBlock(FlatBufferBuilder builder, Offset<ItemInfo>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartItemInfoListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ResUpdateItemInfo> EndResUpdateItemInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ResUpdateItemInfo>(o);
  }
};


}
