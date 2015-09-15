﻿using MvvmApp1.Models;
using MVVMbasics.Commands;
using MVVMbasics.Viewmodels;

namespace MvvmApp1.Viewmodels
{
    public sealed class MainViewmodel : BaseViewmodel
    {
        #region Bindable properties

        //TODO: Add bindable properties, as shown in the following example
        private int _sampleProperty;

        public int SampleProperty
        {
            get { return _sampleProperty; }
            set { Set(ref _sampleProperty, value, () => SampleProperty); }
        }

        #endregion

        #region Bindable commands

        //TODO: Add commands, as shown in the following example
        public BaseCommand SampleCommand { get; set; }

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewmodel()
        {
            #region Bindable properties

            //TODO: Assign default values to the bindable properties defined above
            SampleProperty = 1;

            #endregion

            #region Bindable commands

            //TODO: Assign local methods to the bindable commands defined above
            SampleCommand = new BaseCommand(SampleMethod);

            #endregion

            //dynamic obj = new SampleModel();
            //obj.member1 = 20;
        }

        private void SampleMethod()
        {
            //TODO: Create methods like this, one for each bindable command as defined above
        }

        /// <summary>
        /// Gets called as soon as the global ServiceLocator has been injected into the Viewmodel (usually, shortly
        /// after the constructor).
        /// </summary>
        public override void OnServiceLocatorAvailable()
        {
            //TODO: Add all code here that usually would be called within the constructor but is dependent on the ServiceLocator code, or remove method
            base.OnServiceLocatorAvailable();
        }

        /// <summary>
        /// Gets called when navigating to a page.
        /// </summary>
        /// <param name="uriParameters">List of parameters that were parsed from the URI.</param>
        /// <param name="parameters">List of parameters that were passed from the calling page.</param>
        /// <param name="viewState">Indicates the lifecycle state the View is about to reach.</param>
        public override void OnNavigatedTo(MVVMbasics.Services.ParameterList uriParameters,
                                           MVVMbasics.Services.ParameterList parameters,
                                           MVVMbasics.Services.ViewState viewState)
        {
            //TODO: Add code, or remove method (if you use this method, do not remove the following line!)
            base.OnNavigatedTo(uriParameters, parameters, viewState);
        }

        /// <summary>
        /// Gets called when the page is about to be closed, in order to return back to the previously shown page.
        /// </summary>
        /// <param name="viewState">Indicates the lifecycle state the View is about to reach.</param>
        /// <returns></returns>
        public override bool CancelNavigatingFrom(MVVMbasics.Services.ViewState viewState)
        {
            //TODO: Add code and return TRUE to cancel the closing process, or remove method (if you use this method, do not remove the following line!)
            return base.CancelNavigatingFrom(viewState);
        }

        /// <summary>
        /// Gets called when a page is closed.
        /// </summary>
        /// <param name="viewState">Indicates the lifecycle state the View is about to reach.</param>
        public override void OnNavigatedFrom(MVVMbasics.Services.ViewState viewState)
        {
            //TODO: Add code, or remove method (if you use this method, do not remove the following line!)
            base.OnNavigatedFrom(viewState);
        }
    }
}
