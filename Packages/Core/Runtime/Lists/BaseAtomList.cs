using System.Collections;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    public abstract class BaseAtomList : BaseAtom
    {
        public VoidEvent Cleared;
        protected abstract IList IList { get; }

        public void Clear()
        {
            IList.Clear();
            if (null != Cleared)
            {
                Cleared.Raise();
            }
        }
    }
}