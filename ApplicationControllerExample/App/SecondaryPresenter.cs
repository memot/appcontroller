using ApplicationControllerExample.AppController;
using ApplicationControllerExample.Model;

namespace ApplicationControllerExample.App
{
	public class SecondaryPresenter: IPartOfTheProcess
	{
		private ISecondaryView View { get; set; }
		private IApplicationController AppController { get; set; }

		public SecondaryPresenter(ISecondaryView view, IApplicationController appController)
		{
			View = view;
			AppController = appController;
			View.Presenter = this;
		}

		public void DoThatThing()
		{
			View.Run();
		}

		public void Whatever()
		{
			AppController.Raise(new SomeEventData("you did what?"));
		}

		public void ThatThingHappened(string s)
		{
			AppController.Raise(new SomeEventData("click-o-that menu"));
		}
	}
}