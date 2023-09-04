

Attack LeftRightGoodnight = new("Left. Right. Goodnight.", 10);
Attack GomuGomuNoPistol = new("Gomu Gomu no Pistol", 20);
Attack Splash = new("Splash", 0);

Enemy Kevin = new("Kevin");


Kevin.AttackList.Add(LeftRightGoodnight);
Kevin.AttackList.Add(GomuGomuNoPistol);
Kevin.AttackList.Add(Splash);

Kevin.RandomAttack();