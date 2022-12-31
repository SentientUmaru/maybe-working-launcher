/* Function: FUN_00401000 */
LRESULT FUN_00401000(HWND param_1,UINT param_2,WPARAM param_3,int param_4)

{
  int iVar1;
  int iVar2;
  LRESULT LVar3;
  HDC hDC;
  HBRUSH hbr;
  HFONT h;
  HGDIOBJ h_00;
  int iVar4;
  tagPAINTSTRUCT local_60;
  tagRECT local_20;
  LOGBRUSH local_10;
  
  iVar1 = DAT_0047aef4;
  if (param_2 == 0xf) {
    hDC = BeginPaint(param_1,&local_60);
    local_10.lbStyle = 0;
    GetClientRect(param_1,&local_20);
    iVar2 = local_20.bottom;
    local_20.bottom = 0;
    for (; local_20.top < iVar2; local_20.top = local_20.top + 4) {
      iVar4 = iVar2 - local_20.top;
      local_10.lbColor =
           (uint)CONCAT11((char)((int)((uint)*(byte *)(iVar1 + 0x52) * iVar4 +
                                      (uint)*(byte *)(iVar1 + 0x56) * local_20.top) / iVar2),
                          (char)((int)((uint)*(byte *)(iVar1 + 0x51) * iVar4 +
                                      (uint)*(byte *)(iVar1 + 0x55) * local_20.top) / iVar2)) << 8 |
           (int)((uint)*(byte *)(iVar1 + 0x50) * iVar4 +
                (uint)*(byte *)(iVar1 + 0x54) * local_20.top) / iVar2 & 0xffU;
      hbr = CreateBrushIndirect(&local_10);
      local_20.bottom = local_20.bottom + 4;
      FillRect(hDC,&local_20,hbr);
      DeleteObject(hbr);
    }
    if (*(int *)(iVar1 + 0x58) != -1) {
      h = CreateFontIndirectW(*(LOGFONTW **)(iVar1 + 0x34));
      if (h != (HFONT)0x0) {
        local_20.left = 0x10;
        local_20.top = 8;
        SetBkMode(hDC,1);
        SetTextColor(hDC,*(COLORREF *)(iVar1 + 0x58));
        h_00 = SelectObject(hDC,h);
        DrawTextW(hDC,(LPCWSTR)&DAT_00472ee0,-1,&local_20,0x820);
        SelectObject(hDC,h_00);
        DeleteObject(h);
      }
    }
    EndPaint(param_1,&local_60);
    LVar3 = 0;
  }
  else {
    if (param_2 == 0x46) {
      *(uint *)(param_4 + 0x18) = *(uint *)(param_4 + 0x18) | 0x10;
      *(undefined4 *)(param_4 + 4) = DAT_0047aee8;
    }
    LVar3 = DefWindowProcW(param_1,param_2,param_3,param_4);
  }
  return LVar3;
}

/* Function: FUN_0040117d */
void FUN_0040117d(int param_1)

{
  uint uVar1;
  uint uVar2;
  uint *puVar3;
  uint uVar4;
  int iVar5;
  int iVar6;
  
  uVar1 = *(uint *)(param_1 * 0x4018 + 8 + DAT_0047af28);
  if ((uVar1 & 2) != 0) {
    uVar4 = param_1 + 1;
    if (uVar4 < DAT_0047af2c) {
      puVar3 = (uint *)(uVar4 * 0x4018 + 8 + DAT_0047af28);
      iVar5 = 0;
      do {
        uVar2 = *puVar3;
        if ((uVar2 & 2) == 0) {
          if ((uVar2 & 4) == 0) {
            iVar6 = iVar5;
            if ((uVar2 & 0x10) == 0) {
              *puVar3 = (uVar2 ^ uVar1) & 1 ^ uVar2;
            }
          }
          else {
            iVar6 = iVar5 + -1;
            if (iVar5 == 0) {
              return;
            }
          }
        }
        else {
          iVar6 = iVar5 + 1;
        }
        uVar4 = uVar4 + 1;
        puVar3 = puVar3 + 0x1006;
        iVar5 = iVar6;
      } while (uVar4 < DAT_0047af2c);
    }
  }
  return;
}

/* Function: FUN_004011ef */
uint FUN_004011ef(uint param_1,int param_2)

{
  uint *puVar1;
  int iVar2;
  uint uVar3;
  uint uVar4;
  int iVar5;
  int local_c;
  int local_8;
  
  iVar2 = DAT_0047af28;
  iVar5 = param_1 * 0x4018 + DAT_0047af28;
  local_8 = 0;
  local_c = 0;
  if (((*(uint *)(iVar5 + 8) & 2) != 0) && (param_2 != 0)) {
    param_1 = param_1 + 1;
    *(uint *)(iVar5 + 8) = *(uint *)(iVar5 + 8) & 0xffffffbe;
  }
  if (param_1 < DAT_0047af2c) {
    do {
      puVar1 = (uint *)(param_1 * 0x4018 + 8 + iVar2);
      uVar3 = param_1 + 1;
      uVar4 = *puVar1;
      if ((uVar4 & 2) != 0) {
        uVar3 = FUN_004011ef(param_1,1);
        uVar4 = *puVar1;
      }
      if ((uVar4 & 4) != 0) {
        if (local_8 == 0) {
          return uVar3;
        }
        if (local_c != 0) {
          *(uint *)(iVar5 + 8) = *(uint *)(iVar5 + 8) | 0x40;
          return uVar3;
        }
        *(uint *)(iVar5 + 8) = *(uint *)(iVar5 + 8) & 0xffffff7f | 1;
        return uVar3;
      }
      if ((uVar4 & 0x40) != 0) {
        local_8 = local_8 + 1;
      }
      if ((uVar4 & 1) == 0) {
        local_c = local_c + 1;
      }
      else {
        local_8 = local_8 + 1;
      }
      param_1 = uVar3;
    } while (uVar3 < DAT_0047af2c);
  }
  return 0;
}

/* Function: FUN_00401299 */
void FUN_00401299(uint param_1)

{
  uint uVar1;
  uint *puVar2;
  uint uVar3;
  
  uVar3 = 0;
  if ((param_1 < 0x20) && (DAT_0047af2c != 0)) {
    puVar2 = (uint *)(DAT_0047af28 + 8);
    do {
      uVar1 = *puVar2;
      if ((uVar1 & 6) == 0) {
        if ((puVar2[-1] & 1 << ((byte)param_1 & 0x1f)) == 0) {
          uVar1 = uVar1 & 0xfffffffe;
        }
        else {
          uVar1 = uVar1 | 1;
        }
        *puVar2 = uVar1;
      }
      uVar3 = uVar3 + 1;
      puVar2 = puVar2 + 0x1006;
    } while (uVar3 < DAT_0047af2c);
  }
  return;
}

/* Function: FUN_004012e2 */
uint FUN_004012e2(int param_1)

{
  uint uVar1;
  uint *puVar2;
  bool bVar3;
  int *local_c;
  uint local_8;
  
  local_8 = 0;
  local_c = (int *)(DAT_0047aef4 + 0x94);
  do {
    uVar1 = 0;
    if (*local_c != 0) {
      bVar3 = DAT_0047af2c == 0;
      if (DAT_0047af2c != 0) {
        puVar2 = (uint *)(DAT_0047af28 + 8);
        do {
          if (((*puVar2 & 6) == 0) &&
             (((param_1 == 0 || (*(int *)(param_1 + uVar1 * 4) != 0)) &&
              ((puVar2[-1] & 1 << ((byte)local_8 & 0x1f)) != (*puVar2 & 1) << ((byte)local_8 & 0x1f)
              )))) break;
          uVar1 = uVar1 + 1;
          puVar2 = puVar2 + 0x1006;
        } while (uVar1 < DAT_0047af2c);
        bVar3 = uVar1 == DAT_0047af2c;
      }
      if (bVar3) {
        return local_8;
      }
    }
    local_8 = local_8 + 1;
    local_c = local_c + 1;
    if (0x1f < local_8) {
      return local_8;
    }
  } while( true );
}

/* Function: FUN_0040136d */
void FUN_0040136d(int param_1)

{
  if (param_1 < 0) {
    FUN_0040621a((ushort *)(&DAT_0047b000 + (param_1 + 1) * -0x4000));
  }
  return;
}

/* Function: FUN_00401389 */
undefined4 FUN_00401389(int param_1,HWND param_2)

{
  HWND pHVar1;
  int iVar2;
  int iVar3;
  WPARAM wParam;
  LPARAM lParam;
  
  while ((-1 < param_1 && (pHVar1 = (HWND)(param_1 * 0x1c + DAT_0047af30), pHVar1->unused != 1))) {
    pHVar1 = FUN_00401434(pHVar1);
    if (pHVar1 == (HWND)0x7fffffff) {
      return 0x7fffffff;
    }
    iVar2 = FUN_0040136d((int)pHVar1);
    if (iVar2 == 0) {
      iVar3 = 1;
      iVar2 = param_1 + 1;
    }
    else {
      iVar2 = iVar2 + -1;
      iVar3 = iVar2 - param_1;
    }
    param_1 = iVar2;
    if (param_2 != (HWND)0x0) {
      DAT_00472ecc = DAT_00472ecc + iVar3;
      lParam = 0;
      wParam = MulDiv(DAT_00472ecc,30000,DAT_00472eb4);
      SendMessageW(param_2,0x402,wParam,lParam);
    }
  }
  return 0;
}

/* Function: FUN_0040140b */
void FUN_0040140b(int param_1)

{
  FUN_00401389(*(int *)(DAT_0047aef4 + 0x6c + param_1 * 4),(HWND)0x0);
  return;
}

/* Function: FUN_00401423 */
void FUN_00401423(int param_1)

{
  FUN_00405322(param_1,(LPCWSTR)&DAT_0040e5d0);
  return;
}

/* Function: FUN_00401434 */
/* WARNING: Type propagation algorithm not settling */
/* WARNING: Could not reconcile some variable overlaps */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

HWND FUN_00401434(HWND param_1)

{
  short sVar1;
  undefined4 uVar2;
  short *psVar3;
  HWND pHVar4;
  uint uVar5;
  LRESULT LVar6;
  HGDIOBJ ho;
  HDC hdc;
  DWORD DVar7;
  SIZE_T dwBytes;
  FARPROC pFVar8;
  HRESULT HVar9;
  undefined *puVar10;
  LPCWSTR lpFileName;
  LPCWSTR pWVar11;
  HKEY pHVar12;
  LSTATUS LVar13;
  HANDLE pvVar14;
  LPWSTR pWVar15;
  uint uVar16;
  int iVar17;
  BOOL BVar18;
  HGLOBAL hMem;
  int *piVar19;
  HWND pHVar20;
  byte bVar21;
  int iVar22;
  LPCWSTR extraout_EDX;
  LPCWSTR pWVar23;
  HWND pHVar24;
  WCHAR *pWVar25;
  LPCWSTR lpKeyName;
  bool bVar26;
  undefined8 uVar27;
  undefined8 uVar28;
  UINT type;
  LONG lDistanceToMove;
  PLONG lpDistanceToMoveHigh;
  UINT fuLoad;
  undefined2 *puVar29;
  _WIN32_FIND_DATAW local_2d8;
  undefined local_88 [32];
  HINSTANCE local_68;
  LPCWSTR local_64;
  LPCWSTR local_60;
  undefined2 local_5c;
  undefined2 local_54;
  undefined2 uStack_52;
  undefined4 local_50;
  LPCWSTR local_4c;
  uint local_48 [2];
  LPCWSTR local_40;
  LPCWSTR local_3c;
  undefined8 local_38;
  int local_30;
  HWND local_2c [2];
  HWND local_24;
  undefined8 local_20;
  HWND local_18;
  HWND local_14;
  HWND local_10;
  HWND local_c;
  HWND local_8;
  
  pHVar20 = DAT_0041e630;
  pHVar24 = param_1;
  piVar19 = &local_30;
  for (iVar22 = 7; iVar22 != 0; iVar22 = iVar22 + -1) {
    *piVar19 = pHVar24->unused;
    pHVar24 = pHVar24 + 1;
    piVar19 = piVar19 + 1;
  }
  local_c = DAT_0047aee8;
  pWVar23 = (LPCWSTR)0x0;
  local_10 = (HWND)(&DAT_0047b000 + (int)local_2c[1] * 0x4000);
  DAT_0041e62c = local_2c;
  iVar22 = (int)local_2c[0] * 0x4000;
  pHVar24 = (HWND)(&DAT_0047b000 + iVar22);
  local_8 = (HWND)0x0;
  switch(local_30) {
  case 2:
    goto switchD_0040148a_caseD_2;
  case 3:
    pWVar23 = (LPCWSTR)0x0;
LAB_00401493:
    FUN_00405322((int)local_2c[0],pWVar23);
    return (HWND)0x7fffffff;
  case 4:
    _DAT_00472eac = _DAT_00472eac + 1;
    if (DAT_0047aee8 == (HWND)0x0) {
      return (HWND)0x7fffffff;
    }
    PostQuitMessage(0);
    return (HWND)0x7fffffff;
  case 5:
    iVar22 = FUN_0040136d((int)local_2c[0]);
    pHVar20 = (HWND)FUN_00401389(iVar22 + -1,(HWND)0x0);
    return pHVar20;
  case 6:
    FUN_00405322((int)local_2c[0],(LPCWSTR)0x0);
    break;
  case 7:
    uVar28 = FUN_00402c1f(0);
    DVar7 = (DWORD)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    if ((int)DVar7 < 2) {
      DVar7 = 1;
    }
    Sleep(DVar7);
    break;
  case 8:
    SetForegroundWindow(DAT_0047aee8);
    break;
  case 9:
    if (DAT_00472eb0 != (HWND)0x0) {
      ShowWindow(DAT_00472eb0,(int)local_2c[1]);
    }
    if (DAT_00472ec4 != (HWND)0x0) {
      ShowWindow(DAT_00472ec4,(int)local_2c[0]);
    }
    break;
  case 10:
    pWVar23 = FUN_00402c41(0xfffffff0);
    pWVar15 = (LPWSTR)SetFileAttributesW(pWVar23,(DWORD)local_2c[1]);
    goto LAB_004015b4;
  case 0xb:
    param_1 = (HWND)FUN_00402c41(0xfffffff0);
    pWVar15 = FUN_00405c3a((LPCWSTR)param_1);
    if (pWVar15 != (LPWSTR)0x0) {
      do {
        psVar3 = (short *)FUN_00405bbc(pWVar15,L'\\');
        sVar1 = *psVar3;
        *psVar3 = 0;
        if (((sVar1 == 0) && (local_24 != (HWND)0x0)) && (iVar22 = FUN_0040588b(), iVar22 != 0)) {
          DVar7 = FUN_004057f1((LPCWSTR)param_1);
        }
        else {
          DVar7 = FUN_0040586e((LPCWSTR)param_1);
        }
        if ((DVar7 != 0) &&
           ((DVar7 != 0xb7 || (DVar7 = GetFileAttributesW((LPCWSTR)param_1), (DVar7 & 0x10) == 0))))
        {
          local_8 = (HWND)((int)&local_8->unused + 1);
        }
        *psVar3 = sVar1;
        pWVar15 = psVar3 + 1;
      } while (sVar1 != 0);
    }
    if (local_2c[1] == (HWND)0x0) {
      iVar22 = -0xb;
      goto LAB_0040224b;
    }
    FUN_00401423(-0x1a);
    FUN_004062ba((LPWSTR)&DAT_004d3000,(LPCWSTR)param_1);
    BVar18 = SetCurrentDirectoryW((LPCWSTR)param_1);
    if (BVar18 == 0) {
      local_8 = (HWND)((int)&local_8->unused + 1);
    }
    break;
  case 0xc:
    pWVar23 = FUN_00402c41(0);
    puVar10 = FUN_004065fd(pWVar23);
    local_20._0_4_ = local_2c[1];
    goto joined_r0x00401a1e;
  case 0xd:
    iVar22 = (int)local_2c[0] * 4;
    if (local_24 == (HWND)0x0) {
      *(undefined4 *)(&DAT_0047afc0 + iVar22) = *(undefined4 *)(&DAT_0047af80 + iVar22);
      uVar2 = FUN_00402c1f(1);
      *(undefined4 *)(&DAT_0047af80 + (int)local_2c[0] * 4) = uVar2;
    }
    else {
      *(undefined4 *)(&DAT_0047af80 + iVar22) = *(undefined4 *)(&DAT_0047afc0 + iVar22);
    }
    break;
  case 0xe:
    uVar16 = *(uint *)(&DAT_0047af80 + (int)local_24 * 4);
    pHVar20 = local_2c[uVar16 == 0];
    *(uint *)(&DAT_0047af80 + (int)local_24 * 4) = uVar16 & (uint)(HWND)local_20;
    return pHVar20;
  case 0xf:
    pHVar20 = *(HWND *)(&DAT_0047af80 + (int)local_2c[1] * 4);
    goto LAB_00402a6b;
  case 0x10:
    pWVar23 = FUN_00402c41(0xffffffd0);
    pWVar11 = FUN_00402c41(0xffffffdf);
    FUN_00402c41(0x13);
    BVar18 = MoveFileW(pWVar23,pWVar11);
    if (BVar18 == 0) {
      if ((local_24 == (HWND)0x0) || (puVar10 = FUN_004065fd(pWVar23), puVar10 == (undefined *)0x0))
      goto LAB_0040288b;
      FUN_00406080(pWVar23,pWVar11);
      iVar22 = -0x1c;
    }
    else {
      iVar22 = -0x1d;
    }
    goto LAB_0040224b;
  case 0x11:
    pHVar24 = (HWND)FUN_00402c41(0);
    pHVar20 = local_10;
    DVar7 = GetFullPathNameW((LPCWSTR)pHVar24,0x2000,(LPWSTR)local_10,(LPWSTR *)&param_1);
    if (DVar7 == 0) {
LAB_00401710:
      local_8 = (HWND)0x1;
      *(undefined2 *)&pHVar20->unused = 0;
    }
    else if ((pHVar24 < param_1) && (*(short *)&param_1->unused != 0)) {
      puVar10 = FUN_004065fd((LPCWSTR)pHVar24);
      if (puVar10 == (undefined *)0x0) goto LAB_00401710;
      FUN_004062ba((LPWSTR)param_1,(LPCWSTR)(puVar10 + 0x2c));
    }
    if (local_24 == (HWND)0x0) {
      GetShortPathNameW((LPCWSTR)pHVar20,(LPWSTR)pHVar20,0x2000);
    }
    break;
  case 0x12:
    pWVar23 = FUN_00402c41(0xffffffff);
    DVar7 = SearchPathW((LPCWSTR)0x0,pWVar23,(LPCWSTR)0x0,0x2000,(LPWSTR)pHVar24,(LPWSTR *)&param_1)
    ;
    bVar26 = DVar7 == 0;
    goto LAB_00401751;
  case 0x13:
    pWVar23 = FUN_00402c41(0xffffffef);
    pWVar15 = FUN_00405ddf((LPWSTR)pHVar24,pWVar23);
    goto LAB_004015b4;
  case 0x14:
    local_c = (HWND)FUN_00402c41(0x31);
    param_1 = (HWND)((uint)local_2c[0] & 7);
    iVar22 = FUN_00405c06((ushort *)local_c);
    if (iVar22 == 0) {
      pHVar20 = local_c;
      pWVar23 = (LPCWSTR)FUN_004062ba((LPWSTR)&DAT_0040a5d0,(LPCWSTR)&DAT_004d3000);
      pWVar23 = FUN_00405b8f(pWVar23);
      lstrcatW(pWVar23,(LPCWSTR)pHVar20);
    }
    else {
      FUN_004062ba((LPWSTR)&DAT_0040a5d0,(LPCWSTR)local_c);
    }
    FUN_0040654e((LPCWSTR)&DAT_0040a5d0);
    do {
      if (2 < (int)param_1) {
        puVar10 = FUN_004065fd((LPCWSTR)&DAT_0040a5d0);
        uVar16 = 0;
        if (puVar10 != (undefined *)0x0) {
          uVar16 = CompareFileTime((FILETIME *)(puVar10 + 0x14),(FILETIME *)&local_20);
        }
        param_1 = (HWND)(uint)((((uint)((int)&param_1[-1].unused + 1U) | 0x80000000) & uVar16) == 0)
        ;
      }
      if (param_1 == (HWND)0x0) {
        FUN_00405d8b((LPCWSTR)&DAT_0040a5d0);
      }
      local_38._4_4_ =
           (HWND)FUN_00405db0((LPCWSTR)&DAT_0040a5d0,0x40000000,(param_1 != (HWND)0x1) + 1);
      if (local_38._4_4_ != (HWND)0xffffffff) {
        FUN_00405322(-0x16,(LPCWSTR)local_c);
        DAT_0047afb4 = DAT_0047afb4 + 1;
        DVar7 = FUN_00403116((int)local_24,local_38._4_4_,(undefined *)0x0,0);
        DAT_0047afb4 = DAT_0047afb4 + -1;
        if (((HWND)local_20 != (HWND)0xffffffff) || (local_20._4_4_ != (HWND)0xffffffff)) {
          SetFileTime(local_38._4_4_,(FILETIME *)&local_20,(FILETIME *)0x0,(FILETIME *)&local_20);
        }
        CloseHandle(local_38._4_4_);
        if (-1 < (int)DVar7) goto switchD_0040148a_caseD_41;
        if (DVar7 == 0xfffffffe) {
          FUN_004062dc((LPWSTR)&DAT_0040a5d0,-0x17);
          lstrcatW((LPWSTR)&DAT_0040a5d0,(LPCWSTR)local_c);
        }
        else {
          FUN_004062dc((LPWSTR)&DAT_0040a5d0,-0x12);
        }
        uVar16 = 0x200010;
        puVar10 = &DAT_0040a5d0;
        goto LAB_004022f2;
      }
      if (param_1 != (HWND)0x0) {
        FUN_00405322(-0x1e,(LPCWSTR)local_c);
        bVar26 = param_1 == (HWND)0x2;
        goto LAB_004015b6;
      }
      FUN_004062ba((LPWSTR)&DAT_004125d0,(LPCWSTR)&DAT_0047b000);
      FUN_004062ba((LPWSTR)&DAT_0047b000,(LPCWSTR)&DAT_0040a5d0);
      FUN_004062dc((LPWSTR)&DAT_0040e5d0,(int)local_18);
      FUN_004062ba((LPWSTR)&DAT_0047b000,(LPCWSTR)&DAT_004125d0);
      iVar22 = FUN_00405920(&DAT_0040e5d0,(int)local_2c[0] >> 3);
    } while (iVar22 == 4);
    if (iVar22 != 5) {
      pWVar23 = (LPCWSTR)&DAT_0040a5d0;
      local_2c[0] = (HWND)0xfffffffa;
      goto LAB_00401493;
    }
    _DAT_0047af88 = _DAT_0047af88 + 1;
    goto LAB_00402ace;
  case 0x15:
    uVar16 = 0;
    goto LAB_00401943;
  case 0x16:
    pWVar23 = FUN_00402c41(0x31);
    pHVar20 = (HWND)FUN_00405920(pWVar23,(uint)local_2c[0]);
    if (pHVar20 == (HWND)0x0) goto LAB_0040288b;
    if (pHVar20 == local_24) {
      return (HWND)local_20;
    }
    if (pHVar20 == local_20._4_4_) {
      return local_18;
    }
    break;
  case 0x17:
    uVar16 = 0xfffffff0;
LAB_00401943:
    pWVar23 = FUN_00402c41(uVar16);
    FUN_004059cc(pWVar23,(uint)local_2c[1]);
    break;
  case 0x18:
    pWVar23 = FUN_00402c41(1);
    pHVar20 = (HWND)lstrlenW(pWVar23);
    goto LAB_00402a6b;
  case 0x19:
    uVar28 = FUN_00402c1f(2);
    local_54 = (undefined2)uVar28;
    uStack_52 = (undefined2)((ulonglong)uVar28 >> 0x10);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    local_38 = FUN_00402c1f(3);
    pHVar20 = (HWND)local_38;
    param_1 = (HWND)CONCAT22(uStack_52,local_54);
    local_40 = FUN_00402c41(1);
    pHVar4 = (HWND)lstrlenW(local_40);
    *(undefined2 *)&pHVar24->unused = 0;
    if (CONCAT22(local_50._2_2_,(undefined2)local_50) == 0) {
      param_1 = pHVar4;
    }
    if ((param_1 != (HWND)0x0) &&
       ((-1 < (int)local_38 ||
        (pHVar20 = (HWND)((int)local_38 + (int)&pHVar4->unused), -1 < (int)pHVar20)))) {
      if ((int)pHVar4 < (int)pHVar20) {
        pHVar20 = pHVar4;
      }
      FUN_004062ba((LPWSTR)pHVar24,local_40 + (int)pHVar20);
      if ((int)param_1 < 0) {
        iVar22 = lstrlenW((LPCWSTR)pHVar24);
        param_1 = (HWND)((int)&param_1->unused + iVar22);
        if ((int)param_1 < 0) {
          param_1 = (HWND)0x0;
        }
      }
      if ((int)param_1 < 0x2000) {
        *(undefined2 *)((int)&pHVar24->unused + (int)param_1 * 2) = 0;
      }
    }
    break;
  case 0x1a:
    pWVar23 = FUN_00402c41(0x20);
    pWVar11 = FUN_00402c41(0x31);
    if (local_20._4_4_ == (HWND)0x0) {
      puVar10 = (undefined *)lstrcmpiW(pWVar23,pWVar11);
    }
    else {
      puVar10 = (undefined *)lstrcmpW(pWVar23,pWVar11);
    }
    goto joined_r0x00401a1e;
  case 0x1b:
    param_1 = (HWND)FUN_00402c41(1);
    DVar7 = ExpandEnvironmentStringsW((LPCWSTR)param_1,(LPWSTR)pHVar24,0x2000);
    if ((DVar7 == 0) ||
       ((local_24 != (HWND)0x0 &&
        (iVar17 = lstrcmpW((LPCWSTR)param_1,(LPCWSTR)pHVar24), iVar17 == 0)))) {
      local_8 = (HWND)0x1;
      *(undefined2 *)&pHVar24->unused = 0;
    }
    *(undefined2 *)(&DAT_0047effe + iVar22) = 0;
    break;
  case 0x1c:
    uVar28 = FUN_00402c1f(0);
    uVar16 = (uint)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    uVar5 = FUN_00402c1f(1);
    if (local_18 != (HWND)0x0) {
      if (uVar16 < uVar5) {
        return (HWND)local_20;
      }
      if (uVar16 <= uVar5) {
        return local_24;
      }
      return local_20._4_4_;
    }
    if ((int)uVar16 < (int)uVar5) {
      return (HWND)local_20;
    }
    if ((int)uVar16 <= (int)uVar5) {
      return local_24;
    }
    return local_20._4_4_;
  case 0x1d:
    uVar28 = FUN_00402c1f(1);
    pHVar4 = (HWND)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    param_1 = pHVar4;
    uVar28 = FUN_00402c1f(2);
    uVar16 = (uint)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    pHVar20 = param_1;
    if ((HWND)local_20 <= (HWND)&DAT_0000000d) {
      bVar21 = (byte)uVar28;
      switch((HWND)local_20) {
      case (HWND)0x0:
        pHVar20 = (HWND)((int)&pHVar4->unused + uVar16);
        break;
      case (HWND)0x1:
        pHVar20 = (HWND)((int)pHVar4 - uVar16);
        break;
      case (HWND)0x2:
        pHVar20 = (HWND)(uVar16 * (int)pHVar4);
        break;
      case (HWND)0x3:
        if (uVar16 == 0) {
LAB_00401b33:
          local_8 = (HWND)0x1;
          pHVar20 = (HWND)0x0;
        }
        else {
          pHVar20 = (HWND)((int)pHVar4 / (int)uVar16);
        }
        break;
      case (HWND)0x4:
        pHVar20 = (HWND)(uVar16 | (uint)pHVar4);
        break;
      case (HWND)0x5:
        pHVar20 = (HWND)(uVar16 & (uint)pHVar4);
        break;
      case (HWND)0x6:
        pHVar20 = (HWND)(uVar16 ^ (uint)pHVar4);
        break;
      case (HWND)0x7:
        pHVar20 = (HWND)(uint)(pHVar4 == (HWND)0x0);
        break;
      case (HWND)0x8:
        if (pHVar4 == (HWND)0x0) {
LAB_00401b1d:
          if (uVar16 == 0) goto LAB_00401b15;
        }
        pHVar20 = (HWND)0x1;
        break;
      case (HWND)0x9:
        if (pHVar4 != (HWND)0x0) goto LAB_00401b1d;
LAB_00401b15:
        pHVar20 = (HWND)0x0;
        break;
      case (HWND)0xa:
        if (uVar16 == 0) goto LAB_00401b33;
        pHVar20 = (HWND)((int)pHVar4 % (int)uVar16);
        break;
      case (HWND)0xb:
        pHVar20 = (HWND)((int)pHVar4 << (bVar21 & 0x1f));
        break;
      case (HWND)0xc:
        pHVar20 = (HWND)((int)pHVar4 >> (bVar21 & 0x1f));
        break;
      case (HWND)0xd:
        pHVar20 = (HWND)((uint)pHVar4 >> (bVar21 & 0x1f));
      }
    }
    goto LAB_00402a6b;
  case 0x1e:
    pWVar23 = FUN_00402c41(1);
    uVar28 = FUN_00402c1f(2);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    wsprintfW((LPWSTR)pHVar24,pWVar23,(int)uVar28);
    break;
  case 0x1f:
    if (local_24 == (HWND)0x0) {
      if (local_2c[1] != (HWND)0x0) {
        if (DAT_0041e630 != (HWND)0x0) {
          FUN_004062ba((LPWSTR)pHVar24,(LPCWSTR)(DAT_0041e630 + 1));
          DAT_0041e630 = (HWND)pHVar20->unused;
          goto LAB_00401be7;
        }
        goto LAB_0040288b;
      }
      pHVar20 = (HWND)GlobalAlloc(0x40,0x4004);
      FUN_004062dc((LPWSTR)(pHVar20 + 1),(int)local_2c[0]);
      pHVar20->unused = (int)DAT_0041e630;
      DAT_0041e630 = pHVar20;
    }
    else {
      do {
        local_24 = (HWND)((int)&local_24[-1].unused + 3);
        if (pHVar20 == (HWND)0x0) goto LAB_004022e4;
        pHVar20 = (HWND)pHVar20->unused;
      } while (local_24 != (HWND)0x0);
      if (pHVar20 == (HWND)0x0) goto LAB_004022e4;
      FUN_004062ba((LPWSTR)&DAT_0040a5d0,(LPCWSTR)(pHVar20 + 1));
      FUN_004062ba((LPWSTR)(pHVar20 + 1),(LPCWSTR)(DAT_0041e630 + 1));
      pWVar25 = (WCHAR *)&DAT_0040a5d0;
      pHVar24 = DAT_0041e630 + 1;
LAB_004029e1:
      FUN_004062ba((LPWSTR)pHVar24,pWVar25);
    }
    break;
  case 0x20:
  case 0x21:
    uVar28 = FUN_00402c1f(3);
    local_14 = (HWND)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    uVar28 = FUN_00402c1f(4);
    param_1 = (HWND)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    if (((uint)local_18 & 1) != 0) {
      local_14 = (HWND)FUN_00402c41(0x33);
    }
    if (((uint)local_18 & 2) != 0) {
      param_1 = (HWND)FUN_00402c41(0x44);
    }
    if (local_30 == 0x21) {
      uVar28 = FUN_00402c1f(1);
      local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
      local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
      uVar27 = FUN_00402c1f(2);
      local_50._0_2_ = (undefined2)((ulonglong)uVar27 >> 0x20);
      local_50._2_2_ = (undefined2)((ulonglong)uVar27 >> 0x30);
      if ((int)local_18 >> 2 == 0) {
        pHVar20 = (HWND)SendMessageW((HWND)uVar28,(UINT)uVar27,(WPARAM)local_14,(LPARAM)param_1);
        local_38._4_4_ = pHVar20;
        local_2c[1] = local_2c[0];
      }
      else {
        LVar6 = SendMessageTimeoutW((HWND)uVar28,(UINT)uVar27,(WPARAM)local_14,(LPARAM)param_1,0,
                                    (int)local_18 >> 2,(PDWORD_PTR)((int)&local_38 + 4));
        local_8 = (HWND)(uint)(LVar6 == 0);
        pHVar20 = local_38._4_4_;
        local_2c[1] = local_2c[0];
      }
    }
    else {
      pWVar23 = FUN_00402c41(1);
      pWVar11 = FUN_00402c41(0x12);
      pHVar20 = FindWindowExW(local_14,param_1,(LPCWSTR)(-(uint)(*pWVar23 != L'\0') & (uint)pWVar23)
                              ,(LPCWSTR)(-(uint)(*pWVar11 != L'\0') & (uint)pWVar11));
      local_38._4_4_ = pHVar20;
      local_2c[1] = local_2c[0];
    }
joined_r0x00402816:
    if (-1 < (int)local_2c[1]) goto LAB_00402a6b;
    break;
  case 0x22:
    uVar28 = FUN_00402c1f(0);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    puVar10 = (undefined *)IsWindow((HWND)uVar28);
    local_20._0_4_ = local_2c[1];
joined_r0x00401a1e:
    if (puVar10 == (undefined *)0x0) {
      return local_24;
    }
    return (HWND)local_20;
  case 0x23:
    uVar28 = FUN_00402c1f(2);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    uVar27 = FUN_00402c1f(1);
    local_50._0_2_ = (undefined2)((ulonglong)uVar27 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar27 >> 0x30);
    pHVar20 = GetDlgItem((HWND)uVar27,(int)uVar28);
    goto LAB_00402a6b;
  case 0x24:
    puVar10 = (undefined *)((int)&local_2c[1]->unused + DAT_0047af48);
    uVar28 = FUN_00402c1f(0);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    SetWindowLongW((HWND)uVar28,-0x15,(LONG)puVar10);
    break;
  case 0x25:
    pHVar20 = GetDlgItem(DAT_0047aee8,(int)local_2c[1]);
    GetClientRect(pHVar20,(LPRECT)&local_5c);
    fuLoad = 0x10;
    iVar22 = CONCAT22(local_50._2_2_,(undefined2)local_50) * (int)local_24;
    iVar17 = CONCAT22(uStack_52,local_54) * (int)local_24;
    type = 0;
    pWVar23 = FUN_00402c41(0);
    pvVar14 = LoadImageW((HINSTANCE)0x0,pWVar23,type,iVar17,iVar22,fuLoad);
    ho = (HGDIOBJ)SendMessageW(pHVar20,0x172,0,(LPARAM)pvVar14);
    if (ho != (HGDIOBJ)0x0) {
      DeleteObject(ho);
    }
    break;
  case 0x26:
    hdc = GetDC(DAT_0047aee8);
    uVar28 = FUN_00402c1f(2);
    iVar17 = 0x48;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    iVar22 = GetDeviceCaps(hdc,0x5a);
    _DAT_0041e5d0 = MulDiv((int)uVar28,iVar22,iVar17);
    _DAT_0041e5d0 = -_DAT_0041e5d0;
    ReleaseDC(local_c,hdc);
    uVar28 = FUN_00402c1f(3);
    _DAT_0041e5e0 = (undefined4)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    DAT_0041e5e4 = local_20._4_1_ & 1;
    DAT_0041e5e7 = 1;
    DAT_0041e5e5 = local_20._4_1_ & 2;
    DAT_0041e5e6 = local_20._4_1_ & 4;
    FUN_004062dc((LPWSTR)&DAT_0041e5ec,(int)local_2c[1]);
    pHVar20 = (HWND)CreateFontIndirectW((LOGFONTW *)&DAT_0041e5d0);
    goto LAB_00402a6b;
  case 0x27:
    uVar28 = FUN_00402c1f(0);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    uVar27 = FUN_00402c1f(1);
    local_50._0_2_ = (undefined2)((ulonglong)uVar27 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar27 >> 0x30);
    if ((HWND)local_20 == (HWND)0x0) {
      ShowWindow((HWND)uVar28,(int)uVar27);
    }
    else {
      EnableWindow((HWND)uVar28,(int)uVar27);
    }
    break;
  case 0x28:
    local_88._12_4_ = FUN_00402c41(0);
    local_88._16_4_ = FUN_00402c41(0x31);
    local_88._20_4_ = FUN_00402c41(0x22);
    FUN_00402c41(0x15);
    FUN_00401423(-0x14);
    local_88._4_4_ = local_20._4_4_;
    local_88._8_4_ = local_c;
    local_88._28_4_ = (HWND)local_20;
    local_88._12_4_ = (LPCWSTR)(-(uint)(*local_88._12_4_ != L'\0') & (uint)local_88._12_4_);
    local_88._24_4_ = (LPCWSTR)&DAT_004d3000;
    local_88._20_4_ = (LPCWSTR)(-(uint)(*local_88._20_4_ != L'\0') & (uint)local_88._20_4_);
    iVar22 = FUN_004058e6((SHELLEXECUTEINFOW *)local_88);
    if (iVar22 == 0) goto LAB_0040288b;
    if (((uint)local_88._4_4_ & 0x40) != 0) {
      FUN_00406745((HANDLE)CONCAT22(local_50._2_2_,(undefined2)local_50));
      pvVar14 = (HANDLE)CONCAT22(local_50._2_2_,(undefined2)local_50);
      goto LAB_00401f4d;
    }
    break;
  case 0x29:
    pWVar23 = FUN_00402c41(0);
    FUN_00405322(-0x15,pWVar23);
    pvVar14 = FUN_004058a3(pWVar23);
    if (pvVar14 == (HANDLE)0x0) goto LAB_0040288b;
    if (local_24 != (HWND)0x0) {
      DVar7 = FUN_00406745(pvVar14);
      if ((int)local_2c[1] < 0) {
        if (DVar7 != 0) {
          local_8 = (HWND)0x1;
        }
      }
      else {
        FUN_00406201((LPWSTR)local_10,DVar7);
      }
    }
LAB_00401f4d:
    CloseHandle(pvVar14);
    break;
  case 0x2a:
    pWVar23 = FUN_00402c41(2);
    puVar10 = FUN_004065fd(pWVar23);
    if (puVar10 != (undefined *)0x0) {
      FUN_00406201((LPWSTR)local_10,*(undefined4 *)(puVar10 + 0x14));
      pHVar20 = *(HWND *)(puVar10 + 0x18);
      goto LAB_00402a6b;
    }
    *(undefined2 *)&pHVar24->unused = 0;
    *(undefined2 *)&local_10->unused = 0;
    goto LAB_0040288b;
  case 0x2b:
    pHVar20 = (HWND)FUN_00402c41(0xffffffee);
    puVar29 = (undefined2 *)&local_50;
    local_38._4_4_ = pHVar20;
    pFVar8 = FUN_00406694(9);
    dwBytes = (*pFVar8)(pHVar20,puVar29);
    *(undefined2 *)&pHVar24->unused = 0;
    *(undefined2 *)&local_10->unused = 0;
    local_8 = (HWND)0x1;
    if ((dwBytes != 0) && (param_1 = (HWND)GlobalAlloc(0x40,dwBytes), param_1 != (HWND)0x0)) {
      local_3c = (LPCWSTR)FUN_00406694(10);
      local_14 = (HWND)FUN_00406694(0xb);
      iVar22 = (*(code *)local_3c)(local_38._4_4_,0,dwBytes,param_1);
      pHVar20 = param_1;
      if ((iVar22 != 0) &&
         (iVar22 = (*(code *)local_14)(param_1,&DAT_0040a014,&local_40,&local_4c), pHVar20 = param_1
         , iVar22 != 0)) {
        FUN_00406201((LPWSTR)pHVar24,*(undefined4 *)(local_40 + 4));
        FUN_00406201((LPWSTR)local_10,*(undefined4 *)(local_40 + 6));
        local_8 = (HWND)0x0;
        pHVar20 = param_1;
      }
LAB_00401be7:
      GlobalFree(pHVar20);
    }
    break;
  case 0x2c:
    local_8 = (HWND)0x1;
    if (_DAT_0047afb8 < 0) {
      iVar22 = -0x19;
    }
    else {
      pWVar23 = FUN_00402c41(0xfffffff0);
      local_40 = FUN_00402c41(1);
      if (((local_20._4_4_ != (HWND)0x0) &&
          (param_1 = (HWND)GetModuleHandleW(pWVar23), param_1 != (HWND)0x0)) ||
         (param_1 = (HWND)LoadLibraryExW(pWVar23,(HANDLE)0x0,8), param_1 != (HWND)0x0)) {
        pFVar8 = FUN_00406703((HMODULE)param_1,local_40);
        if (pFVar8 == (FARPROC)0x0) {
          FUN_00405322(-9,local_40);
        }
        else {
          local_8 = (HWND)0x0;
          if (local_24 == (HWND)0x0) {
            (*pFVar8)(local_c,0x2000,&DAT_0047b000,&DAT_0041e630,&PTR_DAT_0040a000);
          }
          else {
            FUN_00401423((int)local_24);
            iVar22 = (*pFVar8)();
            if (iVar22 != 0) {
              local_8 = (HWND)0x1;
            }
          }
        }
        if (((HWND)local_20 == (HWND)0x0) && (iVar22 = FUN_0040394a((int)param_1), iVar22 != 0)) {
          FreeLibrary((HMODULE)param_1);
        }
        break;
      }
      iVar22 = -10;
    }
    goto LAB_0040224b;
  case 0x2d:
    pWVar23 = FUN_00402c41(0xfffffff0);
    local_50._0_2_ = SUB42(pWVar23,0);
    local_50._2_2_ = (undefined2)((uint)pWVar23 >> 0x10);
    local_40 = FUN_00402c41(0xffffffdf);
    local_c = (HWND)FUN_00402c41(2);
    local_4c = FUN_00402c41(0xffffffcd);
    local_10 = (HWND)FUN_00402c41(0x45);
    local_48[0] = (uint)local_20._4_4_ & 0xfff;
    local_3c = (LPCWSTR)((int)local_20._4_4_ >> 0x10 & 0xffff);
    uVar16 = (int)local_20._4_4_ >> 0xc & 7;
    iVar22 = FUN_00405c06((ushort *)local_40);
    if (iVar22 == 0) {
      FUN_00402c41(0x21);
    }
    HVar9 = CoCreateInstance((IID *)&DAT_004085e8,(LPUNKNOWN)0x0,1,(IID *)&DAT_004085d8,&param_1);
    if (-1 < HVar9) {
      local_14 = (HWND)(**(code **)param_1->unused)(param_1,&DAT_004085f8,(int)&local_38 + 4);
      if (-1 < (int)local_14) {
        local_14 = (HWND)(**(code **)(param_1->unused + 0x50))(param_1,local_40);
        if (((uint)local_20._4_4_ & 0x8000) == 0) {
          (**(code **)(param_1->unused + 0x24))(param_1,&DAT_004d3000);
        }
        if (uVar16 != 0) {
          (**(code **)(param_1->unused + 0x3c))(param_1,uVar16);
        }
        (**(code **)(param_1->unused + 0x34))(param_1,local_3c);
        if (*local_4c != L'\0') {
          (**(code **)(param_1->unused + 0x44))(param_1,local_4c,local_48[0]);
        }
        (**(code **)(param_1->unused + 0x2c))(param_1,local_c);
        (**(code **)(param_1->unused + 0x1c))(param_1,local_10);
        if (-1 < (int)local_14) {
          local_14 = (HWND)(**(code **)((local_38._4_4_)->unused + 0x18))
                                     (local_38._4_4_,CONCAT22(local_50._2_2_,(undefined2)local_50),1
                                     );
        }
        (**(code **)((local_38._4_4_)->unused + 8))(local_38._4_4_);
      }
      (**(code **)(param_1->unused + 8))(param_1);
      if (-1 < (int)local_14) {
        iVar22 = -0xc;
        goto LAB_0040224b;
      }
    }
    local_8 = (HWND)0x1;
    iVar22 = -0x10;
    goto LAB_0040224b;
  case 0x2e:
    pWVar23 = FUN_00402c41(0);
    pWVar11 = FUN_00402c41(0x11);
    param_1 = (HWND)FUN_00402c41(0x23);
    puVar10 = FUN_004065fd(pWVar23);
    if (puVar10 != (undefined *)0x0) {
      local_88._28_4_ = local_c;
      local_68 = (HINSTANCE)0x2;
      iVar22 = lstrlenW(pWVar23);
      pWVar23[iVar22 + 1] = L'\0';
      iVar22 = lstrlenW(pWVar11);
      pWVar11[iVar22 + 1] = L'\0';
      uStack_52 = SUB42(param_1,0);
      local_50._0_2_ = (undefined2)((uint)param_1 >> 0x10);
      local_5c = local_24._0_2_;
      local_64 = pWVar23;
      local_60 = pWVar11;
      FUN_00405322(0,(LPCWSTR)param_1);
      iVar22 = SHFileOperationW((LPSHFILEOPSTRUCTW)(local_88 + 0x1c));
      if (iVar22 == 0) break;
    }
    FUN_00405322(-7,(LPCWSTR)0x0);
    goto LAB_0040288b;
  case 0x2f:
    if (local_2c[0] != (HWND)0xbadf00d) {
LAB_004022e4:
      uVar16 = 0x200010;
      puVar10 = (undefined *)FUN_004062dc((LPWSTR)0x0,-0x18);
LAB_004022f2:
      FUN_00405920(puVar10,uVar16);
      return (HWND)0x7fffffff;
    }
    _DAT_0047af94 = _DAT_0047af94 + 1;
    break;
  case 0x30:
    pWVar11 = (LPCWSTR)0x0;
    lpKeyName = (LPCWSTR)0x0;
    if (local_2c[0] != (HWND)0x0) {
      pWVar11 = FUN_00402c41(0);
    }
    if (local_2c[1] != (HWND)0x0) {
      lpKeyName = FUN_00402c41(0x11);
    }
    if (local_20._4_4_ != (HWND)0x0) {
      pWVar23 = FUN_00402c41(0x22);
    }
    lpFileName = FUN_00402c41(0xffffffcd);
    pWVar15 = (LPWSTR)WritePrivateProfileStringW(pWVar11,lpKeyName,pWVar23,lpFileName);
LAB_004015b4:
    bVar26 = pWVar15 == (LPWSTR)0x0;
LAB_004015b6:
    if (bVar26) goto LAB_0040288b;
    break;
  case 0x31:
    param_1 = DAT_0040a010;
    pWVar23 = FUN_00402c41(1);
    pWVar11 = FUN_00402c41(0x12);
    local_50._0_2_ = SUB42(pWVar11,0);
    local_50._2_2_ = (undefined2)((uint)pWVar11 >> 0x10);
    pWVar11 = FUN_00402c41(0xffffffdd);
    GetPrivateProfileStringW
              (pWVar23,(LPCWSTR)CONCAT22(local_50._2_2_,(undefined2)local_50),(LPCWSTR)&param_1,
               (LPWSTR)pHVar24,0x1fff,pWVar11);
    bVar26 = *(short *)&pHVar24->unused == 10;
LAB_00401751:
    if (bVar26) {
LAB_00402859:
      local_8 = (HWND)0x1;
      *(undefined2 *)&pHVar24->unused = 0;
    }
    break;
  case 0x32:
    if (local_20._4_4_ == (HWND)0x0) {
      pHVar12 = (HKEY)FUN_00402c81((HKEY)0x2);
      if (pHVar12 == (HKEY)0x0) goto LAB_0040288b;
      pWVar23 = FUN_00402c41(0x33);
      LVar13 = RegDeleteValueW(pHVar12,pWVar23);
      RegCloseKey(pHVar12);
    }
    else {
      pWVar23 = FUN_00402c41(0x22);
      LVar13 = FUN_00402cff((int)local_2c[1],pWVar23,(int)local_20._4_4_ >> 1);
    }
    if (LVar13 != 0) goto LAB_0040288b;
    break;
  case 0x33:
    local_50._0_2_ = SUB42(local_18,0);
    local_50._2_2_ = (undefined2)((uint)local_18 >> 0x10);
    local_40 = FUN_00402c41(2);
    pWVar23 = FUN_00402c41(0x11);
    local_8 = (HWND)0x1;
    param_1 = (HWND)FUN_00402cd1((int)local_2c[0],pWVar23,(HKEY)0x2);
    if (param_1 != (HWND)0x0) {
      pHVar20 = (HWND)0x0;
      if (local_20._4_4_ == (HWND)0x1) {
        FUN_00402c41(0x23);
        iVar22 = lstrlenW((LPCWSTR)&DAT_004125d0);
        pHVar20 = (HWND)(iVar22 * 2 + 2);
      }
      uVar28 = CONCAT44(local_38._4_4_,_DAT_004125d0);
      if (local_20._4_4_ == (HWND)0x4) {
        uVar28 = FUN_00402c1f(3);
        pHVar20 = local_20._4_4_;
      }
      if (local_20._4_4_ == (HWND)0x3) {
        pHVar20 = (HWND)FUN_00403116((int)(HWND)local_20,(HANDLE)0x0,&DAT_004125d0,0xc000);
        local_38._4_4_ = (HWND)((ulonglong)uVar28 >> 0x20);
        _DAT_004125d0 = (undefined4)uVar28;
      }
      LVar13 = RegSetValueExW((HKEY)param_1,local_40,0,CONCAT22(local_50._2_2_,(undefined2)local_50)
                              ,&DAT_004125d0,(DWORD)pHVar20);
      local_38._4_4_ = (HWND)((ulonglong)uVar28 >> 0x20);
      _DAT_004125d0 = (undefined4)uVar28;
      pHVar12 = (HKEY)param_1;
      if (LVar13 == 0) {
        local_8 = (HWND)0x0;
      }
LAB_00402557:
      RegCloseKey(pHVar12);
      local_38._4_4_ = (HWND)((ulonglong)uVar28 >> 0x20);
      _DAT_004125d0 = (undefined4)uVar28;
    }
    break;
  case 0x34:
    pHVar12 = (HKEY)FUN_00402c81((HKEY)0x20019);
    pWVar23 = FUN_00402c41(0x33);
    *(undefined2 *)&pHVar24->unused = 0;
    if (pHVar12 != (HKEY)0x0) {
      local_50._0_2_ = 0x4000;
      local_50._2_2_ = 0;
      LVar13 = RegQueryValueExW(pHVar12,pWVar23,(LPDWORD)0x0,(LPDWORD)&param_1,(LPBYTE)pHVar24,
                                &local_50);
      if (LVar13 == 0) {
        if (param_1 == (HWND)0x4) {
          local_8 = (HWND)(uint)(local_20._4_4_ == (HWND)0x0);
          FUN_00406201((LPWSTR)pHVar24,pHVar24->unused);
          uVar28 = CONCAT44(local_38._4_4_,_DAT_004125d0);
          goto LAB_00402557;
        }
        if ((param_1 == (HWND)0x1) || (param_1 == (HWND)0x2)) {
          local_8 = local_20._4_4_;
          goto LAB_0040254f;
        }
      }
      *(undefined2 *)&pHVar24->unused = 0;
      uVar28 = CONCAT44(local_38._4_4_,_DAT_004125d0);
      local_8 = (HWND)0x1;
      goto LAB_00402557;
    }
    goto LAB_0040288b;
  case 0x35:
    pHVar12 = (HKEY)FUN_00402c81((HKEY)0x20019);
    uVar28 = FUN_00402c1f(3);
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    *(undefined2 *)&pHVar24->unused = 0;
    if (pHVar12 != (HKEY)0x0) {
      param_1 = (HWND)0x1fff;
      if (local_20._4_4_ == (HWND)0x0) {
        LVar13 = RegEnumValueW(pHVar12,(DWORD)uVar28,(LPWSTR)pHVar24,(LPDWORD)&param_1,(LPDWORD)0x0,
                               (LPDWORD)0x0,(LPBYTE)0x0,(LPDWORD)0x0);
        if (LVar13 != 0) {
          local_8 = (HWND)0x1;
        }
      }
      else {
        RegEnumKeyW(pHVar12,(DWORD)uVar28,(LPWSTR)pHVar24,0x1fff);
      }
LAB_0040254f:
      *(undefined2 *)(&DAT_0047effe + iVar22) = 0;
      uVar28 = CONCAT44(local_38._4_4_,_DAT_004125d0);
      goto LAB_00402557;
    }
    goto LAB_0040288b;
  case 0x36:
    pvVar14 = (HANDLE)FUN_0040621a((ushort *)pHVar24);
    if (pvVar14 != (HANDLE)0x0) goto LAB_00401f4d;
    break;
  case 0x37:
    pWVar23 = FUN_00402c41(0xffffffed);
    pHVar20 = (HWND)FUN_00405db0(pWVar23,(DWORD)local_2c[1],(DWORD)local_24);
    if (pHVar20 == (HWND)0xffffffff) goto LAB_00402888;
LAB_00402a6b:
    FUN_00406201((LPWSTR)pHVar24,pHVar20);
    break;
  case 0x38:
  case 0x44:
    local_50._0_2_ = SUB42(local_24,0);
    local_50._2_2_ = (undefined2)((uint)local_24 >> 0x10);
    if (local_24 == (HWND)0x0) {
      if (local_30 == 0x38) {
        FUN_00402c41(0x21);
        WideCharToMultiByte(0,0,(LPCWSTR)&DAT_004125d0,-1,&DAT_0040e5d0,0x2000,(LPCSTR)0x0,
                            (LPBOOL)0x0);
        param_1 = (HWND)lstrlenA(&DAT_0040e5d0);
      }
      else {
        pWVar23 = FUN_00402c41(0x11);
        iVar22 = lstrlenW(pWVar23);
        param_1 = (HWND)(iVar22 * 2);
      }
    }
    else {
      _DAT_0040e5d0 = FUN_00402c1f(1);
      param_1 = (HWND)(((local_30 == 0x38) == 0) + 1);
      local_40 = extraout_EDX;
    }
    if ((*(short *)&pHVar24->unused != 0) &&
       (((pvVar14 = (HANDLE)FUN_0040621a((ushort *)pHVar24),
         ((uint)(local_30 == 0x38) | CONCAT22(local_50._2_2_,(undefined2)local_50)) != 0 ||
         ((HWND)local_20 == (HWND)0x0)) ||
        (iVar22 = FUN_00405e91(pvVar14,(int)pvVar14), -1 < iVar22)))) {
      pWVar15 = (LPWSTR)FUN_00405e62(pvVar14,&DAT_0040e5d0,(DWORD)param_1);
      goto LAB_004015b4;
    }
    goto LAB_0040288b;
  case 0x39:
  case 0x45:
    local_c = (HWND)0x0;
    local_4c = (LPCWSTR)0x2;
    uVar28 = FUN_00402c1f(2);
    local_40 = (LPCWSTR)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    if ((int)local_40 < 1) break;
    if (0x1fff < (int)local_40) {
      local_40 = (LPCWSTR)0x1fff;
    }
    if (*(short *)&pHVar24->unused != 0) {
      local_38._4_4_ = (HWND)0x0;
      local_14 = (HWND)FUN_0040621a((ushort *)pHVar24);
      if (0 < (int)local_40) {
        do {
          if (local_30 == 0x39) {
            uVar16 = ReadFile(local_14,(LPVOID)((int)&param_1 + 2),2 - (int)(HWND)local_20,
                              (LPDWORD)&local_3c,(LPOVERLAPPED)0x0);
            if ((uVar16 != 0) && (local_3c != (LPCWSTR)0x0)) {
              local_48[0] = uVar16 & 0xffff0000 | (uint)param_1 >> 0x10 & 0xff;
              local_4c = local_3c;
              if ((HWND)local_20 == (HWND)0x0) {
                iVar22 = MultiByteToWideChar(0,8,(LPCSTR)((int)&param_1 + 2),(int)local_3c,
                                             (LPWSTR)local_48,1);
                if (iVar22 == 0) {
                  iVar22 = -(int)local_4c;
                  do {
                    local_3c = (LPCWSTR)((int)local_3c + -1);
                    local_48[0] = 0xfffd;
                    if (local_3c == (LPCWSTR)0x0) break;
                    local_4c = (LPCWSTR)((int)local_4c + -1);
                    iVar22 = iVar22 + 1;
                    SetFilePointer(local_14,iVar22,(PLONG)0x0,1);
                    iVar17 = MultiByteToWideChar(0,8,(LPCSTR)((int)&param_1 + 2),(int)local_3c,
                                                 (LPWSTR)local_48,1);
                  } while (iVar17 == 0);
                }
                goto LAB_00402762;
              }
LAB_00402798:
              FUN_00406201((LPWSTR)local_10,local_48[0] & 0xffff);
              goto LAB_00402ace;
            }
            break;
          }
          if (((((HWND)local_20 == (HWND)0x0) && (local_c == (HWND)0x0)) &&
              (iVar22 = FUN_00405e91(local_14,0), iVar22 < 0)) ||
             (iVar22 = FUN_00405e33(local_14,local_48,2), iVar22 == 0)) break;
LAB_00402762:
          if ((HWND)local_20 != (HWND)0x0) goto LAB_00402798;
          sVar1 = (short)local_48[0];
          if ((local_38._4_2_ == 0xd) || (local_38._4_2_ == 10)) {
            if ((local_38._4_2_ == sVar1) || ((sVar1 != 0xd && (sVar1 != 10)))) {
              SetFilePointer(local_14,-(int)local_4c,(PLONG)0x0,1);
            }
            else {
              *(short *)((int)&local_10->unused + (int)local_c * 2) = sVar1;
              local_c = (HWND)((int)local_c + 1);
            }
            break;
          }
          iVar22 = (int)local_c + 1;
          *(short *)((int)&local_10->unused + (int)local_c * 2) = sVar1;
          local_c = (HWND)iVar22;
          if ((sVar1 == 0) || (local_38._4_4_ = (HWND)local_48[0], (int)local_40 <= iVar22)) break;
        } while( true );
      }
    }
    bVar26 = local_c == (HWND)0x0;
    *(undefined2 *)((int)&local_10->unused + (int)local_c * 2) = 0;
    goto LAB_004015b6;
  case 0x3a:
    if (*(short *)&pHVar24->unused != 0) {
      uVar28 = FUN_00402c1f(2);
      lDistanceToMove = (LONG)uVar28;
      local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
      local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
      lpDistanceToMoveHigh = (PLONG)0x0;
      pvVar14 = (HANDLE)FUN_0040621a((ushort *)pHVar24);
      pHVar20 = (HWND)SetFilePointer(pvVar14,lDistanceToMove,lpDistanceToMoveHigh,
                                     (DWORD)(HWND)local_20);
      pHVar24 = local_10;
      goto joined_r0x00402816;
    }
    break;
  case 0x3b:
    pvVar14 = (HANDLE)FUN_0040621a((ushort *)pHVar24);
    if (pvVar14 != (HANDLE)0x0) {
      FindClose(pvVar14);
    }
    break;
  case 0x3c:
    pvVar14 = (HANDLE)FUN_0040621a((ushort *)local_10);
    if ((pvVar14 != (HANDLE)0x0) && (BVar18 = FindNextFileW(pvVar14,&local_2d8), BVar18 != 0)) {
LAB_004028a0:
      pWVar25 = local_2d8.cFileName;
      goto LAB_004029e1;
    }
    goto LAB_00402859;
  case 0x3d:
    pWVar23 = FUN_00402c41(2);
    pvVar14 = FindFirstFileW(pWVar23,&local_2d8);
    if (pvVar14 != (HANDLE)0xffffffff) {
      FUN_00406201((LPWSTR)local_10,pvVar14);
      goto LAB_004028a0;
    }
    *(undefined2 *)&local_10->unused = 0;
LAB_00402888:
    *(undefined2 *)&pHVar24->unused = 0;
LAB_0040288b:
    local_8 = (HWND)0x1;
    break;
  case 0x3e:
    local_38._4_4_ = (HWND)0xfffffd66;
    pWVar23 = FUN_00402c41(0xfffffff0);
    local_3c = pWVar23;
    iVar22 = FUN_00405c06((ushort *)pWVar23);
    if (iVar22 == 0) {
      FUN_00402c41(0xffffffed);
    }
    FUN_00405d8b(pWVar23);
    param_1 = (HWND)FUN_00405db0(pWVar23,0x40000000,2);
    if (param_1 != (HWND)0xffffffff) {
      local_40 = DAT_0047aef8;
      hMem = GlobalAlloc(0x40,(SIZE_T)DAT_0047aef8);
      if (hMem != (HGLOBAL)0x0) {
        FUN_00403347(0);
        FUN_00403331(hMem,(DWORD)local_40);
        piVar19 = (int *)GlobalAlloc(0x40,(SIZE_T)local_24);
        local_50._0_2_ = SUB42(piVar19,0);
        local_50._2_2_ = (undefined2)((uint)piVar19 >> 0x10);
        if (piVar19 != (int *)0x0) {
          FUN_00403116((int)local_2c[1],(HANDLE)0x0,(undefined *)piVar19,(uint)local_24);
          for (; *(char *)piVar19 != '\0'; piVar19 = (int *)((int)(piVar19 + 2) + (int)local_38)) {
            local_38._0_4_ = *piVar19;
            FUN_00405d6b((undefined *)(piVar19[1] + (int)hMem),(int)(piVar19 + 2),(int)local_38);
          }
          GlobalFree((HGLOBAL)CONCAT22(local_50._2_2_,(undefined2)local_50));
        }
        FUN_00405e62(param_1,hMem,(DWORD)local_40);
        GlobalFree(hMem);
        local_38._4_4_ = (HWND)FUN_00403116(-1,param_1,(undefined *)0x0,0);
      }
      CloseHandle(param_1);
    }
    iVar22 = -0xd;
    if ((int)local_38._4_4_ < 0) {
      iVar22 = -0x11;
      DeleteFileW(local_3c);
      local_8 = (HWND)0x1;
    }
LAB_0040224b:
    FUN_00401423(iVar22);
    break;
  case 0x3f:
    uVar28 = FUN_00402c1f(0);
    uVar16 = (uint)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    if (DAT_0047af2c <= uVar16) goto LAB_0040288b;
    iVar22 = uVar16 * 0x4018 + DAT_0047af28;
    if (-1 < (int)local_24) {
      pHVar24 = local_10;
      pHVar20 = *(HWND *)(iVar22 + (int)local_24 * 4);
      if (local_24 == (HWND)0x0) {
        pWVar25 = (WCHAR *)(iVar22 + 0x18);
        goto LAB_004029e1;
      }
      goto LAB_00402a6b;
    }
    local_24 = (HWND)(-1 - (int)local_24);
    if (local_24 == (HWND)0x0) {
      FUN_004062dc((LPWSTR)(iVar22 + 0x18),(int)local_20._4_4_);
      *(byte *)(iVar22 + 9) = *(byte *)(iVar22 + 9) | 1;
    }
    else {
      uVar28 = FUN_00402c1f(1);
      local_2c[1] = (HWND)uVar28;
      local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
      local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    }
    *(HWND *)(iVar22 + (int)local_24 * 4) = local_2c[1];
    if ((HWND)local_20 != (HWND)0x0) {
      FUN_0040117d(uVar16);
    }
    break;
  case 0x40:
    uVar28 = FUN_00402c1f(0);
    uVar16 = (uint)uVar28;
    local_50._0_2_ = (undefined2)((ulonglong)uVar28 >> 0x20);
    local_50._2_2_ = (undefined2)((ulonglong)uVar28 >> 0x30);
    if (0x1f < uVar16) goto LAB_0040288b;
    if ((HWND)local_20 == (HWND)0x0) {
      if (local_24 == (HWND)0x0) {
        FUN_004062dc((LPWSTR)local_10,*(int *)(DAT_0047aef4 + 0x94 + uVar16 * 4));
      }
      else {
        *(HWND *)(DAT_0047aef4 + 0x94 + uVar16 * 4) = local_2c[1];
      }
    }
    else {
      if (local_24 == (HWND)0x0) {
        pHVar20 = (HWND)FUN_004012e2(0);
        pHVar24 = local_10;
        goto LAB_00402a6b;
      }
      FUN_00401299(uVar16);
      FUN_004011ef(0,0);
    }
    break;
  case 0x43:
    SendMessageW(DAT_0047aee8,0xb,DAT_00460248 & (uint)local_2c[0],0);
    if (local_2c[0] != (HWND)0x0) {
      InvalidateRect(local_c,(RECT *)0x0,0);
    }
  }
switchD_0040148a_caseD_41:
  _DAT_0047af88 = (int)&local_8->unused + _DAT_0047af88;
LAB_00402ace:
  local_2c[0] = (HWND)0x0;
switchD_0040148a_caseD_2:
  return local_2c[0];
}

/* Function: FUN_00402c1f */
void __cdecl FUN_00402c1f(int param_1)

{
  ushort *puVar1;
  
  puVar1 = (ushort *)FUN_004062dc((LPWSTR)0x0,*(int *)(DAT_0041e62c + param_1 * 4));
  FUN_0040621a(puVar1);
  return;
}

/* Function: FUN_00402c41 */
LPCWSTR FUN_00402c41(uint param_1)

{
  uint uVar1;
  LPCWSTR pWVar2;
  
  uVar1 = param_1;
  if ((int)param_1 < 0) {
    uVar1 = -param_1;
  }
  pWVar2 = (LPCWSTR)FUN_004062dc((LPWSTR)(&DAT_0040a5d0 + ((int)uVar1 >> 4) * 0x4000),
                                 *(int *)(DAT_0041e62c + (uVar1 & 0xf) * 4));
  if ((int)param_1 < 0) {
    FUN_0040654e(pWVar2);
  }
  return pWVar2;
}

/* Function: FUN_00402c81 */
uint FUN_00402c81(HKEY param_1)

{
  uint uVar1;
  LPCWSTR pWVar2;
  uint uVar3;
  LSTATUS LVar4;
  HKEY *ppHVar5;
  
  ppHVar5 = &param_1;
  uVar1 = (uint)param_1 | 0x100020;
  pWVar2 = FUN_00402c41(0x22);
  uVar3 = FUN_00402cb9(*(int *)(DAT_0041e62c + 4));
  LVar4 = FUN_00406127(uVar3,pWVar2,uVar1,ppHVar5);
  return ~-(uint)(LVar4 != 0) & (uint)param_1;
}

/* Function: FUN_00402cb9 */
int FUN_00402cb9(int param_1)

{
  if (-1 < param_1) {
    param_1 = DAT_0047af84 + -0x7fffffff + param_1;
  }
  return param_1;
}

/* Function: FUN_00402cd1 */
uint FUN_00402cd1(int param_1,LPCWSTR param_2,HKEY param_3)

{
  uint uVar1;
  uint uVar2;
  LSTATUS LVar3;
  HKEY *ppHVar4;
  
  ppHVar4 = &param_3;
  uVar1 = (uint)param_3 | 0x100020;
  uVar2 = FUN_00402cb9(param_1);
  LVar3 = FUN_00406155(uVar2,param_2,uVar1,ppHVar4);
  return ~-(uint)(LVar3 != 0) & (uint)param_3;
}

/* Function: FUN_00402cff */
LSTATUS FUN_00402cff(int param_1,LPCWSTR param_2,uint param_3)

{
  LSTATUS LVar1;
  uint uVar2;
  HKEY pHVar3;
  uint *puVar4;
  
  if (*param_2 == L'\0') {
    LVar1 = 0x3eb;
  }
  else {
    param_3 = param_3 | 0x100020;
    puVar4 = &param_3;
    uVar2 = FUN_00402cb9(param_1);
    pHVar3 = (HKEY)FUN_004060ac(uVar2,puVar4);
    if (pHVar3 == (HKEY)0x0) {
      LVar1 = 6;
    }
    else {
      LVar1 = FUN_00402d44(pHVar3,param_2,param_3);
    }
  }
  return LVar1;
}

/* Function: FUN_00402d44 */
LSTATUS FUN_00402d44(HKEY param_1,LPCWSTR param_2,uint param_3)

{
  LSTATUS LVar1;
  FARPROC pFVar2;
  WCHAR local_214 [262];
  HKEY local_8;
  
  LVar1 = FUN_00406127((uint)param_1,param_2,CONCAT31((int3)((param_3 & 0x300) >> 8),8),&local_8);
  if (LVar1 == 0) {
    do {
      LVar1 = RegEnumKeyW(local_8,0,local_214,0x105);
      if (LVar1 != 0) break;
      if ((param_3 & 1) != 0) {
        RegCloseKey(local_8);
        return 0x3eb;
      }
      LVar1 = FUN_00402d44(local_8,local_214,param_3);
    } while (LVar1 == 0);
    RegCloseKey(local_8);
    pFVar2 = FUN_00406694(3);
    if (pFVar2 == (FARPROC)0x0) {
      LVar1 = RegDeleteKeyW(param_1,param_2);
    }
    else {
      LVar1 = (*pFVar2)(param_1,param_2,param_3 & 0x300,0);
    }
  }
  return LVar1;
}

/* Function: FUN_00402df3 */
undefined4 FUN_00402df3(HWND param_1,int param_2)

{
  int iVar1;
  WCHAR local_84 [64];
  
  if (param_2 == 0x110) {
    SetTimer(param_1,1,0xfa,(TIMERPROC)0x0);
    param_2 = 0x113;
  }
  if (param_2 == 0x113) {
    iVar1 = DAT_004281f8;
    if (DAT_00434204 <= DAT_004281f8) {
      iVar1 = DAT_00434204;
    }
    iVar1 = MulDiv(iVar1,100,DAT_00434204);
    wsprintfW(local_84,u_verifying_installer___d___0040a01c,iVar1);
    SetWindowTextW(param_1,local_84);
    SetDlgItemTextW(param_1,0x406,local_84);
  }
  return 0;
}

/* Function: FUN_00402e79 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void __cdecl FUN_00402e79(int param_1)

{
  DWORD DVar1;
  
  if (param_1 != 0) {
    if (DAT_00434200 != (HWND)0x0) {
      DestroyWindow(DAT_00434200);
    }
    DAT_00434200 = (HWND)0x0;
    return;
  }
  if (DAT_00434200 != (HWND)0x0) {
    FUN_004066d0(0);
    return;
  }
  DVar1 = GetTickCount();
  if (_DAT_0047aef0 < DVar1) {
    DAT_00434200 = CreateDialogParamW(DAT_0047aee0,(LPCWSTR)0x6f,(HWND)0x0,FUN_00402df3,0);
    ShowWindow(DAT_00434200,5);
  }
  return;
}

/* Function: FUN_00402edd */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

wchar_t * FUN_00402edd(uint param_1)

{
  DWORD DVar1;
  HANDLE hFile;
  LPCWSTR pWVar2;
  uint uVar3;
  uint uVar4;
  int iVar5;
  undefined4 *puVar6;
  int *piVar7;
  uint uVar8;
  uint local_2c;
  int local_28;
  int local_24;
  int local_20;
  int local_1c;
  SIZE_T local_18;
  int local_14;
  HANDLE local_10;
  uint local_c;
  int local_8;
  
  local_c = 0;
  local_8 = 0;
  DVar1 = GetTickCount();
  _DAT_0047aef0 = DVar1 + 1000;
  GetModuleFileNameW((HMODULE)0x0,(LPWSTR)&DAT_004e7000,0x2000);
  hFile = (HANDLE)FUN_00405db0((LPCWSTR)&DAT_004e7000,0x80000000,3);
  if (hFile == (HANDLE)0xffffffff) {
    DAT_0040a018 = hFile;
    return u_Error_launching_installer_0040a1e8;
  }
  DAT_0040a018 = hFile;
  local_10 = hFile;
  FUN_004062ba((LPWSTR)&DAT_004d7000,(LPCWSTR)&DAT_004e7000);
  pWVar2 = FUN_00405bdb((LPCWSTR)&DAT_004d7000);
  FUN_004062ba((LPWSTR)&DAT_004eb000,pWVar2);
  uVar3 = GetFileSize(hFile,(LPDWORD)0x0);
  DAT_00434204 = uVar3;
  for (; 0 < (int)uVar3; uVar3 = uVar3 - uVar8) {
    uVar4 = (-(uint)(DAT_0047aef8 != 0) & 0x7e00) + 0x200;
    uVar8 = uVar3;
    if ((int)uVar4 <= (int)uVar3) {
      uVar8 = uVar4;
    }
    iVar5 = FUN_00403331(&DAT_00434208,uVar8);
    if (iVar5 == 0) {
      FUN_00402e79(1);
      goto LAB_004030b5;
    }
    if (DAT_0047aef8 == 0) {
      FUN_00405d6b((undefined *)&local_2c,(int)&DAT_00434208,0x1c);
      if (((((local_2c & 0xfffffff0) == 0) && (local_28 == -0x21524111)) && (local_1c == 0x74736e49)
          ) && ((local_20 == 0x74666f73 && (local_24 == 0x6c6c754e)))) {
        param_1 = param_1 | local_2c;
        _DAT_0047afa0 = _DAT_0047afa0 | param_1 & 2;
        DAT_0047aef8 = DAT_004281f8;
        if ((int)uVar3 < local_14) goto LAB_004030b5;
        if (((param_1 & 8) == 0) && ((param_1 & 4) != 0)) break;
        local_8 = local_8 + 1;
        uVar3 = local_14 - 4;
        if (uVar3 < uVar8) {
          uVar8 = uVar3;
        }
      }
    }
    else if ((param_1 & 2) == 0) {
      FUN_00402e79(0);
    }
    if ((int)uVar3 < (int)DAT_00434204) {
      local_c = FUN_00406787(local_c,&DAT_00434208,uVar8);
    }
    DAT_004281f8 = DAT_004281f8 + uVar8;
  }
  FUN_00402e79(1);
  if (DAT_0047aef8 != 0) {
    if (local_8 != 0) {
      FUN_00403347(DAT_004281f8);
      iVar5 = FUN_00403331(&param_1,4);
      if ((iVar5 == 0) || (local_c != param_1)) goto LAB_004030b5;
    }
    puVar6 = (undefined4 *)GlobalAlloc(0x40,local_18);
    FUN_00403347(DAT_0047aef8 + 0x1c);
    DVar1 = FUN_00403116(-1,(HANDLE)0x0,(undefined *)puVar6,local_18);
    if (DVar1 == local_18) {
      DAT_0047aefc = *puVar6;
      if ((local_2c & 1) != 0) {
        _DAT_0047af00 = _DAT_0047af00 + 1;
      }
      piVar7 = puVar6 + 0x11;
      iVar5 = 8;
      DAT_0047aef4 = puVar6;
      do {
        piVar7 = piVar7 + -2;
        *piVar7 = *piVar7 + (int)puVar6;
        iVar5 = iVar5 + -1;
      } while (iVar5 != 0);
      DVar1 = SetFilePointer(local_10,0,(PLONG)0x0,1);
      puVar6[0xf] = DVar1;
      FUN_00405d6b(&DAT_0047af20,(int)(puVar6 + 1),0x40);
      return (wchar_t *)0x0;
    }
  }
LAB_004030b5:
  return u_Installer_integrity_check_has_fa_0040a050;
}

/* Function: FUN_00403116 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

DWORD FUN_00403116(int param_1,HANDLE param_2,undefined *param_3,uint param_4)

{
  undefined *puVar1;
  int iVar2;
  DWORD DVar3;
  DWORD DVar4;
  uint uVar5;
  WCHAR local_98 [64];
  int local_18;
  DWORD local_14;
  undefined *local_10;
  DWORD local_c;
  DWORD local_8;
  
  uVar5 = param_4;
  local_c = param_4;
  if (param_3 == (undefined *)0x0) {
    local_c = 0x8000;
  }
  local_8 = 0;
  local_10 = param_3;
  if (param_3 == (undefined *)0x0) {
    local_10 = &DAT_0042c200;
  }
  if (-1 < param_1) {
    FUN_00403347(DAT_0047af58 + param_1);
  }
  iVar2 = FUN_00403331(&param_4,4);
  DVar3 = local_c;
  if (iVar2 != 0) {
    if ((param_4 & 0x80000000) == 0) {
      if (param_3 == (undefined *)0x0) {
        while( true ) {
          if ((int)param_4 < 1) {
            return local_8;
          }
          DVar4 = param_4;
          if ((int)DVar3 <= (int)param_4) {
            DVar4 = DVar3;
          }
          iVar2 = FUN_00403331(&DAT_00428200,DVar4);
          if (iVar2 == 0) break;
          iVar2 = FUN_00405e62(param_2,&DAT_00428200,DVar4);
          if (iVar2 == 0) {
            return 0xfffffffe;
          }
          local_8 = local_8 + DVar4;
          param_4 = param_4 - DVar4;
        }
      }
      else {
        if ((int)param_4 < (int)uVar5) {
          uVar5 = param_4;
        }
        iVar2 = FUN_00403331(param_3,uVar5);
        if (iVar2 != 0) {
          return uVar5;
        }
      }
    }
    else {
      local_14 = GetTickCount();
      _DAT_0041eb64 = 0;
      _DAT_0041eb60 = 0;
      uVar5 = param_4 & 0x7fffffff;
      _DAT_0041e648 = 8;
      _DAT_004281f0 = &DAT_004201e8;
      _DAT_004281ec = &DAT_004201e8;
      _DAT_004281e8 = &DAT_004281e8;
      param_4 = uVar5;
      if (uVar5 == 0) {
        _DAT_0041e648 = 8;
        _DAT_0041eb60 = 0;
        _DAT_0041eb64 = 0;
        return local_8;
      }
      while( true ) {
        DVar3 = 0x4000;
        if ((int)param_4 < 0x4000) {
          DVar3 = param_4;
        }
        iVar2 = FUN_00403331(&DAT_00428200,DVar3);
        if (iVar2 == 0) break;
        param_4 = param_4 - DVar3;
        _DAT_0041e638 = &DAT_00428200;
        _DAT_0041e63c = DVar3;
        while( true ) {
          puVar1 = local_10;
          DAT_0041e640 = local_10;
          _DAT_0041e644 = local_c;
          local_18 = FUN_004067f5((byte **)&DAT_0041e638);
          if (local_18 < 0) {
            return 0xfffffffc;
          }
          DVar4 = (int)DAT_0041e640 - (int)puVar1;
          DVar3 = GetTickCount();
          if ((((byte)DAT_0047afb4 & 1) != 0) && ((200 < DVar3 - local_14 || (param_4 == 0)))) {
            iVar2 = MulDiv(uVar5 - param_4,100,uVar5);
            wsprintfW(local_98,u______d___0040a21c,iVar2);
            FUN_00405322(0,local_98);
            local_14 = DVar3;
          }
          if (DVar4 == 0) break;
          if (param_3 == (undefined *)0x0) {
            iVar2 = FUN_00405e62(param_2,local_10,DVar4);
            if (iVar2 == 0) {
              return 0xfffffffe;
            }
          }
          else {
            local_c = local_c - DVar4;
            local_10 = DAT_0041e640;
          }
          local_8 = local_8 + DVar4;
          if (local_18 == 1) {
            return local_8;
          }
        }
        if ((int)param_4 < 1) {
          return local_8;
        }
      }
    }
  }
  return 0xfffffffd;
}

/* Function: FUN_00403331 */
void FUN_00403331(LPVOID param_1,DWORD param_2)

{
  FUN_00405e33(DAT_0040a018,param_1,param_2);
  return;
}

/* Function: FUN_00403347 */
void FUN_00403347(LONG param_1)

{
  SetFilePointer(DAT_0040a018,param_1,(PLONG)0x0,0);
  return;
}

/* Function: FUN_0040335e */
void FUN_0040335e(void)

{
  int iVar1;
  
  FUN_0040654e((LPCWSTR)&DAT_004df000);
  iVar1 = FUN_00405c06((ushort *)&DAT_004df000);
  if (iVar1 == 0) {
    return;
  }
  FUN_00405b8f((LPCWSTR)&DAT_004df000);
  FUN_0040586e((LPCWSTR)&DAT_004df000);
  FUN_00405ddf((LPWSTR)&DAT_004db000,(LPCWSTR)&DAT_004df000);
  return;
}

/* Function: entry */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void entry(void)

{
  short sVar1;
  bool bVar2;
  DWORD DVar3;
  FARPROC pFVar4;
  int iVar5;
  LPWSTR pWVar6;
  LPCWSTR pWVar7;
  uint *puVar8;
  int *piVar9;
  undefined3 extraout_var;
  int iVar10;
  HANDLE pvVar11;
  BOOL BVar12;
  uint *puVar13;
  char *lpString;
  WCHAR WVar14;
  uint **TokenHandle;
  wchar_t *local_2d4;
  UINT local_2d0;
  uint *puStack_2cc;
  uint local_2c8;
  _TOKEN_PRIVILEGES _Stack_2c4;
  SHFILEINFOW SStack_2b4;
  
  WVar14 = L' ';
  local_2d0 = 0;
  local_2d4 = u_Error_writing_temporary_file__Ma_0040a2e0;
  local_2c8 = 0;
  SetErrorMode(0x8001);
  DVar3 = GetVersion();
  DAT_0047aeec = DVar3 & 0xbfffffff;
  if (((short)DAT_0047aeec != 6) && (pFVar4 = FUN_00406694(0), pFVar4 != (FARPROC)0x0)) {
    (*pFVar4)(0xc00);
  }
  lpString = "UXTHEME";
  do {
    FUN_00406624(lpString);
    iVar5 = lstrlenA(lpString);
    lpString = lpString + iVar5 + 1;
  } while (*lpString != '\0');
  FUN_00406694(10);
  DAT_0047aee4 = FUN_00406694(8);
  pFVar4 = FUN_00406694(6);
  if ((pFVar4 != (FARPROC)0x0) && (iVar5 = (*pFVar4)(0x1e), iVar5 != 0)) {
    DAT_0047aeec = DAT_0047aeec | 0x40000000;
  }
  Ordinal_17();
  _DAT_0047afb8 = OleInitialize((LPVOID)0x0);
  SHGetFileInfoW((LPCWSTR)&DAT_00440208,0,&SStack_2b4,0x2b4,0);
  FUN_004062ba((LPWSTR)&DAT_00472ee0,(LPCWSTR)&PTR_DAT_0040a2c8);
  pWVar6 = GetCommandLineW();
  FUN_004062ba((LPWSTR)&DAT_004cb000,pWVar6);
  DAT_0047aee0 = 0x400000;
  pWVar7 = (LPCWSTR)&DAT_004cb000;
  if (_DAT_004cb000 == 0x22) {
    pWVar7 = (LPCWSTR)&DAT_004cb002;
    WVar14 = L'\"';
  }
  pWVar7 = (LPCWSTR)FUN_00405bbc(pWVar7,WVar14);
  puVar8 = (uint *)CharNextW(pWVar7);
  sVar1 = *(short *)puVar8;
  puStack_2cc = puVar8;
  while (sVar1 != 0) {
    WVar14 = L' ';
    while (sVar1 == 0x20) {
      puVar8 = (uint *)((int)puVar8 + 2);
      sVar1 = *(short *)puVar8;
    }
    if (*(short *)puVar8 == 0x22) {
      puVar8 = (uint *)((int)puVar8 + 2);
      WVar14 = L'\"';
    }
    puVar13 = puVar8;
    if (*(short *)puVar8 == 0x2f) {
      puVar13 = (uint *)((int)puVar8 + 2);
      if ((*(short *)puVar13 == 0x53) &&
         ((*(short *)(puVar8 + 1) == 0x20 || (*(short *)(puVar8 + 1) == 0)))) {
        _DAT_0047afa0 = 1;
      }
      if (((*puVar13 == CONCAT22(DAT_0040a2be,DAT_0040a2bc)) &&
          (*(uint *)((int)puVar8 + 6) ==
           (CONCAT22(DAT_0040a2c2,DAT_0040a2c0) | (int)DAT_0040a2be >> 0xf))) &&
         ((*(short *)((int)puVar8 + 10) == 0x20 || (*(short *)((int)puVar8 + 10) == 0)))) {
        local_2c8 = local_2c8 | 4;
      }
      if ((*(int *)((int)puVar8 + -2) == CONCAT22(DAT_0040a2b2,DAT_0040a2b0)) &&
         (*puVar13 == (CONCAT22(DAT_0040a2b6,DAT_0040a2b4) | (int)DAT_0040a2b2 >> 0xf))) {
        *(short *)((int)puVar8 + -2) = 0;
        FUN_004062ba((LPWSTR)&DAT_004cf000,(LPCWSTR)((int)puVar8 + 6));
        break;
      }
    }
    puVar8 = (uint *)FUN_00405bbc((LPCWSTR)puVar13,WVar14);
    if (*(short *)puVar8 == 0x22) {
      puVar8 = (uint *)((int)puVar8 + 2);
    }
    sVar1 = *(short *)puVar8;
  }
  GetTempPathW(0x2000,(LPWSTR)&DAT_004df000);
  iVar5 = FUN_0040335e();
  if (iVar5 == 0) {
    GetWindowsDirectoryW((LPWSTR)&DAT_004df000,0x1ffb);
    lstrcatW((LPWSTR)&DAT_004df000,u__Temp_0040a2a4);
    iVar5 = FUN_0040335e();
    if (iVar5 == 0) {
      GetTempPathW(0x1ffc,(LPWSTR)&DAT_004df000);
      lstrcatW((LPWSTR)&DAT_004df000,(LPCWSTR)&DAT_0040a29c);
      SetEnvironmentVariableW(u_TEMP_0040a290,(LPCWSTR)&DAT_004df000);
      SetEnvironmentVariableW((LPCWSTR)&PTR_DAT_0040a288,(LPCWSTR)&DAT_004df000);
      iVar5 = FUN_0040335e();
      if (iVar5 == 0) goto LAB_004036fe;
    }
  }
  DeleteFileW((LPCWSTR)&DAT_004db000);
  local_2d4 = FUN_00402edd(local_2c8);
  if (local_2d4 != (wchar_t *)0x0) goto LAB_004036fe;
  if (_DAT_0047af00 != 0) {
    piVar9 = (int *)FUN_00405bbc((LPCWSTR)&DAT_004cb000,L'\0');
    if ((int *)0x4cafff < piVar9) {
      do {
        if ((*piVar9 == CONCAT22(DAT_0040a27e,DAT_0040a27c)) &&
           (piVar9[1] == (CONCAT22(DAT_0040a282,DAT_0040a280) | (int)DAT_0040a27e >> 0xf))) break;
        piVar9 = (int *)((int)piVar9 + -2);
      } while ((int *)0x4cafff < piVar9);
    }
    local_2d4 = u_Error_launching_installer_0040a1e8;
    if (piVar9 < &DAT_004cb000) {
      iVar5 = FUN_0040588b();
      lstrcatW((LPWSTR)&DAT_004df000,u__nsu_0040a270);
      if (iVar5 != 0) {
        lstrcatW((LPWSTR)&DAT_004df000,(LPCWSTR)&DAT_0040a26c);
      }
      lstrcatW((LPWSTR)&DAT_004df000,u__tmp_0040a260);
      iVar10 = lstrcmpiW((LPCWSTR)&DAT_004df000,(LPCWSTR)&DAT_004d7000);
      if (iVar10 != 0) {
        if (iVar5 == 0) {
          FUN_0040586e((LPCWSTR)&DAT_004df000);
        }
        else {
          FUN_004057f1((LPCWSTR)&DAT_004df000);
        }
        SetCurrentDirectoryW((LPCWSTR)&DAT_004df000);
        if (_DAT_004cf000 == 0) {
          FUN_004062ba((LPWSTR)&DAT_004cf000,(LPCWSTR)&DAT_004d7000);
        }
        FUN_004062ba((LPWSTR)&DAT_0047b000,(LPCWSTR)puStack_2cc);
        _DAT_0047f000 = CONCAT22(DAT_0040a25a,DAT_0040a258);
        iVar5 = 0x1a;
        do {
          FUN_004062dc((LPWSTR)&DAT_0043c208,*(int *)(DAT_0047aef4 + 0x120));
          DeleteFileW((LPCWSTR)&DAT_0043c208);
          if ((local_2d4 != (wchar_t *)0x0) &&
             (BVar12 = CopyFileW((LPCWSTR)&DAT_004e7000,(LPCWSTR)&DAT_0043c208,1), BVar12 != 0)) {
            FUN_00406080((LPCWSTR)&DAT_0043c208,(LPCWSTR)0x0);
            FUN_004062dc((LPWSTR)&DAT_0043c208,*(int *)(DAT_0047aef4 + 0x124));
            pvVar11 = FUN_004058a3((LPWSTR)&DAT_0043c208);
            if (pvVar11 != (HANDLE)0x0) {
              CloseHandle(pvVar11);
              local_2d4 = (wchar_t *)0x0;
            }
          }
          _DAT_0047f000 = _DAT_0047f000 + 1;
          _DAT_0047f000 = _DAT_0047f000 & 0xffff0000 | (uint)_DAT_0047f000;
          iVar5 = iVar5 + -1;
        } while (iVar5 != 0);
        FUN_00406080((LPCWSTR)&DAT_004df000,(LPCWSTR)0x0);
      }
      goto LAB_004036fe;
    }
    *(undefined2 *)piVar9 = 0;
    piVar9 = piVar9 + 2;
    bVar2 = FUN_00405c97((LPCWSTR)piVar9);
    if (CONCAT31(extraout_var,bVar2) == 0) goto LAB_004036fe;
    FUN_004062ba((LPWSTR)&DAT_004cf000,(LPCWSTR)piVar9);
    FUN_004062ba((LPWSTR)&DAT_004d3000,(LPCWSTR)piVar9);
    local_2d4 = (wchar_t *)0x0;
  }
  DAT_0047afac = -1;
  local_2d0 = FUN_004039aa();
LAB_004036fe:
  FUN_004038d0();
  OleUninitialize();
  if (local_2d4 == (wchar_t *)0x0) {
    if (_DAT_0047af94 != 0) {
      TokenHandle = &puStack_2cc;
      DVar3 = 0x28;
      pvVar11 = GetCurrentProcess();
      BVar12 = OpenProcessToken(pvVar11,DVar3,TokenHandle);
      if (BVar12 != 0) {
        LookupPrivilegeValueW
                  ((LPCWSTR)0x0,u_SeShutdownPrivilege_0040a230,&_Stack_2c4.Privileges[0].Luid);
        _Stack_2c4.PrivilegeCount = 1;
        _Stack_2c4.Privileges[0].Attributes = 2;
        AdjustTokenPrivileges(puStack_2cc,0,&_Stack_2c4,0,(PTOKEN_PRIVILEGES)0x0,(PDWORD)0x0);
      }
      pFVar4 = FUN_00406694(4);
      if (((pFVar4 != (FARPROC)0x0) && (iVar5 = (*pFVar4)(0,0,0,0x25,0x80040002), iVar5 == 0)) ||
         (BVar12 = ExitWindowsEx(2,0x80040002), BVar12 == 0)) {
        FUN_0040140b(9);
      }
    }
    if (DAT_0047afac != -1) {
      local_2d0 = DAT_0047afac;
    }
                    /* WARNING: Subroutine does not return */
    ExitProcess(local_2d0);
  }
  FUN_00405920(local_2d4,0x200010);
                    /* WARNING: Subroutine does not return */
  ExitProcess(2);
}

/* Function: FUN_004038d0 */
void FUN_004038d0(void)

{
  if (DAT_0040a018 != (HANDLE)0xffffffff) {
    CloseHandle(DAT_0040a018);
    DAT_0040a018 = (HANDLE)0xffffffff;
  }
  FUN_00403915();
  FUN_004059cc((LPCWSTR)&DAT_004e3000,7);
  return;
}

/* Function: FUN_004038fa */
void FUN_004038fa(undefined4 param_1)

{
  undefined4 *puVar1;
  
  for (puVar1 = DAT_0044020c; puVar1 != (undefined4 *)0x0; puVar1 = (undefined4 *)*puVar1) {
    (*(code *)puVar1[1])(param_1);
  }
  return;
}

/* Function: FUN_00403915 */
void FUN_00403915(void)

{
  int *piVar1;
  int *hMem;
  
  hMem = DAT_0044020c;
  FUN_004038fa(0);
  if (hMem != (int *)0x0) {
    do {
      piVar1 = (int *)*hMem;
      FreeLibrary((HMODULE)hMem[2]);
      GlobalFree(hMem);
      hMem = piVar1;
    } while (piVar1 != (int *)0x0);
  }
  DAT_0044020c = (int *)0x0;
  return;
}

/* Function: FUN_0040394a */
undefined4 FUN_0040394a(int param_1)

{
  undefined4 *puVar1;
  
  puVar1 = DAT_0044020c;
  while( true ) {
    if (puVar1 == (undefined4 *)0x0) {
      return 1;
    }
    if (puVar1[2] == param_1) break;
    puVar1 = (undefined4 *)*puVar1;
  }
  return 0;
}

/* Function: FUN_00403968 */
undefined4 FUN_00403968(int param_1,undefined4 param_2)

{
  int iVar1;
  undefined4 uVar2;
  undefined4 *puVar3;
  
  iVar1 = FUN_0040394a(param_1);
  if (iVar1 == 0) {
    uVar2 = 1;
  }
  else {
    puVar3 = (undefined4 *)GlobalAlloc(0x40,0xc);
    if (puVar3 == (undefined4 *)0x0) {
      uVar2 = 0xffffffff;
    }
    else {
      puVar3[2] = param_1;
      puVar3[1] = param_2;
      *puVar3 = DAT_0044020c;
      uVar2 = 0;
      DAT_0044020c = puVar3;
    }
  }
  return uVar2;
}

/* Function: FUN_004039aa */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

INT_PTR FUN_004039aa(void)

{
  bool bVar1;
  ATOM AVar2;
  FARPROC pFVar3;
  uint uVar4;
  undefined3 extraout_var;
  undefined2 *puVar5;
  int iVar6;
  DWORD DVar7;
  LPCWSTR pWVar8;
  undefined3 extraout_var_00;
  int iVar9;
  INT_PTR IVar10;
  BOOL BVar11;
  short *lpString;
  int iStack_10;
  int iStack_c;
  int iStack_8;
  int iStack_4;
  
  iVar9 = DAT_0047aef4;
  pFVar3 = FUN_00406694(2);
  if (pFVar3 == (FARPROC)0x0) {
    _DAT_004db000 = 0x30;
    _DAT_004db002 = 0x78;
    _DAT_004db004 = 0;
    FUN_00406188(0x80000001,L"Control Panel\\Desktop\\ResourceLocale",(LPCWSTR)0x0,
                 (undefined2 *)&DAT_00450248,(HKEY)0x0);
    if (_DAT_00450248 == 0) {
      FUN_00406188(0x80000003,(LPCWSTR)&PTR_DAT_00408340,L"Locale",(undefined2 *)&DAT_00450248,
                   (HKEY)0x0);
    }
    lstrcatW((LPWSTR)&DAT_004db000,(LPCWSTR)&DAT_00450248);
  }
  else {
    uVar4 = (*pFVar3)();
    FUN_00406201((LPWSTR)&DAT_004db000,uVar4 & 0xffff);
  }
  FUN_00403c80();
  _DAT_0047af80 = DAT_0047aefc & 0x20;
  _DAT_0047af9c = 0x10000;
  bVar1 = FUN_00405c97((LPCWSTR)&DAT_004cf000);
  if ((CONCAT31(extraout_var,bVar1) == 0) && (*(int *)(iVar9 + 0x48) != 0)) {
    lpString = &DAT_0046ae80;
    FUN_00406188(*(uint *)(iVar9 + 0x44),(LPCWSTR)(DAT_0047af38 + *(int *)(iVar9 + 0x48) * 2),
                 (LPCWSTR)(DAT_0047af38 + *(int *)(iVar9 + 0x4c) * 2),&DAT_0046ae80,(HKEY)0x0);
    if (DAT_0046ae80 != 0) {
      if (DAT_0046ae80 == 0x22) {
        lpString = (short *)&DAT_0046ae82;
        puVar5 = (undefined2 *)FUN_00405bbc((LPCWSTR)&DAT_0046ae82,L'\"');
        *puVar5 = 0;
      }
      iVar6 = lstrlenW(lpString);
      if (((lpString < lpString + iVar6 + -4) &&
          (iVar6 = lstrcmpiW(lpString + iVar6 + -4,u__exe_0040a388), iVar6 == 0)) &&
         ((DVar7 = GetFileAttributesW(lpString), DVar7 == 0xffffffff || ((DVar7 & 0x10) == 0)))) {
        FUN_00405bdb(lpString);
      }
      pWVar8 = FUN_00405b8f(lpString);
      FUN_004062ba((LPWSTR)&DAT_004cf000,pWVar8);
    }
  }
  bVar1 = FUN_00405c97((LPCWSTR)&DAT_004cf000);
  if (CONCAT31(extraout_var_00,bVar1) == 0) {
    FUN_004062dc((LPWSTR)&DAT_004cf000,*(int *)(iVar9 + 0x118));
  }
  DAT_00472ec8 = LoadImageW(DAT_0047aee0,(LPCWSTR)0x67,1,0,0,0x8040);
  if (*(int *)(iVar9 + 0x50) == -1) {
LAB_00403ba7:
    iVar9 = FUN_0040140b(0);
    if (iVar9 == 0) {
      FUN_00403c80();
      if (_DAT_0047afa0 == 0) {
        ShowWindow(DAT_00450228,5);
        iVar9 = FUN_00406624("RichEd20");
        if (iVar9 == 0) {
          FUN_00406624("RichEd32");
        }
        BVar11 = GetClassInfoW((HINSTANCE)0x0,L"RichEdit20W",(LPWNDCLASSW)&DAT_00472e80);
        if (BVar11 == 0) {
          GetClassInfoW((HINSTANCE)0x0,L"RichEdit",(LPWNDCLASSW)&DAT_00472e80);
          _DAT_00472ea4 = (undefined **)0x408310;
          RegisterClassW((WNDCLASSW *)&DAT_00472e80);
        }
        IVar10 = DialogBoxParamW(DAT_0047aee0,(LPCWSTR)(DAT_00472ec0 + 0x69U & 0xffff),(HWND)0x0,
                                 (DLGPROC)&LAB_00403d58,0);
        FUN_0040140b(5);
        FUN_004038fa(1);
        return IVar10;
      }
      iVar9 = FUN_004053f5((HWND)0x0);
      if (iVar9 == 0) {
        FUN_0040140b(1);
        goto LAB_00403c76;
      }
      if (_DAT_00472eac == 0) {
        FUN_0040140b(2);
      }
    }
    IVar10 = 2;
  }
  else {
    _DAT_00472e84 = FUN_00401000;
    _DAT_00472e90 = DAT_0047aee0;
    _DAT_00472ea4 = &PTR_DAT_0040a380;
    _DAT_00472e94 = DAT_00472ec8;
    AVar2 = RegisterClassW((WNDCLASSW *)&DAT_00472e80);
    if (AVar2 != 0) {
      SystemParametersInfoW(0x30,0,&iStack_10,0);
      DAT_00450228 = CreateWindowExW(0x80,(LPCWSTR)&PTR_DAT_0040a380,(LPCWSTR)0x0,0x80000000,
                                     iStack_10,iStack_c,iStack_8 - iStack_10,iStack_4 - iStack_c,
                                     (HWND)0x0,(HMENU)0x0,DAT_0047aee0,(LPVOID)0x0);
      goto LAB_00403ba7;
    }
LAB_00403c76:
    IVar10 = 0;
  }
  return IVar10;
}

/* Function: FUN_00403c80 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_00403c80(void)

{
  int iVar1;
  ushort *puVar2;
  ushort uVar3;
  int iVar4;
  int *piVar5;
  
  uVar3 = 0xffff;
  iVar1 = FUN_0040621a((ushort *)&DAT_004db000);
  do {
    if (DAT_0047af44 != 0) {
      puVar2 = (ushort *)(*(int *)(DAT_0047aef4 + 100) * DAT_0047af44 + _DAT_0047af40);
      iVar4 = DAT_0047af44;
      do {
        puVar2 = (ushort *)((int)puVar2 - *(int *)(DAT_0047aef4 + 100));
        iVar4 = iVar4 + -1;
        if (((*puVar2 ^ (ushort)iVar1) & uVar3) == 0) {
          DAT_00472ec0 = *(undefined4 *)(puVar2 + 1);
          _DAT_0047afa8 = *(undefined4 *)(puVar2 + 3);
          DAT_00472ebc = puVar2 + 5;
          if (DAT_00472ebc != (ushort *)0x0) {
            FUN_00406201((LPWSTR)&DAT_004db000,(uint)*puVar2);
            FUN_00403d39();
            piVar5 = DAT_0047af28;
            for (iVar1 = DAT_0047af2c; iVar1 != 0; iVar1 = iVar1 + -1) {
              if (*piVar5 != 0) {
                FUN_004062dc((LPWSTR)(piVar5 + 6),*piVar5);
              }
              piVar5 = piVar5 + 0x1006;
            }
            return;
          }
          break;
        }
      } while (iVar4 != 0);
    }
    if (uVar3 == 0xffff) {
      uVar3 = 0x3ff;
    }
    else {
      uVar3 = 0;
    }
  } while( true );
}

/* Function: FUN_00403d39 */
undefined * FUN_00403d39(void)

{
  FUN_004062dc((LPWSTR)&DAT_00472ee0,-2);
  SetWindowTextW(DAT_00450228,(LPCWSTR)&DAT_00472ee0);
  return &DAT_00472ee0;
}

/* Function: FUN_0040420a */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_0040420a(WPARAM param_1)

{
  if (param_1 == 0x78) {
    _DAT_00472eac = _DAT_00472eac + 1;
  }
  SendMessageW(DAT_0047aee8,0x408,param_1,0);
  return;
}

/* Function: FUN_00404231 */
void FUN_00404231(HWND param_1,int param_2,int param_3)

{
  LPCWSTR lpString;
  
  lpString = (LPCWSTR)FUN_004062dc((LPWSTR)0x0,param_3);
  SetDlgItemTextW(param_1,param_2 + 1000,lpString);
  return;
}

/* Function: FUN_00404253 */
void FUN_00404253(BOOL param_1)

{
  EnableWindow(DAT_00450244,param_1);
  return;
}

/* Function: FUN_00404266 */
void FUN_00404266(WPARAM param_1)

{
  SendMessageW(DAT_0047aee8,0x28,param_1,1);
  return;
}

/* Function: FUN_0040427d */
void FUN_0040427d(UINT param_1)

{
  if (DAT_00472eb8 != (HWND)0x0) {
    SendMessageW(DAT_00472eb8,param_1,0,0);
  }
  return;
}

/* Function: FUN_00404298 */
COLORREF FUN_00404298(int param_1,HDC param_2,HWND param_3)

{
  COLORREF *pCVar1;
  COLORREF color;
  HBRUSH pHVar2;
  LOGBRUSH local_10;
  
  if ((((param_1 - 0x133U < 6) &&
       (pCVar1 = (COLORREF *)GetWindowLongW(param_3,-0x15), pCVar1 != (COLORREF *)0x0)) &&
      (pCVar1[2] < 2)) && ((pCVar1[4] < 3 && ((pCVar1[5] & 0xffffffe0) == 0)))) {
    color = *pCVar1;
    if ((pCVar1[5] & 2) != 0) {
      color = GetSysColor(color);
    }
    if ((*(byte *)(pCVar1 + 5) & 1) != 0) {
      SetTextColor(param_2,color);
    }
    SetBkMode(param_2,pCVar1[4]);
    local_10.lbColor = pCVar1[1];
    if ((*(byte *)(pCVar1 + 5) & 8) != 0) {
      local_10.lbColor = GetSysColor(local_10.lbColor);
    }
    if ((*(byte *)(pCVar1 + 5) & 4) != 0) {
      SetBkColor(param_2,local_10.lbColor);
    }
    if ((*(byte *)(pCVar1 + 5) & 0x10) != 0) {
      local_10.lbStyle = pCVar1[2];
      if ((HGDIOBJ)pCVar1[3] != (HGDIOBJ)0x0) {
        DeleteObject((HGDIOBJ)pCVar1[3]);
      }
      pHVar2 = CreateBrushIndirect(&local_10);
      pCVar1[3] = (COLORREF)pHVar2;
    }
    return pCVar1[3];
  }
  return 0;
}

/* Function: FUN_00404367 */
undefined4 FUN_00404367(int param_1,LPWSTR param_2,uint param_3,int *param_4)

{
  int iVar1;
  
  lstrcpynW(param_2,(LPCWSTR)(DAT_00440214 + param_1),param_3 >> 1);
  iVar1 = lstrlenW(param_2);
  *param_4 = iVar1 * 2;
  DAT_00440214 = DAT_00440214 + iVar1 * 2;
  return 0;
}

/* Function: FUN_004043a1 */
undefined4 FUN_004043a1(int param_1,LPSTR param_2,uint param_3,int *param_4)

{
  uint cchWideChar;
  int iVar1;
  
  cchWideChar = lstrlenW((LPCWSTR)(param_1 + DAT_00440214 * 2));
  if (param_3 >> 1 <= cchWideChar) {
    cchWideChar = param_3 >> 1;
  }
  iVar1 = WideCharToMultiByte(0,0,(LPCWSTR)(param_1 + DAT_00440214 * 2),cchWideChar,param_2,param_3,
                              (LPCSTR)0x0,(LPBOOL)0x0);
  *param_4 = iVar1;
  DAT_00440214 = DAT_00440214 + iVar1;
  return 0;
}

/* Function: FUN_004043f0 */
COLORREF FUN_004043f0(HWND param_1,int param_2,HDC param_3,HWND param_4)

{
  uint *puVar1;
  ushort *puVar2;
  LPCWSTR lpString;
  HWND pHVar3;
  DWORD lParam;
  int iVar4;
  HCURSOR pHVar5;
  COLORREF CVar6;
  uint uVar7;
  uint uVar8;
  UINT Msg;
  WPARAM wParam;
  LPARAM lParam_00;
  LPCWSTR local_10;
  int local_c;
  code *local_8;
  
  if (param_2 == 0x110) {
    iVar4 = param_4[0xc].unused;
    if (iVar4 < 0) {
      iVar4 = *(int *)(DAT_00472ebc - (iVar4 * 4 + 4));
    }
    puVar2 = (ushort *)(DAT_0047af38 + iVar4 * 2);
    uVar7 = (uint)*puVar2;
    lpString = (LPCWSTR)(puVar2 + 1);
    local_c = 0;
    local_8 = FUN_004043a1;
    if (uVar7 != 2) {
      local_8 = FUN_00404367;
    }
    uVar8 = (uint)~param_4[5].unused >> 5 & 1 | param_4[5].unused & 1U;
    local_10 = lpString;
    FUN_00404231(param_1,0x22,param_4[0xd].unused);
    FUN_00404231(param_1,0x23,param_4[0xe].unused);
    CheckDlgButton(param_1,(uVar8 == 0) + 0x40a,1);
    FUN_00404253(uVar8);
    pHVar3 = GetDlgItem(param_1,1000);
    FUN_00404266((WPARAM)pHVar3);
    SendMessageW(pHVar3,0x45b,1,0);
    lParam = *(DWORD *)(DAT_0047aef4 + 0x68);
    if ((int)lParam < 0) {
      lParam = GetSysColor(-lParam);
    }
    SendMessageW(pHVar3,0x443,0,lParam);
    SendMessageW(pHVar3,0x445,0,0x4010000);
    iVar4 = lstrlenW(lpString);
    SendMessageW(pHVar3,0x435,0,iVar4);
    DAT_00440214 = 0;
    SendMessageW(pHVar3,0x449,uVar7,(LPARAM)&local_10);
    DAT_00440214 = 0;
    return 0;
  }
  if (param_2 == 0x111) {
    if ((((short)((uint)param_3 >> 0x10) != 0) || (DAT_00440214 != 0)) ||
       (puVar1 = (uint *)(DAT_00448220 + 0x14), (*(byte *)puVar1 & 0x20) == 0)) goto LAB_00404668;
    lParam_00 = 0;
    wParam = 0;
    Msg = 0xf0;
    pHVar3 = GetDlgItem(param_1,0x40a);
    uVar7 = SendMessageW(pHVar3,Msg,wParam,lParam_00);
    *puVar1 = *puVar1 & 0xfffffffe | uVar7 & 1;
    FUN_00404253(uVar7 & 1);
    FUN_0040467b();
  }
  if (param_2 == 0x4e) {
    pHVar3 = GetDlgItem(param_1,1000);
    if ((param_4[2].unused == 0x70b) && (param_4[3].unused == 0x201)) {
      local_c = param_4[7].unused;
      local_10 = (LPCWSTR)param_4[6].unused;
      local_8 = (code *)&DAT_0046ae80;
      if ((uint)(local_c - (int)local_10) < 0x4000) {
        SendMessageW(pHVar3,1099,0,(LPARAM)&local_10);
        pHVar5 = LoadCursorW((HINSTANCE)0x0,(LPCWSTR)0x7f02);
        SetCursor(pHVar5);
        FUN_0040469f(param_1,(LPCWSTR)local_8);
        pHVar5 = LoadCursorW((HINSTANCE)0x0,(LPCWSTR)0x7f00);
        SetCursor(pHVar5);
      }
    }
    if ((param_4[2].unused == 0x700) && (param_4[3].unused == 0x100)) {
      if (param_4[4].unused == 0xd) {
        SendMessageW(DAT_0047aee8,0x111,1,0);
      }
      if (param_4[4].unused == 0x1b) {
        SendMessageW(DAT_0047aee8,0x10,0,0);
      }
      return 1;
    }
  }
  else if (param_2 == 0x40b) {
    DAT_00440214 = DAT_00440214 + 1;
  }
LAB_00404668:
  CVar6 = FUN_00404298(param_2,param_3,param_4);
  return CVar6;
}

/* Function: FUN_0040467b */
void FUN_0040467b(void)

{
  HWND hWnd;
  
  hWnd = DAT_00440210;
  if (DAT_0047af8c == 0) {
    hWnd = DAT_00450244;
  }
  SendMessageW(hWnd,0xf4,1,1);
  return;
}

/* Function: FUN_0040469f */
void FUN_0040469f(HWND param_1,LPCWSTR param_2)

{
  SHELLEXECUTEINFOW local_40;
  
  local_40.lpParameters = (LPCWSTR)0x0;
  local_40.lpDirectory = (LPCWSTR)0x0;
  local_40.hwnd = param_1;
  local_40.fMask = 0x500;
  local_40.lpFile = param_2;
  local_40.nShow = 1;
  local_40.lpVerb = u_open_0040a394;
  FUN_004058e6(&local_40);
  return;
}

/* Function: FUN_004046db */
void FUN_004046db(HWND param_1,int param_2,HDC param_3,HWND param_4)

{
  if (param_2 == 0x110) {
    FUN_00404231(param_1,0x1d,param_4[0xc].unused);
    SetDlgItemTextW(param_1,1000,(LPCWSTR)(&DAT_0047b000 + param_4[0xf].unused * 0x4000));
  }
  FUN_00404298(param_2,param_3,param_4);
  return;
}

/* Function: FUN_00404722 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_00404722(HWND param_1,int param_2,HDC param_3,HWND param_4)

{
  bool bVar1;
  HWND hWnd;
  int iVar2;
  LPWSTR pWVar3;
  FARPROC pFVar4;
  LPITEMIDLIST pv;
  undefined3 extraout_var;
  BOOL BVar5;
  uint uVar6;
  int iVar7;
  LPCWSTR lpString;
  LPCITEMIDLIST *ppIVar8;
  LPCWSTR pWVar9;
  _browseinfoW local_50;
  uint local_30;
  uint local_2c;
  undefined local_28 [4];
  DWORD local_24;
  int local_20;
  undefined local_1c [4];
  DWORD local_18;
  DWORD local_14;
  FARPROC local_10;
  int local_c;
  int local_8;
  
  local_20 = DAT_00448220;
  local_c = *(int *)(DAT_00448220 + 0x38);
  lpString = (LPCWSTR)(&DAT_0047b000 + *(int *)(DAT_00448220 + 0x3c) * 0x4000);
  if (param_2 == 0x40b) {
    FUN_00405904(0x3fb,lpString);
    FUN_0040654e(lpString);
  }
  if (param_2 == 0x110) {
    hWnd = GetDlgItem(param_1,0x3fb);
    iVar2 = FUN_00405c06((ushort *)lpString);
    if ((iVar2 != 0) && (pWVar3 = FUN_00405c3a(lpString), pWVar3 == (LPWSTR)0x0)) {
      FUN_00405b8f(lpString);
    }
    DAT_00472eb8 = param_1;
    SetWindowTextW(hWnd,lpString);
    FUN_00404231(param_1,1,param_4[0xd].unused);
    FUN_00404231(param_1,0x14,param_4[0xc].unused);
    FUN_00404266((WPARAM)hWnd);
    pFVar4 = FUN_00406694(7);
    if (pFVar4 == (FARPROC)0x0) goto LAB_00404a63;
    (*pFVar4)(hWnd,1);
  }
  iVar2 = local_c;
  if (param_2 == 0x111) {
    if (((uint)param_3 & 0xffff) == 0x3fb) {
      if ((short)((uint)param_3 >> 0x10) != 0x300) goto LAB_00404a63;
      param_2 = 0x40f;
    }
    if (((uint)param_3 & 0xffff) == 0x3e9) {
      ppIVar8 = &local_50.pidlRoot;
      for (iVar7 = 7; iVar7 != 0; iVar7 = iVar7 + -1) {
        *ppIVar8 = (LPCITEMIDLIST)0x0;
        ppIVar8 = ppIVar8 + 1;
      }
      local_50.hwndOwner = param_1;
      local_50.pszDisplayName = (LPWSTR)&DAT_00450248;
      local_50.lpfn = FUN_00404a78;
      local_50.lParam = (LPARAM)lpString;
      local_50.lpszTitle = (LPCWSTR)FUN_004062dc((LPWSTR)&DAT_00444220,iVar2);
      local_50.ulFlags = 0x41;
      pv = SHBrowseForFolderW(&local_50);
      if (pv == (LPITEMIDLIST)0x0) {
        param_2 = 0x40f;
      }
      else {
        CoTaskMemFree(pv);
        FUN_00405b8f(lpString);
        if ((*(int *)(DAT_0047aef4 + 0x11c) != 0) && (lpString == (LPCWSTR)&DAT_004cf000)) {
          FUN_004062dc((LPWSTR)0x0,*(int *)(DAT_0047aef4 + 0x11c));
          iVar2 = lstrcmpiW(&DAT_0046ae80,(LPCWSTR)&DAT_00450248);
          if (iVar2 != 0) {
            lstrcatW((LPWSTR)&DAT_004cf000,&DAT_0046ae80);
          }
        }
        _DAT_00450238 = _DAT_00450238 + 1;
        SetDlgItemTextW(param_1,0x3fb,lpString);
      }
    }
  }
  if ((param_2 == 0x40f) || (param_2 == 0x405)) {
    local_8 = 0;
    local_c = 0;
    FUN_00405904(0x3fb,lpString);
    bVar1 = FUN_00405c97(lpString);
    if (CONCAT31(extraout_var,bVar1) == 0) {
      local_8 = 1;
    }
    FUN_004062ba((LPWSTR)&DAT_00440218,lpString);
    local_10 = FUN_00406694(1);
    if (local_10 != (FARPROC)0x0) {
      pWVar9 = (LPCWSTR)0x0;
      do {
        iVar2 = (*local_10)(&DAT_00440218,&local_30,local_1c,local_28);
        if (iVar2 != 0) {
          local_30 = local_30 >> 10 | local_2c << 0x16;
          local_2c = local_2c >> 10;
          local_c = 1;
          goto LAB_004049bc;
        }
        if (pWVar9 != (LPCWSTR)0x0) {
          *pWVar9 = L'\0';
        }
        pWVar9 = FUN_00405bdb((LPCWSTR)&DAT_00440218);
        *pWVar9 = L'\0';
        pWVar9 = pWVar9 + -1;
        *pWVar9 = L'\\';
      } while (pWVar9 != (LPCWSTR)&DAT_00440218);
    }
    FUN_004062ba((LPWSTR)&DAT_00440218,lpString);
    pWVar3 = FUN_00405c3a((LPCWSTR)&DAT_00440218);
    if (pWVar3 != (LPWSTR)0x0) {
      *pWVar3 = L'\0';
    }
    BVar5 = GetDiskFreeSpaceW((LPCWSTR)&DAT_00440218,&local_14,&local_18,(LPDWORD)&local_10,
                              &local_24);
    if (BVar5 != 0) {
      local_30 = MulDiv(local_14 * local_18,(int)local_10,0x400);
      local_2c = (int)local_30 >> 0x1f;
      local_c = 1;
    }
LAB_004049bc:
    uVar6 = FUN_00404bbf(5);
    if (((local_c != 0) && (local_2c == 0)) && (local_30 < uVar6)) {
      local_8 = 2;
    }
    if (*(int *)(DAT_00472ebc + 0x10) != 0) {
      FUN_00404ba7(0x3ff,-5,uVar6);
      if (local_c == 0) {
        SetDlgItemTextW(param_1,0x400,(LPCWSTR)&DAT_00440208);
      }
      else {
        FUN_00404ade(0x400,-4,local_30,local_2c);
      }
    }
    _DAT_0047afa4 = local_8;
    if (local_8 == 0) {
      local_8 = FUN_0040140b(7);
    }
    if ((*(uint *)(local_20 + 0x14) & 0x400) != 0) {
      local_8 = 0;
    }
    FUN_00404253((uint)(local_8 == 0));
    if ((local_8 == 0) && (_DAT_00450238 == 0)) {
      FUN_0040467b();
    }
    _DAT_00450238 = 0;
  }
LAB_00404a63:
  FUN_00404298(param_2,param_3,param_4);
  return;
}

/* Function: FUN_00404a78 */
undefined4 FUN_00404a78(HWND param_1,int param_2,LPCITEMIDLIST param_3,LPWSTR param_4)

{
  BOOL BVar1;
  int iVar2;
  LPARAM lParam;
  
  if (param_2 == 1) {
    FUN_00405904(0x3fb,param_4);
    SendMessageW(param_1,0x467,1,(LPARAM)param_4);
  }
  if (param_2 == 2) {
    BVar1 = SHGetPathFromIDListW(param_3,param_4);
    if ((BVar1 == 0) || (iVar2 = FUN_0040140b(7), iVar2 != 0)) {
      lParam = 0;
    }
    else {
      lParam = 1;
    }
    SendMessageW(param_1,0x465,0,lParam);
    return 0;
  }
  return 0;
}

/* Function: FUN_00404ade */
void FUN_00404ade(int param_1,int param_2,uint param_3,int param_4)

{
  undefined4 uVar1;
  undefined4 uVar2;
  int iVar3;
  sbyte sVar4;
  int iVar5;
  uint uVar6;
  uint uVar7;
  wchar_t *pwVar8;
  WCHAR local_84 [32];
  WCHAR local_44 [32];
  
  iVar5 = -0x24;
  if (param_4 == 0) {
    sVar4 = 0x14;
    if (param_3 < 0x100000) {
      sVar4 = 10;
      iVar5 = -0x23;
    }
    if (param_3 < 0x400) {
      sVar4 = 0;
      iVar5 = -0x22;
    }
    if (param_3 < 0xffff3333) {
      param_3 = (1 << sVar4) / 0x14 + param_3;
    }
    uVar6 = param_3 >> sVar4;
    uVar7 = ((param_3 & 0xffffff) * 10 >> sVar4) % 10;
  }
  else {
    uVar6 = param_3 >> 0x14 | param_4 << 0xc;
    uVar7 = 0;
  }
  uVar1 = FUN_004062dc(local_44,-0x21);
  uVar2 = FUN_004062dc(local_84,iVar5);
  pwVar8 = u__u__u_s_s_0040a3a0;
  iVar5 = FUN_004062dc((LPWSTR)&DAT_00450248,param_2);
  iVar3 = lstrlenW((LPCWSTR)&DAT_00450248);
  wsprintfW((LPWSTR)(iVar5 + iVar3 * 2),pwVar8,uVar6,uVar7,uVar2,uVar1);
  SetDlgItemTextW(DAT_00472eb8,param_1,(LPCWSTR)&DAT_00450248);
  return;
}

/* Function: FUN_00404ba7 */
void FUN_00404ba7(int param_1,int param_2,uint param_3)

{
  FUN_00404ade(param_1,param_2,param_3,0);
  return;
}

/* Function: FUN_00404bbf */
int FUN_00404bbf(int param_1)

{
  int iVar1;
  int iVar2;
  int iVar3;
  
  iVar1 = 0;
  iVar2 = DAT_0047af28;
  iVar3 = DAT_0047af2c;
  if (DAT_0047af2c != 0) {
    do {
      if ((*(byte *)(iVar2 + 8) & 1) != 0) {
        iVar1 = iVar1 + *(int *)(iVar2 + param_1 * 4);
      }
      iVar3 = iVar3 + -1;
      iVar2 = iVar2 + 0x4018;
    } while (iVar3 != 0);
  }
  return iVar1;
}

/* Function: FUN_00404bec */
undefined4 FUN_00404bec(HWND param_1,int param_2)

{
  DWORD DVar1;
  undefined4 local_3c;
  LRESULT local_38;
  undefined4 local_18;
  tagPOINT local_14;
  byte local_c;
  LRESULT local_8;
  
  local_38 = SendMessageW(param_1,0x110a,9,0);
  if (param_2 != 0) {
    DVar1 = GetMessagePos();
    local_14.x = (LONG)(short)DVar1;
    local_14.y = (LONG)(short)(DVar1 >> 0x10);
    ScreenToClient(param_1,&local_14);
    SendMessageW(param_1,0x1111,0,(LPARAM)&local_14);
    local_38 = local_8;
    if ((local_c & 0x66) == 0) {
      return 0xffffffff;
    }
  }
  local_3c = 4;
  SendMessageW(param_1,0x113e,0,(LPARAM)&local_3c);
  return local_18;
}

/* Function: FUN_00404c6c */
void FUN_00404c6c(int param_1,undefined4 param_2)

{
  FUN_004062ba((LPWSTR)&DAT_00450248,(LPCWSTR)&DAT_0047b000);
  FUN_00406201((LPWSTR)&DAT_0047b000,param_2);
  FUN_0040140b(param_1);
  FUN_004062ba((LPWSTR)&DAT_0047b000,(LPCWSTR)&DAT_00450248);
  return;
}

/* Function: FUN_00404c9e */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_00404c9e(HWND param_1,int param_2,HDC param_3,HWND param_4)

{
  int iVar1;
  HBITMAP hbmImage;
  LRESULT LVar2;
  LPARAM lParam;
  WPARAM WVar3;
  LRESULT LVar4;
  uint uVar5;
  uint uVar6;
  HDC pHVar7;
  HWND pHVar8;
  int iVar9;
  uint *puVar10;
  LPARAM local_54;
  undefined4 local_50;
  undefined4 local_4c;
  undefined4 local_48;
  uint local_44;
  uint local_40;
  uint *local_3c;
  uint *local_38;
  undefined4 local_2c;
  int local_28;
  HGLOBAL local_20;
  uint *local_1c;
  int local_18;
  int local_14;
  HWND local_10;
  HWND local_c;
  HWND local_8;
  
  local_c = GetDlgItem(param_1,0x3f9);
  local_8 = GetDlgItem(param_1,0x408);
  local_14 = DAT_0047af28;
  local_18 = DAT_0047aef4 + 0x94;
  if (param_2 == 0x110) {
    local_20 = (HGLOBAL)0x0;
    local_10 = (HWND)0x2;
    _DAT_0047af60 = param_1;
    DAT_00450240 = GlobalAlloc(0x40,DAT_0047af2c << 2);
    hbmImage = LoadBitmapW(DAT_0047aee0,(LPCWSTR)0x6e);
    _DAT_00450234 = 0xffffffff;
    DAT_0045023c = SetWindowLongW(local_8,-4,(LONG)FUN_00405296);
    DAT_0045022c = ImageList_Create(0x10,0x10,0x21,6,0);
    ImageList_AddMasked(DAT_0045022c,hbmImage,0xff00ff);
    SendMessageW(local_8,0x1109,2,(LPARAM)DAT_0045022c);
    LVar2 = SendMessageW(local_8,0x111c,0,0);
    if (LVar2 < 0x10) {
      SendMessageW(local_8,0x111b,0x10,0);
    }
    DeleteObject(hbmImage);
    iVar9 = 0;
    do {
      iVar1 = *(int *)(local_18 + iVar9 * 4);
      if (iVar1 != 0) {
        if (iVar9 != 0x20) {
          local_10 = (HWND)0x0;
        }
        lParam = FUN_004062dc((LPWSTR)0x0,iVar1);
        WVar3 = SendMessageW(local_c,0x143,0,lParam);
        SendMessageW(local_c,0x151,WVar3,iVar9);
      }
      pHVar8 = local_10;
      iVar9 = iVar9 + 1;
    } while (iVar9 < 0x21);
    FUN_00404231(param_1,0x15,param_4[(int)(local_10 + 3)].unused);
    FUN_00404231(param_1,0x16,param_4[(int)((int)&pHVar8[3].unused + 1)].unused);
    iVar9 = 0;
    LVar2 = 0;
    if (DAT_0047af2c < 1) {
LAB_00404eca:
      uVar5 = GetWindowLongW(local_8,-0x10);
      SetWindowLongW(local_8,-0x10,uVar5 & 0xfffffffb);
    }
    else {
      local_1c = (uint *)(local_14 + 8);
      do {
        puVar10 = local_1c + 4;
        if (*(short *)puVar10 != 0) {
          uVar5 = *local_1c;
          local_44 = uVar5 & 0x20;
          local_50 = 0xffff0002;
          local_4c = 0xd;
          local_40 = 0x20;
          local_54 = LVar2;
          local_3c = puVar10;
          local_28 = iVar9;
          if ((uVar5 & 2) == 0) {
            if ((uVar5 & 4) == 0) {
              LVar4 = SendMessageW(local_8,0x1132,0,(LPARAM)&local_54);
              *(LRESULT *)((int)DAT_00450240 + iVar9 * 4) = LVar4;
            }
            else {
              LVar2 = SendMessageW(local_8,0x110a,3,LVar2);
            }
          }
          else {
            local_4c = 0x4d;
            local_2c = 1;
            LVar2 = SendMessageW(local_8,0x1132,0,(LPARAM)&local_54);
            local_20 = (HGLOBAL)0x1;
            *(LRESULT *)((int)DAT_00450240 + iVar9 * 4) = LVar2;
            LVar2 = *(LRESULT *)((int)DAT_00450240 + iVar9 * 4);
          }
        }
        iVar9 = iVar9 + 1;
        local_1c = local_1c + 0x1006;
      } while (iVar9 < DAT_0047af2c);
      if (local_20 == (HGLOBAL)0x0) goto LAB_00404eca;
    }
    if (local_10 == (HWND)0x0) {
      ShowWindow(local_c,5);
      FUN_00404266((WPARAM)local_c);
      goto LAB_00405281;
    }
    FUN_00404266((WPARAM)local_8);
  }
  if (param_2 == 0x405) {
    param_3 = (HDC)0x0;
    param_2 = 0x40f;
    param_4 = (HWND)0x1;
  }
  if (((param_2 == 0x4e) || (param_2 == 0x413)) &&
     ((local_10 = param_4, param_2 == 0x413 || (param_4[1].unused == 0x408)))) {
    if (((DAT_0047aefc & 0x200) == 0) &&
       (((param_2 == 0x413 || (param_4[2].unused == -2)) &&
        (iVar9 = FUN_00404bec(local_8,(uint)(param_2 != 0x413)), -1 < iVar9)))) {
      puVar10 = (uint *)(iVar9 * 0x4018 + 8 + local_14);
      uVar5 = *puVar10;
      if ((uVar5 & 0x10) == 0) {
        if ((uVar5 & 0x40) == 0) {
          uVar5 = uVar5 ^ 1;
        }
        else {
          uVar6 = uVar5 ^ 0x80;
          if ((char)uVar6 < '\0') {
            uVar5 = uVar5 & 0xffffff00 | uVar6 & 0xff | 1;
          }
          else {
            uVar5 = uVar5 & 0xffffff00 | uVar6 & 0xfe;
          }
        }
        *puVar10 = uVar5;
        FUN_0040117d(iVar9);
        param_3 = (HDC)(iVar9 + 1);
        param_4 = (HWND)(~DAT_0047aefc >> 8 & 1);
        param_2 = 0x40f;
      }
    }
    if (local_10 != (HWND)0x0) {
      if (local_10[2].unused == -0x1c3) {
        SendMessageW(local_8,0x419,0,local_10[0x17].unused);
      }
      if (local_10[2].unused == -0x1c7) {
        if (local_10[3].unused == 2) {
          puVar10 = (uint *)(local_10[0x17].unused * 0x4018 + 8 + local_14);
          *puVar10 = *puVar10 | 0x20;
        }
        else {
          puVar10 = (uint *)(local_10[0x17].unused * 0x4018 + 8 + local_14);
          *puVar10 = *puVar10 & 0xffffffdf;
        }
      }
    }
  }
  if (param_2 == 0x111) {
    if ((((short)param_3 != 0x3f9) || ((short)((uint)param_3 >> 0x10) != 1)) ||
       (WVar3 = SendMessageW(local_c,0x147,0,0), WVar3 == 0xffffffff)) goto LAB_00405281;
    uVar5 = SendMessageW(local_c,0x150,WVar3,0);
    if ((uVar5 == 0xffffffff) || (*(int *)(local_18 + uVar5 * 4) == 0)) {
      uVar5 = 0x20;
    }
    FUN_00401299(uVar5);
    SendMessageW(param_1,0x420,0,uVar5);
    param_3 = (HDC)0xffffffff;
    param_4 = (HWND)0x0;
    param_2 = 0x40f;
  }
  if (param_2 == 0x200) {
    SendMessageW(local_8,0x200,0,0);
  }
  if (param_2 == 0x40b) {
    if (DAT_0045022c != (HIMAGELIST)0x0) {
      ImageList_Destroy(DAT_0045022c);
    }
    if (DAT_00450240 != (HGLOBAL)0x0) {
      GlobalFree(DAT_00450240);
    }
    DAT_0045022c = (HIMAGELIST)0x0;
    DAT_00450240 = (HGLOBAL)0x0;
    _DAT_0047af60 = (HWND)0x0;
  }
  if (param_2 == 0x40f) {
    FUN_004011ef(0,0);
    if (param_3 != (HDC)0x0) {
      pHVar7 = param_3;
      if (param_3 != (HDC)0xffffffff) {
        pHVar7 = (HDC)((int)&param_3[-1].unused + 3);
      }
      FUN_00404c6c(8,pHVar7);
    }
    if (param_4 != (HWND)0x0) {
      param_4 = (HWND)FUN_004012e2((int)DAT_00450240);
      FUN_00401299((uint)param_4);
      iVar9 = 0;
      WVar3 = 0;
      if (0 < (int)param_4) {
        do {
          if (*(int *)(local_18 + iVar9 * 4) != 0) {
            WVar3 = WVar3 + 1;
          }
          iVar9 = iVar9 + 1;
        } while (iVar9 < (int)param_4);
      }
      SendMessageW(local_c,0x14e,WVar3,0);
      param_2 = 0x420;
    }
    FUN_004011ef(0,0);
    local_20 = DAT_00450240;
    local_3c = (uint *)0xf030;
    local_14 = 0;
    if (0 < DAT_0047af2c) {
      puVar10 = (uint *)(DAT_0047af28 + 8);
      do {
        uVar5 = *(uint *)((int)local_20 + local_14 * 4);
        if (uVar5 != 0) {
          uVar6 = *puVar10;
          local_48 = 8;
          if ((uVar6 & 0x100) != 0) {
            local_38 = puVar10 + 4;
            local_48 = 9;
            *(byte *)((int)puVar10 + 1) = *(byte *)((int)puVar10 + 1) & 0xfe;
          }
          if ((uVar6 & 0x40) == 0) {
            iVar9 = (uVar6 & 1) + 1;
            if ((uVar6 & 0x10) != 0) {
              iVar9 = (uVar6 & 1) + 4;
            }
          }
          else {
            iVar9 = 3;
          }
          local_40 = (iVar9 << 0xb | uVar6 & 8) * 2 | uVar6 & 0x20;
          local_44 = uVar5;
          SendMessageW(local_8,0x1102,((int)uVar6 >> 5 & 1U) + 1,uVar5);
          SendMessageW(local_8,0x113f,0,(LPARAM)&local_48);
        }
        local_14 = local_14 + 1;
        puVar10 = puVar10 + 0x1006;
      } while (local_14 < DAT_0047af2c);
    }
    InvalidateRect(local_8,(RECT *)0x0,1);
    if (*(int *)(DAT_00472ebc + 0x10) != 0) {
      uVar5 = FUN_00404bbf(5);
      FUN_00404ba7(0x3ff,-5,uVar5);
    }
  }
  if ((param_2 == 0x420) && ((DAT_0047aefc & 0x100) != 0)) {
    iVar9 = (uint)(param_4 == (HWND)0x20) << 3;
    ShowWindow(local_8,iVar9);
    pHVar8 = GetDlgItem(param_1,0x3fe);
    ShowWindow(pHVar8,iVar9);
  }
LAB_00405281:
  FUN_00404298(param_2,param_3,param_4);
  return;
}

/* Function: FUN_00405296 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

LRESULT FUN_00405296(HWND param_1,UINT param_2,WPARAM param_3,int param_4)

{
  BOOL BVar1;
  LRESULT LVar2;
  
  if (param_2 == 0x102) {
    if (param_3 == 0x20) {
      FUN_0040427d(0x413);
      return 0;
    }
  }
  else {
    if (param_2 == 0x200) {
      BVar1 = IsWindowVisible(param_1);
      if (BVar1 == 0) goto LAB_00405308;
      param_4 = FUN_00404bec(param_1,1);
      param_2 = 0x419;
    }
    if ((param_2 == 0x419) && (_DAT_00450234 != param_4)) {
      _DAT_00450234 = param_4;
      FUN_00404c6c(6,param_4);
    }
  }
LAB_00405308:
  LVar2 = CallWindowProcW(DAT_0045023c,param_1,param_2,param_3,param_4);
  return LVar2;
}

/* Function: FUN_00405322 */
void FUN_00405322(int param_1,LPCWSTR param_2)

{
  int iVar1;
  int iVar2;
  LRESULT LVar3;
  uint uVar4;
  undefined4 local_34;
  WPARAM local_30;
  undefined4 local_2c;
  undefined *local_20;
  uint local_c;
  HWND local_8;
  
  local_8 = DAT_00472ec4;
  if (DAT_00472ec4 != (HWND)0x0) {
    local_c = DAT_0047afb4;
    uVar4 = DAT_0047afb4 & 1;
    if (uVar4 == 0) {
      FUN_004062dc((LPWSTR)&DAT_00448228,param_1);
    }
    iVar1 = lstrlenW((LPCWSTR)&DAT_00448228);
    if (param_2 != (LPCWSTR)0x0) {
      iVar2 = lstrlenW(param_2);
      if (0x7fff < (uint)(iVar2 + iVar1)) {
        return;
      }
      lstrcatW((LPWSTR)&DAT_00448228,param_2);
    }
    if ((local_c & 4) == 0) {
      SetWindowTextW(DAT_00472ea8,(LPCWSTR)&DAT_00448228);
    }
    if ((local_c & 2) == 0) {
      local_20 = &DAT_00448228;
      local_34 = 1;
      LVar3 = SendMessageW(local_8,0x1004,0,0);
      local_30 = LVar3 - uVar4;
      local_2c = 0;
      SendMessageW(local_8,0x104d - uVar4,0,(LPARAM)&local_34);
      SendMessageW(local_8,0x1013,local_30,0);
    }
    if (uVar4 != 0) {
      *(undefined2 *)(&DAT_00448228 + iVar1 * 2) = 0;
    }
  }
  return;
}

/* Function: FUN_004053f5 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

int FUN_004053f5(HWND param_1)

{
  uint uVar1;
  int iVar2;
  int *piVar3;
  int iVar4;
  
  iVar4 = DAT_0047af2c;
  iVar2 = DAT_0047af28;
  uVar1 = OleInitialize((LPVOID)0x0);
  _DAT_0047afb8 = _DAT_0047afb8 | uVar1;
  FUN_0040427d(0);
  if (iVar4 != 0) {
    piVar3 = (int *)(iVar2 + 0xc);
    do {
      iVar4 = iVar4 + -1;
      if (((*(byte *)(piVar3 + -1) & 1) != 0) && (iVar2 = FUN_00401389(*piVar3,param_1), iVar2 != 0)
         ) {
        DAT_0047af8c = DAT_0047af8c + 1;
        break;
      }
      piVar3 = piVar3 + 0x1006;
    } while (iVar4 != 0);
  }
  FUN_0040427d(0x404);
  OleUninitialize();
  return DAT_0047af8c;
}

/* Function: FUN_00405461 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

COLORREF FUN_00405461(HWND param_1,int param_2,HDC param_3,HWND param_4)

{
  HWND pHVar1;
  HWND lpParameter;
  HANDLE hObject;
  HMENU hMenu;
  LPCWSTR lpNewItem;
  int iVar2;
  BOOL BVar3;
  LRESULT LVar4;
  HGLOBAL hMem;
  undefined2 *puVar5;
  COLORREF CVar6;
  int y;
  WPARAM wParam;
  int iVar7;
  DWORD dwCreationFlags;
  DWORD *lpThreadId;
  undefined local_44 [8];
  undefined4 local_3c;
  undefined4 local_38;
  int local_34;
  undefined2 *local_30;
  undefined4 local_2c;
  undefined4 local_28;
  undefined4 local_24;
  undefined4 uStack_20;
  tagRECT local_1c;
  DWORD local_c;
  HWND local_8;
  
  pHVar1 = DAT_00472ec4;
  wParam = 0;
  local_8 = DAT_00472ec4;
  if (param_2 == 0x110) {
    local_34 = 0xffffffff;
    local_28 = 0xffffffff;
    local_3c = 2;
    local_38 = 0;
    local_30 = (undefined2 *)0x0;
    local_2c = 0;
    local_24 = 0;
    uStack_20 = 0;
    iVar7 = *(int *)(DAT_0047aef4 + 0x5c);
    iVar2 = *(int *)(DAT_0047aef4 + 0x60);
    DAT_00472eb0 = GetDlgItem(param_1,0x403);
    DAT_00472ea8 = GetDlgItem(param_1,0x3ee);
    DAT_00472ec4 = GetDlgItem(param_1,0x3f8);
    local_8 = DAT_00472ec4;
    FUN_00404266((WPARAM)DAT_00472eb0);
    DAT_00472eb4 = FUN_00404bbf(4);
    DAT_00472ecc = 0;
    GetClientRect(local_8,&local_1c);
    local_34 = GetSystemMetrics(2);
    local_34 = local_1c.right - local_34;
    SendMessageW(local_8,0x1061,0,(LPARAM)&local_3c);
    SendMessageW(local_8,0x1036,0x4000,0x4000);
    if (-1 < iVar7) {
      SendMessageW(local_8,0x1001,0,iVar7);
      SendMessageW(local_8,0x1026,0,iVar7);
    }
    if (-1 < iVar2) {
      SendMessageW(local_8,0x1024,0,iVar2);
    }
    FUN_00404231(param_1,0x1b,param_4[0xc].unused);
    if (((byte)DAT_0047aefc & 3) != 0) {
      ShowWindow(DAT_00472eb0,0);
      if (((byte)DAT_0047aefc & 2) == 0) {
        ShowWindow(local_8,8);
      }
      else {
        DAT_00472eb0 = (HWND)0x0;
      }
      FUN_00404266((WPARAM)DAT_00472ea8);
    }
    pHVar1 = GetDlgItem(param_1,0x3ec);
    SendMessageW(pHVar1,0x401,0,0x75300000);
    if (((byte)DAT_0047aefc & 4) != 0) {
      SendMessageW(pHVar1,0x409,0,iVar2);
      SendMessageW(pHVar1,0x2001,0,iVar7);
    }
LAB_004057ea:
    CVar6 = 0;
  }
  else {
    if (param_2 == 0x405) {
      lpThreadId = &local_c;
      dwCreationFlags = 0;
      lpParameter = GetDlgItem(param_1,0x3ec);
      hObject = CreateThread((LPSECURITY_ATTRIBUTES)0x0,0,FUN_004053f5,lpParameter,dwCreationFlags,
                             lpThreadId);
      CloseHandle(hObject);
    }
    if (param_2 == 0x111) {
      if ((short)param_3 == 0x403) {
        ShowWindow(DAT_00472eb0,0);
        ShowWindow(pHVar1,8);
        FUN_00404266((WPARAM)pHVar1);
        goto LAB_00405667;
      }
    }
    else {
LAB_00405667:
      iVar7 = 1;
      if (param_2 == 0x404) {
        if (_DAT_00472eac != 0) {
          DAT_00444218 = 2;
          FUN_0040420a(0x78);
          goto LAB_0040568c;
        }
        ShowWindow(DAT_0047aee8,8);
        if (DAT_0047af8c == 0) {
          FUN_00405322(*(int *)(DAT_00448220 + 0x34),(LPCWSTR)0x0);
        }
        FUN_0040420a(1);
      }
      if ((param_2 == 0x7b) && (param_3 == (HDC)local_8)) {
        pHVar1 = (HWND)SendMessageW(local_8,0x1004,0,0);
        if (0 < (int)pHVar1) {
          hMenu = CreatePopupMenu();
          lpNewItem = (LPCWSTR)FUN_004062dc((LPWSTR)0x0,-0x1f);
          AppendMenuW(hMenu,0,1,lpNewItem);
          iVar2 = (int)(short)param_4;
          y = (int)(short)((uint)param_4 >> 0x10);
          if (param_4 == (HWND)0xffffffff) {
            GetWindowRect(local_8,&local_1c);
            iVar2 = local_1c.left;
            y = local_1c.top;
          }
          BVar3 = TrackPopupMenu(hMenu,0x180,iVar2,y,0,param_1,(RECT *)0x0);
          if (BVar3 == 1) {
            local_3c = 0;
            local_30 = (undefined2 *)&DAT_00450248;
            local_2c = 0x8000;
            param_1 = pHVar1;
            do {
              param_1 = (HWND)((int)&param_1[-1].unused + 3);
              LVar4 = SendMessageW(local_8,0x1073,(WPARAM)param_1,(LPARAM)local_44);
              iVar7 = iVar7 + 2 + LVar4;
            } while (param_1 != (HWND)0x0);
            OpenClipboard((HWND)0x0);
            EmptyClipboard();
            hMem = GlobalAlloc(0x42,iVar7 * 2);
            puVar5 = (undefined2 *)GlobalLock(hMem);
            do {
              local_30 = puVar5;
              LVar4 = SendMessageW(local_8,0x1073,wParam,(LPARAM)local_44);
              puVar5 = puVar5 + LVar4;
              *puVar5 = 0xd;
              puVar5[1] = 10;
              puVar5 = puVar5 + 2;
              wParam = wParam + 1;
            } while ((int)wParam < (int)pHVar1);
            GlobalUnlock(hMem);
            SetClipboardData(0xd,hMem);
            CloseClipboard();
          }
        }
        goto LAB_004057ea;
      }
    }
LAB_0040568c:
    CVar6 = FUN_00404298(param_2,param_3,param_4);
  }
  return CVar6;
}

/* Function: FUN_004057f1 */
DWORD FUN_004057f1(LPCWSTR param_1)

{
  BOOL BVar1;
  DWORD DVar2;
  undefined local_24;
  undefined local_23;
  undefined2 local_22;
  undefined *local_20;
  undefined *local_1c;
  undefined4 local_18;
  undefined *local_14;
  _SECURITY_ATTRIBUTES local_10;
  
  local_23 = 0;
  local_20 = &DAT_004083f0;
  local_1c = &DAT_004083f0;
  local_10.lpSecurityDescriptor = &local_24;
  local_18 = 0;
  local_10.bInheritHandle = 0;
  local_24 = 1;
  local_22 = 4;
  local_14 = &DAT_004083e0;
  local_10.nLength = 0xc;
  BVar1 = CreateDirectoryW(param_1,&local_10);
  if (BVar1 == 0) {
    DVar2 = GetLastError();
    if (DVar2 != 0xb7) {
      return DVar2;
    }
    BVar1 = SetFileSecurityW(param_1,0x80000007,&local_24);
    if (BVar1 == 0) {
      DVar2 = GetLastError();
      return DVar2;
    }
  }
  return 0;
}

/* Function: FUN_0040586e */
DWORD FUN_0040586e(LPCWSTR param_1)

{
  BOOL BVar1;
  DWORD DVar2;
  
  BVar1 = CreateDirectoryW(param_1,(LPSECURITY_ATTRIBUTES)0x0);
  if (BVar1 == 0) {
    DVar2 = GetLastError();
  }
  else {
    DVar2 = 0;
  }
  return DVar2;
}

/* Function: FUN_0040588b */
undefined4 FUN_0040588b(void)

{
  FARPROC pFVar1;
  int iVar2;
  
  pFVar1 = FUN_00406694(5);
  if (pFVar1 != (FARPROC)0x0) {
    iVar2 = (*pFVar1)();
    if (iVar2 != 0) {
      return 1;
    }
  }
  return 0;
}

/* Function: FUN_004058a3 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

HANDLE FUN_004058a3(LPWSTR param_1)

{
  HANDLE pvVar1;
  _PROCESS_INFORMATION local_14;
  
  _DAT_00468250 = 0x44;
  pvVar1 = (HANDLE)CreateProcessW((LPCWSTR)0x0,param_1,(LPSECURITY_ATTRIBUTES)0x0,
                                  (LPSECURITY_ATTRIBUTES)0x0,0,0x4000000,(LPVOID)0x0,(LPCWSTR)0x0,
                                  (LPSTARTUPINFOW)&DAT_00468250,&local_14);
  if (pvVar1 != (HANDLE)0x0) {
    CloseHandle(local_14.hThread);
    pvVar1 = local_14.hProcess;
  }
  return pvVar1;
}

/* Function: FUN_004058e6 */
void FUN_004058e6(SHELLEXECUTEINFOW *param_1)

{
  param_1->lpIDList = (void *)0x0;
  param_1->cbSize = 0x3c;
  ShellExecuteExW(param_1);
  return;
}

/* Function: USER32.DLL::SetDlgItemTextW */
BOOL SetDlgItemTextW(HWND hDlg,int nIDDlgItem,LPCWSTR lpString)

{
  BOOL BVar1;
  
                    /* WARNING: Could not recover jumptable at 0x004058fe. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  BVar1 = SetDlgItemTextW(hDlg,nIDDlgItem,lpString);
  return BVar1;
}

/* Function: FUN_00405904 */
void FUN_00405904(int param_1,LPWSTR param_2)

{
  GetDlgItemTextW(DAT_00472eb8,param_1,param_2,0x2000);
  return;
}

/* Function: FUN_00405920 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_00405920(undefined4 param_1,uint param_2)

{
  uint uVar1;
  
  uVar1 = param_2 & 0x1fffff;
  if ((_DAT_0047afa0 == 0) || (param_2 >> 0x15 == 0)) {
    if (_DAT_0047afa8 != 0) {
      uVar1 = uVar1 ^ 0x180000;
    }
    _DAT_0040a3bc = DAT_0047aee8;
    _DAT_0040a3c0 = DAT_0047aee0;
    _DAT_0040a3c4 = param_1;
    _DAT_0040a3c8 = &DAT_00472ee0;
    _DAT_0040a3cc = uVar1;
    MessageBoxIndirectW((MSGBOXPARAMSW *)&DAT_0040a3b8);
  }
  return;
}

/* Function: FUN_00405984 */
undefined4 FUN_00405984(LPCWSTR param_1,byte param_2)

{
  DWORD dwFileAttributes;
  int iVar1;
  
  dwFileAttributes = FUN_00405d8b(param_1);
  if (dwFileAttributes != 0xffffffff) {
    if ((param_2 & 1) == 0) {
      iVar1 = DeleteFileW(param_1);
    }
    else {
      iVar1 = RemoveDirectoryW(param_1);
    }
    if (iVar1 != 0) {
      return 1;
    }
    if ((param_2 & 4) == 0) {
      SetFileAttributesW(param_1,dwFileAttributes);
    }
  }
  return 0;
}

/* Function: FUN_004059cc */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_004059cc(LPCWSTR param_1,uint param_2)

{
  uint uVar1;
  bool bVar2;
  undefined3 extraout_var;
  BOOL BVar3;
  int iVar4;
  HANDLE hFindFile;
  int iVar5;
  undefined *puVar6;
  byte local_25c;
  WCHAR local_230;
  WCHAR local_22e;
  WCHAR local_22c;
  int local_c;
  uint local_8;
  
  local_8 = param_2 & 4;
  bVar2 = FUN_00405c97(param_1);
  local_c = CONCAT31(extraout_var,bVar2);
  if ((param_2 & 8) == 0) {
    uVar1 = param_2 & 1;
    if ((uVar1 == 0) || ((local_c != 0 && ((param_2 & 2) != 0)))) {
      FUN_004062ba((LPWSTR)&DAT_00460250,param_1);
      if (uVar1 == 0) {
        FUN_00405bdb(param_1);
      }
      else {
        lstrcatW((LPWSTR)&DAT_00460250,u______0040a54c);
      }
      if ((*param_1 != L'\0') || (_DAT_00460250 == 0x5c)) {
        lstrcatW(param_1,(LPCWSTR)&DAT_0040a014);
      }
      iVar4 = lstrlenW(param_1);
      hFindFile = FindFirstFileW((LPCWSTR)&DAT_00460250,(LPWIN32_FIND_DATAW)&local_25c);
      if (hFindFile != (HANDLE)0xffffffff) {
        do {
          if ((local_230 != L'.') ||
             ((local_22e != L'\0' && ((local_22e != L'.' || (local_22c != L'\0')))))) {
            FUN_004062ba(param_1 + iVar4,&local_230);
            if ((local_25c & 0x10) == 0) {
              iVar5 = FUN_00405984(param_1,(byte)local_8);
              if (iVar5 == 0) {
                if (local_8 == 0) {
                  _DAT_0047af88 = _DAT_0047af88 + 1;
                }
                else {
                  FUN_00405322(-0xf,param_1);
                  FUN_00406080(param_1,(LPCWSTR)0x0);
                }
              }
              else {
                FUN_00405322(-0xe,param_1);
              }
            }
            else if (((byte)param_2 & 3) == 3) {
              FUN_004059cc(param_1,param_2);
            }
          }
          BVar3 = FindNextFileW(hFindFile,(LPWIN32_FIND_DATAW)&local_25c);
        } while (BVar3 != 0);
        FindClose(hFindFile);
      }
      if (uVar1 != 0) {
        (param_1 + iVar4)[-1] = L'\0';
      }
    }
    if (uVar1 != 0) {
      if (local_c != 0) {
        puVar6 = FUN_004065fd(param_1);
        if (puVar6 == (undefined *)0x0) {
          return;
        }
        FUN_00405b8f(param_1);
        iVar4 = FUN_00405984(param_1,(byte)local_8 | 1);
        if (iVar4 != 0) {
          FUN_00405322(-0x1b,param_1);
          return;
        }
        if (local_8 != 0) {
          FUN_00405322(-0xf,param_1);
          FUN_00406080(param_1,(LPCWSTR)0x0);
          return;
        }
      }
      _DAT_0047af88 = _DAT_0047af88 + 1;
    }
  }
  else {
    BVar3 = DeleteFileW(param_1);
    _DAT_0047af88 = _DAT_0047af88 + (uint)(BVar3 == 0);
  }
  return;
}

/* Function: FUN_00405b8f */
LPCWSTR FUN_00405b8f(LPCWSTR param_1)

{
  int iVar1;
  LPWSTR pWVar2;
  
  iVar1 = lstrlenW(param_1);
  pWVar2 = CharPrevW(param_1,param_1 + iVar1);
  if (*pWVar2 != L'\\') {
    lstrcatW(param_1,(LPCWSTR)&DAT_0040a014);
  }
  return param_1;
}

/* Function: FUN_00405bbc */
void FUN_00405bbc(LPCWSTR param_1,WCHAR param_2)

{
  for (; (*param_1 != L'\0' && (*param_1 != param_2)); param_1 = CharNextW(param_1)) {
  }
  return;
}

/* Function: FUN_00405bdb */
LPCWSTR FUN_00405bdb(LPCWSTR param_1)

{
  int iVar1;
  LPCWSTR lpszCurrent;
  
  iVar1 = lstrlenW(param_1);
  lpszCurrent = param_1 + iVar1;
  do {
    if (*lpszCurrent == L'\\') break;
    lpszCurrent = CharPrevW(param_1,lpszCurrent);
  } while (param_1 < lpszCurrent);
  *lpszCurrent = L'\0';
  return lpszCurrent + 1;
}

/* Function: FUN_00405c06 */
undefined4 FUN_00405c06(ushort *param_1)

{
  ushort uVar1;
  undefined4 uVar2;
  
  uVar1 = *param_1 | 0x20;
  if (((*param_1 == 0x5c) && (param_1[1] == 0x5c)) ||
     ((0x60 < uVar1 && ((uVar1 < 0x7b && (param_1[1] == 0x3a)))))) {
    uVar2 = 1;
  }
  else {
    uVar2 = 0;
  }
  return uVar2;
}

/* Function: FUN_00405c3a */
LPWSTR FUN_00405c3a(LPCWSTR param_1)

{
  LPWSTR lpsz;
  LPWSTR lpsz_00;
  short *psVar1;
  int iVar2;
  
  lpsz = CharNextW(param_1);
  lpsz_00 = CharNextW(lpsz);
  if (((*param_1 == L'\0') || (*lpsz != L':')) || (lpsz[1] != L'\\')) {
    if ((*param_1 == L'\\') && (param_1[1] == L'\\')) {
      iVar2 = 2;
      do {
        iVar2 = iVar2 + -1;
        psVar1 = (short *)FUN_00405bbc(lpsz_00,L'\\');
        if (*psVar1 == 0) goto LAB_00405c8f;
        lpsz_00 = psVar1 + 1;
      } while (iVar2 != 0);
    }
    else {
LAB_00405c8f:
      lpsz_00 = (LPWSTR)0x0;
    }
  }
  else {
    lpsz_00 = CharNextW(lpsz_00);
  }
  return lpsz_00;
}

/* Function: FUN_00405c97 */
bool FUN_00405c97(LPCWSTR param_1)

{
  LPWSTR pWVar1;
  byte *pbVar2;
  int iVar3;
  DWORD DVar4;
  
  FUN_004062ba((LPWSTR)&DAT_00464250,param_1);
  pWVar1 = FUN_00405c3a((LPCWSTR)&DAT_00464250);
  if ((pWVar1 != (LPWSTR)0x0) &&
     ((FUN_0040654e(pWVar1), ((byte)DAT_0047aefc & 0x80) == 0 ||
      ((*pWVar1 != L'\0' && (*pWVar1 != L'\\')))))) {
    while( true ) {
      iVar3 = lstrlenW((LPCWSTR)&DAT_00464250);
      if (iVar3 <= (int)(pWVar1 + -0x232128) >> 1) {
        FUN_00405b8f((LPCWSTR)&DAT_00464250);
        DVar4 = GetFileAttributesW((LPCWSTR)&DAT_00464250);
        return DVar4 != 0xffffffff;
      }
      pbVar2 = FUN_004065fd((LPCWSTR)&DAT_00464250);
      if ((pbVar2 != (byte *)0x0) && ((*pbVar2 & 0x10) == 0)) break;
      FUN_00405bdb((LPCWSTR)&DAT_00464250);
    }
  }
  return false;
}

/* Function: FUN_00405d15 */
LPCSTR FUN_00405d15(LPSTR param_1,LPCSTR param_2)

{
  CHAR CVar1;
  int iVar2;
  int iVar3;
  
  iVar2 = lstrlenA(param_2);
  while( true ) {
    iVar3 = lstrlenA(param_1);
    if (iVar3 < iVar2) {
      return (LPCSTR)0x0;
    }
    CVar1 = param_1[iVar2];
    param_1[iVar2] = '\0';
    iVar3 = lstrcmpiA(param_1,param_2);
    param_1[iVar2] = CVar1;
    if (iVar3 == 0) break;
    param_1 = CharNextA(param_1);
  }
  return param_1;
}

/* Function: FUN_00405d6b */
void FUN_00405d6b(undefined *param_1,int param_2,int param_3)

{
  int iVar1;
  
  if (param_3 != 0) {
    iVar1 = param_2 - (int)param_1;
    do {
      *param_1 = param_1[iVar1];
      param_1 = param_1 + 1;
      param_3 = param_3 + -1;
    } while (param_3 != 0);
  }
  return;
}

/* Function: FUN_00405d8b */
DWORD FUN_00405d8b(LPCWSTR param_1)

{
  DWORD DVar1;
  
  DVar1 = GetFileAttributesW(param_1);
  if (DVar1 != 0xffffffff) {
    SetFileAttributesW(param_1,DVar1 & 0xfffffffe);
  }
  return DVar1;
}

/* Function: FUN_00405db0 */
void FUN_00405db0(LPCWSTR param_1,DWORD param_2,DWORD param_3)

{
  DWORD DVar1;
  
  DVar1 = GetFileAttributesW(param_1);
  CreateFileW(param_1,param_2,1,(LPSECURITY_ATTRIBUTES)0x0,param_3,
              -(uint)(DVar1 != 0xffffffff) & DVar1,(HANDLE)0x0);
  return;
}

/* Function: FUN_00405ddf */
/* WARNING: Could not reconcile some variable overlaps */

LPWSTR FUN_00405ddf(LPWSTR param_1,LPCWSTR param_2)

{
  DWORD DVar1;
  UINT UVar2;
  int iVar3;
  undefined4 local_c;
  uint local_8;
  
  iVar3 = 100;
  do {
    iVar3 = iVar3 + -1;
    local_c = DAT_0040a558;
    local_8 = DAT_0040a55c;
    DVar1 = GetTickCount();
    local_8 = local_8 & 0xffff0000 | (uint)(ushort)((short)local_8 + (short)(DVar1 % 0x1a));
    UVar2 = GetTempFileNameW(param_2,(LPCWSTR)&local_c,0,param_1);
    if (UVar2 != 0) {
      return param_1;
    }
  } while (iVar3 != 0);
  *param_1 = L'\0';
  return (LPWSTR)0x0;
}

/* Function: FUN_00405e33 */
undefined4 FUN_00405e33(HANDLE param_1,LPVOID param_2,DWORD param_3)

{
  DWORD DVar1;
  BOOL BVar2;
  undefined4 uVar3;
  
  DVar1 = param_3;
  BVar2 = ReadFile(param_1,param_2,param_3,&param_3,(LPOVERLAPPED)0x0);
  if ((BVar2 == 0) || (DVar1 != param_3)) {
    uVar3 = 0;
  }
  else {
    uVar3 = 1;
  }
  return uVar3;
}

/* Function: FUN_00405e62 */
undefined4 FUN_00405e62(HANDLE param_1,LPCVOID param_2,DWORD param_3)

{
  DWORD DVar1;
  BOOL BVar2;
  undefined4 uVar3;
  
  DVar1 = param_3;
  BVar2 = WriteFile(param_1,param_2,param_3,&param_3,(LPOVERLAPPED)0x0);
  if ((BVar2 == 0) || (DVar1 != param_3)) {
    uVar3 = 0;
  }
  else {
    uVar3 = 1;
  }
  return uVar3;
}

/* Function: FUN_00405e91 */
int FUN_00405e91(HANDLE param_1,int param_2)

{
  HANDLE hFile;
  DWORD DVar1;
  int iVar2;
  
  hFile = param_1;
  DVar1 = SetFilePointer(param_1,0,(PLONG)0x0,1);
  if (DVar1 == 0) {
    iVar2 = FUN_00405e33(hFile,(LPVOID)((int)&param_1 + 2),2);
    if ((iVar2 != 0) && (param_1._2_2_ == -0x101)) {
      return 0;
    }
    if ((param_2 != 0) && (DVar1 = SetFilePointer(hFile,0,(PLONG)0x0,1), DVar1 == 0)) {
      iVar2 = FUN_00405e62(hFile,&DAT_00408414,2);
      return (-(uint)(iVar2 != 0) & 0x7fffbffb) + 0x80004005;
    }
    SetFilePointer(hFile,0,(PLONG)0x0,0);
  }
  return 1;
}

/* Function: FUN_00405f06 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void __cdecl FUN_00405f06(LPCWSTR param_1,LPCWSTR param_2)

{
  HANDLE pvVar1;
  DWORD DVar2;
  int iVar3;
  LPCSTR pCVar4;
  LPSTR hMem;
  int iVar5;
  LPCSTR pCVar6;
  LPCSTR pCVar7;
  CHAR *pCVar8;
  LPSTR pCVar9;
  
  _DAT_004688e8 = &DAT_0055004e;
  _DAT_004688ec = 0x4c;
  if (param_2 != (LPCWSTR)0x0) {
    pvVar1 = (HANDLE)FUN_00405db0(param_2,0,1);
    CloseHandle(pvVar1);
    DVar2 = GetShortPathNameW(param_2,(LPWSTR)&DAT_004688e8,0x400);
    if (DVar2 == 0) {
      return;
    }
    if (0x400 < (int)DVar2) {
      return;
    }
  }
  DVar2 = GetShortPathNameW(param_1,(LPWSTR)&DAT_004690e8,0x400);
  if ((DVar2 != 0) && ((int)DVar2 < 0x401)) {
    iVar3 = wsprintfA(&DAT_004684e8,s__ls__ls_0040a570,&DAT_004688e8,&DAT_004690e8);
    FUN_004062dc((LPWSTR)&DAT_004690e8,*(int *)(DAT_0047aef4 + 0x128));
    pvVar1 = (HANDLE)FUN_00405db0((LPCWSTR)&DAT_004690e8,0xc0000000,4);
    if (pvVar1 != (HANDLE)0xffffffff) {
      pCVar4 = (LPCSTR)GetFileSize(pvVar1,(LPDWORD)0x0);
      hMem = (LPSTR)GlobalAlloc(0x40,(SIZE_T)(pCVar4 + iVar3 + 10));
      if ((hMem != (LPSTR)0x0) && (iVar5 = FUN_00405e33(pvVar1,hMem,(DWORD)pCVar4), iVar5 != 0)) {
        pCVar6 = FUN_00405d15(hMem,s__Rename__0040a564);
        if (pCVar6 == (LPCSTR)0x0) {
          lstrcpyA(hMem + (int)pCVar4,s__Rename__0040a564);
          pCVar4 = pCVar4 + 10;
          pCVar6 = pCVar4;
        }
        else {
          pCVar7 = FUN_00405d15(pCVar6 + 10,&DAT_0040a560);
          pCVar6 = pCVar4;
          if (pCVar7 != (LPCSTR)0x0) {
            pCVar9 = hMem + (int)pCVar4;
            pCVar8 = pCVar9 + iVar3;
            for (; pCVar7 < pCVar9; pCVar9 = pCVar9 + -1) {
              *pCVar8 = *pCVar9;
              pCVar8 = pCVar8 + -1;
            }
            pCVar6 = pCVar7 + (1 - (int)hMem);
          }
        }
        FUN_00405d6b(hMem + (int)pCVar6,(int)&DAT_004684e8,iVar3);
        SetFilePointer(pvVar1,0,(PLONG)0x0,0);
        FUN_00405e62(pvVar1,hMem,(DWORD)(pCVar4 + iVar3));
        GlobalFree(hMem);
      }
      CloseHandle(pvVar1);
    }
  }
  return;
}

/* Function: FUN_00406080 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_00406080(LPCWSTR param_1,LPCWSTR param_2)

{
  BOOL BVar1;
  
  BVar1 = MoveFileExW(param_1,param_2,5);
  if (BVar1 == 0) {
    FUN_00405f06(param_1,param_2);
  }
  _DAT_0047af90 = _DAT_0047af90 + 1;
  return;
}

/* Function: FUN_004060ac */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

uint FUN_004060ac(uint param_1,uint *param_2)

{
  uint uVar1;
  uint uVar2;
  uint uVar3;
  
  uVar1 = *param_2;
  uVar3 = ~DAT_0047aeec >> 0x16 & 0x100;
  if (((uVar1 & 0x20) == 0) || ((param_1 & 0x60000000) == 0)) {
    if ((uVar1 & 0x100000) != 0) {
      uVar1 = uVar1 | _DAT_0047afb0;
    }
  }
  else {
    uVar2 = param_1 >> 0x15 & 0x300;
    if (uVar2 == 0x300) {
      uVar2 = ~uVar3 & _DAT_0047afb0;
    }
    uVar1 = (uVar1 & 0xfffffeff | uVar2) & 0xfffffdff;
    param_1 = param_1 & 0x9fffffff;
  }
  *param_2 = uVar1 & 0xffefffdf;
  return ~-(uint)((uVar1 & uVar3) != 0) & param_1;
}

/* Function: FUN_00406127 */
LSTATUS FUN_00406127(uint param_1,LPCWSTR param_2,REGSAM param_3,PHKEY param_4)

{
  HKEY hKey;
  LSTATUS LVar1;
  
  hKey = (HKEY)FUN_004060ac(param_1,&param_3);
  if (hKey == (HKEY)0x0) {
    LVar1 = 6;
  }
  else {
    LVar1 = RegOpenKeyExW(hKey,param_2,0,param_3,param_4);
  }
  return LVar1;
}

/* Function: FUN_00406155 */
LSTATUS FUN_00406155(uint param_1,LPCWSTR param_2,REGSAM param_3,PHKEY param_4)

{
  HKEY hKey;
  LSTATUS LVar1;
  
  hKey = (HKEY)FUN_004060ac(param_1,&param_3);
  if (hKey == (HKEY)0x0) {
    LVar1 = 6;
  }
  else {
    LVar1 = RegCreateKeyExW(hKey,param_2,0,(LPWSTR)0x0,0,param_3,(LPSECURITY_ATTRIBUTES)0x0,param_4,
                            (LPDWORD)0x0);
  }
  return LVar1;
}

/* Function: FUN_00406188 */
void FUN_00406188(uint param_1,LPCWSTR param_2,LPCWSTR param_3,undefined2 *param_4,HKEY param_5)

{
  undefined2 *puVar1;
  LSTATUS LVar2;
  DWORD local_8;
  
  local_8 = 0x4000;
  LVar2 = FUN_00406127(param_1,param_2,-(uint)(param_5 != (HKEY)0x0) & 0x100 | 0x20019,&param_5);
  puVar1 = param_4;
  if (LVar2 == 0) {
    LVar2 = RegQueryValueExW(param_5,param_3,(LPDWORD)0x0,(LPDWORD)&param_2,(LPBYTE)param_4,&local_8
                            );
    RegCloseKey(param_5);
    puVar1[0x1fff] = 0;
    if (LVar2 == 0) {
      if (param_2 == (LPCWSTR)0x1) {
        return;
      }
      if (param_2 == (LPCWSTR)0x2) {
        return;
      }
    }
  }
  *puVar1 = 0;
  return;
}

/* Function: FUN_00406201 */
void FUN_00406201(LPWSTR param_1,undefined4 param_2)

{
  wsprintfW(param_1,L"%d",param_2);
  return;
}

/* Function: FUN_0040621a */
int FUN_0040621a(ushort *param_1)

{
  ushort uVar1;
  ushort uVar2;
  ushort *puVar3;
  uint uVar4;
  int iVar5;
  uint uVar6;
  int local_c;
  int local_8;
  
  local_8 = 0;
  uVar2 = 10;
  local_c = 1;
  uVar6 = 0x39;
  if (*param_1 == 0x2d) {
    param_1 = param_1 + 1;
    local_c = -1;
  }
  puVar3 = param_1;
  if (*param_1 == 0x30) {
    puVar3 = param_1 + 1;
    uVar1 = *puVar3;
    if ((0x2f < uVar1) && (uVar1 < 0x38)) {
      uVar2 = 8;
      uVar6 = 0x37;
    }
    if ((uVar1 & 0xffdf) == 0x58) {
      uVar2 = 0x10;
      puVar3 = param_1 + 2;
    }
  }
  do {
    uVar4 = (uint)*puVar3;
    puVar3 = puVar3 + 1;
    if ((uVar4 < 0x30) || (uVar6 < uVar4)) {
      if ((uVar2 != 0x10) || (((uVar4 & 0xffffffdf) < 0x41 || (0x46 < (uVar4 & 0xffffffdf))))) {
        return local_c * local_8;
      }
      iVar5 = (uVar4 & 7) + 9;
    }
    else {
      iVar5 = uVar4 - 0x30;
    }
    local_8 = (uint)uVar2 * local_8 + iVar5;
  } while( true );
}

/* Function: FUN_004062ba */
void FUN_004062ba(LPWSTR param_1,LPCWSTR param_2)

{
  lstrcpynW(param_1,param_2,0x2000);
  return;
}

/* Function: KERNEL32.DLL::lstrlenW */
int lstrlenW(LPCWSTR lpString)

{
  int iVar1;
  
                    /* WARNING: Could not recover jumptable at 0x004062d0. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  iVar1 = lstrlenW(lpString);
  return iVar1;
}

/* Function: KERNEL32.DLL::lstrcatW */
LPWSTR lstrcatW(LPWSTR lpString1,LPCWSTR lpString2)

{
  LPWSTR pWVar1;
  
                    /* WARNING: Could not recover jumptable at 0x004062d6. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  pWVar1 = lstrcatW(lpString1,lpString2);
  return pWVar1;
}

/* Function: FUN_004062dc */
void FUN_004062dc(LPWSTR param_1,int param_2)

{
  byte bVar1;
  WCHAR WVar2;
  LPWSTR pWVar3;
  int iVar4;
  HRESULT HVar5;
  BOOL BVar6;
  WCHAR *pWVar7;
  uint uVar8;
  WCHAR *pWVar9;
  uint uVar10;
  LPWSTR lpBuffer;
  int iVar11;
  uint local_1c [4];
  LPCITEMIDLIST local_c;
  uint local_8;
  
  pWVar3 = param_1;
  if (param_2 < 0) {
    param_2 = *(int *)(DAT_00472ebc - (param_2 * 4 + 4));
  }
  pWVar9 = (WCHAR *)(DAT_0047af38 + param_2 * 2);
  lpBuffer = &DAT_0046ae80;
  if (((LPWSTR)0x46ae7f < param_1) && ((uint)((int)(param_1 + -0x235740) >> 1) < 0x4000)) {
    param_1 = (LPWSTR)0x0;
    lpBuffer = pWVar3;
  }
  do {
    while( true ) {
      WVar2 = *pWVar9;
      if ((WVar2 == L'\0') || (0x3fff < (int)((uint)(lpBuffer + -0x235740) & 0xfffffffe))) {
        *lpBuffer = L'\0';
        if (param_1 != (LPWSTR)0x0) {
          FUN_004062ba(param_1,&DAT_0046ae80);
        }
        return;
      }
      pWVar7 = pWVar9 + 1;
      if ((ushort)WVar2 < 4) break;
      if (WVar2 == L'\x04') {
        *lpBuffer = *pWVar7;
        lpBuffer = lpBuffer + 1;
        pWVar9 = pWVar9 + 2;
      }
      else {
        *lpBuffer = WVar2;
        lpBuffer = lpBuffer + 1;
        pWVar9 = pWVar7;
      }
    }
    bVar1 = *(byte *)pWVar7;
    local_1c[1] = (uint)bVar1;
    uVar8 = (*(byte *)((int)pWVar9 + 3) & 0x7f) << 7 | bVar1 & 0x7f;
    local_1c[0] = local_1c[1] | 0x8000;
    uVar10 = (uint)*(byte *)((int)pWVar9 + 3);
    local_1c[3] = uVar10;
    local_1c[2] = uVar10 | 0x8000;
    if (WVar2 == L'\x02') {
      iVar11 = 2;
      if ((((DAT_0047aeec < 0) && ((short)DAT_0047aeec != 0x5a04)) && (uVar10 != 0x23)) &&
         (uVar10 != 0x2e)) {
        local_8 = 0;
      }
      else {
        local_8 = 1;
      }
      if (DAT_0047af84 != 0) {
        iVar11 = 4;
      }
      if ((char)bVar1 < '\0') {
        FUN_00406188(0x80000002,L"Software\\Microsoft\\Windows\\CurrentVersion",
                     (LPCWSTR)(DAT_0047af38 + (local_1c[1] & 0x3f) * 2),lpBuffer,
                     (HKEY)(local_1c[1] & 0x40));
        if (*lpBuffer == L'\0') {
          FUN_004062dc(lpBuffer,uVar10);
          goto LAB_00406497;
        }
LAB_004064a0:
        if (uVar10 == 0x1a) {
          lstrcatW(lpBuffer,L"\\Microsoft\\Internet Explorer\\Quick Launch");
        }
      }
      else {
        if (local_1c[1] == 0x25) {
          GetSystemDirectoryW(lpBuffer,0x2000);
        }
        else {
          if (local_1c[1] == 0x24) {
            GetWindowsDirectoryW(lpBuffer,0x2000);
            iVar11 = 0;
          }
          while ((iVar11 != 0 &&
                 (((iVar11 = iVar11 + -1, DAT_0047aee4 == (code *)0x0 || (local_8 == 0)) ||
                  (iVar4 = (*DAT_0047aee4)(DAT_0047aee8,local_1c[iVar11],0,0,lpBuffer), iVar4 != 0))
                 ))) {
            HVar5 = SHGetSpecialFolderLocation(DAT_0047aee8,local_1c[iVar11],&local_c);
            if (HVar5 == 0) {
              BVar6 = SHGetPathFromIDListW(local_c,lpBuffer);
              CoTaskMemFree(local_c);
              if (BVar6 != 0) break;
            }
            *lpBuffer = L'\0';
          }
        }
LAB_00406497:
        uVar10 = local_1c[3];
        if (*lpBuffer != L'\0') goto LAB_004064a0;
      }
LAB_004064b0:
      FUN_0040654e(lpBuffer);
    }
    else {
      local_8 = uVar8;
      if (WVar2 == L'\x03') {
        if (uVar8 == 0x1d) {
          FUN_00406201(lpBuffer,DAT_0047aee8);
        }
        else {
          FUN_004062ba(lpBuffer,(LPCWSTR)(&DAT_0047b000 + uVar8 * 0x4000));
        }
        if (uVar8 - 0x15 < 7) goto LAB_004064b0;
      }
      else if (WVar2 == L'\x01') {
        FUN_004062dc(lpBuffer,-1 - uVar8);
      }
    }
    iVar11 = lstrlenW(lpBuffer);
    lpBuffer = lpBuffer + iVar11;
    pWVar9 = pWVar9 + 2;
  } while( true );
}

/* Function: FUN_0040654e */
void FUN_0040654e(LPCWSTR param_1)

{
  WCHAR WVar1;
  int iVar2;
  short *psVar3;
  LPWSTR pWVar4;
  LPCWSTR lpsz;
  LPCWSTR lpsz_00;
  
  if ((((*param_1 == L'\\') && (param_1[1] == L'\\')) && (param_1[2] == L'?')) &&
     (param_1[3] == L'\\')) {
    param_1 = param_1 + 4;
  }
  if ((*param_1 != L'\0') && (iVar2 = FUN_00405c06((ushort *)param_1), iVar2 != 0)) {
    param_1 = param_1 + 2;
  }
  WVar1 = *param_1;
  lpsz_00 = param_1;
  lpsz = param_1;
  while (WVar1 != L'\0') {
    if ((0x1f < (ushort)WVar1) &&
       (psVar3 = (short *)FUN_00405bbc(u__________0040a57c,WVar1), *psVar3 == 0)) {
      pWVar4 = CharNextW(lpsz_00);
      FUN_00405d6b((undefined *)lpsz,(int)lpsz_00,(int)pWVar4 - (int)lpsz_00 >> 1);
      lpsz = CharNextW(lpsz);
    }
    lpsz_00 = CharNextW(lpsz_00);
    WVar1 = *lpsz_00;
  }
  *lpsz = L'\0';
  while( true ) {
    lpsz = CharPrevW(param_1,lpsz);
    if ((*lpsz != L' ') && (*lpsz != L'\\')) break;
    *lpsz = L'\0';
    if (lpsz <= param_1) {
      return;
    }
  }
  return;
}

/* Function: FUN_004065fd */
undefined * FUN_004065fd(LPCWSTR param_1)

{
  HANDLE hFindFile;
  undefined *puVar1;
  
  hFindFile = FindFirstFileW(param_1,(LPWIN32_FIND_DATAW)&DAT_00468298);
  if (hFindFile == (HANDLE)0xffffffff) {
    puVar1 = (undefined *)0x0;
  }
  else {
    FindClose(hFindFile);
    puVar1 = &DAT_00468298;
  }
  return puVar1;
}

/* Function: FUN_00406624 */
void FUN_00406624(undefined4 param_1)

{
  UINT UVar1;
  int iVar2;
  WCHAR local_240 [286];
  
  UVar1 = GetSystemDirectoryW(local_240,0x104);
  if (0x104 < UVar1) {
    UVar1 = 0;
  }
  if ((UVar1 == 0) || (local_240[UVar1 - 1] == L'\\')) {
    iVar2 = 1;
  }
  else {
    iVar2 = 0;
  }
  wsprintfW(local_240 + UVar1,u__s_S_dll_0040a590,&DAT_0040a014 + iVar2 * 2,param_1);
  LoadLibraryExW(local_240,(HANDLE)0x0,8);
  return;
}

/* Function: FUN_00406694 */
FARPROC FUN_00406694(int param_1)

{
  LPCSTR lpModuleName;
  HMODULE hModule;
  FARPROC pFVar1;
  
  lpModuleName = (&PTR_s_KERNEL32_0040a3e0)[param_1 * 2];
  hModule = GetModuleHandleA(lpModuleName);
  if ((hModule == (HMODULE)0x0) &&
     (hModule = (HMODULE)FUN_00406624(lpModuleName), hModule == (HMODULE)0x0)) {
    return (FARPROC)0x0;
  }
  pFVar1 = GetProcAddress(hModule,(&PTR_s_SetDefaultDllDirectories_0040a3e4)[param_1 * 2]);
  return pFVar1;
}

/* Function: FUN_004066d0 */
void FUN_004066d0(UINT param_1)

{
  BOOL BVar1;
  MSG local_20;
  
  while( true ) {
    BVar1 = PeekMessageW(&local_20,(HWND)0x0,param_1,param_1,1);
    if (BVar1 == 0) break;
    DispatchMessageW(&local_20);
  }
  return;
}

/* Function: FUN_00406703 */
FARPROC FUN_00406703(HMODULE param_1,LPCWSTR param_2)

{
  int iVar1;
  FARPROC pFVar2;
  CHAR local_104 [256];
  
  iVar1 = WideCharToMultiByte(0,0,param_2,-1,local_104,0x100,(LPCSTR)0x0,(LPBOOL)0x0);
  if (iVar1 == 0) {
    pFVar2 = (FARPROC)0x0;
  }
  else {
    pFVar2 = GetProcAddress(param_1,local_104);
  }
  return pFVar2;
}

/* Function: FUN_00406745 */
DWORD FUN_00406745(HANDLE param_1)

{
  DWORD DVar1;
  DWORD local_8;
  
  DVar1 = WaitForSingleObject(param_1,100);
  while (DVar1 == 0x102) {
    FUN_004066d0(0xf);
    DVar1 = WaitForSingleObject(param_1,100);
  }
  GetExitCodeProcess(param_1,&local_8);
  return local_8;
}

/* Function: FUN_00406787 */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

uint FUN_00406787(uint param_1,byte *param_2,int param_3)

{
  uint uVar1;
  uint uVar2;
  int iVar3;
  
  if (_DAT_004698ec == 0) {
    uVar2 = 0;
    do {
      iVar3 = 8;
      uVar1 = uVar2;
      do {
        uVar1 = uVar1 >> 1 ^ -(uint)((uVar1 & 1) != 0) & 0xedb88320;
        iVar3 = iVar3 + -1;
      } while (iVar3 != 0);
      (&DAT_004698e8)[uVar2] = uVar1;
      uVar2 = uVar2 + 1;
    } while ((int)uVar2 < 0x100);
  }
  uVar2 = ~param_1;
  if (param_3 != 0) {
    do {
      uVar2 = uVar2 >> 8 ^ (&DAT_004698e8)[uVar2 & 0xff ^ (uint)*param_2];
      param_2 = param_2 + 1;
      param_3 = param_3 + -1;
    } while (param_3 != 0);
  }
  return ~uVar2;
}

/* Function: FUN_004067f5 */
/* WARNING: Could not reconcile some variable overlaps */

undefined4 FUN_004067f5(byte **param_1)

{
  byte **ppbVar1;
  byte bVar2;
  byte **ppbVar3;
  int *piVar4;
  byte *pbVar5;
  int iVar6;
  byte **ppbVar7;
  char cVar8;
  byte *pbVar9;
  byte *pbVar10;
  undefined4 uVar11;
  undefined4 *puVar12;
  byte *pbVar13;
  uint uVar14;
  uint uVar15;
  byte *local_44;
  byte *local_3c;
  byte *local_38;
  byte **local_34;
  byte *local_30;
  byte **local_24;
  byte *local_20;
  byte *local_1c;
  byte *local_18;
  uint local_14;
  uint local_10;
  byte **local_c;
  uint local_8;
  
  local_3c = *param_1;
  ppbVar1 = param_1 + 4;
  local_38 = param_1[1];
  local_34 = (byte **)param_1[0x26ee];
  pbVar10 = param_1[0x14a];
  local_44 = param_1[0x14b];
  if (local_34 < param_1[0x26ed]) {
    local_30 = (byte *)((int)param_1[0x26ed] + (-1 - (int)local_34));
  }
  else {
    local_30 = param_1[0x26ec] + -(int)local_34;
  }
LAB_00407209:
  do {
    switch(*ppbVar1) {
    case (byte *)0x0:
      goto switchD_00406846_caseD_0;
    case (byte *)0x1:
      goto switchD_00406846_caseD_1;
    case (byte *)0x2:
      pbVar5 = param_1[6];
      for (; pbVar10 < pbVar5; pbVar10 = pbVar10 + 8) {
        if (local_38 == (byte *)0x0) goto LAB_00407219;
        local_38 = local_38 + -1;
        local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
        local_3c = local_3c + 1;
      }
      param_1[5] = param_1[5] +
                   ((uint)*(ushort *)(&DAT_0040a5a4 + (int)pbVar5 * 2) & (uint)local_44);
      local_44 = (byte *)((uint)local_44 >> ((byte)pbVar5 & 0x1f));
      pbVar10 = pbVar10 + -(int)pbVar5;
      param_1[7] = (byte *)(uint)*(byte *)((int)param_1 + 0x21);
      param_1[6] = param_1[10];
      *ppbVar1 = (byte *)0x3;
    case (byte *)0x3:
      for (; pbVar10 < param_1[7]; pbVar10 = pbVar10 + 8) {
        if (local_38 == (byte *)0x0) goto LAB_00407219;
        local_38 = local_38 + -1;
        local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
        local_3c = local_3c + 1;
      }
      pbVar5 = param_1[6] +
               ((uint)*(ushort *)(&DAT_0040a5a4 + (int)param_1[7] * 2) & (uint)local_44) * 4;
      local_44 = (byte *)((uint)local_44 >> (pbVar5[1] & 0x1f));
      pbVar10 = pbVar10 + -(uint)pbVar5[1];
      bVar2 = *pbVar5;
      pbVar9 = (byte *)(uint)bVar2;
      if ((bVar2 & 0x10) == 0) {
        if ((bVar2 & 0x40) != 0) goto switchD_00406846_caseD_e;
LAB_00406fa7:
        param_1[7] = pbVar9;
        param_1[6] = pbVar5 + (uint)*(ushort *)(pbVar5 + 2) * 4;
      }
      else {
        param_1[6] = (byte *)((uint)pbVar9 & 0xf);
        param_1[7] = (byte *)(uint)*(ushort *)(pbVar5 + 2);
        *ppbVar1 = (byte *)0x4;
      }
      break;
    case (byte *)0x4:
      pbVar5 = param_1[6];
      for (; pbVar10 < pbVar5; pbVar10 = pbVar10 + 8) {
        if (local_38 == (byte *)0x0) goto LAB_00407219;
        local_38 = local_38 + -1;
        local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
        local_3c = local_3c + 1;
      }
      param_1[7] = param_1[7] +
                   ((uint)*(ushort *)(&DAT_0040a5a4 + (int)pbVar5 * 2) & (uint)local_44);
      local_44 = (byte *)((uint)local_44 >> ((byte)pbVar5 & 0x1f));
      pbVar10 = pbVar10 + -(int)pbVar5;
      *ppbVar1 = &DAT_00000005;
    case (byte *)0x5:
      pbVar5 = param_1[7];
      if ((byte *)((int)local_34 + (-0x1ba0 - (int)ppbVar1)) < pbVar5) {
        pbVar5 = param_1[0x26ec] + (-(int)ppbVar1 - (int)pbVar5) + -0x1ba0;
      }
      else {
        pbVar5 = (byte *)-(int)pbVar5;
      }
      local_24 = (byte **)(pbVar5 + (int)local_34);
      pbVar5 = param_1[5];
      ppbVar7 = local_34;
      while (local_34 = ppbVar7, pbVar5 != (byte *)0x0) {
        if (local_30 == (byte *)0x0) {
          if (ppbVar7 == (byte **)param_1[0x26ec]) {
            ppbVar3 = (byte **)param_1[0x26ed];
            local_34 = param_1 + 0x6ec;
            if (ppbVar3 != local_34) {
              if (local_34 < ppbVar3) {
                local_30 = (byte *)((int)ppbVar3 + (-1 - (int)local_34));
              }
              else {
                local_30 = (byte *)((int)param_1[0x26ec] - (int)local_34);
              }
              ppbVar7 = local_34;
              if (local_30 != (byte *)0x0) goto LAB_004070d1;
            }
          }
          param_1[0x26ee] = (byte *)ppbVar7;
          FUN_00407284((int)param_1);
          local_34 = (byte **)param_1[0x26ee];
          ppbVar7 = (byte **)param_1[0x26ed];
          if (local_34 < ppbVar7) {
            local_30 = (byte *)((int)ppbVar7 + (-1 - (int)local_34));
          }
          else {
            local_30 = param_1[0x26ec] + -(int)local_34;
          }
          local_c = (byte **)param_1[0x26ec];
          if ((local_34 == local_c) && (ppbVar3 = param_1 + 0x6ec, ppbVar7 != ppbVar3)) {
            local_34 = ppbVar3;
            if (ppbVar3 < ppbVar7) {
              local_30 = (byte *)((int)ppbVar7 + (-1 - (int)ppbVar3));
            }
            else {
              local_30 = (byte *)((int)local_c - (int)ppbVar3);
            }
          }
          if (local_30 == (byte *)0x0) goto LAB_00407235;
        }
LAB_004070d1:
        *(byte *)local_34 = *(byte *)local_24;
        ppbVar7 = (byte **)((int)local_34 + 1);
        local_24 = (byte **)((int)local_24 + 1);
        local_30 = local_30 + -1;
        if (local_24 == (byte **)param_1[0x26ec]) {
          local_24 = param_1 + 0x6ec;
        }
        ppbVar3 = param_1 + 5;
        *ppbVar3 = *ppbVar3 + -1;
        pbVar5 = *ppbVar3;
      }
LAB_004069c5:
      *ppbVar1 = (byte *)0x0;
      break;
    case (byte *)0x6:
      if (local_30 == (byte *)0x0) {
        if (local_34 == (byte **)param_1[0x26ec]) {
          ppbVar3 = (byte **)param_1[0x26ed];
          ppbVar7 = param_1 + 0x6ec;
          if (ppbVar3 != ppbVar7) {
            if (ppbVar7 < ppbVar3) {
              local_30 = (byte *)((int)ppbVar3 + (-1 - (int)ppbVar7));
            }
            else {
              local_30 = (byte *)((int)param_1[0x26ec] - (int)ppbVar7);
            }
            local_34 = ppbVar7;
            if (local_30 != (byte *)0x0) goto LAB_004071a2;
          }
        }
        param_1[0x26ee] = (byte *)local_34;
        FUN_00407284((int)param_1);
        local_34 = (byte **)param_1[0x26ee];
        ppbVar7 = (byte **)param_1[0x26ed];
        if (local_34 < ppbVar7) {
          local_30 = (byte *)((int)ppbVar7 + (-1 - (int)local_34));
        }
        else {
          local_30 = param_1[0x26ec] + -(int)local_34;
        }
        local_c = (byte **)param_1[0x26ec];
        if ((local_34 == local_c) && (ppbVar3 = param_1 + 0x6ec, ppbVar7 != ppbVar3)) {
          local_34 = ppbVar3;
          if (ppbVar3 < ppbVar7) {
            local_30 = (byte *)((int)ppbVar7 + (-1 - (int)ppbVar3));
          }
          else {
            local_30 = (byte *)((int)local_c - (int)ppbVar3);
          }
        }
        if (local_30 != (byte *)0x0) goto LAB_004071a2;
        goto LAB_00407235;
      }
LAB_004071a2:
      *(byte *)local_34 = *(byte *)(param_1 + 6);
      local_30 = local_30 + -1;
      local_34 = (byte **)((int)local_34 + 1);
      goto LAB_004069c5;
    case (byte *)0x7:
      if ((byte *)0x7 < pbVar10) {
        pbVar10 = pbVar10 + -8;
        local_38 = local_38 + 1;
        local_3c = local_3c + -1;
      }
    case (byte *)0xf:
      param_1[0x26ee] = (byte *)local_34;
      FUN_00407284((int)param_1);
      local_34 = (byte **)param_1[0x26ee];
      ppbVar7 = (byte **)param_1[0x26ed];
      if (local_34 < ppbVar7) {
        local_30 = (byte *)((int)ppbVar7 + (-1 - (int)local_34));
      }
      else {
        local_30 = param_1[0x26ec] + -(int)local_34;
      }
      if (local_34 != ppbVar7) {
LAB_00407235:
        uVar11 = 0;
        goto LAB_004068b5;
      }
      *ppbVar1 = param_1[0x149];
      if (param_1[0x149] != (byte *)0x8) {
        uVar11 = 1;
        goto LAB_004068b5;
      }
      break;
    case (byte *)0x8:
      for (; pbVar10 < (byte *)0x3; pbVar10 = pbVar10 + 8) {
        if (local_38 == (byte *)0x0) goto LAB_00407219;
        local_38 = local_38 + -1;
        local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
        local_3c = local_3c + 1;
      }
      pbVar10 = pbVar10 + -3;
      pbVar5 = (byte *)((uint)local_44 >> 3);
      uVar14 = ((uint)local_44 & 7) >> 1;
      param_1[0x149] = (byte *)((-(uint)(((uint)local_44 & 1) != 0) & 7) + 8);
      if (uVar14 == 0) {
        *ppbVar1 = &DAT_00000009;
        local_44 = (byte *)((uint)pbVar5 >> (sbyte)((uint)pbVar10 & 7));
        pbVar10 = pbVar10 + -((uint)pbVar10 & 7);
      }
      else {
        local_44 = pbVar5;
        if (uVar14 == 1) {
          if (DAT_0046ae70 == '\0') {
            local_c = (byte **)0x0;
            piVar4 = &DAT_00469cf0;
            do {
              cVar8 = '\b';
              if (0x469f2c < (int)piVar4) {
                if ((int)piVar4 < 0x46a0f0) {
                  cVar8 = '\t';
                }
                else if ((int)piVar4 < 0x46a150) {
                  cVar8 = '\a';
                }
              }
              *piVar4 = (int)cVar8;
              piVar4 = piVar4 + 1;
            } while ((int)piVar4 < 0x46a170);
            FUN_004072ec(&DAT_00469cf0,0x120,0x101,(int)&DAT_004084e0,(int)&DAT_00408520,
                         (int *)&DAT_00469cec,(uint *)&DAT_0040a5c8,(int)&DAT_0046a5f0,
                         (uint *)&local_c);
            puVar12 = &DAT_00469cf0;
            for (iVar6 = 0x1e; iVar6 != 0; iVar6 = iVar6 + -1) {
              *puVar12 = 5;
              puVar12 = puVar12 + 1;
            }
            FUN_004072ec(&DAT_00469cf0,0x1e,0,(int)&DAT_00408560,(int)&DAT_0040859c,
                         (int *)&DAT_00469ce8,(uint *)&DAT_0040a5cc,(int)&DAT_0046a5f0,
                         (uint *)&local_c);
            DAT_0046ae70 = DAT_0046ae70 + '\x01';
          }
          *(undefined *)(param_1 + 8) = DAT_0040a5c8;
          *(undefined *)((int)param_1 + 0x21) = DAT_0040a5cc;
          param_1[9] = DAT_00469cec;
          param_1[10] = DAT_00469ce8;
          goto LAB_004069c5;
        }
        if (uVar14 != 2) goto code_r0x004068a5;
        *ppbVar1 = (byte *)0xb;
      }
      break;
    case (byte *)0x9:
      for (; pbVar10 < (byte *)0x20; pbVar10 = pbVar10 + 8) {
        if (local_38 == (byte *)0x0) goto LAB_00407219;
        local_38 = local_38 + -1;
        local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
        local_3c = local_3c + 1;
      }
      pbVar10 = (byte *)0x0;
      pbVar5 = (byte *)((uint)local_44 & 0xffff);
      local_44 = (byte *)0x0;
      param_1[5] = pbVar5;
      if (pbVar5 == (byte *)0x0) goto LAB_00406b08;
      pbVar5 = (byte *)0xa;
      goto LAB_00406b0e;
    case (byte *)0xa:
      if (local_38 == (byte *)0x0) {
LAB_00407219:
        uVar11 = 0;
        param_1[0x14b] = local_44;
        param_1[0x14a] = pbVar10;
        param_1[1] = (byte *)0x0;
        goto LAB_004068cd;
      }
      if (local_30 == (byte *)0x0) {
        if (local_34 == (byte **)param_1[0x26ec]) {
          ppbVar3 = (byte **)param_1[0x26ed];
          ppbVar7 = param_1 + 0x6ec;
          if (ppbVar3 != ppbVar7) {
            if (ppbVar7 < ppbVar3) {
              local_30 = (byte *)((int)ppbVar3 + (-1 - (int)ppbVar7));
            }
            else {
              local_30 = (byte *)((int)param_1[0x26ec] - (int)ppbVar7);
            }
            local_34 = ppbVar7;
            if (local_30 != (byte *)0x0) goto LAB_00406ad4;
          }
        }
        param_1[0x26ee] = (byte *)local_34;
        FUN_00407284((int)param_1);
        local_34 = (byte **)param_1[0x26ee];
        ppbVar7 = (byte **)param_1[0x26ed];
        if (local_34 < ppbVar7) {
          local_30 = (byte *)((int)ppbVar7 + (-1 - (int)local_34));
        }
        else {
          local_30 = param_1[0x26ec] + -(int)local_34;
        }
        if (local_34 == (byte **)param_1[0x26ec]) {
          ppbVar3 = param_1 + 0x6ec;
          if (ppbVar3 != ppbVar7) {
            local_34 = ppbVar3;
            if (ppbVar3 < ppbVar7) {
              local_30 = (byte *)((int)ppbVar7 + (-1 - (int)ppbVar3));
            }
            else {
              local_30 = (byte *)((int)param_1[0x26ec] - (int)ppbVar3);
            }
          }
        }
        if (local_30 == (byte *)0x0) goto LAB_00407235;
      }
LAB_00406ad4:
      pbVar5 = local_30;
      if (local_38 <= local_30) {
        pbVar5 = local_38;
      }
      pbVar9 = param_1[5];
      if (pbVar5 <= param_1[5]) {
        pbVar9 = pbVar5;
      }
      FUN_00405d6b((undefined *)local_34,(int)local_3c,(int)pbVar9);
      local_3c = local_3c + (int)pbVar9;
      local_38 = local_38 + -(int)pbVar9;
      local_34 = (byte **)((int)local_34 + (int)pbVar9);
      local_30 = local_30 + -(int)pbVar9;
      ppbVar7 = param_1 + 5;
      *ppbVar7 = *ppbVar7 + -(int)pbVar9;
      if (*ppbVar7 == (byte *)0x0) {
LAB_00406b08:
        pbVar5 = param_1[0x149];
LAB_00406b0e:
        *ppbVar1 = pbVar5;
      }
      break;
    case (byte *)0xb:
      for (; pbVar10 < (byte *)0xe; pbVar10 = pbVar10 + 8) {
        if (local_38 == (byte *)0x0) goto LAB_00407219;
        local_38 = local_38 + -1;
        local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
        local_3c = local_3c + 1;
      }
      param_1[5] = (byte *)((uint)local_44 & 0x3fff);
      if ((((byte)(byte *)((uint)local_44 & 0x3fff) & 0x1f) < 0x1e) &&
         (((uint)local_44 & 0x3e0) < 0x3a1)) {
        local_44 = (byte *)((uint)local_44 >> 0xe);
        pbVar10 = pbVar10 + -0xe;
        param_1[6] = (byte *)0x0;
        *ppbVar1 = (byte *)0xc;
        goto switchD_00406846_caseD_c;
      }
      goto switchD_00406846_caseD_e;
    case (byte *)0xc:
switchD_00406846_caseD_c:
      if (param_1[6] < (byte *)(((uint)param_1[5] >> 10) + 4)) {
        do {
          for (; pbVar10 < (byte *)0x3; pbVar10 = pbVar10 + 8) {
            if (local_38 == (byte *)0x0) goto LAB_00407219;
            local_38 = local_38 + -1;
            local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
            local_3c = local_3c + 1;
          }
          pbVar5 = (byte *)((uint)local_44 & 7);
          pbVar10 = pbVar10 + -3;
          local_44 = (byte *)((uint)local_44 >> 3);
          param_1[(char)param_1[6][0x4084cc] + 7] = pbVar5;
          param_1[6] = param_1[6] + 1;
        } while (param_1[6] < (byte *)(((uint)param_1[5] >> 10) + 4));
      }
      while (param_1[6] < (byte *)0x13) {
        param_1[(char)param_1[6][0x4084cc] + 7] = (byte *)0x0;
        param_1[6] = param_1[6] + 1;
      }
      ppbVar7 = param_1 + 0x147;
      local_c = (byte **)0x0;
      *ppbVar7 = (byte *)0x7;
      iVar6 = FUN_004072ec((int *)(param_1 + 7),0x13,0x13,0,0,(int *)(param_1 + 0x148),
                           (uint *)ppbVar7,(int)(param_1 + 0x14c),(uint *)&local_c);
      if ((iVar6 == 0) && (*ppbVar7 != (byte *)0x0)) {
        param_1[6] = (byte *)0x0;
        *ppbVar1 = &DAT_0000000d;
switchD_00406846_caseD_d:
        while (param_1[6] <
               (byte *)(((uint)param_1[5] >> 5 & 0x1f) + 0x102 + ((uint)param_1[5] & 0x1f))) {
          for (; pbVar10 < param_1[0x147]; pbVar10 = pbVar10 + 8) {
            if (local_38 == (byte *)0x0) goto LAB_00407219;
            local_38 = local_38 + -1;
            local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
            local_3c = local_3c + 1;
          }
          bVar2 = param_1[0x148]
                  [((uint)*(ushort *)(&DAT_0040a5a4 + (int)param_1[0x147] * 2) & (uint)local_44) * 4
                   + 1];
          uVar14 = (uint)bVar2;
          local_18 = (byte *)(uint)*(ushort *)
                                    (param_1[0x148] +
                                    ((uint)*(ushort *)(&DAT_0040a5a4 + (int)param_1[0x147] * 2) &
                                    (uint)local_44) * 4 + 2);
          if (local_18 < (byte *)0x10) {
            pbVar10 = pbVar10 + -uVar14;
            local_44 = (byte *)((uint)local_44 >> (bVar2 & 0x1f));
            param_1[(int)(param_1[6] + 7)] = local_18;
            param_1[6] = param_1[6] + 1;
          }
          else {
            if (local_18 == (byte *)0x12) {
              local_c = (byte **)0xb;
              pbVar5 = (byte *)0x7;
            }
            else {
              pbVar5 = local_18 + -0xe;
              local_c = (byte **)0x3;
            }
            for (; pbVar10 < pbVar5 + uVar14; pbVar10 = pbVar10 + 8) {
              if (local_38 == (byte *)0x0) goto LAB_00407219;
              local_38 = local_38 + -1;
              local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
              local_3c = local_3c + 1;
            }
            uVar15 = (uint)local_44 >> (bVar2 & 0x1f);
            pbVar10 = pbVar10 + (-(int)pbVar5 - uVar14);
            pbVar9 = (byte *)((int)local_c + (*(ushort *)(&DAT_0040a5a4 + (int)pbVar5 * 2) & uVar15)
                             );
            local_44 = (byte *)(uVar15 >> ((byte)pbVar5 & 0x1f));
            pbVar5 = param_1[6];
            if ((byte *)(((uint)param_1[5] >> 5 & 0x1f) + 0x102 + ((uint)param_1[5] & 0x1f)) <
                pbVar9 + (int)pbVar5) goto switchD_00406846_caseD_e;
            if (local_18 == (byte *)0x10) {
              if (pbVar5 == (byte *)0x0) goto switchD_00406846_caseD_e;
              pbVar13 = param_1[(int)(pbVar5 + 6)];
            }
            else {
              pbVar13 = (byte *)0x0;
            }
            ppbVar7 = param_1 + (int)(pbVar5 + 7);
            do {
              *ppbVar7 = pbVar13;
              pbVar5 = pbVar5 + 1;
              ppbVar7 = ppbVar7 + 1;
              pbVar9 = pbVar9 + -1;
            } while (pbVar9 != (byte *)0x0);
            param_1[6] = pbVar5;
          }
        }
        param_1[0x148] = (byte *)0x0;
        local_10 = 0;
        uVar14 = (uint)param_1[5] & 0x1f;
        uVar15 = uVar14 + 0x101;
        local_18 = (byte *)(((uint)param_1[5] >> 5 & 0x1f) + 1);
        local_8 = 9;
        local_14 = 6;
        iVar6 = FUN_004072ec((int *)(param_1 + 7),uVar15,0x101,(int)&DAT_004084e0,(int)&DAT_00408520
                             ,(int *)&local_1c,&local_8,(int)(param_1 + 0x14c),&local_10);
        if (local_8 == 0) {
          iVar6 = -1;
        }
        if (((iVar6 != 0) ||
            (iVar6 = FUN_004072ec((int *)(param_1 + uVar14 + 0x108),(uint)local_18,0,
                                  (int)&DAT_00408560,(int)&DAT_0040859c,(int *)&local_20,&local_14,
                                  (int)(param_1 + 0x14c),&local_10), iVar6 != 0)) ||
           ((local_14 == 0 && (0x101 < uVar15)))) goto switchD_00406846_caseD_e;
        *ppbVar1 = (byte *)0x0;
        *(char *)((int)param_1 + 0x21) = (char)local_14;
        param_1[9] = local_1c;
        *(undefined *)(param_1 + 8) = (undefined)local_8;
        param_1[10] = local_20;
switchD_00406846_caseD_0:
        param_1[7] = (byte *)(uint)*(byte *)(param_1 + 8);
        param_1[6] = param_1[9];
        *ppbVar1 = (byte *)0x1;
switchD_00406846_caseD_1:
        for (; pbVar10 < param_1[7]; pbVar10 = pbVar10 + 8) {
          if (local_38 == (byte *)0x0) goto LAB_00407219;
          local_38 = local_38 + -1;
          local_44 = (byte *)((uint)local_44 | (uint)*local_3c << ((byte)pbVar10 & 0x1f));
          local_3c = local_3c + 1;
        }
        pbVar5 = param_1[6] +
                 ((uint)*(ushort *)(&DAT_0040a5a4 + (int)param_1[7] * 2) & (uint)local_44) * 4;
        local_44 = (byte *)((uint)local_44 >> (pbVar5[1] & 0x1f));
        pbVar10 = pbVar10 + -(uint)pbVar5[1];
        bVar2 = *pbVar5;
        pbVar9 = (byte *)(uint)bVar2;
        if (pbVar9 == (byte *)0x0) {
          param_1[6] = (byte *)(uint)*(ushort *)(pbVar5 + 2);
          *ppbVar1 = (byte *)0x6;
        }
        else if ((bVar2 & 0x10) == 0) {
          if ((bVar2 & 0x40) == 0) goto LAB_00406fa7;
          if ((bVar2 & 0x20) == 0) goto switchD_00406846_caseD_e;
          *ppbVar1 = (byte *)0x7;
        }
        else {
          param_1[6] = (byte *)((uint)pbVar9 & 0xf);
          param_1[5] = (byte *)(uint)*(ushort *)(pbVar5 + 2);
          *ppbVar1 = (byte *)0x2;
        }
      }
      else {
        *ppbVar1 = (byte *)0x11;
      }
      break;
    case (byte *)0xd:
      goto switchD_00406846_caseD_d;
    default:
      goto switchD_00406846_caseD_e;
    }
  } while( true );
code_r0x004068a5:
  if (uVar14 == 3) {
switchD_00406846_caseD_e:
    uVar11 = 0xffffffff;
    *ppbVar1 = (byte *)0x11;
LAB_004068b5:
    param_1[0x14b] = local_44;
    param_1[0x14a] = pbVar10;
    param_1[1] = local_38;
LAB_004068cd:
    *param_1 = local_3c;
    param_1[0x26ee] = (byte *)local_34;
    FUN_00407284((int)param_1);
    return uVar11;
  }
  goto LAB_00407209;
}

/* Function: FUN_00407284 */
void FUN_00407284(int param_1)

{
  uint uVar1;
  uint uVar2;
  uint uVar3;
  uint uVar4;
  
  uVar4 = *(uint *)(param_1 + 0x9bb4);
  while( true ) {
    uVar2 = *(uint *)(param_1 + 0x9bb8);
    if (uVar2 < uVar4) {
      uVar2 = *(uint *)(param_1 + 0x9bb0);
    }
    uVar1 = *(uint *)(param_1 + 0xc);
    uVar3 = uVar2 - uVar4;
    if (uVar1 <= uVar2 - uVar4) {
      uVar3 = uVar1;
    }
    *(uint *)(param_1 + 0xc) = uVar1 - uVar3;
    FUN_00405d6b(*(undefined **)(param_1 + 8),uVar4,uVar3);
    *(int *)(param_1 + 8) = *(int *)(param_1 + 8) + uVar3;
    if (uVar4 + uVar3 != *(int *)(param_1 + 0x9bb0)) break;
    uVar4 = param_1 + 0x1bb0;
    if (*(int *)(param_1 + 0x9bb8) == *(int *)(param_1 + 0x9bb0)) {
      *(uint *)(param_1 + 0x9bb8) = uVar4;
    }
  }
  *(uint *)(param_1 + 0x9bb4) = uVar4 + uVar3;
  return;
}

/* Function: FUN_004072ec */
/* WARNING: Could not reconcile some variable overlaps */

undefined4
FUN_004072ec(int *param_1,uint param_2,uint param_3,int param_4,int param_5,int *param_6,
            uint *param_7,int param_8,uint *param_9)

{
  undefined3 uVar1;
  undefined4 uVar2;
  undefined2 uVar3;
  int iVar4;
  int *piVar5;
  int iVar6;
  uint uVar7;
  uint *puVar8;
  int iVar9;
  uint uVar10;
  byte bVar11;
  uint *puVar12;
  uint *puVar13;
  int iVar14;
  int local_f0 [15];
  uint local_b4 [16];
  uint local_74 [16];
  int local_34;
  uint local_30;
  int local_2c;
  uint local_28;
  uint *local_24;
  uint *local_20;
  uint *local_1c;
  int local_18;
  uint local_14;
  int local_10;
  uint local_c;
  uint *local_8;
  
  puVar13 = param_7;
  puVar12 = local_74;
  for (iVar4 = 0x10; piVar5 = param_1, uVar7 = param_2, iVar4 != 0; iVar4 = iVar4 + -1) {
    *puVar12 = 0;
    puVar12 = puVar12 + 1;
  }
  do {
    local_74[*piVar5] = local_74[*piVar5] + 1;
    uVar7 = uVar7 - 1;
    piVar5 = piVar5 + 1;
  } while (uVar7 != 0);
  if (local_74[0] == param_2) {
    *param_6 = 0;
    *param_7 = 0;
    uVar2 = 0;
  }
  else {
    puVar12 = (uint *)0x1;
    param_7 = (uint *)*param_7;
    puVar8 = (uint *)0xf;
    do {
      iVar4 = 0;
      if (local_74[(int)puVar12] != 0) break;
      puVar12 = (uint *)((int)puVar12 + 1);
    } while (puVar12 < (uint *)0x10);
    local_8 = puVar12;
    if (param_7 < puVar12) {
      param_7 = puVar12;
    }
    do {
      if (local_74[(int)puVar8] != 0) break;
      puVar8 = (uint *)((int)puVar8 - 1);
    } while (puVar8 != (uint *)0x0);
    local_1c = puVar8;
    if (puVar8 < param_7) {
      param_7 = puVar8;
    }
    *puVar13 = (uint)param_7;
    local_34 = 1 << ((byte)puVar12 & 0x1f);
    for (; puVar12 < puVar8; puVar12 = (uint *)((int)puVar12 + 1)) {
      if ((int)(local_34 - local_74[(int)puVar12]) < 0) goto LAB_0040761d;
      local_34 = (local_34 - local_74[(int)puVar12]) * 2;
    }
    uVar7 = local_74[(int)puVar8];
    local_34 = local_34 - uVar7;
    if (-1 < local_34) {
      local_b4[1] = 0;
      local_74[(int)puVar8] = uVar7 + local_34;
      iVar6 = 0;
      iVar9 = (int)puVar8 - 1;
      if (iVar9 != 0) {
        iVar14 = 0;
        do {
          iVar6 = iVar6 + *(int *)((int)local_74 + iVar14 + 4);
          iVar9 = iVar9 + -1;
          *(int *)((int)local_b4 + iVar14 + 8) = iVar6;
          iVar14 = iVar14 + 4;
        } while (iVar9 != 0);
      }
      uVar7 = 0;
      piVar5 = param_1;
      do {
        iVar6 = *piVar5;
        piVar5 = piVar5 + 1;
        if (iVar6 != 0) {
          uVar10 = local_b4[iVar6];
          (&DAT_0046a170)[uVar10] = uVar7;
          local_b4[iVar6] = uVar10 + 1;
        }
        uVar7 = uVar7 + 1;
      } while (uVar7 < param_2);
      uVar7 = local_b4[(int)puVar8];
      local_10 = -1;
      local_28 = 0;
      iVar6 = -(int)param_7;
      local_c = 0;
      local_b4[0] = 0;
      local_24 = &DAT_0046a170;
      local_f0[0] = 0;
      if ((int)local_8 <= (int)local_1c) {
        local_2c = (int)local_8 - 1;
        local_20 = local_74 + (int)local_8;
        do {
          local_14 = *local_20;
          while (local_14 != 0) {
            param_1._2_2_ = (undefined2)((uint)param_1 >> 0x10);
            local_30 = local_14 - 1;
            local_18 = (int)param_7 + iVar6;
            if ((int)param_7 + iVar6 < (int)local_8) {
              do {
                iVar14 = local_10;
                iVar9 = local_10 + 1;
                local_10 = iVar9;
                puVar13 = (uint *)((int)local_1c - local_18);
                if (param_7 < (uint *)((int)local_1c - local_18)) {
                  puVar13 = param_7;
                }
                puVar12 = (uint *)((int)local_8 - local_18);
                uVar10 = 1 << ((byte)puVar12 & 0x1f);
                if ((local_14 < uVar10) &&
                   (iVar4 = uVar10 + (-1 - local_30), puVar8 = local_20, puVar12 < puVar13)) {
                  while (puVar12 = (uint *)((int)puVar12 + 1), puVar12 < puVar13) {
                    uVar10 = puVar8[1];
                    if ((uint)(iVar4 * 2) <= uVar10) break;
                    iVar4 = iVar4 * 2 - uVar10;
                    puVar8 = puVar8 + 1;
                  }
                }
                local_28 = 1 << ((byte)puVar12 & 0x1f);
                uVar10 = *param_9 + local_28;
                if (0x5a0 < uVar10) goto LAB_0040761d;
                iVar4 = param_8 + *param_9 * 4;
                *param_9 = uVar10;
                local_f0[iVar9] = iVar4;
                uVar10 = local_c;
                if (iVar9 == 0) {
                  *param_6 = iVar4;
                }
                else {
                  iVar14 = local_f0[iVar14];
                  local_b4[iVar9] = local_c;
                  param_1._0_2_ = (ushort)puVar12 & 0xff | (ushort)(((uint)param_7 & 0xff) << 8);
                  uVar10 = uVar10 >> ((byte)iVar6 & 0x1f);
                  param_1 = (int *)CONCAT22((short)(iVar4 - iVar14 >> 2) - (short)uVar10,
                                            (ushort)param_1);
                  *(int **)(iVar14 + uVar10 * 4) = param_1;
                }
                iVar6 = local_18;
                local_18 = local_18 + (int)param_7;
              } while (local_18 < (int)local_8);
            }
            bVar11 = (byte)iVar6;
            uVar1 = CONCAT21(param_1._2_2_,(char)local_8 - bVar11);
            if (local_24 < &DAT_0046a170 + uVar7) {
              uVar10 = *local_24;
              if (uVar10 < param_3) {
                param_1._0_2_ = (ushort)CONCAT31(uVar1,(uVar10 < 0x100) + -1) & 0xff60;
                uVar3 = *(undefined2 *)local_24;
                local_24 = local_24 + 1;
              }
              else {
                iVar9 = (uVar10 - param_3) * 2;
                local_24 = local_24 + 1;
                param_1 = (int *)CONCAT31(uVar1,*(char *)(iVar9 + param_5) + 'P');
                uVar3 = *(undefined2 *)(iVar9 + param_4);
              }
              param_1 = (int *)CONCAT22(uVar3,(ushort)param_1);
            }
            else {
              param_1 = (int *)CONCAT31(uVar1,0xc0);
            }
            for (uVar10 = local_c >> (bVar11 & 0x1f); uVar10 < local_28;
                uVar10 = uVar10 + (1 << ((char)local_8 - bVar11 & 0x1f))) {
              *(int **)(iVar4 + uVar10 * 4) = param_1;
            }
            uVar10 = 1 << ((byte)local_2c & 0x1f);
            while ((local_c & uVar10) != 0) {
              local_c = local_c ^ uVar10;
              uVar10 = uVar10 >> 1;
            }
            local_c = local_c ^ uVar10;
            local_14 = 1;
            local_14 = local_30;
            if (((1 << (bVar11 & 0x1f)) - 1U & local_c) != local_b4[local_10]) {
              do {
                iVar6 = iVar6 - (int)param_7;
                local_10 = local_10 + -1;
              } while (((1 << ((byte)iVar6 & 0x1f)) - 1U & local_c) != local_b4[local_10]);
            }
          }
          local_8 = (uint *)((int)local_8 + 1);
          local_20 = local_20 + 1;
          local_2c = local_2c + 1;
        } while ((int)local_8 <= (int)local_1c);
      }
      if (local_34 == 0) {
        return 0;
      }
      if (local_1c == (uint *)0x1) {
        return 0;
      }
    }
LAB_0040761d:
    uVar2 = 0xffffffff;
  }
  return uVar2;
}

;
