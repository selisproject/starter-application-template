// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DemonstratorApp.BO
{
    /// <summary>
    /// The Intermediary class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Intermediary : IDomainModelClass
    {
        #region Intermediary's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="OtherDescription")]
        protected string otherDescription;
        [DataMember(Name="IntermediaryType")]
        protected DemonstratorApp.BO.IntermediaryType? intermediaryType;
        [DataMember(Name="Company")]
        protected string company;
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="EMail")]
        protected string eMail;
        [DataMember(Name="GUID")]
        protected string gUID;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

#pragma warning disable 0649
        private bool disableInternalAdditions;
#pragma warning restore 0649
        #endregion
        #region Intermediary's Properties
/// <summary>
/// The OtherDescription property
///
/// </summary>
///
        public virtual string OtherDescription
        {
            get
            {
                return otherDescription;
            }
            set
            {
                otherDescription = value;
            }
        }
/// <summary>
/// The IntermediaryType property
///
/// </summary>
///
        public virtual DemonstratorApp.BO.IntermediaryType? IntermediaryType
        {
            get
            {
                return intermediaryType;
            }
            set
            {
                intermediaryType = value;
            }
        }
/// <summary>
/// The Company property
///
/// </summary>
///
        public virtual string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The EMail property
///
/// </summary>
///
        public virtual string EMail
        {
            get
            {
                return eMail;
            }
            set
            {
                eMail = value;
            }
        }
/// <summary>
/// The GUID property
///
/// </summary>
///
        public virtual string GUID
        {
            get
            {
                return gUID;
            }
            set
            {
                gUID = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region Intermediary's Participant Properties
        [DataMember(Name="Orders")]
        protected IList<Order> orders = new List<Order>();
        public virtual List<Order> Orders
        {
            get
            {
                if (orders is Order[])
                {
                    orders = orders.ToList();
                }
                if (orders == null)
                {
                    orders = new List<Order>();
                }
                return orders.ToList();
            }
            set
            {
                if (orders is Order[])
                {
                    orders = orders.ToList();
                }
                if (orders != null)
                {
                    var __itemsToDelete = new List<Order>(orders);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOrders(__item);
                    }
                }
                if(value == null)
                {
                    orders = new List<Order>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOrders(__item);
                }
            }
        }
        public virtual void AddOrders(IList<Order> __items)
        {
            foreach (var __item in __items)
            {
                AddOrders(__item);
            }
        }

        public virtual void InternalAddOrders(Order __item)
        {
            if (__item == null || disableInternalAdditions) return;
            orders?.Add(__item);
        }

        public virtual void InternalRemoveOrders(Order __item)
        {
            if (__item == null) return;
            orders?.Remove(__item);
        }

        public virtual void AddOrders(Order __item)
        {
            if (__item == null) return;
            if (!orders.Contains(__item))
                InternalAddOrders(__item);
            if (!__item.Intermediaries.Contains(this))
                __item.AddIntermediaries(this);
        }

        public virtual void AddAtIndexOrders(int index, Order __item)
        {
            if (__item == null) return;
            if (!orders.Contains(__item))
                orders.Insert(index, __item);
            if (!__item.Intermediaries.Contains(this))
                __item.AddIntermediaries(this);
        }

        public virtual void RemoveOrders(Order __item)
        {
            if (__item != null)
            {
                if (orders.Contains(__item))
                    InternalRemoveOrders(__item);
                if(__item.Intermediaries.Contains(this))
                    __item.RemoveIntermediaries(this);
            }
        }
        public virtual void SetOrdersAt(Order __item, int __index)
        {
            if (__item == null)
            {
                orders[__index].RemoveIntermediaries(this);
            }
            else
            {
                orders[__index] = __item;
                if (!__item.Intermediaries.Contains(this))
                    __item.AddIntermediaries(this);
            }
        }

        public virtual void ClearOrders()
        {
            if (orders!=null)
            {
                var __itemsToRemove = orders.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOrders(__item);
                }
            }
        }
        [DataMember(Name="Transactions")]
        protected IList<Transaction> transactions = new List<Transaction>();
        public virtual List<Transaction> Transactions
        {
            get
            {
                if (transactions is Transaction[])
                {
                    transactions = transactions.ToList();
                }
                if (transactions == null)
                {
                    transactions = new List<Transaction>();
                }
                return transactions.ToList();
            }
            set
            {
                if (transactions is Transaction[])
                {
                    transactions = transactions.ToList();
                }
                if (transactions != null)
                {
                    var __itemsToDelete = new List<Transaction>(transactions);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTransactions(__item);
                    }
                }
                if(value == null)
                {
                    transactions = new List<Transaction>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTransactions(__item);
                }
            }
        }
        public virtual void AddTransactions(IList<Transaction> __items)
        {
            foreach (var __item in __items)
            {
                AddTransactions(__item);
            }
        }

        public virtual void InternalAddTransactions(Transaction __item)
        {
            if (__item == null || disableInternalAdditions) return;
            transactions?.Add(__item);
        }

        public virtual void InternalRemoveTransactions(Transaction __item)
        {
            if (__item == null) return;
            transactions?.Remove(__item);
        }

        public virtual void AddTransactions(Transaction __item)
        {
            if (__item == null) return;
            if (!transactions.Contains(__item))
                InternalAddTransactions(__item);
            if (!__item.Intermediaries.Contains(this))
                __item.AddIntermediaries(this);
        }

        public virtual void AddAtIndexTransactions(int index, Transaction __item)
        {
            if (__item == null) return;
            if (!transactions.Contains(__item))
                transactions.Insert(index, __item);
            if (!__item.Intermediaries.Contains(this))
                __item.AddIntermediaries(this);
        }

        public virtual void RemoveTransactions(Transaction __item)
        {
            if (__item != null)
            {
                if (transactions.Contains(__item))
                    InternalRemoveTransactions(__item);
                if(__item.Intermediaries.Contains(this))
                    __item.RemoveIntermediaries(this);
            }
        }
        public virtual void SetTransactionsAt(Transaction __item, int __index)
        {
            if (__item == null)
            {
                transactions[__index].RemoveIntermediaries(this);
            }
            else
            {
                transactions[__index] = __item;
                if (!__item.Intermediaries.Contains(this))
                    __item.AddIntermediaries(this);
            }
        }

        public virtual void ClearTransactions()
        {
            if (transactions!=null)
            {
                var __itemsToRemove = transactions.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTransactions(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Intermediary class
/// </summary>
/// <returns>New Intermediary object</returns>
/// <remarks></remarks>
        public Intermediary() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (OtherDescription != null && OtherDescription.Length > 100)
            {
                __errors.Add("Length of property 'OtherDescription' cannot be greater than 100.");
            }
            if (Company != null && Company.Length > 100)
            {
                __errors.Add("Length of property 'Company' cannot be greater than 100.");
            }
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (EMail != null && EMail.Length > 100)
            {
                __errors.Add("Length of property 'EMail' cannot be greater than 100.");
            }
            if (GUID != null && GUID.Length > 100)
            {
                __errors.Add("Length of property 'GUID' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'Intermediary' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (OtherDescription?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (IntermediaryType?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Company?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EMail?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (GUID?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [Intermediary] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Intermediary Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Intermediary copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Intermediary)copiedObjects[this];
            copy = copy ?? new Intermediary();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.OtherDescription = this.OtherDescription;
            copy.IntermediaryType = this.IntermediaryType;
            copy.Company = this.Company;
            copy.EMail = this.EMail;
            copy.GUID = this.GUID;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.orders = new List<Order>();
            if(deep && this.orders != null)
            {
                foreach (var __item in this.orders)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOrders(__item);
                        else
                            copy.AddOrders(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOrders((Order)copiedObjects[__item]);
                    }
                }
            }
            copy.transactions = new List<Transaction>();
            if(deep && this.transactions != null)
            {
                foreach (var __item in this.transactions)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTransactions(__item);
                        else
                            copy.AddTransactions(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTransactions((Transaction)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Intermediary;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(Intermediary x, Intermediary y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(Intermediary x, Intermediary y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.Id == default(int) || this.Id.Equals(default(int));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(Intermediary compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
