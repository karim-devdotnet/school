# Installation von Docker für Linux

1. `sudo passwd` - school
1. `apt-get update` - root
1. `apt-get upgrade` - root
1. `apt-get install apt-transport-https ca-certificates` - root
1. `apt-key adv --keyserver hkp://p80.pool.sks-keyservers.net:80 --recv-keys 58118E89F3A912897C070ADBF76221572C52609D` - root
1. `echo "deb https://apt.dockerproject.org/repo ubuntu-xenial main" | sudo tee /etc/apt/sources.list.d/docker.list` - root
1. `apt-get update` - root
1. `apt-get install linux-image-extra-$(uname -r) linux-image-extra-virtual` - root
1. `apt-get update` - root
1. `apt-get install docker-engine` - root