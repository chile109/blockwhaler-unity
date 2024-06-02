mergeInto(LibraryManager.library, {
  ShootCallback: function (direction, xpos, ypos) {
    window.dispatchReactUnityEvent(
      "ShootCallback",
    );
  },
});

