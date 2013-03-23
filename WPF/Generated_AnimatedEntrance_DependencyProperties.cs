﻿
// ############################################################################
// #                                                                          #
// #        ---==>  T H I S  F I L E  I S   G E N E R A T E D  <==---         #
// #                                                                          #
// # This means that any edits to the .cs file will be lost when its          #
// # regenerated. Changes should instead be applied to the corresponding      #
// # template file (.tt)                                                      #
// ############################################################################



                                   

// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable InconsistentNaming
// ReSharper disable InvocationIsSkipped
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PossibleUnintendedReferenceComparison
// ReSharper disable RedundantAssignment
// ReSharper disable RedundantCast
// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedMember.Local

namespace Source.WPF
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;

    using System.Windows;
    using System.Windows.Media;

    // ------------------------------------------------------------------------
    // AnimatedEntrance
    // ------------------------------------------------------------------------
    partial class AnimatedEntrance
    {
        #region Uninteresting generated code
        static readonly DependencyPropertyKey ChildrenPropertyKey = DependencyProperty.RegisterReadOnly (
            "Children",
            typeof (ObservableCollection<UIElement>),
            typeof (AnimatedEntrance),
            new FrameworkPropertyMetadata (
                null,
                FrameworkPropertyMetadataOptions.None,
                Changed_Children,
                Coerce_Children          
            ));

        public static readonly DependencyProperty ChildrenProperty = ChildrenPropertyKey.DependencyProperty;

        static void Changed_Children (DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var instance = dependencyObject as AnimatedEntrance;
            if (instance != null)
            {
                var oldValue = (ObservableCollection<UIElement>)eventArgs.OldValue;
                var newValue = (ObservableCollection<UIElement>)eventArgs.NewValue;

                if (oldValue != null)
                {
                    oldValue.CollectionChanged -= instance.CollectionChanged_Children;
                }

                if (newValue != null)
                {
                    newValue.CollectionChanged += instance.CollectionChanged_Children;
                }

                instance.Changed_Children (oldValue, newValue);
            }
        }

        void CollectionChanged_Children(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged_Children (
                sender, 
                e.Action,
                e.OldStartingIndex,
                e.OldItems,
                e.NewStartingIndex,
                e.NewItems
                );
        }

        static object Coerce_Children (DependencyObject dependencyObject, object basevalue)
        {
            var instance = dependencyObject as AnimatedEntrance;
            if (instance == null)
            {
                return basevalue;
            }
            var oldValue = (ObservableCollection<UIElement>)basevalue;
            var newValue = oldValue;

            instance.Coerce_Children (oldValue, ref newValue);

            if (newValue == null)
            {
               newValue = new ObservableCollection<UIElement> ();
            }

            return newValue;
        }

        #endregion

        // --------------------------------------------------------------------
        // Constructor
        // --------------------------------------------------------------------
        public AnimatedEntrance ()
        {
            CoerceAllProperties ();
            Constructed__AnimatedEntrance ();
        }
        // --------------------------------------------------------------------
        partial void Constructed__AnimatedEntrance ();
        // --------------------------------------------------------------------
        void CoerceAllProperties ()
        {
            CoerceValue (ChildrenProperty);
        }


        // --------------------------------------------------------------------
        // Properties
        // --------------------------------------------------------------------

           
        // --------------------------------------------------------------------
        public ObservableCollection<UIElement> Children
        {
            get
            {
                return (ObservableCollection<UIElement>)GetValue (ChildrenProperty);
            }
            private set
            {
                if (Children != value)
                {
                    SetValue (ChildrenPropertyKey, value);
                }
            }
        }
        // --------------------------------------------------------------------
        partial void Changed_Children (ObservableCollection<UIElement> oldValue, ObservableCollection<UIElement> newValue);
        partial void Coerce_Children (ObservableCollection<UIElement> value, ref ObservableCollection<UIElement> coercedValue);
        partial void CollectionChanged_Children (object sender, NotifyCollectionChangedAction action, int oldStartingIndex, IList oldItems, int newStartingIndex, IList newItems);
        // --------------------------------------------------------------------


    }
    // ------------------------------------------------------------------------

}
                                   
