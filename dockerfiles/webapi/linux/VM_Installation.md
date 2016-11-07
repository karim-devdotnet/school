# Installation von Docker für Linux

1. `apt-get update`
1. `apt-get upgrade`
1. `apt-get install apt-transport-https ca-certificates`
1. `apt-key adv --keyserver hkp://p80.pool.sks-keyservers.net:80 --recv-keys 58118E89F3A912897C070ADBF76221572C52609D`
1. `echo "deb https://apt.dockerproject.org/repo ubuntu-trusty main" | sudo tee /etc/apt/sources.list.d/docker.list`
1. `apt-get update`
1. `apt-get install linux-image-extra-$(uname -r) linux-image-extra-virtual`
1. `apt-get install init-system-helpers`
1. `apt-get install aufs-tools`
1. `apt-get install cgroupfs-mount`