/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.opentransactions.otapi {

using System;
using System.Runtime.InteropServices;

public class Contact : Displayable {
  private HandleRef swigCPtr;

  internal Contact(IntPtr cPtr, bool cMemoryOwn) : base(otapiPINVOKE.Contact_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Contact obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Contact() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_Contact(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public string gui_label {
    set {
      otapiPINVOKE.Contact_gui_label_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.Contact_gui_label_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string contact_id {
    set {
      otapiPINVOKE.Contact_contact_id_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.Contact_contact_id_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string email {
    set {
      otapiPINVOKE.Contact_email_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.Contact_email_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string memo {
    set {
      otapiPINVOKE.Contact_memo_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.Contact_memo_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string public_key {
    set {
      otapiPINVOKE.Contact_public_key_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.Contact_public_key_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint GetContactNymCount() {
    uint ret = otapiPINVOKE.Contact_GetContactNymCount(swigCPtr);
    return ret;
  }

  public ContactNym GetContactNym(uint nIndex) {
    IntPtr cPtr = otapiPINVOKE.Contact_GetContactNym(swigCPtr, nIndex);
    ContactNym ret = (cPtr == IntPtr.Zero) ? null : new ContactNym(cPtr, false);
    return ret;
  }

  public bool RemoveContactNym(uint nIndexContactNym) {
    bool ret = otapiPINVOKE.Contact_RemoveContactNym(swigCPtr, nIndexContactNym);
    return ret;
  }

  public bool AddContactNym(ContactNym disownObject) {
    bool ret = otapiPINVOKE.Contact_AddContactNym(swigCPtr, ContactNym.getCPtr(disownObject));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetContactAcctCount() {
    uint ret = otapiPINVOKE.Contact_GetContactAcctCount(swigCPtr);
    return ret;
  }

  public ContactAcct GetContactAcct(uint nIndex) {
    IntPtr cPtr = otapiPINVOKE.Contact_GetContactAcct(swigCPtr, nIndex);
    ContactAcct ret = (cPtr == IntPtr.Zero) ? null : new ContactAcct(cPtr, false);
    return ret;
  }

  public bool RemoveContactAcct(uint nIndexContactAcct) {
    bool ret = otapiPINVOKE.Contact_RemoveContactAcct(swigCPtr, nIndexContactAcct);
    return ret;
  }

  public bool AddContactAcct(ContactAcct disownObject) {
    bool ret = otapiPINVOKE.Contact_AddContactAcct(swigCPtr, ContactAcct.getCPtr(disownObject));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static Contact ot_dynamic_cast(Storable pObject) {
    IntPtr cPtr = otapiPINVOKE.Contact_ot_dynamic_cast(Storable.getCPtr(pObject));
    Contact ret = (cPtr == IntPtr.Zero) ? null : new Contact(cPtr, false);
    return ret;
  }

}

}
