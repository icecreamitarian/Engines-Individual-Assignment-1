#pragma once

#ifdef SIMPLEPLUGIN_EXPORTS
#define PLUGIN_API __declspec(dllexport)
#elif SIMPLEPLUGIN_IMPORTS
#define PLUGIN_API __declspec(dllexport)
#else
#define PLUGIN_API
#endif