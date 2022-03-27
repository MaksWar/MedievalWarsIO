namespace Game.Scripts.States
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : StateBase;
    }
}