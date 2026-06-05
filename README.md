# WordCards 單字卡片學習程式

一款基於 Windows Forms 的英文單字學習工具，支援單字瀏覽、音檔播放與自動輪播功能。

---

## 功能特色

- **單字清單瀏覽**：左側清單顯示全部單字（共 302 筆），點選即可查看詳細資訊
- **單字資訊顯示**：顯示英文單字、KK 音標及中文解釋（支援多行）
- **音檔播放**：點選單字自動播放對應發音音檔（使用 Windows Media Player）
- **自動播放模式**：按下 ▶ Play 按鈕依序自動切換並播放，每 2 秒切換一個單字
- **鍵盤操作支援**：
  - `Enter`：切換並播放下一個單字
  - `Space`：重複播放目前單字
- **現代化 UI**：深色清單 + 米白主區雙色配置，Segoe UI 字型

---

## 執行畫面

<img width="749" height="535" alt="螢幕擷取畫面 2026-06-05 133330" src="https://github.com/user-attachments/assets/a714a143-ba9d-46f2-b98b-bf8516a9eb68" />

---
## 專案結構

```
WordCards/                          ← 方案根目錄
├── .gitattributes
├── .gitignore
├── README.md
├── WordCards.sln                   ← Visual Studio 方案檔
└── WordCards/                      ← 專案目錄
    ├── bin/                        ← 編譯輸出
    ├── obj/                        ← 中間產物
    ├── Properties/                 ← 組件資訊
    ├── Resources/
    │   ├── WordCards.txt           ← 單字資料檔（Tab 分隔，302 筆）
    │   ├── WordCards.ico           ← 程式圖示
    │   ├── WordCards_Icon.png
    │   └── WordCards_Logo.png      ← 右上角 Logo
    ├── Sound/
    │   └── A/                      ← 音效檔目錄（.mp3）
    ├── App.config
    ├── frmWordCards.cs             ← 主視窗邏輯
    ├── frmWordCards.Designer.cs    ← 主視窗 UI 設計
    ├── frmWordCards.resx           ← 資源檔
    ├── Program.cs                  ← 程式進入點
    ├── WordCards.csproj            ← 專案設定
    ├── WordCards.txt               ← （備份）
    ├── WordCollection.cs           ← 單字集合類別
    └── WordItem.cs                 ← 單字資料模型
```

---

## 單字檔格式

單字資料儲存於 `Resources/WordCards.txt`，每行一個單字，欄位以 **Tab（`\t`）** 分隔：

```
單字\t音標\t音檔路徑\t中文解釋（可多欄）
```

範例：
```
abacus  `œbəkəs  Sound\A\abacus.mp3  <aba-=abax-:一種計算工具>+<-us: calculus 小圓石>  一種利用小圓石幫助計算的工具
apple   [ˋæpl]   Sound\A\apple.mp3   蘋果；蘋果樹
```

| 欄位 | 說明 |
|------|------|
| 第 1 欄 | 英文單字 |
| 第 2 欄 | KK 音標 |
| 第 3 欄 | 音效檔相對路徑（相對於執行檔目錄） |
| 第 4 欄以後 | 中文解釋，多欄以換行合併顯示 |

---

## 系統需求

| 項目 | 需求 |
|------|------|
| 作業系統 | Windows 10 / 11 |
| .NET Framework | 4.7.2 以上 |
| 開發工具 | Visual Studio 2019 / 2022 |
| 相依套件 | WMPLib（Windows Media Player COM 元件） |

---

## 安裝與執行

1. Clone 或下載此專案
2. 以 Visual Studio 開啟 `WordCards.sln`
3. 加入 WMPLib 參考：「專案」→「加入參考」→「COM」→ 搜尋 **Windows Media Player**
4. 確認 `Resources/WordCards.txt` 與 `Sound/` 音效檔已就位
5. 按下 `F5` 建置並執行

> **注意**：音效檔路徑為相對於執行檔（`bin\Debug\`）的路徑，請確認 `Sound\` 資料夾已複製至該目錄，或在專案屬性中設定「複製到輸出目錄」。

---

## 使用說明

| 操作 | 動作 |
|------|------|
| 點選清單項目 | 顯示單字資訊並播放發音 |
| `Enter` | 切換至下一個單字並播放 |
| `Space` | 重複播放目前單字 |
| ▶ **Play** | 開始自動輪播（每 2 秒一個單字） |
| ■ **Stop** | 停止自動輪播 |
| 自動播放中點選清單 | 自動暫停輪播 |

---

## 類別說明

### `WordItem`
單字資料模型，儲存單一單字的所有欄位資訊。

| 屬性 | 型別 | 說明 |
|------|------|------|
| `Word` | `string` | 英文單字 |
| `Phonogram` | `string` | KK 音標 |
| `SoundPath` | `string` | 音效檔路徑 |
| `Explain` | `string` | 中文解釋（多行） |

### `WordCollection`
繼承自 `Collection<WordItem>`，提供 `LoadFromStringArray(string[] lines)` 方法從 Tab 分隔的字串陣列批次載入單字。

### `frmWordCards`
主視窗，負責 UI 互動、單字顯示與音檔播放控制。主要方法：

| 方法 | 說明 |
|------|------|
| `ShowWord(WordItem)` | 將單字資訊顯示至畫面 |
| `PlayWord(WordItem)` | 透過 WMP 播放音效檔 |
| `PlaySelectedWord()` | 顯示並播放目前選取的單字 |
| `NextWordList()` | 移至下一個單字並自動捲動清單 |
| `UpdateWordList()` | 重新整理左側單字清單 |

---

## 授權

本專案僅供學習與教育用途。
