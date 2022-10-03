using System.Collections.Generic;
using System.Threading.Tasks;
using Lukomor.Application.Contexts;
using Lukomor.DIContainer;
using Lukomor.Domain.Scenes;
using Lukomor.Presentation;

public class SlicerGame
{
    public static ProjectContext ProjectContext { get; }
    public static ISceneManager SceneManager { get; }

    static SlicerGame()
    {
        Dictionary<string, IContext> scenesContextMap = new Dictionary<string, IContext>
            {
                {"GameplayScene", new SlicerGameGameplaySceneContext()}
            };

        ProjectContext = new SlicerGameProjectContext(scenesContextMap);

        DI.Bind(UserInterface.CreateInstance());

        SceneManager = Lukomor.Domain.Scenes.SceneManager.CreateInstance(ProjectContext);
    }

    public static async Task StartGameAsync()
    {
        await ProjectContext.InitializeAsync();
        await SceneManager.LoadScene("GameplayScene");
    }
}
