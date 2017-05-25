package md59ebb556601005bed46c9d29d9d7a3ebc;


public class BillView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("RestaurantBilling.UI.Droid.Views.BillView, RestaurantBilling.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BillView.class, __md_methods);
	}


	public BillView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BillView.class)
			mono.android.TypeManager.Activate ("RestaurantBilling.UI.Droid.Views.BillView, RestaurantBilling.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
