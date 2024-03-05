variable "token" {
}

data "digitalocean_ssh_key" "ssh_key" {
  name = "WSL"
}


output "droplet_ip" {
  value = digitalocean_droplet.api-filmes.ipv4_address
}