#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class KSFrameworkLuaUIControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(KSFramework.LuaUIController);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInit", _m_OnInit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnOpen", _m_OnOpen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnClose", _m_OnClose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetOutlet", _m_SetOutlet);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetOutlet_Slua", _m_SetOutlet_Slua);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetControl", _m_GetControl);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearLuaTableCache", _m_ClearLuaTableCache);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LastOnOpenArgs", _g_get_LastOnOpenArgs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UILuaPath", _g_get_UILuaPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canvas", _g_get_canvas);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "canvas", _s_set_canvas);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sortOrder", _g_get_sortOrder);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sortOrder", _s_set_sortOrder);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KSFramework.LuaUIController gen_ret = new KSFramework.LuaUIController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KSFramework.LuaUIController constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnInit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnInit(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnOpen(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object[] _args = translator.GetParams<object>(L, 2);
                    
                    gen_to_be_invoked.OnOpen( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnClose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnClose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOutlet(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XLua.LuaTable __luaTable = (XLua.LuaTable)translator.GetObject(L, 2, typeof(XLua.LuaTable));
                    
                    gen_to_be_invoked.SetOutlet( __luaTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOutlet_Slua(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XLua.LuaTable __luaTable = (XLua.LuaTable)translator.GetObject(L, 2, typeof(XLua.LuaTable));
                    
                    gen_to_be_invoked.SetOutlet_Slua( __luaTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControl(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    string _uri = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.Object gen_ret = gen_to_be_invoked.GetControl( _typeName, _uri );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    string _uri = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _findTrans = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Object gen_ret = gen_to_be_invoked.GetControl( _typeName, _uri, _findTrans );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    string _uri = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _findTrans = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isLog = LuaAPI.lua_toboolean(L, 5);
                    
                        UnityEngine.Object gen_ret = gen_to_be_invoked.GetControl( _typeName, _uri, _findTrans, _isLog );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KSFramework.LuaUIController.GetControl!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearLuaTableCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearLuaTableCache(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LastOnOpenArgs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LastOnOpenArgs);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UILuaPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.UILuaPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortOrder(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, KSFramework.LuaUIController.sortOrder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canvas(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.canvas);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortOrder(RealStatePtr L)
        {
		    try {
                
			    KSFramework.LuaUIController.sortOrder = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_canvas(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KSFramework.LuaUIController gen_to_be_invoked = (KSFramework.LuaUIController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.canvas = (UnityEngine.Canvas)translator.GetObject(L, 2, typeof(UnityEngine.Canvas));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
