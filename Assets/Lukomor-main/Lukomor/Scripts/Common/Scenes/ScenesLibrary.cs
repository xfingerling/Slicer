﻿using System.Linq;
using UnityEngine;
using VavilichevGD.Tools.Logging;

namespace Lukomor.Common.Scenes
{
	[CreateAssetMenu(fileName = "ScenesLibrary", menuName = "Scenes/New Scenes Library")]
	public class ScenesLibrary : ScriptableObject
	{
		[SerializeField] private SceneConfig[] _uiSceneConfigs = default;

		public SceneConfig GetConfigOfScene(string sceneName)
		{
			var foundConfig = _uiSceneConfigs.FirstOrDefault(config => config.SceneName == sceneName);

			if (foundConfig == null)
			{
				Log.PrintError($"ScenesLibrary: Cannot find scene config for sceneName = {sceneName}");
			}

			return foundConfig;
		}
	}
}