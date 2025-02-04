﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsoLangViewer.Core.Models;

namespace EsoLangViewer.Core.Contracts.Services;
public interface ILangFileService
{
    List<LangFile> ReadLangWithFileMode(string FilePath);
    List<LuaFile> ReadLuaWithFileMode(string FilePath, bool isPreGame = false);
    Task<bool> ExportLangDatasToLuaDict(Dictionary<string,string> luaDict);
}
