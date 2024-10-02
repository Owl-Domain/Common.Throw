namespace OwlDomain.Common;

static file class FlagCache<T> where T : struct, Enum
{
   #region Delegates
   private delegate T InverseCallback(T value);
   private delegate T OrCallback(T valueA, T valueB);
   private delegate T AndCallback(T valueA, T valueB);
   #endregion

   #region Fields
   private static readonly AndCallback CachedAndCallback = GetAndCallback();
   #endregion

   #region Properties
   public static T AllInverse { get; } = CalculateValue();
   #endregion

   #region Methods
   public static T And(T valueA, T valueB) => CachedAndCallback.Invoke(valueA, valueB);
   #endregion

   #region Helpers
   private static T CalculateValue()
   {
      InverseCallback inverseCallback = GetInverseCallback();
      OrCallback orCallback = GetOrCallback();

      T inverse = default;

#if NET5_0_OR_GREATER
      T[] values = Enum.GetValues<T>();
#else
      Array values = Enum.GetValues(typeof(T));
#endif

      foreach (T value in values)
         inverse = orCallback.Invoke(inverse, value);

      inverse = inverseCallback.Invoke(inverse);
      return inverse;
   }
   private static InverseCallback GetInverseCallback()
   {
      static T SByte(T value) => (T)(object)(sbyte)~(sbyte)(object)value;
      static T Byte(T value) => (T)(object)(byte)~(byte)(object)value;
      static T Short(T value) => (T)(object)(short)~(short)(object)value;
      static T UShort(T value) => (T)(object)(ushort)~(ushort)(object)value;
      static T Int(T value) => (T)(object)~(int)(object)value;
      static T UInt(T value) => (T)(object)~(uint)(object)value;
      static T Long(T value) => (T)(object)~(long)(object)value;
      static T ULong(T value) => (T)(object)~(ulong)(object)value;

      Type type = typeof(T).GetEnumUnderlyingType();

      if (type == typeof(sbyte)) return SByte;
      if (type == typeof(byte)) return Byte;
      if (type == typeof(short)) return Short;
      if (type == typeof(ushort)) return UShort;
      if (type == typeof(int)) return Int;
      if (type == typeof(uint)) return UInt;
      if (type == typeof(long)) return Long;
      if (type == typeof(ulong)) return ULong;

      Throw.For.NotSupported($"Unknown underlying enum type '{type}' on the '{typeof(T)}' enum.");
      return default!;
   }
   private static OrCallback GetOrCallback()
   {
      static T SByte(T valueA, T valueB) => (T)(object)(sbyte)((sbyte)(object)valueA | (sbyte)(object)valueB);
      static T Byte(T valueA, T valueB) => (T)(object)(byte)((byte)(object)valueA | (byte)(object)valueB);
      static T Short(T valueA, T valueB) => (T)(object)(short)((short)(object)valueA | (short)(object)valueB);
      static T UShort(T valueA, T valueB) => (T)(object)(ushort)((ushort)(object)valueA | (ushort)(object)valueB);
      static T Int(T valueA, T valueB) => (T)(object)((int)(object)valueA | (int)(object)valueB);
      static T UInt(T valueA, T valueB) => (T)(object)((uint)(object)valueA | (uint)(object)valueB);
      static T Long(T valueA, T valueB) => (T)(object)((long)(object)valueA | (long)(object)valueB);
      static T ULong(T valueA, T valueB) => (T)(object)((ulong)(object)valueA | (ulong)(object)valueB);

      Type type = typeof(T).GetEnumUnderlyingType();

      if (type == typeof(sbyte)) return SByte;
      if (type == typeof(byte)) return Byte;
      if (type == typeof(short)) return Short;
      if (type == typeof(ushort)) return UShort;
      if (type == typeof(int)) return Int;
      if (type == typeof(uint)) return UInt;
      if (type == typeof(long)) return Long;
      if (type == typeof(ulong)) return ULong;

      Throw.For.NotSupported($"Unknown underlying enum type '{type}' on the '{typeof(T)}' enum.");
      return default!;
   }
   private static AndCallback GetAndCallback()
   {
      static T SByte(T valueA, T valueB) => (T)(object)(sbyte)((sbyte)(object)valueA & (sbyte)(object)valueB);
      static T Byte(T valueA, T valueB) => (T)(object)(byte)((byte)(object)valueA & (byte)(object)valueB);
      static T Short(T valueA, T valueB) => (T)(object)(short)((short)(object)valueA & (short)(object)valueB);
      static T UShort(T valueA, T valueB) => (T)(object)(ushort)((ushort)(object)valueA & (ushort)(object)valueB);
      static T Int(T valueA, T valueB) => (T)(object)((int)(object)valueA & (int)(object)valueB);
      static T UInt(T valueA, T valueB) => (T)(object)((uint)(object)valueA & (uint)(object)valueB);
      static T Long(T valueA, T valueB) => (T)(object)((long)(object)valueA & (long)(object)valueB);
      static T ULong(T valueA, T valueB) => (T)(object)((ulong)(object)valueA & (ulong)(object)valueB);

      Type type = typeof(T).GetEnumUnderlyingType();

      if (type == typeof(sbyte)) return SByte;
      if (type == typeof(byte)) return Byte;
      if (type == typeof(short)) return Short;
      if (type == typeof(ushort)) return UShort;
      if (type == typeof(int)) return Int;
      if (type == typeof(uint)) return UInt;
      if (type == typeof(long)) return Long;
      if (type == typeof(ulong)) return ULong;

      Throw.For.NotSupported($"Unknown underlying enum type '{type}' on the '{typeof(T)}' enum.");
      return default!;
   }
   #endregion
}

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>Checks if the given <paramref name="argument"/> has any invalid flags set.</summary>
   /// <typeparam name="T">The type of the <paramref name="argument"/>.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="argument"/> has any invalid flags set.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument HasInvalidFlags<T>(
     this IThrowIfArgument @throw,
     T argument,
     [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
     where T : struct, Enum
   {
      T inverse = FlagCache<T>.AllInverse;

      T invalid = FlagCache<T>.And(inverse, argument);

      if (invalid.CompareTo(default(T)) is not 0)
         Throw.For.Argument($"The given argument value ({argument}), from the enum ({typeof(T)}) had the invalid bit fields ({invalid}) set.", argumentExpression);

      return @throw;
   }
   #endregion
}
