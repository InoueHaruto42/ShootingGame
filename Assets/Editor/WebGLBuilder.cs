using UnityEditor;
using UnityEngine;

/// <summary>
/// コマンドラインからWebGLビルドを実行するためのスクリプト
/// 使用例: Unity -batchmode -executeMethod WebGLBuilder.Build
/// </summary>
public static class WebGLBuilder
{
    public static void Build()
    {
        // GitHub PagesはContent-Encodingヘッダを設定できないため、
        // 解凍フォールバックを有効にする(これがないとブラウザで読み込めない)
        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Brotli;
        PlayerSettings.WebGL.decompressionFallback = true;

        var options = new BuildPlayerOptions
        {
            scenes = new[]
            {
                "Assets/Scenes/MainScene.unity",
                "Assets/Scenes/GameOver.unity",
            },
            locationPathName = "docs",
            target = BuildTarget.WebGL,
            options = BuildOptions.None,
        };

        var report = BuildPipeline.BuildPlayer(options);
        if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            EditorApplication.Exit(1);
        }
        EditorApplication.Exit(0);
    }
}
