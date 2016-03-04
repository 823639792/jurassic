/*
 * This file is auto-generated, do not modify directly.
 */

using System.Collections.Generic;
using Jurassic;

namespace Jurassic.Library
{

	public partial class ArrayInstance
	{
		private static List<PropertyNameAndValue> GetDeclarativeProperties(ScriptEngine engine)
		{
			return new List<PropertyNameAndValue>(27)
			{
				new PropertyNameAndValue("concat", new ClrStubFunction(engine.FunctionInstancePrototype, "concat", 1, __STUB__concat), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("join", new ClrStubFunction(engine.FunctionInstancePrototype, "join", 1, __STUB__join), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("pop", new ClrStubFunction(engine.FunctionInstancePrototype, "pop", 0, __STUB__pop), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("push", new ClrStubFunction(engine.FunctionInstancePrototype, "push", 1, __STUB__push), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("reverse", new ClrStubFunction(engine.FunctionInstancePrototype, "reverse", 0, __STUB__reverse), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("shift", new ClrStubFunction(engine.FunctionInstancePrototype, "shift", 0, __STUB__shift), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("slice", new ClrStubFunction(engine.FunctionInstancePrototype, "slice", 2, __STUB__slice), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("sort", new ClrStubFunction(engine.FunctionInstancePrototype, "sort", 1, __STUB__sort), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("splice", new ClrStubFunction(engine.FunctionInstancePrototype, "splice", 2, __STUB__splice), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("unshift", new ClrStubFunction(engine.FunctionInstancePrototype, "unshift", 1, __STUB__unshift), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("toLocaleString", new ClrStubFunction(engine.FunctionInstancePrototype, "toLocaleString", 0, __STUB__toLocaleString), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("toString", new ClrStubFunction(engine.FunctionInstancePrototype, "toString", 0, __STUB__toString), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("indexOf", new ClrStubFunction(engine.FunctionInstancePrototype, "indexOf", 1, __STUB__indexOf), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("lastIndexOf", new ClrStubFunction(engine.FunctionInstancePrototype, "lastIndexOf", 1, __STUB__lastIndexOf), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("every", new ClrStubFunction(engine.FunctionInstancePrototype, "every", 1, __STUB__every), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("some", new ClrStubFunction(engine.FunctionInstancePrototype, "some", 1, __STUB__some), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("forEach", new ClrStubFunction(engine.FunctionInstancePrototype, "forEach", 1, __STUB__forEach), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("map", new ClrStubFunction(engine.FunctionInstancePrototype, "map", 1, __STUB__map), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("find", new ClrStubFunction(engine.FunctionInstancePrototype, "find", 1, __STUB__find), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("filter", new ClrStubFunction(engine.FunctionInstancePrototype, "filter", 1, __STUB__filter), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("reduce", new ClrStubFunction(engine.FunctionInstancePrototype, "reduce", 1, __STUB__reduce), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("reduceRight", new ClrStubFunction(engine.FunctionInstancePrototype, "reduceRight", 1, __STUB__reduceRight), PropertyAttributes.NonEnumerable),
			};
		}

		private static object __STUB__concat(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Concat(TypeConverter.ToObject(engine, thisObj), new object[0]);
				default:
					return Concat(TypeConverter.ToObject(engine, thisObj), args);
			}
		}

		private static object __STUB__join(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Join(TypeConverter.ToObject(engine, thisObj), ",");
				default:
					return Join(TypeConverter.ToObject(engine, thisObj), TypeUtilities.IsUndefined(args[0]) ? "," : TypeConverter.ToString(args[0]));
			}
		}

		private static object __STUB__pop(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			return Pop(TypeConverter.ToObject(engine, thisObj));
		}

		private static object __STUB__push(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Push(TypeConverter.ToObject(engine, thisObj), new object[0]);
				default:
					return Push(TypeConverter.ToObject(engine, thisObj), args);
			}
		}

		private static object __STUB__reverse(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			return Reverse(TypeConverter.ToObject(engine, thisObj));
		}

		private static object __STUB__shift(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			return Shift(TypeConverter.ToObject(engine, thisObj));
		}

		private static object __STUB__slice(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Slice(TypeConverter.ToObject(engine, thisObj), 0, int.MaxValue);
				case 1:
					return Slice(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToInteger(args[0]), int.MaxValue);
				default:
					return Slice(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToInteger(args[0]), TypeUtilities.IsUndefined(args[1]) ? int.MaxValue : TypeConverter.ToInteger(args[1]));
			}
		}

		private static object __STUB__sort(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Sort(TypeConverter.ToObject(engine, thisObj), null);
				default:
					return Sort(TypeConverter.ToObject(engine, thisObj), TypeUtilities.IsUndefined(args[0]) ? null : TypeConverter.ToObject<FunctionInstance>(engine, args[0]));
			}
		}

		private static object __STUB__splice(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Splice(TypeConverter.ToObject(engine, thisObj), 0, 0, new object[0]);
				case 1:
					return Splice(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToInteger(args[0]), 0, new object[0]);
				case 2:
					return Splice(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToInteger(args[0]), TypeConverter.ToInteger(args[1]), new object[0]);
				default:
					return Splice(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToInteger(args[0]), TypeConverter.ToInteger(args[1]), TypeUtilities.SliceArray(args, 2));
			}
		}

		private static object __STUB__unshift(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return Unshift(TypeConverter.ToObject(engine, thisObj), new object[0]);
				default:
					return Unshift(TypeConverter.ToObject(engine, thisObj), args);
			}
		}

		private static object __STUB__toLocaleString(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			return ToLocaleString(TypeConverter.ToObject(engine, thisObj));
		}

		private static object __STUB__toString(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			return ToString(TypeConverter.ToObject(engine, thisObj));
		}

		private static object __STUB__indexOf(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return IndexOf(TypeConverter.ToObject(engine, thisObj), Undefined.Value, 0);
				case 1:
					return IndexOf(TypeConverter.ToObject(engine, thisObj), args[0], 0);
				default:
					return IndexOf(TypeConverter.ToObject(engine, thisObj), args[0], TypeUtilities.IsUndefined(args[1]) ? 0 : TypeConverter.ToInteger(args[1]));
			}
		}

		private static object __STUB__lastIndexOf(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					return LastIndexOf(TypeConverter.ToObject(engine, thisObj), Undefined.Value);
				case 1:
					return LastIndexOf(TypeConverter.ToObject(engine, thisObj), args[0]);
				default:
					return LastIndexOf(TypeConverter.ToObject(engine, thisObj), args[0], TypeConverter.ToInteger(args[1]));
			}
		}

		private static object __STUB__every(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return Every(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return Every(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : TypeConverter.ToObject(engine, args[1]));
			}
		}

		private static object __STUB__some(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return Some(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return Some(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : TypeConverter.ToObject(engine, args[1]));
			}
		}

		private static object __STUB__forEach(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					ForEach(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null); return Undefined.Value;
				default:
					ForEach(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : TypeConverter.ToObject(engine, args[1])); return Undefined.Value;
			}
		}

		private static object __STUB__map(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return Map(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return Map(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : TypeConverter.ToObject(engine, args[1]));
			}
		}

		private static object __STUB__find(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return Find(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return Find(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : TypeConverter.ToObject(engine, args[1]));
			}
		}

		private static object __STUB__filter(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return Filter(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return Filter(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : TypeConverter.ToObject(engine, args[1]));
			}
		}

		private static object __STUB__reduce(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return Reduce(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return Reduce(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : args[1]);
			}
		}

		private static object __STUB__reduceRight(ScriptEngine engine, object thisObj, object[] args)
		{
			if (thisObj == null || thisObj == Undefined.Value || thisObj == Null.Value)
				throw new JavaScriptException(engine, ErrorType.TypeError, "Cannot convert undefined or null to object.");
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, ErrorType.TypeError, "undefined cannot be converted to an object");
				case 1:
					return ReduceRight(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), null);
				default:
					return ReduceRight(TypeConverter.ToObject(engine, thisObj), TypeConverter.ToObject<FunctionInstance>(engine, args[0]), TypeUtilities.IsUndefined(args[1]) ? null : args[1]);
			}
		}
	}

}
