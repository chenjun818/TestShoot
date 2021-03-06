﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LWindowBase : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			LWindowBase o;
			o=new LWindowBase();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int open(IntPtr l) {
		try {
			LWindowBase self=(LWindowBase)checkSelf(l);
			System.Collections.ArrayList a1;
			checkType(l,2,out a1);
			self.open(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int close(IntPtr l) {
		try {
			LWindowBase self=(LWindowBase)checkSelf(l);
			self.close();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disposeType(IntPtr l) {
		try {
			LWindowBase self=(LWindowBase)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.disposeType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disposeType(IntPtr l) {
		try {
			LWindowBase self=(LWindowBase)checkSelf(l);
			WindowDispose v;
			checkEnum(l,2,out v);
			self.disposeType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hierarchy(IntPtr l) {
		try {
			LWindowBase self=(LWindowBase)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.hierarchy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hierarchy(IntPtr l) {
		try {
			LWindowBase self=(LWindowBase)checkSelf(l);
			WindowHierarchy v;
			checkEnum(l,2,out v);
			self.hierarchy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LWindowBase");
		addMember(l,open);
		addMember(l,close);
		addMember(l,"disposeType",get_disposeType,set_disposeType,true);
		addMember(l,"hierarchy",get_hierarchy,set_hierarchy,true);
		createTypeMetatable(l,constructor, typeof(LWindowBase),typeof(LLuaBehaviourBase));
	}
}
