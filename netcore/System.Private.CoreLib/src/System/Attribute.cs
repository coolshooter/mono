// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable
using System.Reflection;

namespace System
{
	partial class Attribute
	{
		static Attribute? GetAttr (ICustomAttributeProvider element, Type attributeType, bool inherit)
		{
			if (attributeType == null)
				throw new ArgumentNullException (nameof (attributeType));
			if (!attributeType.IsSubclassOf (typeof (Attribute)) && attributeType != typeof (Attribute) && attributeType != typeof (MonoCustomAttrs))
				throw new ArgumentException (SR.Argument_MustHaveAttributeBaseClass + " " + attributeType.FullName);

			var attrs = MonoCustomAttrs.GetCustomAttributes (element, attributeType, inherit);
			if (attrs == null || attrs.Length == 0)
				return null;
			if (attrs.Length != 1)
				throw new AmbiguousMatchException ();
			return (Attribute)(attrs [0]);
		}

		public static Attribute GetCustomAttribute (Assembly element, Type attributeType) => GetAttr (element, attributeType, true);
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) => GetAttr (element, attributeType, inherit);
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) => GetAttr (element, attributeType, true);
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) => GetAttr (element, attributeType, inherit);
		public static Attribute GetCustomAttribute(Module element, Type attributeType) => GetAttr (element, attributeType, true);
		public static Attribute GetCustomAttribute(Module element, Type attributeType, bool inherit) => GetAttr (element, attributeType, inherit);
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType) => GetAttr (element, attributeType, true);
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit) => GetAttr (element, attributeType, inherit);

		public static Attribute[] GetCustomAttributes (Assembly element) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, true);
		public static Attribute[] GetCustomAttributes (Assembly element, bool inherit) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, inherit);
		public static Attribute[] GetCustomAttributes (Assembly element, Type attributeType) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, true);
		public static Attribute[] GetCustomAttributes (Assembly element, Type attributeType, bool inherit) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, inherit);
		public static Attribute[] GetCustomAttributes (MemberInfo element) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, true);
		public static Attribute[] GetCustomAttributes (MemberInfo element, bool inherit) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, inherit);
		public static Attribute[] GetCustomAttributes (MemberInfo element, Type attributeType) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, true);
		public static Attribute[] GetCustomAttributes (MemberInfo element, Type attributeType, bool inherit) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, inherit);
		public static Attribute[] GetCustomAttributes (Module element) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, true);
		public static Attribute[] GetCustomAttributes (Module element, bool inherit) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, inherit);
		public static Attribute[] GetCustomAttributes (Module element, Type attributeType) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, true);
		public static Attribute[] GetCustomAttributes (Module element, Type attributeType, bool inherit) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, inherit);
		public static Attribute[] GetCustomAttributes (ParameterInfo element) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, true);
		public static Attribute[] GetCustomAttributes (ParameterInfo element, bool inherit) => (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, inherit);
		public static Attribute[] GetCustomAttributes (ParameterInfo element, Type attributeType) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, true);
		public static Attribute[] GetCustomAttributes (ParameterInfo element, Type attributeType, bool inherit) => (Attribute[])GetCustomAttributes ((ICustomAttributeProvider)element, attributeType, inherit);

		internal static Attribute[] GetCustomAttributes (ICustomAttributeProvider element, Type attributeType, bool inherit)
		{
			if (attributeType == null)
				throw new ArgumentNullException (nameof (attributeType));
			if (!attributeType.IsSubclassOf (typeof (Attribute)) && attributeType != typeof (Attribute))
				throw new ArgumentException (SR.Argument_MustHaveAttributeBaseClass + " " + attributeType.FullName);

			return (Attribute[])MonoCustomAttrs.GetCustomAttributes (element, attributeType, inherit);
		}

		public static bool IsDefined (Assembly element, Type attributeType) => IsDefined ((ICustomAttributeProvider)element, attributeType, true);
		public static bool IsDefined (Assembly element, Type attributeType, bool inherit) => IsDefined ((ICustomAttributeProvider)element, attributeType, inherit);
		public static bool IsDefined (MemberInfo element, Type attributeType) => IsDefined ((ICustomAttributeProvider)element, attributeType, true);
		public static bool IsDefined (MemberInfo element, Type attributeType, bool inherit) => IsDefined ((ICustomAttributeProvider)element, attributeType, inherit);
		public static bool IsDefined (Module element, Type attributeType) => IsDefined ((ICustomAttributeProvider)element, attributeType, true);
		public static bool IsDefined (Module element, Type attributeType, bool inherit) => IsDefined ((ICustomAttributeProvider)element, attributeType, inherit);
		public static bool IsDefined (ParameterInfo element, Type attributeType) => IsDefined ((ICustomAttributeProvider)element, attributeType, true);
		public static bool IsDefined (ParameterInfo element, Type attributeType, bool inherit) => IsDefined ((ICustomAttributeProvider)element, attributeType, inherit);

		internal static bool IsDefined (ICustomAttributeProvider element, Type attributeType, bool inherit)
		{
			if (attributeType == null)
				throw new ArgumentNullException (nameof (attributeType));
			if (!attributeType.IsSubclassOf (typeof (Attribute)) && attributeType != typeof (Attribute))
				throw new ArgumentException (SR.Argument_MustHaveAttributeBaseClass + " " + attributeType.FullName);

			return MonoCustomAttrs.IsDefined (element, attributeType, inherit);
		}
	}
}
