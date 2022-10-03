﻿using Lukomor.Presentation.Controllers;
using Lukomor.Presentation.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Lukomor.Presentation.Views.Windows
{
	public abstract class DialogWindow<TModel> : Window<TModel> where TModel : Model, new()
	{
		[SerializeField] protected Button _btnClose;
		[SerializeField] protected Button _btnCloseAlt;

		public override void Subscribe()
		{
			base.Subscribe();

			if (_btnClose != null)
			{
				_btnClose.onClick.AddListener(OnCloseButtonClick);
			}

			if (_btnCloseAlt != null)
			{
				_btnCloseAlt.onClick.AddListener(OnCloseButtonClick);
			}
		}

		public override void Unsubscribe()
		{
			base.Unsubscribe();
			
			if (_btnClose != null)
			{
				_btnClose.onClick.RemoveListener(OnCloseButtonClick);
			}

			if (_btnCloseAlt != null)
			{
				_btnCloseAlt.onClick.RemoveListener(OnCloseButtonClick);
			}
		}

		protected virtual void OnCloseButtonClick()
		{
			UI.Back();
		}
	}
	
	public abstract class DialogWindow : DialogWindow<Model>
	{
		protected sealed override Controller<Model> CreateController()
		{
			return null;
		}
	}
}