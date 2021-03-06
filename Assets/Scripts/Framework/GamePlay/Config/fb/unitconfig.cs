// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct unitconfigTB : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static unitconfigTB GetRootAsunitconfigTB(ByteBuffer _bb) { return GetRootAsunitconfigTB(_bb, new unitconfigTB()); }
  public static unitconfigTB GetRootAsunitconfigTB(ByteBuffer _bb, unitconfigTB obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public unitconfigTB __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public fb.unitconfigTR? Unitconfigtrs(int j) { int o = __p.__offset(4); return o != 0 ? (fb.unitconfigTR?)(new fb.unitconfigTR()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int UnitconfigtrsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<fb.unitconfigTB> CreateunitconfigTB(FlatBufferBuilder builder,
      VectorOffset unitconfigtrsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    unitconfigTB.AddUnitconfigtrs(builder, unitconfigtrsOffset);
    return unitconfigTB.EndunitconfigTB(builder);
  }

  public static void StartunitconfigTB(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddUnitconfigtrs(FlatBufferBuilder builder, VectorOffset unitconfigtrsOffset) { builder.AddOffset(0, unitconfigtrsOffset.Value, 0); }
  public static VectorOffset CreateUnitconfigtrsVector(FlatBufferBuilder builder, Offset<fb.unitconfigTR>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateUnitconfigtrsVectorBlock(FlatBufferBuilder builder, Offset<fb.unitconfigTR>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartUnitconfigtrsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<fb.unitconfigTB> EndunitconfigTB(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<fb.unitconfigTB>(o);
  }
  public static void FinishunitconfigTBBuffer(FlatBufferBuilder builder, Offset<fb.unitconfigTB> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedunitconfigTBBuffer(FlatBufferBuilder builder, Offset<fb.unitconfigTB> offset) { builder.FinishSizePrefixed(offset.Value); }
};

public struct unitconfigTR : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static unitconfigTR GetRootAsunitconfigTR(ByteBuffer _bb) { return GetRootAsunitconfigTR(_bb, new unitconfigTR()); }
  public static unitconfigTR GetRootAsunitconfigTR(ByteBuffer _bb, unitconfigTR obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public unitconfigTR __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int _id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string Desc { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(8); }
  public int Position { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Height { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Weight { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<fb.unitconfigTR> CreateunitconfigTR(FlatBufferBuilder builder,
      int _id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset descOffset = default(StringOffset),
      int position = 0,
      int height = 0,
      int weight = 0) {
    builder.StartTable(6);
    unitconfigTR.AddWeight(builder, weight);
    unitconfigTR.AddHeight(builder, height);
    unitconfigTR.AddPosition(builder, position);
    unitconfigTR.AddDesc(builder, descOffset);
    unitconfigTR.AddName(builder, nameOffset);
    unitconfigTR.Add_id(builder, _id);
    return unitconfigTR.EndunitconfigTR(builder);
  }

  public static void StartunitconfigTR(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void Add_id(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset) { builder.AddOffset(2, descOffset.Value, 0); }
  public static void AddPosition(FlatBufferBuilder builder, int position) { builder.AddInt(3, position, 0); }
  public static void AddHeight(FlatBufferBuilder builder, int height) { builder.AddInt(4, height, 0); }
  public static void AddWeight(FlatBufferBuilder builder, int weight) { builder.AddInt(5, weight, 0); }
  public static Offset<fb.unitconfigTR> EndunitconfigTR(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<fb.unitconfigTR>(o);
  }
};


}
